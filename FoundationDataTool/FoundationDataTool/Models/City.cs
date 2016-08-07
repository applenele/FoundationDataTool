/**********************************************
*说明:
*计算机名称：LENNY
*创建日期：2016/8/7 11:43:34
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
    [Table("City")]
    public class City
    {
        /// <summary>
        /// 获取或设置 编号
        /// </summary>
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// 获取或设置 名称
        /// </summary>
        [Column("name")]
        public string Name { get; set; }

        /// <summary>
        /// 获取或设置 区域代码
        /// </summary>
        [Column("division_code")]
        public string DivisionCode { get; set; }

        /// <summary>
        /// 获取或设置 所属省份
        /// </summary>
        [Column("province_id")]
        public int ProvinceId { get; set; }
    }
}
