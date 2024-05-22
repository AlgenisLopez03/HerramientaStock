using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;
using System.Security.Cryptography.X509Certificates;

namespace CapaDato
{
    public class UserPass:CD_Conexion
    {
        public bool Login(String user, String pass)
        {
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand()) {
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Users WHERE LoginName = @user AND Password = @pass;";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.IdUser = reader.GetInt32(0);
                            UserLoginCache.FirstName = reader.GetString(3);
                            UserLoginCache.LastName = reader.GetString(4);
                            UserLoginCache.Position =reader.GetString(5);
                            UserLoginCache.Email = reader.GetString(6);

                        }
                       return true;
                    }
                    else 
                   return false;
                }
            }
            
           
        }//con este metodo le puedo dar privilegio a mis usuario

                      public void AnyMethod()
                         {
                        if (UserLoginCache.Position == CargosINV.Administrator) {  
                                            
                        }if (UserLoginCache.Position == CargosINV.General)
                         {

                         }

                      }
    }
}
