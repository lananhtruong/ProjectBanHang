namespace ProjectBanHang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonHang")]
    public partial class DonHang
    {
        [Key]
        public int IDDH { get; set; }

        public int IDAcc { get; set; }

        public DateTime? Ngay { get; set; }

        [StringLength(50)]
        public string NguoiNhan { get; set; }

        [StringLength(50)]
        public string SDT { get; set; }

        [StringLength(100)]
        public string DiaChiGiaoHang { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public int? TinhTrang { get; set; }
    }
}
