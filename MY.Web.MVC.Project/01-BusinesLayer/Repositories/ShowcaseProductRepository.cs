using _00_DataAccessLayer.Entity;
using _00_DataAccessLayer.Models;
using _00_DataAccessLayer.ViewModel;
using _01_BusinesLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BusinesLayer.Repositories
{
    public class ShowcaseProductRepository : IRepository<ShowcaseProduct>
    {
        private readonly MYProjectContext db;
        private readonly IDbSet<ShowcaseProduct> showcaseproducts;
        private readonly ShowcaseRepository showcaseRepository;
        private readonly ProductRepository productRepository;
        private readonly ProductImageRepository productImageRepository;
        public ShowcaseProductRepository()
        {
            db = new MYProjectContext();
            showcaseproducts = db.Set<ShowcaseProduct>();
            showcaseRepository = new ShowcaseRepository();
            productRepository = new ProductRepository();
            productImageRepository = new ProductImageRepository();
        }
        public void Delete(ShowcaseProduct data)
        {
            db.Entry(data).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public List<ShowcaseProduct> GetAll()
        {
            var showcaseprod = new List<ShowcaseProduct>();
            showcaseprod = showcaseproducts.ToList();
            return showcaseprod;
        }

        public void Insert(ShowcaseProduct data)
        {
            db.Entry(data).State = EntityState.Added;
            db.SaveChanges();
        }

        public ShowcaseProduct SelectById(int id)
        {
            return showcaseproducts.FirstOrDefault(x => x.ShowcaseProductId == id);
        }

        public ShowcaseProduct SelectByShowcaseProductId(int productId, string showcaseId)
        {
            int ShowcaseID = Convert.ToInt32(showcaseId);
            var sowcaseProductFirst = (from i in showcaseproducts where i.ProductId == productId && i.ShowcaseProductTopId == ShowcaseID select i).SingleOrDefault();
            ShowcaseProduct sowcaseProduct = sowcaseProductFirst;
            return sowcaseProduct;
        }

        public void Update(ShowcaseProduct data)
        {
            db.Entry(data).State = EntityState.Modified;
            db.SaveChanges();
        }

        public List<ShowcaseProduct> FirstByProductId(int id)
        {
            return showcaseproducts.Where(x => x.ShowcaseProductTopId == id).ToList();
        }

        public List<ShowcaseProduct> GetProductId(int id)
        {
            return showcaseproducts.Where(x => x.ProductId == id).ToList();
        }
        public ShowcaseProductListModel ShowcaseProductListModel()
        {
            ShowcaseProductListModel model = new ShowcaseProductListModel();
            model.ShowcaseProduct = showcaseproducts.ToList();
            model.Showcase = showcaseRepository.GetAll();
            model.Product = productRepository.GetAll();
            List<ProductImage> listProductImage = new List<ProductImage>();
            foreach (var item in model.Product)
            {
                ProductImage productimage= productImageRepository.FirstByProductId(item.ProductId);
                listProductImage.Add(productimage);
            }
            model.ProductImage = listProductImage;
            return model;
        }

        
    }
}
