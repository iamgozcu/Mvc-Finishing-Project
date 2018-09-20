namespace _00_DataAccessLayer.ViewModel
{
    public class BasketModel
     //view model görünecek modeller
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string PhotoPath { get; set; }
        public decimal Price { get; set; }
        public int Piece { get; set; }
        public int CargoPrice { get; set; }
        public string ShortDescription { get; set; }
        public decimal Total
        {
            get { return Piece * Price; }//burda ne yapılıyor.
        }
       
    }
}
    