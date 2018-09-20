using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class VirtualPosBank
    {
        public int BankId { get; set; }
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string Bank3DLink { get; set; }
        public string BankMemberId { get; set; }
        public string BankAnswer { get; set; }
        public string Bank3DSecurity { get; set; }
        public string BankImage { get; set; }
        public bool AktivePassive { get; set; }
        public int BankSort { get; set; }
    }
}
