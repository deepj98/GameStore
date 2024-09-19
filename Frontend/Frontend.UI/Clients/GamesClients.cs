using System;
using Frontend.UI.Components;
using Frontend.UI.Models;

namespace Frontend.UI.Clients;

public class GamesClients
{
     private readonly List<GameSummary> games = [
    new(){
            Id = 1,
            Name = "Hitman",
            Genre = "Action",
            Price = 19.99M ,
            ReleaseDate = new DateOnly(2004, 11, 29),
        },
        new(){
            Id = 2,
            Name = "Angry Birds",
            Genre = "Fun & Adventure",
            Price = 23.99M ,
            ReleaseDate = new DateOnly(2009, 12, 11),   
        },
        new(){
            Id = 3,
            Name = "Counter Strike",
            Genre = "Action",
            Price = 49.99M ,
            ReleaseDate = new DateOnly(2003, 10, 23),
        }

    ];

private readonly Genre[] genres = new GenresClient().GetGenres();
    public GameSummary[] GetGames() => [.. games];

    public void AddGames(GameDetails game)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(game.GenreId); 
        var genre = genres.Single(genre => genre.Id == int.Parse(game.GenreId));

        var gameSummary = new GameSummary{
            Id = games.Count + 1,
            Name = game.Name,
            Genre = genre.Name,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate

        };

        games.Add(gameSummary);
    }
     

}
