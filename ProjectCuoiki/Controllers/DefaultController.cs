using ProjectCuoiki.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectCuoiki.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        ProjectCuoiKiEntities db = new ProjectCuoiKiEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getMenu()
        {
            var listitem =from item in db.menus where item.hide==true orderby item.order ascending  select item;
            return PartialView(listitem.ToList());
        }
        public ActionResult getSlideshow()
        {
            var listslide= from item in db.slideshows where item.hide==true orderby item.order ascending select  item;
            return PartialView(listslide.ToList());
        }
        public ActionResult getFooter()
        {
           
            var item=db.footers.FirstOrDefault(i => i.hide == true);
            return PartialView(item);
        }
        public ActionResult getbanneTtop()
        {
            var banneritem= db.banners.FirstOrDefault(i => i.hide == true& i.positionId==1);
            return PartialView(banneritem);  
        }
        public ActionResult getbannerMiddle()
        {
            var banneritem = db.banners.FirstOrDefault(i => i.hide == true & i.positionId==2);
            return PartialView(banneritem);
        }
        public ActionResult getbannerBottom()
        {
            var banneritem = db.banners.FirstOrDefault(i => i.hide == true & i.positionId == 3);
            return PartialView(banneritem);
        }
        public ActionResult getListNewProductByDate() { 

            var listitem=(from item in db.products where item.hide== true orderby item.datebegin ascending select item).Take(6);
            return PartialView(listitem.ToList());
        }
        public ActionResult getNews()
        {
            var listitem = (from item in db.news where item.hide == true orderby item.datebegin ascending select item).Take(3);
            return PartialView(listitem.ToList());
        }
    }
}