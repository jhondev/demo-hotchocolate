using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

  public virtual DbSet<Tournament>? Tournaments { get; set; }
  public virtual DbSet<Game>? Games { get; set; }
}