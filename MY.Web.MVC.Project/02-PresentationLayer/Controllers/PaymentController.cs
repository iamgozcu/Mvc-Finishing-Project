using _01_BusinesLayer.Repositories;
using Iyzipay;
using Iyzipay.Model;
using Iyzipay.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_PresentationLayer.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        public ActionResult Index()
        {
            decimal kargo = 0;
            int adet = 0;
            decimal toplamTutar = 0;
            decimal sepetToplamTutar = 0;
            BasketRepository sepetim = (BasketRepository)Session["sepet"];
            if (sepetim != null)
            {
                foreach (int i in sepetim.urunler.Keys)
                {
                    adet = sepetim.urunler[i].Piece;
                    kargo = Convert.ToInt32(sepetim.urunler[i].CargoPrice) * adet;
                    toplamTutar = sepetim.urunler[i].Total + kargo;
                    sepetToplamTutar += toplamTutar;
                }
            }

            CreateCheckoutFormInitializeRequest request = new CreateCheckoutFormInitializeRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.Price = "1";
            request.PaidPrice = "222.2";
            request.Currency = Currency.TRY.ToString();
            request.BasketId = "B67832";
            request.PaymentGroup = PaymentGroup.PRODUCT.ToString();
            request.CallbackUrl = "http://localhost:17738/Payment/ResultBank";

            List<int> enabledInstallments = new List<int>();
            enabledInstallments.Add(2);
            enabledInstallments.Add(3);
            enabledInstallments.Add(6);
            enabledInstallments.Add(9);
            request.EnabledInstallments = enabledInstallments;

            Buyer buyer = new Buyer();
            buyer.Id = "BY789";
            buyer.Name = "John";
            buyer.Surname = "Doe";
            buyer.GsmNumber = "+905350000000";
            buyer.Email = "email@email.com";
            buyer.IdentityNumber = "74300864791";
            buyer.LastLoginDate = "2015-10-05 12:43:35";
            buyer.RegistrationDate = "2013-04-21 15:12:09";
            buyer.RegistrationAddress = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            buyer.Ip = "85.34.78.112";
            buyer.City = "Istanbul";
            buyer.Country = "Turkey";
            buyer.ZipCode = "34732";
            request.Buyer = buyer;

            Address shippingAddress = new Address();
            shippingAddress.ContactName = "Jane Doe";
            shippingAddress.City = "Istanbul";
            shippingAddress.Country = "Turkey";
            shippingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            shippingAddress.ZipCode = "34742";
            request.ShippingAddress = shippingAddress;

            Address billingAddress = new Address();
            billingAddress.ContactName = "Jane Doe";
            billingAddress.City = "Istanbul";
            billingAddress.Country = "Turkey";
            billingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            billingAddress.ZipCode = "34742";
            request.BillingAddress = billingAddress;

            List<BasketItem> basketItems = new List<BasketItem>();
            BasketItem firstBasketItem = new BasketItem();
            firstBasketItem.Id = "BI101";
            firstBasketItem.Name = "Binocular";
            firstBasketItem.Category1 = "Collectibles";
            firstBasketItem.Category2 = "Accessories";
            firstBasketItem.ItemType = BasketItemType.PHYSICAL.ToString();
            firstBasketItem.Price = "0.3";
            basketItems.Add(firstBasketItem);

            BasketItem secondBasketItem = new BasketItem();
            secondBasketItem.Id = "BI102";
            secondBasketItem.Name = "Game code";
            secondBasketItem.Category1 = "Game";
            secondBasketItem.Category2 = "Online Game Items";
            secondBasketItem.ItemType = BasketItemType.VIRTUAL.ToString();
            secondBasketItem.Price = "0.5";
            basketItems.Add(secondBasketItem);

            BasketItem thirdBasketItem = new BasketItem();
            thirdBasketItem.Id = "BI103";
            thirdBasketItem.Name = "Usb";
            thirdBasketItem.Category1 = "Electronics";
            thirdBasketItem.Category2 = "Usb / Cable";
            thirdBasketItem.ItemType = BasketItemType.PHYSICAL.ToString();
            thirdBasketItem.Price = "0.2";
            basketItems.Add(thirdBasketItem);
            request.BasketItems = basketItems;

            Options op = new Options();
            op.ApiKey = "sandbox-4qe5Bt7swzzJZ3rJaaGvj2CmUvNVMGpU";
            op.SecretKey = "sandbox-fm5wbKx0Dx3t09pGa75kwRrUjgXuJkQT";
            op.BaseUrl = "https://sandbox-api.iyzipay.com";

            CheckoutFormInitialize checkoutFormInitialize = CheckoutFormInitialize.Create(request, op);


            Response.Write(checkoutFormInitialize.CheckoutFormContent);
            Session["token"] = checkoutFormInitialize.Token;
            return View();
        }
        public ActionResult ResultBank()
        {
            Response.Write(Session["token"] + " token");
            Options op = new Options();
            op.ApiKey = "sandbox-4qe5Bt7swzzJZ3rJaaGvj2CmUvNVMGpU";
            op.SecretKey = "sandbox-fm5wbKx0Dx3t09pGa75kwRrUjgXuJkQT";
            op.BaseUrl = "https://sandbox-api.iyzipay.com";

            RetrieveCheckoutFormRequest request = new RetrieveCheckoutFormRequest();
            request.ConversationId = "123456789";
            request.Token = Session["token"].ToString();

            CheckoutForm checkoutForm = CheckoutForm.Retrieve(request, op);

            Response.Write("payment statüs : " + checkoutForm.PaymentStatus + "<br>");
            Response.Write(" Status : " + checkoutForm.Status + "<br>");
            Response.Write(" Status : " + checkoutForm.Installment.Value + "<br>");
            Response.Write("payment Price : " + checkoutForm.Price + "<br>");
            Response.Write("payment PaidPrice : " + checkoutForm.PaidPrice + "<br>");
            Response.Write("payment IyziCommissionFee : " + checkoutForm.IyziCommissionFee + "<br>");
            Response.Write("payment IyziCommissionRateAmount : " + checkoutForm.IyziCommissionRateAmount + "<br>");
            Response.Write("payment MerchantCommissionRate : " + checkoutForm.MerchantCommissionRate + "<br>");
            Response.Write("payment MerchantCommissionRateAmount : " + checkoutForm.MerchantCommissionRateAmount + "<br>");
            Response.Write("payment Token : " + checkoutForm.Token + "<br>");
            return View();
        }
    }
}