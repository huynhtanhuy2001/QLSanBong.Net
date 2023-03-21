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
    public partial class Fphieuguixe : Form
    {
        ClassPhieuGuixe PGX = new ClassPhieuGuixe();
        public bool themmoi = false;

        public Fphieuguixe()
        {
            InitializeComponent();
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
        void redonlytex(bool val)
        {
            textmaphieu.ReadOnly = val;
            textbiensoxe.ReadOnly = val;
            combotenkhach.Enabled = !val;
            combotennv.Enabled = !val;
            datengaylap.Enabled = !val;
        }
        private void xoatext()
        {
            textmaphieu.Text = "";
            textbiensoxe.Text = "";
        }

        private void Fphieuguixe_Load(object sender, EventArgs e)
        {
            setButton(true);
            hienthitennv();
            hienthitenkhach();
            hienthidsTK();
        }
        private void hienthitennv()// hien thi chuc vu
        {

            DataTable dt = PGX.LayTENNV();
            combotennv.DataSource = dt;
            combotennv.ValueMember = "MA_NV";


        }
        private void hienthitenkhach()// hien thi chuc vu
        {

            DataTable dt = PGX.LayTENKHACH();
            combotenkhach.DataSource = dt;
            combotenkhach.ValueMember = "MA_KHACH";
            

        }
        private void hienthidsTK()// hien thi ds ssinh vien
        {
            DataTable dt = PGX.LayDSNhanvien();
            dataGridView1.DataSource = dt;

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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textmaphieu.ReadOnly = true;

                if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                {
                    textmaphieu.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    textbiensoxe.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    datengaylap.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                    combotenkhach.SelectedIndex = combotenkhach.FindString(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                    combotennv.SelectedIndex = combotennv.FindString(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Không có thông tin", "Thông Báo");
                }
            }
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            textmaphieu.ReadOnly = false;
            if (textmaphieu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã phiếu gửi xe", "thông báo");
                textmaphieu.Focus();
                textmaphieu.ReadOnly = false;
            }
            else if (textbiensoxe.Text == "")
            {
                MessageBox.Show("Vui lòng nhập biển số xe", "Thông báo");
                textbiensoxe.Focus();
                textmaphieu.ReadOnly = false;
            }
            else
            {
                if (PGX.ktbiénsoxe(textbiensoxe.Text) == true)
                {
                    MessageBox.Show("Biển số xe này đã có", "Thông báo");
                    textbiensoxe.Focus();
                    textmaphieu.ReadOnly = false;
                }
                else
                {
                    if (ktkieuintma(textmaphieu.Text) == true)
                    {
                        if (PGX.ktma(textmaphieu.Text) == true)
                        {
                            MessageBox.Show("Mã Phiếu Gửi Xe này đã có", "Thông báo");
                            textmaphieu.Focus();
                            textmaphieu.ReadOnly = false;
                        }
                        else
                        {
                            themmoi = true;// thỏa mãn đk thi hàm them mơi sdc gán bằng true
                            setButton(false);//nut bị dong dc mo lai
                            redonlytex(true);
                            MessageBox.Show("-Chọn Lưu Để Thêm \n" +
                                               "-Hủy Thì giữ nguyên ", "Thông Báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhâp số và không nhập số quá lớn cho mã phiếu", "Thông Báo");
                        textmaphieu.Focus();
                        textmaphieu.ReadOnly = false;
                    }
                }

            }
        }

        private void buttonluu_Click(object sender, EventArgs e)
        {
            string ngaylap = datengaylap.Value.ToString("MM/dd/yyyy");
            if (themmoi)// đc click thì thực hiên vs dk true thì thực hiên cái đầu
            {

                PGX.ThemNhanPHIEUGX(textmaphieu.Text, combotennv.SelectedValue.ToString(), combotenkhach.SelectedValue.ToString(), ngaylap, textbiensoxe.Text);
                MessageBox.Show("Thêm Thành Công", "Thông Báo");
                xoatext();
                redonlytex(false);

            }
            else //ngược tra ve gia tri false thi thuc hien
            {
                PGX.CapNhatphieugx(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), combotennv.SelectedValue.ToString(), combotenkhach.SelectedValue.ToString(), ngaylap, textbiensoxe.Text);
                MessageBox.Show("cập nhật Thành Công", "Thông Báo");
                xoatext();
                redonlytex(false);

            }
            setButton(true);// dong thoi dong button luu va mo lại bunton mặc định
            hienthidsTK();
        }

        private void buttonsua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                {
                    if (textbiensoxe.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập biển số xe", "Thông báo");
                        textbiensoxe.Focus();
                        textmaphieu.ReadOnly = false;
                    }
                    else
                    {
                        if (PGX.ktbiénsoxe(textbiensoxe.Text) == true)
                        {
                            MessageBox.Show("Biển số xe này đã có", "Thông báo");
                            textbiensoxe.Focus();
                            textmaphieu.ReadOnly = false;
                        }
                        else
                        {

                            themmoi = false;//thoa man dk thi ham sua dc gan bang false
                            themmoi = false;//thoa man dk thi ham sua dc gan bang false
                            setButton(false);//nut bị dong dc mo lai
                            redonlytex(true);
                            MessageBox.Show("-Chọn Lưu Để Sửa \n" +
                                                   "-Hủy Thì giữ nguyên ", "Thông Báo");

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không có thông tin", "Thông Báo");
                }
            }
            else
            {
                MessageBox.Show("Chọn Dòng muốn Sửa", "Thông Báo");
            }

        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                {

                    DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Thông Báo", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        PGX.XoaNhanVien(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                        MessageBox.Show("Xóa Thành Công", "thông báo");
                        xoatext();
                        hienthidsTK();
                        redonlytex(false);
                    }
                    else
                    {
                        MessageBox.Show("Bạn Vừa Hủy Bỏ Chức Năng", "thông báo");
                        xoatext();
                        redonlytex(false);
                    }
                }
                else
                {
                    MessageBox.Show("Không có thông tin", "Thông Báo");
                    redonlytex(false);
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa", "thông báo");
            }
        }

        private void buttonhuy_Click(object sender, EventArgs e)
        {
            setButton(true); ;// dong thoi dong button luu va mo lại bunton mặc định
            MessageBox.Show("Bạn Vừa hủy bỏ tác vụ", "Thông Báo");
            xoatext();
            redonlytex(false);
        }

        private void Fphieuguixe_FormClosing(object sender, FormClosingEventArgs e)
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

        private void combotennv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
