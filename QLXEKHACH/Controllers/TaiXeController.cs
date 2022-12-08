using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLXEKHACH.Models;

namespace QLXEKHACH.Controllers
{
    public class TaiXeController : Controller
    {
        ql_xekhachEntities1 db = new ql_xekhachEntities1();
        // GET: TaiXe
        public ActionResult Index()
        {
            var ds = from Taixe in db.tTaiXes select Taixe;
            return View(ds);
        }

        public ActionResult Delete(String id)
        {
            tTaiXe tx = db.tTaiXes.Find(id);
            db.tTaiXes.Remove(tx);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(String id)
        {
            tTaiXe tx = db.tTaiXes.Find(id);
            return View(tx);
        }
        [HttpPost]
        public ActionResult Edit(FormCollection f)
        {
            string mtx = f.Get("MaTaiXe");
            tTaiXe tx = db.tTaiXes.Find(mtx);
            tx.TenTaiXe = f.Get("TenTaiXe");
            tx.LoaiBangLaiXe = f.Get("LoaiBangLaiXe");
            tx.DiaChi = f.Get("DiaChi");
            tx.GhiChu = f.Get("GhiChu");
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(string id)
        {
            tTaiXe tx = db.tTaiXes.Find(id);
            return View(tx);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tTaiXe tx)
        {
            db.tTaiXes.Add(tx);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}