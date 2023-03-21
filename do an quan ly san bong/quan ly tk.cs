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
    public partial class quan_ly_tk : Form
    {



        quanlyTK qlnv = new quanlyTK();
        public bool themmoi = false;

        public quan_ly_tk()
        {
            InitializeComponent();
        }



        private void quan_ly_tk_Load(object sender, EventArgs e)
        {
            setButton(true);// xét dk dong mơ ở hàm setbuton
            //string strcon = @"Data Source=HOANG;Initial Catalog=DO AN SAN BONG;Integrated Security=True";
            //sqlcon = new SqlConnection(strcon);
            //sqlcon.Open();
            hienthidsTK();
            hienthiMANV();
            hienthiquyen();


        }
        void dongtext(bool val)
        {
            texttendangnhap.ReadOnly = val;
            textmatkhau.ReadOnly = val;
            combochucvu.Enabled = !val;
            comboquyen.Enabled = !val;
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
        private void hienthiquyen()// hien thi chuc vu
        {

            DataTable dt = qlnv.Layquyen();
            comboquyen.DataSource = dt;
            comboquyen.ValueMember = "QUYEN";

        }
        private void hienthiMANV()// hien thi chuc vu
        {
            DataTable dt = qlnv.LaymaNV();
            combochucvu.DataSource = dt;
            combochucvu.ValueMember = "MA_NV";

        }
        private void hienthidsTK()// hien thi ds ssinh vien
        {
            DataTable dt = qlnv.LayDSNhanvien();
            listViewtk.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                listViewtk.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());

            }
        }



        private bool ktdodaimk(string mk)// kiem tra do dai cua mat khau
        {
            if (mk.Length > 15)
            {
                return true;
            }
            return false;
        }
        private bool ktdodaitk(string tk)// kiem tra do dai cua =ten dang nhap
        {
            if (tk.Length > 30)
            {
                return true;
            }
            return false;
        }

        private void quan_ly_tk_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            

        }

        private void combotennv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            texttendangnhap.ReadOnly = false;
            if (texttendangnhap.Text == "")// dieu kien tai khoan khong duoc de trong
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập", "Thông Báo");
                texttendangnhap.Focus();
                texttendangnhap.ReadOnly = false;
            }
            else if (textmatkhau.Text == "")// dieu kien mk khon dc de trong
            {
                MessageBox.Show("Vui lòng nhập Nhập Mật Khẩu", "Thông Báo");
                textmatkhau.Focus();
                texttendangnhap.ReadOnly = false;
            }
            else
            {

                if (qlnv.ktma(texttendangnhap.Text) == true)// điều kiện kt xem có tùng mã nv hay không
                {
                    MessageBox.Show("Tên Đăng Nhập Đã Có", "Thông Báo");
                    texttendangnhap.Focus();
                    texttendangnhap.ReadOnly = false;
                }
                else
                {
                    if (ktdodaitk(texttendangnhap.Text) == true)// dk kiem tra khong qua 30 ký tự
                    {
                        MessageBox.Show("Vui lòng nhập tên đăng nhập  không quá 30 ký tự", "Thông Báo");
                        texttendangnhap.Focus();
                    }
                    else if (ktdodaimk(textmatkhau.Text) == true)// dk kiem tra khong qua 15 ký tự
                    {
                        MessageBox.Show("Vui lòng nhập mật khẩu không quá 15 ký tự", "Thông Báo");
                        textmatkhau.Focus();
                    }
                    // neu khong trùng diều kiện thì cho thêm
                    else
                    {
                        themmoi = true;// thỏa mãn đk thi hàm them mơi sdc gán bằng true
                        setButton(false);//nut bị dong dc mo lai
                        dongtext(true);
                        MessageBox.Show("-Chọn Lưu Để Thêm \n" +
                                           "-Hủy Thì giữ nguyên ", "Thông Báo");
                    }
                }

            }
        }//NÚT THÊM

        private void combochucvu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewtk_SelectedIndexChanged(object sender, EventArgs e)// hàm đổ dữ liệu sau 1 lần click
        {
            // texttendangnhap.ReadOnly = true;
            if (listViewtk.SelectedItems.Count > 0)//kiểm tra xem có ai nhập ko nếu có thì làm cái trong if
            {
                texttendangnhap.ReadOnly = true;
                //texttendangnhap.ReadOnly = true;
                //lấy dữ liệ từ cái lis view bằng 1 lần click
                ListViewItem lvi = listViewtk.SelectedItems[0];
                string tendn = lvi.SubItems[0].Text;
                int chucvu = combochucvu.FindString(lvi.SubItems[1].Text);
                string mk = lvi.SubItems[2].Text;
                //đổ dữ liệu từ list view sang cho teexxt box
                texttendangnhap.Text = tendn;
                combochucvu.SelectedIndex = chucvu;
                textmatkhau.Text = mk;
                comboquyen.SelectedIndex = comboquyen.FindString(lvi.SubItems[3].Text);

            }
        }
        private void xoatextbox()
        {
            texttendangnhap.Focus();
            texttendangnhap.Text = "";
            textmatkhau.Text = "";


        }// hàm xóa text box
        private void buttonxoa_Click(object sender, EventArgs e)
        {
            if (listViewtk.SelectedItems.Count > 0)
            {
                if (texttendangnhap.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn hàng cần xóa", "thông báo");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa bằng cấp", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        qlnv.XoaNhanVien(listViewtk.SelectedItems[0].SubItems[0].Text);
                        listViewtk.Items.RemoveAt(listViewtk.SelectedIndices[0]);                       
                        MessageBox.Show("Xóa Thành Công", "thông báo");
                        xoatextbox();
                        dongtext(false);
                        
                    }
                    else
                    {
                        MessageBox.Show("Bạn Vừa Hủy Bỏ Chức Năng", "thông báo");
                        xoatextbox();
                        dongtext(false);
                    }    
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa", "thông báo");
            }
        }// NÚT XÓA

        private void buttonsua_Click(object sender, EventArgs e)
        {
            if (listViewtk.SelectedItems.Count > 0)
            {

                if (texttendangnhap.Text != "")
                {
                    if (ktdodaimk(textmatkhau.Text) == true)// dk kiem tra khong qua 15 ký tự
                    {
                        MessageBox.Show("Vui lòng nhập mật khẩu không quá 15 ký tự", "Thông Báo");
                        textmatkhau.Focus();

                    }
                    // neu khong trùng diều kiện thì cho thêm
                    else
                    {
                        themmoi = false;//thoa man dk thi ham sua dc gan bang false
                        setButton(false);//nut bị dong dc mo lai
                     
                        MessageBox.Show("-Chọn Lưu Để Sửa \n" +
                                               "-Hủy Thì giữ nguyên ", "Thông Báo");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn hàng cần sửa", "thông báo");
                }    

            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần sửa", "thông báo");
            }
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonluu_Click(object sender, EventArgs e)
        {
            if (themmoi)// đc click thì thực hiên vs dk true thì thực hiên cái đầu
            {
                qlnv.ThemNhanVien(texttendangnhap.Text, combochucvu.SelectedValue.ToString(), textmatkhau.Text, comboquyen.SelectedValue.ToString());
                MessageBox.Show("Thêm Thành Công", "Thông Báo");
                xoatextbox();
                dongtext(false);

            }
            else //ngược tra ve gia tri false thi thuc hien
            {
                qlnv.CapNhatNhanVien(listViewtk.SelectedItems[0].SubItems[0].Text, combochucvu.SelectedValue.ToString(), textmatkhau.Text, comboquyen.SelectedValue.ToString());
                MessageBox.Show("cập nhật Thành Công", "Thông Báo");
                xoatextbox();
                dongtext(false);
            }
            setButton(true);// dong thoi dong button luu va mo lại bunton mặc định
            hienthidsTK();
        }

        private void buttonhuy_Click(object sender, EventArgs e)
        {
            setButton(true); ;// dong thoi dong button luu va mo lại bunton mặc định
            MessageBox.Show("Bạn Vừa hủy bỏ tác vụ", "Thông Báo");
            xoatextbox();
            dongtext(false);
        }
    }
}
