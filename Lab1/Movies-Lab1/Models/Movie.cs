using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Movies_Lab1.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        [Range(1900, 2022)]
        public int ReleaseYear { get; set; }

        [MinLength(10)]
        public string Genre { get; set; }
        [Range (1, 10)]
        public float Rating { get; set; }
        [Required]
        public string StudioName { get; set; } 
    }

}
