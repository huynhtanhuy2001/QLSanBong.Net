using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an_quan_ly_san_bong
{
    class Database
    {
        SqlConnection sqlConn; //Doi tuong ket noi CSDL
        SqlDataAdapter da;//Bo dieu phoi du lieu
        DataSet ds; //Doi tuong chhua CSDL khi giao tiep
        SqlCommand sqlcmd;
        SqlDataReader reader;
        


        public Database()
        {
            string strcon = @"Data Source=LAPTOP-ESFJ9H96\MSSQLSERVER01;Initial Catalog=DO AN SAN BONG;Integrated Security=True";

            sqlConn = new SqlConnection(strcon);
        }
        //Phuong thuc de thuc hien cau lenh strSQL truy vân du lieu
        public DataTable Execute(string sqlhienthi)
        {

            da = new SqlDataAdapter(sqlhienthi, sqlConn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];

        }

        //Phuong thuc de thuc hien cac lenh Them, Xoa, Sua
        public void ExecuteNonQuery(string sqlchucnang)
        {
            sqlcmd = new SqlCommand(sqlchucnang, sqlConn);
            sqlConn.Open(); //Mo ket noi
            sqlcmd.ExecuteNonQuery();//Lenh hien lenh Them/Xoa/Sua
            sqlConn.Close();
        }
        public bool kiemtra(string manv)
        {

            sqlcmd = new SqlCommand(manv, sqlConn);
            sqlConn.Open();
            reader = sqlcmd.ExecuteReader();
            if (reader.Read() == true)// đọc mà trùng với cái nhập thig trả về true
            {
                sqlConn.Close();
                reader.Close();
                return true;
            }
            sqlConn.Close();
            reader.Close();
            return false;
        }
        
    }
}
