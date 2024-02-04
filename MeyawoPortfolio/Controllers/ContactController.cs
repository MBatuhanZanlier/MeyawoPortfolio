using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;
namespace MeyawoPortfolio.Controllers
{
    public class ContactController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TblContact.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateContact()
        {
            return View();

        }
        [HttpPost]
        public ActionResult CreateContact(TblContact p)
        {
            p.SendDate = DateTime.Now;
            p.IsRead = false;
            db.TblContact.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult DeleteContact(int id)
        {
            var value = db.TblContact.Find(id);
            db.TblContact.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DetailMessage(int id)
        {
            var value = db.TblContact.Find(id);
            return View(value);
        }
        public ActionResult DetailsContact(int id)
        {
            var value = db.TblContact.Find(id);

            return View(value);
        }
      
    }

}