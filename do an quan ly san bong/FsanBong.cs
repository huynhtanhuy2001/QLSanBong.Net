using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_an_quan_ly_san_bong
{
    public partial class FsanBong : Form
    {
        SqlConnection sqlcon;
        SqlCommand sqlcmd;
        SqlDataReader reader;

        public bool themmoi = false;

        public FsanBong()
        {
            InitializeComponent();
        }

        private void FsanBong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.LOAISAN' table. You can move, or remove it, as needed.
            this.lOAISANTableAdapter.Fill(this.dataSet1.LOAISAN);
            // TODO: This line of code loads data into the 'dataSet1.LOAISAN' table. You can move, or remove it, as needed.
            setButton(true);
            string strcon = @"Data Source=LAPTOP-ESFJ9H96\MSSQLSERVER01;Initial Catalog=DO AN SAN BONG;Integrated Security=True";
            sqlcon = new SqlConnection(strcon);
            hienthidsTK();


        }
        public bool kiemtra(string masan)
        {
            string sql = " SELECT MA_SAN FROM SAN_BONG WHERE MA_SAN =  '" + masan + "'";

            sqlcmd = new SqlCommand(sql, sqlcon);
            sqlcon.Open();
            reader = sqlcmd.ExecuteReader();
            if (reader.Read() == true)// đọc mà trùng với cái nhập thig trả về true
            {
                sqlcon.Close();
                reader.Close();
                return true;

            }
            sqlcon.Close();
            reader.Close();
            return false;
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
        private bool ktkieuintma(string sdt)
        {

            int a;
            if (Int32.TryParse(sdt, out a))
            {
                return true;
            }
            return false;
        }

        private void thêm()
        {
            sqlcon.Open();
            try
            {
                if (ktkieuintma(textmasan.Text) == true)
                {
                    string sqlthem = "insert into SAN_BONG  VALUES('" + textmasan.Text + "','" + textgialoai.Text + "','" + combotenloai.SelectedValue.ToString() + "')";
                    sqlcmd = new SqlCommand(sqlthem, sqlcon);
                    sqlcmd.ExecuteNonQuery();
                    //hienthidsTK();
                    MessageBox.Show("Thêm Thành Công ", "Thông Báo");
                    //sqlcon.Close()
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Vui Lòng Nhập Số Cho mã sv ", "Thông Báo");
                    textmasan.ReadOnly = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("sai ", "Thông Báo");
                textmasan.Focus();
                textmasan.ReadOnly = false;
            }
            sqlcon.Close();

        }
        private void hienthidsTK()// hien thi ds ssinh vien
        {


            string sqlhienthi = "SELECT MA_SAN,N.GIA_LOAI,T.TEN_LOAI FROM SAN_BONG T, LOAISAN N  WHERE T.GIA_LOAI = N.GIA_LOAI";
            sqlcmd = new SqlCommand(sqlhienthi, sqlcon);// ham thuc thi          
            SqlDataAdapter da = new SqlDataAdapter(sqlhienthi, sqlcon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            listViewtk.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                listViewtk.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
            }
        }
        void dongtext(bool val)
        {
            textmasan.ReadOnly = val;
            combotenloai.Enabled = !val;
        }
        private void hinthichucvu()
        {
            sqlcon.Open();
            string sql = "select * from LOAISAN  where TEN_LOAI= '" + combotenloai.Text + "'  ";
            sqlcmd = new SqlCommand(sql, sqlcon);
            reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                string ten = reader.GetDouble(1).ToString();
                textgialoai.Text = ten;
            }
            reader.Close();
            sqlcon.Close();
        }

        private void FsanBong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                sqlcon.Close();

            }

        }

        private void combogialoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            hinthichucvu();
        }
        private void sua()
        {
            sqlcon.Open();
            string sqlsua = "UPDATE SAN_BONG SET GIA_LOAI = N'" + textgialoai.Text + "',TEN_LOAI ='" + combotenloai.SelectedValue.ToString() + "' WHERE MA_SAN = N'" + listViewtk.SelectedItems[0].SubItems[0].Text + "'";
            sqlcmd = new SqlCommand(sqlsua, sqlcon);
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Sửa Thành Công ", "Thông Báo");
            xoatext();
            sqlcon.Close();

        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            textmasan.ReadOnly = false;
            try
            {
                if (textgialoai.Text == "")
                {
                    MessageBox.Show("Vui lòng click vào tên sân để chọn giá ", "Thông Báo");
                    combotenloai.Focus();
                }
                else
                {
                    if (textmasan.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập  mã sân", "Thông Báo");
                        textmasan.Focus();
                    }
                    else
                    {
                        if (kiemtra(textmasan.Text) == true)
                        {
                            MessageBox.Show("Mã sân đã có vui lòng nhập lại", "Thông Báo");
                            textmasan.Focus();
                            textmasan.ReadOnly = false;
                        }
                        else
                        {
                            if (ktkieuintma(textmasan.Text) == true)
                            {

                                themmoi = true;// thỏa mãn đk thi hàm them mơi sdc gán bằng true
                                setButton(false);//nut bị dong dc mo lai
                                dongtext(true);
                                MessageBox.Show("-Chọn Lưu Để Thêm \n" +
                                                        "-Hủy Thì giữ nguyên ", "Thông Báo");
                            }
                            else
                            {
                                MessageBox.Show("Vui Lòng nhập số và không nhập số quá lớn cho mã sân ", "Thông Báo");
                                textmasan.Focus();
                                textmasan.ReadOnly = false;
                            }
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("sai ", "Thông Báo");

            }
        }
        private void buttonxoa_Click(object sender, EventArgs e)
        {
            if (listViewtk.SelectedItems.Count > 0)
            {

                if (textmasan.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn dòng cần xóa", "Thông báo");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa bằng cấp", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        if (dr == DialogResult.Yes)
                        {
                            sqlcon.Open();
                            string sqlpds = "DELETE FROM  PHIEU_DAT_SAN WHERE MA_SAN = '" + textmasan.Text + "'";
                            sqlcmd = new SqlCommand(sqlpds, sqlcon);
                            sqlcmd.ExecuteNonQuery();
                            sqlcon.Close();

                        }
                        sqlcon.Open();
                        string sqlxoa = "DELETE FROM  SAN_BONG WHERE MA_SAN = '" + listViewtk.SelectedItems[0].SubItems[0].Text + "'";
                        sqlcmd = new SqlCommand(sqlxoa, sqlcon);
                        sqlcmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa Thành Công ", "Thông Báo");
                        sqlcon.Close();
                        hienthidsTK();
                        xoatext();
                        dongtext(false);
                    }
                    else
                    {
                        MessageBox.Show("Bạn Vừa Hủy Chức Năng ", "Thông Báo");
                        xoatext();
                        dongtext(false);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa", "Thông báo");
            }
        }

        private void buttonluu_Click(object sender, EventArgs e)
        {
            if (themmoi)// đc click thì thực hiên vs dk true thì thực hiên cái đầu
            {
                thêm();
                dongtext(false);

            }
            else //ngược tra ve gia tri false thi thuc hien
            {
                sua();
                dongtext(false);

            }
            xoatext();
            setButton(true);// dong thoi dong button luu va mo lại bunton mặc định
            hienthidsTK();
        }
        private void xoatext()
        {
            textmasan.Text = "";
            textgialoai.Text = "";
        }

        private void listViewtk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewtk.SelectedItems.Count > 0)
            {
                textmasan.ReadOnly = true;
                textmasan.Text = listViewtk.SelectedItems[0].SubItems[0].Text;
                combotenloai.SelectedIndex = combotenloai.FindString(listViewtk.SelectedItems[0].SubItems[2].Text);
                textgialoai.Text = listViewtk.SelectedItems[0].SubItems[1].Text;
            }

        }

        private void buttonhuy_Click(object sender, EventArgs e)
        {
            setButton(true);// click vô thì mở lại nút bị đóng
            MessageBox.Show("Bạn Vừa hủy bỏ tác vụ", "Thông Báo");
            dongtext(false);
            xoatext();
        }

        private void buttonsua_Click(object sender, EventArgs e)
        {
            if (listViewtk.SelectedItems.Count > 0)
            {
                if (textmasan.Text == "")
                {
                    MessageBox.Show("Vui Lòng Chọn dòng cần sửa");
                }
                else
                {
                    themmoi = false;//thoa man dk thi ham sua dc gan bang false
                    setButton(false);//nut bị dong dc mo lai
                    dongtext(true);
                    MessageBox.Show("-Chọn Lưu Để Thêm \n" +
                                                   "-Hủy Thì giữ nguyên ", "Thông Báo");
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn dòng cần sửa");
            }
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
