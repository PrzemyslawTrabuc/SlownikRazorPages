using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Slownik.Repository;
using Slownik.Entity;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Dapper;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Security.Claims;

namespace Slownik.Repository
{
    public class SlowaRepository : ISlowaRepository
    {
        IConfiguration _configuration;   


        public SlowaRepository(IConfiguration configuration)
        {

            _configuration = configuration;
        }       
        
        public int Add(Slowa slowo)
        {
            var connectionString = this.GetConnection();
            int count = 0;            
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var query = "INSERT INTO Slowa(polski, angielski) VALUES(@polski, @angielski);  SELECT CAST(SCOPE_IDENTITY() as INT);";
                    count = con.Execute(query, slowo);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }

                return count;
            }
        }

        public int DeleteSlowo(int id)
        {
            var connectionString = this.GetConnection();
            var count = 0;

            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var query = "DELETE FROM Slowa WHERE Id =" + id;
                    count = con.Execute(query);                 
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }

                return count;
            }
        }

        public int DeleteUlubioneSlowo(int id)
        {
            var connectionString = this.GetConnection();
            var count = 0;

            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var query = "DELETE FROM Ulubione WHERE Id =" + id;
                    count = con.Execute(query);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }

                return count;
            }
        }

        public int SaveSlowo(int id, string user_id)
        {
            var connectionString = this.GetConnection();
            var count = 0;

            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var query = "INSERT INTO Ulubione (User_ID, polski, angielski) SELECT '"+user_id+"', polski, angielski FROM Slowa WHERE Id="+id;
                    count = con.Execute(query);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }

                return count;
            }
        }

        public int EditSlowo(Slowa product)
        {
            var connectionString = this.GetConnection();
            var count = 0;

            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var query = "UPDATE Slowa SET polski = @polski, angielski = @angielski  WHERE Id = @Id";
                    count = con.Execute(query, product);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }

                return count;
            }
        }

        public List<Slowa> GetList()
        {
            var connectionString = this.GetConnection();
            List<Slowa> products = new List<Slowa>();

            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var query = "SELECT * FROM Slowa ORDER BY polski ASC";
                    products = con.Query<Slowa>(query).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }

                return products;
            }
        }

        public Slowa GetSlowo(int id)
        {
            var connectionString = this.GetConnection();
            Slowa product = new Slowa();

            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var query = "SELECT * FROM Slowa WHERE Id =" + id;
                    product = con.Query<Slowa>(query).FirstOrDefault();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }

                return product;
            }
        }
        public List<Slowa> SzukaneGetList(string search)
        {
            var connectionString = this.GetConnection();
            List<Slowa> products = new List<Slowa>();          
                using (var con = new SqlConnection(connectionString))
                {

                    try
                    {
                        con.Open();
                        var query = "SELECT * FROM Slowa WHERE polski LIKE" + " N'%" + search + "%'" + " OR angielski LIKE" + " N'%" + search + "%'";
                        products = con.Query<Slowa>(query).ToList();                    
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        con.Close();
                    }

                    return products;
                }                
                      
        }

        public List<Slowa> UserGetList(string user_id)
        {                     
            var connectionString = this.GetConnection();
            List<Slowa> products = new List<Slowa>();
            using (var con = new SqlConnection(connectionString))
            {

                try
                {
                    con.Open();
                    var query = "SELECT * FROM Ulubione WHERE User_ID ='" + user_id+"'";
                    products = con.Query<Slowa>(query).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }

                return products;
            }

        }

        public List<Slowa> SzukaneUlubioneGetList(string search, string user_id)
        {
            var connectionString = this.GetConnection();
            List<Slowa> products = new List<Slowa>();
            using (var con = new SqlConnection(connectionString))
            {

                try
                {
                    con.Open();
                    var query = "SELECT * FROM Ulubione WHERE User_ID='"+user_id+"' AND (polski LIKE" + " N'%" + search + "%'" + " OR angielski LIKE" + " N'%" + search + "%');";
                    products = con.Query<Slowa>(query).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }

                return products;
            }

        }

        public string GetConnection()
        {
            var connection = _configuration.GetSection("ConnectionStrings2").GetSection("ProductContext").Value;
            return connection;
        }

        public string GetConnection2()
        {
            var connection = _configuration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            return connection;
        }
    }
}
