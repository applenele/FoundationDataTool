/**********************************************
*说明:
*计算机名称：LENNY
*创建日期：2016/8/14 1:05:59
*作者：乐
*电子邮箱：1941973283@qq.com
/**********************************************/

using FoundationDataTool.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationDataTool.DataModels.DataBase
{
    public class ColumnInfo
    {
        [DataMapping(Name = "columnName")]
        public string ColumnName { set; get; }

        [DataMapping(Name = "columnType")]
        public string ColumnType { set; get; }

        [DataMapping(Name ="dataType")]
        public string DataType { set; get; }
    }
}
