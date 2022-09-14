using SachOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SachOnline.Controllers
{
    public class NxbController : Controller
    {
        DbSachOnlineDataContext db = new DbSachOnlineDataContext();

        // GET: Nxb
        public ActionResult Index()
        {
            var nxb= db.NHAXUATBANs;
            return View(nxb);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            var nxb = db.NHAXUATBANs.Where(n => n.MaNXB == id).Single();
            return View(nxb);
        }

        public NHAXUATBAN GetNXB(int id)
        {
            return db.NHAXUATBANs.Where(nxb => nxb.MaNXB == id).SingleOrDefault();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(GetNXB(id));
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit()
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
            return RedirectToAction("Edit");
        }

        public ActionResult Delete(int id)
        {
            return View(GetNXB(id));
        }
    }
}