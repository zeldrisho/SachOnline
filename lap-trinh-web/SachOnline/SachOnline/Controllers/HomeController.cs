using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SachOnline.Models;
using PagedList;
using PagedList.Mvc;
using System.Web.UI.WebControls;
using System.Web.UI;

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
        public ActionResult Index(int? page)
        {
            int pageSize = 6;
            int pageNum = (page ?? 1);
            var listSachMoi = LaySachMoi(20);
            return View(listSachMoi.ToPagedList(pageNum, pageSize));
        }

        public ActionResult ChuDePartial()
        {
            var listChuDe = data.CHUDEs;
            return PartialView(listChuDe);
        }

        public ActionResult NxbPartial()
        {
            var listNxb = data.NHAXUATBANs;
            return PartialView(listNxb);
        }

        public ActionResult SachBanNhieuPartial()
        {
            var listSachBanNhieu = LaySachBanNhieu(6);
            return PartialView(listSachBanNhieu);
        }

        public ActionResult SachTheoCD(int id, int? page)
        {
            ViewBag.MaCD = id;
            int pageSize = 3;
            int pageNum = (page ?? 1);
            var sach = data.SACHes.Where(s => s.MaCD == id);
            return View(sach.ToPagedList(pageNum, pageSize));
        }

        public ActionResult SachTheoNXB(int id, int? page)
        {
            ViewBag.MaNXB = id;
            int pageSize = 3;
            int pageNum = (page ?? 1);
            var sach = data.SACHes.Where(s => s.MaNXB == id);
            return View(sach.ToPagedList(pageNum, pageSize));
        }

        public ActionResult ChiTietSach(int id)
        {
            var sach = data.SACHes.Where(s => s.MaSach == id);
            return View(sach.Single());
        }

        public ActionResult NavPartial()
        {
            var menu = data.MENUs;
            return PartialView(menu);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection f)
        {
            //Gán các giá trị người dùng nhập liệu cho các biến
            var sTenDN = f["UserName"];
            var sMatKhau = f["Password"];
            //Gán giá trị cho đối tượng được tạo mới (ad)
            ADMIN ad = data.ADMINs.SingleOrDefault(n => n.TenDN == sTenDN && n.MatKhau == sMatKhau);
            if (ad != null)
            {
                Session["Admin"] = ad;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ThongBao = "Tên đăng nhập hoặc mật khẩu không đúng";
            }
            return View();
        }

        public ActionResult MenuPartial()
        {
            ViewBag.Menu = MenuList();
            return PartialView();
        }

        private IList<MENU> MenuList()
        {
            var list = data.MENUs.ToList();
            return list;
        }

        public ActionResult LoginLogoutPartial()
        {
            return PartialView();
        }
    }
}