using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hotel_Project.Models;

namespace Hotel_Project.Controllers
{
    public class OdaController : Controller
    {
        // GET: Oda
        HotelEntities1 db = new HotelEntities1();
        public ActionResult Index()
        {
            return View(db.Rooms.ToList());
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Room ekle)
        {
            try
            {
                using (HotelEntities1 db = new HotelEntities1())
                {
                    db.Rooms.Add(ekle);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Duzenle(int id)
        {
            using (HotelEntities1 db = new HotelEntities1())
            {
                return View(db.Rooms.Where(x => x.RoomID == id).FirstOrDefault());
            }
        }
        [HttpPost]
        public ActionResult Duzenle(int id, Room duzenle)
        {
            try
            {
                using (HotelEntities1 db = new HotelEntities1())
                {
                    db.Entry(duzenle).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Delete(int id)
        {
            using (HotelEntities1 db = new HotelEntities1())
            {
                return View(db.Rooms.Where(x => x.RoomID == id).FirstOrDefault());
            }
        }
        [HttpPost]
        public ActionResult Delete(int id, Room sil)
        {
            try
            {
                using (HotelEntities1 db = new HotelEntities1())
                {
                    sil = db.Rooms.Where(x => x.RoomID == id).FirstOrDefault();
                    db.Rooms.Remove(sil);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}