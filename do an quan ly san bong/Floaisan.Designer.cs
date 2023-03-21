
namespace do_an_quan_ly_san_bong
{
    partial class Floaisan
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
            this.components = new System.ComponentModel.Container();
            this.lOAISANTableAdapter = new do_an_quan_ly_san_bong.DataSet1TableAdapters.LOAISANTableAdapter();
            this.buttonhuy = new System.Windows.Forms.Button();
            this.buttonluu = new System.Windows.Forms.Button();
            this.buttonsua = new System.Windows.Forms.Button();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.buttonthem = new System.Windows.Forms.Button();
            this.lOAISANBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new do_an_quan_ly_san_bong.DataSet1();
            this.buttonthoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textgialoai = new System.Windows.Forms.TextBox();
            this.textloaisan = new System.Windows.Forms.TextBox();
            this.lOAISANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOAISANBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewtk = new System.Windows.Forms.ListView();
            this.lOAISANBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISANBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISANBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISANBindingSource2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lOAISANTableAdapter
            // 
            this.lOAISANTableAdapter.ClearBeforeFill = true;
            // 
            // buttonhuy
            // 
            this.buttonhuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonhuy.Location = new System.Drawing.Point(121, 146);
            this.buttonhuy.Name = "buttonhuy";
            this.buttonhuy.Size = new System.Drawing.Size(85, 40);
            this.buttonhuy.TabIndex = 8;
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
            this.buttonluu.TabIndex = 7;
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
            this.buttonsua.TabIndex = 6;
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
            this.buttonxoa.TabIndex = 5;
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
            this.buttonthem.TabIndex = 4;
            this.buttonthem.Text = "Thêm";
            this.buttonthem.UseVisualStyleBackColor = true;
            this.buttonthem.Click += new System.EventHandler(this.buttonthem_Click);
            // 
            // lOAISANBindingSource3
            // 
            this.lOAISANBindingSource3.DataMember = "LOAISAN";
            this.lOAISANBindingSource3.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonthoat
            // 
            this.buttonthoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonthoat.Location = new System.Drawing.Point(223, 146);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(88, 40);
            this.buttonthoat.TabIndex = 9;
            this.buttonthoat.Text = "Thoát";
            this.buttonthoat.UseVisualStyleBackColor = true;
            this.buttonthoat.Click += new System.EventHandler(this.buttonthoat_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(44, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 217);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // textgialoai
            // 
            this.textgialoai.Location = new System.Drawing.Point(131, 134);
            this.textgialoai.Name = "textgialoai";
            this.textgialoai.Size = new System.Drawing.Size(164, 22);
            this.textgialoai.TabIndex = 3;
            // 
            // textloaisan
            // 
            this.textloaisan.Location = new System.Drawing.Point(131, 51);
            this.textloaisan.Name = "textloaisan";
            this.textloaisan.Size = new System.Drawing.Size(164, 22);
            this.textloaisan.TabIndex = 1;
            // 
            // lOAISANBindingSource
            // 
            this.lOAISANBindingSource.DataMember = "LOAISAN";
            // 
            // lOAISANBindingSource1
            // 
            this.lOAISANBindingSource1.DataMember = "LOAISAN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(38, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gia loại: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(38, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên loại : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(276, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 33);
            this.label3.TabIndex = 20;
            this.label3.Text = "Danh sách Loại Sân";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textgialoai);
            this.groupBox1.Controls.Add(this.textloaisan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Location = new System.Drawing.Point(44, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 201);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "giá loại";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên loại";
            this.columnHeader1.Width = 200;
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
            this.listViewtk.Size = new System.Drawing.Size(419, 403);
            this.listViewtk.TabIndex = 10;
            this.listViewtk.UseCompatibleStateImageBehavior = false;
            this.listViewtk.View = System.Windows.Forms.View.Details;
            this.listViewtk.SelectedIndexChanged += new System.EventHandler(this.listViewtk_SelectedIndexChanged);
            // 
            // lOAISANBindingSource2
            // 
            this.lOAISANBindingSource2.DataMember = "LOAISAN";
            this.lOAISANBindingSource2.DataSource = this.dataSet1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listViewtk);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox3.Location = new System.Drawing.Point(386, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(425, 424);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách loại sân";
            // 
            // Floaisan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(823, 503);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Floaisan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Floaisan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Floaisan_FormClosing);
            this.Load += new System.EventHandler(this.Floaisan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOAISANBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lOAISANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISANBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISANBindingSource2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1TableAdapters.LOAISANTableAdapter lOAISANTableAdapter;
        private System.Windows.Forms.Button buttonhuy;
        private System.Windows.Forms.Button buttonluu;
        private System.Windows.Forms.Button buttonsua;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.Button buttonthem;
        private System.Windows.Forms.BindingSource lOAISANBindingSource3;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Button buttonthoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textgialoai;
        private System.Windows.Forms.TextBox textloaisan;
        private System.Windows.Forms.BindingSource lOAISANBindingSource;
        private System.Windows.Forms.BindingSource lOAISANBindingSource1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listViewtk;
        private System.Windows.Forms.BindingSource lOAISANBindingSource2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}