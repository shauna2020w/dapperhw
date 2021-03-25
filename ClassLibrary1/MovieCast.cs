using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Models
{
    public class MovieCast
    {
        public int MovieId { get; set; }
        public int CastId { get; set; }
        public String Character { get; set; }

    }
}
