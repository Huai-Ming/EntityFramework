namespace EF_Code_First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAgeField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentInfo", "Age", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.StudentInfo", "Age");
        }
    }
}
