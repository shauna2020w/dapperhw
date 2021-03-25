using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Models;
using MovieApp.Repository;

namespace MovieApp1
{
    class MovieService
    {
        private readonly MovieRepo movieRepo;
        public MovieService()
        {
            movieRepo = new MovieRepo();
        }
        void PrintAllwithGenre()
        {
            IEnumerable<Movie> movieCollection= movieRepo.GetAllWithGenre();
            foreach (var item in movieCollection) //?
            {
                Console.WriteLine(item.Title + " \t " + item.Genre.Name);
            }
        }

        public void Run()
        {
            PrintAllwithGenre();
        }
    }
}
