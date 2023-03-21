namespace do_an_quan_ly_san_bong.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TAI_KHOAN
    {
        [Key]
        [StringLength(50)]
        public string TEN_DANG_NHAP { get; set; }

        public int? MA_NV { get; set; }

        [StringLength(15)]
        public string MAT_KHAU { get; set; }

        [StringLength(20)]
        public string QUYEN { get; set; }

        public virtual NHAN_VIEN NHAN_VIEN { get; set; }
    }
}
