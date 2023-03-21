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
    public partial class FchucVuNV : Form
    {

        public bool themmoi = false;
        calssDanhSachChucVu cv = new calssDanhSachChucVu();
        public FchucVuNV()
        {
            InitializeComponent();
        }

        private void FchucVuNV_Load(object sender, EventArgs e)
        {
            setButton(true);
            hienthidsCV();
        }
        public void hienthidsCV()
        {
            DataTable dt = cv.LayDSNhanvien();
            listViewtk.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                listViewtk.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());

            }
        }
        void dongtext(bool val)
        {
            textmaCV.ReadOnly = val;
            texttenCV.ReadOnly = val;
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
        

        private void listViewtk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewtk.SelectedItems.Count > 0)//kiểm tra xem có ai nhập ko nếu có thì làm cái trong if
            {
                textmaCV.ReadOnly = true;
                textmaCV.Text = listViewtk.SelectedItems[0].SubItems[0].Text;
                texttenCV.Text = listViewtk.SelectedItems[0].SubItems[1].Text;

            }
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            textmaCV.ReadOnly = false;
            if (textmaCV.Text == "")
            {
                MessageBox.Show("Chưa Nhập mã chức vụ ", "Thông báo");
                textmaCV.Focus();
                textmaCV.ReadOnly = false;
            }
            else if (texttenCV.Text == "")
            {
                MessageBox.Show("Chưa Nhập tên chức vụ ", "Thông báo");
                texttenCV.Focus();
            }
            else
            {
                if (ktkieuintma(textmaCV.Text) == true)
                {
                    if (cv.ktma(textmaCV.Text) == true)
                    {
                        MessageBox.Show("Nhập trùng mã vui lòng nhập lại", "Thông báo");
                        textmaCV.Focus();
                        textmaCV.ReadOnly = false;
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
                    MessageBox.Show("Vui lòng không nhập mã quá lớn và nhập số cho mã chức vụ", "Thông báo");
                    textmaCV.Focus();
                }
            }
        }

        private void buttonluu_Click(object sender, EventArgs e)
        {
            if (themmoi)// đc click thì thực hiên vs dk true thì thực hiên cái đầu
            {
                cv.ThemNhanVien(textmaCV.Text, texttenCV.Text);
                MessageBox.Show("Thêm Thành Công", "Thông Báo");
                xoatextbox();
                dongtext(false);

            }
            else //ngược tra ve gia tri false thi thuc hien
            {
                cv.CapNhatNhanVien(listViewtk.SelectedItems[0].SubItems[0].Text, texttenCV.Text);
                MessageBox.Show("cập nhật Thành Công", "Thông Báo");
                xoatextbox();
                dongtext(false);
            }
            setButton(true);// dong thoi dong button luu va mo lại bunton mặc định
            hienthidsCV();
        }
        private void xoatextbox()
        {
            textmaCV.Focus();
            textmaCV.Text = "";
            texttenCV.Text = "";
        }// hàm xóa text box

        private void buttonhuy_Click(object sender, EventArgs e)
        {
            setButton(true); ;// dong thoi dong button luu va mo lại bunton mặc định
            MessageBox.Show("Bạn Vừa hủy bỏ tác vụ", "Thông Báo");
            xoatextbox();
            dongtext(false);
        }

        private void buttonsua_Click(object sender, EventArgs e)
        {
            if (listViewtk.SelectedItems.Count > 0)
            {
                if (textmaCV.Text == "" && texttenCV.Text == "")
                {
                    MessageBox.Show("Vui Lòng Chọn hàng cần sửa", "Thông Báo");
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
                MessageBox.Show("Vui lòng chọn hàng cần sửa", "thông báo");
            }
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            if (listViewtk.SelectedItems.Count > 0)
            {
                if (textmaCV.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn ô cần xóa", "Thông Báo");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa bằng cấp", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        cv.XoaNhanVien(listViewtk.SelectedItems[0].SubItems[0].Text);
                        listViewtk.Items.RemoveAt(listViewtk.SelectedIndices[0]);                       
                        MessageBox.Show("Xóa Thành Công", "thông báo");
                        textmaCV.ReadOnly = false;
                        xoatextbox();
                    }
                    else
                    {
                        MessageBox.Show("Bạn Vừa Hủy Chức Năng", "thông báo");
                        xoatextbox();
                        textmaCV.ReadOnly = false;
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

        private void FchucVuNV_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }           
        }
    }
}
