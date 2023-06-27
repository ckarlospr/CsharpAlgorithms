using IntroBackend;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/brewery", () => new Repository().GetBreweries());
app.MapGet("/brewery/{id}", (int id) =>
{
    var brewery = new Repository().GetBrewery(id);

    return brewery == null ? Results.NotFound() : Results.Ok(brewery);
});

app.Run();
