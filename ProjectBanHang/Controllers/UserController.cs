using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectBanHang.Models;
using System.Security.Cryptography;
using System.Text;

namespace ProjectBanHang.Controllers
{
    public class UserController : Controller
    {
        Model1 db = new Model1();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterModel user)
        {
            //try
            //{
                Model1 db = new Model1();
                if (ModelState.IsValid == true)
                {
                    UserManager usermanager = new UserManager();
                    if (usermanager.CheckUserName(user.username) == false && usermanager.CheckEmail(user.email) == false)/*chua t?n t?i nên t?o m?i*/
                    {
                        Account newuser = new Account();
                        newuser.username = user.username;

                        newuser.password = MaHoa.GetMd5Hash(user.password);

                        newuser.name = user.name;
                        newuser.address = user.address;
                        newuser.phonenumber = user.phonenumber;
                        newuser.email = user.email;


                        db.Accounts.Add(newuser);
                        db.SaveChanges();
                        ViewBag.dangkythanhcong = "Ðã đăng ký thành công";
                        return View();
                    }
                    else
                    {
                        return View("FailRegister");
                        //ModelState.AddModelError("RegisterFail", "Tai khoan da ton tai");
                        //ViewBag.error = "Tai khoan da ton tai";
                    }

                }
            //}
            //catch (Exception ex)
            //{

            //}
            return View();
        }
        public ActionResult FailRegister()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel user)
        {
            if (ModelState.IsValid)
            {
                Model1 db = new Model1();
                UserManager usermanager = new UserManager();

                if (usermanager.CheckUser(user.username, MaHoa.GetMd5Hash(user.password)) == true)
                {
                    Session["Logged"] = "Xin chào" + " " + user.username;


                    return RedirectToAction("Index","Home");

                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập không hợp lệ");
                    ViewBag.thongbao = "Tên tài khoản hoặc mật khẩu sai";
                    return View();
                }
            }
            return View();
        }
        public ActionResult Logout()
        {
            Session["Logged"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}