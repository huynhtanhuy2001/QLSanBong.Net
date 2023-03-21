namespace do_an_quan_ly_san_bong.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHIEU_DEN_BU_CUA_NV
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MA_PHIEU_DEN_NV { get; set; }

        public int? MA_PHIEU_GUI_XE { get; set; }

        public int? MA_HINH_THUC_DEN { get; set; }

        public DateTime? NGAY_LAP { get; set; }

        public virtual HINH_THUC_DEN_BU HINH_THUC_DEN_BU { get; set; }

        public virtual PHIEU_GUI_XE PHIEU_GUI_XE { get; set; }
    }
}
