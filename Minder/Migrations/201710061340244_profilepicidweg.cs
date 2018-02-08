namespace Minder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class profilepicidweg : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Profiles", "ProfilePictureId", "dbo.Pictures");
            DropIndex("dbo.Profiles", new[] { "ProfilePictureId" });
            RenameColumn(table: "dbo.Profiles", name: "ProfilePictureId", newName: "ProfilePicture_Id");
            AlterColumn("dbo.Profiles", "ProfilePicture_Id", c => c.Int());
            CreateIndex("dbo.Profiles", "ProfilePicture_Id");
            AddForeignKey("dbo.Profiles", "ProfilePicture_Id", "dbo.Pictures", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Profiles", "ProfilePicture_Id", "dbo.Pictures");
            DropIndex("dbo.Profiles", new[] { "ProfilePicture_Id" });
            AlterColumn("dbo.Profiles", "ProfilePicture_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Profiles", name: "ProfilePicture_Id", newName: "ProfilePictureId");
            CreateIndex("dbo.Profiles", "ProfilePictureId");
            AddForeignKey("dbo.Profiles", "ProfilePictureId", "dbo.Pictures", "Id", cascadeDelete: true);
        }
    }
}
