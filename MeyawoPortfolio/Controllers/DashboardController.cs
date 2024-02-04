using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;
using Microsoft.Ajax.Utilities;

namespace MeyawoPortfolio.Controllers
{
    public class DashboardController : Controller
    {
        DbMyPortfolioEntities db =new DbMyPortfolioEntities();  
        public ActionResult Index()
        {    
          
            ViewBag.messageCount = db.TblContact.Count();
            ViewBag.projectCount = db.TblProject.Count();
            ViewBag.testimonialCount = db.TblTestimonial.Count();
            ViewBag.categoryCount = db.TblCategory.Count(); 

            return View();
        } 

       
    } 
}