namespace LostPeople.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
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

        }
        public override void Down()
        {
            
            
        }
    }
}
