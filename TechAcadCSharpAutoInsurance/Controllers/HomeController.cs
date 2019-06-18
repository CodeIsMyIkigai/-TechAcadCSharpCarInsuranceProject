using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechAcadCSharpAutoInsurance.Models;

namespace TechAcadCSharpAutoInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.homeActive = "active";
            return View();
        }


        public ActionResult GetQuote(Quote quote)
        {
            Console.WriteLine("DOB--------------------");
            Console.WriteLine(quote.DateOfBirth);

            //Set the quote total at $50
            quote.QuoteTotal = 50.00m;

            int age = DateTime.Now.Year - quote.DateOfBirth.Year;
            
            if (age < 18)
            {
                quote.QuoteTotal += 100.00m;
            }
            else if(age < 25 || age > 100)
            {
                quote.QuoteTotal += 25.00m;
            }

            //If the car's year is before 2000, add $25 to the monthly total.
            //If the car's year is after 2015, add $25 to the monthly total.

            if(quote.CarYear < 2000 || quote.CarYear > 2015)
            {
                quote.QuoteTotal += 25m;
            }

            //If the car's Make is a Porsche, add $25 to the price.
            //If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.
            if (quote.CarMake == "Porsche")
            {
                quote.QuoteTotal += 25.00m;
                if(quote.CarModel == "911 Carrera")
                {
                    quote.QuoteTotal += 25.00m;
                }
            }

            //Add $10 to the monthly total for every speeding ticket the user has.
            quote.QuoteTotal += quote.Tickets * 10.00m;
                        

            //If the user has ever had a DUI, add 25 % to the total.
            if(quote.DUI)
            {
                quote.QuoteTotal += 25.00m;
            }

            //If it's full coverage, add 50% to the total.
            if(quote.FullCoverage)
            {
                quote.QuoteTotal *= 1.5m;
            }



            using (CarInsuranceEntities db = new CarInsuranceEntities())
            {
                db.Quotes.Add(quote);
                db.SaveChanges();

                
            }
            ViewBag.homeActive = "active";
            return View(quote);
        }
        

    }
}