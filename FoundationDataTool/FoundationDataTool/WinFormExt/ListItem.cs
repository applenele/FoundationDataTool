/**********************************************
*说明:
*计算机名称：LENNY
*创建日期：2016/8/7 15:40:29
*作者：乐
*电子邮箱：1941973283@qq.com
/**********************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationDataTool.WinFormExt
{
    /// <summary>
    /// 选择项类，用于ComboBox或者ListBox添加项
    /// </summary>
    public class ListItem
    {
        private string id = string.Empty;
        private string name = string.Empty;
        public ListItem(string sid, string sname)
        {
            id = sid;
            name = sname;
        }
        public override string ToString()
        {
            return this.name;
        }
        public string ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
    }
}
