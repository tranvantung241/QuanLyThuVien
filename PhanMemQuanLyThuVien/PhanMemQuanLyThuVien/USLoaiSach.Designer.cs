namespace PhanMemQuanLyThuVien
{
    partial class USLoaiSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USLoaiSach));
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridLoaiSach = new DevExpress.XtraGrid.GridControl();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoaiSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.fluentDesignFormContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Loại Sách";
            this.gridColumn2.FieldName = "tenloaisach";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Loại Sách";
            this.gridColumn1.FieldName = "maloaisach";
            this.gridColumn1.MaxWidth = 200;
            this.gridColumn1.MinWidth = 50;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 50;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridLoaiSach;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.RowAutoHeight = true;
            // 
            // gridLoaiSach
            // 
            this.gridLoaiSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLoaiSach.Location = new System.Drawing.Point(0, 0);
            this.gridLoaiSach.MainView = this.gridView1;
            this.gridLoaiSach.Name = "gridLoaiSach";
            this.gridLoaiSach.Size = new System.Drawing.Size(999, 683);
            this.gridLoaiSach.TabIndex = 0;
            this.gridLoaiSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(-11, 122);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.OffText = "Off";
            this.toggleSwitch1.Properties.OnText = "On";
            this.toggleSwitch1.Size = new System.Drawing.Size(95, 24);
            this.toggleSwitch1.TabIndex = 1;
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement5.ImageOptions.Image")));
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement5.Text = "Tải Lại";
            this.accordionControlElement5.Click += new System.EventHandler(this.accordionControlElement5_Click);
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement3.ImageOptions.Image")));
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement3.Text = "Cập Nhật Loại Sách";
            this.accordionControlElement3.Click += new System.EventHandler(this.accordionControlElement3_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement2.ImageOptions.Image")));
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement2.Text = "Thêm Loại Sách";
            this.accordionControlElement2.Click += new System.EventHandler(this.accordionControlElement2_Click);
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement2,
            this.accordionControlElement3,
            this.accordionControlElement4,
            this.accordionControlElement5});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Công Việc";
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement4.ImageOptions.Image")));
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement4.Text = "Xóa Loại Sách";
            this.accordionControlElement4.Click += new System.EventHandler(this.accordionControlElement4_Click);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl1.Size = new System.Drawing.Size(108, 683);
            this.accordionControl1.TabIndex = 0;
            this.accordionControl1.Text = "accordionControl1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.splitContainer1.Panel1.AllowDrop = true;
            this.splitContainer1.Panel1.Controls.Add(this.accordionControl1);
            this.splitContainer1.Panel1.Controls.Add(this.toggleSwitch1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridLoaiSach);
            this.splitContainer1.Size = new System.Drawing.Size(1111, 683);
            this.splitContainer1.SplitterDistance = 108;
            this.splitContainer1.TabIndex = 0;
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.splitContainer1);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(1111, 683);
            this.fluentDesignFormContainer1.TabIndex = 6;
            // 
            // USLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Name = "USLoaiSach";
            this.Size = new System.Drawing.Size(1111, 683);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoaiSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.fluentDesignFormContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridLoaiSach;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
    }
}
