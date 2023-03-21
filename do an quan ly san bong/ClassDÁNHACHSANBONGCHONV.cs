using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an_quan_ly_san_bong
{
    class ClassDÁNHACHSANBONGCHONV
    {
        Database db;
        public ClassDÁNHACHSANBONGCHONV()
        {
            db = new Database();
        }
        public DataTable LayDssan()
        {
            string strSQL = "SELECT MA_SAN,N.GIA_LOAI,T.TEN_LOAI FROM SAN_BONG T, LOAISAN N  WHERE T.GIA_LOAI = N.GIA_LOAI";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public DataTable timkiemmasan(string masan)
        {
            string strSQL = "SELECT MA_SAN,N.GIA_LOAI,T.TEN_LOAI FROM SAN_BONG T, LOAISAN N  WHERE T.GIA_LOAI = N.GIA_LOAI and MA_SAN LIKE '%"+masan+"%'";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public bool ktmasan(string manv)
        {
            string sqlkt = "select MA_SAN FROM SAN_BONG T, LOAISAN N WHERE MA_SAN like '%" + manv + "%'";
            return db.kiemtra(sqlkt);
        }
        public DataTable timkiemgiâsan(string masan)
        {
            string strSQL = "SELECT MA_SAN,N.GIA_LOAI,T.TEN_LOAI FROM SAN_BONG T, LOAISAN N  WHERE T.GIA_LOAI = N.GIA_LOAI and N.GIA_LOAI LIKE '%" + masan + "%'";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public bool ktmagialoai(string manv)
        {
            string sqlkt = "select  N.GIA_LOAI FROM SAN_BONG T, LOAISAN N WHERE N.GIA_LOAI like '%" + manv + "%'";
            return db.kiemtra(sqlkt);
        }
        public DataTable timkiemténsan(string masan)
        {
            string strSQL = "SELECT MA_SAN,N.GIA_LOAI,T.TEN_LOAI FROM SAN_BONG T, LOAISAN N  WHERE T.GIA_LOAI = N.GIA_LOAI and T.TEN_LOAI LIKE N'%" + masan + "%'";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public bool ktténan(string manv)
        {
            string sqlkt = "select  T.TEN_LOAI FROM SAN_BONG T, LOAISAN N WHERE T.TEN_LOAI like N'%" + manv + "%'";
            return db.kiemtra(sqlkt);
        }
    }
}
