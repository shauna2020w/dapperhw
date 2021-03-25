using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Models;
using System.Data.SqlClient;
using Dapper;

namespace MovieApp.Repository
{
    public class GenreRepo : IRepository<Genre>
    {

        public int Delete(int id)
        {
            SqlConnection connection = new SqlConnection(DbHelper.connectionstring);
            try
            {
                return connection.Execute("Delete from Genre where id=@id");
            }
            catch (Exception ex)
            {
                //log exception using logger in a flat file/database or somewhere else
            }
            finally
            {
                connection.Dispose();
            }
            return 0;
        }

        public IEnumerable<Genre> GetAll()
        {
            SqlConnection connection = new SqlConnection(DbHelper.connectionstring);
            try
            {
                return connection.Query<Genre>("Select Id,Name from Genre");
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

        public Genre GetById(int Id)
        {
            SqlConnection connection = new SqlConnection(DbHelper.connectionstring);
            try
            {
                return connection.QueryFirstOrDefault<Genre>("Select Name where Id=@Id", new { Id = Id });

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

        public int Insert(Genre item)
        {
            SqlConnection connection = new SqlConnection(DbHelper.connectionstring);
            try
            {
                // connection.Execute("insert into Dept values (@deptName,@location)", new { deptName = item.DName, location = item.Loc });

                return connection.Execute("insert into Genre values (@Id,@Name)", item);
            }
            catch (Exception ex)
            {
                //log exception using logger in a flat file/database or somewhere else
            }
            finally
            {
                connection.Dispose();
            }
            return 0;
        }

        public int Update(Genre item)
        {
            SqlConnection connection = new SqlConnection(DbHelper.connectionstring);
            try
            {

                return connection.Execute("update Genre set Name = @Name where Id=@Id,)", item);
            }
            catch (Exception ex)
            {
                //log exception using logger in a flat file/database or somewhere else
            }
            finally
            {
                connection.Dispose();
            }
            return 0;
        }
    }
}
