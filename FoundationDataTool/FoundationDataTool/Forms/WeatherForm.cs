using FoundationDataTool.DataModels;
using FoundationDataTool.DataModels.DataResult;
using FoundationDataTool.Helper;
using FoundationDataTool.Models;
using FoundationDataTool.WinFormExt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoundationDataTool.Forms
{
    public partial class WeatherForm : BaseForm
    {
        public List<CityCode> list { set; get; }

        public WeatherForm()
        {
            base.Title = "获取天气";
            InitializeComponent();
        }

        private void WeatherForm_Load(object sender, EventArgs e)
        {
            string str;
            using (StreamReader sr = new StreamReader(Application.StartupPath + @"\MetaData\CityCode.json", false))
            {
                str = sr.ReadToEnd().ToString();
            }
            list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CityCode>>(str);

            ListItem listItem0 = new ListItem("0", "省");
            cbmCity.Items.Add(listItem0);
            foreach (var item in list)
            {
                ListItem listItem = new ListItem(item.city_id, item.name);
                cbmCity.Items.Add(listItem);
            }

            //设置默认选择项，DropDownList会默认选择第一项。
            // cbmCity.SelectedIndex = 0;//设置第一项为默认选择项。
            cbmCity.SelectedItem = listItem0;//设置指定的项为默认选择项

        }

        /// <summary>
        /// 选各种事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbmCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmCity.SelectedIndex != 0)
            {
                cbmCounty.Items.Clear();
                ListItem item = cbmCity.SelectedItem as ListItem;

                var countyList = list.Where(x => x.city_id == item.ID).FirstOrDefault();

                ListItem listItem0 = new ListItem("0", "市");
                cbmCounty.Items.Add(listItem0);
                foreach (var county in countyList.list)
                {
                    ListItem listItem = new ListItem(county.city_id, county.name);
                    cbmCounty.Items.Add(listItem);
                }
                cbmCounty.SelectedItem = listItem0;
            }
        }

        private void btnGetWeather_Click(object sender, EventArgs e)
        {
            string city = "";
            if (cbmCounty.SelectedIndex != 0)
            {
                ListItem item = cbmCounty.SelectedItem as ListItem;
                city = item.ID;
            }
            //else if (cbmCity.SelectedIndex != 0)
            //{
            //    ListItem item = cbmCity.SelectedItem as ListItem;
            //    city = item.ID;
            //}
            else
            {
                MessageBox.Show("请选择城市");
                return;
            }

            var url = "";
            string paramStr = "";
            using (DB db = new DB())
            {
                var config = db.Configs.Where(x => x.ConfigName == "weatherapi").FirstOrDefault();
                if (config == null)
                {
                    MessageBox.Show("没有配置获取天气的url");
                    return;
                }
                url = config.ConfigValue;

                var configWeatherApiKey = db.Configs.Where(x => x.ConfigName == "weatherApiKey").FirstOrDefault();

                List<string> paramList = new List<string>();
                paramList.Add("city=" + city);
                paramList.Add("key=" + configWeatherApiKey.ConfigValue);
                paramStr = string.Join("&", paramList);
            }
            string _result = HttpHelper.HttpGet(url, paramStr);
            WeatherResult result = Newtonsoft.Json.JsonConvert.DeserializeObject<WeatherResult>(_result);

            StringBuilder sbd = new StringBuilder();
            if (result.msg == "Sucess")
            {
                foreach (var item in result.data.list)
                {
                    sbd.AppendFormat("{0}\r\n", item.ToString());
                }
                MessageBox.Show(sbd.ToString());
            }
            else
            {
                MessageBox.Show("获取天气失败:"+result.msg);
            }
        }
    }
}
