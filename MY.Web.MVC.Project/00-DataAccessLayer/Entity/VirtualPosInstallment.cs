using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class VirtualPosInstallment
    {
        public int InstallmentId { get; set; }
        public int BankId { get; set; }
        public int NumberOfInstallment { get; set; }
        public string InstallmentRate { get; set; }
        public bool ActivePassive { get; set; }
    }
}
