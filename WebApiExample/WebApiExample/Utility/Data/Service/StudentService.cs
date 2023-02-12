using KeplerCrud.Repository;
using System.Data;
using WebApiCrud.Library.Connection.Interface;
using WebApiCrud.Models;
using WebApiCrud.Utility.Data.Service.Interface;

namespace WebApiCrud.Utility.Data.Service
{
    public class StudentService : IStudentService
    {
        private readonly IConnectionBuilder _connectionBuilder;
        public StudentService(IConnectionBuilder connectionBuilder)
        {
            _connectionBuilder = connectionBuilder;
        }
        public bool Delete(int id)
        {
            using IDbConnection con = _connectionBuilder.GetConnection;
            return con.SoftDelete<StudentModel>(id);

        }
        public List<StudentModel> Get()
        {
            using IDbConnection con = _connectionBuilder.GetConnection;
            var result = con.GetAll<StudentModel>(true);
            return result;
        }
        public StudentModel Get(int id)
        {
            using IDbConnection con = _connectionBuilder.GetConnection;
            List<ConditionPair> conditionPairs = new List<ConditionPair>
            {
                new ConditionPair() { Value = $"{id}", Where = "Id" }
            };
            return con.Get<StudentModel>(conditionPairs, false);
        }
        public int Insert(StudentModel uiPageTypeModel)
        {
            using IDbConnection con = _connectionBuilder.GetConnection;
            var result = con.Insert(uiPageTypeModel);
            return result ? 1 : 0;
        }
        public bool Update(StudentModel uiPageTypeModel)
        {
            using IDbConnection con = _connectionBuilder.GetConnection;
            return con.Update(uiPageTypeModel);
        }
    }
}
