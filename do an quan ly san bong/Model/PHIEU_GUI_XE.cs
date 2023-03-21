namespace do_an_quan_ly_san_bong.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHIEU_GUI_XE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEU_GUI_XE()
        {
            PHIEU_DEN_BU_CUA_NV = new HashSet<PHIEU_DEN_BU_CUA_NV>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MA_PHIEU_GUI_XE { get; set; }

        public int? MA_NV { get; set; }

        public int? MA_KHACH { get; set; }

        public DateTime? NGAY_LAP { get; set; }

        public virtual KHACH KHACH { get; set; }

        public virtual NHAN_VIEN NHAN_VIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_DEN_BU_CUA_NV> PHIEU_DEN_BU_CUA_NV { get; set; }
    }
}
