namespace do_an_quan_ly_san_bong.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class THIET_BI_SAN
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MA_THIET_BI_SAN { get; set; }

        public int? MA_SAN { get; set; }

        public int? MA_NV { get; set; }

        [StringLength(50)]
        public string TEN_THIET_BI { get; set; }

        public virtual NHAN_VIEN NHAN_VIEN { get; set; }
    }
}
