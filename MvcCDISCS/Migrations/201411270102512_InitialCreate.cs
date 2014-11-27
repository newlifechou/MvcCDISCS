namespace MvcCDISCS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false),
                        Role = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.basicinfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false, maxLength: 50),
                        Contact = c.String(maxLength: 50),
                        Phone = c.String(maxLength: 50),
                        CellPhone = c.String(maxLength: 50),
                        Fax = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        Address = c.String(),
                        PostCode = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.careers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        ExpirationTime = c.DateTime(nullable: false),
                        Content = c.String(nullable: false),
                        Memo = c.String(),
                        IsShow = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.feedbacks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        CustomerName = c.String(nullable: false),
                        FeedbackTime = c.DateTime(nullable: false),
                        Email = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Content = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.flashes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SlidePhoto = c.String(nullable: false),
                        Memo = c.String(maxLength: 50),
                        Priority = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.friendlinks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SiteName = c.String(nullable: false, maxLength: 20),
                        SiteUrl = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.logs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        LogTime = c.String(),
                        IpAddress = c.String(),
                        Memo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.morebasicinfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemName = c.String(nullable: false, maxLength: 50),
                        ItemContent = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.news",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Author = c.String(nullable: false),
                        PublishTime = c.DateTime(nullable: false),
                        ReadCount = c.Int(nullable: false),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.notices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NoticeContent = c.String(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        Priority = c.Int(nullable: false),
                        IsShow = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.productcategories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false),
                        Photo = c.String(nullable: false),
                        Memo = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false),
                        PublishTime = c.DateTime(nullable: false),
                        ReadCount = c.Int(nullable: false),
                        Photo = c.String(nullable: false),
                        Content = c.String(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.productcategories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Photo = c.String(nullable: false),
                        Content = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.products", "CategoryId", "dbo.productcategories");
            DropIndex("dbo.products", new[] { "CategoryId" });
            DropTable("dbo.services");
            DropTable("dbo.products");
            DropTable("dbo.productcategories");
            DropTable("dbo.notices");
            DropTable("dbo.news");
            DropTable("dbo.morebasicinfoes");
            DropTable("dbo.logs");
            DropTable("dbo.friendlinks");
            DropTable("dbo.flashes");
            DropTable("dbo.feedbacks");
            DropTable("dbo.careers");
            DropTable("dbo.basicinfoes");
            DropTable("dbo.admins");
        }
    }
}
