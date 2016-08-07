/**********************************************
*说明:
*计算机名称：LENNY
*创建日期：2016/8/7 17:29:53
*作者：乐
*电子邮箱：1941973283@qq.com
/**********************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationDataTool.DataModels
{
    /// <summary>
    /// 乡镇
    /// </summary>
    public class Town
    {
        /// <summary>
        /// 获取或设置 编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 获取或设置 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 获取或设置 区域代码
        /// </summary>
        public string DivisionCode { get; set; }

        /// <summary>
        /// 获取或设置 所属县级
        /// </summary>
        public County County { get; set; }
    }
}
