using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_an_quan_ly_san_bong
{
    public partial class Ftinhluongtheongaythangtuychon : Form
    {
        public Ftinhluongtheongaythangtuychon()
        {
            InitializeComponent();
        }
        ClasstongLUONGTHEONGAYTHANGMANV luong = new ClasstongLUONGTHEONGAYTHANGMANV();
        private void Ftinhluongtheongaythangtuychon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetbangluong.BANG_LUONG' table. You can move, or remove it, as needed.
            this.bANG_LUONGTableAdapter.Fill(this.dataSetbangluong.BANG_LUONG);
            hienthidsbangluong();



        }
        private void hienthidsbangluong()// hien thi ds ssinh vien
        {
            DataTable dt = luong.hienthidsluong();
            listViewbangcong.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = listViewbangcong.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][7].ToString());
            }
        }

        private void buttontongdoanhthu_Click(object sender, EventArgs e)
        {
            if (textmanv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên", "Thông Báo");
                textmanv.Focus();
            }
            else if(luong.ktma(textmanv.Text)==true)
            {
                DataTable dt = luong.tongtien(comboBoxngaybatdau.SelectedValue.ToString(), comboBoxngayketthuc.SelectedValue.ToString(), textmanv.Text);
                ////.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    textBoxTổngtiền.Text = dt.Rows[i][0].ToString();
                }
                MessageBox.Show("Tính tiền thành công", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Không có mã nv cần tính ", "Thông Báo");
                textmanv.Focus();
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ngaybatdau = dateTimengaybatdau.Value.ToString("MM/dd/yyyy");//form mat đúng kiểu date sql
            string ngayketthuc = dateTimengayketthuc.Value.ToString("MM/dd/yyyy");
            if (luong.ktngay(ngaybatdau, ngayketthuc) == true)
            {
                DataTable dt = luong.timkiemngaythang(ngaybatdau, ngayketthuc);
                listViewbangcong.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi = listViewbangcong.Items.Add(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());
                    lvi.SubItems.Add(dt.Rows[i][3].ToString());
                    lvi.SubItems.Add(dt.Rows[i][4].ToString());
                    lvi.SubItems.Add(dt.Rows[i][5].ToString());
                    lvi.SubItems.Add(dt.Rows[i][6].ToString());
                    lvi.SubItems.Add(dt.Rows[i][7].ToString());
                }
                MessageBox.Show("Tìm thành công", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Không có ngày cần tìm kiếm", "Thông Báo");
            }    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxtimkiemmanv.Text == "")
            {
                MessageBox.Show("Vui lòng mã muốn tìm", "Thông Báo");
                textBoxtimkiemmanv.Focus();

            }
            else if (luong.ktmanvtimkiem(textBoxtimkiemmanv.Text) == true)
            {
                DataTable dt = luong.timkiemmã(textBoxtimkiemmanv.Text);
                listViewbangcong.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi = listViewbangcong.Items.Add(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());
                    lvi.SubItems.Add(dt.Rows[i][3].ToString());
                    lvi.SubItems.Add(dt.Rows[i][4].ToString());
                    lvi.SubItems.Add(dt.Rows[i][5].ToString());
                    lvi.SubItems.Add(dt.Rows[i][6].ToString());
                    lvi.SubItems.Add(dt.Rows[i][7].ToString());
                }
                MessageBox.Show("Tìm thành công", "Thông Báo");
                textBoxtimkiemmanv.Text = "";
            }
            else
            {
                MessageBox.Show("Không có mã  muốn tìm", "Thông Báo");
                textBoxtimkiemmanv.Focus();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hienthidsbangluong();
        }

        private void Ftinhluongtheongaythangtuychon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
