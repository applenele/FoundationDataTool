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
    public partial class AddConfigForm : Form
    {
        public AddConfigForm()
        {
            InitializeComponent();
        }

        private void btnAddConfig_Click(object sender, EventArgs e)
        {
            string configName = txtConfigName.Text;
            string configValue = txtConfigValue.Text;

            using (DB db = new DB())
            {
                Config config = new Config { ConfigName = configName, ConfigValue = configValue };
                db.Configs.Add(config);
                bool flag = db.SaveChanges() > 0;
                if (flag)
                {
                    MessageBox.Show("增加配置成功");
                }
                else
                {
                    MessageBox.Show("增加配置失败");
                }
            }

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
