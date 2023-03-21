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
    public partial class Danh_Sách_Nhân_Viên : Form
    {


        DS_NV nv = new DS_NV();
        public bool themmoi = false;
        public Danh_Sách_Nhân_Viên()
        {
            InitializeComponent();
        }
        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
        void dongtext(bool val)
        {
            textmanv.ReadOnly = val;
            textdiachi.ReadOnly = val;
            textsdt.ReadOnly = val;
            texttennv.ReadOnly = val;
            combochucvu.Enabled = !val;
            datengay.Enabled = !val;
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            if (listViewNV.SelectedItems.Count > 0)
            {
                if (textmanv.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn ô cần xóa", "Thông Báo");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa bằng cấp", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        nv.Xoapbcc(textmanv.Text);
                        nv.XoapGX(textmanv.Text);
                        nv.Xoapds(textmanv.Text);
                        nv.Xoatk(textmanv.Text);
                        nv.XoaNhanVien(listViewNV.SelectedItems[0].SubItems[0].Text);
                        listViewNV.Items.RemoveAt(listViewNV.SelectedIndices[0]);
                        MessageBox.Show("Xóa Thành Công", "Thông Báo");
                        xoatextbox();
                        dongtext(false);
                        hienthislnv();
                    }
                    else
                    {
                        MessageBox.Show("Bạn Vừa Hủy Chức Năng", "thông báo");
                        xoatextbox();
                        dongtext(false);
                    }    
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn ô cần xóa", "Thông Báo");
            }
        }

        private void Danh_Sách_Nhân_Viên_Load(object sender, EventArgs e)
        {
            setButton(true);// ẩn đi nút lưu và hủy           
            hienthidsNV();
            hienthichucvu();
            hienthislnv();


        }
        private void hienthichucvu()// hien thi chuc vu
        {
            DataTable dt = nv.laychucvu();
            combochucvu.DataSource = dt;
            combochucvu.DisplayMember = "TEN_CHUC_VU";
            combochucvu.ValueMember = "MA_CHUC_VU";

        }
        private void hienthidsNV()
        {
            DataTable dt = nv.LayDSNhanvien();
            listViewNV.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                listViewNV.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());                
            }

        }
        private void hienthislnv()
        {
            DataTable dt = nv.soluongnv();
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                textslnv.Text = dt.Rows[i][0].ToString();               
            }

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

        private bool ktkieuint(string sdt)
        {

            double a;
            if (double.TryParse(sdt, out a))
            {
                return true;
            }
            return false;
        }

        private bool ktdodaisdt(string sdt)// kiem tra do dai cua =ten dang nhap
        {
            if (sdt.Length > 11)
            {
                return true;
            }
            return false;
        }
        private void xoatextbox()
        {
            textmanv.Focus();// cho con tro chuot vao ma nv
            textmanv.Text = "";
            texttennv.Text = "";
            textsdt.Text = "";
            textdiachi.Text = "";
            radionam.Checked = false;
            radionu.Checked = false;
        }

        private void Danh_Sách_Nhân_Viên_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Bạn có thật sự muốn thoát ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            textmanv.ReadOnly = false;
            if (textmanv.Text == "")// dieu kien tai khoan khong duoc de trong
            {
                MessageBox.Show("Vui lòng nhập mã nv", "Thông Báo");
                textmanv.Focus();
                textmanv.ReadOnly=false;
            }
            else if (texttennv.Text == "")// dieu kien mk khon dc de trong
            {
                MessageBox.Show("Vui lòng nhập Nhập tên nv", "Thông Báo");
                texttennv.Focus();
            }

            else if (textsdt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập sdt", "Thông Báo");
                textsdt.Focus();
            }
            else
            {
                try
                {
                    string ngay = datengay.Value.ToString("MM/dd/yyyy");//form mat đúng kiểu date sql
                    nv.hamttruyengiatri(textmanv.Text, texttennv.Text, combochucvu.SelectedValue.ToString(), textsdt.Text, textdiachi.Text, ngay);
                    if (ktkieuintma(nv.Manv))
                    {
                        if (nv.ktma(textmanv.Text) == true)// điều kiện kt xem có tùng mã nv hay không
                        {
                            MessageBox.Show("Mã Nhân Viên Này Đã Có", "Thông Báo");
                            textmanv.Focus();
                            textmanv.ReadOnly = false;

                        }
                        else
                        {
                            if (ktkieuint(nv.Sdt))
                            {
                                if (ktdodaisdt(nv.Sdt) == true)
                                {
                                    MessageBox.Show("Vui Lòng Nhập sdt  không quá 11 số", "Thông Báo");
                                    textsdt.Focus();
                                }
                                else
                                {
                                    if (radionam.Checked == true)
                                    {
                                        //set dateformat dmy
                                        themmoi = true;// thỏa mãn đk thi hàm them mơi sdc gán bằng true
                                        setButton(false);//nut bị dong dc mo lai
                                        dongtext(true);
                                        MessageBox.Show("-Chọn Lưu Để Thêm \n" + 
                                            "-Hủy Thì giữ nguyên ", "Thông Báo");


                                    }
                                    else if (radionu.Checked == true)
                                    {
                                        themmoi = true;// thỏa mãn đk thi hàm them mơi sdc gán bằng true
                                        setButton(false);//nut bị dong dc mo lai
                                        dongtext(true);
                                        MessageBox.Show("-Chọn Lưu Để Thêm \n" +
                                            "-Hủy Thì giữ nguyên ", "Thông Báo");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Vui lòng Chọn giới tính ", "Thông Báo");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Vui lòng không nhập chữ cái và ký tự cho sdt ", "Thông Báo");
                                textsdt.Focus();
                                textmanv.ReadOnly = false;
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Đảm bảo rằng bạn không nhập chữ cái,ký tự cho Mã Sinh Viên và không nhập số quá lớn", "Thông Báo");
                        textmanv.Focus();
                        textmanv.ReadOnly = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("lỗi");
                }

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void datengay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listViewNV_SelectedIndexChanged(object sender, EventArgs e)//ham click tra du lieu
        {
            if (listViewNV.SelectedItems.Count > 0)//kiểm tra xem có ai nhập ko nếu có thì làm cái trong if
            {
                textmanv.ReadOnly = true;
                // textmanv.ReadOnly = true;
                ListViewItem lvi = listViewNV.SelectedItems[0];
                textmanv.Text = lvi.SubItems[0].Text;
                texttennv.Text = lvi.SubItems[1].Text;
                combochucvu.SelectedIndex = combochucvu.FindString(lvi.SubItems[2].Text);
                textsdt.Text = lvi.SubItems[3].Text;
                textdiachi.Text = lvi.SubItems[4].Text;
                datengay.Value = DateTime.Parse(lvi.SubItems[5].Text);
               
            }

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (listViewNV.SelectedItems.Count > 0)
            {
                string ngay = datengay.Value.ToString("MM/dd/yyyy");//form mat đúng kiểu date sql


                if (texttennv.Text == "")// dieu kien mk khon dc de trong
                {
                    MessageBox.Show("không để trống tên", "Thông Báo");
                    texttennv.Focus();
                }

                else if (textsdt.Text == "")
                {
                    MessageBox.Show("không để trống sdt", "Thông Báo");
                    textsdt.Focus();
                }
                else
                {
                    nv.hamttruyengiatri(textmanv.Text, texttennv.Text, combochucvu.SelectedValue.ToString(), textsdt.Text, textdiachi.Text, ngay);

                    if (textmanv.Text!="")
                    {
                        if (ktkieuint(nv.Sdt))
                        {
                            if (ktdodaisdt(nv.Sdt) == true)
                            {
                                MessageBox.Show("Vui Lòng Nhập sdt  không quá 11 số", "Thông Báo");
                                textsdt.Focus();
                            }
                            else
                            {
                                if (radionam.Checked == true)
                                {
                                    themmoi = false;//thoa man dk thi ham sua dc gan bang false
                                    setButton(false);//nut bị dong dc mo lai
                                    dongtext(true);
                                    MessageBox.Show("-Chọn Lưu Để Sửa \n" +
                                           "-Hủy Thì giữ nguyên ", "Thông Báo");
                                }
                                else if (radionu.Checked == true)
                                {
                                    themmoi = false;//thoa man dk thi ham sua dc gan bang false
                                    setButton(false);//nut bị dong dc mo lai
                                    dongtext(true);
                                    MessageBox.Show("-Chọn Lưu Để Thêm \n" +
                                           "-Hủy Thì giữ nguyên ", "Thông Báo");
                                }
                                else
                                {
                                    MessageBox.Show("Vui lòng Chọn giới tính ", "Thông Báo");

                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng không nhập chữ cái và ký tự cho sdt ", "Thông Báo");
                            textsdt.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn ô cần sửa", "Thông Báo");
                    }    
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn ô cần sửa", "Thông Báo");
            }
        }

        private void buttontimkiem_Click(object sender, EventArgs e)
        {

        }

        private void textsdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonhuy_Click(object sender, EventArgs e)
        {
            setButton(true);// click vô thì mở lại nút bị đóng
            MessageBox.Show("Bạn Vừa hủy bỏ tác vụ", "Thông Báo");
            dongtext(false);
            xoatextbox();
        }

        private void buttonluu_Click(object sender, EventArgs e)
        {
            string ngay = datengay.Value.ToString("MM/dd/yyyy");//form mat đúng kiểu date sql
            if (themmoi)// đc click thì thực hiên vs dk true thì thực hiên cái đầu
            {
                if (radionam.Checked == true)
                {
                    nv.ThemNhanVien(textmanv.Text, texttennv.Text, combochucvu.SelectedValue.ToString(), textsdt.Text, textdiachi.Text, ngay,radionam.Text);
                    MessageBox.Show("Thêm Thành Công", "Thông Báo");
                    xoatextbox();
                    dongtext(false);
                }
                else if (radionu.Checked == true)
                {
                    nv.ThemNhanVien(textmanv.Text, texttennv.Text, combochucvu.SelectedValue.ToString(), textsdt.Text, textdiachi.Text, ngay,radionu.Text);
                    MessageBox.Show("Thêm Thành Công", "Thông Báo");
                    xoatextbox();
                    dongtext(false);
                }
                else
                {
                    MessageBox.Show("Vui lòng Chọn giới tính ", "Thông Báo");


                }
            }
            else //ngược tra ve gia tri false thi thuc hien
            {
                if (radionam.Checked == true)
                {
                    nv.CapNhatNhanVien(listViewNV.SelectedItems[0].SubItems[0].Text, texttennv.Text, combochucvu.SelectedValue.ToString(), textsdt.Text, textdiachi.Text, ngay,radionam.Text);
                    MessageBox.Show("cập nhật Thành Công", "Thông Báo");
                    xoatextbox();
                    dongtext(false);
                }
                else if (radionu.Checked == true)
                {
                    nv.CapNhatNhanVien(listViewNV.SelectedItems[0].SubItems[0].Text, texttennv.Text, combochucvu.SelectedValue.ToString(), textsdt.Text, textdiachi.Text, ngay,radionu.Text);
                    MessageBox.Show("cập nhật Thành Công", "Thông Báo");
                    xoatextbox();
                    dongtext(false);
                }
                else
                {
                    MessageBox.Show("Vui lòng Chọn giới tính ", "Thông Báo");


                }
            }
            setButton(true);// dong thoi dong button luu va mo lại bunton mặc định
            hienthidsNV();
            hienthislnv();

        }

        private void radionam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void combochucvu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonIN_Click(object sender, EventArgs e)
        {
            FREPORTDSNV F = new FREPORTDSNV();
            this.Hide();
            F.ShowDialog();
            this.Show();
        }

        private void buttontimkiemtheoteen_Click(object sender, EventArgs e)
        {
            if (textBoxtimten.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên muốn tìm", "Thông Báo");
                textBoxtimten.Focus();

            }
            else if (nv.ktten(textBoxtimten.Text) == true)
            {
                DataTable dt = nv.timkiemten(textBoxtimten.Text);
                listViewNV.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi =
                    listViewNV.Items.Add(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());
                    lvi.SubItems.Add(dt.Rows[i][3].ToString());
                    lvi.SubItems.Add(dt.Rows[i][4].ToString());
                    lvi.SubItems.Add(dt.Rows[i][5].ToString());
                    lvi.SubItems.Add(dt.Rows[i][6].ToString());
                }
                MessageBox.Show("Đã tìm đc thông tin muốn tìm", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Không có tên muốn tìm", "Thông Báo");
                textBoxtimten.Focus();
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxtimSDT.Text == "")
            {
                MessageBox.Show("Vui lòng SDT  muốn tìm", "Thông Báo");
                textBoxtimSDT.Focus();

            }
            else if (nv.ktSDT(textBoxtimSDT.Text) == true)
            {
                DataTable dt = nv.timkiemSDT(textBoxtimSDT.Text);
                listViewNV.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi =
                    listViewNV.Items.Add(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());
                    lvi.SubItems.Add(dt.Rows[i][3].ToString());
                    lvi.SubItems.Add(dt.Rows[i][4].ToString());
                    lvi.SubItems.Add(dt.Rows[i][5].ToString());
                    lvi.SubItems.Add(dt.Rows[i][6].ToString());
                }
                MessageBox.Show("Đã tìm đc thông tin muốn tìm", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Không có SDT muốn tìm", "Thông Báo");
                textBoxtimSDT.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxtimkiemma.Text == "")
            {
                MessageBox.Show("Vui lòng mã muốn tìm", "Thông Báo");
                textBoxtimkiemma.Focus();

            }
            else if (nv.ktMATIMKIEM(textBoxtimkiemma.Text) == true)
            {
                DataTable dt = nv.timkiemmanv(textBoxtimkiemma.Text);
                listViewNV.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi =
                    listViewNV.Items.Add(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());
                    lvi.SubItems.Add(dt.Rows[i][3].ToString());
                    lvi.SubItems.Add(dt.Rows[i][4].ToString());
                    lvi.SubItems.Add(dt.Rows[i][5].ToString());
                    lvi.SubItems.Add(dt.Rows[i][6].ToString());
                }
                MessageBox.Show("Đã tìm đc thông tin muốn tìm", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Không có mã  muốn tìm", "Thông Báo");
                textBoxtimkiemma.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hienthidsNV();
        }
    }
}
