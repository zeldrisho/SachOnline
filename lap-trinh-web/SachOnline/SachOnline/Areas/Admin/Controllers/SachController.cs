using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SachOnline.Models;
using PagedList;
using PagedList.Mvc;
using System.IO;

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

        //[HttpGet]
        //public ActionResult Create()
        //{
        //    ViewBag.MaCD = new SelectList(db.CHUDEs.ToList().OrderBy(n => n.TenChuDe), "MaCD", "TenChuDe");
        //    ViewBag.MaNXB = new SelectList(db.NHAXUATBANs.ToList().OrderBy(n => n.TenNXB), "MaNXB", "TenNXB");
        //    return View();
        //}

        //[HttpPost]
        //[ValidateInput(false)]
        //public ActionResult Create(SACH sach, FormCollection f, HttpPostedFileBase fFileUpload)
        //{
        //    //Đưa dữ liệu vào DropDown
        //    ViewBag.MaCD = new SelectList(db.CHUDEs.ToList().OrderBy(n =>
        //    n.TenChuDe), "MaCD", "TenChuDe");
        //    ViewBag.MaNXB = new SelectList(db.NHAXUATBANs.ToList().OrderBy(n =>
        //    n.TenNXB), "MaNXB", "TenNXB");
        //    if (fFileUpload == null)
        //    {
        //        //Nội dung thông báo yêu cầu chọn ảnh bìa
        //        ViewBag.ThongBao = "Hãy chọn ảnh bìa.";
        //        //Lưu thông tin để khi load lại trang do yêu cầu chọn ảnh bìa sẽ hiển thị
        //        //các thông tin này lên trang
        //        ViewBag.TenSach = f["sTenSach"];
        //        ViewBag.MoTa = f["sMoTa"];
        //        ViewBag.SoLuong = int.Parse(f["iSoLuong"]);
        //        ViewBag.GiaBan = decimal.Parse(f["mGiaBan"]);
        //        ViewBag.MaCD = new SelectList(db.CHUDEs.ToList().OrderBy(n =>
        //        n.TenChuDe), "MaCD", "TenChuDe", int.Parse(f["MaCD"]));
        //        ViewBag.MaNXB = new SelectList(db.NHAXUATBANs.ToList().OrderBy(n =>
        //        n.TenNXB), "MaNXB", "TenNXB", int.Parse(f["MaNXB"]));
        //        return View();
        //    }
        //    else
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            //Lấy tên file (Khai báo thư viện: System.IO)
        //            var sFileName = Path.GetFileName(fFileUpload.FileName);
        //            //Lấy đường dẫn lưu file
        //            var path = Path.Combine(Server.MapPath("~/Images"), sFileName);
        //            //Kiểm tra ảnh bìa đã tồn tại chưa để lưu lên thư mục
        //            if (!System.IO.File.Exists(path))
        //            {
        //                fFileUpload.SaveAs(path);
        //            }
        //            //Lưu Sach vào CSDL
        //            sach.TenSach = f["sTenSach"];
        //            sach.MoTa = f["sMoTa"];
        //            sach.AnhBia = sFileName;
        //            sach.NgayCapNhat = Convert.ToDateTime(f["dNgayCapNhat"]);
        //            sach.SoLuongBan = int.Parse(f["iSoLuong"]);
        //            sach.GiaBan = decimal.Parse(f["mGiaBan"]);
        //            sach.MaCD = int.Parse(f["MaCD"]);
        //            sach.MaNXB = int.Parse(f["MaNXB"]);
        //            db.SACHes.InsertOnSubmit(sach);
        //            db.SubmitChanges();
        //            //Về lại trang Quản lý sách
        //            return RedirectToAction("Index");
        //        }
        //        return View();
        //    }
        //}

        //[HttpGet]
        //public ActionResult Delete(int id)
        //{
        //    var sach = db.SACHes.SingleOrDefault(n => n.MaSach == id);
        //    if (sach == null)
        //    {
        //        Response.StatusCode = 404;
        //        return null;
        //    }
        //    return View(sach);
        //}

        //[HttpPost, ActionName("Delete")]
        //public ActionResult DeleteConfirm(int id, FormCollection f)
        //{
        //    var sach = db.SACHes.SingleOrDefault(n => n.MaSach == id);
        //    if (sach == null)
        //    {
        //        Response.StatusCode = 404;
        //        return null;
        //    }
        //    var ctdh = db.CHITIETDATHANGs.Where(ct => ct.MaSach == id);
        //    if (ctdh.Count() > 0)
        //    {
        //        //Nội dung sẽ hiển thị khi sách cần xóa đã có trong table ChiTietDonHang
        //        //ViewBag.ThongBao = "Sách này đang có trong bảng Chi tiết đặt hàng <br>" + " Nếu muốn xóa thì phải xóa hết mã sách này trong bảng Chi tiết đặt hàng";
        //        SetAlert("Sách này đang có trong bảng Chi tiết đặt hàng. Nếu muốn xóa thì phải xóa hết mã sách này trong bảng Chi tiết đặt hàng", "danger");
        //        return View(sach);
        //    }
        //    //Xóa hết thông tin của cuốn sách trong table VietSach trước khi xóa sách này
        //    var vietsach = db.VIETSACHes.Where(vs => vs.MaSach == id).ToList();
        //    if (vietsach != null)
        //    {
        //        db.VIETSACHes.DeleteAllOnSubmit(vietsach);
        //        db.SubmitChanges();
        //    }
        //    //Xóa sách
        //    db.SACHes.DeleteOnSubmit(sach);
        //    db.SubmitChanges();
        //    return RedirectToAction("Index");
        //}

        //[HttpGet]
        //public ActionResult Edit(int id)
        //{
        //    var sach = db.SACHes.SingleOrDefault(n => n.MaSach == id);
        //    if (sach == null)
        //    {
        //        Response.StatusCode = 404;
        //        return null;
        //    }
        //    //Hiển thị danh sách chủ đề và nhà xuất bản đồng thời chọn chủ đề và nhà xuất bản
        //    //của cuốn hiện tại
        //    ViewBag.MaCD = new SelectList(db.CHUDEs.ToList().OrderBy(n => n.TenChuDe),
        //    "MaCD", "TenChuDe", sach.MaCD);
        //    ViewBag.MaNXB = new SelectList(db.NHAXUATBANs.ToList().OrderBy(n =>
        //    n.TenNXB), "MaNXB", "TenNXB", sach.MaNXB);
        //    return View(sach);
        //}

        //[HttpPost]
        //[ValidateInput(false)]
        //public ActionResult Edit(FormCollection f, HttpPostedFileBase fFileUpload)
        //{
        //    var sach = db.SACHes.SingleOrDefault(n => n.MaSach == int.Parse(f["iMaSach"]));
        //    ViewBag.MaCD = new SelectList(db.CHUDEs.ToList().OrderBy(n => n.TenChuDe),
        //    "MaCD", "TenChuDe", sach.MaCD);
        //    ViewBag.MaNXB = new SelectList(db.NHAXUATBANs.ToList().OrderBy(n =>
        //    n.TenNXB), "MaNXB", "TenNXB", sach.MaNXB);
        //    if (ModelState.IsValid)
        //    {
        //        if (fFileUpload != null) //Kiểm tra để xác nhận cho thay đổi ảnh bìa
        //        {
        //            //Lấy tên file (Khai báo thư viện: System.IO)
        //            var sFileName = Path.GetFileName(fFileUpload.FileName);
        //            //Lấy đường dẫn lưu file
        //            var path = Path.Combine(Server.MapPath("~/Images"), sFileName);
        //            //Kiểm tra file đã tồn tại chưa
        //            if (!System.IO.File.Exists(path))
        //            {
        //                fFileUpload.SaveAs(path);
        //            }
        //        sach.AnhBia = sFileName;
        //        }
        //        //Lưu Sach vào CSDL
        //        sach.TenSach = f["sTenSach"];
        //        sach.MoTa = f["sMoTa"];
        //        sach.NgayCapNhat = Convert.ToDateTime(f["dNgayCapNhat"]);
        //        sach.SoLuongBan = int.Parse(f["iSoLuong"]);
        //        sach.GiaBan = decimal.Parse(f["mGiaBan"]);
        //        sach.MaCD = int.Parse(f["MaCD"]);
        //        sach.MaNXB = int.Parse(f["MaNXB"]);
        //        db.SubmitChanges();
        //        //Về lại trang Quản lý sách
        //        return RedirectToAction("Index");
        //    }
        //    return View(sach);
        //}

        public ActionResult Search(string strSearch)
        {
            ViewBag.Search = strSearch;
            if (string.IsNullOrEmpty(strSearch))
            {
                return View();
            }
            var kq = db.SACHes.Where(s => s.TenSach.Contains(strSearch));
            ViewBag.Kq = kq.Count();
            return View(kq);
        }

        [HttpGet]
        public JsonResult DsSach()
        {
            try
            {

                var dsSach = (from s in db.SACHes
                            select new
                            {
                                MaSach = s.MaSach,
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