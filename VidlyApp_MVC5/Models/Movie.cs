using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyApp_MVC5.Models
{
    public class Movie
    {
        public int Id { get; set; }    
        
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        //This is called Navigation property
        [Required]
        [Display(Name = "Genre Type")]
        public int GenreId { get; set; }

        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        [Range(1, 20)]
        [Display(Name = "Stock Count")]
        public int StockCount { get; set; }
    }
}