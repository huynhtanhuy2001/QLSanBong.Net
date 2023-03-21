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
    public partial class Fkhach : Form
    {
        Classtt_Khách kh = new Classtt_Khách();
        public Fkhach()
        {
            InitializeComponent();
        }
        public bool themmoi = false;
        private void Fkhach_Load(object sender, EventArgs e)
        {
            setButton(true);
            hienthidsCV();
        }
        void setButton(bool val)
        {
            buttonthem.Enabled = val;//true thi mo
            buttonxoa.Enabled = val;//true thi mo
            buttonsua.Enabled = val;//true thi mo
            buttonthoat.Enabled = val;//true thi mo
            buttonluu.Enabled = !val;//true thi dong
            buttonhuy.Enabled = !val;//true thi dong
        }

        public void hienthidsCV()
        {
            DataTable dt = kh.LayDSNhanvien();
            listViewNV.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                listViewNV.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());

            }
        }
        private bool ktdodaisdt(string sdt)// kiem tra do dai cua =ten dang nhap
        {
            if (sdt.Length > 11)
            {
                return true;
            }
            return false;
        }
        private bool ktkieusdt(string sdt)
        {

            double a;
            if (double.TryParse(sdt, out a))
            {
                return true;
            }
            return false;
        }
        private bool ktkieuintma(string sdt)
        {

            int a;
            if (Int32.TryParse(sdt, out a))
            {
                return true;
            }
            return false;
        }

        private void listViewNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewNV.SelectedItems.Count > 0)//kiểm tra xem có ai nhập ko nếu có thì làm cái trong if
            {
                textmakh.ReadOnly = true;
                textmakh.Text = listViewNV.SelectedItems[0].SubItems[0].Text;
                textsdt.Text = listViewNV.SelectedItems[0].SubItems[1].Text;
                texttenkh.Text = listViewNV.SelectedItems[0].SubItems[2].Text;
                textdiachi.Text = listViewNV.SelectedItems[0].SubItems[3].Text;

            }
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            textmakh.ReadOnly = false;
            if (textmakh.Text == "")
            {
                MessageBox.Show("Chưa Nhập mã Khách", "Thông báo");
                textmakh.ReadOnly = false;
                textmakh.Focus();
            }
            else if (texttenkh.Text == "")
            {
                MessageBox.Show("Chưa Nhập tên Khách ", "Thông báo");
                texttenkh.Focus();
            }
            else if (textsdt.Text == "")
            {
                MessageBox.Show("Chưa Nhập sdt  Khách ", "Thông báo");
                textsdt.Focus();
            }
            else
            {
                if (ktkieuintma(textmakh.Text) == true)
                {
                    if (kh.ktma(textmakh.Text) == true)
                    {
                        MessageBox.Show("Nhập trùng mã vui lòng nhập lại", "Thông báo");
                        textmakh.ReadOnly = false;
                        textmakh.Focus();
                    }
                    else
                    {
                        if (ktkieusdt(textsdt.Text) == true)
                        {
                            if (ktdodaisdt(textsdt.Text) == true)
                            {
                                MessageBox.Show("không nhập quá 11 số, cho số điện thoại", "thông báo");
                                textsdt.Focus();
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
                        else
                        {
                            MessageBox.Show("Vui lòng không nhập chữ cái cho sdt", "Thông báo");
                            textmakh.ReadOnly = false;
                            textsdt.Focus();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng không nhập mã quá lớn và nhập số cho mã chức vụ", "Thông báo");
                    textmakh.Focus();
                }
            }
        }
        private void xoatextbox()
        {
            textmakh.Focus();
            textmakh.Text = "";
            textsdt.Text = "";
            textdiachi.Text = "";
            texttenkh.Text = "";

        }// hàm xóa text box
        void dongtext(bool val)
        {
            textmakh.ReadOnly = val;
            texttenkh.ReadOnly = val;
            textdiachi.ReadOnly = val;
            textsdt.ReadOnly = val;
        }

        private void buttonluu_Click(object sender, EventArgs e)
        {
            if (themmoi)// đc click thì thực hiên vs dk true thì thực hiên cái đầu
            {
                kh.ThemNhanVien(textmakh.Text, textsdt.Text, texttenkh.Text, textdiachi.Text);
                MessageBox.Show("Thêm Thành Công", "Thông Báo");

                xoatextbox();
                dongtext(false);

            }
            else //ngược tra ve gia tri false thi thuc hien
            {
                kh.CapNhatNhanVien(listViewNV.SelectedItems[0].SubItems[0].Text, textsdt.Text, texttenkh.Text, textdiachi.Text);
                MessageBox.Show("cập nhật Thành Công", "Thông Báo");
                xoatextbox();
                dongtext(false);
            }
            setButton(true);// dong thoi dong button luu va mo lại bunton mặc định
            hienthidsCV();
        }

        private void buttonsua_Click(object sender, EventArgs e)
        {
            if (listViewNV.SelectedItems.Count > 0)
            {
                if (textmakh.Text == "" && texttenkh.Text == "")
                {
                    MessageBox.Show("Vui Lòng Chọn hàng cần sửa", "Thông Báo");
                }
                else
                {
                    if (ktkieusdt(textsdt.Text) == true)
                    {
                        if (ktdodaisdt(textsdt.Text) == true)
                        {
                            MessageBox.Show("không nhập qua 11 số, cho số điện thoại", "thông báo");
                            textsdt.Focus();
                        }
                        else
                        {
                            themmoi = false;//thoa man dk thi ham sua dc gan bang false
                            setButton(false);//nut bị dong dc mo lai
                            dongtext(true);
                            MessageBox.Show("-Chọn Lưu Để Sửa \n" +
                                              "-Hủy Thì giữ nguyên ", "Thông Báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng không nhập chữ cái cho sdt", "Thông báo");
                        textsdt.Focus();
                    }

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần sửa", "thông báo");
            }
        }

        private void buttonhuy_Click(object sender, EventArgs e)
        {
            setButton(true); ;// dong thoi dong button luu va mo lại bunton mặc định
            MessageBox.Show("Bạn Vừa hủy bỏ tác vụ", "Thông Báo");
            xoatextbox();
            dongtext(false);
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            if (listViewNV.SelectedItems.Count > 0)
            {
                if (textmakh.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn ô cần xóa", "Thông Báo");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa bằng cấp", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        kh.xoattphieuguixe(textmakh.Text);
                        kh.xoattphieudatsan(textmakh.Text);
                        kh.XoaNhanVien(listViewNV.SelectedItems[0].SubItems[0].Text);
                        listViewNV.Items.RemoveAt(listViewNV.SelectedIndices[0]);
                        MessageBox.Show("Xóa Thành Công", "thông báo");
                        xoatextbox();
                        textmakh.ReadOnly = false;
                    }
                    else
                    {
                        MessageBox.Show("Bạn Vừa Hủy Chức Năng", "thông báo");
                        xoatextbox();
                        textmakh.ReadOnly = false;
                    }
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn ô cần xóa", "Thông Báo");
            }
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fkhach_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttontimkiemtheoteen_Click(object sender, EventArgs e)
        {
            if (textBoxtimten.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên bạn muốn tìm", "Thông Báo");
                textBoxtimten.Focus();
            }
            else if (kh.ktten(textBoxtimten.Text) == true)
            {
                DataTable dt = kh.timkiemten(textBoxtimten.Text);
                listViewNV.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi =
                    listViewNV.Items.Add(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());
                    lvi.SubItems.Add(dt.Rows[i][3].ToString());
                }
                MessageBox.Show("Đã tìm được thông tin bạn muốn", "Thông Báo");
                textBoxtimten.Text = "";
            }
            else
            {
                MessageBox.Show("Không có Thông tin tìm kiếm bạn muốn", "Thông Báo");
                textBoxtimten.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxtimSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập SDT bạn muốn tìm", "Thông Báo");
                textBoxtimSDT.Focus();
            }
            else if (kh.ktsdt(textBoxtimSDT.Text) == true)
            {
                DataTable dt = kh.timkiemSDT(textBoxtimSDT.Text);
                listViewNV.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi =
                    listViewNV.Items.Add(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());
                    lvi.SubItems.Add(dt.Rows[i][3].ToString());
                }
                MessageBox.Show("Đã tìm được thông tin bạn muốn", "Thông Báo");
                textBoxtimSDT.Text = "";
            }
            else
            {
                MessageBox.Show("Không có Thông tin tìm kiếm bạn muốn", "Thông Báo");
                textBoxtimSDT.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hienthidsCV();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
