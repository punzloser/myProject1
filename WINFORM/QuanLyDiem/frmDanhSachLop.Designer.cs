
namespace QuanLyDiem
{
    partial class frmDanhSachLop
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
            this.gcDanhSachLop = new DevExpress.XtraGrid.GridControl();
            this.sinhVienSelectAllDetailResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoiSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanToc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.luLop = new DevExpress.XtraEditors.LookUpEdit();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.dateNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.txtGioiTinh = new DevExpress.XtraEditors.TextEdit();
            this.txtNoiSinh = new DevExpress.XtraEditors.TextEdit();
            this.txtDanToc = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForMaSV = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNgaySinh = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForHoTen = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDanToc = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForGioiTinh = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNoiSinh = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnExport = new QuanLyDiem.CircularButton();
            this.btnImport = new QuanLyDiem.CircularButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienSelectAllDetailResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGioiTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiSinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDanToc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNgaySinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDanToc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGioiTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNoiSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcDanhSachLop
            // 
            this.gcDanhSachLop.DataSource = this.sinhVienSelectAllDetailResultBindingSource;
            this.gcDanhSachLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSachLop.Location = new System.Drawing.Point(2, 2);
            this.gcDanhSachLop.MainView = this.gridView1;
            this.gcDanhSachLop.Name = "gcDanhSachLop";
            this.gcDanhSachLop.Size = new System.Drawing.Size(1044, 314);
            this.gcDanhSachLop.TabIndex = 0;
            this.gcDanhSachLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sinhVienSelectAllDetailResultBindingSource
            // 
            this.sinhVienSelectAllDetailResultBindingSource.DataSource = typeof(QuanLyDiem.SinhVienSelectAllDetail_Result);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSV,
            this.colHoTen,
            this.colNgaySinh,
            this.colGioiTinh,
            this.colNoiSinh,
            this.colDanToc});
            this.gridView1.GridControl = this.gcDanhSachLop;
            this.gridView1.Name = "gridView1";
            // 
            // colMaSV
            // 
            this.colMaSV.FieldName = "MaSV";
            this.colMaSV.MinWidth = 30;
            this.colMaSV.Name = "colMaSV";
            this.colMaSV.Visible = true;
            this.colMaSV.VisibleIndex = 0;
            this.colMaSV.Width = 112;
            // 
            // colHoTen
            // 
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.MinWidth = 30;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 1;
            this.colHoTen.Width = 112;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.MinWidth = 30;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 2;
            this.colNgaySinh.Width = 112;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.FieldName = "GioiTinh";
            this.colGioiTinh.MinWidth = 30;
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Visible = true;
            this.colGioiTinh.VisibleIndex = 3;
            this.colGioiTinh.Width = 112;
            // 
            // colNoiSinh
            // 
            this.colNoiSinh.FieldName = "NoiSinh";
            this.colNoiSinh.MinWidth = 30;
            this.colNoiSinh.Name = "colNoiSinh";
            this.colNoiSinh.Visible = true;
            this.colNoiSinh.VisibleIndex = 4;
            this.colNoiSinh.Width = 112;
            // 
            // colDanToc
            // 
            this.colDanToc.FieldName = "DanToc";
            this.colDanToc.MinWidth = 30;
            this.colDanToc.Name = "colDanToc";
            this.colDanToc.Visible = true;
            this.colDanToc.VisibleIndex = 5;
            this.colDanToc.Width = 112;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.dataLayoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1052, 527);
            this.panelControl1.TabIndex = 2;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gcDanhSachLop);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 207);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1048, 318);
            this.panelControl3.TabIndex = 2;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.luLop);
            this.dataLayoutControl1.Controls.Add(this.txtMaSV);
            this.dataLayoutControl1.Controls.Add(this.txtHoTen);
            this.dataLayoutControl1.Controls.Add(this.dateNgaySinh);
            this.dataLayoutControl1.Controls.Add(this.txtGioiTinh);
            this.dataLayoutControl1.Controls.Add(this.txtNoiSinh);
            this.dataLayoutControl1.Controls.Add(this.txtDanToc);
            this.dataLayoutControl1.DataSource = this.sinhVienSelectAllDetailResultBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataLayoutControl1.Location = new System.Drawing.Point(2, 2);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1048, 205);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // luLop
            // 
            this.luLop.Location = new System.Drawing.Point(97, 12);
            this.luLop.Name = "luLop";
            this.luLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luLop.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenLop", "Ten Lop", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.luLop.Properties.DataSource = this.lopBindingSource;
            this.luLop.Properties.DisplayMember = "TenLop";
            this.luLop.Properties.NullText = "";
            this.luLop.Properties.ValueMember = "MaLop";
            this.luLop.Size = new System.Drawing.Size(939, 26);
            this.luLop.StyleController = this.dataLayoutControl1;
            this.luLop.TabIndex = 10;
            this.luLop.EditValueChanged += new System.EventHandler(this.luLop_EditValueChanged);
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataSource = typeof(QuanLyDiem.Lop);
            // 
            // txtMaSV
            // 
            this.txtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sinhVienSelectAllDetailResultBindingSource, "MaSV", true));
            this.txtMaSV.Location = new System.Drawing.Point(97, 42);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(373, 26);
            this.txtMaSV.StyleController = this.dataLayoutControl1;
            this.txtMaSV.TabIndex = 4;
            // 
            // txtHoTen
            // 
            this.txtHoTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sinhVienSelectAllDetailResultBindingSource, "HoTen", true));
            this.txtHoTen.Location = new System.Drawing.Point(559, 42);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(477, 26);
            this.txtHoTen.StyleController = this.dataLayoutControl1;
            this.txtHoTen.TabIndex = 5;
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sinhVienSelectAllDetailResultBindingSource, "NgaySinh", true));
            this.dateNgaySinh.EditValue = null;
            this.dateNgaySinh.Location = new System.Drawing.Point(611, 72);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.dateNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinh.Size = new System.Drawing.Size(425, 26);
            this.dateNgaySinh.StyleController = this.dataLayoutControl1;
            this.dateNgaySinh.TabIndex = 6;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sinhVienSelectAllDetailResultBindingSource, "GioiTinh", true));
            this.txtGioiTinh.Location = new System.Drawing.Point(97, 102);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(425, 26);
            this.txtGioiTinh.StyleController = this.dataLayoutControl1;
            this.txtGioiTinh.TabIndex = 7;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sinhVienSelectAllDetailResultBindingSource, "NoiSinh", true));
            this.txtNoiSinh.Location = new System.Drawing.Point(97, 72);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(425, 26);
            this.txtNoiSinh.StyleController = this.dataLayoutControl1;
            this.txtNoiSinh.TabIndex = 8;
            // 
            // txtDanToc
            // 
            this.txtDanToc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sinhVienSelectAllDetailResultBindingSource, "DanToc", true));
            this.txtDanToc.Location = new System.Drawing.Point(611, 102);
            this.txtDanToc.Name = "txtDanToc";
            this.txtDanToc.Size = new System.Drawing.Size(425, 26);
            this.txtDanToc.StyleController = this.dataLayoutControl1;
            this.txtDanToc.TabIndex = 9;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1048, 205);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForMaSV,
            this.ItemForNgaySinh,
            this.layoutControlItem1,
            this.ItemForHoTen,
            this.ItemForDanToc,
            this.ItemForGioiTinh,
            this.ItemForNoiSinh});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1028, 185);
            // 
            // ItemForMaSV
            // 
            this.ItemForMaSV.Control = this.txtMaSV;
            this.ItemForMaSV.Location = new System.Drawing.Point(0, 30);
            this.ItemForMaSV.Name = "ItemForMaSV";
            this.ItemForMaSV.Size = new System.Drawing.Size(462, 30);
            this.ItemForMaSV.Text = "Ma SV";
            this.ItemForMaSV.TextSize = new System.Drawing.Size(82, 18);
            // 
            // ItemForNgaySinh
            // 
            this.ItemForNgaySinh.Control = this.dateNgaySinh;
            this.ItemForNgaySinh.Location = new System.Drawing.Point(514, 60);
            this.ItemForNgaySinh.Name = "ItemForNgaySinh";
            this.ItemForNgaySinh.Size = new System.Drawing.Size(514, 30);
            this.ItemForNgaySinh.Text = "Ngay Sinh";
            this.ItemForNgaySinh.TextSize = new System.Drawing.Size(82, 18);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.luLop;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1028, 30);
            this.layoutControlItem1.Text = "Chọn lớp";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(82, 18);
            // 
            // ItemForHoTen
            // 
            this.ItemForHoTen.Control = this.txtHoTen;
            this.ItemForHoTen.Location = new System.Drawing.Point(462, 30);
            this.ItemForHoTen.Name = "ItemForHoTen";
            this.ItemForHoTen.Size = new System.Drawing.Size(566, 30);
            this.ItemForHoTen.Text = "Ho Ten";
            this.ItemForHoTen.TextSize = new System.Drawing.Size(82, 18);
            // 
            // ItemForDanToc
            // 
            this.ItemForDanToc.Control = this.txtDanToc;
            this.ItemForDanToc.Location = new System.Drawing.Point(514, 90);
            this.ItemForDanToc.Name = "ItemForDanToc";
            this.ItemForDanToc.Size = new System.Drawing.Size(514, 95);
            this.ItemForDanToc.Text = "Dan Toc";
            this.ItemForDanToc.TextSize = new System.Drawing.Size(82, 18);
            // 
            // ItemForGioiTinh
            // 
            this.ItemForGioiTinh.Control = this.txtGioiTinh;
            this.ItemForGioiTinh.Location = new System.Drawing.Point(0, 90);
            this.ItemForGioiTinh.Name = "ItemForGioiTinh";
            this.ItemForGioiTinh.Size = new System.Drawing.Size(514, 95);
            this.ItemForGioiTinh.Text = "Gioi Tinh";
            this.ItemForGioiTinh.TextSize = new System.Drawing.Size(82, 18);
            // 
            // ItemForNoiSinh
            // 
            this.ItemForNoiSinh.Control = this.txtNoiSinh;
            this.ItemForNoiSinh.Location = new System.Drawing.Point(0, 60);
            this.ItemForNoiSinh.Name = "ItemForNoiSinh";
            this.ItemForNoiSinh.Size = new System.Drawing.Size(514, 30);
            this.ItemForNoiSinh.Text = "Noi Sinh";
            this.ItemForNoiSinh.TextSize = new System.Drawing.Size(82, 18);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnExport);
            this.panelControl2.Controls.Add(this.btnImport);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(1052, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(236, 527);
            this.panelControl2.TabIndex = 3;
            // 
            // btnExport
            // 
            this.btnExport.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.Location = new System.Drawing.Point(30, 68);
            this.btnExport.LookAndFeel.SkinName = "VS2010";
            this.btnExport.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(177, 94);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export Excel";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Appearance.BorderColor = System.Drawing.Color.Red;
            this.btnImport.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Appearance.Options.UseBorderColor = true;
            this.btnImport.Appearance.Options.UseFont = true;
            this.btnImport.AppearanceHovered.BorderColor = System.Drawing.Color.Red;
            this.btnImport.AppearanceHovered.Options.UseBorderColor = true;
            this.btnImport.Location = new System.Drawing.Point(30, 240);
            this.btnImport.LookAndFeel.SkinName = "Office 2007 Green";
            this.btnImport.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(177, 94);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import Excel";
            // 
            // frmDanhSachLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 527);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDanhSachLop";
            this.Text = "frmDanhSachLop";
            this.Load += new System.EventHandler(this.frmDanhSachLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienSelectAllDetailResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGioiTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiSinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDanToc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNgaySinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDanToc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGioiTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNoiSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDanhSachLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.BindingSource sinhVienSelectAllDetailResultBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSV;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colNoiSinh;
        private DevExpress.XtraGrid.Columns.GridColumn colDanToc;
        private DevExpress.XtraEditors.LookUpEdit luLop;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.DateEdit dateNgaySinh;
        private DevExpress.XtraEditors.TextEdit txtGioiTinh;
        private DevExpress.XtraEditors.TextEdit txtNoiSinh;
        private DevExpress.XtraEditors.TextEdit txtDanToc;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMaSV;
        private DevExpress.XtraLayout.LayoutControlItem ItemForHoTen;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNgaySinh;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGioiTinh;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNoiSinh;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDanToc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private CircularButton btnExport;
        private CircularButton btnImport;
    }
}