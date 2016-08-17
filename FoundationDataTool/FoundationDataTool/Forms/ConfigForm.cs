using EntityFramework.Extensions;
using FoundationDataTool.Models;
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
    public partial class ConfigForm : BaseForm
    {
        public ConfigForm()
        {
            base.Title = "配置管理";
            InitializeComponent();
        }

        public void LoadConfigList()
        {
            List<Config> configs = new List<Config>();

            using (DB db = new DB())
            {
                configs = db.Configs.ToList();
            }

            dgwConfig.DataSource = configs;
            dgwConfig.Columns[0].HeaderText = "Id";
            dgwConfig.Columns[1].HeaderText = "配置名称";
            dgwConfig.Columns[2].HeaderText = "配置值";
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            LoadConfigList();
        }


        private void dgwConfig_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    dgwConfig.ClearSelection();
                    dgwConfig.Rows[e.RowIndex].Selected = true;
                    dgwConfig.CurrentCell = dgwConfig.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    this.ConfigListContextMenu.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        /// <summary>
        ///  编辑配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedId = this.dgwConfig[0, this.dgwConfig.CurrentCell.RowIndex].Value.ToString();
            EditConfigForm form = new EditConfigForm(Convert.ToInt32(selectedId));
            form.Owner = this;
            form.Show();
        }

        private void deleteConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedId = this.dgwConfig[0, this.dgwConfig.CurrentCell.RowIndex].Value.ToString();
            int id = Convert.ToInt32(selectedId);
            using (DB db = new DB())
            {
                //var config = db.Configs.Find();
                bool flag = db.Configs.Where(x => x.Id == id).Delete() > 0;
                if (flag)
                {
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
                LoadConfigList();
            }
        }

        private void btnAddConfig_Click(object sender, EventArgs e)
        {
            ///打开子窗体
            AddConfigForm form = new AddConfigForm();
            form.Owner = this;
            form.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadConfigList();
        }

        /// <summary>
        /// 快捷键
        /// 注意：把 Form 的 KeyPreview 属性设为 True 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
            {
                btnAddConfig_Click(this, EventArgs.Empty);
            }
        }
    }
}
