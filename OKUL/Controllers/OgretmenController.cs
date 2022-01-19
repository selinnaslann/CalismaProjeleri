using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OKUL.Models;
using OKUL.DataAccess;

namespace OKUL.Controllers
{
    public class OgretmenController : Controller
    {
        private static Ogretmen _ogretmen { get; set; }
        public static Ogretmen ogretmen {
            get {
                if (_ogretmen == null)
                    _ogretmen = new Ogretmen();
                return _ogretmen;
            }
            set { _ogretmen = value; }
        }
        // GET: Ogretmen
        public ActionResult Index()
        {
            List<Ogretmen> ogretmenler = new List<Ogretmen>();
            ogretmenler = OgretmenDAL.methods.ListOgretmen();
            return View(ogretmenler);
        }

        public ActionResult Create()
        {
            return View(ogretmen);
        }
        [HttpPost]
        public ActionResult Create(Ogretmen ogrt)
        {
            object insertedID = OgretmenDAL.methods.Create(ogrt);
            TempData["insertedID"] = insertedID;
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Ogretmen ogrt = OgretmenDAL.methods.GetByID(id);
            return View(ogrt);
        }

        [HttpPost]
        public ActionResult Edit(Ogretmen ogrt)
        {
            if (OgretmenDAL.methods.Update(ogrt))
                return RedirectToAction("Index");
            else
                ViewBag.hata = "Güncelleme Başarısız.";
                return View(ogrt);
        }

        public ActionResult Details(int id)
        {
            Ogretmen ogrt = OgretmenDAL.methods.GetByID(id);
            return View(ogrt);
        }

        public ActionResult Delete(int id)
        {
            Ogretmen ogrt = new Ogretmen();
            ogrt = OgretmenDAL.methods.GetByID(id);
            return View(ogrt);
        }

        [HttpPost]
        public ActionResult Delete(Ogretmen ogrt)
        {
            if (OgretmenDAL.methods.Delete(ogrt))
                return RedirectToAction("Index");
            else
            {
                TempData["hata"] = "Silme işlemi başarısız";
                return RedirectToAction("Delete",new { id=ogrt.ID});
            }
        }

        [HttpPost]
        public ActionResult Ara(string arananKelime)
        {
            List<Ogretmen> ogretmenler = new List<Ogretmen>();
            ogretmenler = OgretmenDAL.methods.Search(arananKelime);
            //TempData["arananKelime"] = arananKelime;
            return View(ogretmenler);
        }
    }
}