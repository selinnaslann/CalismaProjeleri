using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OKUL.Models;
using OKUL.Tools;

namespace OKUL.Controllers
{
    public class yedek_OgrenciController : Controller
    {
        // GET: Ogrenci
        public ActionResult yedek_Index()
        {
            Ogrenci ogrenci = new Ogrenci() { ID = 1, Ad = "Ömer", Soyad = "KILIÇ" };
            Ogretmen ogretmen = new Ogretmen() { ID = 1, Ad = "Mehmet", Soyad = "DEMİR" };

            OgrenciOgretmen birlesim = new OgrenciOgretmen();
            birlesim.Ogretmen = ogretmen;
            birlesim.Ogrenci = ogrenci;

            
            return View(birlesim); // model aracılığı ile Controller'dan View'e veri taşıma.
        }

        public ActionResult yedek_Kaydet()
        {
            //ViewData["isim"] = "Mehmet Demir"; // Controller'dan View'e veri taşır.
            //ViewBag.okul = "Mehmet Akif İlköğretim Okulu"; // Controller'dan View'e veri taşır.
            //TempData["ogretmen"] = "Selahattin Ustabaşı"; // iki action methodu arasında veri taşıyabilir.
            //                                              // Controller'dan View'e veri taşıyabilir.
            //return RedirectToAction("Index");

            return View();
        }
    }
}