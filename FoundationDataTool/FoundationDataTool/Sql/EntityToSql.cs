/**********************************************
*说明:
*计算机名称：LENNY
*创建日期：2016/8/7 11:05:18
*作者：乐
*电子邮箱：1941973283@qq.com
/**********************************************/

using FoundationDataTool.Common;
using FoundationDataTool.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FoundationDataTool.Sql
{
    public class EntityToSql
    {
        public static string ToSql(Type type)
        {
            string sql = "CREATE TABLE `{0}` (\r\n{1}\r\n) ENGINE=InnoDB DEFAULT CHARSET=utf8;";

            string tableName = type.Name.ToPlural();
            StringBuilder sbdColumns = new StringBuilder();
            List<PropertyInfo> props = type.GetRuntimeProperties().ToList();

            StringBuilder sbdKeys = new StringBuilder();

            foreach (var prop in props)
            {
                if (!string.IsNullOrEmpty(sbdColumns.ToString()))
                {
                    sbdColumns.Append("\r\n");
                }
                IEnumerable<KeyAttribute> KeyAttributes = prop.GetCustomAttributes<KeyAttribute>();
                if (KeyAttributes != null & KeyAttributes.Count() > 0)
                {
                    sbdKeys.AppendFormat("PRIMARY KEY (`{0}`)", prop.Name);
                }
                StringBuilder columnSbd = new StringBuilder("");
                string typeValue = "";
                DBCsharpTypeDict.MysqlTypeDict.TryGetValue(prop.PropertyType.Name, out typeValue);
                if (prop.PropertyType.GetTypeInfo().IsEnum)
                    typeValue = "int";
                if (string.IsNullOrEmpty(typeValue))
                    typeValue = "varchar(255)";
                columnSbd.AppendFormat("`{0}` {1},", prop.Name, typeValue);
                //if (!props.IsLast(prop))
                //    columnSbd.Append(",\r\n");
                sbdColumns.Append(columnSbd.ToString());
            }
            if (string.IsNullOrEmpty(sbdKeys.ToString()))
            {
                sbdColumns.Remove(sbdColumns.Length - 1, 1);
            }
            else
            {
                sbdColumns.AppendFormat("\r\n {0}", sbdKeys);
            }


            return string.Format(sql, tableName, sbdColumns.ToString());
        }
    }
}
