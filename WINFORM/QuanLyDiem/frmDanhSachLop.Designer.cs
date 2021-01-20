
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.luLop = new DevExpress.XtraEditors.LookUpEdit();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MaSVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.HoTenTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NgaySinhDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.GioiTinhTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NoiSinhTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DanTocTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForMaSV = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForHoTen = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNgaySinh = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForGioiTinh = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNoiSinh = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDanToc = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienSelectAllDetailResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaSVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoTenTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySinhDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySinhDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GioiTinhTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoiSinhTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanTocTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNgaySinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGioiTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNoiSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDanToc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDanhSachLop
            // 
            this.gcDanhSachLop.DataSource = this.sinhVienSelectAllDetailResultBindingSource;
            this.gcDanhSachLop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcDanhSachLop.Location = new System.Drawing.Point(2, 299);
            this.gcDanhSachLop.MainView = this.gridView1;
            this.gcDanhSachLop.Name = "gcDanhSachLop";
            this.gcDanhSachLop.Size = new System.Drawing.Size(1048, 226);
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
            this.panelControl1.Controls.Add(this.dataLayoutControl1);
            this.panelControl1.Controls.Add(this.gcDanhSachLop);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1052, 527);
            this.panelControl1.TabIndex = 2;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.luLop);
            this.dataLayoutControl1.Controls.Add(this.MaSVTextEdit);
            this.dataLayoutControl1.Controls.Add(this.HoTenTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NgaySinhDateEdit);
            this.dataLayoutControl1.Controls.Add(this.GioiTinhTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NoiSinhTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DanTocTextEdit);
            this.dataLayoutControl1.DataSource = this.sinhVienSelectAllDetailResultBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(2, 2);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1048, 297);
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
            // MaSVTextEdit
            // 
            this.MaSVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sinhVienSelectAllDetailResultBindingSource, "MaSV", true));
            this.MaSVTextEdit.Location = new System.Drawing.Point(97, 42);
            this.MaSVTextEdit.Name = "MaSVTextEdit";
            this.MaSVTextEdit.Size = new System.Drawing.Size(939, 26);
            this.MaSVTextEdit.StyleController = this.dataLayoutControl1;
            this.MaSVTextEdit.TabIndex = 4;
            // 
            // HoTenTextEdit
            // 
            this.HoTenTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sinhVienSelectAllDetailResultBindingSource, "HoTen", true));
            this.HoTenTextEdit.Location = new System.Drawing.Point(97, 72);
            this.HoTenTextEdit.Name = "HoTenTextEdit";
            this.HoTenTextEdit.Size = new System.Drawing.Size(939, 26);
            this.HoTenTextEdit.StyleController = this.dataLayoutControl1;
            this.HoTenTextEdit.TabIndex = 5;
            // 
            // NgaySinhDateEdit
            // 
            this.NgaySinhDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sinhVienSelectAllDetailResultBindingSource, "NgaySinh", true));
            this.NgaySinhDateEdit.EditValue = null;
            this.NgaySinhDateEdit.Location = new System.Drawing.Point(97, 102);
            this.NgaySinhDateEdit.Name = "NgaySinhDateEdit";
            this.NgaySinhDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.NgaySinhDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NgaySinhDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NgaySinhDateEdit.Size = new System.Drawing.Size(939, 26);
            this.NgaySinhDateEdit.StyleController = this.dataLayoutControl1;
            this.NgaySinhDateEdit.TabIndex = 6;
            // 
            // GioiTinhTextEdit
            // 
            this.GioiTinhTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sinhVienSelectAllDetailResultBindingSource, "GioiTinh", true));
            this.GioiTinhTextEdit.Location = new System.Drawing.Point(97, 132);
            this.GioiTinhTextEdit.Name = "GioiTinhTextEdit";
            this.GioiTinhTextEdit.Size = new System.Drawing.Size(939, 26);
            this.GioiTinhTextEdit.StyleController = this.dataLayoutControl1;
            this.GioiTinhTextEdit.TabIndex = 7;
            // 
            // NoiSinhTextEdit
            // 
            this.NoiSinhTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sinhVienSelectAllDetailResultBindingSource, "NoiSinh", true));
            this.NoiSinhTextEdit.Location = new System.Drawing.Point(97, 162);
            this.NoiSinhTextEdit.Name = "NoiSinhTextEdit";
            this.NoiSinhTextEdit.Size = new System.Drawing.Size(939, 26);
            this.NoiSinhTextEdit.StyleController = this.dataLayoutControl1;
            this.NoiSinhTextEdit.TabIndex = 8;
            // 
            // DanTocTextEdit
            // 
            this.DanTocTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sinhVienSelectAllDetailResultBindingSource, "DanToc", true));
            this.DanTocTextEdit.Location = new System.Drawing.Point(97, 192);
            this.DanTocTextEdit.Name = "DanTocTextEdit";
            this.DanTocTextEdit.Size = new System.Drawing.Size(939, 26);
            this.DanTocTextEdit.StyleController = this.dataLayoutControl1;
            this.DanTocTextEdit.TabIndex = 9;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1048, 297);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForMaSV,
            this.ItemForHoTen,
            this.ItemForNgaySinh,
            this.ItemForGioiTinh,
            this.ItemForNoiSinh,
            this.ItemForDanToc,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1028, 277);
            // 
            // ItemForMaSV
            // 
            this.ItemForMaSV.Control = this.MaSVTextEdit;
            this.ItemForMaSV.Location = new System.Drawing.Point(0, 30);
            this.ItemForMaSV.Name = "ItemForMaSV";
            this.ItemForMaSV.Size = new System.Drawing.Size(1028, 30);
            this.ItemForMaSV.Text = "Ma SV";
            this.ItemForMaSV.TextSize = new System.Drawing.Size(82, 18);
            // 
            // ItemForHoTen
            // 
            this.ItemForHoTen.Control = this.HoTenTextEdit;
            this.ItemForHoTen.Location = new System.Drawing.Point(0, 60);
            this.ItemForHoTen.Name = "ItemForHoTen";
            this.ItemForHoTen.Size = new System.Drawing.Size(1028, 30);
            this.ItemForHoTen.Text = "Ho Ten";
            this.ItemForHoTen.TextSize = new System.Drawing.Size(82, 18);
            // 
            // ItemForNgaySinh
            // 
            this.ItemForNgaySinh.Control = this.NgaySinhDateEdit;
            this.ItemForNgaySinh.Location = new System.Drawing.Point(0, 90);
            this.ItemForNgaySinh.Name = "ItemForNgaySinh";
            this.ItemForNgaySinh.Size = new System.Drawing.Size(1028, 30);
            this.ItemForNgaySinh.Text = "Ngay Sinh";
            this.ItemForNgaySinh.TextSize = new System.Drawing.Size(82, 18);
            // 
            // ItemForGioiTinh
            // 
            this.ItemForGioiTinh.Control = this.GioiTinhTextEdit;
            this.ItemForGioiTinh.Location = new System.Drawing.Point(0, 120);
            this.ItemForGioiTinh.Name = "ItemForGioiTinh";
            this.ItemForGioiTinh.Size = new System.Drawing.Size(1028, 30);
            this.ItemForGioiTinh.Text = "Gioi Tinh";
            this.ItemForGioiTinh.TextSize = new System.Drawing.Size(82, 18);
            // 
            // ItemForNoiSinh
            // 
            this.ItemForNoiSinh.Control = this.NoiSinhTextEdit;
            this.ItemForNoiSinh.Location = new System.Drawing.Point(0, 150);
            this.ItemForNoiSinh.Name = "ItemForNoiSinh";
            this.ItemForNoiSinh.Size = new System.Drawing.Size(1028, 30);
            this.ItemForNoiSinh.Text = "Noi Sinh";
            this.ItemForNoiSinh.TextSize = new System.Drawing.Size(82, 18);
            // 
            // ItemForDanToc
            // 
            this.ItemForDanToc.Control = this.DanTocTextEdit;
            this.ItemForDanToc.Location = new System.Drawing.Point(0, 180);
            this.ItemForDanToc.Name = "ItemForDanToc";
            this.ItemForDanToc.Size = new System.Drawing.Size(1028, 97);
            this.ItemForDanToc.Text = "Dan Toc";
            this.ItemForDanToc.TextSize = new System.Drawing.Size(82, 18);
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
            // panelControl2
            // 
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(1052, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(236, 527);
            this.panelControl2.TabIndex = 3;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaSVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoTenTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySinhDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySinhDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GioiTinhTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoiSinhTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanTocTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNgaySinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGioiTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNoiSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDanToc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit MaSVTextEdit;
        private DevExpress.XtraEditors.TextEdit HoTenTextEdit;
        private DevExpress.XtraEditors.DateEdit NgaySinhDateEdit;
        private DevExpress.XtraEditors.TextEdit GioiTinhTextEdit;
        private DevExpress.XtraEditors.TextEdit NoiSinhTextEdit;
        private DevExpress.XtraEditors.TextEdit DanTocTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMaSV;
        private DevExpress.XtraLayout.LayoutControlItem ItemForHoTen;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNgaySinh;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGioiTinh;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNoiSinh;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDanToc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource lopBindingSource;
    }
}