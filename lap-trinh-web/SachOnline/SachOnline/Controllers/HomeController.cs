using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SachOnline.Models;

namespace SachOnline.Controllers
{
    public class HomeController : Controller
    {
        // Tao 1 doi tuong chua toan bo CSDL tu bdSachOnline
        DbSachOnlineDataContext data = new DbSachOnlineDataContext();

        /// <summary>
        /// LaySachMoi
        /// </summary>
        /// <param name="count">int</param>
        /// <returns>List</returns>

        private List<SACH> LaySachMoi(int count)
        {
            return data.SACHes.OrderByDescending(a => a.NgayCapNhat).Take(count).ToList();
        }

        private List<SACH> LaySachBanNhieu(int count)
        {
            return data.SACHes.OrderByDescending(a => a.SoLuongBan).Take(count).ToList();
        }

        // GET: Home
        public ActionResult Index()
        {
            // Lay 6 quyen sach moi
            var listSachMoi = LaySachMoi(6);
            return View(listSachMoi);
        }

        public ActionResult ChuDePartial()
        {
            var listChuDe = from cd in data.CHUDEs select cd;
            return PartialView(listChuDe);
        }

        public ActionResult NxbPartial()
        {
            var listNxb = from nxb in data.NHAXUATBANs select nxb;
            return PartialView(listNxb);
        }

        public ActionResult SachBanNhieuPartial()
        {
            var listSachBanNhieu = LaySachBanNhieu(3);
            return PartialView(listSachBanNhieu);
        }

        public ActionResult SachTheoCD(int id)
        {
            var sach = from s in data.SACHes where s.MaCD == id select s;
            return View(sach);
        }

        public ActionResult SachTheoNXB(int id)
        {
            var sach = from s in data.SACHes where s.MaNXB == id select s;
            return View(sach);
        }

        public ActionResult ChiTietSach(int id)
        {
            var sach = from s in data.SACHes where s.MaSach == id select s;
            return View(sach.Single());
        }
    }
}