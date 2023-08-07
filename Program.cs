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
const string getGameName = "GetGame";

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/games", () => games);
app.MapGet("/games/{id}", (int id) =>
{
    Game? game = games.Find(game => game.Id == id);

    if (game is null)
    {
        return Results.NotFound("Not found");
    }

    return Results.Ok(game);
})
.WithName(getGameName);

app.MapPost("/games", (Game game) =>
{
    game.Id = games.Max(game => game.Id) + 1;
    games.Add(game);

    return Results.CreatedAtRoute(getGameName, new { id = game.Id }, game);
});

app.MapPut("/games/{id}", (int id, Game updatedGame) =>
{
    Game? extingGame = games.Find(game => game.Id == id);

    if (extingGame is null)
    {
        return Results.NotFound("Not found");
    }

    extingGame.Name = updatedGame.Name;
    extingGame.Genre = updatedGame.Genre;
    extingGame.Price = updatedGame.Price;
    extingGame.RealeseDate = updatedGame.RealeseDate;
    extingGame.ImgURI = updatedGame.ImgURI;

    return Results.NoContent();
});

app.Run();
