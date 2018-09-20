using _00_DataAccessLayer.Entity;
using _00_DataAccessLayer.Models;
using _00_DataAccessLayer.ViewModel;
using _01_BusinesLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace _01_BusinesLayer.Repositories
{
    public class SettingRepository : IRepository<Setting>
    {
        private readonly MYProjectContext db;
        private readonly IDbSet<Setting> settings;
        public SettingRepository()
        {
            db = new MYProjectContext();
            settings = db.Set<Setting>();
        }
        public void Delete(Setting data)
        {
            db.Entry(data).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public List<Setting> GetAll()
        {
            List<Setting> setting = new List<Setting>();
            setting = settings.ToList();
            return setting;
        }

        public void Insert(Setting data)
        {
            db.Entry(data).State = EntityState.Added;
            db.SaveChanges();
        }

        public Setting SelectById(int id)
        {
            return settings.FirstOrDefault(x => x.SettingId == id);
        }

        public Setting SelectById1()
        {
            return settings.FirstOrDefault();
        }

        public void Update(Setting data)
        {
            db.Entry(data).State = EntityState.Modified;
            db.SaveChanges();
        }

        public bool SendMail(SendMailModel sendmail)
        {
            try
            {
                MailMessage msj = new MailMessage();
                SmtpClient sc = new SmtpClient();
                sc.Credentials = new System.Net.NetworkCredential("info@firmabayi.com", "Mg199349");
                msj.To.Add("muhammed.yilmaz.ym@gmail.com");
                msj.From = new MailAddress("info@firmabayi.com", "dukkan.com.tr", Encoding.UTF8);
                msj.Subject = sendmail.NameSurname +" iletişim sayfasından gönderdi";
                msj.SubjectEncoding = Encoding.UTF8;
                msj.BodyEncoding = Encoding.UTF8;
                msj.IsBodyHtml = true;
                msj.Body =  sendmail.Message;
                sc.EnableSsl = false;
                sc.Port = 587;
                sc.Host = "	5.2.85.56";
                sc.Send(msj);
                msj.Dispose();

            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool SendMailLayout(string EmailAddress)
        {
            try
            {
                MailMessage msj = new MailMessage();
                SmtpClient sc = new SmtpClient();
                sc.Credentials = new System.Net.NetworkCredential("info@firmabayi.com", "Mg199349");
                msj.To.Add("muhammed.yilmaz.ym@gmail.com");
                msj.From = new MailAddress("info@firmabayi.com", "dukkan.com.tr", Encoding.UTF8);
                msj.Subject =  "Kampanya Haberdarından gönderdi";
                msj.SubjectEncoding = Encoding.UTF8;
                msj.BodyEncoding = Encoding.UTF8;
                msj.IsBodyHtml = true;
                msj.Body = EmailAddress;
                sc.EnableSsl = false;
                sc.Port = 587;
                sc.Host = "	5.2.85.56";
                sc.Send(msj);
                msj.Dispose();

            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool SendMailPasword(Customer sendmail)
        {
            try
            {
                MailMessage msj = new MailMessage();
                SmtpClient sc = new SmtpClient();
                sc.Credentials = new System.Net.NetworkCredential("info@firmabayi.com", "Mg199349");
                msj.To.Add(sendmail.EmailAddress);
                msj.From = new MailAddress("info@firmabayi.com", "dukkan.com.tr", Encoding.UTF8);
                msj.Subject = "Şifremi Unuttum Sayfasından Gönderildi";
                msj.SubjectEncoding = Encoding.UTF8;
                msj.BodyEncoding = Encoding.UTF8;
                msj.IsBodyHtml = true;
                msj.Body = "http://mvceticaret.6v5.org/"+ "şifreniz= " + sendmail.Password;
                sc.EnableSsl = false;
                sc.Port = 587;
                sc.Host = "	5.2.85.56";
                sc.Send(msj);
                msj.Dispose();

            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
