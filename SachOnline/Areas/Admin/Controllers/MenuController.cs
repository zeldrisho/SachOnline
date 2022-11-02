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

        public int? ToNullableInt(string s)
        {
            int i;
            if (int.TryParse(s, out i)) return i;
            return null;
        }

        // GET: Admin/Menu
        public ActionResult Index()
        {
            List<MENU> lst = new List<MENU>();
            lst = db.MENUs.Where(m => m.ParentId == null).OrderBy(m => m.OrderNumber).ToList();
            int[] a = new int[lst.Count()];
            for (int i = 0; i < lst.Count; i++)
            {
                var l = db.MENUs.Where(m => m.ParentId == lst[i].Id);
                a[i] = l.Count();
            }
            ViewBag.lst = a;
            return View(lst);
        }

        // GET: Admin/Menu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Menu/Create
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(MENU menu, FormCollection f)
        {
            if (ModelState.IsValid)
            {
                menu.MenuName = f["MenuName"];
                menu.MenuLink = f["MenuLink"];
                menu.ParentId = ToNullableInt(f["ParentId"]);
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
                menu.ParentId = ToNullableInt(f["ParentId"]);
                menu.OrderNumber = int.Parse(f["OrderNumber"]);
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

        [ChildActionOnly]
        public ActionResult LoadChildMenu(int parentId)
        {
            List<MENU> lst = new List<MENU>();
            lst = db.MENUs.Where(m => m.ParentId == parentId).OrderBy(m => m.OrderNumber).ToList();
            ViewBag.Count = lst.Count();
            int[] a = new int[lst.Count()];
            for (int i = 0; i < lst.Count(); i++)
            {
                var l = db.MENUs.Where(m => m.ParentId == lst[i].Id);
                a[i] = l.Count();
            }
            ViewBag.lst = a;
            return PartialView("LoadChildMenu", lst);
        }
    }
}
