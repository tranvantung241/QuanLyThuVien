namespace PhanMemQuanLyThuVien
{
    partial class frmThemDocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemDocGia));
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.btnCancleThemSach = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemSach = new DevExpress.XtraEditors.SimpleButton();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtTenDocGia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.dateNgaySinh = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDocGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(187, 187);
            this.cboGioiTinh.Margin = new System.Windows.Forms.Padding(5);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(233, 28);
            this.cboGioiTinh.TabIndex = 37;
            // 
            // btnCancleThemSach
            // 
            this.btnCancleThemSach.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancleThemSach.Appearance.Options.UseFont = true;
            this.btnCancleThemSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancleThemSach.ImageOptions.Image")));
            this.btnCancleThemSach.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancleThemSach.ImageOptions.SvgImage")));
            this.btnCancleThemSach.Location = new System.Drawing.Point(315, 365);
            this.btnCancleThemSach.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancleThemSach.Name = "btnCancleThemSach";
            this.btnCancleThemSach.Size = new System.Drawing.Size(105, 38);
            this.btnCancleThemSach.TabIndex = 36;
            this.btnCancleThemSach.Text = "Cancle";
            // 
            // btnThemSach
            // 
            this.btnThemSach.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSach.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSach.Appearance.Image")));
            this.btnThemSach.Appearance.Options.UseFont = true;
            this.btnThemSach.Appearance.Options.UseImage = true;
            this.btnThemSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSach.ImageOptions.Image")));
            this.btnThemSach.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemSach.ImageOptions.SvgImage")));
            this.btnThemSach.Location = new System.Drawing.Point(65, 365);
            this.btnThemSach.Margin = new System.Windows.Forms.Padding(5);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(108, 38);
            this.btnThemSach.TabIndex = 35;
            this.btnThemSach.Text = "Thêm";
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(187, 237);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Size = new System.Drawing.Size(233, 26);
            this.txtDiaChi.TabIndex = 31;
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.Location = new System.Drawing.Point(187, 85);
            this.txtTenDocGia.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDocGia.Properties.Appearance.Options.UseFont = true;
            this.txtTenDocGia.Size = new System.Drawing.Size(233, 26);
            this.txtTenDocGia.TabIndex = 32;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(65, 195);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(62, 20);
            this.labelControl5.TabIndex = 29;
            this.labelControl5.Text = "Giới tính:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(65, 243);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 20);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "Địa chỉ:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(65, 141);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 20);
            this.labelControl3.TabIndex = 27;
            this.labelControl3.Text = "Ngày sinh:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(65, 88);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 20);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Tên độc giả:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(164, 24);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(137, 24);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "THÊM ĐỘC GIẢ";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(65, 295);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(101, 20);
            this.labelControl7.TabIndex = 39;
            this.labelControl7.Text = "Số  điện thoại:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(187, 289);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Properties.Appearance.Options.UseFont = true;
            this.txtSDT.Size = new System.Drawing.Size(233, 26);
            this.txtSDT.TabIndex = 31;
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.EditValue = null;
            this.dateNgaySinh.Location = new System.Drawing.Point(187, 140);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgaySinh.Properties.Appearance.Options.UseFont = true;
            this.dateNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinh.Size = new System.Drawing.Size(233, 26);
            this.dateNgaySinh.TabIndex = 40;
            // 
            // frmThemDocGia
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 449);
            this.Controls.Add(this.dateNgaySinh);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.btnCancleThemSach);
            this.Controls.Add(this.btnThemSach);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenDocGia);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmThemDocGia";
            this.Text = "Thêm Độc Giả";
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDocGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private DevExpress.XtraEditors.SimpleButton btnCancleThemSach;
        private DevExpress.XtraEditors.SimpleButton btnThemSach;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtTenDocGia;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.DateEdit dateNgaySinh;
    }
}