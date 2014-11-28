namespace MvcCDISCS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productcategoryaddc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.productcategories", "Priority", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.productcategories", "Priority");
        }
    }
}
