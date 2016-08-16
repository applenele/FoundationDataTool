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
    public partial class EditConfigForm : BaseForm
    {
        public int id { set; get; }

        public EditConfigForm(int id)
        {
            base.Title = "编辑配置";
            this.id = id;
            InitializeComponent();
        }

        private void EditConfigForm_Load(object sender, EventArgs e)
        {
            using (DB db = new DB())
            {
                var config = db.Configs.Find(id);
                txtConfigValue.Text = config.ConfigValue;
                txtConfigName.Text = config.ConfigName;
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string configName = txtConfigName.Text;
            string configValue = txtConfigValue.Text;

            using (DB db = new DB())
            {
                db.Configs.Where(x => x.Id == id).Update(x => new Models.Config { ConfigValue = configValue, ConfigName = configName });
            }

            ConfigForm form = (ConfigForm)this.Owner;
            form.LoadConfigList();

            this.Close();
        }
    }
}
