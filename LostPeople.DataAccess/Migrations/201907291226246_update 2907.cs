namespace LostPeople.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update2907 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.LostPersonPhotoes");

        }
        
        public override void Down()
        {
            DropTable("dbo.LostPersonPhotoes");
            CreateTable(
                "dbo.LostPersonPhotoes",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Photo = c.String(),
                })
                .PrimaryKey(t => t.Id);
        }
    }
}
