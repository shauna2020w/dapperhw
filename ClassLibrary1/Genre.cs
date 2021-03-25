using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; } //allow null
        
    }
}
