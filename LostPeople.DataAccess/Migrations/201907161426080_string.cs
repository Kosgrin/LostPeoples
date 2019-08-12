namespace LostPeople.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _string : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LostPersons",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        OVD = c.String(),
                        CATEGORY = c.String(),
                        LAST_NAME = c.String(),
                        FIRST_NAME = c.String(),
                        MIDDLE_NAME = c.String(),
                        BIRTH_DATE = c.String(),
                        SEX = c.String(),
                        LOST_PLACE = c.String(),
                        LOST_DATE = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LostPersons");
        }
    }
}
