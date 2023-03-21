
namespace do_an_quan_ly_san_bong
{
    partial class Danh_Sách_Nhân_Viên
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
            this.combochucvu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radionu = new System.Windows.Forms.RadioButton();
            this.radionam = new System.Windows.Forms.RadioButton();
            this.datengay = new System.Windows.Forms.DateTimePicker();
            this.textdiachi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textsdt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.texttennv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textmanv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewNV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.buttonthoat = new System.Windows.Forms.Button();
            this.buttonthem = new System.Windows.Forms.Button();
            this.buttonluu = new System.Windows.Forms.Button();
            this.buttonhuy = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonIN = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxtimkiemma = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttontimkiemtheoteen = new System.Windows.Forms.Button();
            this.textBoxtimSDT = new System.Windows.Forms.TextBox();
            this.textBoxtimten = new System.Windows.Forms.TextBox();
            this.textslnv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // combochucvu
            // 
            this.combochucvu.FormattingEnabled = true;
            this.combochucvu.Location = new System.Drawing.Point(92, 153);
            this.combochucvu.Name = "combochucvu";
            this.combochucvu.Size = new System.Drawing.Size(201, 24);
            this.combochucvu.TabIndex = 3;
            this.combochucvu.SelectedIndexChanged += new System.EventHandler(this.combochucvu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(359, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Nhân Viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combochucvu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.radionu);
            this.groupBox1.Controls.Add(this.radionam);
            this.groupBox1.Controls.Add(this.datengay);
            this.groupBox1.Controls.Add(this.textdiachi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textsdt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.texttennv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textmanv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Location = new System.Drawing.Point(103, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(889, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin cần nhập";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Giới tính: ";
            // 
            // radionu
            // 
            this.radionu.AutoSize = true;
            this.radionu.BackColor = System.Drawing.SystemColors.Control;
            this.radionu.ForeColor = System.Drawing.Color.Black;
            this.radionu.Location = new System.Drawing.Point(220, 201);
            this.radionu.Name = "radionu";
            this.radionu.Size = new System.Drawing.Size(74, 21);
            this.radionu.TabIndex = 4;
            this.radionu.TabStop = true;
            this.radionu.Text = "  Nữ   ";
            this.radionu.UseVisualStyleBackColor = false;
            // 
            // radionam
            // 
            this.radionam.AutoSize = true;
            this.radionam.BackColor = System.Drawing.SystemColors.Control;
            this.radionam.ForeColor = System.Drawing.Color.Black;
            this.radionam.Location = new System.Drawing.Point(109, 201);
            this.radionam.Name = "radionam";
            this.radionam.Size = new System.Drawing.Size(71, 21);
            this.radionam.TabIndex = 4;
            this.radionam.TabStop = true;
            this.radionam.Text = "  Nam";
            this.radionam.UseVisualStyleBackColor = false;
            this.radionam.CheckedChanged += new System.EventHandler(this.radionam_CheckedChanged);
            // 
            // datengay
            // 
            this.datengay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengay.Location = new System.Drawing.Point(572, 158);
            this.datengay.Name = "datengay";
            this.datengay.Size = new System.Drawing.Size(208, 22);
            this.datengay.TabIndex = 8;
            this.datengay.Value = new System.DateTime(2021, 10, 22, 0, 0, 0, 0);
            this.datengay.ValueChanged += new System.EventHandler(this.datengay_ValueChanged);
            // 
            // textdiachi
            // 
            this.textdiachi.Location = new System.Drawing.Point(572, 51);
            this.textdiachi.Name = "textdiachi";
            this.textdiachi.Size = new System.Drawing.Size(208, 22);
            this.textdiachi.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(460, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Địa Chỉ";
            // 
            // textsdt
            // 
            this.textsdt.Location = new System.Drawing.Point(572, 104);
            this.textsdt.Name = "textsdt";
            this.textsdt.Size = new System.Drawing.Size(208, 22);
            this.textsdt.TabIndex = 7;
            this.textsdt.TextChanged += new System.EventHandler(this.textsdt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(461, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Số ĐT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(461, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày Sinh:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chức Vụ:";
            // 
            // texttennv
            // 
            this.texttennv.Location = new System.Drawing.Point(93, 99);
            this.texttennv.Name = "texttennv";
            this.texttennv.Size = new System.Drawing.Size(201, 22);
            this.texttennv.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên NV: ";
            // 
            // textmanv
            // 
            this.textmanv.Location = new System.Drawing.Point(93, 46);
            this.textmanv.Name = "textmanv";
            this.textmanv.Size = new System.Drawing.Size(201, 22);
            this.textmanv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã NV: ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(486, 314);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(8, 8);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewNV);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox2.Location = new System.Drawing.Point(85, 543);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(907, 276);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DS Nhân Viên";
            // 
            // listViewNV
            // 
            this.listViewNV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewNV.FullRowSelect = true;
            this.listViewNV.GridLines = true;
            this.listViewNV.HideSelection = false;
            this.listViewNV.Location = new System.Drawing.Point(3, 18);
            this.listViewNV.Name = "listViewNV";
            this.listViewNV.Size = new System.Drawing.Size(901, 255);
            this.listViewNV.TabIndex = 15;
            this.listViewNV.UseCompatibleStateImageBehavior = false;
            this.listViewNV.View = System.Windows.Forms.View.Details;
            this.listViewNV.SelectedIndexChanged += new System.EventHandler(this.listViewNV_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã nv";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên nv";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Chức Vụ";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SDT";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Địa chỉ";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngày Sinh";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "giới tính";
            this.columnHeader7.Width = 120;
            // 
            // buttonSua
            // 
            this.buttonSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSua.Location = new System.Drawing.Point(262, 21);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(98, 41);
            this.buttonSua.TabIndex = 11;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonxoa
            // 
            this.buttonxoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonxoa.Location = new System.Drawing.Point(148, 21);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(98, 41);
            this.buttonxoa.TabIndex = 10;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = true;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click);
            // 
            // buttonthoat
            // 
            this.buttonthoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonthoat.Location = new System.Drawing.Point(735, 21);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(98, 41);
            this.buttonthoat.TabIndex = 13;
            this.buttonthoat.Text = "Thoát";
            this.buttonthoat.UseVisualStyleBackColor = true;
            this.buttonthoat.Click += new System.EventHandler(this.buttonthoat_Click);
            // 
            // buttonthem
            // 
            this.buttonthem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonthem.Location = new System.Drawing.Point(25, 21);
            this.buttonthem.Name = "buttonthem";
            this.buttonthem.Size = new System.Drawing.Size(98, 41);
            this.buttonthem.TabIndex = 9;
            this.buttonthem.Text = "Thêm";
            this.buttonthem.UseVisualStyleBackColor = true;
            this.buttonthem.Click += new System.EventHandler(this.buttonthem_Click);
            // 
            // buttonluu
            // 
            this.buttonluu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonluu.Location = new System.Drawing.Point(376, 21);
            this.buttonluu.Name = "buttonluu";
            this.buttonluu.Size = new System.Drawing.Size(98, 41);
            this.buttonluu.TabIndex = 17;
            this.buttonluu.Text = "Lưu";
            this.buttonluu.UseVisualStyleBackColor = true;
            this.buttonluu.Click += new System.EventHandler(this.buttonluu_Click);
            // 
            // buttonhuy
            // 
            this.buttonhuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonhuy.Location = new System.Drawing.Point(492, 21);
            this.buttonhuy.Name = "buttonhuy";
            this.buttonhuy.Size = new System.Drawing.Size(98, 41);
            this.buttonhuy.TabIndex = 18;
            this.buttonhuy.Text = "Hủy";
            this.buttonhuy.UseVisualStyleBackColor = true;
            this.buttonhuy.Click += new System.EventHandler(this.buttonhuy_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonIN);
            this.groupBox3.Controls.Add(this.buttonthoat);
            this.groupBox3.Controls.Add(this.buttonthem);
            this.groupBox3.Controls.Add(this.buttonhuy);
            this.groupBox3.Controls.Add(this.buttonxoa);
            this.groupBox3.Controls.Add(this.buttonSua);
            this.groupBox3.Controls.Add(this.buttonluu);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox3.Location = new System.Drawing.Point(103, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(889, 81);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // buttonIN
            // 
            this.buttonIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonIN.Location = new System.Drawing.Point(615, 21);
            this.buttonIN.Name = "buttonIN";
            this.buttonIN.Size = new System.Drawing.Size(98, 41);
            this.buttonIN.TabIndex = 19;
            this.buttonIN.Text = "IN";
            this.buttonIN.UseVisualStyleBackColor = true;
            this.buttonIN.Click += new System.EventHandler(this.buttonIN_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.textBoxtimkiemma);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.buttontimkiemtheoteen);
            this.groupBox4.Controls.Add(this.textBoxtimSDT);
            this.groupBox4.Controls.Add(this.textBoxtimten);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox4.Location = new System.Drawing.Point(103, 410);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(795, 127);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm Kiếm";
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Location = new System.Drawing.Point(421, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 39);
            this.button3.TabIndex = 15;
            this.button3.Text = "Tìm Kiếm theo Mã";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxtimkiemma
            // 
            this.textBoxtimkiemma.Location = new System.Drawing.Point(605, 37);
            this.textBoxtimkiemma.Name = "textBoxtimkiemma";
            this.textBoxtimkiemma.Size = new System.Drawing.Size(175, 22);
            this.textBoxtimkiemma.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(421, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(359, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "Hiển Thị Lại DS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(43, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Tìm kiếm theo SDT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttontimkiemtheoteen
            // 
            this.buttontimkiemtheoteen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttontimkiemtheoteen.Location = new System.Drawing.Point(43, 29);
            this.buttontimkiemtheoteen.Name = "buttontimkiemtheoteen";
            this.buttontimkiemtheoteen.Size = new System.Drawing.Size(169, 39);
            this.buttontimkiemtheoteen.TabIndex = 2;
            this.buttontimkiemtheoteen.Text = "Tìm Kiếm theo Tên";
            this.buttontimkiemtheoteen.UseVisualStyleBackColor = true;
            this.buttontimkiemtheoteen.Click += new System.EventHandler(this.buttontimkiemtheoteen_Click);
            // 
            // textBoxtimSDT
            // 
            this.textBoxtimSDT.Location = new System.Drawing.Point(218, 82);
            this.textBoxtimSDT.Name = "textBoxtimSDT";
            this.textBoxtimSDT.Size = new System.Drawing.Size(169, 22);
            this.textBoxtimSDT.TabIndex = 1;
            // 
            // textBoxtimten
            // 
            this.textBoxtimten.Location = new System.Drawing.Point(218, 37);
            this.textBoxtimten.Name = "textBoxtimten";
            this.textBoxtimten.Size = new System.Drawing.Size(169, 22);
            this.textBoxtimten.TabIndex = 1;
            // 
            // textslnv
            // 
            this.textslnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textslnv.Location = new System.Drawing.Point(476, 827);
            this.textslnv.Name = "textslnv";
            this.textslnv.ReadOnly = true;
            this.textslnv.Size = new System.Drawing.Size(175, 22);
            this.textslnv.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(320, 830);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Số lượng nhân viên:";
            // 
            // Danh_Sách_Nhân_Viên
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1086, 882);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textslnv);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Danh_Sách_Nhân_Viên";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh_Sách_Nhân_Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Danh_Sách_Nhân_Viên_FormClosing);
            this.Load += new System.EventHandler(this.Danh_Sách_Nhân_Viên_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox texttennv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textmanv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textsdt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textdiachi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listViewNV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.DateTimePicker datengay;
        private System.Windows.Forms.RadioButton radionu;
        private System.Windows.Forms.RadioButton radionam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.Button buttonthoat;
        private System.Windows.Forms.Button buttonthem;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button buttonluu;
        private System.Windows.Forms.Button buttonhuy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonIN;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttontimkiemtheoteen;
        private System.Windows.Forms.TextBox textBoxtimSDT;
        private System.Windows.Forms.TextBox textBoxtimten;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxtimkiemma;
        private System.Windows.Forms.ComboBox combochucvu;
        private System.Windows.Forms.TextBox textslnv;
        private System.Windows.Forms.Label label9;
    }
}