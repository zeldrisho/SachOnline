using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SachOnline.Models;

namespace SachOnline.Controllers
{
    public class SearchController : Controller
    {
        DbSachOnlineDataContext data = new DbSachOnlineDataContext();

        public ActionResult Search(string strSearch)
        {
            ViewBag.Search = strSearch;
            if (string.IsNullOrEmpty(strSearch))
            {
                return View();
            }

            var kq = data.SACHes.Where(s => s.TenSach.Contains(strSearch));
            //var kq = data.SACHes.Where(s => s.MaCD == int.Parse(strSearch));
            //var kq = data.SACHes.Where(s => (s.SoLuongBan >= 5 && s.SoLuongBan <= 10));
            //var kq = data.SACHes.Where(s => (
            //    s.MaSach == int.Parse(strSearch) ||
            //    s.TenSach.Contains(strSearch) ||
            //    s.MoTa.Contains(strSearch) ||
            //    s.SoLuongBan == int.Parse(strSearch) ||
            //    s.MaCD == int.Parse(strSearch) ||
            //    s.MaNXB == int.Parse(strSearch)
            //));
            //var kq = data.SACHes.Where(s => (s.SoLuongBan >= 5 && s.SoLuongBan <= 10)).OrderBy(s => s.SoLuongBan);
            //var kq = data.SACHes.Where(s => (s.SoLuongBan >= 5 && s.SoLuongBan <= 10)).OrderByDescending(s => s.SoLuongBan);
            
            ViewBag.Kq = kq.Count();
            return View(kq);
        }

        public ActionResult Group()
        {
            // var kq = from s in db.SACHes group s by s.MaCD;
            var kq = data.SACHes.GroupBy(s => s.MaCD);
            return View(kq);
        }

        public ActionResult ThongKe()
        {
            var kq = from s in data.SACHes
                     join cd in data.CHUDEs on s.MaCD equals cd.MaCD
                     group s by new { cd.MaCD, cd.TenChuDe } into g
                     select new ReportInfo
                     {
                         Id = g.Key.MaCD.ToString(),
                         Name = g.Key.TenChuDe,
                         Count = g.Count(),
                         Sum = g.Sum(n => n.SoLuongBan),
                         Max = g.Max(n => n.SoLuongBan),
                         Min = g.Min(n => n.SoLuongBan),
                         Avg = Convert.ToDecimal(g.Average(n => n.SoLuongBan))
                     };
            return View(kq);
        }
    }
}