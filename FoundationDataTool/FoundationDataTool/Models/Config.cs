/**********************************************
*说明:
*计算机名称：LENNY
*创建日期：2016/8/16 23:47:36
*作者：乐
*电子邮箱：1941973283@qq.com
/**********************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationDataTool.Models
{
    public class Config
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { set; get; }

        /// <summary>
        /// 配置名称
        /// </summary>
        public string ConfigName { set; get; }

        /// <summary>
        /// 配置的值
        /// </summary>
        public string ConfigValue { set; get; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { set; get; }
    }
}
