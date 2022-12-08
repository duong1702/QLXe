using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLXEKHACH.Models;

namespace QLXEKHACH.Controllers
{
    public class BaoTriController : Controller
    {
        ql_xekhachEntities1 db = new ql_xekhachEntities1();
        // GET: BaoTri
        public ActionResult Index()
        {
            var ds = from btri in db.tBaoTris select btri;
            return View(ds);
        }
        public ActionResult Delete(String id)
        {
            tBaoTri stt = db.tBaoTris.Find(id);
            db.tBaoTris.Remove(stt);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(String id)
        {
            tBaoTri stt = db.tBaoTris.Find(id);
            return View(stt);
        }
        [HttpPost]
        public ActionResult Edit(FormCollection f)
        {
            var so = f.Get("SoThuTu");
            tBaoTri stt = db.tBaoTris.Find(so);
            stt.SoXe = f.Get("SoXe");
            stt.NgayBaoTri = f.Get("NgayBaoTri");
            stt.ThanhTien = f.Get("ThanhTien");
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(string id)
        {
            tBaoTri stt = db.tBaoTris.Find(id);
            return View(stt);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tBaoTri btri)
        {
            db.tBaoTris.Add(btri);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}