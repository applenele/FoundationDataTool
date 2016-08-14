using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoundationDataTool.Forms
{
    /// <summary>
    /// 窗体基类
    /// </summary>
    public partial class BaseForm : Form
    {
        public string Title = "";
        public BaseForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 子类继承 先执行父类 的这个方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BaseForm_Load(object sender, EventArgs e)
        {
            ///从镶嵌资源中获取图片 设置图标
            Assembly asm = Assembly.GetExecutingAssembly();
            Stream imgStream = asm.GetManifestResourceStream("FoundationDataTool.Resource.Images.icon.ico");
            this.Icon = new Icon(imgStream);
            this.Text = Title;
        }
    }
}
