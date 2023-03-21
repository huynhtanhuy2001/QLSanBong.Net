using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace do_an_quan_ly_san_bong.model2
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<BAN_CHAM_CONGG> BAN_CHAM_CONGG { get; set; }
        public virtual DbSet<BANG_LUONG> BANG_LUONG { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
