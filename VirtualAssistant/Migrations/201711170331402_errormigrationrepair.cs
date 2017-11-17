namespace VirtualAssistant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class errormigrationrepair : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String());
        }
    }
}
