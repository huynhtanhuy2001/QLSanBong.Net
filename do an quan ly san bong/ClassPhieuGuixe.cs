using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an_quan_ly_san_bong
{
    class ClassPhieuGuixe
    {
        Database db;
        public ClassPhieuGuixe()
        {
            db = new Database();
        }
        public bool ktma(string manv)
        {
            string sqlkt = "select MA_PHIEU_GUI_XE FROM PHIEU_GUI_XE WHERE MA_PHIEU_GUI_XE  = '" + manv + "'";
            return db.kiemtra(sqlkt);
        }
        public bool ktbiénsoxe(string manv)
        {
            string sqlkt = "select BIEN_SO_XE FROM PHIEU_GUI_XE WHERE BIEN_SO_XE  = '" + manv + "'";
            return db.kiemtra(sqlkt);
        }
        public DataTable LayDSNhanvien()
        {
            string strSQL = "SELECT MA_PHIEU_GUI_XE,N.MA_NV,K.MA_KHACH, NGAY_LAP,BIEN_SO_XE FROM PHIEU_GUI_XE P, NHAN_VIEN N, KHACH K  WHERE (P.MA_NV = N.MA_NV and P.MA_KHACH=K.MA_KHACH) ";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public DataTable LayTENNV()
        {
            string strSQL = "Select MA_NV,TEN_NV from NHAN_VIEN";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable LayTENKHACH()
        {
            string strSQL = " select MA_KHACH,TEN FROM KHACH  ";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public void XoaNhanVien(string index_nv)
        {
            string sql = "DELETE FROM  PHIEU_GUI_XE WHERE MA_PHIEU_GUI_XE = N'" + index_nv + "'";
            db.ExecuteNonQuery(sql);
        }
        //Thêm 1 nhân viên mới

        public void ThemNhanPHIEUGX(string maphieu, string tennv, string TENkhach, string ngaylap,string bieso)
        {
            string sql = "insert into PHIEU_GUI_XE VALUES('" + maphieu + "',N'" + tennv + "',N'" + TENkhach + "','" + ngaylap + "',N'" + bieso + "')";
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatphieugx(string maphieu, string tennv, string TENkhach, string ngaylap, string bieso)
        {
            string str = "UPDATE PHIEU_GUI_XE SET MA_NV = N'" + tennv + "',MA_KHACH = N'" + TENkhach+ "',NGAY_LAP='" + ngaylap + "',BIEN_SO_XE='"+bieso+"' WHERE MA_PHIEU_GUI_XE = N'" + maphieu + "'";
            db.ExecuteNonQuery(str);
        }
    }
}
