using _00_DataAccessLayer.Entity;
using _00_DataAccessLayer.ViewModel;
using _01_BusinesLayer.Repositories;
using _02_PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_PresentationLayer.Controllers
{
    public class CheckoutController : Controller
    {
        // GET: Checkout
        DistrictRepository districtRepo = new DistrictRepository();
        CityRepository cityRepo = new CityRepository();
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public JsonResult SetUye(string ad, string soyad, string Eposta, string Firma,
                            string Vergi_Dairesi, string Vergi_No, string GSM, string Telefon,
                            string sehir, string ilce, string adres, string not, string fatura_Ad, string fatura_Soyad,
                            string fatura_E_posta, string fatura_Firma, string fatura_Vergi_Dairesi,
                            string fatura_Vergi_No, string fatura_GSM, string fatura_Telefon,
                            string fatura_Sehir, string fatura_Ilce, string fatura_Adres)
        {
            KisiBilgileri uyeler = new KisiBilgileri();
            uyeler.UyeID = 1;
            uyeler.ad = ad;
            uyeler.soyad = soyad;
            uyeler.Eposta = Eposta;
            uyeler.Firma = Firma;
            uyeler.Vergi_Dairesi = Vergi_Dairesi;
            uyeler.Vergi_No = Vergi_No;
            uyeler.GSM = GSM;
            uyeler.Telefon = Telefon;
            uyeler.sehir = sehir;
            uyeler.ilce = ilce;
            uyeler.adres = adres;
            uyeler.not = not;
            uyeler.fatura_Ad = fatura_Ad;
            uyeler.fatura_Soyad = fatura_Soyad;
            uyeler.fatura_E_posta = fatura_E_posta;
            uyeler.fatura_Firma = fatura_Firma;
            uyeler.fatura_Vergi_Dairesi = fatura_Vergi_Dairesi;
            uyeler.fatura_Vergi_No = fatura_Vergi_No;
            uyeler.fatura_GSM = fatura_GSM;
            uyeler.fatura_Telefon = fatura_Telefon;
            uyeler.fatura_Sehir = fatura_Sehir;
            uyeler.fatura_Ilce = fatura_Ilce;
            uyeler.fatura_Adres = fatura_Adres;
            S_KisiKayit kisileriSessionEkle = new S_KisiKayit();
            kisileriSessionEkle.Ekle(uyeler);
            HttpContext.Session["KisiBilgileri"] = kisileriSessionEkle;
            return Json(new {success = true,responseText = "başarılı"}, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]

        public JsonResult ilceler(string ilId)
        {
            string result = null;
            int ilConvert = Convert.ToInt32(ilId);
            List<District> district= districtRepo.GetAllCityId(Convert.ToInt32(ilConvert));
            result += "<select name='ilce' class='select' style='padding: 7px;' id='ilce'> <option value='0'> İlçe </option>";

            foreach (var item in district)
            {
                result += "<option value='" + item.DistrictId + "'>" + item.DistrictName + "</option>";
            }
            result += "</select>";
            return Json(new { success = true, responseText = result }, JsonRequestBehavior.AllowGet);
        }


        [ChildActionOnly]
        public ActionResult CityListPartial()
        {
            List<City> city = cityRepo.GetAll();
            ViewBag.CityList = city;
            return View();
        }

        [HttpPost]
        public JsonResult sehirGet()
        {
            string cevap = "";
           // cevap += "<select name='sehir' class='select' style='padding: 7px;' id='sehir'> <option value='0'> Şehir </option>";
            List<City> city = cityRepo.GetAll();
            cevap += "<option value='0'> Şehir </option>";
            foreach (var item in city)
            {
                cevap += "<option value='" + item.ProvincialIdentificationNo + "'>" + item.CityName + "</option>";
            }

            //cevap += "</select>";

            return Json(new { success = true, responseText = cevap }, JsonRequestBehavior.AllowGet);
        }

      
    }
}