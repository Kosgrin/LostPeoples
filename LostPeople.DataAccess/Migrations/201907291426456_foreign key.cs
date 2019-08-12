namespace LostPeople.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foreignkey : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.LostPersonPhotoes", name: "Id", newName: "PhotoId");
            RenameIndex(table: "dbo.LostPersonPhotoes", name: "IX_Id", newName: "IX_PhotoId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.LostPersonPhotoes", name: "IX_PhotoId", newName: "IX_Id");
            RenameColumn(table: "dbo.LostPersonPhotoes", name: "PhotoId", newName: "Id");
        }
    }
}
