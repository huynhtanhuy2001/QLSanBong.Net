using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an_quan_ly_san_bong
{
    class đăng_nhập
    {
        private string taikhoan;
        private string matkhau;
        public đăng_nhập()
        {
            Taikhoan = "";
            Matkhau = "";
        }
        public đăng_nhập(string taikhoan, string matkhau)
        {
            this.Taikhoan = taikhoan;
            this.Matkhau = matkhau;
        }

        public string Taikhoan { get => taikhoan; set => taikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }

        public void truyenthamsotk(string taikhoaN, string matkhaU)
        {
            Taikhoan = taikhoaN;
            Matkhau = matkhaU;
        }
    }
}
