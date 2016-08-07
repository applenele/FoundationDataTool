/**********************************************
*说明:
*计算机名称：LENNY
*创建日期：2016/8/7 13:38:59
*作者：乐
*电子邮箱：1941973283@qq.com
/**********************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationDataTool.Models
{
    [Table("Province")]
    public class Province
    {
        /// <summary>
        /// 获取或设置 编号
        /// </summary>
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// 获取或设置 省份名称
        /// </summary>
        [Column("name")]
        public string Name { get; set; }
    }
}
