using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Models;
using System.Data.SqlClient;
using Dapper;
using System.Threading.Tasks;

namespace MovieApp.Repository
{
    public class MovieRepo
    {
        public IEnumerable<Movie> GetAllWithGenre()
        {
            SqlConnection connection = new SqlConnection(DbHelper.connectionstring);
            try
            {
                string cmd = "Select m.Title,g.Name from Movie m inner join Genre g on m.Id = g.Id";
                return connection.Query<Movie, Genre, Movie>(cmd, (m, g) => { m.Genre = g ; return m; });

            }
            catch (Exception ex)
            { }
            finally
            {
                connection.Dispose();
            }
            return null;
        }


        public async Task<IEnumerable<Movie>> GetAllAsync()
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.connectionstring))
            {
                var result = await connection.QueryAsync<Movie>("Select Id,Title from Movie");
                return result;
            }
        }

        public IEnumerable<Movie> GetAll()
        {
            SqlConnection connection = new SqlConnection(DbHelper.connectionstring);
            try
            {
                return connection.Query<Movie>("Select Id,Title from Movie");
            }
            catch (Exception ex)
            {
                //log exception using logger in a flat file/database or somewhere else
            }
            finally
            {
                connection.Dispose();
            }
            return null;
        }
        

    }
}
