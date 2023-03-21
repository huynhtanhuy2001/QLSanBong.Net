using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an_quan_ly_san_bong
{
    class Classtomgdoanhthutheongaythang
    {
        Database db;
        public Classtomgdoanhthutheongaythang()
        {
            db = new Database();
        }
        public bool ktngay(string ngaybatdau, string ngaykeythuc)
        {
            string sqlkt = "select NGAY_LAP,NGAY_LAP FROM HOADON  WHERE NGAY_LAP BETWEEN '" + ngaybatdau + "' AND '" + ngaykeythuc + "'";
            return db.kiemtra(sqlkt);
        }
        public DataTable timkiemngaythang(string ngyabatdau, string ngayketthuc)
        {
            string strSQL = " SELECT MA_HD,TEN_NV,TEN_KHACH,SAN_THUE,convert(nvarchar(30),NGAY_LAP,110),convert(nvarchar(30),GIO_DAT,108),convert(nvarchar(30),GIO_HET,108),TONG_GIO,TONG_TIEN  FROM HOADON WHERE NGAY_LAP BETWEEN '" + ngyabatdau + "' AND '" + ngayketthuc + "'  ";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable tongtien(string ngyabatdau,string ngayketthuc)
        {
            string strSQL = " select sum(TONG_TIEN) FROM HOADON WHERE NGAY_LAP BETWEEN '"+ngyabatdau+"' AND '"+ngayketthuc+"' ";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
       
        public DataTable hienthidsbangchamcong()
        {
            string strSQL = "SELECT MA_HD,TEN_NV,TEN_KHACH,SAN_THUE,convert(nvarchar(30),NGAY_LAP,110),convert(nvarchar(30),GIO_DAT,108),convert(nvarchar(30),GIO_HET,108),TONG_GIO,TONG_TIEN FROM HOADON"; ;
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
    }
}
