namespace LabBigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (1, 'Delelopment')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (2, 'Business')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (3, 'MarketingS')");
        }
        
        public override void Down()
        {
        }
    }
}
