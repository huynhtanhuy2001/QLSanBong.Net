namespace do_an_quan_ly_san_bong.model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BAN_CHAM_CONGG
    {
        [Key]
        public int STT { get; set; }

        public int? MA_NV { get; set; }

        [StringLength(30)]
        public string TEN_NV { get; set; }

        public DateTime? NGAY_LAM { get; set; }

        public DateTime? GIO_LAM { get; set; }

        public DateTime? GIO_NGHI { get; set; }
    }
}
