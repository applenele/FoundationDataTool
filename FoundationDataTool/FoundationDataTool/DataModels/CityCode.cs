/**********************************************
*说明:
*计算机名称：LENNY
*创建日期：2016/8/18 0:31:46
*作者：乐
*电子邮箱：1941973283@qq.com
/**********************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationDataTool.DataModels
{
    public class CityCode
    {
        /// <summary>
        /// 
        /// </summary>
        public string city_id { get; set; }
        /// <summary>
        ///  
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string en { get; set; }

        public List<CityCode> list { set; get; }
    }
}
