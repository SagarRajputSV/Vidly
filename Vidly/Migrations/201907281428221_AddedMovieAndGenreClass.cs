namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMovieAndGenreClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        GenreName = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.GenreId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieId = c.Int(nullable: false, identity: true),
                        MovieName = c.String(nullable: false),
                        Genre = c.Int(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        ReleaseDate = c.DateTime(name: "Release Date", nullable: false),
                        NumberInStock = c.Byte(name: "Number In Stock", nullable: false),
                        NumberAvailable = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.MovieId)
                .ForeignKey("dbo.Genres", t => t.Genre, cascadeDelete: true)
                .Index(t => t.Genre);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Genre", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genre" });
            DropTable("dbo.Movies");
            DropTable("dbo.Genres");
        }
    }
}
