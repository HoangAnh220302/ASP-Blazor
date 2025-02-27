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

    public GameSummary[] GetGames() => [.. games];
}
