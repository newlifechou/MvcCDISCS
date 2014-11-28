namespace MvcCDISCS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeadmin : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.admins", "UserName", c => c.String(nullable: false));
            AlterColumn("dbo.admins", "Role", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.admins", "Role", c => c.String(nullable: false));
            AlterColumn("dbo.admins", "UserName", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
