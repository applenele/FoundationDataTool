/**********************************************
*说明:
*计算机名称：LENNY
*创建日期：2016/8/14 0:17:57
*作者：乐
*电子邮箱：1941973283@qq.com
/**********************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationDataTool.Attributes
{
    /// <summary>
    /// 数据映射
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class DataMappingAttribute : Attribute
    {
        public string Name { set; get; }
    }
}
