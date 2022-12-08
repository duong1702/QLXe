using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLXEKHACH.Models;

namespace QLXEKHACH.Controllers
{
    public class DSXeController : Controller
    {
        ql_xekhachEntities1 db = new ql_xekhachEntities1();
        // GET: DSXe
        public ActionResult Index()
        {
            var ds = from xe in db.tXes select xe;
            return View(ds);
        }
        public ActionResult Delete(String id)
        {
            tXe xe = db.tXes.Find(id);
            db.tXes.Remove(xe);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(String id)
        {
            tXe xe = db.tXes.Find(id);
            return View(xe);
        }
        [HttpPost]
        public ActionResult Edit(FormCollection f)
        {
            string so = f.Get("SoXe");
            tXe xe = db.tXes.Find(so);
            xe.HangSanXuat = f.Get("HangSanXuat");
            xe.NamSanXuat = f.Get("NamSanXuat");
            xe.SoLuongChoNgoi = f.Get("SoLuongChoNgoi");
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(string id)
        {
            tXe dtxe = db.tXes.Find(id);
            return View(dtxe);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tXe dtxe)
        {
            db.tXes.Add(dtxe);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}