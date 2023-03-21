namespace do_an_quan_ly_san_bong.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHIEU_TIEN_ICH
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MA_PHIEU_TIEN_ICH { get; set; }

        public int? MA_CTPDS { get; set; }

        public int? MA_TIEN_ICH { get; set; }

        public DateTime? NGAY_LAP { get; set; }
    }
}
