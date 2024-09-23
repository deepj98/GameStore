using System;
using System.ComponentModel.DataAnnotations;

namespace Frontend.UI.Models;

public class GameDetails
{

    public int Id { get; set; }

    [Required(ErrorMessage = "Name cannot be empty")]
    [StringLength(50)]
    public required string Name { get; set; }

    [Required(ErrorMessage ="Selet a Genre from the list, Genre cannot be Null")]
    public  string? GenreId { get; set; }

    [Range(1.00,100.00,ErrorMessage = "Value cannot be less the 1 or exceed 100")]
    public decimal Price { get; set; }

    public DateOnly ReleaseDate { get; set; }
 
}
