using System;
using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class Statistic
    {
        public int StatisticId { get; set; }
        public string IP { get; set; }
        public DateTime Date { get; set; }
        public string Page { get; set; }
        public string Language { get; set; }
    }
}
