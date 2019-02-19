using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyApp_MVC5.Models;

namespace VidlyApp_MVC5.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}