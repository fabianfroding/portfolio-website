namespace PortfolioWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateProjects : DbMigration
    {
        public override void Up()
        {
            //Sql("INSERT INTO Projects (Title, Description) VALUES ('Role Detector', 'A software project')");
            //Sql("INSERT INTO Projects (Title, Description) VALUES ('Dog watcher', 'Hardware to observe dog behaviour')");
        }
        
        public override void Down()
        {
        }
    }
}
