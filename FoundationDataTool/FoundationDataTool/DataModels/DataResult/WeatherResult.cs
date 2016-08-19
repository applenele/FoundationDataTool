/**********************************************
*说明:
*计算机名称：LENNY
*创建日期：2016/8/19 22:11:49
*作者：乐
*电子邮箱：1941973283@qq.com
/**********************************************/

using FoundationDataTool.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FoundationDataTool.DataModels.DataResult
{
    public class WeatherResult
    {
        /// <summary>
        /// 
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string msg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int counts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public WeatherData data { get; set; }
    }

    public class WeatherData
    {
        /// <summary>
        /// 
        /// </summary>
        public string cityId { get; set; }
        /// <summary>
        /// 北京
        /// </summary>
        public string cityName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sj { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<WeatherListItem> list { get; set; }
    }

    public class WeatherListItem
    {
        /// <summary>
        /// 晴
        /// </summary>
        [Description("白天天气")]
        public string tq1 { get; set; }
        /// <summary>
        /// 晴
        /// </summary>
        [Description("夜间天气")]
        public string tq2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("白天气温")]
        public string qw1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("夜间气温")]
        public string qw2 { get; set; }
        /// <summary>
        /// 微风
        /// </summary>
        [Description("白天风力")]
        public string fl1 { get; set; }
        /// <summary>
        /// 微风
        /// </summary>
        [Description("夜间风力")]
        public string fl2 { get; set; }
        /// <summary>
        /// 无持续风向
        /// </summary>
        [Description("白天风向")]
        public string fx1 { get; set; }
        /// <summary>
        /// 无持续风向
        /// </summary>
        [Description("夜间风向")]
        public string fx2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("夜间时间")]
        public string date { get; set; }

        public override string ToString()
        {
            StringBuilder sbd = new StringBuilder();
            PropertyInfo[] props = this.GetType().GetProperties();
            foreach (PropertyInfo prop in props)
            {
                var attrArrs = prop.GetCustomAttributes<DescriptionAttribute>();
                foreach (var item in attrArrs)
                {
                    sbd.AppendFormat("{0}:{1}\r\n", item.Description, prop.GetValue(this,null).ToString());
                }
            }
            return sbd.ToString();
        }
    }
}
