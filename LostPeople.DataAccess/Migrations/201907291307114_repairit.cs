namespace LostPeople.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class repairit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LostPersonPhotoes",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Photo = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateIndex("dbo.LostPersonPhotoes", "Id");
            AddForeignKey("dbo.LostPersonPhotoes", "Id", "dbo.LostPersons", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LostPersonPhotoes", "Id", "dbo.LostPersons");
            DropIndex("dbo.LostPersonPhotoes", new[] { "Id" });
        }
    }
}
