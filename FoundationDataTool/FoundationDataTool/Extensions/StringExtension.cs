using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FoundationDataTool.Extensions
{
    public static class StringExtension
    {
        /// <summary>
        /// 单词变成单数形式
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string ToSingular(this string word)
        {
            Regex plural1 = new Regex("(?<keep>[^aeiou])ies$");
            Regex plural2 = new Regex("(?<keep>[aeiou]y)s$");
            Regex plural3 = new Regex("(?<keep>[sxzh])es$");
            Regex plural4 = new Regex("(?<keep>[^sxzhyu])s$");

            if (plural1.IsMatch(word))
                return plural1.Replace(word, "${keep}y");
            else if (plural2.IsMatch(word))
                return plural2.Replace(word, "${keep}");
            else if (plural3.IsMatch(word))
                return plural3.Replace(word, "${keep}");
            else if (plural4.IsMatch(word))
                return plural4.Replace(word, "${keep}");

            return word;
        }
        /// <summary>
        /// 单词变成复数形式
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string ToPlural(this string word)
        {
            Regex plural1 = new Regex("(?<keep>[^aeiou])y$");
            Regex plural2 = new Regex("(?<keep>[aeiou]y)$");
            Regex plural3 = new Regex("(?<keep>[sxzh])$");
            Regex plural4 = new Regex("(?<keep>[^sxzhy])$");

            if (plural1.IsMatch(word))
                return plural1.Replace(word, "${keep}ies");
            else if (plural2.IsMatch(word))
                return plural2.Replace(word, "${keep}s");
            else if (plural3.IsMatch(word))
                return plural3.Replace(word, "${keep}es");
            else if (plural4.IsMatch(word))
                return plural4.Replace(word, "${keep}s");

            return word;
        }


        /// <summary>
        /// 首字母大写
        /// </summary>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        public static string FirstLetterToUpper(this string inputValue)
        {
            return System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(inputValue);
        }


        /// <summary>
        /// 验证是否为IP地址
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsIP(this string inputValue)
        {
            /// <summary>
            /// IP地址判断
            /// </summary>
            string regexIP = @"^(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])$";
            return Regex.IsMatch(inputValue, regexIP);
        }

        /// <summary>
        /// 判断输入的字符串是否是一个合法的手机号
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsMobilePhone(this string input)
        {
            Regex regex = new Regex("^1[3458]\\d{9}$");
            return regex.IsMatch(input);

        }


        /// <summary>
        /// 取Href值
        /// </summary>
        /// <param name="source">〈a〉</param>
        /// <returns>Href</returns>
        public static string ParseHref(this string source)
        {
            string result = string.Empty;
            /// <summary>
            /// 匹配所有的href标签href=["'\s]?(.*?)["'\s>]
            /// </summary>
            string rxgethref = "href=[" + "\"" + @"'\s]?(.*?)[" + "\"" + @"'\s>]";
            if (Regex.IsMatch(source, rxgethref))
            {
                Match ms = Regex.Match(source, rxgethref);
                result = ms.Groups[1].Value;
                result = result.Replace("\"", string.Empty);
                result = result.Replace("'", string.Empty);
            }
            return result;
        }


        /// <summary>
        /// 去掉所有的Script标签
        /// </summary>
        /// <param name="returnstr">Html代码</param>
        /// <returns>结果</returns>
        public static string GetNullScriptHtml(this string returnstr)
        {
            /// <summary>
            /// 匹配所有的Script标签
            /// </summary>
            string rxScritp = @"<script[^>]*?>.*?</script>";
            returnstr = Regex.Replace(returnstr, rxScritp, "");
            return returnstr;
        }

        


    }
}
