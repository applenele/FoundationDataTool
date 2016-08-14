/**********************************************
*说明:
*计算机名称：LENNY
*创建日期：2016/8/14 12:28:16
*作者：乐
*电子邮箱：1941973283@qq.com
/**********************************************/

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationDataTool.Helper
{
    public class ConfigurationHelper
    {
        public static string GetValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static string GetConnectionValue(string key)
        {
            return ConfigurationManager.ConnectionStrings[key].ConnectionString;
        }
    }
}
