
namespace do_an_quan_ly_san_bong
{
    partial class FchucVuNV
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listViewtk = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textmaCV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.texttenCV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonthoat = new System.Windows.Forms.Button();
            this.buttonhuy = new System.Windows.Forms.Button();
            this.buttonluu = new System.Windows.Forms.Button();
            this.buttonsua = new System.Windows.Forms.Button();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.buttonthem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listViewtk);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox3.Location = new System.Drawing.Point(370, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 424);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Chức Vụ";
            // 
            // listViewtk
            // 
            this.listViewtk.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewtk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewtk.FullRowSelect = true;
            this.listViewtk.GridLines = true;
            this.listViewtk.HideSelection = false;
            this.listViewtk.Location = new System.Drawing.Point(3, 18);
            this.listViewtk.Name = "listViewtk";
            this.listViewtk.Size = new System.Drawing.Size(421, 403);
            this.listViewtk.TabIndex = 10;
            this.listViewtk.UseCompatibleStateImageBehavior = false;
            this.listViewtk.View = System.Windows.Forms.View.Details;
            this.listViewtk.SelectedIndexChanged += new System.EventHandler(this.listViewtk_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Chức Vụ";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Chức Vụ";
            this.columnHeader2.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textmaCV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.texttenCV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Location = new System.Drawing.Point(26, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 172);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin";
            // 
            // textmaCV
            // 
            this.textmaCV.Location = new System.Drawing.Point(131, 50);
            this.textmaCV.Name = "textmaCV";
            this.textmaCV.Size = new System.Drawing.Size(164, 22);
            this.textmaCV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(54, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã CV: ";
            // 
            // texttenCV
            // 
            this.texttenCV.Location = new System.Drawing.Point(131, 102);
            this.texttenCV.Name = "texttenCV";
            this.texttenCV.Size = new System.Drawing.Size(164, 22);
            this.texttenCV.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(54, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên CV:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonthoat);
            this.groupBox2.Controls.Add(this.buttonhuy);
            this.groupBox2.Controls.Add(this.buttonluu);
            this.groupBox2.Controls.Add(this.buttonsua);
            this.groupBox2.Controls.Add(this.buttonxoa);
            this.groupBox2.Controls.Add(this.buttonthem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox2.Location = new System.Drawing.Point(26, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 234);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // buttonthoat
            // 
            this.buttonthoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonthoat.Location = new System.Drawing.Point(223, 146);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(88, 40);
            this.buttonthoat.TabIndex = 8;
            this.buttonthoat.Text = "Thoát";
            this.buttonthoat.UseVisualStyleBackColor = true;
            this.buttonthoat.Click += new System.EventHandler(this.buttonthoat_Click);
            // 
            // buttonhuy
            // 
            this.buttonhuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonhuy.Location = new System.Drawing.Point(121, 146);
            this.buttonhuy.Name = "buttonhuy";
            this.buttonhuy.Size = new System.Drawing.Size(85, 40);
            this.buttonhuy.TabIndex = 7;
            this.buttonhuy.Text = "Hủy";
            this.buttonhuy.UseVisualStyleBackColor = true;
            this.buttonhuy.Click += new System.EventHandler(this.buttonhuy_Click);
            // 
            // buttonluu
            // 
            this.buttonluu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonluu.Location = new System.Drawing.Point(16, 146);
            this.buttonluu.Name = "buttonluu";
            this.buttonluu.Size = new System.Drawing.Size(85, 40);
            this.buttonluu.TabIndex = 6;
            this.buttonluu.Text = "Lưu";
            this.buttonluu.UseVisualStyleBackColor = true;
            this.buttonluu.Click += new System.EventHandler(this.buttonluu_Click);
            // 
            // buttonsua
            // 
            this.buttonsua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonsua.Location = new System.Drawing.Point(223, 56);
            this.buttonsua.Name = "buttonsua";
            this.buttonsua.Size = new System.Drawing.Size(88, 40);
            this.buttonsua.TabIndex = 5;
            this.buttonsua.Text = "Sửa";
            this.buttonsua.UseVisualStyleBackColor = true;
            this.buttonsua.Click += new System.EventHandler(this.buttonsua_Click);
            // 
            // buttonxoa
            // 
            this.buttonxoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonxoa.Location = new System.Drawing.Point(121, 56);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(85, 40);
            this.buttonxoa.TabIndex = 4;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = true;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click);
            // 
            // buttonthem
            // 
            this.buttonthem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonthem.Location = new System.Drawing.Point(16, 56);
            this.buttonthem.Name = "buttonthem";
            this.buttonthem.Size = new System.Drawing.Size(85, 40);
            this.buttonthem.TabIndex = 3;
            this.buttonthem.Text = "Thêm";
            this.buttonthem.UseVisualStyleBackColor = true;
            this.buttonthem.Click += new System.EventHandler(this.buttonthem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(243, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 33);
            this.label3.TabIndex = 13;
            this.label3.Text = "Danh Sách Chức Vụ";
            // 
            // FchucVuNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FchucVuNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FchucVuNV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FchucVuNV_FormClosing);
            this.Load += new System.EventHandler(this.FchucVuNV_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listViewtk;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textmaCV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texttenCV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonthem;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.Button buttonsua;
        private System.Windows.Forms.Button buttonluu;
        private System.Windows.Forms.Button buttonhuy;
        private System.Windows.Forms.Button buttonthoat;
        private System.Windows.Forms.Label label3;
    }
}