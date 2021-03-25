using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; } //missing column
        public String Title { get; set; }

        public decimal Budget { get; set; }
        public decimal Revenue{ get; set; }
        public int  RunTime { get; set; }

        //Navigational property
        public Genre Genre { get; set; }
        public MovieCast MovieCast { get; set; }
    }
}
