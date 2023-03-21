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
    public partial class ManHinhChinh : Form
    {
        string tendangnhap = "", mk = "", quyen = "";
        string manv = default;
        public ManHinhChinh()
        {
            InitializeComponent();

        }
        public ManHinhChinh(string tendangnhap, string mk, string manv, string quyen)
        {
            InitializeComponent();
            this.tendangnhap = tendangnhap;
            this.mk = mk;
            this.manv = manv;
            this.quyen = quyen;
        }


        private void tạoTtNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var f in this.MdiChildren)
            {
                //trong truong hop from dc mo 
                if (f.Name == "Danh_Sách_Nhân_Viên")
                {
                    // hien thi len tren dau
                    f.Activate();
                    return;
                }
            }
            //neu form chua dc mo thi tbuc hien
            Danh_Sách_Nhân_Viên sv = new Danh_Sách_Nhân_Viên();
            sv.MdiParent = this;
            sv.Show();
        }

        private void ManHinhChinh_Load(object sender, EventArgs e)
        {
            if (quyen == "thu ngân")
            {
                quảnLýTàiKhoảnToolStripMenuItem1.Visible = false;
                thôngTinNhânViênToolStripMenuItem.Visible = false;
                hethongToolStripMenuItem.Visible = false;
                lươngCủaNhânViênTrongThángToolStripMenuItem.Visible = false;
                thôngTinsânToolStripMenuItem.Visible = false;
                bảngChấmCôngToolStripMenuItem.Visible = false;
                tỔNGDOANHTHUToolStripMenuItem.Visible = false;
            }
            if (quyen == "bảo vệ")
            {
                quảnLýTàiKhoảnToolStripMenuItem1.Visible = false;
                thôngTinNhânViênToolStripMenuItem.Visible = false;
                hethongToolStripMenuItem.Visible = false;
                lươngCủaNhânViênTrongThángToolStripMenuItem.Visible = false;
                thôngTinsânToolStripMenuItem.Visible = false;
                bảngChấmCôngToolStripMenuItem.Visible = false;
                tỔNGDOANHTHUToolStripMenuItem.Visible = false;

            }


        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            flogin f = new flogin();
            this.Close();
            f.Show();

            MessageBox.Show("Bạn vừa thoát khỏi chương trình ");
        }

        private void ManHinhChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (var f in this.MdiChildren)
            {
                //trong truong hop from dc mo 
                if (f.Name == "quan_ly_tk")
                {
                    // hien thi len tren dau
                    f.Activate();
                    return;
                }
            }
            //neu form chua dc mo thi tbuc hien
            quan_ly_tk sv = new quan_ly_tk();
            sv.MdiParent = this;
            sv.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void chứcVụNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var f in this.MdiChildren)
            {
                //trong truong hop from dc mo 
                if (f.Name == "FchucVuNV ")
                {
                    // hien thi len tren dau
                    f.Activate();
                    return;
                }
            }
            //neu form chua dc mo thi tbuc hien
            FchucVuNV sv = new FchucVuNV();
            sv.MdiParent = this;
            sv.Show();

        }

        private void tTKHÁCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var f in this.MdiChildren)
            {
                //trong truong hop from dc mo 
                if (f.Name == " Fkhach ")
                {
                    // hien thi len tren dau
                    f.Activate();
                    return;
                }
            }
            //neu form chua dc mo thi tbuc hien
            Fkhach sv = new Fkhach();
            sv.MdiParent = this;
            sv.Show();


        }

        private void sânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var f in this.MdiChildren)
            {
                //trong truong hop from dc mo 
                if (f.Name == " FsanBong")
                {
                    // hien thi len tren dau
                    f.Activate();
                    return;
                }
            }
            //neu form chua dc mo thi tbuc hien
            FsanBong sv = new FsanBong();
            sv.MdiParent = this;
            sv.Show();
        }

        private void phiếuĐặtSânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (var f in this.MdiChildren)
            {
                //trong truong hop from dc mo 
                if (f.Name == "  FphiueuDatsan")
                {
                    // hien thi len tren dau
                    f.Activate();
                    return;
                }
            }
            //neu form chua dc mo thi tbuc hien
            FphiueuDatsan sv = new FphiueuDatsan();

            sv.MdiParent = this;
            sv.Show();

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quyềntk_Click(object sender, EventArgs e)
        {

        }

        private void tínhTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
        }

        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc đăng xuất không? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                flogin f = new flogin();
                this.Hide();
                f.Show();
                MessageBox.Show("Bạn vừa đăng xuất khỏi tài khoản", "Thông báo ");
            }
        }

        private void ManHinhChinh_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void phiếuGửiXeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (var f in this.MdiChildren)
            {
                //trong truong hop from dc mo 
                if (f.Name == "   Fphieuguixe")
                {
                    // hien thi len tren dau
                    f.Activate();
                    return;
                }
            }
            //neu form chua dc mo thi tbuc hien

            Fphieuguixe sv = new Fphieuguixe();
            sv.MdiParent = this;
            sv.Show();

        }

        private void phiếuĐặtSânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var f in this.MdiChildren)
            {
                //trong truong hop from dc mo 
                if (f.Name == "Floaisan")
                {
                    // hien thi len tren dau
                    f.Activate();
                    return;
                }
            }
            //neu form chua dc mo thi tbuc hien
            Floaisan sv = new Floaisan();
            sv.MdiParent = this;
            sv.Show();
        }

        private void tỔNGDOANHTHUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var f in this.MdiChildren)
            {
                //trong truong hop from dc mo 
                if (f.Name == "Ftongdoanhthutheongaythang")
                {
                    // hien thi len tren dau
                    f.Activate();
                    return;
                }
            }
            //neu form chua dc mo thi tbuc hien
            Ftongdoanhthutheongaythang sv = new Ftongdoanhthutheongaythang();
            sv.MdiParent = this;
            sv.Show();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var f in this.MdiChildren)
            {
                //trong truong hop from dc mo 
                if (f.Name == "Ftinhtien")
                {
                    // hien thi len tren dau
                    f.Activate();
                    return;
                }
            }
            //neu form chua dc mo thi tbuc hien
            Ftinhtien sv = new Ftinhtien();


            sv.MdiParent = this;
            sv.Show();
        }

        private void đĂNGXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc đăng xuất không? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                flogin f = new flogin();
                this.Hide();
                f.Show();
                MessageBox.Show("Bạn vừa đăng xuất khỏi tài khoản", "Thông báo ");
            }
        }

        private void đăngXuấtToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc đăng xuất không? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                flogin f = new flogin();
                this.Hide();
                f.Show();
                MessageBox.Show("Bạn vừa đăng xuất khỏi tài khoản", "Thông báo ");
            }
        }

        private void dSBẢNGCHẤMCÔNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var f in this.MdiChildren)
            {
                //trong truong hop from dc mo 
                if (f.Name == "bangchamcong")
                {
                    // hien thi len tren dau
                    f.Activate();
                    return;
                }
            }
            //neu form chua dc mo thi tbuc hien
            bangchamcong sv = new bangchamcong();


            sv.MdiParent = this;
            sv.Show();
        }

        private void lươngCủaNhânViênTrongThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var f in this.MdiChildren)
            {
                //trong truong hop from dc mo 
                if (f.Name == " Ftinhluongtheongaythangtuychon")
                {
                    // hien thi len tren dau
                    f.Activate();
                    return;
                }
            }
            //neu form chua dc mo thi tbuc hien
            Ftinhluongtheongaythangtuychon sv = new Ftinhluongtheongaythangtuychon();
            sv.MdiParent = this;
            sv.Show();
        }

        private void dANHSÁCHSÂNBÓNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var f in this.MdiChildren)
            {
                //trong truong hop from dc mo 
                if (f.Name == " FDANHSACHSANBONG")
                {
                    // hien thi len tren dau
                    f.Activate();
                    return;
                }
            }
            //neu form chua dc mo thi tbuc hien
           FDANHSACHSANBONG sv = new FDANHSACHSANBONG();
            sv.MdiParent = this;
            sv.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (var f in this.MdiChildren)
            {
                //trong truong hop from dc mo 
                if (f.Name == "Fquenmk")
                {
                    // hien thi len tren dau
                    f.Activate();
                    return;
                }
            }
            //neu form chua dc mo thi tbuc hien
            Fquenmk sv = new Fquenmk();
            sv.MdiParent = this;
            sv.Show();
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tÌMKiếmDanhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var f in this.MdiChildren)
            {
                //trong truong hop from dc mo 
                if (f.Name == " Tìm_Kiếm sv")
                {
                    // hien thi len tren dau
                    f.Activate();
                    return;
                }
            }
            //neu form chua dc mo thi tbuc hien
            Tìm_Kiếm sv = new Tìm_Kiếm();
            sv.MdiParent = this;
            sv.Show();
        }
    }
}
