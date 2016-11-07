namespace VertoWebforms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intalise : DbMigration
    {
        public override void Up()
        {

            CreateTable(
               "dbo.ImagesModels",
               c => new
               {
                   imageId = c.Int(nullable: false, identity: true),
                   imageLocation = c.String(),
                   imageUploadDate = c.DateTime(nullable: false),
               })

               .PrimaryKey(t => t.imageId);
            CreateTable(
                "dbo.catagoriesModels",
                c => new
                    {
                        CatagoryId = c.Int(nullable: false, identity: true),
                        Catagory = c.String(),
                        imageModelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CatagoryId)
                .ForeignKey("dbo.ImagesModels", t => t.imageModelId, cascadeDelete: true)
                .Index(t => t.imageModelId);
            
           
            
            CreateTable(
                "dbo.FieldEventsModels",
                c => new
                    {
                        FeildeventId = c.Int(nullable: false, identity: true),
                        EventCreationDate = c.DateTime(nullable: false),
                        Title = c.String(),
                        description = c.String(),
                        imageModelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FeildeventId)
                .ForeignKey("dbo.ImagesModels", t => t.imageModelId, cascadeDelete: true)
                .Index(t => t.imageModelId);
            
            CreateTable(
                "dbo.GalleryModels",
                c => new
                    {
                        galleryId = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        description = c.String(),
                        galleryDate = c.DateTime(nullable: false),
                        imageModelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.galleryId)
                .ForeignKey("dbo.ImagesModels", t => t.imageModelId, cascadeDelete: true)
                .Index(t => t.imageModelId);
            
            CreateTable(
                "dbo.NewsModels",
                c => new
                    {
                        storyId = c.Int(nullable: false, identity: true),
                        ArticleCreationDate = c.DateTime(nullable: false),
                        Title = c.String(),
                        story = c.String(),
                        imageModelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.storyId)
                .ForeignKey("dbo.ImagesModels", t => t.imageModelId, cascadeDelete: true)
                .Index(t => t.imageModelId);
            
            CreateTable(
                "dbo.offersModels",
                c => new
                    {
                        offerId = c.Int(nullable: false, identity: true),
                        offerTitle = c.String(),
                        Offer = c.String(),
                        offerDate = c.DateTime(nullable: false),
                        imageModelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.offerId)
                .ForeignKey("dbo.ImagesModels", t => t.imageModelId, cascadeDelete: true)
                .Index(t => t.imageModelId);
            
            CreateTable(
                "dbo.ProductsModels",
                c => new
                    {
                        productId = c.Int(nullable: false, identity: true),
                        productCreationDate = c.DateTime(nullable: false),
                        Title = c.String(),
                        description = c.String(),
                        imageModelId = c.Int(nullable: false),
                        catagoryModelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.productId)
                .ForeignKey("dbo.catagoriesModels", t => t.catagoryModelId, cascadeDelete: false)
                .ForeignKey("dbo.ImagesModels", t => t.imageModelId, cascadeDelete: true)
                .Index(t => t.imageModelId)
                .Index(t => t.catagoryModelId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.ProductsModels", "imageModelId", "dbo.ImagesModels");
            DropForeignKey("dbo.ProductsModels", "catagoryModelId", "dbo.catagoriesModels");
            DropForeignKey("dbo.offersModels", "imageModelId", "dbo.ImagesModels");
            DropForeignKey("dbo.NewsModels", "imageModelId", "dbo.ImagesModels");
            DropForeignKey("dbo.GalleryModels", "imageModelId", "dbo.ImagesModels");
            DropForeignKey("dbo.FieldEventsModels", "imageModelId", "dbo.ImagesModels");
            DropForeignKey("dbo.catagoriesModels", "imageModelId", "dbo.ImagesModels");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.ProductsModels", new[] { "catagoryModelId" });
            DropIndex("dbo.ProductsModels", new[] { "imageModelId" });
            DropIndex("dbo.offersModels", new[] { "imageModelId" });
            DropIndex("dbo.NewsModels", new[] { "imageModelId" });
            DropIndex("dbo.GalleryModels", new[] { "imageModelId" });
            DropIndex("dbo.FieldEventsModels", new[] { "imageModelId" });
            DropIndex("dbo.catagoriesModels", new[] { "imageModelId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.ProductsModels");
            DropTable("dbo.offersModels");
            DropTable("dbo.NewsModels");
            DropTable("dbo.GalleryModels");
            DropTable("dbo.FieldEventsModels");
            DropTable("dbo.ImagesModels");
            DropTable("dbo.catagoriesModels");
        }
    }
}
