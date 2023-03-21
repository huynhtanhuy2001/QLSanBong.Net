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
    public partial class bangchamcong : Form
    {
        public bool themmoi = false;
        Classbangchamcong bcc = new Classbangchamcong();
        public bangchamcong()
        {
            InitializeComponent();
        }

        private void bangchamcong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet5.NHAN_VIEN' table. You can move, or remove it, as needed.
            this.nHAN_VIENTableAdapter.Fill(this.dataSet5.NHAN_VIEN);
            setButton(true);
            hienthidsTK();
            hienthidsbangluong();

        }
        void setButton(bool val)

        {
            buttonthem.Enabled = val;
            buttonxoa.Enabled = val;
            buttonSua.Enabled = val;
            buttonthoat.Enabled = val;
            buttonluu.Enabled = !val;
            buttonhuy.Enabled = !val;
        }
        private void hienthitheoten()// hien thi ds ssinh vien
        {
            DataTable dt = bcc.LayTENNV(combomanv.Text);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                texttennv.Text = dt.Rows[i][1].ToString();
            }
        }

        private void combomanv_SelectedIndexChanged(object sender, EventArgs e)
        {
            hienthitheoten();
        }
        private void hienthidsTK()// hien thi ds ssinh vien
        {
            DataTable dt = bcc.hienthidsbangchamcong();
            listViewNV.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = listViewNV.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
            }
        }
        private void hienthidsbangluong()// hien thi ds ssinh vien
        {
            DataTable dt = bcc.hienthidsluong();
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
        void dongtext(bool val)
        {
            combomanv.Enabled = !val;
            dateTimegiovào.Enabled = !val;
            dateTimengaylàm.Enabled = !val;
            datetimegiohet.Enabled = !val;
        }
        private void xoatext()
        {
            texttennv.Text = "";
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            if (texttennv.Text == "")
            {
                MessageBox.Show("Vui Lòng chọn click vào mã nv để thêm tên", "thông báo");
                combomanv.Focus();
            }
            else
            {
                themmoi = true;// thỏa mãn đk thi hàm them mơi sdc gán bằng true
                setButton(false);//nut bị dong dc mo lai
                dongtext(true);
                MessageBox.Show("-Chọn Lưu Để Thêm \n" +
                                   "-Hủy Thì giữ nguyên ", "Thông Báo");
            }
        }

        private void buttonluu_Click(object sender, EventArgs e)
        {
            //hh: mm:ss
            string giovao = dateTimegiovào.Value.ToString(" HH: mm:ss");
            string giohet = datetimegiohet.Value.ToString("HH: mm:ss");
            string ngaylam = dateTimengaylàm.Value.ToString("MM/dd/yyyy");
            if (themmoi)// đc click thì thực hiên vs dk true thì thực hiên cái đầu
            {

                bcc.Themphieudatsan(combomanv.SelectedValue.ToString(), texttennv.Text, ngaylam, giovao, giohet);
                MessageBox.Show("Thêm Thành Công", "Thông Báo");
                dongtext(false);


            }
            else //ngược tra ve gia tri false thi thuc hien
            {
                bcc.CapNhatNhanVien(listViewNV.SelectedItems[0].SubItems[0].Text, combomanv.SelectedValue.ToString(), texttennv.Text, ngaylam, giovao, giohet);
                MessageBox.Show("cập nhật Thành Công", "Thông Báo");
                dongtext(false);
            }
            xoatext();
            setButton(true);// dong thoi dong button luu va mo lại bunton mặc định
            hienthidsTK();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listViewNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewNV.SelectedIndices.Count > 0)
            {
                texttennv.Text = listViewNV.SelectedItems[0].SubItems[2].Text;
                dateTimengaylàm.Value = DateTime.Parse(listViewNV.SelectedItems[0].SubItems[3].Text);
                dateTimegiovào.Value = DateTime.Parse(listViewNV.SelectedItems[0].SubItems[4].Text);
                datetimegiohet.Value = DateTime.Parse(listViewNV.SelectedItems[0].SubItems[5].Text);
                combomanv.SelectedIndex = combomanv.FindString(listViewNV.SelectedItems[0].SubItems[1].Text);
            }

        }
        private void tinhtien()// hien thi ds ssinh vien
        {

            string giovao = dateTimegiovào.Value.ToString("HH: mm:ss ");
            string giohet = datetimegiohet.Value.ToString("HH: mm:ss ");
            string ngaylam = dateTimengaylàm.Value.ToString("MM/dd/yyyy");
            if (listViewNV.SelectedIndices.Count > 0)
            {
                if (texttennv.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn hàng cần tính lương", "Thông Báo");
                }
                else
                {
                    DataTable dt = bcc.CHAMCONG(listViewNV.SelectedItems[0].SubItems[0].Text);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        textBoxtonggiolam.Text = dt.Rows[i][0].ToString();
                        textBoxluong1ngay.Text = dt.Rows[i][1].ToString();
                    }
                    MessageBox.Show("Tính Lương thành công", "Thông Báo");
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Hàng cần tính lương", "Thông Báo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tinhtien();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (listViewNV.SelectedIndices.Count > 0)
            {
                themmoi = false;// thỏa mãn đk thi hàm them mơi sdc gán bằng true
                setButton(false);//nut bị dong dc mo lai
                dongtext(true);
                MessageBox.Show("-Chọn Lưu Để Thêm \n" +
                                   "-Hủy Thì giữ nguyên ", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Vui Lòng chọn hàng cần sửa", "Thông Báo");
            }
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {

            if (listViewNV.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa bằng cấp", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    bcc.XoaNhanVien(listViewNV.SelectedItems[0].SubItems[0].Text);
                    listViewNV.Items.RemoveAt(listViewNV.SelectedIndices[0]);
                    MessageBox.Show("Xóa Thành Công", "Thông Báo");
                    xoatext();
                }
                else
                {
                    MessageBox.Show("Bạn Vừa hủy chức năng", "Thông Báo");
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng chọn hàng cần xóa", "Thông báo");
            }

        }

        private void buttonhuy_Click(object sender, EventArgs e)
        {
            setButton(true);// click vô thì mở lại nút bị đóng
            MessageBox.Show("Bạn Vừa hủy bỏ tác vụ", "Thông Báo");
            dongtext(false);
            xoatext();
        }
        private void timkiemstt()// hien thi ds ssinh vien
        {
            if (textBoxtimstt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập stt bạn muốn tìm", "Thông Báo");
                textBoxtimstt.Focus();
            }
            else if (bcc.ktstt(textBoxtimstt.Text) == true)
            {
                DataTable dt = bcc.TIMKIEMSTT(textBoxtimstt.Text);
                listViewNV.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi = listViewNV.Items.Add(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());
                    lvi.SubItems.Add(dt.Rows[i][3].ToString());
                    lvi.SubItems.Add(dt.Rows[i][4].ToString());
                    lvi.SubItems.Add(dt.Rows[i][5].ToString());
                }
                textBoxtimstt.Text = "";
                MessageBox.Show("Đã tìm được thông tin bạn muốn", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Không có thông bạn muốn tìm", "Thông Báo");
                textBoxtimstt.Focus();
            }
        }
        private void timkiemmanv()// hien thi ds ssinh vien
        {
            if (textBoxtimmanv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nv bạn muốn tìm", "Thông Báo");
                textBoxtimmanv.Focus();
            }
            else if (bcc.ktmanv(textBoxtimmanv.Text) == true)
            {
                DataTable dt = bcc.timMANV(textBoxtimmanv.Text);
                listViewNV.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi = listViewNV.Items.Add(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());
                    lvi.SubItems.Add(dt.Rows[i][3].ToString());
                    lvi.SubItems.Add(dt.Rows[i][4].ToString());
                    lvi.SubItems.Add(dt.Rows[i][5].ToString());
                }
                textBoxtimmanv.Text = "";
                MessageBox.Show("Đã tìm được thông tin bạn muốn", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Không có thông bạn muốn tìm", "Thông Báo");
                textBoxtimmanv.Focus();
            }
        }
        private void timkietennv()// hien thi ds ssinh vien
        {
            if (textBoxtimtheoten.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên  bạn muốn tìm", "Thông Báo");
                textBoxtimtheoten.Focus();
            }
            else if (bcc.ktten(textBoxtimtheoten.Text) == true)
            {
                DataTable dt = bcc.timten(textBoxtimtheoten.Text);
                listViewNV.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi = listViewNV.Items.Add(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());
                    lvi.SubItems.Add(dt.Rows[i][3].ToString());
                    lvi.SubItems.Add(dt.Rows[i][4].ToString());
                    lvi.SubItems.Add(dt.Rows[i][5].ToString());
                }
                textBoxtimtheoten.Text = "";
                MessageBox.Show("Đã tìm được thông tin bạn muốn", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Không có thông bạn muốn tìm", "Thông Báo");
                textBoxtimtheoten.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timkiemstt();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timkiemmanv();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timkietennv();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hienthidsTK();
        }

        private void buttonlubangcong_Click(object sender, EventArgs e)
        {
            string giovao = dateTimegiovào.Value.ToString("HH: mm:ss ");
            string giohet = datetimegiohet.Value.ToString("HH: mm:ss ");
            string ngaylam = dateTimengaylàm.Value.ToString("MM/dd/yyyy");
            if (textBoxtonggiolam.Text == "" || textBoxluong1ngay.Text == "")
            {
                MessageBox.Show("Vui lòng tính lương cho nhân viên", "Thông Báo");
                button1.Focus();
            }
            else if (textBoxMAbangluong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã bảng lương", "Thông Báo");
                textBoxMAbangluong.Focus();
            }
            else if (bcc.ktmabnagLUONG(textBoxMAbangluong.Text) == true)
            {
                MessageBox.Show("Mã lương đã có vui lòng nhập lại", "Thông Báo");
                textBoxMAbangluong.Focus();
            }
            else if (ktdodaima(textBoxMAbangluong.Text) == true)
            {
                MessageBox.Show("vui lòng nhập mã lương không quá 20 ký tự", "Thông Báo");
                textBoxMAbangluong.Focus();
            }
            else
            {
                bcc.THEMLUONG(textBoxMAbangluong.Text, combomanv.SelectedValue.ToString(), texttennv.Text, ngaylam, giovao, giohet, textBoxtonggiolam.Text, textBoxluong1ngay.Text);
                MessageBox.Show("Thêm Thành Công", "Thông Báo");
                dongtext(false);
                textBoxMAbangluong.Text = "";
                textBoxluong1ngay.Text = "";
                textBoxtonggiolam.Text = "";
                xoatext();
                hienthidsbangluong();
            }
        }
        private bool ktdodaima(string mk)// kiem tra do dai cua mat khau
        {
            if (mk.Length > 20)
            {
                return true;
            }
            return false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (listViewbangcong.SelectedIndices.Count > 0)
            {
                if (textBoxMAbangluong.Text == "")
                {
                    MessageBox.Show("Vui Lòng chọn hàng cần xóa", "Thông báo");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa bằng cấp", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        bcc.Xoattbangluong(listViewbangcong.SelectedItems[0].SubItems[0].Text);
                        listViewbangcong.Items.RemoveAt(listViewbangcong.SelectedIndices[0]);
                        MessageBox.Show("Xóa Thành Công", "Thông Báo");
                        xoatext();
                        textBoxMAbangluong.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Bạn Vừa hủy chức năng", "Thông Báo");
                        textBoxMAbangluong.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng chọn hàng cần xóa", "Thông báo");
            }
        }

        private void listViewbangcong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewbangcong.SelectedIndices.Count > 0)
            {
                textBoxMAbangluong.Text = listViewbangcong.SelectedItems[0].SubItems[0].Text;
            }
        }
        private void timkiemmaBLuong()// hien thi ds ssinh vien
        {
            if (textBoxmabcBL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã bạn muốn tìm", "Thông Báo");
                textBoxmabcBL.Focus();
            }
            else if (bcc.ktmabangluongtimkiem(textBoxmabcBL.Text) == true)
            {
                DataTable dt = bcc.timmabangluong(textBoxmabcBL.Text);
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
                textBoxmabcBL.Text = "";
                MessageBox.Show("Đã tìm được thông tin bạn muốn", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Không có thông bạn muốn tìm", "Thông Báo");
                textBoxmabcBL.Focus();
            }
        }
        private void timkiemmaNVBANGLUONG()// hien thi ds ssinh vien
        {
            if (textBoxtimkiemtheomanvBL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã bạn muốn tìm", "Thông Báo");
                textBoxtimkiemtheomanvBL.Focus();
            }
            else if (bcc.ktmaMANVLUONG(textBoxtimkiemtheomanvBL.Text) == true)
            {
                DataTable dt = bcc.timmaNVLUONG(textBoxtimkiemtheomanvBL.Text);
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
                textBoxtimkiemtheomanvBL.Text = "";
                MessageBox.Show("Đã tìm được thông tin bạn muốn", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Không có thông bạn muốn tìm", "Thông Báo");
                textBoxtimkiemtheomanvBL.Focus();
            }
        }
        private void timkiemmaten_nvBANGLUONG()// hien thi ds ssinh vien
        {
            if (texttenBL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên bạn muốn tìm", "Thông Báo");
                texttenBL.Focus();
            }
            else if (bcc.ktmaTENNVLUONG(texttenBL.Text) == true)
            {
                DataTable dt = bcc.timmaTENLUONG(texttenBL.Text);
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
                texttenBL.Text = "";
                MessageBox.Show("Đã tìm được thông tin bạn muốn", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Không có thông bạn muốn tìm", "Thông Báo");
                texttenBL.Focus();
            }
        }

        private void buttontimmabc_Click(object sender, EventArgs e)
        {
            timkiemmaBLuong();
        }

        private void buttontimmanv_Click(object sender, EventArgs e)
        {
            timkiemmaNVBANGLUONG();
        }

        private void buttontimtennv_Click(object sender, EventArgs e)
        {
            timkiemmaten_nvBANGLUONG();
        }

        private void buttonhienthiBC_Click(object sender, EventArgs e)
        {
            hienthidsbangluong();
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bangchamcong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void buttonin_Click(object sender, EventArgs e)
        {
            Formreportbangchamcong f = new Formreportbangchamcong();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Formreportbangluong f = new Formreportbangluong();
            f.Show();
        }
    }
}
