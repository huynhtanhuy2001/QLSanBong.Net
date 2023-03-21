using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace do_an_quan_ly_san_bong
{
    public partial class Tìm_Kiếm : Form
    {
        SqlConnection sqlcon;
        SqlCommand sqlcmd;
        SqlDataReader reader;



        public Tìm_Kiếm()
        {
            InitializeComponent();
        }

        private void Tìm_Kiếm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            string strcon = @"Data Source=LAPTOP-ESFJ9H96\MSSQLSERVER01;Initial Catalog=DO AN SAN BONG;Integrated Security=True";
            sqlcon = new SqlConnection(strcon);
            sqlcon.Open();
            hienthidsNV();
           

        }
        private void hienthidsNV()
        {

            string sqlhienthi = "SELECT MA_NV,TEN_NV,TEN_CHUC_VU,SDT,DIA_CHI,NGAY_SINH,GIOI_TINH FROM NHAN_VIEN N, CHUC_VU C WHERE N.MA_CHUC_VU=C.MA_CHUC_VU  ";
            SqlDataAdapter da = new SqlDataAdapter(sqlhienthi, sqlcon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void timkiemten()
        {
            string sqlhienthi= "";
            if (textBoxten.Text == "")// dieu kien tai khoan khong duoc de trong
            {
                MessageBox.Show("Vui lòng nhập nhập thông tin cần tìm kiếm", "Thông Báo");
                textBoxten.Focus();
            }
            else
            {

                if (ktten(textBoxten.Text) == true)
                {
                    sqlhienthi = " select MA_NV,TEN_NV,TEN_CHUC_VU,SDT,DIA_CHI,NGAY_SINH,GIOI_TINH from  NHAN_VIEN N, CHUC_VU C where (N.MA_CHUC_VU=C.MA_CHUC_VU) AND (TEN_NV like N'%" + textBoxten.Text + "%') ";
                    SqlDataAdapter da = new SqlDataAdapter(sqlhienthi, sqlcon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;                   
                    MessageBox.Show("đã tìm kiếm được thông tin bạn muốn", "Thông Báo");
                    hamxoatextboxytkten();
                }
                else
                {
                    MessageBox.Show("Không có thông tin mà bạn muốn tìm ", "Thông Báo");
                    textBoxten.Focus();

                }
                reader.Close();


            }
        }
        private void timkiemma()
        {
            string sqltk = "";
            if (textBoxmanv.Text == "")// dieu kien tai khoan khong duoc de trong
            {
                MessageBox.Show("Vui lòng nhập nhập thông tin cần tìm kiếm", "Thông Báo");
                textBoxmanv.Focus();
            }
            else
            {
                if (ktkieuintma(textBoxmanv.Text))
                {

                    if (ktma(textBoxmanv.Text) == true)
                    {
                        sqltk = " select MA_NV,TEN_NV,TEN_CHUC_VU,SDT,DIA_CHI,NGAY_SINH,GIOI_TINH from  NHAN_VIEN N, CHUC_VU C where (N.MA_CHUC_VU=C.MA_CHUC_VU) AND (MA_NV like '%" + textBoxmanv.Text + "%') ";
                        SqlDataAdapter da = new SqlDataAdapter(sqltk, sqlcon);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;                       
                        MessageBox.Show("đã tìm kiếm được thông tin bạn muốn", "Thông Báo");
                        hamxoatextbox();
                    }
                    else
                    {
                        MessageBox.Show("Không có thông tin mà bạn muốn tìm ", "Thông Báo");
                        textBoxmanv.Focus();

                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Đảm bảo rằng bạn không nhập chữ cái, ký tự cho Mã Sinh Viên và không nhập số quá lớn ", "Thông Báo");
                    textBoxmanv.Focus();
                }

            }
        }
        private void timsdt()
        {
            string sqltk = "";
            if (textSDT.Text == "")// dieu kien tai khoan khong duoc de trong
            {
                MessageBox.Show("Vui lòng nhập nhập thông tin cần tìm kiếm", "Thông Báo");
                textSDT.Focus();
            }
            else
            {
                if (ktkieusdt(textSDT.Text))
                {

                    if (ktSDT(textSDT.Text) == true)
                    {
                        sqltk = " select MA_NV,TEN_NV,TEN_CHUC_VU,SDT,DIA_CHI,NGAY_SINH,GIOI_TINH from  NHAN_VIEN N, CHUC_VU C where (N.MA_CHUC_VU=C.MA_CHUC_VU) AND (SDT like '%" + textSDT.Text + "%') ";
                        SqlDataAdapter da = new SqlDataAdapter(sqltk, sqlcon);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        MessageBox.Show("đã tìm kiếm được thông tin bạn muốn", "Thông Báo");
                        hamxoatextboxsdt();
                    }
                    else
                    {
                        MessageBox.Show("Không có thông tin mà bạn muốn tìm ", "Thông Báo");
                        textSDT.Focus();

                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số ", "Thông Báo");
                    textSDT.Focus();
                }

            }
        }
        
        private bool ktkieuintma(string manv)
        {

            int a;
            if (int.TryParse(manv, out a))
            {
                return true;
            }
            return false;
        }
        private bool ktkieusdt(string manv)
        {

            double a;
            if (double.TryParse(manv, out a))
            {
                return true;
            }
            return false;
        }
        private bool ktma(string manv)// kiem tra ma xem co trung
        {
            string sqlkt = "select MA_NV FROM NHAN_VIEN WHERE MA_NV like '%" + manv + "%'";
            sqlcmd = new SqlCommand(sqlkt, sqlcon);
            sqlcmd.ExecuteNonQuery();
            reader = sqlcmd.ExecuteReader();
            if (reader.Read() == true)// đọc mà trùng với cái nhập thig trả về true
            {
                reader.Close();
                return true;

            }
            reader.Close();
            return false;
        }
        private bool ktten(string manv)// kiem tra ma xem co trung
        {
            string sqlkt = "select TEN_NV FROM NHAN_VIEN WHERE TEN_NV like '%" + manv + "%'";
            sqlcmd = new SqlCommand(sqlkt, sqlcon);
            sqlcmd.ExecuteNonQuery();
            reader = sqlcmd.ExecuteReader();
            if (reader.Read() == true)// đọc mà trùng với cái nhập thig trả về true
            {
                reader.Close();
                return true;

            }
            reader.Close();
            return false;
        }
        private bool ktSDT(string manv)// kiem tra ma xem co trung
        {
            string sqlkt = "select  SDT FROM NHAN_VIEN WHERE SDT like '%" + manv + "%'";
            sqlcmd = new SqlCommand(sqlkt, sqlcon);
            sqlcmd.ExecuteNonQuery();
            reader = sqlcmd.ExecuteReader();
            if (reader.Read() == true)// đọc mà trùng với cái nhập thig trả về true
            {
                reader.Close();
                return true;

            }
            reader.Close();
            return false;
        }

        private void buttontimkiem_Click(object sender, EventArgs e)
        {
            timkiemma();
        }
        private void hamxoatextbox()
        {
            textBoxmanv.Focus();
            textBoxmanv.Text = "";
            textBoxten.Text = "";
            textSDT.Text = "";
        }
        private void hamxoatextboxsdt()
        {
            textSDT.Focus();
            textBoxmanv.Text = "";
            textBoxten.Text = "";
            textSDT.Text = "";
        }
        private void hamxoatextboxytkten()
        {
            textBoxten.Focus();
            textBoxmanv.Text = "";
            textBoxten.Text = "";
            textSDT.Text = "";
        }

        private void btnhienthilai_Click(object sender, EventArgs e)
        {
            hienthidsNV();
            MessageBox.Show("Đã quay về danh sách bạn lúc chưa tìm kiếm");
            textBoxmanv.Focus();
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tìm_Kiếm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                sqlcon.Close();
               
            }

        }

        private void buttontheoten_Click(object sender, EventArgs e)
        {
            timkiemten();
        }

        private void buttontimkiemtheosdt_Click(object sender, EventArgs e)
        {
            timsdt();
        }

        private void Tìm_Kiếm_KeyUp(object sender, KeyEventArgs e)
        {
            
                if(e.KeyCode.Equals(Keys.Enter))
                {
                    btnhienthilai_Click(null, null);
                }    
              
        }
    }
}
