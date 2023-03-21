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
    public partial class Floaisan : Form
    {

        public bool themmoi = false;
        ClassLoaisan LS = new ClassLoaisan();
        public Floaisan()
        {
            InitializeComponent();
        }

        private void Floaisan_Load(object sender, EventArgs e)
        {
            setButton(true);
            hienthidsLS();
        }
        void dongtext(bool val)
        {
            textloaisan.ReadOnly = val;
            textgialoai.ReadOnly = val;
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
        public void hienthidsLS()
        {
            DataTable dt = LS.LayDSNhanvien();
            listViewtk.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                listViewtk.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());

            }
        }
        private bool ktgiatien(string sdt)
        {

            double a;
            if (double.TryParse(sdt, out a))
            {
                return true;
            }
            return false;
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            textloaisan.ReadOnly = false;
            if (textloaisan.Text == "")
            {
                MessageBox.Show("Chưa Nhập tên loại sân ", "Thông báo");
                textloaisan.Focus();
                textloaisan.ReadOnly = false;
            }
            else if (textgialoai.Text == "")
            {
                MessageBox.Show("Chưa Nhập giá loại ", "Thông báo");
                textgialoai.Focus();
            }
            else
            {
                if (ktgiatien(textgialoai.Text) == true)
                {
                    if (LS.kttenloai(textloaisan.Text) == true)
                    {
                        MessageBox.Show("Nhập trùng tên vui lòng nhập lại", "Thông báo");
                        textloaisan.Focus();
                        textloaisan.ReadOnly = false;
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
                    MessageBox.Show("Vui  nhập số cho giá loại", "Thông báo");
                    textgialoai.Focus();
                }
            }
        }
        private void xoatextbox()
        {
            textloaisan.Text = "";
            textgialoai.Text = "";
        }
        private void buttonluu_Click(object sender, EventArgs e)
        {
            if (themmoi)// đc click thì thực hiên vs dk true thì thực hiên cái đầu
            {
                LS.ThemNhanVien(textloaisan.Text, textgialoai.Text);
                MessageBox.Show("Thêm Thành Công", "Thông Báo");
                xoatextbox();
                dongtext(false);

            }
            else //ngược tra ve gia tri false thi thuc hien
            {
                LS.CapNhatNhanVien(listViewtk.SelectedItems[0].SubItems[0].Text, textgialoai.Text);
                MessageBox.Show("cập nhật Thành Công", "Thông Báo");
                xoatextbox();
                dongtext(false);
            }
            setButton(true);// dong thoi dong button luu va mo lại bunton mặc định
            hienthidsLS();
        }

        private void listViewtk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewtk.SelectedItems.Count > 0)//kiểm tra xem có ai nhập ko nếu có thì làm cái trong if
            {
                textloaisan.ReadOnly = true;
                textloaisan.Text = listViewtk.SelectedItems[0].SubItems[0].Text;
                textgialoai.Text = listViewtk.SelectedItems[0].SubItems[1].Text;

            }
        }

        private void buttonsua_Click(object sender, EventArgs e)
        {
            if (listViewtk.SelectedItems.Count > 0)
            {


                if (textgialoai.Text == "" && textloaisan.Text == "")
                {
                    MessageBox.Show("Vui Lòng Chọn hàng cần sửa", "Thông Báo");
                }
                else if (textgialoai.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập tt cho giá loại", "Thông Báo");
                    textgialoai.Focus();
                }
                else
                {
                    if (ktgiatien(textgialoai.Text) == true)
                    {
                        themmoi = false;//thoa man dk thi ham sua dc gan bang false
                        setButton(false);//nut bị dong dc mo lai
                        dongtext(true);
                        MessageBox.Show("-Chọn Lưu Để Sửa \n" +
                                          "-Hủy Thì giữ nguyên ", "Thông Báo");
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập số cho giá loại", "thông báo");
                    }
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
                if (textloaisan.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn ô cần xóa", "Thông Báo");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Thông Báo", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                       
                        LS.Xoasan(listViewtk.SelectedItems[0].SubItems[0].Text);
                        LS.XoaNhanVien(listViewtk.SelectedItems[0].SubItems[0].Text);
                        listViewtk.Items.RemoveAt(listViewtk.SelectedIndices[0]);
                        MessageBox.Show("Xóa Thành Công", "thông báo");
                        textloaisan.ReadOnly = false;
                        xoatextbox();
                    }
                    else
                    {
                        MessageBox.Show("Bạn Vừa Hủy Chức Năng", "thông báo");
                        xoatextbox();
                        textloaisan.ReadOnly = false;
                    }
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn ô cần xóa", "Thông Báo");
            }


        }

        private void buttonhuy_Click(object sender, EventArgs e)
        {
            setButton(true); ;// dong thoi dong button luu va mo lại bunton mặc định
            MessageBox.Show("Bạn Vừa hủy bỏ tác vụ", "Thông Báo");
            xoatextbox();
            dongtext(false);
        }

        private void Floaisan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
