namespace MvcCDISCS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changebasicinfo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.basicinfoes", "Phone", c => c.String(maxLength: 80));
            AlterColumn("dbo.basicinfoes", "Email", c => c.String(maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.basicinfoes", "Email", c => c.String(maxLength: 50));
            AlterColumn("dbo.basicinfoes", "Phone", c => c.String(maxLength: 50));
        }
    }
}
