using IntroBackend;
using IntroBackend.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<PubContext>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/brewery", () => new Repository().GetBreweries());
app.MapGet("/brewery/{id}", (int id) =>
{
    var brewery = new Repository().GetBrewery(id);

    return brewery == null ? Results.NotFound() : Results.Ok(brewery);
});


/* Sin dependecias
 * app.MapGet("/beers", () => 
{
    List<Beer> beers = null;

    using (var db = new PubContext()) 
    {
        beers = db.Beers.ToList();
    }

    return beers;
});*/

//Con depedencias
app.MapGet("/beers", (PubContext db) => db.Beers.ToList());

app.Run();
