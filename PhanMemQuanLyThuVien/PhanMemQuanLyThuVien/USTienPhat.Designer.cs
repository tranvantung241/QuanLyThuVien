namespace PhanMemQuanLyThuVien
{
    partial class USTienPhat
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
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.quanLiThuVienDataSet1 = new PhanMemQuanLyThuVien.QuanLiThuVienDataSet1();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonTableAdapter = new PhanMemQuanLyThuVien.QuanLiThuVienDataSet1TableAdapters.HoaDonTableAdapter();
            this.Mã = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmadocgia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmasach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsoluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsotien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collydo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngayhd = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiThuVienDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.hoaDonBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(802, 463);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Mã,
            this.colten,
            this.colmadocgia,
            this.colmasach,
            this.colsoluong,
            this.colsotien,
            this.collydo,
            this.colngayhd});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // quanLiThuVienDataSet1
            // 
            this.quanLiThuVienDataSet1.DataSetName = "QuanLiThuVienDataSet1";
            this.quanLiThuVienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.quanLiThuVienDataSet1;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // Mã
            // 
            this.Mã.Caption = "Mã";
            this.Mã.FieldName = "id";
            this.Mã.Name = "Mã";
            this.Mã.Visible = true;
            this.Mã.VisibleIndex = 0;
            // 
            // colten
            // 
            this.colten.Caption = "Tên";
            this.colten.FieldName = "ten";
            this.colten.Name = "colten";
            this.colten.Visible = true;
            this.colten.VisibleIndex = 1;
            // 
            // colmadocgia
            // 
            this.colmadocgia.Caption = "Mã độc giả";
            this.colmadocgia.FieldName = "madocgia";
            this.colmadocgia.Name = "colmadocgia";
            this.colmadocgia.Visible = true;
            this.colmadocgia.VisibleIndex = 2;
            // 
            // colmasach
            // 
            this.colmasach.Caption = "Mã sách";
            this.colmasach.FieldName = "masach";
            this.colmasach.Name = "colmasach";
            this.colmasach.Visible = true;
            this.colmasach.VisibleIndex = 3;
            // 
            // colsoluong
            // 
            this.colsoluong.Caption = "Số lượng";
            this.colsoluong.FieldName = "soluong";
            this.colsoluong.Name = "colsoluong";
            this.colsoluong.Visible = true;
            this.colsoluong.VisibleIndex = 4;
            // 
            // colsotien
            // 
            this.colsotien.Caption = "Số Tiền";
            this.colsotien.FieldName = "sotien";
            this.colsotien.Name = "colsotien";
            this.colsotien.Visible = true;
            this.colsotien.VisibleIndex = 5;
            // 
            // collydo
            // 
            this.collydo.Caption = "Lý Do";
            this.collydo.FieldName = "lydo";
            this.collydo.Name = "collydo";
            this.collydo.Visible = true;
            this.collydo.VisibleIndex = 6;
            // 
            // colngayhd
            // 
            this.colngayhd.Caption = "Ngày hóa đơn";
            this.colngayhd.FieldName = "ngayhd";
            this.colngayhd.Name = "colngayhd";
            this.colngayhd.Visible = true;
            this.colngayhd.VisibleIndex = 7;
            // 
            // USTienPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "USTienPhat";
            this.Size = new System.Drawing.Size(802, 463);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiThuVienDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private QuanLiThuVienDataSet1 quanLiThuVienDataSet1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Mã;
        private DevExpress.XtraGrid.Columns.GridColumn colten;
        private DevExpress.XtraGrid.Columns.GridColumn colmadocgia;
        private DevExpress.XtraGrid.Columns.GridColumn colmasach;
        private DevExpress.XtraGrid.Columns.GridColumn colsoluong;
        private DevExpress.XtraGrid.Columns.GridColumn colsotien;
        private DevExpress.XtraGrid.Columns.GridColumn collydo;
        private DevExpress.XtraGrid.Columns.GridColumn colngayhd;
        private QuanLiThuVienDataSet1TableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
    }
}
