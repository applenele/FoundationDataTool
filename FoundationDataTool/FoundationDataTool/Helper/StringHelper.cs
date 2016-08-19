/**********************************************
*说明:
*计算机名称：LENNY
*创建日期：2016/8/19 23:07:50
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
    public class StringHelper
    {
        /// <summary>
        /// 得到随机字符串
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static string GetRandomString(int count, bool IsLower = false)
        {
            int number;
            string checkCode = String.Empty;     //存放随机码的字符串   

            System.Random random = new Random();

            for (int i = 0; i < count; i++) //产生4位校验码   
            {
                number = random.Next();
                number = number % 36;
                if (number < 10)
                {
                    number += 48;    //数字0-9编码在48-57   
                }
                else
                {
                    number += 55;    //字母A-Z编码在65-90   
                }

                checkCode += ((char)number).ToString();
            }
            if (IsLower)
                return checkCode.ToLower();
            else
                return checkCode;
        }
    }
}
