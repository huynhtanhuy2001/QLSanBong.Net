namespace do_an_quan_ly_san_bong.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NHAN_VIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHAN_VIEN()
        {
            PHIEU_DAT_SAN = new HashSet<PHIEU_DAT_SAN>();
            PHIEU_DEN_BU = new HashSet<PHIEU_DEN_BU>();
            PHIEU_GUI_XE = new HashSet<PHIEU_GUI_XE>();
            TAI_KHOAN = new HashSet<TAI_KHOAN>();
            THIET_BI_SAN = new HashSet<THIET_BI_SAN>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MA_NV { get; set; }

        [StringLength(40)]
        public string TEN_NV { get; set; }

        public int? MA_CHUC_VU { get; set; }

        [StringLength(12)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string DIA_CHI { get; set; }

        public DateTime? NGAY_SINH { get; set; }

        [StringLength(5)]
        public string GIOI_TINH { get; set; }

        public virtual CHUC_VU CHUC_VU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_DAT_SAN> PHIEU_DAT_SAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_DEN_BU> PHIEU_DEN_BU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_GUI_XE> PHIEU_GUI_XE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAI_KHOAN> TAI_KHOAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THIET_BI_SAN> THIET_BI_SAN { get; set; }
    }
}
