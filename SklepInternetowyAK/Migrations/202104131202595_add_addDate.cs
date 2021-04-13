namespace SklepInternetowyAK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_addDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "AddDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "AddDate");
        }
    }
}
