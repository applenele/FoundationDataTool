﻿/**********************************************
*说明:
*计算机名称：LENNY
*创建日期：2016/8/7 11:55:14
*作者：乐
*电子邮箱：1941973283@qq.com
/**********************************************/

using EntityFramework.Batch;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationDataTool.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DB : DbContext
    {
        public DB() : base("name =mysqldb")
        {
            Database.SetInitializer<DB>(null);
        }

        public DbSet<SecondryCode> SecondryCodes { set; get; }

        /// <summary>
        ///  省份
        /// </summary>
        public DbSet<Province> Provinces { set; get; }

        /// <summary>
        /// 城市
        /// </summary>
        public DbSet<City> Cities { set; get; }

        /// <summary>
        /// 区
        /// </summary>
        public DbSet<County> Counties { set; get; }

        /// <summary>
        /// 镇
        /// </summary>
        public DbSet<Town> Towns { set; get; }

        /// <summary>
        /// 村
        /// </summary>
        public DbSet<Village> Villages { set; get; }

        /// <summary>
        /// 配置
        /// </summary>
        public DbSet<Config> Configs { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("");    //增加配置 migration 的注释掉  运行的时候拿掉注释
            base.OnModelCreating(modelBuilder);
        }
    }
}
