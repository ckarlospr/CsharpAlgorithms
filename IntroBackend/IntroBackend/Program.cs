using IntroBackend;
using IntroBackend.Models;
using Microsoft.AspNetCore.Mvc;

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


// Sin dependecias
/* app.MapGet("/beers", () => 
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

app.MapPost("/beers", (PubContext db, Beer beer) =>
{
    db.Beers.Add(beer);
    db.SaveChanges();

    return Results.Created($"beer/{beer.BeerId}", beer);
});

app.MapPut("/beers/{id}", async (int id, PubContext db, Beer beerRequest) =>
{
    var beer = await db.Beers.FindAsync(id);

    if (beer is null) return Results.NotFound();

    beer.Name = beerRequest.Name;
    beer.BrandId = beerRequest.BrandId;

    await db.SaveChangesAsync();

    return Results.NoContent();
});

app.MapDelete("/beers/{id}", async (int id, PubContext db) => {
    var beer = await db.Beers.FindAsync(id);

    if (beer is null) return Results.NotFound();

    db.Beers.Remove(beer);
    await db.SaveChangesAsync();

    return Results.Ok(beer);
});

app.Run();
