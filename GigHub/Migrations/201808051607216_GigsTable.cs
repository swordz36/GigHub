namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GigsTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Gigs", "Astist_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Gigs", new[] { "Astist_Id" });
            RenameColumn(table: "dbo.Gigs", name: "Genre_Id", newName: "GenreId");
            RenameIndex(table: "dbo.Gigs", name: "IX_Genre_Id", newName: "IX_GenreId");
            AddColumn("dbo.Gigs", "Artist", c => c.String());
            AddColumn("dbo.Gigs", "ArtistId", c => c.String(nullable: false));
            DropColumn("dbo.Gigs", "Astist_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Gigs", "Astist_Id", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Gigs", "ArtistId");
            DropColumn("dbo.Gigs", "Artist");
            RenameIndex(table: "dbo.Gigs", name: "IX_GenreId", newName: "IX_Genre_Id");
            RenameColumn(table: "dbo.Gigs", name: "GenreId", newName: "Genre_Id");
            CreateIndex("dbo.Gigs", "Astist_Id");
            AddForeignKey("dbo.Gigs", "Astist_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
    }
}
