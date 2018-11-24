namespace PhanMemQuanLyThuVien
{
    partial class frmThemLoaiSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemLoaiSach));
            this.btnCancleThemSach = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemLoaiSach = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenLoaiSach = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiSach.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancleThemSach
            // 
            this.btnCancleThemSach.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancleThemSach.Appearance.Options.UseFont = true;
            this.btnCancleThemSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancleThemSach.ImageOptions.Image")));
            this.btnCancleThemSach.Location = new System.Drawing.Point(270, 124);
            this.btnCancleThemSach.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancleThemSach.Name = "btnCancleThemSach";
            this.btnCancleThemSach.Size = new System.Drawing.Size(105, 38);
            this.btnCancleThemSach.TabIndex = 28;
            this.btnCancleThemSach.Text = "Cancle";
            this.btnCancleThemSach.Click += new System.EventHandler(this.btnCancleThemSach_Click);
            // 
            // btnThemLoaiSach
            // 
            this.btnThemLoaiSach.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoaiSach.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLoaiSach.Appearance.Image")));
            this.btnThemLoaiSach.Appearance.Options.UseFont = true;
            this.btnThemLoaiSach.Appearance.Options.UseImage = true;
            this.btnThemLoaiSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLoaiSach.ImageOptions.Image")));
            this.btnThemLoaiSach.Location = new System.Drawing.Point(92, 124);
            this.btnThemLoaiSach.Margin = new System.Windows.Forms.Padding(5);
            this.btnThemLoaiSach.Name = "btnThemLoaiSach";
            this.btnThemLoaiSach.Size = new System.Drawing.Size(108, 38);
            this.btnThemLoaiSach.TabIndex = 27;
            this.btnThemLoaiSach.Text = "Thêm";
            this.btnThemLoaiSach.Click += new System.EventHandler(this.btnThemLoaiSach_Click_1);
            // 
            // txtTenLoaiSach
            // 
            this.txtTenLoaiSach.Location = new System.Drawing.Point(158, 61);
            this.txtTenLoaiSach.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenLoaiSach.Name = "txtTenLoaiSach";
            this.txtTenLoaiSach.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiSach.Properties.Appearance.Options.UseFont = true;
            this.txtTenLoaiSach.Size = new System.Drawing.Size(233, 26);
            this.txtTenLoaiSach.TabIndex = 26;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(39, 64);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(97, 20);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "Tên loại sách:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(173, 14);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(159, 24);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "THÊM LOẠI SÁCH";
            // 
            // frmThemLoaiSach
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 176);
            this.Controls.Add(this.btnCancleThemSach);
            this.Controls.Add(this.btnThemLoaiSach);
            this.Controls.Add(this.txtTenLoaiSach);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmThemLoaiSach";
            this.Text = "Thêm Loại Sách";
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiSach.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancleThemSach;
        private DevExpress.XtraEditors.SimpleButton btnThemLoaiSach;
        private DevExpress.XtraEditors.TextEdit txtTenLoaiSach;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}