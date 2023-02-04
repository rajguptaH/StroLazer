using System.Data;
using System.Data.SqlClient;
using WebApiCrud.Library.Connection.Interface;

namespace WebApiCrud.Library.Connection
{

    public class ConnectionBuilder : IConnectionBuilder 
    { 

        public ConnectionBuilder()
        {
          
        }
        public IDbConnection GetConnection
        {
            get
            {
                {
                  
                        var connectionString = "Server=localhost;Database=Maui; User ID=sa;Password=admin;";
                    try
                    {
                        SqlConnection connection = new SqlConnection(connectionString);
                        return connection;
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }
                    
                    
                    
                }
            }
        }
    }
}
