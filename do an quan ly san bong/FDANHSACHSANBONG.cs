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
    public partial class FDANHSACHSANBONG : Form
    {
        ClassDÁNHACHSANBONGCHONV sb = new ClassDÁNHACHSANBONGCHONV();
        public FDANHSACHSANBONG()
        {
            InitializeComponent();
        }

        private void FDANHSACHSANBONG_Load(object sender, EventArgs e)
        {
            hienthisan();
        }
        private void hienthisan()
        {
            DataTable dt = sb.LayDssan();
            listViewtk.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                listViewtk.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxtimma.Text == "")
            {
                MessageBox.Show("Vui lòng mã muốn tìm", "Thông Báo");
                textBoxtimma.Focus();

            }
            else if (sb.ktmasan(textBoxtimma.Text) == true)
            {
                DataTable dt = sb.timkiemmasan(textBoxtimma.Text);
                listViewtk.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi =
                    listViewtk.Items.Add(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());
                    
                }
                MessageBox.Show("Đã tìm đc thông tin muốn tìm", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Không có mã  muốn tìm", "Thông Báo");
                textBoxtimma.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxtimgia.Text == "")
            {
                MessageBox.Show("Vui lòng giá sân muốn tìm", "Thông Báo");
                textBoxtimgia.Focus();

            }
            else if (sb.ktmagialoai(textBoxtimgia.Text) == true)
            {
                DataTable dt = sb.timkiemgiâsan(textBoxtimgia.Text);
                listViewtk.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi =
                    listViewtk.Items.Add(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());

                }
                MessageBox.Show("Đã tìm đc thông tin muốn tìm", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Không có giá sân muốn tìm", "Thông Báo");
                textBoxtimgia.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxtimten.Text == "")
            {
                MessageBox.Show("Vui lòng tên sân muốn tìm", "Thông Báo");
                textBoxtimten.Focus();

            }
            else if (sb.ktténan(textBoxtimten.Text) == true)
            {
                DataTable dt = sb.timkiemténsan(textBoxtimten.Text);
                listViewtk.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi =
                    listViewtk.Items.Add(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());

                }
                MessageBox.Show("Đã tìm đc thông tin muốn tìm", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Không có tên sân muốn tìm", "Thông Báo");
                textBoxtimten.Focus();
            }
        }

        private void buttonthoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FDANHSACHSANBONG_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hienthisan();
        }
    }
}
