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
    public partial class Fquenmk : Form
    {
        SqlConnection sqlcon;
        SqlCommand sqlcmd;
        SqlDataReader reader;
        public Fquenmk()
        {
            InitializeComponent();
        }

        private void Fquenmk_Load(object sender, EventArgs e)
        {
            string strcon = @"Data Source=LAPTOP-ESFJ9H96\MSSQLSERVER01;Initial Catalog=DO AN SAN BONG;Integrated Security=True";
            sqlcon = new SqlConnection(strcon);
            sqlcon.Open();
        }
        private void them()
        {
            string sqlsua = "";
            if (texttendn.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Tên Đăng Nhập Của Bạn", "Thông Báo");
                texttendn.Focus();
            }
            else if (textmk.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Mật Khẩu của bạn ", "Thông Báo");
                textmk.Focus();
            }
            else if (textMKmoi.Text == "")
            {
                MessageBox.Show("Vui Lòng  Mật Khẩu Mới", "Thông Báo");
                textMKmoi.Focus();
            }
            else if (textnhaplai.Text == "")
            {
                MessageBox.Show("Nhập Lại Mật Khẩu Bạn Vừa Nhập", "Thông Báo");
                textnhaplai.Focus();
            }
            else
            {
                if (ktma(texttendn.Text) == true)
                {
                    if (ktmk(textmk.Text) == true)
                    {
                        if (ktdodaimk(textMKmoi.Text) == false)
                        {
                            if (textMKmoi.Text == textnhaplai.Text)
                            {
                                DialogResult dr = MessageBox.Show("Bạn có chắc muốn đổi mật khẩu không ? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (dr == DialogResult.Yes)
                                {
                                    sqlsua = "UPDATE TAI_KHOAN SET MAT_KHAU = N'" + textMKmoi.Text + "' WHERE TEN_DANG_NHAP = N'" + texttendn.Text + "'";
                                    sqlcmd = new SqlCommand(sqlsua, sqlcon);
                                    sqlcmd.ExecuteNonQuery();
                                    MessageBox.Show("Đổi Mật Khẩu Thành Công", "Thông Báo");
                                    xoatextbox();
                                }
                                else
                                {
                                    xoatextbox();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Mật Khẩu Nhập Lại Không Trùng Với Mật Khẩu Mới ", "Thông Báo");
                                textnhaplai.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật Khẩu Mới Không được quá 15 ký tự", "Thông Báo");
                            textMKmoi.Focus();
                        }    

                    }
                    else
                    {
                        MessageBox.Show("Mật Khẩu Sai", "Thông Báo");
                        textmk.Focus();
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Thông Tin Tài Khoản Của Bạn Không tồn Tại", "Thông Báo");
                    texttendn.Focus();
                }
                reader.Close();
            }
        }
        private bool ktma(string tendn)// kiem tra ma xem co trung
        {
            string sqlkt = "select TEN_DANG_NHAP FROM TAI_KHOAN WHERE TEN_DANG_NHAP= N'" + tendn + "'";
            sqlcmd = new SqlCommand(sqlkt, sqlcon);
            reader = sqlcmd.ExecuteReader();
            if (reader.Read() == true)// đọc mà trùng với cái nhập thig trả về true
            {
                reader.Close();
                return true;

            }
            reader.Close();
            return false;
        }
        private bool ktmk(string mk)// kiem tra ma xem co trung
        {
            string sqlkt = "select MAT_KHAU FROM TAI_KHOAN WHERE MAT_KHAU= N'" + mk + "'";
            sqlcmd = new SqlCommand(sqlkt, sqlcon);
            reader = sqlcmd.ExecuteReader();
            if (reader.Read() == true)// đọc mà trùng với cái nhập thig trả về true
            {
                reader.Close();
                return true;

            }
            reader.Close();
            return false;
        }
        private bool ktdodaimk(string mk)// kiem tra do dai cua mat khau
        {
            if (mk.Length > 15)
            {
                return true;
            }
            return false;
        }
        private void buttondoimk_Click(object sender, EventArgs e)
        {
            them();
        }
        private void xoatextbox()
        {
            texttendn.Focus();
            texttendn.Text = "";
            textmk.Text = "";
            textMKmoi.Text = "";
            textnhaplai.Text = "";
            checkmkmoi.Checked = false;
            checknhaplai.Checked = false;
            checkmk.Checked = false;
        }

        private void checkmk_CheckedChanged(object sender, EventArgs e)
        {
            if (checkmk.Checked == true)
            {
                textmk.UseSystemPasswordChar = false;
            }
            else
            {
                textmk.UseSystemPasswordChar = true;
            }
        }


        private void checkmkmoi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkmkmoi.Checked == true)
            {
                textMKmoi.UseSystemPasswordChar = false;
            }
            else
            {
                textMKmoi.UseSystemPasswordChar = true;
            }
        }

        private void checknhaplai_CheckedChanged(object sender, EventArgs e)
        {
            if (checknhaplai.Checked == true)
            {
                textnhaplai.UseSystemPasswordChar = false;
            }
            else
            {
                textnhaplai.UseSystemPasswordChar = true;
            }
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Fquenmk_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
