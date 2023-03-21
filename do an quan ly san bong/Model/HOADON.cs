namespace do_an_quan_ly_san_bong.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MA_HD { get; set; }

        [StringLength(50)]
        public string TEN_NV { get; set; }

        [StringLength(50)]
        public string TEN_KHACH { get; set; }

        [StringLength(20)]
        public string SAN_THUE { get; set; }

        public DateTime? NGAY_LAP { get; set; }

        public DateTime? GIO_DAT { get; set; }

        public DateTime? GIO_HET { get; set; }

        [StringLength(10)]
        public string TONG_GIO { get; set; }

        public double? TONG_TIEN { get; set; }
    }
}
