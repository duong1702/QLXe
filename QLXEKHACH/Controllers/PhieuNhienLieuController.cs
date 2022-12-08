using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLXEKHACH.Models;

namespace QLXEKHACH.Controllers
{
    public class PhieuNhienLieuController : Controller
    {
        ql_xekhachEntities1 db = new ql_xekhachEntities1();
        // GET: PhieuNhienLieu
        public ActionResult Index()
        {
            var ds = from pnl in db.tPhieuNhienLieux select pnl;
            return View(ds);
        }
        public ActionResult Delete(string id)
        {
            tPhieuNhienLieu pnl = db.tPhieuNhienLieux.Find(id);
            db.tPhieuNhienLieux.Remove(pnl);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(String id)
        {
            tPhieuNhienLieu pnl = db.tPhieuNhienLieux.Find(id);
            return View(pnl);
        }
        [HttpPost]
        public ActionResult Edit(FormCollection k)
        {
            string sp = k.Get("SoPhieu");
            tPhieuNhienLieu pnl = db.tPhieuNhienLieux.Find(sp);
            pnl.NgayLapPhieu = k.Get("NgayLapPhieu");
            pnl.MaNhienLieu = k.Get("MaNhienLieu");
            pnl.SoLuong = k.Get("SoLuong");
            pnl.SoLuong = k.Get("SoXe");
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(String id)
        {
            tPhieuNhienLieu pnl = db.tPhieuNhienLieux.Find(id);
            return View(pnl);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tPhieuNhienLieu pnl)
        {
            db.tPhieuNhienLieux.Add(pnl);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}