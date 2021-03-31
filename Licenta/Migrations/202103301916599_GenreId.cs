namespace Licenta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenreId : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Genre");
            DropTable("dbo.Book");
        }
        
        public override void Down()
        {
        }
    }
}
