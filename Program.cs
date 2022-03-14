using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(opts => opts.UseNpgsql("Name=AppDb").UseSnakeCaseNamingConvention());

builder.Services
  .AddGraphQLServer()
  .RegisterDbContext<AppDbContext>()
  .AddQueryType<Query>()
  .AddProjections()
  .AddFiltering()
  .AddSorting();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGraphQL();

app.Run();


/* REVIEW
 https://github.com/ChilliCream/graphql-workshop

*/