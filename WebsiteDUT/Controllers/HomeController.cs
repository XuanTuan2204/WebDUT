using ModelEF.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebsiteDUT.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.MenuTop = new LoaiDonViDao().ListAll();
            ViewBag.MenuItemTop = new DonViDao().ListAll();
            
            ViewBag.TinTuc = new ChuyenMucDao().ListAll();
            ViewBag.HoatDong = new ChuyenMucDao().ListAll();
            return View();
        }

        [ChildActionOnly]
        [OutputCache(Duration = 3600 * 24)]
        public ActionResult TinTucSuKien()
        {
            ViewBag.TinTucSuKien = new ChuyenMucDao().ListAll(); 
            return PartialView();
        }

        [ChildActionOnly]
        [OutputCache(Duration = 3600 * 24)]
        public ActionResult HoatDongLienKet()
        {
            ViewBag.LienKetNhanh = new LienKetDao().ListAll();
            ViewBag.HoatDongLienKet = new ChuyenMucDao().ListAll1();
            return PartialView();
        }

        [ChildActionOnly]
        [OutputCache(Duration = 3600 * 24)]
        public ActionResult ThongTinTuyenSinh()
        {
            ViewBag.ThongTinTuyenSinh = new ChuyenMucDao().ListTTTS();
            return PartialView();
        }

    }
}