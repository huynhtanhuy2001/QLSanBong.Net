using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an_quan_ly_san_bong
{
    class Classtt_Khách
    {
        Database db;
        public Classtt_Khách()
        {
            db = new Database();
        }
        public DataTable LayDSNhanvien()
        {
            string strSQL = "Select *  from KHACH";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public DataTable timkiemten(string ten)
        {
            string strSQL = "Select *  from KHACH where TEN LIKE N'%"+ten+"%'";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public DataTable timkiemSDT(string ten)
        {
            string strSQL = "Select *  from KHACH where SDT LIKE N'%" + ten + "%'";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public bool ktsdt(string manv)
        {
            string sqlkt = "select  SDT FROM KHACH WHERE SDT LIKE N'%" + manv + "%'";
            return db.kiemtra(sqlkt);
        }
        public bool ktten(string manv)
        {
            string sqlkt = "select  TEN FROM KHACH WHERE TEN LIKE N'%" + manv + "%'";
            return db.kiemtra(sqlkt);
        }
        public bool ktma(string manv)
        {
            string sqlkt = "select  MA_KHACH FROM KHACH WHERE MA_KHACH= '" + manv + "'";
            return db.kiemtra(sqlkt);
        }

        public void XoaNhanVien(string index_nv)
        {
            string sql = "Delete from  KHACH  where MA_KHACH = " + index_nv;
            db.ExecuteNonQuery(sql);
        }
        public void xoattphieuguixe(string index_nv)
        {
            string sql = "Delete from  PHIEU_GUI_XE where MA_KHACH= " + index_nv;
            db.ExecuteNonQuery(sql);
        }
        public void xoattphieudatsan(string index_nv)
        {
            string sql = "Delete from  PHIEU_DAT_SAN where MA_KHACH = " + index_nv;
            db.ExecuteNonQuery(sql);
        }
        //Thêm 1 nhân viên mới
        public void ThemNhanVien(string ma, string sdt, string ten, string diachi )
        {
            string sql = string.Format("Insert Into KHACH Values('{0}','{1}',N'{2}',N'{3}')",ma, sdt, ten, diachi);
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatNhanVien(string ma, string sdt, string ten, string diachi)
        {
            string str = string.Format("Update KHACH set  SDT = '{0}', TEN=N'{1}',DIA_CHI=N'{2}' where MA_KHACH ='{3}'", sdt, ten, diachi, ma);
            db.ExecuteNonQuery(str);

        }
    }
}
