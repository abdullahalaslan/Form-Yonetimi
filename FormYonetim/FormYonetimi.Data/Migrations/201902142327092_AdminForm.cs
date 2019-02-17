namespace FormYonetimi.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdminForm : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Admin", "FormId", "dbo.Form");
            DropIndex("dbo.Admin", new[] { "FormId" });
            CreateIndex("dbo.Form", "CreatedById");
            AddForeignKey("dbo.Form", "CreatedById", "dbo.Admin", "AdminId", cascadeDelete: true);
            DropColumn("dbo.Admin", "FormId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Admin", "FormId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Form", "CreatedById", "dbo.Admin");
            DropIndex("dbo.Form", new[] { "CreatedById" });
            CreateIndex("dbo.Admin", "FormId");
            AddForeignKey("dbo.Admin", "FormId", "dbo.Form", "FormId", cascadeDelete: true);
        }
    }
}
