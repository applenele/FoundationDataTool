namespace FoundationDataTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedb2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Configs", "Remark", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Configs", "Remark");
        }
    }
}
