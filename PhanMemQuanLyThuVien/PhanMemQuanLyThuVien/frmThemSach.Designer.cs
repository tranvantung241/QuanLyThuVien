﻿namespace PhanMemQuanLyThuVien
{
    partial class frmThemSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemSach));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new DevExpress.XtraEditors.SimpleButton();
            this.txtGia = new DevExpress.XtraEditors.TextEdit();
            this.txtTenSach = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnThemSach = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancleThemSach = new DevExpress.XtraEditors.SimpleButton();
            this.cboLoaiSach = new System.Windows.Forms.ComboBox();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSach.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.pictureBox1);
            this.groupControl1.Location = new System.Drawing.Point(459, 70);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(190, 239);
            this.groupControl1.TabIndex = 21;
            this.groupControl1.Text = "Hình Ảnh";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(2, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 217);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonAnh.Appearance.Options.UseFont = true;
            this.btnChonAnh.Location = new System.Drawing.Point(160, 276);
            this.btnChonAnh.Margin = new System.Windows.Forms.Padding(5);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(233, 33);
            this.btnChonAnh.TabIndex = 20;
            this.btnChonAnh.Text = "Choose Image";
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(160, 174);
            this.txtGia.Margin = new System.Windows.Forms.Padding(5);
            this.txtGia.Name = "txtGia";
            this.txtGia.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Properties.Appearance.Options.UseFont = true;
            this.txtGia.Size = new System.Drawing.Size(233, 26);
            this.txtGia.TabIndex = 16;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(160, 70);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Properties.Appearance.Options.UseFont = true;
            this.txtTenSach.Size = new System.Drawing.Size(233, 26);
            this.txtTenSach.TabIndex = 17;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(38, 285);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(68, 20);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Hình ảnh:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(38, 126);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(72, 20);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Loại sách:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(38, 177);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(29, 20);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Giá:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(38, 228);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 20);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Tình trạng:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(38, 73);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 20);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Tên sách:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(251, 24);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(112, 24);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "THÊM SÁCH";
            // 
            // btnThemSach
            // 
            this.btnThemSach.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSach.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSach.Appearance.Image")));
            this.btnThemSach.Appearance.Options.UseFont = true;
            this.btnThemSach.Appearance.Options.UseImage = true;
            this.btnThemSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSach.ImageOptions.Image")));
            this.btnThemSach.Location = new System.Drawing.Point(202, 342);
            this.btnThemSach.Margin = new System.Windows.Forms.Padding(5);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(108, 38);
            this.btnThemSach.TabIndex = 22;
            this.btnThemSach.Text = "Thêm";
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // btnCancleThemSach
            // 
            this.btnCancleThemSach.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancleThemSach.Appearance.Options.UseFont = true;
            this.btnCancleThemSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancleThemSach.ImageOptions.Image")));
            this.btnCancleThemSach.Location = new System.Drawing.Point(397, 342);
            this.btnCancleThemSach.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancleThemSach.Name = "btnCancleThemSach";
            this.btnCancleThemSach.Size = new System.Drawing.Size(105, 38);
            this.btnCancleThemSach.TabIndex = 23;
            this.btnCancleThemSach.Text = "Cancle";
            this.btnCancleThemSach.Click += new System.EventHandler(this.btnCancleThemSach_Click);
            // 
            // cboLoaiSach
            // 
            this.cboLoaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiSach.FormattingEnabled = true;
            this.cboLoaiSach.Location = new System.Drawing.Point(160, 126);
            this.cboLoaiSach.Margin = new System.Windows.Forms.Padding(5);
            this.cboLoaiSach.Name = "cboLoaiSach";
            this.cboLoaiSach.Size = new System.Drawing.Size(233, 28);
            this.cboLoaiSach.TabIndex = 24;
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Items.AddRange(new object[] {
            "Mới"});
            this.cboTinhTrang.Location = new System.Drawing.Point(160, 228);
            this.cboTinhTrang.Margin = new System.Windows.Forms.Padding(5);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(233, 28);
            this.cboTinhTrang.TabIndex = 24;
            // 
            // frmThemSach
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 418);
            this.Controls.Add(this.cboTinhTrang);
            this.Controls.Add(this.cboLoaiSach);
            this.Controls.Add(this.btnCancleThemSach);
            this.Controls.Add(this.btnThemSach);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmThemSach";
            this.Text = "Thêm Sách"; 
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSach.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnChonAnh;
        private DevExpress.XtraEditors.TextEdit txtGia;
        private DevExpress.XtraEditors.TextEdit txtTenSach;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnThemSach;
        private DevExpress.XtraEditors.SimpleButton btnCancleThemSach;
        private System.Windows.Forms.ComboBox cboLoaiSach;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}