using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class Setting
    {
        public int SettingId { get; set; }
        public string BasketLimitKeeps { get; set; }
        public string OrderEmailAddress { get; set; }
        public string ContactMailAddress { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string CompanyName { get; set; }
        public string GSM { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public string Map { get; set; }
        public string CompanyNumber { get; set; }
        public string Slogan { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Linkedin { get; set; }
        public string Google { get; set; }
    }
}
