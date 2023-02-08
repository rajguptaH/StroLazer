using KeplerCrud.Utility;

namespace WebApiCrud.Models
{
    [KeplerTable("Student")]
    public class StudentModel
    {
        [KeplerColumn("Id")]
        public int Id { get; set; }
        [KeplerColumn("Name")]
        public string Name { get; set; }
        [KeplerColumn]
        public int RollNo { get; set; }
        [KeplerColumn]
        public string Class { get; set; }
        [KeplerColumn]
        public string Address { get; set; }
    }
}
