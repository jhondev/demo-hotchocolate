

public class Query
{
  public Book GetBook() => new Book
  {
    Title = "C# in depth.",
    Author = new Author
    {
      Name = "Jon Skeet"
    }
  };

  [UseProjection]
  [UseFiltering]
  [UseSorting]
  public IQueryable<Tournament>? GetTournaments(AppDbContext db) => db.Tournaments;

  [UseProjection]
  public IQueryable<Game>? GetGames(AppDbContext db) => db.Games;
}