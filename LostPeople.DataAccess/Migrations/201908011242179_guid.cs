namespace LostPeople.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class guid : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.LostPersonPhotoes", "PhotoId", "dbo.LostPersons");
            DropIndex("dbo.LostPersons", new[] { "PhotoId" });
            DropIndex("dbo.LostPersonPhotoes", new[] { "PhotoId" });
            DropPrimaryKey("dbo.LostPersons");
            DropPrimaryKey("dbo.LostPersonPhotoes");
            AlterColumn("dbo.LostPersons", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.LostPersons", "PhotoId", c => c.String(maxLength: 50));
            AlterColumn("dbo.LostPersonPhotoes", "PhotoId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.LostPersons", "Id");
            AddPrimaryKey("dbo.LostPersonPhotoes", "PhotoId");
            CreateIndex("dbo.LostPersons", "PhotoId");
            CreateIndex("dbo.LostPersonPhotoes", "PhotoId");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LostPersonPhotoes", "PhotoId", "dbo.LostPersons");
            DropIndex("dbo.LostPersonPhotoes", new[] { "PhotoId" });
            DropIndex("dbo.LostPersons", new[] { "PhotoId" });
            DropPrimaryKey("dbo.LostPersonPhotoes");
            DropPrimaryKey("dbo.LostPersons");
            AlterColumn("dbo.LostPersonPhotoes", "PhotoId", c => c.Guid(nullable: false));
            AlterColumn("dbo.LostPersons", "PhotoId", c => c.Guid());
            AlterColumn("dbo.LostPersons", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.LostPersonPhotoes", "PhotoId");
            AddPrimaryKey("dbo.LostPersons", "Id");
            CreateIndex("dbo.LostPersonPhotoes", "PhotoId", unique: true);
            CreateIndex("dbo.LostPersons", "PhotoId", unique: true);
            AddForeignKey("dbo.LostPersonPhotoes", "PhotoId", "dbo.LostPersons", "Id");
        }
    }
}
