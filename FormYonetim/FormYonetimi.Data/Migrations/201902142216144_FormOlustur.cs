namespace FormYonetimi.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FormOlustur : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admin",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 16),
                        FormId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AdminId)
                .ForeignKey("dbo.Form", t => t.FormId, cascadeDelete: true)
                .Index(t => t.FormId);
            
            CreateTable(
                "dbo.Form",
                c => new
                    {
                        FormId = c.Int(nullable: false, identity: true),
                        FormName = c.String(),
                        FormDescription = c.String(maxLength: 150),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedById = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FormId);
            
            CreateTable(
                "dbo.Kullanici",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false),
                        Soyad = c.String(nullable: false),
                        Yas = c.Int(nullable: false),
                        FormId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Form", t => t.FormId, cascadeDelete: true)
                .Index(t => t.FormId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kullanici", "FormId", "dbo.Form");
            DropForeignKey("dbo.Admin", "FormId", "dbo.Form");
            DropIndex("dbo.Kullanici", new[] { "FormId" });
            DropIndex("dbo.Admin", new[] { "FormId" });
            DropTable("dbo.Kullanici");
            DropTable("dbo.Form");
            DropTable("dbo.Admin");
        }
    }
}
