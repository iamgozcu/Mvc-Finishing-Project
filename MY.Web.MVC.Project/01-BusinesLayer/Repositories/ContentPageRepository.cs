using _00_DataAccessLayer.Entity;
using _00_DataAccessLayer.Models;
using _01_BusinesLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BusinesLayer.Repositories
{
    public class ContentPageRepository : IRepository<ContentPage>
    {
        private readonly MYProjectContext db;
        private readonly IDbSet<ContentPage> contentPages;
        public ContentPageRepository()
        {
            db = new MYProjectContext();
            contentPages = db.Set<ContentPage>();
        }
        public void Delete(ContentPage data)
        {
            db.Entry(data).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public List<ContentPage> GetAll()
        {
            List<ContentPage> contentPage = new List<ContentPage>();
            contentPage = contentPages.ToList();
            return contentPage;
        }

        public void Insert(ContentPage data)
        {
            db.Entry(data).State = EntityState.Added;
            db.SaveChanges();
        }

        public ContentPage SelectById(int id)
        {
            return contentPages.FirstOrDefault(x => x.PageId == id);
        }

        public void Update(ContentPage data)
        {
            db.Entry(data).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
