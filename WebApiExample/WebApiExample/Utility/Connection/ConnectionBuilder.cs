using System.Data;
using System.Data.SqlClient;
using WebApiCrud.Library.Connection.Interface;

namespace WebApiCrud.Library.Connection
{

    public class ConnectionBuilder : IConnectionBuilder 
    {
        private readonly IConfiguration _configuration;
        public ConnectionBuilder(IConfiguration configuration)
        {
          _configuration = configuration;
        }
        public IDbConnection GetConnection
        {
            get
            {
                {
                    try
                    {
                        SqlConnection connection = new SqlConnection(_configuration["ConnectionStrings:Value"]);
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
