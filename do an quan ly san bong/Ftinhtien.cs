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
    public partial class Ftinhtien : Form
    {
        SqlConnection sqlcon;
        SqlCommand sqlcmd;
        SqlDataReader reader;
        int i = default;

        public Ftinhtien()
        {
            InitializeComponent();
        }

        private void Ftinhtien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.SAN_BONG' table. You can move, or remove it, as needed.

            string strcon = @"Data Source=LAPTOP-ESFJ9H96\MSSQLSERVER01;Initial Catalog=DO AN SAN BONG;Integrated Security=True";
            sqlcon = new SqlConnection(strcon);
            hienthihd();
            hienthiphieudat();
        }
        private void hienthiphieudat()
        {
            string strSQL = "SELECT MA_PHIEU_DAT_SAN,N.TEN_NV,K.TEN, convert(nvarchar(30),NGAY_LAP,110),convert(nvarchar(30),GIO_DAT,108),convert(nvarchar(30),GIO_HET,108),S.MA_SAN FROM PHIEU_DAT_SAN P, NHAN_VIEN N, KHACH K,SAN_BONG S WHERE (P.MA_NV = N.MA_NV and P.MA_KHACH = K.MA_KHACH and P.MA_SAN=S.MA_SAN) ";
            SqlDataAdapter da = new SqlDataAdapter(strSQL, sqlcon);
            DataTable dt = new DataTable();
            da.Fill(dt);
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
        private void them()
        {
            textMAHD.ReadOnly = false;
            string giodat = dategiodat.Value.ToString("HH: mm:ss ");
            string giohet = dateTimegiohet.Value.ToString("HH: mm:ss ");
            string ngaylap = dateTimengaylap.Value.ToString("MM/dd/yyyy");
            if (textBoxtongtien.Text == "" || textgiothue.Text == "" || textsânthue.Text == "")
            {
                MessageBox.Show("Vui Lòng tính tiền sân", "Thông Báo");
                buttontinhtien.Focus();
                textMAHD.ReadOnly = false;
            }
            else
            {
                if (textMAHD.Text == "")
                {
                    MessageBox.Show("Vui Lòng Nhập Mã HĐ", "Thông Báo");
                    textMAHD.Focus();
                    textMAHD.ReadOnly = false;
                }
                else
                {
                    if (ktkieuint(textMAHD.Text) == true)
                    {
                        if (kiemtramahd(textMAHD.Text) == true)
                        {
                            MessageBox.Show("Mã Hóa Đơn đã có vui lòng nhập lại", "Thông Báo");
                            textMAHD.Focus();
                            textMAHD.ReadOnly = false;
                        }
                        else
                        {
                            sqlcon.Open();
                            string sqlthem = "insert into HOADON VALUES(" + textMAHD.Text + ",N'" + texttennv.Text + "',N'" + textkhach.Text + "','" + textsânthue.Text + "','" + ngaylap + "','" + giodat + "','" + giohet + "','" + textgiothue.Text + "','" + textBoxtongtien.Text + "')";
                            sqlcmd = new SqlCommand(sqlthem, sqlcon);
                            sqlcmd.ExecuteNonQuery();
                            hienthihd();
                            MessageBox.Show("Thêm Thành Công ", "Thông Báo");
                            xoatext();
                            sqlcon.Close();
                        }
                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập số cho và không nhập số quá lớn cho Mã HD", "Thông Báo");
                        textMAHD.Focus();
                        textMAHD.ReadOnly = false;
                    }
                }
            }
        }
        private void hienthihd()
        {
            string strSQL = "SELECT MA_HD,TEN_NV,TEN_KHACH,SAN_THUE,convert(nvarchar(30),NGAY_LAP,110),convert(nvarchar(30),GIO_DAT,108),convert(nvarchar(30),GIO_HET,108),TONG_GIO,TONG_TIEN FROM HOADON";
            SqlDataAdapter da = new SqlDataAdapter(strSQL, sqlcon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            listViewhd.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
               listViewhd.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][7].ToString());
                lvi.SubItems.Add(dt.Rows[i][8].ToString());
            }
        }
        public bool kiemtra(string masan)
        {
            string sql = " SELECT MA_SAN FROM PHIEU_DAT_SAN  WHERE MA_SAN like  '%" + masan + "%'";

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
        public bool kiemtramaphieu(string masan)
        {

            string sql = " SELECT MA_PHIEU_DAT_SAN FROM PHIEU_DAT_SAN WHERE MA_PHIEU_DAT_SAN like'%" + masan + "%'";

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
        public bool kiemtraten(string masan)
        {

            string sql = " SELECT TEN_KHACH FROM HOADON WHERE TEN_KHACH like N'%" + masan + "%'";

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
        public bool kiemtramaHD(string masan)
        {

            string sql = " SELECT MA_HD FROM HOADON WHERE MA_HD like '%" + masan + "%'";

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

        public bool kiemtramahd(string masan)
        {
            string sql = " SELECT MA_HD FROM HOADON WHERE MA_HD='" + masan + "'";

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
        private bool ktkieuint(string sdt)
        {

            int a;
            if (int.TryParse(sdt, out a))
            {
                return true;
            }
            return false;
        }

        private void buttontimkiemmasan_Click(object sender, EventArgs e)
        {

            if (textBoxmasan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sân cần tìm kiếm", "Thông Báo");
                textBoxmasan.Focus();
            }
            else
            {
                if (ktkieuint(textBoxmasan.Text) == true)
                {
                    if (kiemtra(textBoxmasan.Text) == true)
                    {
                        sqlcon.Open();
                        string strSQL = "SELECT MA_PHIEU_DAT_SAN,N.MA_NV,K.MA_KHACH, convert(nvarchar(30),NGAY_LAP,110),convert(nvarchar(30),GIO_DAT,108),convert(nvarchar(30),GIO_HET,108),S.MA_SAN FROM PHIEU_DAT_SAN P, NHAN_VIEN N, KHACH K,SAN_BONG S WHERE (P.MA_NV = N.MA_NV and P.MA_KHACH = K.MA_KHACH and P.MA_SAN=S.MA_SAN )and( S.MA_SAN LIKE '%" + textBoxmasan.Text + "%') ";
                        sqlcmd = new SqlCommand(strSQL, sqlcon);
                        listViewNV.Items.Clear();
                        reader = sqlcmd.ExecuteReader();
                        i = 0;
                        while (reader.Read())
                        {
                            listViewNV.Items.Add(reader[0].ToString());
                            listViewNV.Items[i].SubItems.Add(reader[1].ToString());
                            listViewNV.Items[i].SubItems.Add(reader[2].ToString());
                            listViewNV.Items[i].SubItems.Add(reader[3].ToString());
                            listViewNV.Items[i].SubItems.Add(reader[4].ToString());
                            listViewNV.Items[i].SubItems.Add(reader[5].ToString());
                            listViewNV.Items[i].SubItems.Add(reader[6].ToString());
                            i++;
                        }

                        sqlcon.Close();
                        MessageBox.Show("tìm thành công", "Thong bao");
                        textBoxmasan.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Không có mã sân bạn cần tìm ", "Thong bao");
                        textBoxmasan.Focus();
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Vui Lòng Nhập số và ko nhập số quá lớn", "Thong bao");
                    textBoxmasan.Focus();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxmaphieu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã phiếu cần tìm", "Thông báo");
                textBoxmaphieu.Focus();
            }
            else
            {
                if (ktkieuint(textBoxmaphieu.Text) == true)
                {
                    if (kiemtramaphieu(textBoxmaphieu.Text) == true)
                    {
                        sqlcon.Open();
                        string strSQL = "SELECT MA_PHIEU_DAT_SAN,N.MA_NV,K.MA_KHACH, convert(nvarchar(30),NGAY_LAP,110),convert(nvarchar(30),GIO_DAT,108),convert(nvarchar(30),GIO_HET,108),S.MA_SAN FROM PHIEU_DAT_SAN P, NHAN_VIEN N, KHACH K,SAN_BONG S WHERE (P.MA_NV = N.MA_NV and P.MA_KHACH = K.MA_KHACH and P.MA_SAN=S.MA_SAN) and( MA_PHIEU_DAT_SAN like '%" + textBoxmaphieu.Text + "%') ";
                        sqlcmd = new SqlCommand(strSQL, sqlcon);
                        reader = sqlcmd.ExecuteReader();
                        listViewNV.Items.Clear();
                        i = 0;
                        while (reader.Read())
                        {
                            listViewNV.Items.Add(reader[0].ToString());
                            listViewNV.Items[i].SubItems.Add(reader[1].ToString());
                            listViewNV.Items[i].SubItems.Add(reader[2].ToString());
                            listViewNV.Items[i].SubItems.Add(reader[3].ToString());
                            listViewNV.Items[i].SubItems.Add(reader[4].ToString());
                            listViewNV.Items[i].SubItems.Add(reader[5].ToString());
                            listViewNV.Items[i].SubItems.Add(reader[6].ToString());
                            i++;
                        }
                        sqlcon.Close();
                        MessageBox.Show("tìm thành công", "Thông Báo");
                        textBoxmaphieu.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Không có mã phiếu  cần tìm " , "Thông báo");
                        textBoxmaphieu.Focus();
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Vui Lòng Nhập số và ko nhập số quá lớn", "Thông báo ");
                    textBoxmaphieu.Focus();
                }
            }
        }

        private void listViewNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewNV.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listViewNV.SelectedItems[0];
                textBoxmasan.Text = listViewNV.SelectedItems[0].SubItems[6].Text;
                textBoxmaphieu.Text = listViewNV.SelectedItems[0].SubItems[0].Text;
                texttennv.Text = listViewNV.SelectedItems[0].SubItems[1].Text;
                textkhach.Text = listViewNV.SelectedItems[0].SubItems[2].Text;
                dateTimengaylap.Value = DateTime.Parse(lvi.SubItems[3].Text);
                dategiodat.Value = DateTime.Parse(lvi.SubItems[4].Text);
                dateTimegiohet.Value = DateTime.Parse(lvi.SubItems[5].Text);

            }
        }

        private void listViewNV_Click(object sender, EventArgs e)
        {

        }
        private void xoatext()
        {
            textsânthue.Text = "";
            textgiothue.Text = "";
            textBoxtongtien.Text = "";
            textBoxmaphieu.Text = "";
            textBoxmasan.Text = "";
            textMAHD.Text = "";
            textkhach.Text = "";
            texttennv.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (listViewNV.SelectedItems.Count > 0)
            {
                if (textBoxmasan.Text == "" || textBoxmaphieu.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần thanh toán", "Thông Báo");
                }
                else
                {
                    // listViewNV.Items.Clear();
                    sqlcon.Open();
                    string sql = " select S.TEN_LOAI,P.MA_PHIEU_DAT_SAN,DATEDIFF(HOUR,P.GIO_DAT,P.GIO_HET),DATEDIFF(HOUR,P.GIO_DAT,P.GIO_HET)* S.GIA_LOAI FROM PHIEU_DAT_SAN P, SAN_BONG S where( P.MA_SAN= S.MA_SAN) AND (P.MA_SAN= N'" + textBoxmasan.Text + "' and  P.MA_PHIEU_DAT_SAN= N'" + textBoxmaphieu.Text + "') ";
                    sqlcmd = new SqlCommand(sql, sqlcon);
                    reader = sqlcmd.ExecuteReader();
                    while (reader.Read())
                    {
                        textsânthue.Text = reader[0].ToString();
                        textgiothue.Text = reader[2].ToString();
                        textBoxtongtien.Text = reader[3].ToString();
                        i++;
                    }
                    sqlcon.Close();
                    textBoxmaphieu.Text= "";
                    textBoxmasan.Text = "";
                    MessageBox.Show("Tính tiền thành công", "Thông Báo");
                    //sqlcon.Open();
                    //string sqlxoa = "DELETE FROM  PHIEU_DAT_SAN  WHERE MA_PHIEU_DAT_SAN= '" + listViewNV.SelectedItems[0].SubItems[0].Text + "'";
                    //sqlcmd = new SqlCommand(sqlxoa, sqlcon);
                    //sqlcmd.ExecuteNonQuery();
                    hienthiphieudat();
                    sqlcon.Close();
                    
                        
                    
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần thanh toán", "Thông Báo");
            }
        }
        private void buttonlưu_Click(object sender, EventArgs e)
        {
            them();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listViewhd.SelectedItems.Count > 0)
            {
                xoa();

            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa", "thông báo");
            }
        }
        private void xoa()
        {
            if (textMAHD.Text == "")
            {
                MessageBox.Show("Vui lòng chon dòng cần xóa", "Thông Báo");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không ? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    sqlcon.Open();
                    string sqlxoa = "DELETE FROM  HOADON WHERE MA_HD= '" + listViewhd.SelectedItems[0].SubItems[0].Text + "'";
                    sqlcmd = new SqlCommand(sqlxoa, sqlcon);
                    sqlcmd.ExecuteNonQuery();
                    hienthihd();
                    MessageBox.Show("Xóa Thành Công ", "Thông Báo");
                    textMAHD.ReadOnly = false;
                    xoatext();
                    sqlcon.Close();
                }
                else
                {
                    MessageBox.Show("Bạn Vừa Hủy Bỏ chức năng ", "Thông Báo");
                    textMAHD.ReadOnly = false;
                    xoatext();
                }
            }
        }

        private void listViewhd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewhd.SelectedItems.Count > 0)
            {
                textMAHD.ReadOnly = true;
                ListViewItem lvi = listViewhd.SelectedItems[0];
                textMAHD.Text = listViewhd.SelectedItems[0].SubItems[0].Text;
                texttennv.Text = listViewhd.SelectedItems[0].SubItems[1].Text;
                textkhach.Text = listViewhd.SelectedItems[0].SubItems[2].Text;
                dateTimengaylap.Value = DateTime.Parse(lvi.SubItems[4].Text);
                dategiodat.Value = DateTime.Parse(lvi.SubItems[5].Text);
                dateTimegiohet.Value = DateTime.Parse(lvi.SubItems[6].Text);
                textgiothue.Text = lvi.SubItems[7].Text;
                textBoxtongtien.Text = lvi.SubItems[8].Text;
                textsânthue.Text = listViewhd.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void buttonhienthittpds_Click(object sender, EventArgs e)
        {
            hienthiphieudat();
        }

        private void buttonhienthiHD_Click(object sender, EventArgs e)
        {
            hienthihd();
        }

        private void buttontimnmahd_Click(object sender, EventArgs e)
        {
            if (texttimmahd.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn tìm", "Thông báo");
                texttimmahd.Focus();
            }
            else
            {
                if (ktkieuint(texttimmahd.Text) == true)
                {
                    if (kiemtramaHD(texttimmahd.Text) == true)
                    {
                        sqlcon.Open();
                        string strSQL = "SELECT  MA_HD,TEN_NV,TEN_KHACH,SAN_THUE,convert(nvarchar(30),NGAY_LAP,110),convert(nvarchar(30),GIO_DAT,108),convert(nvarchar(30),GIO_HET,108),TONG_GIO,TONG_TIEN FROM HOADON where MA_HD like '%" + texttimmahd.Text + "%' ";
                        sqlcmd = new SqlCommand(strSQL, sqlcon);
                        reader = sqlcmd.ExecuteReader();
                        listViewhd.Items.Clear();
                        i = 0;
                        while (reader.Read())
                        {
                            listViewhd.Items.Add(reader[0].ToString());
                            listViewhd.Items[i].SubItems.Add(reader[1].ToString());
                            listViewhd.Items[i].SubItems.Add(reader[2].ToString());
                            listViewhd.Items[i].SubItems.Add(reader[3].ToString());
                            listViewhd.Items[i].SubItems.Add(reader[4].ToString());
                            listViewhd.Items[i].SubItems.Add(reader[5].ToString());
                            listViewhd.Items[i].SubItems.Add(reader[6].ToString());
                            listViewhd.Items[i].SubItems.Add(reader[7].ToString());
                            listViewhd.Items[i].SubItems.Add(reader[8].ToString());
                            i++;
                        }
                        sqlcon.Close();
                        MessageBox.Show("tìm thành công", "Thông bao");
                        texttimmahd.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Không có mã hóa đơn cần tìm", "Thong bao");
                        texttimmahd.Focus();
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Vui Lòng Nhập số và ko nhập số quá lớn", "Thong bao");
                    texttimmahd.Focus();
                }
            }
        }

        private void buttontimtenkhach_Click(object sender, EventArgs e)
        {
            if (texttimkiemmãkhach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã khách cần tìm", "Thông báo");
                texttimkiemmãkhach.Focus();
            }
            else
            {
                if (kiemtraten(texttimkiemmãkhach.Text) == true)
                {
                    sqlcon.Open();
                    string strSQL = "SELECT  MA_HD,TEN_NV,TEN_KHACH,SAN_THUE,convert(nvarchar(30),NGAY_LAP,110),convert(nvarchar(30),GIO_DAT,108),convert(nvarchar(30),GIO_HET,108),TONG_GIO,TONG_TIEN FROM HOADON where TEN_KHACH like N'%" + texttimkiemmãkhach.Text +"%' ";
                    sqlcmd = new SqlCommand(strSQL, sqlcon);
                    reader = sqlcmd.ExecuteReader();
                    listViewhd.Items.Clear();
                    i = 0;
                    while (reader.Read())
                    {
                        listViewhd.Items.Add(reader[0].ToString());
                        listViewhd.Items[i].SubItems.Add(reader[1].ToString());
                        listViewhd.Items[i].SubItems.Add(reader[2].ToString());
                        listViewhd.Items[i].SubItems.Add(reader[3].ToString());
                        listViewhd.Items[i].SubItems.Add(reader[4].ToString());
                        listViewhd.Items[i].SubItems.Add(reader[5].ToString());
                        listViewhd.Items[i].SubItems.Add(reader[6].ToString());
                        listViewhd.Items[i].SubItems.Add(reader[7].ToString());
                        listViewhd.Items[i].SubItems.Add(reader[8].ToString());
                        i++;
                    }
                    sqlcon.Close();
                    MessageBox.Show("tìm thành công", "Thong bao");
                    texttimkiemmãkhach.Text = "";
                }
                else
                {
                    MessageBox.Show("Không có thông tin cần tìm kiếm", "Thông bao");
                    texttimkiemmãkhach.Focus();
                }    
            }
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ftinhtien_FormClosing(object sender, FormClosingEventArgs e)
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

        private void buttoninhd_Click(object sender, EventArgs e)
        {
            Freport f = new Freport();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void textBoxmasan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

