using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an_quan_ly_san_bong
{
    class ClasstongLUONGTHEONGAYTHANGMANV
    {
        Database db;
        public ClasstongLUONGTHEONGAYTHANGMANV()
        {
            db = new Database();
        }
        public bool ktma(string manv)
        {
            string sqlkt = "select MA_NV FROM BANG_LUONG  WHERE MA_NV = '" + manv + "'";
            return db.kiemtra(sqlkt);
        }
        public bool ktmanvtimkiem(string manv)
        {
            string sqlkt = "select MA_NV FROM BANG_LUONG  WHERE MA_NV like '%" + manv + "%'";
            return db.kiemtra(sqlkt);
        }
        public bool ktngay(string ngaybatdau,string ngaykeythuc)
        {
            string sqlkt = "select NGAY_LAM,NGAY_LAM FROM BANG_LUONG  WHERE NGAY_LAM BETWEEN '" + ngaybatdau + "' AND '" + ngaykeythuc + "'";
            return db.kiemtra(sqlkt);
        }

        public DataTable tongtien(string ngyabatdau, string ngayketthuc,string manv)
        {
            string strSQL = " select sum(LUONG) FROM BANG_LUONG WHERE NGAY_LAM BETWEEN '" + ngyabatdau + "' AND '" + ngayketthuc + "' AND MA_NV='"+manv+"' ";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable timkiemngaythang(string ngyabatdau, string ngayketthuc)
        {
            string strSQL = " select MA_BC,MA_NV,TEN_NV,CONVERT(nvarchar(30),NGAY_LAM,110),convert(nvarchar(30),GIO_LAM,108),convert(nvarchar(30),GIO_NGHI,108),TONG_GIO,LUONG  FROM BANG_LUONG WHERE NGAY_LAM BETWEEN '" + ngyabatdau + "' AND '" + ngayketthuc + "'  ";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable timkiemmã(string manv)
        {
            string strSQL = " select MA_BC,MA_NV,TEN_NV,CONVERT(nvarchar(30),NGAY_LAM,110),convert(nvarchar(30),GIO_LAM,108),convert(nvarchar(30),GIO_NGHI,108),TONG_GIO,LUONG  FROM BANG_LUONG WHERE MA_NV LIKE '%"+manv+"%'  ";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable hienthidsluong()
        {
            string strSQL = " select MA_BC,MA_NV,TEN_NV,convert(nvarchar(30),NGAY_LAM,110),convert(nvarchar(30),GIO_LAM,108),convert(nvarchar(30),GIO_NGHI,108),TONG_GIO,LUONG FROM BANG_LUONG";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
       

    }
}
