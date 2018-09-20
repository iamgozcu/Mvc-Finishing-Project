using _00_DataAccessLayer.Entity;
using _00_DataAccessLayer.Models;
using _00_DataAccessLayer.ViewModel;
using _01_BusinesLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace _01_BusinesLayer.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private readonly MYProjectContext db;
        private readonly IDbSet<Product> products;
        private readonly ProductImageRepository productImageRepo;
        private readonly BrandRepository brandRepo;
        private readonly CategoryRepository categoryRepo;
        private readonly ProductCategoryRepository productCategoryRepo;
        private readonly IDbSet<ShowcaseProduct> showcaseProducts;

        public ProductRepository()
        {
            db = new MYProjectContext();
            products = db.Set<Product>();
            showcaseProducts = db.Set<ShowcaseProduct>();
            productImageRepo = new ProductImageRepository();
            categoryRepo = new CategoryRepository();
            brandRepo = new BrandRepository();
            productCategoryRepo = new ProductCategoryRepository();
        }

        public void Delete(Product data)
        {
            db.Entry(data).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public List<Product> GetAll()
        {
            var prod = new List<Product>();
            prod = products.ToList();
            return prod;
        }

        public void Insert(Product data)
        {
            db.Entry(data).State = EntityState.Added;
            db.SaveChanges();
        }

        public Product SelectById(int id)
        {
            return products.FirstOrDefault(x => x.ProductId == id);
        }
        public void Update(Product data)
        {
            db.Entry(data).State = EntityState.Modified;
            db.SaveChanges();
        }

        public List<ProductListModel> ProductListModel()
        {
            var list = new List<ProductListModel>();
            foreach (var item in products)
            {
                ProductImage pi = productImageRepo.FirstByProductId(item.ProductId);
                list.Add(new ProductListModel(item, pi));
            }
            return list;
        }

        public List<ProductListModel> ShowcaseProductListModel(int id)
        {
            List<ShowcaseProduct> showcaseprod = showcaseProducts.Where(x => x.ShowcaseProductTopId == id).ToList();
            List<Product> productList = new List<Product>();
            foreach (var item1 in showcaseprod)
            {
                Product p = products.FirstOrDefault(x => x.ProductId == item1.ProductId);
                productList.Add(p);
            }
            var list = new List<ProductListModel>();
            foreach (var item in productList)
            {
                ProductImage pi = productImageRepo.FirstByProductId(item.ProductId);
                list.Add(new ProductListModel(item, pi));
            }
            return list;
        }

        public List<ProductDetailListModel> ProductDetailListModel(string seourl)
        {
            var list = new List<ProductDetailListModel>();
            Product product = products.FirstOrDefault(p => p.SeoUrl == seourl);
            Brand brand = brandRepo.SelectById(product.BrandId);
            List<ProductImage> pi = productImageRepo.FirstByProductImageId(product.ProductId);
            list.Add(new ProductDetailListModel(product, pi, brand));
            return list;
        }

        public Product GetAllFirstProd(int id)
        {
            Product prod = new Product();
            prod = products.Where(x => x.ProductId == id).FirstOrDefault();
            return prod;
        }

        //ProductCategoryListModel silinecek
        public List<Category> ProductCategoryList(string seoUrl)
        {
            Category cat = categoryRepo.GetAllFirstCat(seoUrl);
            List<Category> sonuc = categoryRepo.GetAllFirstCat1(cat.SubCategoryId);
            return sonuc;
        }

        public Category ProductCategorySubList(string seoUrl)
        {
            Category cat = categoryRepo.GetAllFirstCat(seoUrl);
            Category sonuc = categoryRepo.GetAllFirstSubCat1(cat.SubCategoryId);
            return sonuc;
        }

        public List<ProductListModel> ProductListModel1(string seoUrl)
        {
            Category cat = categoryRepo.GetAllFirstCat(seoUrl);
            List<ProductCategory> cat1 = productCategoryRepo.GetCategoryId(cat.CategoryId);

            Product prod = new Product();
            List<Product> prod1 = new List<Product>();
            foreach (var item in cat1)
            {
                prod = GetAllFirstProd(item.ProductId);
                prod1.Add(prod);
            }

            var list = new List<ProductListModel>();
            foreach (var item in prod1)
            {
                ProductImage pi = productImageRepo.FirstByProductId(item.ProductId);
                list.Add(new ProductListModel(item, pi));
            }
            return list;
        }

        public List<ProductBrandModel> ProductGridBrand(string seoUrl)
        {
            Category cat = categoryRepo.GetAllFirstCat(seoUrl);
            List<ProductCategory> cat1 = productCategoryRepo.GetCategoryId(cat.CategoryId);
            Product prod = new Product();
            List<Product> prod1 = new List<Product>();
            foreach (var item in cat1)
            {
                prod = GetAllFirstProd(item.ProductId);
                prod1.Add(prod);
            }

            var list = new List<ProductBrandModel>();
            foreach (var item in prod1)
            {
                Brand pi = brandRepo.SelectById(item.BrandId);
                list.Add(new ProductBrandModel(item, pi));
            }
            return list;
        }

        public List<string> Search(string name)
        {
            return products.Where(p => p.ProductName.StartsWith(name, StringComparison.OrdinalIgnoreCase)).Select(p => p.ProductName).ToList();
        }

    }
}