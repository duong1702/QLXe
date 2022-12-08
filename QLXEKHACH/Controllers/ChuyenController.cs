using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLXEKHACH.Models;

namespace QLXEKHACH.Controllers
{
    public class ChuyenController : Controller
    {
        ql_xekhachEntities1 db = new ql_xekhachEntities1();
        // GET: Chuyen
        public ActionResult Index()
        {
            var ds = from chuyen in db.tChuyens select chuyen;
            return View(ds);
        }
        public ActionResult Delete(String id)
        {
            tChuyen chuyen = db.tChuyens.Find(id);
            db.tChuyens.Remove(chuyen);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(String id)
        {
            tChuyen chuyen = db.tChuyens.Find(id);
            return View(chuyen);
        }
        [HttpPost]
        public ActionResult Edit(FormCollection f)
        {
            string ma = f.Get("MaChuyen");
            tChuyen chuyen = db.tChuyens.Find(ma);
            chuyen.SoXe = f.Get("SoXe");
            chuyen.MaTaiXe = f.Get("MaTaiXe");
            chuyen.SoLuongKhach = f.Get("SoLuongKhach");
            chuyen.GioXuatBen = f.Get("GioXuatBen");
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(string id)
        {
            tChuyen chuyen = db.tChuyens.Find(id);
            return View(chuyen);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tChuyen chuyen)
        {
            db.tChuyens.Add(chuyen);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}