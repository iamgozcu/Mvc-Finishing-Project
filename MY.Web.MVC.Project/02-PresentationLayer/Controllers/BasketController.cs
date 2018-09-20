using _00_DataAccessLayer.Entity;
using _00_DataAccessLayer.ViewModel;
using _01_BusinesLayer.Repositories;
using System;
using System.Web.Mvc;

namespace _02_PresentationLayer.Controllers
{
    public class BasketController : Controller
    {
        // GET: Basket
        ProductRepository productRepo = new ProductRepository();
        ProductImageRepository productImageRepo = new ProductImageRepository();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SepetGetirSepetSayfasi()
        {
            string adi = "";
            string kisaAciklama = "";
            string resim = "";
            int adet = 0;
            int fiyat = 0;
            int UrunID;
            string cevap = "";
            BasketRepository sepetim = (BasketRepository)Session["sepet"];
            if (sepetim != null)
            {
                foreach (int i in sepetim.urunler.Keys)
                {
                    adi = sepetim.urunler[i].ProductName;
                    kisaAciklama = sepetim.urunler[i].ShortDescription;
                    resim = sepetim.urunler[i].PhotoPath;
                    adet = sepetim.urunler[i].Piece;
                    fiyat = Convert.ToInt32(sepetim.urunler[i].Price);
                    kargo = Convert.ToInt32(sepetim.urunler[i].CargoPrice) * adet;
                    toplam = Convert.ToInt32(sepetim.urunler[i].Total)+kargo;
                  
                    UrunID = sepetim.urunler[i].ProductId;
                    cevap += "<tr>" +
                                        "<td>" +
                                            "<div class='thumb'>" +
                                                "<img alt='" + adi + "' src='http://mvceticaret.6v5.org/Content/images/products/" + resim + "' />" +
                                            "</div>" +
                                        "</td>" +
                                        "<td>" +
                                            "<div class='desc'>" +
                                                "<h3>" + adi + "</h3>" +
                                                "<div class='tag-line'>" +
                                                   kisaAciklama +
                                                "</div>" +
                                                "<div class='pid'>Ürün Kodu: " + UrunID + "</div>" +
                                            "</div>" +
                                        "</td>" +
                                        "<td>" +
                                            "<div class='price'>" +
                                               fiyat.ToString("C") +
                                            "</div>" +
                                        "</td>" +
                                         "<td>" +
                                            "<div class='price'>" +
                                               kargo.ToString("C") +
                                            "</div>" +
                                        "</td>" +
                                        "<td>" +
                                            "<div class='le-quantity'>" +
                                                "<form>" +
                                                    "<a class='minus' style='cursor:pointer' onclick='sepettenindir(" + UrunID + "," + adet + ")'></a>" +
                                                    "<input name='quantity' readonly='readonly' type='text' value='" + adet + "' />" +
                                                    "<a class='plus' style='cursor:pointer' onclick='sepettenarttir(" + UrunID + "," + adet + ")'></a>" +
                                                "</form>" +
                                            "</div>" +
                                        "</td>" +
                                        "<td>" +
                                            "<div class='price'>" +
                                                toplam.ToString("C") +
                                            "</div>" +
                                        "</td>" +
                                        "<td>" +
                                            "<div class='delete'>" +
                                            "<a style='cursor:pointer' onclick='sepettensil(" + UrunID + ")'>"+
                                            "<img src='http://mvceticaret.6v5.org/Content/images/remove.png' /></a>" +
                                            "</div>" +
                                        "</td>" +
                                    "</tr>";
                }
            }

            return Json(new
            {
                success = true,
                responseText = cevap
            }, JsonRequestBehavior.AllowGet);
        }

        public int SepetteVarmi(int id)
        {
            if (Session["sepet"] == null)
            {
                return 0;
            }
            else
            {
                BasketRepository sepetim = (BasketRepository)Session["sepet"];

                foreach (int key in sepetim.urunler.Keys)
                {
                    if (id == sepetim.urunler[key].ProductId)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            return 0;
        }

        [HttpPost]
        public JsonResult CreateProductBasket(int id, int adet)
        {
            Product prod = productRepo.SelectById(id);
            ProductImage productImage = productImageRepo.FirstByProductId(id);
            BasketModel urun = new BasketModel();
            urun.ProductName = prod.ProductName;
            urun.Piece = adet;
            urun.Price = prod.ProductPrice;
            urun.ShortDescription = prod.ProductShortDescription;
            urun.CargoPrice = prod.CargoPrice;
            urun.PhotoPath = productImage.Path;
            urun.ProductId = id;

            if (Session["sepet"] == null)
            {
                BasketRepository sepetim = new BasketRepository();
                sepetim.Ekle(urun);
                Session["sepet"] = sepetim;
            }
            else
            {
                if (SepetteVarmi(urun.ProductId) == 1)
                {

                    int idd = urun.ProductId;
                    BasketRepository sepetim = (BasketRepository)Session["sepet"];
                    sepetim.urunler[idd].Piece += urun.Piece;
                    Session["sepet"] = sepetim;
                }
                else
                {
                    BasketRepository sepetim = (BasketRepository)Session["sepet"];
                    sepetim.Ekle(urun);
                    Session["sepet"] = sepetim;
                }
            }

            return Json(new { success = true, responseText = "Sepete eklenmiştir." }, JsonRequestBehavior.AllowGet);

        }


        int toplam = 0;
        int kargo = 0;
        [HttpPost]
        public JsonResult SepetGetir()
        {
            string adi = "";
            string resim = "";
            int adet = 0;
            int fiyat = 0;
            int UrunID;
            string cevap = "";
            BasketRepository sepetim = (BasketRepository)Session["sepet"];
            if (sepetim != null)
            {
                if (sepetim.urunler.Count>0)
                {

               
                foreach (int i in sepetim.urunler.Keys)
                {
                    adi = sepetim.urunler[i].ProductName;
                    resim = sepetim.urunler[i].PhotoPath;
                    adet = sepetim.urunler[i].Piece;
                    fiyat = Convert.ToInt32(sepetim.urunler[i].Price);
                    UrunID = sepetim.urunler[i].ProductId;
                    cevap += "<li>" +
                              "<div class='basket-item'>" +
                                  "<div class='row'>" +
                                      "<div class='col-xs-12 col-sm-2 col-md-4'>" +
                                          "<div class='thumb'>" +
                                          "<img src='http://mvceticaret.6v5.org/Content/images/products/" + resim + "' />" +
                                          "</div>" +
                                      "</div>" +
                                      "<div class='col-xs-12 col-sm-10 col-md-8'>" +
                                          "<div class='title'>" + adi + "</div>" +
                                          "<div class='price'>" + fiyat.ToString("C") + " X <span>" + adet + "</span></div>" +
                                      "</div>" +
                                  "</div>" +
                                "<a class='close-btn' onclick='sepettensil(" + UrunID + ")' style='cursor:pointer;'></a>" +
                              "</div>" +
                             "</li>";

                }
                cevap += "<li class='checkout'>" +
                                                "<div class='merged-buttons'>" +
                                                    "<a href='" + Url.Action("Index", "Basket") + "' class='btn-add-to-cart le-btn '>sepete git</a>" +
                                                    //"<a href='" + Url.Action("Index", "Checkout") + "' class='btn-add-to-wishlist le-btn '>ödeme yap</a>" +
                                                "</div>" +

                                            "</li>";
            }
                else
                {
                    cevap += "<li class='checkout'>Sepetinizde Ürün Bulunmamaktadır!</li>";
                }
            }
           
            else
            {
                cevap += "<li class='checkout'>Sepetinizde Ürün Bulunmamaktadır!</li>";
            }



            return Json(new
            {
                success = true,
                responseText = cevap
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult SepetSayisi()
        {

            int adet = 0;
            int toplamAdet = 0;
            string cevap = "";
            BasketRepository sepetim = (BasketRepository)Session["sepet"];
            if (sepetim != null)
            {
                foreach (int i in sepetim.urunler.Keys)
                {

                    adet = sepetim.urunler[i].Piece;
                    toplamAdet += adet;
                }
                cevap += "<span class='item-count'>" + toplamAdet + "</span>";
            }
            else
            {
                cevap += "<span class='item-count'>0</span>";
            }


            return Json(new
            {
                success = true,
                responseText = cevap
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult SepetToplam()
        {
            decimal toplamTutar = 0;
            decimal sepetToplamTutar = 0;
            string cevap = "";
            BasketRepository sepetim = (BasketRepository)Session["sepet"];
            if (sepetim != null)
            {
                foreach (int i in sepetim.urunler.Keys)
                {

                    toplamTutar = sepetim.urunler[i].Total;
                    sepetToplamTutar += toplamTutar;
                }

                cevap += "<span class='total-price'>" + sepetToplamTutar.ToString("C") + "</span>";
            }
            else
            {
                cevap += "<span class='total-price'>" + sepetToplamTutar.ToString("C") + "</span>";
            }


            return Json(new
            {
                success = true,
                responseText = cevap
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult KargoDahilSepetToplam()
        {
            int adet = 0;
            decimal toplamTutar = 0;
            decimal sepetToplamTutar = 0;
            string cevap = "";
            BasketRepository sepetim = (BasketRepository)Session["sepet"];
            if (sepetim != null)
            {
                foreach (int i in sepetim.urunler.Keys)
                {
                    adet = sepetim.urunler[i].Piece;
                    kargo = Convert.ToInt32(sepetim.urunler[i].CargoPrice) * adet;
                    toplamTutar = sepetim.urunler[i].Total+kargo;
                    sepetToplamTutar += toplamTutar;
                }

                cevap += "<span class='total-price'>" + sepetToplamTutar.ToString("C") + "</span>";
            }
            else
            {
                cevap += "<span class='total-price'>" + sepetToplamTutar.ToString("C") + "</span>";
            }


            return Json(new
            {
                success = true,
                responseText = cevap
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult KargoToplam()
        {
            int adet = 0;
            decimal kargoToplamTutar = 0;
            string cevap = "";
            BasketRepository sepetim = (BasketRepository)Session["sepet"];
            if (sepetim != null)
            {
                foreach (int i in sepetim.urunler.Keys)
                {
                    adet = sepetim.urunler[i].Piece;
                    kargo = Convert.ToInt32(sepetim.urunler[i].CargoPrice) * adet;
                    kargoToplamTutar += kargo;
                }

                cevap += "<span class='total-price'>" + kargoToplamTutar.ToString("C") + "</span>";
            }
            else
            {
                cevap += "<span class='total-price'>" + kargoToplamTutar.ToString("C") + "</span>";
            }


            return Json(new
            {
                success = true,
                responseText = cevap
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult SepetSayfasiUrunSil(int id)
        {
            string cevap = "";
            int idUrun = id;
            BasketRepository sepetim = (BasketRepository)HttpContext.Session["sepet"];
            sepetim.urunler.Remove(idUrun);
            HttpContext.Session["sepet"] = sepetim;
            cevap = "1";
            return Json(new { success = true, responseText = cevap }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult SepettenIndir(int id, int adet)
        {
            string cevap = "1";
            BasketRepository sepetim = (BasketRepository)HttpContext.Session["sepet"];
            sepetim.urunler[id].Piece = adet;
            HttpContext.Session["sepet"] = sepetim;
            return Json(new { success = true, responseText = cevap }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult SepettenArttirr(int id, int adet)
        {
            string cevap = "1";
            BasketRepository sepetim = (BasketRepository)HttpContext.Session["sepet"];
            sepetim.urunler[id].Piece = adet;
            HttpContext.Session["sepet"] = sepetim;
            return Json(new { success = true, responseText = cevap }, JsonRequestBehavior.AllowGet);
        }
    }
}