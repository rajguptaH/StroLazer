using WebApiCrud.Utility.Data.Service.Interface;
using WebApiCrud.Models;
using KeplerCrud.Repository;

namespace WebApiCrud.Utility.Data.Service
{
    public class StudentService : IStudentService
    {
        private readonly IKeplerRepository<StudentModel> _keplerRepository;
        public StudentService(IKeplerRepository<StudentModel> keplerRepository) 
        { 
            _keplerRepository = keplerRepository;
        }

        public bool Delete(int id)
        {
           return _keplerRepository.SoftDelete(id);
          
        }

        public List<StudentModel> Get()
        {
            return _keplerRepository.GetAll(false);
        }

        public StudentModel Get(int id)
        {
            List<ConditionPair> conditionPairs = new List<ConditionPair>
            {
                new ConditionPair() { Value = $"{id}", Where = "Id" }
            };
            return _keplerRepository.Get(conditionPairs,true);
        }

        public int Insert(StudentModel uiPageTypeModel)
        {
            var result = _keplerRepository.Insert(uiPageTypeModel);
            if (result)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public bool Update(StudentModel uiPageTypeModel)
        {
           return _keplerRepository.Update(uiPageTypeModel);
        }
    }
}
