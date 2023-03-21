
namespace do_an_quan_ly_san_bong
{
    partial class flogin
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
            this.textBoxtk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkhienthi = new System.Windows.Forms.CheckBox();
            this.labelnhapmk = new System.Windows.Forms.Label();
            this.textBoxnhapmk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonthoat = new System.Windows.Forms.Button();
            this.buttondangnhap = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.login = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxtk
            // 
            this.textBoxtk.Location = new System.Drawing.Point(164, 33);
            this.textBoxtk.Name = "textBoxtk";
            this.textBoxtk.Size = new System.Drawing.Size(245, 22);
            this.textBoxtk.TabIndex = 0;
            this.textBoxtk.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập Tài Khoản: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxtk);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 79);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkhienthi);
            this.panel2.Controls.Add(this.labelnhapmk);
            this.panel2.Controls.Add(this.textBoxnhapmk);
            this.panel2.Location = new System.Drawing.Point(3, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 79);
            this.panel2.TabIndex = 3;
            // 
            // checkhienthi
            // 
            this.checkhienthi.AutoSize = true;
            this.checkhienthi.Location = new System.Drawing.Point(164, 51);
            this.checkhienthi.Name = "checkhienthi";
            this.checkhienthi.Size = new System.Drawing.Size(195, 21);
            this.checkhienthi.TabIndex = 7;
            this.checkhienthi.Text = "Tích Để Hiển thị Mật Khẩu";
            this.checkhienthi.UseVisualStyleBackColor = true;
            this.checkhienthi.CheckedChanged += new System.EventHandler(this.checkhienthi_CheckedChanged);
            // 
            // labelnhapmk
            // 
            this.labelnhapmk.AutoSize = true;
            this.labelnhapmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnhapmk.Location = new System.Drawing.Point(8, 27);
            this.labelnhapmk.Name = "labelnhapmk";
            this.labelnhapmk.Size = new System.Drawing.Size(133, 18);
            this.labelnhapmk.TabIndex = 1;
            this.labelnhapmk.Text = "Nhập Mật Khẩu: ";
            // 
            // textBoxnhapmk
            // 
            this.textBoxnhapmk.Location = new System.Drawing.Point(164, 23);
            this.textBoxnhapmk.Name = "textBoxnhapmk";
            this.textBoxnhapmk.Size = new System.Drawing.Size(245, 22);
            this.textBoxnhapmk.TabIndex = 0;
            this.textBoxnhapmk.UseSystemPasswordChar = true;
            this.textBoxnhapmk.TextChanged += new System.EventHandler(this.textBoxnhapmk_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(223, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đăng Nhập Vào Hệ Thống";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.login);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.buttonthoat);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.buttondangnhap);
            this.panel3.Location = new System.Drawing.Point(350, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 295);
            this.panel3.TabIndex = 8;
            // 
            // buttonthoat
            // 
            this.buttonthoat.BackgroundImage = global::do_an_quan_ly_san_bong.Properties.Resources.pngtree_logout_icon_vectors_png_image_1737872;
            this.buttonthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonthoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonthoat.Location = new System.Drawing.Point(275, 193);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(108, 66);
            this.buttonthoat.TabIndex = 5;
            this.buttonthoat.UseVisualStyleBackColor = true;
            this.buttonthoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttondangnhap
            // 
            this.buttondangnhap.BackgroundImage = global::do_an_quan_ly_san_bong.Properties.Resources._192_1925162_login_icon_png_transparent_png;
            this.buttondangnhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttondangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondangnhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttondangnhap.Location = new System.Drawing.Point(36, 193);
            this.buttondangnhap.Name = "buttondangnhap";
            this.buttondangnhap.Size = new System.Drawing.Size(108, 66);
            this.buttondangnhap.TabIndex = 4;
            this.buttondangnhap.UseVisualStyleBackColor = true;
            this.buttondangnhap.Click += new System.EventHandler(this.buttondangnhap_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::do_an_quan_ly_san_bong.Properties.Resources.istockphoto_1221661916_1024x1024;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(12, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(332, 295);
            this.panel4.TabIndex = 9;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(68, 262);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(46, 19);
            this.login.TabIndex = 6;
            this.login.Text = "login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(311, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "exit";
            // 
            // flogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.KeyPreview = true;
            this.Name = "flogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.flogin_FormClosing);
            this.Load += new System.EventHandler(this.flogin_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.flogin_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxtk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelnhapmk;
        private System.Windows.Forms.TextBox textBoxnhapmk;
        private System.Windows.Forms.Button buttondangnhap;
        private System.Windows.Forms.Button buttonthoat;
        private System.Windows.Forms.CheckBox checkhienthi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label login;
    }
}

