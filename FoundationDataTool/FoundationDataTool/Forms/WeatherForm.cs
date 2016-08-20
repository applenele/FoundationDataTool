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
            cbmProvince.Items.Add(listItem0);
            foreach (var item in list)
            {
                ListItem listItem = new ListItem(item.city_id, item.name);
                cbmProvince.Items.Add(listItem);
            }

            //设置默认选择项，DropDownList会默认选择第一项。
            // cbmCity.SelectedIndex = 0;//设置第一项为默认选择项。
            cbmProvince.SelectedItem = listItem0;//设置指定的项为默认选择项

        }

        /// <summary>
        /// 选各种事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbmCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbmCounty.Items.Clear();
            cbmCounty.Text = "";
            if (cbmCity.SelectedIndex != 0)
            {
                ListItem provinceItem = cbmProvince.SelectedItem as ListItem;
                ListItem cityItem = cbmCity.SelectedItem as ListItem;

                var province = list.Where(x => x.city_id == provinceItem.ID).FirstOrDefault();
                var city = province.list.Where(x => x.city_id == cityItem.ID).FirstOrDefault();

                if (city.list != null)
                {
                    ListItem listItem0 = new ListItem("0", "区");
                    cbmCounty.Items.Add(listItem0);
                    foreach (var county in city.list)
                    {
                        ListItem listItem = new ListItem(county.city_id, county.name);
                        cbmCounty.Items.Add(listItem);
                    }
                    cbmCounty.SelectedItem = listItem0;//设置指定的项为默认选择项
                }
            }
        }

        private void btnGetWeather_Click(object sender, EventArgs e)
        {
            string city = "";
            if (cbmCounty.SelectedIndex != 0)
            {
                ListItem countyItem = cbmCounty.SelectedItem as ListItem;
                if (countyItem != null)
                {
                    city = countyItem.ID;
                }
                else
                {
                    ListItem cityItem = cbmCity.SelectedItem as ListItem;
                    city = cityItem.ID;
                }

            }
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
                MessageBox.Show("获取天气失败:" + result.msg);
            }
        }

        private void cbmProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbmCity.Items.Clear();
            cbmCity.Text = "";
            if (cbmProvince.SelectedIndex != 0)
            {
                ListItem item = cbmProvince.SelectedItem as ListItem;
                var province = list.Where(x => x.city_id == item.ID).FirstOrDefault();

                ListItem listItem0 = new ListItem("0", "市");
                cbmCity.Items.Add(listItem0);
                foreach (var city in province.list)
                {
                    ListItem listItem = new ListItem(city.city_id, city.name);
                    cbmCity.Items.Add(listItem);
                }
                cbmCity.SelectedItem = listItem0;//设置指定的项为默认选择项
            }

        }


    }
}
