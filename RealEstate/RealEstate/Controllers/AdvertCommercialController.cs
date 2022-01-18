using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RealEstate.ModelBase;
using RealEstate.Models;

namespace RealEstate.Controllers
{
    public class AdvertCommercialController : Controller
    {
        // GET: AdvertCommercial
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details()
        {
            Commercial workplace = new Commercial();
            workplace.RealEstateID = 3;
            workplace.PropertyType = PropertyType.BanquetHall_EventsVenue;
            workplace.Square = 1200;
            workplace.HeatingType = HeatingType.NaturalGas;

            User user = new User();
            user.Email = "selinaslan@test.com";
            user.FullName = "Selin Aslan";

            AdvertCommercial advertCommercial = new AdvertCommercial();
            advertCommercial.AdvertiseId = 3;
            advertCommercial.Date = DateTime.Now;
            advertCommercial.Title = "Ankaranın en iyi yerinde arsa.";
            advertCommercial.User = user;
            advertCommercial.RealEstate = workplace;
            return View(advertCommercial);
        }

    }
}