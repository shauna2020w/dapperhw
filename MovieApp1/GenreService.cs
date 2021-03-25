using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Models;
using MovieApp.Repository;

namespace MovieApp1
{
    class GenreService
    {
        private readonly GenreRepo genreRepo;
        public GenreService()
        {
            genreRepo = new GenreRepo();
        }
        void UpdateGenre(Genre item)
        {
            Genre g = new Genre();
            g.Id = item.Id;
            g.Name = item.Name;

            if (genreRepo.Update(g) > 0)
                Console.WriteLine("Genre Updated successfully");
            else
                Console.WriteLine("Some error has occured");
        }
    }
}
