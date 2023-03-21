using do_an_quan_ly_san_bong.model2;
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
    public partial class Formreportbangchamcong : Form
    {
        public Formreportbangchamcong()
        {
            InitializeComponent();
        }

        private void Formreportbangchamcong_Load(object sender, EventArgs e)
        {
            Model1 md = new Model1();
            //lấy ds hoadon
            List<BAN_CHAM_CONGG> HD = md.BAN_CHAM_CONGG.ToList();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.ReportPath = "./Reportbangchamcong.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("bacngchamcong", HD);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
           
            
        }

        private void Formreportbangchamcong_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Bạn có thật sự muốn thoát ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
