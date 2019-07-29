using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime ReleaseDate { get; set; }

        public byte NumberInStock { get; set; }
        public byte NumberAvailable { get; set; }

    }
}