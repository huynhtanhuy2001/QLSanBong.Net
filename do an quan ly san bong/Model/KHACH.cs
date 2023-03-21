namespace do_an_quan_ly_san_bong.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACH")]
    public partial class KHACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACH()
        {
            PHIEU_DAT_SAN = new HashSet<PHIEU_DAT_SAN>();
            PHIEU_GUI_XE = new HashSet<PHIEU_GUI_XE>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MA_KHACH { get; set; }

        [StringLength(12)]
        public string SDT { get; set; }

        [StringLength(40)]
        public string TEN { get; set; }

        [StringLength(50)]
        public string DIA_CHI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_DAT_SAN> PHIEU_DAT_SAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_GUI_XE> PHIEU_GUI_XE { get; set; }
    }
}
