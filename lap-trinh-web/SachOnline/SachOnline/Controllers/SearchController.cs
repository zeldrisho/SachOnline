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
            var kq = data.SACHes.Where(s => (
                s.MaCD == int.Parse(strSearch)
            )).OrderByDescending(s => s.SoLuongBan);
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
                     group s by s.MaCD into g
                     select new ReportInfo
                     {
                         Id = g.Key.ToString(),
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