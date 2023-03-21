namespace do_an_quan_ly_san_bong.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HINH_THUC_DEN_BU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HINH_THUC_DEN_BU()
        {
            PHIEU_DEN_BU_CUA_NV = new HashSet<PHIEU_DEN_BU_CUA_NV>();
            PHIEU_DEN_BU = new HashSet<PHIEU_DEN_BU>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MA_HINH_THUC_DEN { get; set; }

        [StringLength(50)]
        public string TEN_HINH_THUC_DEN { get; set; }

        [StringLength(50)]
        public string CACH_DEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_DEN_BU_CUA_NV> PHIEU_DEN_BU_CUA_NV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_DEN_BU> PHIEU_DEN_BU { get; set; }
    }
}
