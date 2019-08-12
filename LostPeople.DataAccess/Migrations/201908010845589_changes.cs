namespace LostPeople.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.LostPersonPhotoes", new[] { "PhotoId" });
            AlterColumn("dbo.LostPersons", "PhotoId", c => c.Guid());
            CreateIndex("dbo.LostPersons", "PhotoId", unique: true);
            CreateIndex("dbo.LostPersonPhotoes", "PhotoId", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.LostPersonPhotoes", new[] { "PhotoId" });
            DropIndex("dbo.LostPersons", new[] { "PhotoId" });
            AlterColumn("dbo.LostPersons", "PhotoId", c => c.Guid(nullable: false));
            CreateIndex("dbo.LostPersonPhotoes", "PhotoId");
        }
    }
}
