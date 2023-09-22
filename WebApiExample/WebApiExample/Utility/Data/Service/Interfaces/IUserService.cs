using WebApiCrud.Models;

namespace WebApiCrud.Utility.Data.Service.Interface
{
    public interface IUserService
    {
        int Insert(UserModel uiPageTypeModel);
        List<UserModel> Get();
        UserModel Get(int id);
        bool Update(UserModel uiPageTypeModel);
        bool Delete(int id);
        List<CityModel> GetCity();
    }
}
