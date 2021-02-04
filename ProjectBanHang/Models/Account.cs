namespace ProjectBanHang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        public int IDAcc { get; set; }

        [StringLength(100)]
        public string username { get; set; }

        [StringLength(50)]
        public string password { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public string address { get; set; }

        [StringLength(50)]
        public string phonenumber { get; set; }

        public string email { get; set; }

        [StringLength(50)]
        public string quyen { get; set; }
    }
}
