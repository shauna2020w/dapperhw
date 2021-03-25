using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Models
{
    public class MovieGenre
    {
        [Key]
        public int Genre_Id { get; set; }
        [Key]
        public int Movie_Id { get; set; }
    }
}
