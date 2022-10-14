using PagedList;
using SachOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace SachOnline.Areas.Admin.Controllers
{
    public class ChuDeController : BaseController
    {
        DbSachOnlineDataContext db = new DbSachOnlineDataContext();

        // GET: Admin/ChuDe
        public ActionResult Index(int? page)
        {
            int pageNum = (page ?? 1);
            int pageSize = 7;
            return View(db.CHUDEs.ToList().OrderBy(n => n.MaCD).ToPagedList(pageNum, pageSize));
        }

        // GET: Admin/ChuDe/Create
        public ActionResult Create()
        {
            ViewBag.MaNXB = new SelectList(db.NHAXUATBANs.ToList().OrderBy(n => n.TenNXB), "MaNXB", "TenNXB");
            return View();
        }

        // POST: Admin/ChuDe/Create
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/ChuDe/Edit/5
        public ActionResult Edit(int id)
        {
            var chude = db.CHUDEs.SingleOrDefault(n => n.MaCD == id);
            if (chude == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            //ViewBag.MaNXB = new SelectList(db.NHAXUATBANs.ToList().OrderBy(n =>
            //n.TenNXB), "MaNXB", "TenNXB", chude.MaNXB);
            return View(chude);
        }

        // POST: Admin/ChuDe/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/ChuDe/Delete/5
        public ActionResult Delete(int id)
        {
            var chude = db.CHUDEs.SingleOrDefault(n => n.MaCD == id);
            if (chude == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(chude);
        }

        // POST: Admin/ChuDe/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
