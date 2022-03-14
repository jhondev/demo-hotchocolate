using System.ComponentModel.DataAnnotations;

public class Game
{
  [Key]
  public string? KeyName { get; set; }
  public string? Name { get; set; }
  public string? AvatarName { get; set; }
}

public class Tournament
{
  public Guid Id { get; set; }
  public string? GameKeyName { get; set; }
  public string? Name { get; set; }
}

public class Book
{
  public string? Title { get; set; }
  public Author? Author { get; set; }
}

public class Author
{
  public string? Name { get; set; }
}