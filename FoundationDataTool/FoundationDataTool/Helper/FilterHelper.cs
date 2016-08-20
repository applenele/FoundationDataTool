﻿/**********************************************
*说明:
*计算机名称：LENNY
*创建日期：2016/8/20 19:49:02
*作者：乐
*电子邮箱：1941973283@qq.com
/**********************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace FoundationDataTool.Helper
{
    public class FilterHelper
    {
        /// <summary>
        /// 返回过滤掉所有的Html标签后的字符串
        /// </summary>
        /// <param name="html">Html源码</param>
        /// <returns>过滤Html标签后的字符串</returns>
        public static string FilterAllHtml(string html)
        {
            string filter = "<[\\s\\S]*?>";
            html = URLDecode(html);
            if (Regex.IsMatch(html, filter))
            {
                html = Regex.Replace(html, filter, "");
            }
            filter = "[<>][\\s\\S]*?";
            if (Regex.IsMatch(html, filter))
            {
                html = Regex.Replace(html, filter, "");
            }
            return html.Replace("\r\n", "").Replace("\r", "").Replace("\n", "").Replace("\t", "");
        }

        /// <summary>
        /// 检查是否有Html标签
        /// </summary>
        /// <param name="html">Html源码</param>
        /// <returns>存在为True</returns>
        public static bool CheckHtml(string html)
        {
            html = URLDecode(html);
            string filter = "<[\\s\\S]*?>";

            if (Regex.IsMatch(html, filter))
            {
                return true;
            }
            filter = "[<>][\\s\\S]*?";
            if (Regex.IsMatch(html, filter))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 对Html进行解码
        /// </summary>
        /// <param name="html">html</param>
        /// <returns></returns>
        private static string URLDecode(string html)
        {
            return HttpUtility.UrlDecode(html, Encoding.UTF8);
        }
    }
}
