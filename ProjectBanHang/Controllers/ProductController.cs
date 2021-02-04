using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectBanHang.Models;

namespace ProjectBanHang.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult productDetail(int proid)
        {
            Model1 db = new Model1();
            Product prodetail = db.Products.Where(p => p.IDSP == proid).SingleOrDefault();
            return View(prodetail);
        }
        [ChildActionOnly]
        public ActionResult getCategories()
        {
            Model1 db = new Model1();
            List<DanhMucSanPham> listdm = db.DanhMucSanPhams.ToList<DanhMucSanPham>();
            return PartialView(listdm);
        }
        public ActionResult listPro(int dmid)
        {
            Model1 db = new Model1();
            List<Product> listdm = db.Products.Where(p=>p.IDDM==dmid).ToList();
            return View(listdm);
        }

    }
}