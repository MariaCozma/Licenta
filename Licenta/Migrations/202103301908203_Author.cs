namespace Licenta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Author : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Books", "Author");
        }
        
        public override void Down()
        {
           
        }
    }
}
