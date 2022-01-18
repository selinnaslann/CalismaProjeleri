using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RealEstate.ModelBase;
using RealEstate.Models;

namespace RealEstate.Controllers
{
    public class AdvertLandController : Controller
    {
        // GET: AdvertLand
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details()
        {
            Land plot = new Land();
            plot.RealEstateID = 2;
            plot.Square = 2374;
            plot.LandStatus = LandStatus.DetachedParcel;

            User user = new User();
            user.Email = "selinaslan@test.com";
            user.FullName = "Selin Aslan";

            AdvertLand advertLand = new AdvertLand();
            advertLand.AdvertiseId = 2;
            advertLand.Date = DateTime.Now;
            advertLand.Title = "Ankaranın en iyi yerinde arsa.";
            advertLand.User = user;
            advertLand.RealEstate = plot;
            return View(advertLand);

        }
    }
}