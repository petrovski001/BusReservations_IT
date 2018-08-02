using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusReservations.Models;

namespace BusReservations.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
	    using(var db = new BusReservationsDB())
            {
                db.BusCompanies.Add(new BusCompany { Name = "ime" });
                db.SaveChanges();
            }
            return View();
        } 

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        
    }
}