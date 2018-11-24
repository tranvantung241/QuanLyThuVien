namespace PhanMemQuanLyThuVien
{
    partial class USListSach
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewColumn1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewColumn2 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewColumn3 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewColumn4 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewColumn5 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewColumn6 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.layoutViewField_gridColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_gridColumn2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_gridColumn3 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_gridColumn4 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_gridColumn5 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_gridColumn6 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn6)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(DAL.SACH);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1094, 627);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1,
            this.gridView1});
            // 
            // layoutView1
            // 
            this.layoutView1.CardMinSize = new System.Drawing.Size(134, 182);
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.layoutViewColumn1,
            this.layoutViewColumn2,
            this.layoutViewColumn3,
            this.layoutViewColumn4,
            this.layoutViewColumn5,
            this.layoutViewColumn6});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // layoutViewColumn1
            // 
            this.layoutViewColumn1.Caption = "Mã Sách:";
            this.layoutViewColumn1.FieldName = "masach";
            this.layoutViewColumn1.LayoutViewField = this.layoutViewField_gridColumn1;
            this.layoutViewColumn1.Name = "layoutViewColumn1";
            // 
            // layoutViewColumn2
            // 
            this.layoutViewColumn2.Caption = "Tên Sách:";
            this.layoutViewColumn2.FieldName = "tensach";
            this.layoutViewColumn2.LayoutViewField = this.layoutViewField_gridColumn2;
            this.layoutViewColumn2.Name = "layoutViewColumn2";
            // 
            // layoutViewColumn3
            // 
            this.layoutViewColumn3.Caption = "Loại Sách:";
            this.layoutViewColumn3.FieldName = "tenloaiach";
            this.layoutViewColumn3.LayoutViewField = this.layoutViewField_gridColumn3;
            this.layoutViewColumn3.Name = "layoutViewColumn3";
            // 
            // layoutViewColumn4
            // 
            this.layoutViewColumn4.Caption = "Giá:";
            this.layoutViewColumn4.FieldName = "trigia";
            this.layoutViewColumn4.LayoutViewField = this.layoutViewField_gridColumn4;
            this.layoutViewColumn4.Name = "layoutViewColumn4";
            // 
            // layoutViewColumn5
            // 
            this.layoutViewColumn5.Caption = "Tình Trạng Sách:";
            this.layoutViewColumn5.FieldName = "tinhtrangsach";
            this.layoutViewColumn5.LayoutViewField = this.layoutViewField_gridColumn5;
            this.layoutViewColumn5.Name = "layoutViewColumn5";
            // 
            // layoutViewColumn6
            // 
            this.layoutViewColumn6.Caption = "Hình Ảnh:";
            this.layoutViewColumn6.FieldName = "hinhanh";
            this.layoutViewColumn6.LayoutViewField = this.layoutViewField_gridColumn6;
            this.layoutViewColumn6.Name = "layoutViewColumn6";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "masach";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.FieldName = "tensach";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "gridColumn3";
            this.gridColumn3.FieldName = "tenloaiach";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "gridColumn4";
            this.gridColumn4.FieldName = "trigia";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "gridColumn5";
            this.gridColumn5.FieldName = "tinhtrangsach";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "gridColumn6";
            this.gridColumn6.FieldName = "hinhanh";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_gridColumn1,
            this.layoutViewField_gridColumn2,
            this.layoutViewField_gridColumn3,
            this.layoutViewField_gridColumn4,
            this.layoutViewField_gridColumn5,
            this.layoutViewField_gridColumn6});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // layoutViewField_gridColumn1
            // 
            this.layoutViewField_gridColumn1.EditorPreferredWidth = 130;
            this.layoutViewField_gridColumn1.Location = new System.Drawing.Point(0, 24);
            this.layoutViewField_gridColumn1.Name = "layoutViewField_gridColumn1";
            this.layoutViewField_gridColumn1.Size = new System.Drawing.Size(224, 24);
            this.layoutViewField_gridColumn1.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutViewField_gridColumn2
            // 
            this.layoutViewField_gridColumn2.EditorPreferredWidth = 130;
            this.layoutViewField_gridColumn2.Location = new System.Drawing.Point(0, 48);
            this.layoutViewField_gridColumn2.Name = "layoutViewField_gridColumn2";
            this.layoutViewField_gridColumn2.Size = new System.Drawing.Size(224, 24);
            this.layoutViewField_gridColumn2.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutViewField_gridColumn3
            // 
            this.layoutViewField_gridColumn3.EditorPreferredWidth = 130;
            this.layoutViewField_gridColumn3.Location = new System.Drawing.Point(0, 72);
            this.layoutViewField_gridColumn3.Name = "layoutViewField_gridColumn3";
            this.layoutViewField_gridColumn3.Size = new System.Drawing.Size(224, 24);
            this.layoutViewField_gridColumn3.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutViewField_gridColumn4
            // 
            this.layoutViewField_gridColumn4.EditorPreferredWidth = 130;
            this.layoutViewField_gridColumn4.Location = new System.Drawing.Point(0, 96);
            this.layoutViewField_gridColumn4.Name = "layoutViewField_gridColumn4";
            this.layoutViewField_gridColumn4.Size = new System.Drawing.Size(224, 24);
            this.layoutViewField_gridColumn4.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutViewField_gridColumn5
            // 
            this.layoutViewField_gridColumn5.EditorPreferredWidth = 130;
            this.layoutViewField_gridColumn5.Location = new System.Drawing.Point(0, 120);
            this.layoutViewField_gridColumn5.Name = "layoutViewField_gridColumn5";
            this.layoutViewField_gridColumn5.Size = new System.Drawing.Size(224, 24);
            this.layoutViewField_gridColumn5.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutViewField_gridColumn6
            // 
            this.layoutViewField_gridColumn6.EditorPreferredWidth = 130;
            this.layoutViewField_gridColumn6.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_gridColumn6.Name = "layoutViewField_gridColumn6";
            this.layoutViewField_gridColumn6.Size = new System.Drawing.Size(224, 24);
            this.layoutViewField_gridColumn6.TextSize = new System.Drawing.Size(85, 13);
            // 
            // USListSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "USListSach";
            this.Size = new System.Drawing.Size(1094, 627);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn2;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn3;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn4;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn5;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn6;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn3;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn4;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn5;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn6;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}
