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
    public partial class FormreportPHIEUDATSAN : Form
    {
        public FormreportPHIEUDATSAN()
        {
            InitializeComponent();
        }

        private void FormreportPHIEUDATSAN_Load(object sender, EventArgs e)
        {
            Model1 md = new Model1();
            //lấy ds hoadon
            List<PHIEU_DAT_SAN> HD = md.PHIEU_DAT_SAN.ToList();
         
           this.reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.ReportPath = "./Report1.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("phieudatsan", HD);          
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);          
            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void FormreportPHIEUDATSAN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
