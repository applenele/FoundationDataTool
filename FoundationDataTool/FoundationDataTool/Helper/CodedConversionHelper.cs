/**********************************************
*说明:
*计算机名称：LENNY
*创建日期：2016/8/20 19:54:48
*作者：乐
*电子邮箱：1941973283@qq.com
/**********************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationDataTool.Helper
{
    /// <summary>
    /// 编码转化帮助类
    /// </summary>
    public class CodedConversionHelper
    {
        /// <summary>
        /// 将中文转化为Unicode字符串
        /// </summary>
        /// <param name="chinese"></param>
        /// <returns></returns>
        public static string ChineseToUnicode(string chinese)
        {
            string outStr = string.Empty;
            if (!string.IsNullOrEmpty(chinese))
            {
                for (int i = 0; i < chinese.Length; i++)
                {
                    //将中文字符转为10进制整数，然后转为16进制unicode字符
                    outStr += "\\u" + ((int)chinese[i]).ToString("x");
                }
            }
            return outStr;
        }
        /// <summary>
        /// 将Unicode串字符转化为中文字符串
        /// </summary>
        /// <param name="unicode"></param>
        /// <returns></returns>
        public static string UnicodeToChinese(string unicode)
        {
            string outStr = string.Empty;
            if (!string.IsNullOrEmpty(unicode))
            {
                string[] strlist = unicode.Replace("\\", "").Split('u');
                try
                {
                    for (int i = 1; i < strlist.Length; i++)
                    {
                        //将unicode字符转为10进制整数，然后转为char中文字符  
                        outStr += (char)int.Parse(strlist[i], System.Globalization.NumberStyles.HexNumber);
                    }
                }
                catch (FormatException ex)
                {
                    outStr = ex.Message;
                }
            }
            return outStr;
        }
    }
}
