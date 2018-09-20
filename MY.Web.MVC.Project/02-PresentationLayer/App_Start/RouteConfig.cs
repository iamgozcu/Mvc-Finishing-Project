using System.Web.Mvc;
using System.Web.Routing;

namespace _02_PresentationLayer
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "Contact",
            url: "Contact",
            defaults: new { controller = "Contact", action = "Index" },
            namespaces: new[] { "_02_PresentationLayer.Controllers" }
           );

            routes.MapRoute(
           name: "Basket",
           url: "Basket",
           defaults: new { controller = "Basket", action = "Index" },
           namespaces: new[] { "_02_PresentationLayer.Controllers" }
          );

            routes.MapRoute(
            name: "Checkout",
            url: "Checkout",
            defaults: new { controller = "Checkout", action = "Index" },
            namespaces: new[] { "_02_PresentationLayer.Controllers" }
           );


            routes.MapRoute(
            name: "Payment",
            url: "Payment",
            defaults: new { controller = "Payment", action = "Index" },
            namespaces: new[] { "_02_PresentationLayer.Controllers" }
           );


            routes.MapRoute(
           name: "Customer",
           url: "Customer",
           defaults: new { controller = "Customer", action = "Create" },
           namespaces: new[] { "_02_PresentationLayer.Controllers" }
          );

            routes.MapRoute(
             name: "ProductGrid",
             url: "ProductGrid/{ProductGridSeoUrl}",
             defaults: new { controller = "ProductGrid", action = "Index" },
             namespaces: new[] { "_02_PresentationLayer.Controllers" }
             );

            routes.MapRoute(
             name: "SingleProduct",
             url: "{seourl}",
             defaults: new { controller = "SingleProduct", action = "Index" },
             namespaces: new[] { "_02_PresentationLayer.Controllers" }
             );

            routes.MapRoute(
            "ItemDetailsWithSender",
            "Products/Item/{id}/{sender}",
            new { controller = "Products", action = "Item" }
            );



            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "_02_PresentationLayer.Controllers" }
            );
        }
    }
}
