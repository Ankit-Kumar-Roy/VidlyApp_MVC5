using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VidlyApp_MVC5.Models;

namespace VidlyApp_MVC5.ViewModels
{
    public class MovieFormViewModel
    {
        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            GenreId = movie.GenreId;
            ReleaseDate = movie.ReleaseDate;
            StockCount = movie.StockCount;
        }

        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        [Required]
        [Display(Name = "Genre Type")]
        public int? GenreId { get; set; }
        
        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }
        
        [Required]
        [Range(1, 20)]
        [Display(Name = "Stock Count")]
        public int? StockCount { get; set; }

        public string Title
        {
            get
            {
                return (Id != null && Id != 0) ? "Edit Movie" : "New Movie";
            }
            //private set;
        }
    }
}