namespace do_an_quan_ly_san_bong.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAP_QUYEN
    {
        [Key]
        [StringLength(20)]
        public string QUYEN { get; set; }
    }
}
