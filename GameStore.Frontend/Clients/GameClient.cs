using System;
using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class GameClient
{
    private readonly List<GameSummary> games = [
        new() {
            Id = 1,
            Name = "Genshin Impact",
            Genre = "Exploration",
            Price = 9.99M,
            ReleaseDate = new DateOnly(2020, 9, 28)
        },
        new() {
            Id = 2,
            Name = "Honkai StarRail",
            Genre = "Exploration",
            Price = 9.99M,
            ReleaseDate = new DateOnly(2023, 4, 26)
        },
        new() {
            Id = 3,
            Name = "Zenless Zone Zero",
            Genre = "Fighting",
            Price = 9.99M,
            ReleaseDate = new DateOnly(2024, 7, 4)
        }
    ];

    private readonly Genre[] genres= new GenreClient().GetGenres();

    public GameSummary[] GetGames() => [.. games];

    public void AddGame(GameDetails game) {
        ArgumentException.ThrowIfNullOrWhiteSpace(game.GenreId);
        var genre = genres.Single(genre => genre.Id == int.Parse(game.GenreId));
        var gameSummary = new GameSummary() {
            Id = games.Count + 1,
            Name = game.Name,
            Genre = game.GenreId,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate
        };

        games.Add(gameSummary);
    }
}
