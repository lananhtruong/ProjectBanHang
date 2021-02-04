using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBanHang.Models
{
    public class Cart
    {
        public string Hinh { get; set; }
        public int IDSP { get; set; }
        public string TenSP { get; set; }
        public int GiaBan { get; set; }
        public int SoLuong { get; set; }
        public int ThanhTien
        { get { return SoLuong * GiaBan; } }
    }
}