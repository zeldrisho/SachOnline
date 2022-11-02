using SachOnline.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace SachOnline.Areas.Admin.Controllers
{
    public class SlideController : Controller
    {
        DbSachOnlineDataContext db = new DbSachOnlineDataContext();

        // GET: Admin/Slide
        public ActionResult Index()
        {
            var model = db.SLIDEs.ToList();
            return View(model);
        }

        // GET: Admin/Slide/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Slide/Create
        [HttpPost]
        public ActionResult Create(SLIDE slide, FormCollection f)
        {
            if (ModelState.IsValid)
            {
                slide.TieuDe = f["TieuDe"];
                slide.Anh = f["Anh"];
                slide.MoTa = f["MoTa"];
                slide.HienThi = Boolean.Parse(f["HienThi"]);
                db.SLIDEs.InsertOnSubmit(slide);
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Admin/Slide/Edit/5
        public ActionResult Edit(int id)
        {
            var model = db.SLIDEs.SingleOrDefault(n => n.Id == id);
            if (model == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(model);
        }

        // POST: Admin/Slide/Edit/5
        [HttpPost]
        public ActionResult Edit(FormCollection f)
        {
            var slide = db.SLIDEs.SingleOrDefault(n => n.Id == int.Parse(f["Id"]));
            if (ModelState.IsValid)
            {
                slide.TieuDe = f["TieuDe"];
                slide.Anh = f["Anh"];
                slide.MoTa = f["MoTa"];
                slide.HienThi = Boolean.Parse(f["HienThi"]);
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            return View(slide);
        }

        // POST: Admin/Slide/Delete/5
        [HttpDelete]
        public bool Delete(int id)
        {
            try
            {
                var model = db.SLIDEs.SingleOrDefault(n => n.Id == id);
                db.SLIDEs.DeleteOnSubmit(model);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
