using System.Collections.Generic;

namespace _02_PresentationLayer.Models
{
    public class S_KisiKayit
    {
        public Dictionary<int, KisiBilgileri> listele = null;

        public S_KisiKayit()
        {
            listele = new Dictionary<int, KisiBilgileri>();
        }
        public void Ekle(KisiBilgileri u)
        {
            listele.Add(u.UyeID, u);
        }
    }
}
