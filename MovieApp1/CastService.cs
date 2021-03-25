using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Models;
using MovieApp.Repository;

namespace MovieApp1
{
    class CastService
    {
        public readonly CastRepo castRepo;
        public CastService()
        {
            castRepo = new CastRepo();
        }


        void AddCast(Cast item)
        {
            Cast c = new Cast();

            Console.Write("Enter Name = ");
            c.Name = Console.ReadLine();
            Console.Write("Enter Gender = ");
            c.Gender = Console.ReadLine();
            Console.Write("Enter TmdbUrl = ");
            c.TmdbUrl = Console.ReadLine();
            Console.Write("Enter ProfilePath = ");
            c.ProfilePath = Console.ReadLine();

            if (castRepo.Insert(c) > 0)
                Console.WriteLine("Cast added successfully");
            else
                Console.WriteLine("Some error has occured");
        }
        void PrintAll()
        {
            IEnumerable<Cast> castCollection = castRepo.GetAll();
            foreach (var item in castCollection)
            {
                Console.WriteLine(item.id + " \t " + item.Name);
            }
        }

        public void Run()
        {
            PrintAll();
        }
    }
}
