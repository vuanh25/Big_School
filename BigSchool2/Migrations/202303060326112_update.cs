namespace BigSchool2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES (1,'Development')");
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES (2,'Business')");
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES (3,'Marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
