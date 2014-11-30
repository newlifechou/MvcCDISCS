namespace MvcCDISCS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class udservicefeedback : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.feedbacks", "Title", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.feedbacks", "CustomerName", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.feedbacks", "CustomerName", c => c.String(nullable: false));
            AlterColumn("dbo.feedbacks", "Title", c => c.String(nullable: false));
        }
    }
}
