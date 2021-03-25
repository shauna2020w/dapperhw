using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Models;
using System.Data.SqlClient;
using Dapper;
using System.Threading.Tasks;


namespace MovieApp.Repository
{
    public class MovieCastRepo
    {
        public async Task<IEnumerable<MovieCast>> GetAllAsync()
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.connectionstring))
            {
                var result = await connection.QueryAsync<MovieCast>("Select MovieId, CastId,Character from MovieCast");
                return result;
            }
        }
    }
   
}
