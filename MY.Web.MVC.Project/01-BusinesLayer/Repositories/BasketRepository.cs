using _00_DataAccessLayer.ViewModel;
using System.Collections.Generic;

namespace _01_BusinesLayer.Repositories
{
    public class BasketRepository
    {
        public Dictionary<int, BasketModel> urunler = null;
        public BasketRepository()
        {
            urunler = new Dictionary<int, BasketModel>();
        }
        public void Ekle(BasketModel u)
        {
            if (urunler.ContainsKey(u.ProductId))
            {
                urunler[u.ProductId].Piece += u.Piece;
            }
            else {
                urunler.Add(u.ProductId, u);
            }
        }

    }
}
