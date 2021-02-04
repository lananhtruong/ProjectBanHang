using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjectBanHang.Models
{
    public class RegisterModel
    {
        //public int ID { get; set; }

        [Display(Name = "User Name")]
        [Required(ErrorMessage = "User name bắt buộc nhập !!!")]
        public string username { get; set; }


        [Required(ErrorMessage = "Password bắt buộc nhập !!!")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }


        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage ="Password không trùng khớp !!!")]
        public string confirmpassword { get; set; }


        [Display(Name = "Name")]
        [Required(ErrorMessage = "Tên bắt buộc nhập !!!")]
        public string name { get; set; }


        [Display(Name = "Address")]
        [Required(ErrorMessage = "Địa chỉ bắt buộc nhập !!!")]
        public string address { get; set; }


        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Sđt bắt buộc nhập !!!")]
        public string phonenumber { get; set; }


        [Required(ErrorMessage = "Email bắt buộc nhập !!!")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage ="Email không hợp lệ !!!")]
        public string email { get; set; }
    }
    public class LoginModel
    {
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "User name bắt buộc nhập !!!")]
        public string username { get; set; }



        [Required(ErrorMessage = "Password bắt buộc nhập !!!")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}