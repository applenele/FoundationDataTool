using FoundationDataTool.Common;
using FoundationDataTool.DataModels;
using FoundationDataTool.Forms;
using FoundationDataTool.Models;
using FoundationDataTool.Tool.MySql;
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

namespace FoundationDataTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        ///   加载主页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            
            ListItem listItem0 = new ListItem("0", "选择导入的数据类型");
            ListItem listItem1 = new ListItem("1", "省");
            ListItem listItem2 = new ListItem("2", "市");
            ListItem listItem3 = new ListItem("3", "区");
            ListItem listItem4 = new ListItem("4", "镇");
            ListItem listItem5 = new ListItem("5", "村");

            comboBox1.Items.Add(listItem0);
            comboBox1.Items.Add(listItem1);
            comboBox1.Items.Add(listItem2);
            comboBox1.Items.Add(listItem3);
            comboBox1.Items.Add(listItem4);
            comboBox1.Items.Add(listItem5);
            //设置默认选择项，DropDownList会默认选择第一项。
            comboBox1.SelectedIndex = 0;//设置第一项为默认选择项。
            comboBox1.SelectedItem = listItem1;//设置指定的项为默认选择项
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ListItem item = comboBox1.SelectedItem as ListItem;
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.Title = "打开文件";
            oFD.ShowHelp = true;
            oFD.Filter = "文本文件|*.txt|RTF文件|*.rtf|所有文件|*.*";//过滤格式
            oFD.FilterIndex = 1;                                    //格式索引
            oFD.RestoreDirectory = false;
            oFD.InitialDirectory = "c:\\";                          //默认路径
            oFD.Multiselect = true;                                 //是否多选
            if (oFD.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = File.OpenRead(oFD.FileName))  //打开txt文件
                {
                    using (StreamReader stmReader = new StreamReader(fileStream, System.Text.Encoding.Default))  //读取txt文件
                    {
                        string str = stmReader.ReadToEnd();
                        switch (item.ID)
                        {
                            case "1":
                                List<FoundationDataTool.Models.Province> provinces = Newtonsoft.Json.JsonConvert.DeserializeObject<List<FoundationDataTool.Models.Province>>(str);
                                EFCommon<Models.Province>.BatchAdd(provinces);
                                break;
                            case "2":
                                List<FoundationDataTool.DataModels.City> cities = Newtonsoft.Json.JsonConvert.DeserializeObject<List<FoundationDataTool.DataModels.City>>(str);
                                List<Models.City> _cities = cities.Select(x => new Models.City { Id = x.Id, Name = x.Name, DivisionCode = x.DivisionCode, ProvinceId = x.Province.Id }).ToList();
                                EFCommon<Models.City>.BatchAdd(_cities);
                                break;
                            case "3":
                                List<FoundationDataTool.DataModels.County> counties = Newtonsoft.Json.JsonConvert.DeserializeObject<List<FoundationDataTool.DataModels.County>>(str);
                                List<Models.County> _counties = counties.Select(x => new Models.County { Id = x.Id, Name = x.Name, DivisionCode = x.DivisionCode, CityId = x.City.Id }).ToList();
                                EFCommon<Models.County>.BatchAdd(_counties);
                                break;
                            case "4":
                                List<FoundationDataTool.DataModels.Town> towns = Newtonsoft.Json.JsonConvert.DeserializeObject<List<FoundationDataTool.DataModels.Town>>(str);
                                List<Models.Town> _towns = towns.Select(x => new Models.Town { Id = x.Id, Name = x.Name, DivisionCode = x.DivisionCode, CountyId = x.County.Id }).ToList();
                                EFCommon<Models.Town>.BatchAdd(_towns);
                                break;
                            case "5":
                                List<FoundationDataTool.DataModels.Village> villages = Newtonsoft.Json.JsonConvert.DeserializeObject<List<FoundationDataTool.DataModels.Village>>(str);
                                List<Models.Village> _village = villages.Select(x => new Models.Village { Id = x.Id, Name = x.Name, DivisionCode = x.DivisionCode, TownId = x.Town.Id, Type = x.Type }).ToList();
                                EFCommon<Models.Village>.BatchAdd(_village);
                                break;
                            default:
                                break;
                        }


                    }
                }
            }
        }

        /// <summary>
        /// 查看地域信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 查看地域信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Area areaForm = new Forms.Area();

            areaForm.Show();
        }

        /// <summary>
        /// 链接到数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 连接ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 实体生成器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModelGenerate form = new ModelGenerate();
            form.Show();
        }
    }
}
