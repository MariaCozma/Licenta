namespace Licenta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberAvailableToBook : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "NumberAvailable", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "NumberAvailable");
        }
    }
}
