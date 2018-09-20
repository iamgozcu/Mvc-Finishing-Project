using System;
using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class Cargo
    {
        public int CargoId { get; set; }
        public string CargoName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CargoImage { get; set; }
    }
}
