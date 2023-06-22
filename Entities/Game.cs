namespace dotnet_crud.Entities;

public class Game
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Genre { get; set; }
    public decimal Price { get; set; }
    public DateTime RealeseDate { get; set; }
    public required string ImgURI { get; set; }
}