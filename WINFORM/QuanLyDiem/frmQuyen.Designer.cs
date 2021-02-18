
namespace QuanLyDiem
{
    partial class frmQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuyen));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colDanhMuc = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colQThem = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colQSua = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colQXoa = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCam = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMenu = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colParent = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnRef = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 39);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.treeList1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1190, 526);
            this.splitContainerControl1.SplitterPosition = 349;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(349, 526);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserName,
            this.colFullName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colUserName
            // 
            this.colUserName.Caption = "Tài Khoản";
            this.colUserName.FieldName = "UserName";
            this.colUserName.MinWidth = 30;
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 0;
            this.colUserName.Width = 112;
            // 
            // colFullName
            // 
            this.colFullName.Caption = "Họ Tên";
            this.colFullName.FieldName = "FullName";
            this.colFullName.MinWidth = 30;
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 1;
            this.colFullName.Width = 112;
            // 
            // treeList1
            // 
            this.treeList1.CaptionHeight = 2;
            this.treeList1.ColumnPanelRowHeight = 2;
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colDanhMuc,
            this.colQThem,
            this.colQSua,
            this.colQXoa,
            this.colCam,
            this.colMenu,
            this.colParent});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.KeyFieldName = "Menu";
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsView.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.Dark;
            this.treeList1.ParentFieldName = "ParentMenu";
            this.treeList1.Size = new System.Drawing.Size(826, 526);
            this.treeList1.TabIndex = 0;
            this.treeList1.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.treeList1_CustomDrawNodeCell);
            this.treeList1.CellValueChanging += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.treeList1_CellValueChanging);
            // 
            // colDanhMuc
            // 
            this.colDanhMuc.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colDanhMuc.AppearanceHeader.Options.UseFont = true;
            this.colDanhMuc.Caption = "Danh mục";
            this.colDanhMuc.FieldName = "Detail";
            this.colDanhMuc.Name = "colDanhMuc";
            this.colDanhMuc.OptionsColumn.AllowEdit = false;
            this.colDanhMuc.OptionsColumn.AllowFocus = false;
            this.colDanhMuc.Visible = true;
            this.colDanhMuc.VisibleIndex = 0;
            // 
            // colQThem
            // 
            this.colQThem.AppearanceCell.Options.UseTextOptions = true;
            this.colQThem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQThem.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colQThem.AppearanceHeader.Options.UseFont = true;
            this.colQThem.AppearanceHeader.Options.UseTextOptions = true;
            this.colQThem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQThem.Caption = "Quyền Thêm";
            this.colQThem.FieldName = "QuyenThem";
            this.colQThem.Name = "colQThem";
            this.colQThem.Visible = true;
            this.colQThem.VisibleIndex = 1;
            // 
            // colQSua
            // 
            this.colQSua.AppearanceCell.Options.UseTextOptions = true;
            this.colQSua.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQSua.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colQSua.AppearanceHeader.Options.UseFont = true;
            this.colQSua.AppearanceHeader.Options.UseTextOptions = true;
            this.colQSua.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQSua.Caption = "Quyền Sửa";
            this.colQSua.FieldName = "QuyenSua";
            this.colQSua.Name = "colQSua";
            this.colQSua.Visible = true;
            this.colQSua.VisibleIndex = 2;
            // 
            // colQXoa
            // 
            this.colQXoa.AppearanceCell.Options.UseTextOptions = true;
            this.colQXoa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQXoa.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colQXoa.AppearanceHeader.Options.UseFont = true;
            this.colQXoa.AppearanceHeader.Options.UseTextOptions = true;
            this.colQXoa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQXoa.Caption = "Quyền Xóa";
            this.colQXoa.FieldName = "QuyenXoa";
            this.colQXoa.Name = "colQXoa";
            this.colQXoa.Visible = true;
            this.colQXoa.VisibleIndex = 3;
            // 
            // colCam
            // 
            this.colCam.AppearanceCell.Options.UseTextOptions = true;
            this.colCam.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCam.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colCam.AppearanceHeader.Options.UseFont = true;
            this.colCam.AppearanceHeader.Options.UseTextOptions = true;
            this.colCam.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCam.Caption = "Cấm";
            this.colCam.FieldName = "Cam";
            this.colCam.Name = "colCam";
            this.colCam.Visible = true;
            this.colCam.VisibleIndex = 4;
            // 
            // colMenu
            // 
            this.colMenu.Caption = "Menu";
            this.colMenu.FieldName = "Menu";
            this.colMenu.Name = "colMenu";
            // 
            // colParent
            // 
            this.colParent.Caption = "ParentMenu";
            this.colParent.FieldName = "ParentMenu";
            this.colParent.Name = "colParent";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnRef,
            this.btnUpdate});
            this.barManager1.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRef, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUpdate, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnRef
            // 
            this.btnRef.Caption = "Làm mới";
            this.btnRef.Id = 0;
            this.btnRef.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRef.ImageOptions.Image")));
            this.btnRef.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRef.ImageOptions.LargeImage")));
            this.btnRef.Name = "btnRef";
            this.btnRef.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRef_ItemClick_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Update dữ liệu phân quyền";
            this.btnUpdate.Id = 1;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.LargeImage")));
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdate_ItemClick_1);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1190, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 565);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1190, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 526);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1190, 39);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 526);
            // 
            // frmQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 565);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHÂN QUYỀN NGƯỜI DÙNG";
            this.Load += new System.EventHandler(this.frmQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDanhMuc;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colQThem;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colQSua;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colQXoa;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCam;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMenu;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colParent;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnRef;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
    }
}