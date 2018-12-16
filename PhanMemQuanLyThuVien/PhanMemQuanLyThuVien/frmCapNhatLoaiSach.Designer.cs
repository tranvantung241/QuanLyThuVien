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
            this.btnCapNhatLoaiSach = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenLoaiSachUpdate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiSachUpdate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapNhatLoaiSach
            // 
            this.btnCapNhatLoaiSach.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatLoaiSach.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatLoaiSach.Appearance.Image")));
            this.btnCapNhatLoaiSach.Appearance.Options.UseFont = true;
            this.btnCapNhatLoaiSach.Appearance.Options.UseImage = true;
            this.btnCapNhatLoaiSach.Location = new System.Drawing.Point(142, 128);
            this.btnCapNhatLoaiSach.Margin = new System.Windows.Forms.Padding(5);
            this.btnCapNhatLoaiSach.Name = "btnCapNhatLoaiSach";
            this.btnCapNhatLoaiSach.Size = new System.Drawing.Size(104, 26);
            this.btnCapNhatLoaiSach.TabIndex = 32;
            this.btnCapNhatLoaiSach.Text = "Cập Nhật";
            this.btnCapNhatLoaiSach.Click += new System.EventHandler(this.btnCapNhatLoaiSach_Click);
            // 
            // txtTenLoaiSachUpdate
            // 
            this.txtTenLoaiSachUpdate.Location = new System.Drawing.Point(137, 74);
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
            this.labelControl2.Location = new System.Drawing.Point(14, 77);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(97, 20);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "Tên loại sách:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(92, 28);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(218, 24);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "CẬP NHẬT LOẠI SÁCH";
            // 
            // frmCapNhatLoaiSach
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 182);
            this.Controls.Add(this.btnCapNhatLoaiSach);
            this.Controls.Add(this.txtTenLoaiSachUpdate);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmCapNhatLoaiSach";
            this.Text = "Cập Nhật Loại  Sách";
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiSachUpdate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnCapNhatLoaiSach;
        private DevExpress.XtraEditors.TextEdit txtTenLoaiSachUpdate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}