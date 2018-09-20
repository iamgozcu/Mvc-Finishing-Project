using System;
using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class ProductImage
    {
        public int ImageId { get; set; }
        public string Path { get; set; }
        public int ProductId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
