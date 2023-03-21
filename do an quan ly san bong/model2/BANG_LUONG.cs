namespace do_an_quan_ly_san_bong.model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BANG_LUONG
    {
        [Key]
        [StringLength(20)]
        public string MA_BC { get; set; }

        public int? MA_NV { get; set; }

        [StringLength(30)]
        public string TEN_NV { get; set; }

        public DateTime? NGAY_LAM { get; set; }

        public DateTime? GIO_LAM { get; set; }

        public DateTime? GIO_NGHI { get; set; }

        public int? TONG_GIO { get; set; }

        public double? LUONG { get; set; }
    }
}
