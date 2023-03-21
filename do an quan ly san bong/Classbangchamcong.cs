using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an_quan_ly_san_bong
{
    
    class Classbangchamcong
    {
        Database db;
        public Classbangchamcong()
        {
            db = new Database();
        }
       
        
        public DataTable LayTENNV(string ten)
        {
            string strSQL = "SELECT * from NHAN_VIEN where MA_NV= '"+ten+"' ";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        
        public DataTable hienthidsbangchamcong()
        {
            string strSQL = " select STT,B.MA_NV,B.TEN_NV,convert(nvarchar(30),NGAY_LAM,110),convert(nvarchar(30),GIO_LAM,108),convert(nvarchar(30),GIO_NGHI,108) FROM BAN_CHAM_CONGG B, NHAN_VIEN N WHERE B.MA_NV = N.MA_NV ";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable hienthidsluong()
        {
            string strSQL = " select MA_BC,MA_NV,TEN_NV,convert(nvarchar(30),NGAY_LAM,110),convert(nvarchar(30),GIO_LAM,108),convert(nvarchar(30),GIO_NGHI,108),TONG_GIO,LUONG FROM BANG_LUONG";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public void THEMLUONG(string mabl ,string manv, string tennv, string ngaylam, string giolam, string gionghi,string tonggio,string tongluong)
        {
            string sql = "insert into BANG_LUONG   VALUES (N'"+mabl+"'," + manv + ",N'" + tennv + "','" + ngaylam + "','" + giolam + "','" + gionghi + "','"+tonggio+"','"+tongluong+"')";
            db.ExecuteNonQuery(sql);
        }
        public DataTable CHAMCONG(string stt)
        {
            string strSQL = " select DATEDIFF(HOUR,GIO_LAM,GIO_NGHI), DATEDIFF(HOUR,GIO_LAM,GIO_NGHI)*20000 from BAN_CHAM_CONGG WHERE STT = "+stt+" ";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public bool ktmabnagLUONG(string manv)
        {
            string sqlkt = "select MA_BC FROM BANG_LUONG WHERE MA_BC = N'" + manv + "'"; ;
            return db.kiemtra(sqlkt);
        }

        public void XoaNhanVien(string index_nv)
        {
            string sql = "DELETE FROM  BAN_CHAM_CONGG WHERE STT=  '" + index_nv + "'";
            db.ExecuteNonQuery(sql);
        }
        public void Xoattbangluong(string index_nv)
        {
            string sql = "DELETE FROM  BANG_LUONG WHERE MA_BC=  '" + index_nv + "'";
            db.ExecuteNonQuery(sql);
        }
        //Thêm 1 nhân viên mới
        public void Themphieudatsan(string manv, string tennv, string ngaylam, string giolam,string gionghi)
        {
            string sql = "insert into BAN_CHAM_CONGG   VALUES (" + manv + ",N'" + tennv + "','" + ngaylam+ "','" + giolam+ "','" + gionghi+ "')";
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatNhanVien( string stt,string manv, string tennv, string ngaylam, string giolam, string gionghi )
        {
            string str = "UPDATE BAN_CHAM_CONGG SET MA_NV = '" + manv + "',TEN_NV = N'" + tennv + "',NGAY_LAM='" + ngaylam + "',GIO_LAM='" + giolam + "',GIO_NGHI ='" + gionghi + "' WHERE STT = '" + stt + "'";
            db.ExecuteNonQuery(str);
        }
        public bool ktstt(string manv)
        {
            string sqlkt = "select STT FROM BAN_CHAM_CONGG WHERE STT LIKE  '%" + manv + "%'"; ;
            return db.kiemtra(sqlkt);
        }
        public DataTable TIMKIEMSTT(string manv)
        {
            string sqlkt = "select STT,B.MA_NV,B.TEN_NV,convert(nvarchar(30),NGAY_LAM,110),convert(nvarchar(30),GIO_LAM,108),convert(nvarchar(30),GIO_NGHI,108) FROM BAN_CHAM_CONGG B, NHAN_VIEN N WHERE (B.MA_NV = N.MA_NV) and STT LIKE  '%" + manv + "%'"; ;
            return db.Execute(sqlkt);
        }
        public bool ktten(string manv)
        {
            string sqlkt = "select TEN_NV FROM BAN_CHAM_CONGG WHERE TEN_NV LIKE  N'%" + manv + "%'"; ;
            return db.kiemtra(sqlkt);
        }
        public DataTable timten(string manv)
        {
            string sqlkt = " select STT,B.MA_NV,B.TEN_NV,convert(nvarchar(30),NGAY_LAM,110),convert(nvarchar(30),GIO_LAM,108),convert(nvarchar(30),GIO_NGHI,108) FROM BAN_CHAM_CONGG B, NHAN_VIEN N WHERE (B.MA_NV = N.MA_NV) and B.TEN_NV LIKE  N'%" + manv + "%'"; ;
            return db.Execute(sqlkt);
        }
        public bool ktmanv(string manv)
        {
            string sqlkt = "select MA_NV FROM BAN_CHAM_CONGG WHERE MA_NV LIKE  '%" + manv + "%'"; ;
            return db.kiemtra(sqlkt);
        }
        public DataTable timMANV(string manv)
        {
            string sqlkt = "select STT,B.MA_NV,B.TEN_NV,convert(nvarchar(30),NGAY_LAM,110),convert(nvarchar(30),GIO_LAM,108),convert(nvarchar(30),GIO_NGHI,108) FROM BAN_CHAM_CONGG B, NHAN_VIEN N WHERE (B.MA_NV = N.MA_NV) and B.MA_NV LIKE  '%" + manv + "%'"; ;
            return db.Execute(sqlkt);
        }
        public bool ktmabangluongtimkiem(string manv)
        {
            string sqlkt = "select MA_BC FROM BANG_LUONG WHERE MA_BC LIKE  N'%" + manv + "%'"; ;
            return db.kiemtra(sqlkt);
        }
        public DataTable timmabangluong(string manv)
        {
            string sqlkt = "select MA_BC,MA_NV,TEN_NV,convert(nvarchar(30),NGAY_LAM,110),convert(nvarchar(30),GIO_LAM,108),convert(nvarchar(30),GIO_NGHI,108),TONG_GIO,LUONG FROM BANG_LUONG WHERE MA_BC LIKE  N'%" + manv + "%'"; ;
            return db.Execute(sqlkt);
        }
        public bool ktmaMANVLUONG(string manv)
        {
            string sqlkt = "select MA_NV FROM BANG_LUONG WHERE MA_NV LIKE  '%" + manv + "%'"; ;
            return db.kiemtra(sqlkt);
        }
        public DataTable timmaNVLUONG(string manv)
        {
            string sqlkt = "select MA_BC,MA_NV,TEN_NV,convert(nvarchar(30),NGAY_LAM,110),convert(nvarchar(30),GIO_LAM,108),convert(nvarchar(30),GIO_NGHI,108),TONG_GIO,LUONG FROM BANG_LUONG WHERE MA_NV LIKE  '%" + manv + "%'"; ;
            return db.Execute(sqlkt);
        }
        public bool ktmaTENNVLUONG(string manv)
        {
            string sqlkt = "select TEN_NV FROM BANG_LUONG WHERE TEN_NV LIKE  '%" + manv + "%'"; ;
            return db.kiemtra(sqlkt);
        }
        public DataTable timmaTENLUONG(string manv)
        {
            string sqlkt = "select MA_BC,MA_NV,TEN_NV,convert(nvarchar(30),NGAY_LAM,110),convert(nvarchar(30),GIO_LAM,108),convert(nvarchar(30),GIO_NGHI,108),TONG_GIO,LUONG FROM BANG_LUONG WHERE TEN_NV LIKE  '%" + manv + "%'"; ;
            return db.Execute(sqlkt);
        }
    }
}
