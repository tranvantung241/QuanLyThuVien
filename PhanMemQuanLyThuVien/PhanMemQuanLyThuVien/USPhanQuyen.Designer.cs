namespace PhanMemQuanLyThuVien
{
    partial class USPhanQuyen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Quản Lý Sách");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Quản Lý Mượn Sách");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Quản Lý Trả Sách");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Quản Lý Báo Cáo");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Quản Lý Độc Giả");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Quản Lý Nhân Viên");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Quản Lý Sách");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Quản Lý Mượn Sách");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Quản Lý Trả Sách");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Quản Lý Báo Cáo");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Quản Lý Độc Giả");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USPhanQuyen));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lookNhanVien = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.listView3 = new System.Windows.Forms.ListView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ckhGiamDoc = new DevExpress.XtraEditors.CheckEdit();
            this.chkNhanVien = new DevExpress.XtraEditors.CheckEdit();
            this.btnPhanQuyen = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lookNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckhGiamDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(304, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tài khoản:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(67, 49);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nhân viên:";
            // 
            // lookNhanVien
            // 
            this.lookNhanVien.Location = new System.Drawing.Point(150, 47);
            this.lookNhanVien.Name = "lookNhanVien";
            this.lookNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookNhanVien.Properties.Appearance.Options.UseFont = true;
            this.lookNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookNhanVien.Properties.DisplayMember = "tennhanvien";
            this.lookNhanVien.Properties.NullText = "Tên nhân viên";
            this.lookNhanVien.Properties.ValueMember = "manv";
            this.lookNhanVien.Size = new System.Drawing.Size(122, 22);
            this.lookNhanVien.TabIndex = 2;
            this.lookNhanVien.EditValueChanged += new System.EventHandler(this.lookNhanVien_EditValueChanged);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(386, 48);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(136, 20);
            this.txtTaiKhoan.TabIndex = 4;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.listView3);
            this.groupControl1.Location = new System.Drawing.Point(70, 123);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(211, 268);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Chức Năng";
            // 
            // listView3
            // 
            this.listView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView3.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.listView3.Location = new System.Drawing.Point(2, 20);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(207, 246);
            this.listView3.TabIndex = 1;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Tile;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.listView1);
            this.groupControl2.Location = new System.Drawing.Point(304, 123);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(218, 266);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Chức Năng";
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11});
            this.listView1.Location = new System.Drawing.Point(2, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(214, 244);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // ckhGiamDoc
            // 
            this.ckhGiamDoc.Location = new System.Drawing.Point(70, 86);
            this.ckhGiamDoc.Name = "ckhGiamDoc";
            this.ckhGiamDoc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckhGiamDoc.Properties.Appearance.Options.UseFont = true;
            this.ckhGiamDoc.Properties.Caption = "Giám Đốc";
            this.ckhGiamDoc.Size = new System.Drawing.Size(97, 23);
            this.ckhGiamDoc.TabIndex = 5;
            // 
            // chkNhanVien
            // 
            this.chkNhanVien.Location = new System.Drawing.Point(304, 86);
            this.chkNhanVien.Name = "chkNhanVien";
            this.chkNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNhanVien.Properties.Appearance.Options.UseFont = true;
            this.chkNhanVien.Properties.Caption = "Nhân Viên";
            this.chkNhanVien.Size = new System.Drawing.Size(97, 23);
            this.chkNhanVien.TabIndex = 6;
            this.chkNhanVien.CheckedChanged += new System.EventHandler(this.chkNhanVien_CheckedChanged);
            // 
            // btnPhanQuyen
            // 
            this.btnPhanQuyen.Location = new System.Drawing.Point(570, 361);
            this.btnPhanQuyen.Name = "btnPhanQuyen";
            this.btnPhanQuyen.Size = new System.Drawing.Size(82, 25);
            this.btnPhanQuyen.TabIndex = 7;
            this.btnPhanQuyen.Text = "Phân Quyền";
            this.btnPhanQuyen.Click += new System.EventHandler(this.btnPhanQuyen_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(570, 88);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(274, 194);
            this.pictureEdit1.TabIndex = 8;
            // 
            // USPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.btnPhanQuyen);
            this.Controls.Add(this.chkNhanVien);
            this.Controls.Add(this.ckhGiamDoc);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lookNhanVien);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "USPhanQuyen";
            this.Size = new System.Drawing.Size(901, 510);
            ((System.ComponentModel.ISupportInitialize)(this.lookNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ckhGiamDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lookNhanVien;
        private DevExpress.XtraEditors.TextEdit txtTaiKhoan;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit ckhGiamDoc;
        private DevExpress.XtraEditors.CheckEdit chkNhanVien;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView1;
        private DevExpress.XtraEditors.SimpleButton btnPhanQuyen;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}
