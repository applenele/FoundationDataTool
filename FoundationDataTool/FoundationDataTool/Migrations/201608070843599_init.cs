namespace FoundationDataTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.City",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(unicode: false),
                        division_code = c.String(unicode: false),
                        province_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Province",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.SecondryCode",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        type = c.String(unicode: false),
                        value = c.String(unicode: false),
                        name = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SecondryCode");
            DropTable("dbo.Province");
            DropTable("dbo.City");
        }
    }
}
