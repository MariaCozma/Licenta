namespace Licenta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropTable : DbMigration
    {
        public override void Up()
        {
           RenameColumn("dbo.Books", ("Genre_Id") , ("GenreId"));
        }
        
        public override void Down()
        {
        }
    }
}
