namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertingDataToGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(GenreName)" +
                "VALUES('Absurdist')," +
                "('Action')," +
                "('Adventure')," +
                "('Comedy')," +
                "('Crime')," +
                "('Drama')," +
                "('Fantasy')," +
                "('Historical')," +
                "('Historical Fiction')," +
                "('Horror')," +
                "('Magical realism')," +
                "('Mystery')," +
                "('Paranoid Fiction')," +
                "('Philosophical')," +
                "('Political')," +
                "('Romance')," +
                "('Saga')," +
                "('Satire')," +
                "('Science Fiction')," +
                "('Social')," +
                "('Speculative')," +
                "('Thriller')," +
                "('Urban')," +
                "('Western')," +
                "('Animation')");
        }



        public override void Down()
        {
        }
    }
}
