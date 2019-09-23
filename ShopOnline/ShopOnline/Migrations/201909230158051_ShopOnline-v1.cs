namespace ShopOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShopOnlinev1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ADVERTISE",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 500),
                        Url = c.String(maxLength: 500),
                        Width = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                        Link = c.String(maxLength: 500),
                        Target = c.Int(nullable: false),
                        Position = c.Int(nullable: false),
                        Order = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.COMPANY",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 500),
                        Address = c.String(storeType: "ntext"),
                        PhoneNumber = c.String(maxLength: 20),
                        Fax = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CONTACT",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 500),
                        Company = c.String(maxLength: 500),
                        Address = c.String(storeType: "ntext"),
                        Tel = c.String(maxLength: 20),
                        Mal = c.String(maxLength: 20),
                        Detail = c.String(storeType: "ntext"),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CUSTOMERS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 500),
                        Birthday = c.DateTime(nullable: false),
                        Province = c.String(maxLength: 500),
                        Address = c.String(storeType: "ntext"),
                        Tel = c.String(maxLength: 20),
                        Email = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GROUPPRODUCT",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 500),
                        Content = c.String(maxLength: 500),
                        Images = c.String(maxLength: 500),
                        Order = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MENU",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 500),
                        Link = c.String(maxLength: 500),
                        Order = c.Int(nullable: false),
                        Parent_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ORDERDETAIL",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Order_Id = c.Int(nullable: false),
                        Product_Id = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ORDER",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Customer_Id = c.Int(nullable: false),
                        TotalMoney = c.Single(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PRODUCT",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 500),
                        Detail = c.String(storeType: "ntext"),
                        Price = c.Single(nullable: false),
                        Image = c.String(maxLength: 500),
                        PriceNew = c.Single(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Order = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        GroupProduct_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PROVINCE",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SHOP",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 500),
                        Address = c.String(maxLength: 500),
                        Tel = c.String(maxLength: 500),
                        Province_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SUPPORT",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 500),
                        Tel = c.String(maxLength: 20),
                        Type = c.Int(nullable: false),
                        Nick = c.String(maxLength: 500),
                        Order = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.USERS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 500),
                        UserName = c.String(maxLength: 255),
                        Password = c.String(maxLength: 255),
                        Rule = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.USERS");
            DropTable("dbo.SUPPORT");
            DropTable("dbo.SHOP");
            DropTable("dbo.PROVINCE");
            DropTable("dbo.PRODUCT");
            DropTable("dbo.ORDER");
            DropTable("dbo.ORDERDETAIL");
            DropTable("dbo.MENU");
            DropTable("dbo.GROUPPRODUCT");
            DropTable("dbo.CUSTOMERS");
            DropTable("dbo.CONTACT");
            DropTable("dbo.COMPANY");
            DropTable("dbo.ADVERTISE");
        }
    }
}
