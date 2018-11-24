namespace PhanMemQuanLyThuVien
{
    partial class frmCapNhatLoaiSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapNhatLoaiSach));
            this.btnCancleUpdateLoaiSach = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhatLoaiSach = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenLoaiSachUpdate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiSachUpdate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancleUpdateLoaiSach
            // 
            this.btnCancleUpdateLoaiSach.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancleUpdateLoaiSach.Appearance.Options.UseFont = true;
            this.btnCancleUpdateLoaiSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancleThemSach.ImageOptions.Image")));
            this.btnCancleUpdateLoaiSach.Location = new System.Drawing.Point(290, 158);
            this.btnCancleUpdateLoaiSach.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancleUpdateLoaiSach.Name = "btnCancleUpdateLoaiSach";
            this.btnCancleUpdateLoaiSach.Size = new System.Drawing.Size(105, 38);
            this.btnCancleUpdateLoaiSach.TabIndex = 33;
            this.btnCancleUpdateLoaiSach.Text = "Cancle";
            this.btnCancleUpdateLoaiSach.Click += new System.EventHandler(this.btnCancleUpdateLoaiSach_Click);
            // 
            // btnCapNhatLoaiSach
            // 
            this.btnCapNhatLoaiSach.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatLoaiSach.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSach.Appearance.Image")));
            this.btnCapNhatLoaiSach.Appearance.Options.UseFont = true;
            this.btnCapNhatLoaiSach.Appearance.Options.UseImage = true;
            this.btnCapNhatLoaiSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSach.ImageOptions.Image")));
            this.btnCapNhatLoaiSach.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemSach.ImageOptions.SvgImage")));
            this.btnCapNhatLoaiSach.Location = new System.Drawing.Point(112, 158);
            this.btnCapNhatLoaiSach.Margin = new System.Windows.Forms.Padding(5);
            this.btnCapNhatLoaiSach.Name = "btnCapNhatLoaiSach";
            this.btnCapNhatLoaiSach.Size = new System.Drawing.Size(129, 38);
            this.btnCapNhatLoaiSach.TabIndex = 32;
            this.btnCapNhatLoaiSach.Text = "Cập Nhật";
            this.btnCapNhatLoaiSach.Click += new System.EventHandler(this.btnCapNhatLoaiSach_Click);
            // 
            // txtTenLoaiSachUpdate
            // 
            this.txtTenLoaiSachUpdate.Location = new System.Drawing.Point(178, 95);
            this.txtTenLoaiSachUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenLoaiSachUpdate.Name = "txtTenLoaiSachUpdate";
            this.txtTenLoaiSachUpdate.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiSachUpdate.Properties.Appearance.Options.UseFont = true;
            this.txtTenLoaiSachUpdate.Size = new System.Drawing.Size(233, 26);
            this.txtTenLoaiSachUpdate.TabIndex = 31;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(59, 98);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(97, 20);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "Tên loại sách:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(193, 48);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(200, 24);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "CẬP NHẬT LOẠI SÁCH";
            // 
            // frmCapNhatLoaiSach
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 245);
            this.Controls.Add(this.btnCancleUpdateLoaiSach);
            this.Controls.Add(this.btnCapNhatLoaiSach);
            this.Controls.Add(this.txtTenLoaiSachUpdate);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCapNhatLoaiSach";
            this.Text = "frmCapNhatLoaiSach";
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiSachUpdate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancleUpdateLoaiSach;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatLoaiSach;
        private DevExpress.XtraEditors.TextEdit txtTenLoaiSachUpdate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}