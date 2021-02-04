namespace ProjectBanHang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TinhTrang")]
    public partial class TinhTrang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDTinhTrang { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }
    }
}
