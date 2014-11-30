namespace MvcCDISCS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upbasicinfo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.basicinfoes", "Contact", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.basicinfoes", "Phone", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.basicinfoes", "CellPhone", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.basicinfoes", "Fax", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.basicinfoes", "Email", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.basicinfoes", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.basicinfoes", "PostCode", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.basicinfoes", "PostCode", c => c.String(maxLength: 20));
            AlterColumn("dbo.basicinfoes", "Address", c => c.String());
            AlterColumn("dbo.basicinfoes", "Email", c => c.String(maxLength: 80));
            AlterColumn("dbo.basicinfoes", "Fax", c => c.String(maxLength: 50));
            AlterColumn("dbo.basicinfoes", "CellPhone", c => c.String(maxLength: 50));
            AlterColumn("dbo.basicinfoes", "Phone", c => c.String(maxLength: 80));
            AlterColumn("dbo.basicinfoes", "Contact", c => c.String(maxLength: 50));
        }
    }
}
