namespace do_an_quan_ly_san_bong.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAN_BONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SAN_BONG()
        {
            PHIEU_DAT_SAN = new HashSet<PHIEU_DAT_SAN>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MA_SAN { get; set; }

        public double? GIA_LOAI { get; set; }

        [StringLength(30)]
        public string TEN_LOAI { get; set; }

        public virtual LOAISAN LOAISAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_DAT_SAN> PHIEU_DAT_SAN { get; set; }
    }
}
