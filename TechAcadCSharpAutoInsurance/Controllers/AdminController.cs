using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechAcadCSharpAutoInsurance.Models;

namespace TechAcadCSharpAutoInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (CarInsuranceEntities db = new CarInsuranceEntities())
            {
                List<Quote> quotes = db.Quotes.ToList();
                ViewBag.adminActive = "active";
                return View(quotes);
            }            
        }
    }
}