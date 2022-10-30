using Antlr.Runtime.Tree;
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
    public class ChuDeController : Controller
    {
        DbSachOnlineDataContext db = new DbSachOnlineDataContext();

        // GET: Admin/ChuDe
        public ActionResult Index(int? page)
        {
            int pageNum = (page ?? 1);
            int pageSize = 7;
            return View(db.CHUDEs.ToList().OrderBy(n => n.MaCD).ToPagedList(pageNum, pageSize));
        }

        // POST: Admin/ChuDe/Create
        [HttpPost]
        [ValidateInput(false)]
        public JsonResult Create(string strTenCD)
        {
            try
            {
                var cd = new CHUDE();
                cd.TenChuDe = strTenCD;
                db.CHUDEs.InsertOnSubmit(cd);
                db.SubmitChanges();
                return Json(new { code = 200, msg = "Thêm chủ đề thành công" },
                    JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(new { code = 500, msg = "Thêm chủ đề thất bại" + e.Message },
                    JsonRequestBehavior.AllowGet);
            }
        }

        // POST: Admin/ChuDe/Edit/5
        [HttpPost]
        public ActionResult Edit(int maCD, string strTenCD)
        {
            try
            {
                var cd = db.CHUDEs.SingleOrDefault(c => c.MaCD == maCD);
                cd.TenChuDe = strTenCD;
                db.SubmitChanges();
                return Json(new { code = 200, msg = "Sửa chủ đề thành công" },
                    JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(new { code = 500, msg = "Sửa chủ đề thất bại" + e.Message },
                    JsonRequestBehavior.AllowGet);
            }
        }

        // POST: Admin/ChuDe/Delete/5
        [HttpPost]
        public ActionResult Delete(int maCD)
        {
            try
            {
                var cd = db.CHUDEs.SingleOrDefault(c => c.MaCD == maCD);
                db.CHUDEs.DeleteOnSubmit(cd);
                db.SubmitChanges();
                return Json(new { code = 200, msg = "Xoá chủ đề thành công" },
                    JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(new { code = 500, msg = "Xoá chủ đề thất bại" + e.Message },
                    JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public JsonResult DsChuDe()
        {
            try
            {
                var dsCD = (from cd in db.CHUDEs
                            select new
                            {
                                MaCD = cd.MaCD,
                                TenCD = cd.TenChuDe
                            }).ToList();
                return Json(new { code = 200, dsCD = dsCD, msg = "Lấy danh sách chủ đề thành công" },
                    JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(new { code = 500, msg = "Lấy danh sách chủ đề thất bại" + e.Message },
                    JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public JsonResult Details(int maCD)
        {
            try
            {
                var cd = (from s in db.CHUDEs
                            where (s.MaCD == maCD)
                            select new
                            {
                                MaCD = s.MaCD,
                                TenCD = s.TenChuDe
                            }).SingleOrDefault();
                return Json(new { code = 200, cd = cd, msg = "Lấy thông tin chủ đề thành công" },
                    JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(new { code = 500, msg = "Lấy thông tin chủ đề thất bại" + e.Message },
                    JsonRequestBehavior.AllowGet);
            }
        }
    }
}
