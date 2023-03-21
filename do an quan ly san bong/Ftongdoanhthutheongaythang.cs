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
    public partial class Ftongdoanhthutheongaythang : Form
    {
        Classtomgdoanhthutheongaythang dtn = new Classtomgdoanhthutheongaythang();
        public Ftongdoanhthutheongaythang()
        {
            InitializeComponent();
        }

        private void listViewhd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Ftongdoanhthutheongaythang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dO_AN_SAN_BONGDataSet.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.dO_AN_SAN_BONGDataSet.HOADON);
            hienthidsCV();

        }
        public void hienthidsCV()
        {
            DataTable dt =dtn.hienthidsbangchamcong();
            listViewhd.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                listViewhd.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][7].ToString());
                lvi.SubItems.Add(dt.Rows[i][8].ToString());                
            }
        }

        private void buttontongdoanhthu_Click(object sender, EventArgs e)
        {

            DataTable dt = dtn.tongtien(comboBoxngaybatdau.SelectedValue.ToString(), comboBoxngayketthuc.SelectedValue.ToString());
            ////.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {              
              textBoxTổngtiền.Text= dt.Rows[i][0].ToString();                
            }
            MessageBox.Show("Tính tiền thành công","Thông Báo");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxTổngtiền.Text = "";
        }

        private void Ftongdoanhthutheongaythang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
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
            if (dtn.ktngay(ngaybatdau, ngayketthuc) == true)
            {
                DataTable dt = dtn.timkiemngaythang(ngaybatdau, ngayketthuc);
                listViewhd.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi =
                    listViewhd.Items.Add(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());
                    lvi.SubItems.Add(dt.Rows[i][3].ToString());
                    lvi.SubItems.Add(dt.Rows[i][4].ToString());
                    lvi.SubItems.Add(dt.Rows[i][5].ToString());
                    lvi.SubItems.Add(dt.Rows[i][6].ToString());
                    lvi.SubItems.Add(dt.Rows[i][7].ToString());
                    lvi.SubItems.Add(dt.Rows[i][8].ToString());
                }
                MessageBox.Show("Tìm thành công", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Không có ngày cần tìm kiếm", "Thông Báo");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hienthidsCV();
        }
    }
}

