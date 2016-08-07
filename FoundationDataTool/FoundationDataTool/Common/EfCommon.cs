/**********************************************
*说明:
*计算机名称：LENNY
*创建日期：2016/8/7 16:55:27
*作者：乐
*电子邮箱：1941973283@qq.com
/**********************************************/

using FoundationDataTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Z.EntityFramework.Plus;

namespace FoundationDataTool.Common
{
    public class EFCommon<T> where T : class
    {
        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="entities">The entities.</param>
        public static void BatchAdd(List<T> entities)
        {
            using (DB db = new DB())
            {
                db.Set<T>().AddRange(entities);
                db.BulkInsert(entities);
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="exp"></param>
        public static void Delete(Expression<Func<T, bool>> exp)
        {
            using (DB db = new DB())
            {
                db.Set<T>().Where(exp).Delete();
            }
        }

        /// <summary>
        /// 实现按需要只更新部分更新
        /// <para>如：Update(u =>u.Id==1,u =>new User{Name="ok"});</para>
        /// </summary>
        /// <param name="where">The where.</param>
        /// <param name="entity">The entity.</param>
        public static void Update(Expression<Func<T, bool>> where, Expression<Func<T, T>> entity)
        {
            using (DB db = new DB())
            {
                db.Set<T>().Where(where).Update(entity);
            }
        }

        /// <summary>
        /// 是否存在
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public static bool IsExist(Expression<Func<T, bool>> exp)
        {
            using (DB db = new DB())
            {
                return db.Set<T>().Any(exp);
            }
        }
    }
}
