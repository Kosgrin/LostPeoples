namespace LostPeople.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fkeys : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.LostPersons", new[] { "PhotoId" });
            DropIndex("dbo.LostPersonPhotoes", new[] { "PhotoId" });
            CreateIndex("dbo.LostPersonPhotoes", "PhotoId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.LostPersonPhotoes", new[] { "PhotoId" });
            AlterColumn("dbo.LostPersons", "PhotoId", c => c.String(maxLength: 50));
            CreateIndex("dbo.LostPersonPhotoes", "PhotoId");
            CreateIndex("dbo.LostPersons", "PhotoId");
        }
    }
}
