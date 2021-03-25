using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Models;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace MovieApp.Repository
{
    public class CastRepo : IRepository<Cast>
    {

        public int Delete(int id)
        { 
            SqlConnection connection = new SqlConnection(DbHelper.connectionstring);
            try
            {
                return connection.Execute("Delete from Cast where id=@id");
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

        public IEnumerable<Cast> GetAll()
        {
            SqlConnection connection = new SqlConnection(DbHelper.connectionstring);
            try
            {
                return connection.Query<Cast>("Select id,Name,Gender,TmdbUrl,ProfilePath from Cast");
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

        public Cast GetById(int id)
        {
            SqlConnection connection = new SqlConnection(DbHelper.connectionstring);
            try
            {
                return connection.QueryFirstOrDefault<Cast>("Select id,Name,Gender,TmdbUrl,ProfilePath from Cast where id=@id", new { id = id });

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

        public int Insert(Cast item)
        {
            SqlConnection connection = new SqlConnection(DbHelper.connectionstring);
            try
            {
                // connection.Execute("insert into Dept values (@deptName,@location)", new { deptName = item.DName, location = item.Loc });

                return connection.Execute("insert into Cast values (@id,@Name,@Gender,@TmdbUrl,@ProfilePath)", item);
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

        public int Update(Cast item)
        {
            SqlConnection connection = new SqlConnection(DbHelper.connectionstring);
            try
            {

                return connection.Execute("update Cast set Name = @Name,Gender=@Gender,TmdbUrl=@TmdbUrl,ProfilePath = @ProfilePath where id=@id,)", item);
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
