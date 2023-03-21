using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace do_an_quan_ly_san_bong.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<CAP_QUYEN> CAP_QUYEN { get; set; }
        public virtual DbSet<CHUC_VU> CHUC_VU { get; set; }
        public virtual DbSet<HINH_THUC_DEN_BU> HINH_THUC_DEN_BU { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACH> KHACHes { get; set; }
        public virtual DbSet<LOAISAN> LOAISANs { get; set; }
        public virtual DbSet<NHAN_VIEN> NHAN_VIEN { get; set; }
        public virtual DbSet<PHIEU_DAT_SAN> PHIEU_DAT_SAN { get; set; }
        public virtual DbSet<PHIEU_DEN_BU> PHIEU_DEN_BU { get; set; }
        public virtual DbSet<PHIEU_DEN_BU_CUA_NV> PHIEU_DEN_BU_CUA_NV { get; set; }
        public virtual DbSet<PHIEU_GUI_XE> PHIEU_GUI_XE { get; set; }
        public virtual DbSet<PHIEU_TIEN_ICH> PHIEU_TIEN_ICH { get; set; }
        public virtual DbSet<SAN_BONG> SAN_BONG { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TAI_KHOAN> TAI_KHOAN { get; set; }
        public virtual DbSet<THIET_BI_SAN> THIET_BI_SAN { get; set; }
        public virtual DbSet<TIEN_ICH> TIEN_ICH { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
