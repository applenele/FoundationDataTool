using FoundationDataTool.DataModels.DataBase;
using FoundationDataTool.Extensions;
using FoundationDataTool.Helper;
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
    public partial class ModelGenerate : BaseForm
    {

        public static string connectionString = "";

        public ModelGenerate()
        {
            base.Title = "实体生成器";
            InitializeComponent();
        }


        private void ModelGenerate_Load(object sender, EventArgs e)
        {
            txtHost.Text = ConfigurationHelper.GetValue("MysqlDefaultHost");
            txtPort.Text = ConfigurationHelper.GetValue("MysqlDefaultPort");
            txtUser.Text = ConfigurationHelper.GetValue("MysqlDefaultUser");
            txtPassword.Text = ConfigurationHelper.GetValue("MysqlDefaultPassword");
            txtDB.Text = ConfigurationHelper.GetValue("MysqlDefaultDB");
        }

        /// <summary>
        /// 链接到数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkToMySql_Click(object sender, EventArgs e)
        {
            connectionString = txtConnectstring.Text;
            chlTables.Items.Clear();
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
            if (chlTables.Items.Count == 0 || chlTables.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择表");
            }
            else
            {
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
        }

        /// <summary>
        /// 生成实体
        /// </summary>
        /// <param name="tables"></param>
        /// <param name="schema"></param>
        /// <returns></returns>
        public List<string> GenerateModels(List<string> tables)
        {
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
            string _table = table.Trim('-').Trim('_').Replace("__", "");
            sb.Append(Createplace(4));
            sb.AppendFormat("[Table({1}{0}{1})]", table, "\"");
            sb.Append(Environment.NewLine);
            sb.Append(Createplace(4));
            sb.Append("public class ");
            sb.Append(GetHumpName(_table));
            sb.Append(Environment.NewLine);
            sb.Append(Createplace(4));
            sb.Append("{");
            sb.Append(Environment.NewLine);
            foreach (ColumnInfo column in columns)
            {
                sb.Append(Createplace(8));
                sb.AppendFormat("[Column({1}{0}{1})]", column.ColumnName, "\"");
                sb.Append(Environment.NewLine);
                sb.Append(Createplace(8));
                sb.Append("public");
                sb.Append(" ");
                sb.Append(findModelsType(column.ColumnType));
                sb.Append(" ");
                sb.Append(GetHumpName(column.ColumnName));
                sb.Append(" {  get;  set; }  ");
                sb.Append(Environment.NewLine);
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

        /// <summary>
        /// 得到驼峰名
        /// </summary>
        /// <returns></returns>
        public string GetHumpName(string name, char separator = '_')
        {
            name = string.Concat(name.Split(separator).Select(x => x.FirstLetterToUpper()));
            return name;
        }

        /// <summary>
        /// 第二种方式链接数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLinkDB2_Click(object sender, EventArgs e)
        {
            string host = txtHost.Text;
            string port = txtPort.Text;
            string user = txtUser.Text;
            string password = txtPassword.Text;
            string db = txtDB.Text;
            StringBuilder sbd = new StringBuilder();

            sbd.AppendFormat("Server={0}", host);
            sbd.Append(";");
            sbd.AppendFormat("Port={0}", port);
            sbd.Append(";");
            sbd.AppendFormat("database={0}", db);
            sbd.Append(";");
            sbd.AppendFormat("uid={0}", user);
            sbd.Append(";");
            sbd.AppendFormat("pwd={0}", password);
            sbd.Append(";");

            connectionString = sbd.ToString();

            chlTables.Items.Clear();
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
    }
}
