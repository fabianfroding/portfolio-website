namespace PortfolioWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedImagesPropertyToProjectModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "Images", c => c.String());
        }
        
        public override void Down()
        {
        }
    }
}
