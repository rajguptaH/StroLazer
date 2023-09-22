using Dapper;
using System.Data;
using System.Text.Json;
using System.Text.Json.Serialization;
using WebApiCrud.Library.Connection.Interface;
using WebApiCrud.Models;
using WebApiCrud.Utility.Data.Service.Interface;

namespace WebApiCrud.Utility.Data.Service
{
    public class UserService : IUserService
    {
        private readonly IConnectionBuilder _connectionBuilder;
        public UserService(IConnectionBuilder connectionBuilder)
        {
            _connectionBuilder = connectionBuilder;
        }
        public bool Delete(int id)
        {
            using (IDbConnection con = _connectionBuilder.GetConnection)
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", id);
                con.Execute("DeleteUser", parameters, commandType: CommandType.StoredProcedure);
                return true;
            }

        }
        public List<UserModel> Get()
        {
            using IDbConnection con = _connectionBuilder.GetConnection;

            return con.Query<UserModel>("GetUser").ToList();
        }
        public List<CityModel> GetCity()
        {
            using IDbConnection con = _connectionBuilder.GetConnection;

            return con.Query<CityModel>("GetCity").ToList();
        }
        public UserModel Get(int id)
        {
            using (IDbConnection con = _connectionBuilder.GetConnection)
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@Id", id);
                return con.Query<UserModel>("GetUserById", parameter, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
        public int Insert(UserModel user)
        {
            using (IDbConnection con = _connectionBuilder.GetConnection)
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Name", user.Name);
                parameters.Add("@City", user.City);
                parameters.Add("@Address", user.Address);
                parameters.Add("@Dob", user.Dob);
                parameters.Add("@MobileNumber", user.MobileNumber);
                parameters.Add("@SalesId", user.SalesId);

                return con.Execute("InsertUser", parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public bool Update(UserModel user)
        {
            using (IDbConnection con = _connectionBuilder.GetConnection)
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", user.Id);
                parameters.Add("@Name", user.Name);
                parameters.Add("@City", user.City);
                parameters.Add("@Address", user.Address);
                parameters.Add("@Dob", user.Dob);
                parameters.Add("@MobileNumber", user.MobileNumber);
                parameters.Add("@SalesId", user.SalesId);
                con.Execute("UpdateUser", parameters, commandType: CommandType.StoredProcedure);
                return true;            
            }

        }
    }
}
