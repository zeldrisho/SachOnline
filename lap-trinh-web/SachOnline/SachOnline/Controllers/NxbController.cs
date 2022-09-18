using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using SachOnline.Models;

namespace SachOnline.Controllers
{
    public class NxbController : Controller
    {
        DbSachOnlineDataContext db = new DbSachOnlineDataContext();

        public NHAXUATBAN GetNXB(int id)
        {
            return db.NHAXUATBANs.Where(nxb => nxb.MaNXB == id).SingleOrDefault();
        }

        // GET: Nxb
        public ActionResult Index()
        {
            var nxb = db.NHAXUATBANs;
            return View(nxb);
        }

        // GET: Nxb/Details/5
        public ActionResult Details(int id)
        {
            var nxb = db.NHAXUATBANs.Where(n => n.MaNXB == id).Single();
            return View(nxb);
        }

        // GET: Nxb/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Nxb/Create
        [HttpPost]
        public ActionResult Create(NHAXUATBAN collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    NHAXUATBAN nxb = new NHAXUATBAN();
                    nxb.TenNXB = collection.TenNXB;
                    nxb.DiaChi = collection.DiaChi;
                    nxb.DienThoai = collection.DienThoai;
                    db.NHAXUATBANs.InsertOnSubmit(nxb);
                    db.SubmitChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Nxb/Edit/5
        public ActionResult Edit(int id)
        {
            return View(GetNXB(id));
        }

        // POST: Nxb/Edit/5
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var nxb = GetNXB(int.Parse(Request.Form["MaNXB"]));
                    nxb.TenNXB = Request.Form["TenNXB"];
                    nxb.DiaChi = Request.Form["DiaChi"];
                    nxb.DienThoai = Request.Form["DienThoai"];
                    db.SubmitChanges();
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Nxb/Delete/5
        public ActionResult Delete(int id)
        {
            return View(GetNXB(id));
        }

        // POST: Nxb/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                NHAXUATBAN nxb = db.NHAXUATBANs.Single(n => n.MaNXB == id);
                db.NHAXUATBANs.DeleteOnSubmit(nxb);
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
