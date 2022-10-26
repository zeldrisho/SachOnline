using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SachOnline.Models;
using PagedList;
using PagedList.Mvc;
using System.IO;
using System.Text.RegularExpressions;

namespace SachOnline.Areas.Admin.Controllers
{
    public class SachController : BaseController
    {
        DbSachOnlineDataContext db = new DbSachOnlineDataContext();

        // GET: Admin/Sach
        public ActionResult Index(int? page)
        {
            int pageNum = (page ?? 1);
            int pageSize = 7;
            return View(db.SACHes.ToList().OrderByDescending(n => n.NgayCapNhat).ToPagedList(pageNum, pageSize));
        }

        [HttpPost]
        [ValidateInput(false)]
        public JsonResult Create(string strTenSach)
        {
            try
            {
                var s = new SACH();
                s.TenSach = strTenSach;
                db.SACHes.InsertOnSubmit(s);
                db.SubmitChanges();
                return Json(new { code = 200, msg = "Thêm sách thành công" },
                    JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(new { code = 500, msg = "Thêm sách thất bại" + e.Message },
                    JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Edit(int maSach, string strTenSach)
        {
            try
            {
                var s = db.SACHes.SingleOrDefault(model => model.MaSach == maSach);
                s.TenSach = strTenSach;
                db.SubmitChanges();
                return Json(new { code = 200, msg = "Sửa sách thành công" },
                    JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(new { code = 500, msg = "Sửa sách thất bại" + e.Message },
                    JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Delete(int maSach)
        {
            try
            {
                var s = db.SACHes.SingleOrDefault(model => model.MaSach == maSach);
                db.SACHes.DeleteOnSubmit(s);
                db.SubmitChanges();
                return Json(new { code = 200, msg = "Xoá sách thành công" },
                    JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(new { code = 500, msg = "Xoá sách thất bại" + e.Message },
                    JsonRequestBehavior.AllowGet);
            }
        }

        //public ActionResult Search(string strSearch)
        //{
        //    ViewBag.Search = strSearch;
        //    if (string.IsNullOrEmpty(strSearch))
        //    {
        //        return View();
        //    }
        //    var kq = db.SACHes.Where(s => s.TenSach.Contains(strSearch));
        //    ViewBag.Kq = kq.Count();
        //    return View(kq);
        //}

        [HttpGet]
        public JsonResult DsSach()
        {
            try
            {

                var dsSach = (from s in db.SACHes
                            select new
                            {
                                MaSach = s.MaSach,
                                MoTa = s.MoTa,
                                TenSach = s.TenSach,
                                Anh = s.AnhBia,
                                NgayCapNhat = s.NgayCapNhat,
                                SoLuong = s.SoLuongBan,
                                GiaBan = s.GiaBan,
                                TenCD = from cd in db.CHUDEs where cd.MaCD == s.MaCD select cd.TenChuDe,
                                TenNXB = from nxb in db.NHAXUATBANs where nxb.MaNXB == s.MaNXB select nxb.TenNXB
                            }).ToList();
                return Json(new { code = 200, dsSach = dsSach, msg = "Lấy danh sách sách thành công" },
                    JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(new { code = 500, msg = "Lấy danh sách sách thất bại" + e.Message },
                    JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public JsonResult Details(int maSach)
        {
            try
            {
                var sach = (from s in db.SACHes
                          where (s.MaSach == maSach)
                          select new
                          {
                              MaSach = s.MaSach,
                              TenSach = s.TenSach,
                              MoTa = s.MoTa,
                              Anh = s.AnhBia,
                              NgayCapNhat = s.NgayCapNhat,
                              SoLuong = s.SoLuongBan,
                              GiaBan = s.GiaBan,
                              TenCD = from cd in db.CHUDEs where cd.MaCD == s.MaCD select cd.TenChuDe,
                              TenNXB = from nxb in db.NHAXUATBANs where nxb.MaNXB == s.MaNXB select nxb.TenNXB
                          }).SingleOrDefault();
                return Json(new { code = 200, sach = sach, msg = "Lấy thông tin sách thành công" },
                    JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(new { code = 500, msg = "Lấy thông tin sách thất bại" + e.Message },
                    JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Edit(int maSach, string tenSach, string moTa)
        {
            try
            {
                var sach = db.SACHes.SingleOrDefault(c => c.MaSach == maSach);
                sach.TenSach = tenSach;
                sach.MoTa = moTa;
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
    }
}