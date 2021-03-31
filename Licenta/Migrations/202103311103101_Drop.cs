namespace Licenta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Drop : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Books", "Genre_Id", "GenreId");        }
        
        public override void Down()
        {
        }
    }
}
