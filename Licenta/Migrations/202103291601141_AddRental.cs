namespace Licenta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRental : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rentals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateRented = c.DateTime(nullable: false),
                        DateReturned = c.DateTime(),
                        Book_Id = c.Int(nullable: false),
                        Customer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.Book_Id, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .Index(t => t.Book_Id)
                .Index(t => t.Customer_Id);
            
            AddColumn("dbo.Books", "NumberAvailable", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Rentals", "Book_Id", "dbo.Books");
            DropIndex("dbo.Rentals", new[] { "Customer_Id" });
            DropIndex("dbo.Rentals", new[] { "Book_Id" });
            DropColumn("dbo.Books", "NumberAvailable");
            DropTable("dbo.Rentals");
        }
    }
}
