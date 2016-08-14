/**********************************************
*说明:
*计算机名称：LENNY
*创建日期：2016/8/13 22:29:56
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
    public class TableInfo
    {
        [DataMapping(Name = "tableName")]
        public string TableName { set; get; }
    }
}
