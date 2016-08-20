/**********************************************
*说明:
*计算机名称：LENNY
*创建日期：2016/8/20 19:53:54
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
    /// Base64帮助
    /// </summary>
    public class Base64Helper
    {
        /// <summary>
        /// 给定字符方案编码解码string
        /// </summary>
        /// <param name="encrypted">要解码的string字符</param>
        /// <param name="encoding">字符编码方案</param>
        /// <returns></returns>
        public static string Decrypt(string encrypted, Encoding encoding)
        {
            byte[] buff = Convert.FromBase64String(encrypted);
            return encoding.GetString(buff);
        }
        /// <summary>
        /// 给定字符方案编码string
        /// </summary>
        /// <param name="original">要编码的string字符</param>
        /// <param name="encoding">字符编码方案</param>
        /// <returns></returns>
        public static string Encrypt(string original, Encoding encoding)
        {
            byte[] buff = encoding.GetBytes(original);
            return Convert.ToBase64String(buff);
        }
    }
}
