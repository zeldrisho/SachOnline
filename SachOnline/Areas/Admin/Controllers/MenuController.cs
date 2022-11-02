using SachOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace SachOnline.Areas.Admin.Controllers
{
    public class MenuController : Controller
    {
        DbSachOnlineDataContext db = new DbSachOnlineDataContext();

        // GET: Admin/Menu
        public ActionResult Index()
        {
            var model = db.MENUs.ToList();
            return View(model);
        }

        // GET: Admin/Menu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Menu/Create
        [HttpPost]
        public ActionResult Create(MENU menu, FormCollection f)
        {
            if (ModelState.IsValid)
            {
                menu.MenuName = f["MenuName"];
                menu.MenuLink = f["MenuLink"];
                menu.ParentId = int.Parse(f["ParentId"]);
                menu.OrderNumber = int.Parse(f["OrderNumber"]);
                db.MENUs.InsertOnSubmit(menu);
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Admin/Menu/Edit/5
        public ActionResult Edit(int id)
        {
            var model = db.MENUs.SingleOrDefault(n => n.Id == id);
            if (model == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(model);
        }

        // POST: Admin/Menu/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection f)
        {
            var menu = db.MENUs.SingleOrDefault(n => n.Id == int.Parse(f["Id"]));
            if (ModelState.IsValid)
            {
                menu.MenuName = f["MenuName"];
                menu.MenuLink = f["MenuLink"];
                menu.ParentId = int.Parse(f["ParentId"]);
                menu.OrderNumber = int.Parse(f["OrderNumber"]);
                db.MENUs.InsertOnSubmit(menu);
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            return View(menu);
        }

        // POST: Admin/Menu/Delete/5
        [HttpDelete]
        public bool Delete(int id)
        {
            try
            {
                var model = db.MENUs.SingleOrDefault(n => n.Id == id);
                db.MENUs.DeleteOnSubmit(model);
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
