using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class Administrator 
    //Varlıklar burda oluşturulur bunlar tablolarımızı oluşturacak
    {
        public int AdminId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmailAdress { get; set; }
        public bool IsActive { get; set; }
        public int Role { get; set; }
        public string Path { get; set; }
    }
}
