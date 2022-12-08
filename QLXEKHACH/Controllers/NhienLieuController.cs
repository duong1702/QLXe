using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLXEKHACH.Models;

namespace QLXEKHACH.Controllers
{
    public class NhienLieuController : Controller
    {
        ql_xekhachEntities1 db = new ql_xekhachEntities1();
        // GET: NhienLieu
        public ActionResult Index()
        {
            var ds = from nlieu in db.tNhienLieux select nlieu;
            return View(ds);
        }
        public ActionResult Delete(String id)
        {
            tNhienLieu nl = db.tNhienLieux.Find(id);
            db.tNhienLieux.Remove(nl);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(String id)
        {
            tNhienLieu nl = db.tNhienLieux.Find(id);
            return View(nl);
        }
        [HttpPost]
        public ActionResult Edit(FormCollection f)
        {
            string mnl = f.Get("MaNhienLieu");
            tNhienLieu nl = db.tNhienLieux.Find(mnl);
            nl.TenNhienLieu = f.Get("TenNhienLieu");
            nl.DonGia = f.Get("DonGia");
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(string id)
        {
            tNhienLieu dtnl = db.tNhienLieux.Find(id);
            return View(dtnl);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tNhienLieu dtnl)
        {
            db.tNhienLieux.Add(dtnl);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}