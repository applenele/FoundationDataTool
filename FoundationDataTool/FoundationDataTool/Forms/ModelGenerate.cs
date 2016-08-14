using FoundationDataTool.DataModels.DataBase;
using FoundationDataTool.Extensions;
using FoundationDataTool.Tool.MySql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoundationDataTool.Forms
{
    public partial class ModelGenerate : Form
    {
        public ModelGenerate()
        {
            InitializeComponent();
        }


        private void ModelGenerate_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 链接到数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkToMySql_Click(object sender, EventArgs e)
        {
            string connectionString = txtConnectstring.Text;

            MySqlHelper helper = new MySqlHelper(connectionString);
            bool flag = helper.IsConnect();
            string schma = helper.GetSchma();
            if (flag)
            {
                MessageBox.Show("连接成功");
                List<string> tables = helper.GetTables(schma);
                foreach (var table in tables)
                {
                    chlTables.Items.Add(table);
                }
            }
            else
            {
                MessageBox.Show("连接失败");
            }

        }

        private void txtTables_Click(object sender, EventArgs e)
        {
            MessageBox.Show(e.ToString());
        }





        private void btnGenerateModel_Click(object sender, EventArgs e)
        {
            List<string> tables = new List<string>();
            for (int i = 0; i < chlTables.Items.Count; i++)
            {
                if (chlTables.GetItemChecked(i))//先判断是否被选中
                {
                    tables.Add(chlTables.GetItemText(chlTables.Items[i]));
                }
            }
            List<string> modelList = new List<string>();
            modelList = GenerateModels(tables);

            txtResult.Text = string.Join(Environment.NewLine, modelList.ToArray());
        }

        /// <summary>
        /// 生成实体
        /// </summary>
        /// <param name="tables"></param>
        /// <param name="schema"></param>
        /// <returns></returns>
        public List<string> GenerateModels(List<string> tables)
        {
            string connectionString = txtConnectstring.Text;
            List<string> modelList = new List<string>();
            MySqlHelper helper = new MySqlHelper(connectionString);
            string schema = helper.GetSchma();
            foreach (var table in tables)
            {
                List<ColumnInfo> columns = helper.GetColumns(table, schema);
                modelList.Add(GenerateModel(table, columns));
            }
            return modelList;
        }

        public string GenerateModel(string table, List<ColumnInfo> columns)
        {
            StringBuilder sb = new StringBuilder();
            table = table.Replace("-", "").Replace("-", "").Replace("__", "");
            sb.Append("    public class ");
            sb.Append(table.FirstLetterToUpper());
            sb.Append(Environment.NewLine);
            sb.Append(Createplace(4));
            sb.Append("{");
            sb.Append(Environment.NewLine);
            foreach (ColumnInfo column in columns)
            {
                sb.Append(Createplace(8));
                sb.Append("public");
                sb.Append(" ");
                sb.Append(findModelsType(column.ColumnType));
                sb.Append(" ");
                sb.Append(column.ColumnName.FirstLetterToUpper());
                sb.Append(" {  get;  set; }  ");
                sb.Append(Environment.NewLine);
            }
            sb.Append(Createplace(4));
            sb.Append("}");

            return sb.ToString();
        }

        /// <summary>
        /// 得到实体对应的类型
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private string findModelsType(string type)
        {
            string outer = "";
            Common.DBCsharpTypeDict.MysqlToCsharpTypeDict.TryGetValue(type, out outer);
            if (string.IsNullOrEmpty(outer))
            {
                outer = "string";
            }
            return outer;
        }

        #region 转换空格
        private string Createplace(int a)
        {
            return new string(' ', a);
        }
        #endregion



    }
}
