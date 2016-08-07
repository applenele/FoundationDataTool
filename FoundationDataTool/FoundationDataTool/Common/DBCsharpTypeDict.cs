using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoundationDataTool.Common
{
    public class DBCsharpTypeDict
    {

        public static Dictionary<string, string> MysqlTypeDict = new Dictionary<string, string>
        {
            ["Int32"] = "int",
            ["String"] = "varchar(255)",
            ["Boolean"] = "BOOL",
            ["Double"] = "DOUBLE",
            ["Decimal"] = "DECIMAL",
            ["DateTime"] = "DATETIME ",
            ["Single"] = "FLOAT",
            ["Char"] = "CHARACTER",
        };

        public static Dictionary<string, string> SqliteTypeDict = new Dictionary<string, string>
        {
            ["Int32"] = "INTEGER",
            ["String"] = "TEXT",
            ["Boolean"] = "BOOL",
            ["Double"] = "REAL",
            ["Decimal"] = "REAL",
            ["DateTime"] = "DATETIME ",
            ["Single"] = "REAL",
            ["Char"] = "TEXT",
        };
    }
}
