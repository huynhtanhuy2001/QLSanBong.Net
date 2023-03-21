namespace do_an_quan_ly_san_bong.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIEN_ICH
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MA_TIEN_ICH { get; set; }

        [StringLength(50)]
        public string TEN_TIEN_ICH { get; set; }
    }
}
