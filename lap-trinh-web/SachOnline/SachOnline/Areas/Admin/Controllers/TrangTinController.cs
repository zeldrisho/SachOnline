using SachOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SachOnline.Areas.Admin.Controllers
{
    public class TrangTinController : Controller
    {
        DbSachOnlineDataContext db = new DbSachOnlineDataContext();

        // GET: Admin/TrangTin
        public ActionResult Index()
        {
            return View(db.TRANGTINs.ToList());
        }

        // GET: Admin/TrangTin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/TrangTin/Create
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(TRANGTIN tt)
        {
            if (ModelState.IsValid)
            {
                tt.MetaTitle = tt.TenTrang.RemoveDiacritics().Replace(" ", "-");
                tt.NgayTao = DateTime.Now;
                db.TRANGTINs.InsertOnSubmit(tt);
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Admin/TrangTin/Edit/5
        public ActionResult Edit(int id)
        {
            var tt = db.TRANGTINs.Where(t => t.MaTT == id).SingleOrDefault();
            return View(tt);
        }

        // POST: Admin/TrangTin/Edit/5
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(FormCollection f)
        {
            if (ModelState.IsValid)
            {
                var tt = db.TRANGTINs.Where(t => t.MaTT == int.Parse(f["MaTT"])).SingleOrDefault();
                tt.TenTrang = f["TenTrang"];
                tt.NoiDung = f["NoiDung"];
                tt.NgayTao = Convert.ToDateTime(f["NgayTao"]);
                tt.MetaTitle = f["TenTrang"].RemoveDiacritics().Replace(" ", "-");
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Admin/TrangTin/Delete/5
        public ActionResult Delete(int id)
        {
            var tt = db.TRANGTINs.Where(t => t.MaTT == id).SingleOrDefault();
            return View(tt);
        }

        // POST: Admin/TrangTin/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            var tt = db.TRANGTINs.Where(t => t.MaTT == id).SingleOrDefault();
            db.TRANGTINs.DeleteOnSubmit(tt);
            db.SubmitChanges();
            return RedirectToAction("Index");
        }
    }
}
