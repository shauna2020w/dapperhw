using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Models;
using System.Data.SqlClient;
using Dapper;
using System.Threading.Tasks;

namespace MovieApp.Repository
{
    public class MovieGenreRepo 
    {
        public async Task<IEnumerable<MovieGenre>> GetAllAsync()
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.connectionstring))
            {
                var result = await connection.QueryAsync<MovieGenre>("Select MovieId, GenreId from MovieGenre");
                return result;
            }
        }
    }
}
