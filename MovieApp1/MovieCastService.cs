using MovieApp.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Repository;
using MovieApp.Models;
using System.Threading.Tasks;

namespace MovieApp1
{
    class MovieCastService
    {
        public readonly MovieCastRepo mcRepo;
        public MovieCastService()
        {
            mcRepo = new MovieCastRepo();
        }


        public async Task PrintAllAsync()
        {
            var mcCollection = await mcRepo.GetAllAsync();
            foreach (var mc in mcCollection)
            {
                Console.WriteLine(mc.MovieId + " \t " + mc.Character);
            }

        }
        public async void Run()
        {
            await PrintAllAsync();
        }
    }
}
