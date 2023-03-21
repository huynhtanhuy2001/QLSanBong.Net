using do_an_quan_ly_san_bong.Model;
using Microsoft.Reporting.WinForms;
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
    public partial class FREPORTDSNV : Form
    {
        Classreportnhanvien nv = new Classreportnhanvien();
        public FREPORTDSNV()
        {
            InitializeComponent();
        }

        private void FREPORTDSNV_Load(object sender, EventArgs e)
        {
            Model1 md = new Model1();
            //lấy ds hoadon
            List<NHAN_VIEN> HD = md.NHAN_VIEN.ToList();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.ReportPath = "./reportDANHSACHNHANVIEN.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("dsnv", HD);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
            hienthi();

        }
        private void hienthi()
        {
            DataTable dt = nv.LayDSNhanvien();
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                textBox1.Text = dt.Rows[i][0].ToString();

            }
        }

        private void FREPORTDSNV_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
