/**********************************************
*说明:
*计算机名称：LENNY
*创建日期：2016/8/7 11:50:46
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
    [Table("SecondryCode")]
    public class SecondryCode
    {
        [Column("id")]
        public int Id { set; get; }

        [Column("type")]
        public string Type { set; get; }

        [Column("value")]
        public string Value { set; get; }

        [Column("name")]
        public string Name { set; get; }
    }
}
