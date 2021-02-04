using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectBanHang.Models;

namespace ProjectBanHang.Controllers
{
    public class CartController : Controller
    {
        Model1 db = new Model1();
        private const string CartSession = "CartSession";
        // GET: Cart
        public ActionResult Index()
        {
            var giohang = Session[CartSession];
            var listgh = new List<Cart>();

            if (giohang != null)
            {
                listgh = (List<Cart>)giohang;
            }


            return View(listgh);
        }
        public ActionResult AddtoCart(int SPID)
        {

            if (Session[CartSession] == null)
            {
                Session[CartSession] = new List<Cart>();

            }
            List<Cart> listgh = Session[CartSession] as List<Cart>;
            if (listgh.Exists(m => m.IDSP == SPID)) // ko co sp nay trong gio hang
            {
                // Nếu sản phẩm khách chọn đã có trong giỏ hàng thì không thêm vào giỏ nữa mà tăng số lượng lên.
                Cart card = listgh.FirstOrDefault(m => m.IDSP == SPID);
                card.SoLuong++;


            }
            else
            {
                Product pro = db.Products.Find(SPID);  // tim sp theo sanPhamID

                Cart newItem = new Cart()
                {
                    IDSP = SPID,
                    TenSP = pro.TenSP,
                    SoLuong = 1,
                    Hinh = pro.Hinh,
                    GiaBan = pro.GiaBan

                };  // Tạo ra 1 CartItem mới

                listgh.Add(newItem);  // Thêm CartItem vào giỏ 
            }

            // Action này sẽ chuyển hướng về trang chi tiết sp khi khách hàng đặt vào giỏ thành công. Bạn có thể chuyển về chính trang khách hàng vừa đứng bằng lệnh return Redirect(Request.UrlReferrer.ToString()); nếu muốn.
            return RedirectToAction("Index", "Cart", new { proid = SPID });
        }

        public ActionResult Deleted(int SPID)
        {
            List<Cart> giohang = Session[CartSession] as List<Cart>;
            Cart itemXoa = giohang.FirstOrDefault(m => m.IDSP == SPID);
            if (itemXoa != null)
                giohang.Remove(itemXoa);
            {
            }
            return RedirectToAction("Index", "Cart");

        }
        public ActionResult Updated(int SPID, int Soluongmoi)
        {
            List<Cart> giohang = Session[CartSession] as List<Cart>;
            Cart itemSua = giohang.FirstOrDefault(m => m.IDSP == SPID);
            if (itemSua != null)
            { itemSua.SoLuong = Soluongmoi; }
            return RedirectToAction("Index", "Cart");
        }
    }
}