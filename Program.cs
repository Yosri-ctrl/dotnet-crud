using dotnet_crud.Entities;

List<Game> games = new List<Game>(){
    new Game() {
        Id = 1,
        Name = "Street Fighter",
        Genre = "Action",
        Price = 19.99M,
        RealeseDate = new DateTime(1991,2,1),
        ImgURI = "",
    },
    new Game() {
        Id = 2,
        Name = "FFXIV",
        Genre = "MMO",
        Price = 59.99M,
        RealeseDate = new DateTime(2010,9,1),
        ImgURI = "",
    },
    new Game() {
        Id = 3,
        Name = "Fifa 23",
        Genre = "Sport",
        Price = 59.99M,
        RealeseDate = new DateTime(2022,9,1),
        ImgURI = "",
    }
};


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/games", () => games);
app.MapGet("/games/{id}", (int id) =>
{
    Game? game = games.Find(game => game.Id == id);

    if (game is null) {
        return Results.NotFound("");
    }

    return Results.Ok(game);
});

app.Run();
