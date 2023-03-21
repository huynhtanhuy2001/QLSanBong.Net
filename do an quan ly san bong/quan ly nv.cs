using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an_quan_ly_san_bong
{
    class quanlyTK
    {
        Database db;
        private string tendn;
        private string mk;
        private string chucvu;
        public quanlyTK()
        {
            db = new Database();
        }
        public quanlyTK(string tendn, string mk, string tennv, string chucvu)
        {
            this.Tendn = tendn;
            this.Mk = mk;
            this.Chucvu = chucvu;
        }

        public string Tendn { get => tendn; set => tendn = value; }
        public string Mk { get => mk; set => mk = value; }

        public string Chucvu { get => chucvu; set => chucvu = value; }

        public void hamgoitt(string tendN, string chucvU, string mK)
        {
            tendn = tendN;
            mk = mK;
            chucvu = chucvU;
        }
       
        public bool ktma(string manv)
        {
            string sqlkt = "select TEN_DANG_NHAP FROM TAI_KHOAN WHERE TEN_DANG_NHAP= '" + manv + "'";
            return db.kiemtra(sqlkt);
        }
        public DataTable LayDSNhanvien()
        {
            string strSQL = "SELECT TEN_DANG_NHAP,N.MA_NV,MAT_KHAU, Q.QUYEN FROM TAI_KHOAN T, NHAN_VIEN N, CAP_QUYEN Q  WHERE (T.MA_NV = N.MA_NV and T.QUYEN=Q.QUYEN) ";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public DataTable LaymaNV()
        {
            string strSQL = "Select MA_NV from NHAN_VIEN";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable Layquyen()
        {
            string strSQL = " select QUYEN FROM CAP_QUYEN ";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public void XoaNhanVien(string index_nv)
        {
            string sql = "DELETE FROM  TAI_KHOAN WHERE TEN_DANG_NHAP= N'" + index_nv+ "'";
            db.ExecuteNonQuery(sql);
        }
        //Thêm 1 nhân viên mới
        
        public void ThemNhanVien(string ten, string ma, string mk, string quyen)
        {
            string sql = "insert into TAI_KHOAN VALUES(N'" + ten + "','" + ma + "',N'" + mk + "',N'" + quyen + "')";
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatNhanVien(string index_nv, string chucvu, string mk, string quyen)
        {
            string str = "UPDATE TAI_KHOAN SET MA_NV = '" + chucvu + "',MAT_KHAU = N'" + mk + "',QUYEN=N'" + quyen + "' WHERE TEN_DANG_NHAP = N'" + index_nv + "'";
            db.ExecuteNonQuery(str);
        }
    }
}
