namespace _00_DataAccessLayer.Entity
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string BrandImage { get; set; }
        public bool ActivePassive { get; set; }
        public int Sorting { get; set; }
    }
}
