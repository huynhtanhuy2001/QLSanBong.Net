using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an_quan_ly_san_bong
{
    class DS_NV
    {
        Database db;

        private string manv;
        private string tennv, chucvu, sdt, diachi, ngaysinh;
        public DS_NV()
        {
            db = new Database();
        }

        public DS_NV(string manv, string tennv, string chucvu, string sdt, string diachi, string ngaysinh)
        {
            this.Manv = manv;
            this.Tennv = tennv;
            this.Chucvu = chucvu;
            this.Sdt = sdt;
            this.Diachi = diachi;
            this.Ngaysinh = ngaysinh;



        }

        public string Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public void hamttruyengiatri(string manV, string tennV, string chucvU, string sdT, string diachI, string ngaysinH)
        {
            Manv = manV;
            Tennv = tennV;
            Chucvu = chucvU;
            Sdt = sdT;
            Diachi = diachI;
            Ngaysinh = ngaysinH;
        }
        public bool ktma(string manv)
        {
            string sqlkt = "select MA_NV FROM NHAN_VIEN WHERE MA_NV= '" + manv + "'"; ;
            return db.kiemtra(sqlkt);
        }
        public bool ktSDT(string manv)
        {
            string sqlkt = "select SDT FROM NHAN_VIEN WHERE SDT LIKE  '%" + manv + "%'"; ;
            return db.kiemtra(sqlkt);
        }
        public bool ktMATIMKIEM(string manv)
        {
            string sqlkt = "select MA_NV FROM NHAN_VIEN WHERE MA_NV LIKE  '%" + manv + "%'"; ;
            return db.kiemtra(sqlkt);
        }

        public DataTable LayDSNhanvien()
        {
            string strSQL = "SELECT MA_NV,TEN_NV,TEN_CHUC_VU,SDT,DIA_CHI,convert(nvarchar(30),NGAY_SINH,110),GIOI_TINH FROM NHAN_VIEN N, CHUC_VU C WHERE N.MA_CHUC_VU=C.MA_CHUC_VU  ";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public DataTable soluongnv()
        {
            string strSQL = "SELECT count(*)from  NHAN_VIEN  ";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public DataTable laychucvu()
        {
          string strSQL = " select MA_CHUC_VU, TEN_CHUC_VU FROM CHUC_VU ";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable timkiemten(string ten)
        {
            string strSQL = "SELECT MA_NV,TEN_NV,TEN_CHUC_VU,SDT,DIA_CHI,convert(nvarchar(30),NGAY_SINH,110),GIOI_TINH FROM NHAN_VIEN N, CHUC_VU C WHERE (N.MA_CHUC_VU=C.MA_CHUC_VU)and(TEN_NV LIKE N'%"+ten+"%')  "; ;
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public DataTable timkiemSDT(string ten)
        {
            string strSQL = "SELECT MA_NV,TEN_NV,TEN_CHUC_VU,SDT,DIA_CHI,convert(nvarchar(30),NGAY_SINH,110),GIOI_TINH FROM NHAN_VIEN N, CHUC_VU C WHERE (N.MA_CHUC_VU=C.MA_CHUC_VU)and(SDT LIKE N'%" + ten + "%')  "; ;
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public DataTable timkiemmanv(string ten)
        {
            string strSQL = "SELECT MA_NV,TEN_NV,TEN_CHUC_VU,SDT,DIA_CHI,convert(nvarchar(30),NGAY_SINH,110),GIOI_TINH FROM NHAN_VIEN N, CHUC_VU C WHERE (N.MA_CHUC_VU=C.MA_CHUC_VU)and(MA_NV LIKE '%" + ten + "%')  "; ;
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public bool ktten(string manv)
        {
            string sqlkt = "select TEN_NV FROM NHAN_VIEN WHERE TEN_NV LIKE N'%" + manv + "%'"; ;
            return db.kiemtra(sqlkt);
        }


        public void XoaNhanVien(string index_nv)
        {
           string  sql = "DELETE FROM  NHAN_VIEN WHERE MA_NV= '" + index_nv + "'";
            db.ExecuteNonQuery(sql);
        }
        public void Xoatk(string index_nv)
        {
            string sql = "DELETE FROM  TAI_KHOAN WHERE MA_NV= '" + index_nv + "'";
            db.ExecuteNonQuery(sql);
        }
        public void Xoapds(string index_nv)
        {
            string sql = "DELETE FROM  PHIEU_DAT_SAN WHERE MA_NV= '" + index_nv + "'";
            db.ExecuteNonQuery(sql);
        }
        public void XoapGX(string index_nv)
        {
            string sql = "DELETE FROM  PHIEU_GUI_XE WHERE MA_NV= '" + index_nv + "'";
            db.ExecuteNonQuery(sql);
        }
        public void Xoapbcc(string index_nv)
        {
            string sql = "DELETE FROM  BAN_CHAM_CONGG WHERE MA_NV= '" + index_nv + "'";
            db.ExecuteNonQuery(sql);
        }

        //Thêm 1 nhân viên mới
        public void ThemNhanVien(string manv, string tennv, string chucvu,string Sdt,string diachi,string ngaysinh,string gioitinh)
        {
           string  sql = " insert into NHAN_VIEN VALUES(" + manv + ",N'" + tennv + "',N'" + chucvu + "',N'" + Sdt + "',N'" + diachi + "','" + ngaysinh + "',N'"+gioitinh+"')";
            db.ExecuteNonQuery(sql);
        }
        
        public void CapNhatNhanVien(string index_manv, string Tennv,  string Chucvu, string Sdt, string Diachi,string Ngaysinh,string gt)
        {
           string str= "UPDATE NHAN_VIEN SET TEN_NV =N'" + Tennv + "', MA_CHUC_VU = N'" + Chucvu + "',SDT='" + Sdt + "',DIA_CHI=N'" + Diachi + "',NGAY_SINH='" + Ngaysinh + "',GIOI_TINH=N'"+gt+"' WHERE MA_NV = N'" + index_manv + "'";
            db.ExecuteNonQuery(str);
        }
       

    }
}
