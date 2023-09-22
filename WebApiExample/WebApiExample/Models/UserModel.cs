using KeplerCrud.Utility;

namespace WebApiCrud.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public DateTime Dob { get; set; }
        public string MobileNumber { get; set; }
        public string SalesId { get; set; }
    }
}
