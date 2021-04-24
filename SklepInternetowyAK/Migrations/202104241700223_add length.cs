namespace SklepInternetowyAK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addlength : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "Length", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "Length");
        }
    }
}
