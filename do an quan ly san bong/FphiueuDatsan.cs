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
    public partial class FphiueuDatsan : Form
    {
        public FphiueuDatsan()
        {
            InitializeComponent();
        }
        ClassphieuDatSan pdh = new ClassphieuDatSan();
        public bool themmoi = false;
        void setButton(bool val)

        {
            buttonthem.Enabled = val;
            buttonxoa.Enabled = val;
            buttonSua.Enabled = val;
            buttonthoat.Enabled = val;
            buttonluu.Enabled = !val;
            buttonhuy.Enabled = !val;
        }
        private void FphiueuDatsan_Load(object sender, EventArgs e)
        {
            setButton(true);
            hienTENNV();
            hienTENkhach();
            hienthidsTK();
            hienmasan();
            hienthiSL();
            //hienthiSL();

        }
        private void hienTENNV()// hien thi chuc vu
        {
            DataTable dt = pdh.Laytennv();
            combotennv.DataSource = dt;
            combotennv.DisplayMember = "TEN_NV";
            combotennv.ValueMember = "MA_NV";
        }
        private void hienTENkhach()// hien thi chuc vu
        {
            DataTable dt = pdh.Laytenkhach();
            combotenkhach.DataSource = dt;
            combotenkhach.DisplayMember = "TEN";
            combotenkhach.ValueMember = "MA_KHACH";
        }
        private void hienmasan()// hien thi chuc vu
        {

            DataTable dt = pdh.Laymasan();
            comboBomasan.DataSource = dt;           
            comboBomasan.ValueMember = "MA_SAN";

        }
        private void hienthidsTK()// hien thi ds ssinh vien
        {
            DataTable dt = pdh.LayDsphieudat();
            listViewNV.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = listViewNV.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][7].ToString());

            }
        }
        private void hienthiSL()// hien thi ds ssinh vien
        {
            DataTable dt = pdh.Hienthisoluonghang();           
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                textBoxsoluong.Text = dt.Rows[i][0].ToString();        
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

        private void buttonthem_Click(object sender, EventArgs e)
        {
            textmaphieu.ReadOnly = false;
            if (textmaphieu.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Mã Phiếu", "Thông Báo");
                textmaphieu.Focus();
                textmaphieu.ReadOnly = false;
            }
            else
            {
                if(pdh.ktmasan(comboBomasan.SelectedValue.ToString())==true)
                {
                    MessageBox.Show("Sân đang có khách thuê vui lòng chọn sân khác", "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
                else if (ktkieuintma(textmaphieu.Text) == true)
                {
                    if (pdh.ktma(textmaphieu.Text) == true)// điều kiện kt xem có tùng mã nv hay không
                    {
                        MessageBox.Show("mã phiếu Đã Có", "Thông Báo");
                        textmaphieu.Focus();
                        textmaphieu.ReadOnly = false;
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
                    MessageBox.Show("Đảm bảo rằng bạn không nhập chữ cái,ký tự cho Mã Phiếu và không nhập số quá lớn", "Thông Báo");
                    textmaphieu.Focus();
                    textmaphieu.ReadOnly = false;
                }
            }
        }
        void dongtext(bool val)
        {
            textmaphieu.ReadOnly = val;
            combotennv.Enabled = !val;
            combotenkhach.Enabled = !val;
            datetimegiohet.Enabled = !val;
            dateTimegioidat.Enabled = !val;
            dateTimengaylap.Enabled = !val;
        }
        private void xoatextbox()
        {
            textmaphieu.Text = "";
        }

        private void buttonluu_Click(object sender, EventArgs e)
        {
            string giodat = dateTimegioidat.Value.ToString("HH: mm:ss ");
            string giohet = datetimegiohet.Value.ToString("HH: mm:ss ");
            string ngaylap = dateTimengaylap.Value.ToString("MM/dd/yyyy");
            if (themmoi)// đc click thì thực hiên vs dk true thì thực hiên cái đầu
            {

                pdh.Themphieudatsan(textmaphieu.Text, combotennv.SelectedValue.ToString(), combotenkhach.SelectedValue.ToString(), ngaylap, giodat, giohet, comboBomasan.SelectedValue.ToString(),textghichu.Text);
                MessageBox.Show("Thêm Thành Công", "Thông Báo");               
                dongtext(false);

            }
            else //ngược tra ve gia tri false thi thuc hien
            {
               pdh.CapNhatNhanVien(listViewNV.SelectedItems[0].SubItems[0].Text, combotennv.SelectedValue.ToString(), combotenkhach.SelectedValue.ToString(), ngaylap, giodat, giohet, comboBomasan.SelectedValue.ToString(), textghichu.Text);
                MessageBox.Show("cập nhật Thành Công", "Thông Báo");
                xoatextbox();
                dongtext(false);
            }
            xoatextbox();
            setButton(true);// dong thoi dong button luu va mo lại bunton mặc định
            hienthidsTK();
            hienthiSL();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (listViewNV.SelectedItems.Count > 0)
            {
                if (textmaphieu.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn dòng cần sửa", "Thông Báo");
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
                MessageBox.Show("Vui lòng chọn dòng cần sửa","Thông Báo");
            }    
        }

        private void listViewNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewNV.SelectedItems.Count > 0)//kiểm tra xem có ai nhập ko nếu có thì làm cái trong if
            {
                textmaphieu.ReadOnly = true;
                // textmanv.ReadOnly = true;
                ListViewItem lvi = listViewNV.SelectedItems[0];
                textmaphieu.Text = lvi.SubItems[0].Text;
                combotennv.SelectedIndex = combotennv.FindString(lvi.SubItems[1].Text);
                combotenkhach.SelectedIndex = combotenkhach.FindString(lvi.SubItems[2].Text);
                dateTimengaylap.Value = DateTime.Parse(lvi.SubItems[3].Text);
                dateTimegioidat.Value = DateTime.Parse(lvi.SubItems[4].Text);
                datetimegiohet.Value = DateTime.Parse(lvi.SubItems[5].Text);
                comboBomasan.SelectedIndex = comboBomasan.FindString(lvi.SubItems[6].Text);
                textghichu.Text = lvi.SubItems[7].Text;

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
                if (textmaphieu.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn hàng cần xóa", "thông báo");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Thông Báo", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        pdh.XoaNhanVien(listViewNV.SelectedItems[0].SubItems[0].Text);
                        listViewNV.Items.RemoveAt(listViewNV.SelectedIndices[0]);
                        MessageBox.Show("Xóa Thành Công", "thông báo");
                        xoatextbox();
                        dongtext(false);
                        hienthiSL();

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
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FphiueuDatsan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            
        }

        private void buttonin_Click(object sender, EventArgs e)
        {
            FormreportPHIEUDATSAN f = new FormreportPHIEUDATSAN();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void combotenkhach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxsoluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
