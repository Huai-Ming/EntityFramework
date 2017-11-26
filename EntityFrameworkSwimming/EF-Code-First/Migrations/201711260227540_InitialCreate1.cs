namespace EF_Code_First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Students", newName: "StudentInfo");
            RenameColumn(table: "dbo.StudentInfo", name: "StudentName", newName: "Name");
            AlterColumn("dbo.StudentInfo", "Name", c => c.String(storeType: "ntext"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StudentInfo", "Name", c => c.String());
            RenameColumn(table: "dbo.StudentInfo", name: "Name", newName: "StudentName");
            RenameTable(name: "dbo.StudentInfo", newName: "Students");
        }
    }
}
