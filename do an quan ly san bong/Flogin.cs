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
    public partial class flogin : Form
    {
        SqlConnection sqlcon;
       
        public flogin()
        {
            InitializeComponent();

        }
      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            
        }

        private void textBoxnhapmk_TextChanged(object sender, EventArgs e)
        {

        }
        private void xoatexbox()
        {
            textBoxtk.Focus();// tra tro chout ve vi tri nhap tk
            textBoxnhapmk.Text = "";
            textBoxtk.Text = "";
        }

        private void buttondangnhap_Click(object sender, EventArgs e)
        {
            đăng_nhập dn = new đăng_nhập();
             sqlcon = new SqlConnection(@"Data Source=LAPTOP-ESFJ9H96\MSSQLSERVER01;Initial Catalog=DO AN SAN BONG;Integrated Security=True");

           // sqlcon.Open();
            
            if (textBoxtk.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "thông báo");
                textBoxtk.Focus();
            }
            else if (textBoxnhapmk.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "thông báo");
                textBoxnhapmk.Focus();
            }
            else
            {
                dn.truyenthamsotk(textBoxtk.Text, textBoxnhapmk.Text);
                string sqldn = "select * from TAI_KHOAN where TEN_DANG_NHAP=N'" +dn.Taikhoan+ "'and MAT_KHAU = N'" + dn.Matkhau + "'";              
                SqlDataAdapter da = new SqlDataAdapter(sqldn, sqlcon);              
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count>0)
                {
                    ManHinhChinh f = new ManHinhChinh(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    f.Show();
                    this.Hide();
                    MessageBox.Show("Đăng nhập thành công, đây là màn hình chính", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Sai thông tin đăng nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    xoatexbox();
                }
                
            }
                 
        }

        private void flogin_Load(object sender, EventArgs e)
        {
            //this.KeyPreview = true;
        }

        private void checkhienthi_CheckedChanged(object sender, EventArgs e)
        {
            if(checkhienthi.Checked==true)
            {
                textBoxnhapmk.UseSystemPasswordChar = false;
            } 
            else
            {
                textBoxnhapmk.UseSystemPasswordChar = true;
            }
           
        }

        private void buttondoimk_Click(object sender, EventArgs e)
        {
           
           
        }

        private void flogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
               buttondangnhap_Click(null, null);
            }
        }
    }
}
