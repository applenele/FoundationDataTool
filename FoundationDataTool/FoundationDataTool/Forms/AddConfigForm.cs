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
    public partial class AddConfigForm : BaseForm
    {
        public AddConfigForm()
        {
            base.Title = "增加配置";
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
            //获取父窗口 调用窗口的更新方法
            ConfigForm form = (ConfigForm)this.Owner;
            form.LoadConfigList();

            //关闭该窗体
            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddConfigForm_Load(object sender, EventArgs e)
        {

        }
    }
}
