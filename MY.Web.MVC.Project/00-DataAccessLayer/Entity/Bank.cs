using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class Bank
    {
        public int BankId { get; set; }
        public string BankName { get; set; }
        public string BankImage { get; set; }
        public string AccountNumber { get; set; }
        public string AccountOwner { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
        public string AccountType { get; set; }
        public string IbanNo { get; set; }
    }
}
