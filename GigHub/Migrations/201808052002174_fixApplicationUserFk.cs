namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixApplicationUserFk : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Gigs", "ArtistId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Gigs", "ArtistId");
            AddForeignKey("dbo.Gigs", "ArtistId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            DropColumn("dbo.Gigs", "Artist");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Gigs", "Artist", c => c.String());
            DropForeignKey("dbo.Gigs", "ArtistId", "dbo.AspNetUsers");
            DropIndex("dbo.Gigs", new[] { "ArtistId" });
            AlterColumn("dbo.Gigs", "ArtistId", c => c.String(nullable: false));
        }
    }
}
