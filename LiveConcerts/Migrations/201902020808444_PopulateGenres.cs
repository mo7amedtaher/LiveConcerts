namespace LiveConcerts.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Genres(Name) Values (  'Jazz')");
            Sql("Insert Into Genres(Name) Values (  'Blues')");
            Sql("Insert Into Genres(Name) Values (  'Rock')");
            Sql("Insert Into Genres(Name) Values (  'Country')");

        }
        
        public override void Down()
        {
            Sql("Delete from Genres where Id in (1,2,3,4)");
        }
    }
}
