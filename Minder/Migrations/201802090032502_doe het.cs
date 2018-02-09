namespace Minder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class doehet : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "SenderId", c => c.Int(nullable: false));
            AddColumn("dbo.Messages", "ReceiverId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "ReceiverId");
            DropColumn("dbo.Messages", "SenderId");
        }
    }
}
