using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an_quan_ly_san_bong
{
    class ClassphieuDatSan
    {
        Database db;
        public ClassphieuDatSan()
        {
            db = new Database();
        }
        public bool ktma(string manv)
        {
            string sqlkt = "select MA_PHIEU_DAT_SAN FROM PHIEU_DAT_SAN  WHERE MA_PHIEU_DAT_SAN = '" + manv + "'";
            return db.kiemtra(sqlkt);
        }
        public bool ktmasan(string manv)
        {
            string sqlkt = "select MA_SAN FROM PHIEU_DAT_SAN  WHERE MA_SAN = '" + manv + "'";
            return db.kiemtra(sqlkt);
        }
        public DataTable LayDsphieudat()
        {
            string strSQL = "SELECT MA_PHIEU_DAT_SAN,N.TEN_NV,K.TEN, convert(nvarchar(30),NGAY_LAP,110),convert(nvarchar(30),GIO_DAT,108),convert(nvarchar(30),GIO_HET,108),S.MA_SAN,GHI_CHU FROM PHIEU_DAT_SAN P, NHAN_VIEN N, KHACH K,SAN_BONG S WHERE (P.MA_NV = N.MA_NV and P.MA_KHACH = K.MA_KHACH and P.MA_SAN=S.MA_SAN) ";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public DataTable Hienthisoluonghang()
        {
            string strSQL = "SELECT COUNT(*) FROM PHIEU_DAT_SAN ";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public DataTable Laymasan()
        {
            string strSQL = "Select MA_SAN  from SAN_BONG";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable Laytennv()
        {
            string strSQL = "Select MA_NV,TEN_NV  from NHAN_VIEN";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable Laytenkhach()
        {
            string strSQL = " select MA_KHACH,TEN FROM KHACH";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public void XoaNhanVien(string index_nv)
        {
            string sql = "DELETE FROM  PHIEU_DAT_SAN WHERE MA_PHIEU_DAT_SAN= N'" + index_nv + "'";
            db.ExecuteNonQuery(sql);
        }
        //Thêm 1 nhân viên mới
        public void Themphieudatsan(string maphieu, string manv, string makhach, string ngaylap, string giodat, string giohet,string masan,string ghichu)
        {
            string sql = "insert into PHIEU_DAT_SAN VALUES(" + maphieu + ",N'" + manv + "',N'" + makhach + "','" + ngaylap + "','" + giodat + "','" + giohet + "','"+masan+"','"+ghichu+"')";
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatNhanVien(string maphieu, string manv, string makhach, string ngaylap, string giodat, string giohet, string masan,string ghichu)
        {
            string str = "UPDATE PHIEU_DAT_SAN SET MA_NV = N'" + manv + "',MA_KHACH= N'" + makhach + "',NGAY_LAP='" + ngaylap + "',GIO_DAT='"+giodat+"',GIO_HET='"+giohet+"',MA_SAN='"+masan+"',GHI_CHU='"+ghichu+"' WHERE MA_PHIEU_DAT_SAN = '" + maphieu + "'";
            db.ExecuteNonQuery(str);
        }
    }
}
