using System;
using Frontend.UI.Models;

namespace Frontend.UI.Components;

public class GenresClient
{   
    private readonly Genre[] genres = [
        new(){
            Id = 1,
            Name = "Fighting"
        },
        new(){
            Id = 2,
            Name = "Adventure"
        },
        new(){
            Id = 3,
            Name = "War"
        },
        new(){
            Id = 4,
            Name = "Educational"
        },
        new(){
            Id = 5,
            Name = "Kids and Family"
        },
        new(){
            Id = 6,
            Name = "Sports"
        },
         new(){
            Id = 7,
            Name = "Racing"
        },
    ];

    public Genre[] GetGenres() => genres;

}
