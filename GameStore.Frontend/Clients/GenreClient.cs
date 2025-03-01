using System;
using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class GenreClient
{
    private readonly Genre[] genres = [
        new Genre {
            Id = 1,
            Name = "Adventure",
        },
        new Genre {
            Id = 2,
            Name = "Shooter",
        },
        new Genre {
            Id = 3,
            Name = "RPG",
        },
        new Genre {
            Id = 4,
            Name = "Battle Royale",
        },
        new Genre {
            Id = 5,
            Name = "Strategy",
        },
    ];
    
    public Genre[] GetGenres() => genres;
}
