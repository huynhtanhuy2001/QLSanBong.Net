using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an_quan_ly_san_bong
{
    class calssDanhSachChucVu
    {
        Database db;
        public calssDanhSachChucVu()
        {
            db = new Database();
        }
        public bool ktma(string manv)
        {
            string sqlkt = "select  MA_CHUC_VU FROM CHUC_VU WHERE MA_CHUC_VU= '" + manv + "'";
            return db.kiemtra(sqlkt);
        }
        public DataTable LayDSNhanvien()
        {
            string strSQL = "SELECT * from CHUC_VU ";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public void XoaNhanVien(string index_nv)
        {
            string sql = "DELETE FROM  CHUC_VU WHERE MA_CHUC_VU= N'" + index_nv + "'";
            db.ExecuteNonQuery(sql);
        }
        public void XoaNhanVienbenbangnv(string index_nv)
        {
            string sql = "DELETE FROM  NHAN_VIEN WHERE MA_CHUC_VU= N'" + index_nv + "'";
            db.ExecuteNonQuery(sql);
        }

        //Thêm 1 nhân viên mới
        public void ThemNhanVien(string ma, string ten)
        {
            string sql = "insert into CHUC_VU VALUES(" + ma + ",N'" + ten + "')";
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatNhanVien(string index_nv, string tenchucvu)
        {
            string str = "UPDATE CHUC_VU SET TEN_CHUC_VU = N'" + tenchucvu + "' WHERE MA_CHUC_VU = '" + index_nv + "'";
            db.ExecuteNonQuery(str);
        }
    }
}
