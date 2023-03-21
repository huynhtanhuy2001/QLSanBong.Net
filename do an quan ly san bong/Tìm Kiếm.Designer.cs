
namespace do_an_quan_ly_san_bong
{
    partial class Tìm_Kiếm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttontimkiemtheoma = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttontheoten = new System.Windows.Forms.Button();
            this.buttontimkiemtheosdt = new System.Windows.Forms.Button();
            this.textSDT = new System.Windows.Forms.TextBox();
            this.textBoxten = new System.Windows.Forms.TextBox();
            this.textBoxmanv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonthoat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnhienthilai = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox2.Location = new System.Drawing.Point(1, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(802, 276);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DS Nhân Viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(796, 255);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tìm Kiếm Nhân Viên";
            // 
            // buttontimkiemtheoma
            // 
            this.buttontimkiemtheoma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttontimkiemtheoma.Location = new System.Drawing.Point(6, 47);
            this.buttontimkiemtheoma.Name = "buttontimkiemtheoma";
            this.buttontimkiemtheoma.Size = new System.Drawing.Size(171, 30);
            this.buttontimkiemtheoma.TabIndex = 19;
            this.buttontimkiemtheoma.Text = "Tìm Kiếm theo Mã";
            this.buttontimkiemtheoma.UseVisualStyleBackColor = true;
            this.buttontimkiemtheoma.Click += new System.EventHandler(this.buttontimkiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttontheoten);
            this.groupBox1.Controls.Add(this.buttontimkiemtheosdt);
            this.groupBox1.Controls.Add(this.textSDT);
            this.groupBox1.Controls.Add(this.buttontimkiemtheoma);
            this.groupBox1.Controls.Add(this.textBoxten);
            this.groupBox1.Controls.Add(this.textBoxmanv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Location = new System.Drawing.Point(305, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 226);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "thông tin cần tìm";
            // 
            // buttontheoten
            // 
            this.buttontheoten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttontheoten.Location = new System.Drawing.Point(6, 106);
            this.buttontheoten.Name = "buttontheoten";
            this.buttontheoten.Size = new System.Drawing.Size(171, 30);
            this.buttontheoten.TabIndex = 21;
            this.buttontheoten.Text = "Tìm Kiếm theo Tên";
            this.buttontheoten.UseVisualStyleBackColor = true;
            this.buttontheoten.Click += new System.EventHandler(this.buttontheoten_Click);
            // 
            // buttontimkiemtheosdt
            // 
            this.buttontimkiemtheosdt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttontimkiemtheosdt.Location = new System.Drawing.Point(6, 165);
            this.buttontimkiemtheosdt.Name = "buttontimkiemtheosdt";
            this.buttontimkiemtheosdt.Size = new System.Drawing.Size(171, 30);
            this.buttontimkiemtheosdt.TabIndex = 20;
            this.buttontimkiemtheosdt.Text = "Tìm Kiếm theo SDT";
            this.buttontimkiemtheosdt.UseVisualStyleBackColor = true;
            this.buttontimkiemtheosdt.Click += new System.EventHandler(this.buttontimkiemtheosdt_Click);
            // 
            // textSDT
            // 
            this.textSDT.Location = new System.Drawing.Point(281, 169);
            this.textSDT.Name = "textSDT";
            this.textSDT.Size = new System.Drawing.Size(207, 22);
            this.textSDT.TabIndex = 2;
            // 
            // textBoxten
            // 
            this.textBoxten.Location = new System.Drawing.Point(281, 108);
            this.textBoxten.Name = "textBoxten";
            this.textBoxten.Size = new System.Drawing.Size(207, 22);
            this.textBoxten.TabIndex = 2;
            // 
            // textBoxmanv
            // 
            this.textBoxmanv.Location = new System.Drawing.Point(281, 47);
            this.textBoxmanv.Name = "textBoxmanv";
            this.textBoxmanv.Size = new System.Drawing.Size(207, 22);
            this.textBoxmanv.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(216, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "SDT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(207, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên nv: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(210, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã NV: ";
            // 
            // buttonthoat
            // 
            this.buttonthoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonthoat.Location = new System.Drawing.Point(35, 130);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(134, 41);
            this.buttonthoat.TabIndex = 21;
            this.buttonthoat.Text = "Thoát";
            this.buttonthoat.UseVisualStyleBackColor = true;
            this.buttonthoat.Click += new System.EventHandler(this.buttonthoat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnhienthilai);
            this.groupBox3.Controls.Add(this.buttonthoat);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox3.Location = new System.Drawing.Point(99, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 226);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // btnhienthilai
            // 
            this.btnhienthilai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnhienthilai.Location = new System.Drawing.Point(35, 73);
            this.btnhienthilai.Name = "btnhienthilai";
            this.btnhienthilai.Size = new System.Drawing.Size(134, 42);
            this.btnhienthilai.TabIndex = 22;
            this.btnhienthilai.Text = "Hiển Thị Lại DS";
            this.btnhienthilai.UseVisualStyleBackColor = true;
            this.btnhienthilai.Click += new System.EventHandler(this.btnhienthilai_Click);
            // 
            // Tìm_Kiếm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(805, 596);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Tìm_Kiếm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm_Kiếm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tìm_Kiếm_FormClosing);
            this.Load += new System.EventHandler(this.Tìm_Kiếm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tìm_Kiếm_KeyUp);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttontimkiemtheoma;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxmanv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonthoat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnhienthilai;
        private System.Windows.Forms.TextBox textBoxten;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttontheoten;
        private System.Windows.Forms.Button buttontimkiemtheosdt;
    }
}