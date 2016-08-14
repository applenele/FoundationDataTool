/**********************************************
*说明:
*计算机名称：LENNY
*创建日期：2016/8/13 22:01:30
*作者：乐
*电子邮箱：1941973283@qq.com
/**********************************************/

using FoundationDataTool.DataModels.DataBase;
using FoundationDataTool.Helper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationDataTool.Tool.MySql
{
    public sealed partial class MySqlHelper
    {
        /// <summary>
        /// 得到schma 
        /// </summary>
        /// <returns></returns>
        public string GetSchma()
        {
            string schma = "";
            string sql = "SELECT SCHEMA() as schma";
            DataTable dt = ExecuteDataTable(this.ConnectionString, sql);
            schma = dt.Rows.Cast<DataRow>().FirstOrDefault().Field<string>("schma");
            return schma;
        }

        /// <summary>
        /// 得到全部的表
        /// </summary>
        /// <param name="schma"></param>
        /// <returns></returns>
        public List<string> GetTables(string schma)
        {
            string sql = string.Format("select table_name as tableName from information_schema.tables where table_schema='{0}' and table_type='base table';", schma);
            DataTable dt = ExecuteDataTable(sql);
            List<TableInfo> tableList = dt.ToList<TableInfo>();
            return tableList.Select(x => x.TableName).ToList();
        }

        /// <summary>
        /// 得到表中的字段
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public List<ColumnInfo> GetColumns(string table, string schema)
        {
            string sql = string.Format("select COLUMN_NAME as columnName,COLUMN_TYPE AS columnType,	DATA_TYPE AS dataType from information_schema.COLUMNS where table_name = '{0}' and TABLE_SCHEMA='{1}';", table, schema);
            DataTable dt = ExecuteDataTable(sql);
            List<ColumnInfo> columnList = dt.ToList<ColumnInfo>();
            return columnList;
        }
    }
}
