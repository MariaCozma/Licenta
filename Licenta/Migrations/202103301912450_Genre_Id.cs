namespace Licenta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Genre_Id : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Books", "GenreId");
        }
        
        public override void Down()
        {
        }
    }
}
