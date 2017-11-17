namespace VirtualAssistant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class exercise31 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
            DropColumn("dbo.Movies", "GendreId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "GendreId", c => c.Byte(nullable: false));
            DropColumn("dbo.Movies", "GenreId");
        }
    }
}
