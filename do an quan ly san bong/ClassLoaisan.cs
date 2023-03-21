using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an_quan_ly_san_bong
{
    class ClassLoaisan
    {
        Database db;
        public ClassLoaisan()
        {
            db = new Database();
        }
        public bool kttenloai(string manv)
        {
            string sqlkt = "select  TEN_LOAI FROM LOAISAN WHERE TEN_LOAI = '" + manv + "'";
            return db.kiemtra(sqlkt);
        }
        public DataTable LayDSNhanvien()
        {
            string strSQL = "SELECT * from LOAISAN";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public void XoaNhanVien(string index_nv)
        {
            string sql = "DELETE FROM  LOAISAN WHERE TEN_LOAI= N'" + index_nv + "'";
            db.ExecuteNonQuery(sql);
        }
        public void Xoasan(string index_nv)
        {
            string sql = "DELETE FROM  SAN_BONG  WHERE TEN_LOAI= N'" + index_nv + "'";
            db.ExecuteNonQuery(sql);
        }       
        //Thêm 1 nhân viên mới
        public void ThemNhanVien(string ten, string gia)
        {
            string sql = "insert into LOAISAN VALUES(N'" + ten + "'," + gia + ")";
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatNhanVien(string index_nv, string GIA)
        {
            string str = "UPDATE LOAISAN SET GIA_LOAI  = " + GIA+ " WHERE TEN_LOAI  = '" + index_nv + "'";
            db.ExecuteNonQuery(str);
        }
    }
}
