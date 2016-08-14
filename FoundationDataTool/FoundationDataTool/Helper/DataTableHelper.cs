/**********************************************
*说明:
*计算机名称：LENNY
*创建日期：2016/8/14 0:09:02
*作者：乐
*电子邮箱：1941973283@qq.com
/**********************************************/

using FoundationDataTool.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FoundationDataTool.Helper
{
    /// <summary>
    /// datatable相关的帮助方法
    /// </summary>
    public static class DataTableHelper
    {

        /// <summary>
        /// DataTable转换成IList
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static List<T> ToList<T>(this DataTable dt) where T : new()
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }
            PropertyInfo[] properties = typeof(T).GetProperties();//获取实体类型的属性集合
            List<T> list = new List<T>();
            T model = default(T);
            foreach (DataRow dr in dt.Rows)
            {
                model = new T();//创建实体
                int i = 0;
                foreach (PropertyInfo p in properties)
                {
                    string dataName = "";
                    List<DataMappingAttribute> mapAttrs = p.GetCustomAttributes<DataMappingAttribute>().ToList();
                    if (mapAttrs.Any())
                    {
                        dataName = mapAttrs.FirstOrDefault().Name;
                    }
                    else
                    {
                        dataName = p.Name;
                    }
                    if (p.PropertyType == typeof(string))
                    {
                        p.SetValue(model, dr[dataName], null);
                    }
                    else if (p.PropertyType == typeof(int))
                    {
                        p.SetValue(model, int.Parse(dr[dataName].ToString()), null);
                    }
                    else if (p.PropertyType == typeof(DateTime))
                    {
                        p.SetValue(model, DateTime.Parse(dr[dataName].ToString()), null);
                    }
                    else if (p.PropertyType == typeof(float))
                    {
                        p.SetValue(model, float.Parse(dr[dataName].ToString()), null);
                    }
                    else if (p.PropertyType == typeof(double))
                    {
                        p.SetValue(model, double.Parse(dr[dataName].ToString()), null);
                    }
                }

                list.Add(model);
            }
            return list;
        }

    }
}
