namespace FormYonetimi.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatetimeFix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Form", "CreatedAt", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Form", "CreatedAt", c => c.DateTime(nullable: false));
        }
    }
}
