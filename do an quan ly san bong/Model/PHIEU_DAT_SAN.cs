namespace do_an_quan_ly_san_bong.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHIEU_DAT_SAN
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MA_PHIEU_DAT_SAN { get; set; }

        public int? MA_NV { get; set; }

        public int? MA_KHACH { get; set; }

        public DateTime? NGAY_LAP { get; set; }

        public DateTime? GIO_DAT { get; set; }

        public DateTime? GIO_HET { get; set; }

        public int? MA_SAN { get; set; }

        public virtual KHACH KHACH { get; set; }

        public virtual NHAN_VIEN NHAN_VIEN { get; set; }

        public virtual SAN_BONG SAN_BONG { get; set; }
    }
}
