using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Models
{
    public class Cast
    {
        [Key]
        public int id { get; set; } 
        public String Name { get; set; }
        public String Gender { get; set; }
        public String ProfilePath { get; set; }
        public String TmdbUrl { get; set; }
    }
}
