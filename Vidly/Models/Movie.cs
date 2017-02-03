using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        
        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        
        public DateTime DateAdded { get; set; }

        
        [Display(Name = "Release Date (d/MMM/yyyy)")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Number In Stock")]
        [MovieStockValidation]
        public byte NumberInStock { get; set; }

        public static readonly byte NoStock = 0;
        public static readonly byte MaxStock = 20;
    }
}