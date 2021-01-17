
namespace QuanLyDiem
{
    partial class frmBangDiemFull
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.luLop = new DevExpress.XtraEditors.LookUpEdit();
            this.lopSelectAllResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.circularPanel1 = new QuanLyDiem.CircularPanel();
            this.treeSV = new System.Windows.Forms.TreeView();
            this.gcDiemCT = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.circularLabel1 = new QuanLyDiem.CircularLabel();
            this.circularLabel2 = new QuanLyDiem.CircularLabel();
            this.circularLabel5 = new QuanLyDiem.CircularLabel();
            this.circularLabel3 = new QuanLyDiem.CircularLabel();
            this.circularLabel6 = new QuanLyDiem.CircularLabel();
            this.circularLabel8 = new QuanLyDiem.CircularLabel();
            this.circularLabel9 = new QuanLyDiem.CircularLabel();
            this.circularLabel4 = new QuanLyDiem.CircularLabel();
            this.circularLabel7 = new QuanLyDiem.CircularLabel();
            this.lbMaSV = new DevExpress.XtraEditors.LabelControl();
            this.lbGioiTinh = new DevExpress.XtraEditors.LabelControl();
            this.lbNoiSinh = new DevExpress.XtraEditors.LabelControl();
            this.lblTB = new DevExpress.XtraEditors.LabelControl();
            this.lbDanToc = new DevExpress.XtraEditors.LabelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.lblTinChiDat = new DevExpress.XtraEditors.LabelControl();
            this.lblXL = new DevExpress.XtraEditors.LabelControl();
            this.circularLabel10 = new QuanLyDiem.CircularLabel();
            this.lbNgaySinh = new DevExpress.XtraEditors.LabelControl();
            this.lbTenSV = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnXuatExcel = new QuanLyDiem.CircularButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopSelectAllResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPanel1)).BeginInit();
            this.circularPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiemCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl5);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(416, 648);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.luLop);
            this.panelControl5.Controls.Add(this.labelControl1);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl5.Location = new System.Drawing.Point(2, 2);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(412, 62);
            this.panelControl5.TabIndex = 5;
            // 
            // luLop
            // 
            this.luLop.Location = new System.Drawing.Point(84, 10);
            this.luLop.Name = "luLop";
            this.luLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luLop.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenLop", "Chọn lớp", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.luLop.Properties.DataSource = this.lopSelectAllResultBindingSource;
            this.luLop.Properties.DisplayMember = "TenLop";
            this.luLop.Properties.NullText = "";
            this.luLop.Properties.PopupFormMinSize = new System.Drawing.Size(10, 0);
            this.luLop.Properties.ValueMember = "MaLop";
            this.luLop.Size = new System.Drawing.Size(230, 26);
            this.luLop.TabIndex = 0;
            this.luLop.EditValueChanged += new System.EventHandler(this.luLop_EditValueChanged);
            // 
            // lopSelectAllResultBindingSource
            // 
            this.lopSelectAllResultBindingSource.DataSource = typeof(QuanLyDiem.LopSelectAll_Result);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Chọn lớp";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.circularPanel1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(2, 58);
            this.groupControl1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(412, 588);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thành viên lớp";
            // 
            // circularPanel1
            // 
            this.circularPanel1.Controls.Add(this.treeSV);
            this.circularPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.circularPanel1.Location = new System.Drawing.Point(2, 31);
            this.circularPanel1.LookAndFeel.SkinName = "Liquid Sky";
            this.circularPanel1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.circularPanel1.Name = "circularPanel1";
            this.circularPanel1.Size = new System.Drawing.Size(408, 555);
            this.circularPanel1.TabIndex = 3;
            // 
            // treeSV
            // 
            this.treeSV.BackColor = System.Drawing.Color.LavenderBlush;
            this.treeSV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeSV.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeSV.ForeColor = System.Drawing.Color.Blue;
            this.treeSV.LineColor = System.Drawing.Color.DarkRed;
            this.treeSV.Location = new System.Drawing.Point(2, 2);
            this.treeSV.Name = "treeSV";
            this.treeSV.Size = new System.Drawing.Size(404, 551);
            this.treeSV.TabIndex = 2;
            this.treeSV.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeSV_NodeMouseClick);
            // 
            // gcDiemCT
            // 
            this.gcDiemCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDiemCT.Location = new System.Drawing.Point(2, 209);
            this.gcDiemCT.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.gcDiemCT.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gcDiemCT.MainView = this.gridView1;
            this.gcDiemCT.Name = "gcDiemCT";
            this.gcDiemCT.Size = new System.Drawing.Size(1226, 437);
            this.gcDiemCT.TabIndex = 0;
            this.gcDiemCT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcDiemCT;
            this.gridView1.Name = "gridView1";
            // 
            // circularLabel1
            // 
            this.circularLabel1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.circularLabel1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.circularLabel1.Appearance.BorderColor = System.Drawing.Color.Red;
            this.circularLabel1.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularLabel1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.circularLabel1.Appearance.Options.UseBackColor = true;
            this.circularLabel1.Appearance.Options.UseBorderColor = true;
            this.circularLabel1.Appearance.Options.UseFont = true;
            this.circularLabel1.Appearance.Options.UseForeColor = true;
            this.circularLabel1.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.circularLabel1.AppearanceHovered.Options.UseBackColor = true;
            this.circularLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.circularLabel1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.circularLabel1.Location = new System.Drawing.Point(2, 2);
            this.circularLabel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.circularLabel1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.circularLabel1.Name = "circularLabel1";
            this.circularLabel1.Padding = new System.Windows.Forms.Padding(5);
            this.circularLabel1.Size = new System.Drawing.Size(639, 39);
            this.circularLabel1.TabIndex = 1;
            this.circularLabel1.Text = "BẢNG TỔNG HỢP ĐIỂM TOÀN KHÓA SINH VIÊN";
            // 
            // circularLabel2
            // 
            this.circularLabel2.Appearance.BackColor = System.Drawing.Color.White;
            this.circularLabel2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularLabel2.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.circularLabel2.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularLabel2.Appearance.Options.UseBackColor = true;
            this.circularLabel2.Appearance.Options.UseBorderColor = true;
            this.circularLabel2.Appearance.Options.UseFont = true;
            this.circularLabel2.Location = new System.Drawing.Point(5, 56);
            this.circularLabel2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.circularLabel2.Name = "circularLabel2";
            this.circularLabel2.Padding = new System.Windows.Forms.Padding(5);
            this.circularLabel2.Size = new System.Drawing.Size(66, 32);
            this.circularLabel2.TabIndex = 2;
            this.circularLabel2.Text = "Mã SV";
            // 
            // circularLabel5
            // 
            this.circularLabel5.Appearance.BackColor = System.Drawing.Color.White;
            this.circularLabel5.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularLabel5.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.circularLabel5.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularLabel5.Appearance.Options.UseBackColor = true;
            this.circularLabel5.Appearance.Options.UseBorderColor = true;
            this.circularLabel5.Appearance.Options.UseFont = true;
            this.circularLabel5.Location = new System.Drawing.Point(382, 56);
            this.circularLabel5.LookAndFeel.UseDefaultLookAndFeel = false;
            this.circularLabel5.Name = "circularLabel5";
            this.circularLabel5.Padding = new System.Windows.Forms.Padding(5);
            this.circularLabel5.Size = new System.Drawing.Size(85, 32);
            this.circularLabel5.TabIndex = 2;
            this.circularLabel5.Text = "Giới tính";
            // 
            // circularLabel3
            // 
            this.circularLabel3.Appearance.BackColor = System.Drawing.Color.White;
            this.circularLabel3.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularLabel3.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.circularLabel3.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularLabel3.Appearance.Options.UseBackColor = true;
            this.circularLabel3.Appearance.Options.UseBorderColor = true;
            this.circularLabel3.Appearance.Options.UseFont = true;
            this.circularLabel3.Location = new System.Drawing.Point(5, 103);
            this.circularLabel3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.circularLabel3.Name = "circularLabel3";
            this.circularLabel3.Padding = new System.Windows.Forms.Padding(5);
            this.circularLabel3.Size = new System.Drawing.Size(73, 32);
            this.circularLabel3.TabIndex = 2;
            this.circularLabel3.Text = "Tên SV";
            // 
            // circularLabel6
            // 
            this.circularLabel6.Appearance.BackColor = System.Drawing.Color.White;
            this.circularLabel6.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularLabel6.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.circularLabel6.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularLabel6.Appearance.Options.UseBackColor = true;
            this.circularLabel6.Appearance.Options.UseBorderColor = true;
            this.circularLabel6.Appearance.Options.UseFont = true;
            this.circularLabel6.Location = new System.Drawing.Point(382, 103);
            this.circularLabel6.LookAndFeel.UseDefaultLookAndFeel = false;
            this.circularLabel6.Name = "circularLabel6";
            this.circularLabel6.Padding = new System.Windows.Forms.Padding(5);
            this.circularLabel6.Size = new System.Drawing.Size(81, 32);
            this.circularLabel6.TabIndex = 2;
            this.circularLabel6.Text = "Nơi sinh";
            // 
            // circularLabel8
            // 
            this.circularLabel8.Appearance.BackColor = System.Drawing.Color.Linen;
            this.circularLabel8.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularLabel8.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.circularLabel8.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularLabel8.Appearance.Options.UseBackColor = true;
            this.circularLabel8.Appearance.Options.UseBorderColor = true;
            this.circularLabel8.Appearance.Options.UseFont = true;
            this.circularLabel8.Location = new System.Drawing.Point(713, 56);
            this.circularLabel8.LookAndFeel.UseDefaultLookAndFeel = false;
            this.circularLabel8.Name = "circularLabel8";
            this.circularLabel8.Padding = new System.Windows.Forms.Padding(5);
            this.circularLabel8.Size = new System.Drawing.Size(129, 32);
            this.circularLabel8.TabIndex = 2;
            this.circularLabel8.Text = "TB toàn khóa";
            // 
            // circularLabel9
            // 
            this.circularLabel9.Appearance.BackColor = System.Drawing.Color.Linen;
            this.circularLabel9.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularLabel9.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.circularLabel9.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularLabel9.Appearance.Options.UseBackColor = true;
            this.circularLabel9.Appearance.Options.UseBorderColor = true;
            this.circularLabel9.Appearance.Options.UseFont = true;
            this.circularLabel9.Location = new System.Drawing.Point(713, 106);
            this.circularLabel9.LookAndFeel.UseDefaultLookAndFeel = false;
            this.circularLabel9.Name = "circularLabel9";
            this.circularLabel9.Padding = new System.Windows.Forms.Padding(5);
            this.circularLabel9.Size = new System.Drawing.Size(178, 32);
            this.circularLabel9.TabIndex = 2;
            this.circularLabel9.Text = "Xếp loại toàn khóa";
            // 
            // circularLabel4
            // 
            this.circularLabel4.Appearance.BackColor = System.Drawing.Color.White;
            this.circularLabel4.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularLabel4.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.circularLabel4.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularLabel4.Appearance.Options.UseBackColor = true;
            this.circularLabel4.Appearance.Options.UseBorderColor = true;
            this.circularLabel4.Appearance.Options.UseFont = true;
            this.circularLabel4.Location = new System.Drawing.Point(3, 153);
            this.circularLabel4.LookAndFeel.UseDefaultLookAndFeel = false;
            this.circularLabel4.Name = "circularLabel4";
            this.circularLabel4.Padding = new System.Windows.Forms.Padding(5);
            this.circularLabel4.Size = new System.Drawing.Size(98, 32);
            this.circularLabel4.TabIndex = 2;
            this.circularLabel4.Text = "Ngày sinh";
            // 
            // circularLabel7
            // 
            this.circularLabel7.Appearance.BackColor = System.Drawing.Color.White;
            this.circularLabel7.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularLabel7.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.circularLabel7.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularLabel7.Appearance.Options.UseBackColor = true;
            this.circularLabel7.Appearance.Options.UseBorderColor = true;
            this.circularLabel7.Appearance.Options.UseFont = true;
            this.circularLabel7.Location = new System.Drawing.Point(382, 153);
            this.circularLabel7.LookAndFeel.UseDefaultLookAndFeel = false;
            this.circularLabel7.Name = "circularLabel7";
            this.circularLabel7.Padding = new System.Windows.Forms.Padding(5);
            this.circularLabel7.Size = new System.Drawing.Size(79, 32);
            this.circularLabel7.TabIndex = 2;
            this.circularLabel7.Text = "Dân tộc";
            // 
            // lbMaSV
            // 
            this.lbMaSV.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbMaSV.Appearance.Options.UseFont = true;
            this.lbMaSV.Location = new System.Drawing.Point(93, 56);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Padding = new System.Windows.Forms.Padding(5);
            this.lbMaSV.Size = new System.Drawing.Size(42, 32);
            this.lbMaSV.TabIndex = 3;
            this.lbMaSV.Text = "null";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbGioiTinh.Appearance.Options.UseFont = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(473, 56);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Padding = new System.Windows.Forms.Padding(5);
            this.lbGioiTinh.Size = new System.Drawing.Size(42, 32);
            this.lbGioiTinh.TabIndex = 3;
            this.lbGioiTinh.Text = "null";
            // 
            // lbNoiSinh
            // 
            this.lbNoiSinh.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbNoiSinh.Appearance.Options.UseFont = true;
            this.lbNoiSinh.Location = new System.Drawing.Point(473, 103);
            this.lbNoiSinh.Name = "lbNoiSinh";
            this.lbNoiSinh.Padding = new System.Windows.Forms.Padding(5);
            this.lbNoiSinh.Size = new System.Drawing.Size(42, 32);
            this.lbNoiSinh.TabIndex = 3;
            this.lbNoiSinh.Text = "null";
            // 
            // lblTB
            // 
            this.lblTB.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblTB.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTB.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblTB.Appearance.Options.UseBackColor = true;
            this.lblTB.Appearance.Options.UseFont = true;
            this.lblTB.Appearance.Options.UseForeColor = true;
            this.lblTB.Location = new System.Drawing.Point(918, 56);
            this.lblTB.Name = "lblTB";
            this.lblTB.Padding = new System.Windows.Forms.Padding(5);
            this.lblTB.Size = new System.Drawing.Size(48, 32);
            this.lblTB.TabIndex = 3;
            this.lblTB.Text = "null";
            // 
            // lbDanToc
            // 
            this.lbDanToc.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbDanToc.Appearance.Options.UseFont = true;
            this.lbDanToc.Location = new System.Drawing.Point(473, 153);
            this.lbDanToc.Name = "lbDanToc";
            this.lbDanToc.Padding = new System.Windows.Forms.Padding(5);
            this.lbDanToc.Size = new System.Drawing.Size(42, 32);
            this.lbDanToc.TabIndex = 3;
            this.lbDanToc.Text = "null";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.btnXuatExcel);
            this.panelControl4.Controls.Add(this.circularLabel1);
            this.panelControl4.Controls.Add(this.lblTinChiDat);
            this.panelControl4.Controls.Add(this.lblXL);
            this.panelControl4.Controls.Add(this.lbDanToc);
            this.panelControl4.Controls.Add(this.lblTB);
            this.panelControl4.Controls.Add(this.circularLabel2);
            this.panelControl4.Controls.Add(this.circularLabel10);
            this.panelControl4.Controls.Add(this.circularLabel9);
            this.panelControl4.Controls.Add(this.lbNgaySinh);
            this.panelControl4.Controls.Add(this.circularLabel8);
            this.panelControl4.Controls.Add(this.circularLabel3);
            this.panelControl4.Controls.Add(this.lbNoiSinh);
            this.panelControl4.Controls.Add(this.circularLabel4);
            this.panelControl4.Controls.Add(this.lbGioiTinh);
            this.panelControl4.Controls.Add(this.lbMaSV);
            this.panelControl4.Controls.Add(this.circularLabel7);
            this.panelControl4.Controls.Add(this.lbTenSV);
            this.panelControl4.Controls.Add(this.circularLabel5);
            this.panelControl4.Controls.Add(this.circularLabel6);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(2, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1226, 207);
            this.panelControl4.TabIndex = 4;
            // 
            // lblTinChiDat
            // 
            this.lblTinChiDat.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblTinChiDat.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinChiDat.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblTinChiDat.Appearance.Options.UseBackColor = true;
            this.lblTinChiDat.Appearance.Options.UseFont = true;
            this.lblTinChiDat.Appearance.Options.UseForeColor = true;
            this.lblTinChiDat.Location = new System.Drawing.Point(918, 161);
            this.lblTinChiDat.Name = "lblTinChiDat";
            this.lblTinChiDat.Padding = new System.Windows.Forms.Padding(5);
            this.lblTinChiDat.Size = new System.Drawing.Size(48, 32);
            this.lblTinChiDat.TabIndex = 3;
            this.lblTinChiDat.Text = "null";
            // 
            // lblXL
            // 
            this.lblXL.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblXL.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXL.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblXL.Appearance.Options.UseBackColor = true;
            this.lblXL.Appearance.Options.UseFont = true;
            this.lblXL.Appearance.Options.UseForeColor = true;
            this.lblXL.Location = new System.Drawing.Point(918, 106);
            this.lblXL.Name = "lblXL";
            this.lblXL.Padding = new System.Windows.Forms.Padding(5);
            this.lblXL.Size = new System.Drawing.Size(48, 32);
            this.lblXL.TabIndex = 3;
            this.lblXL.Text = "null";
            // 
            // circularLabel10
            // 
            this.circularLabel10.Appearance.BackColor = System.Drawing.Color.Linen;
            this.circularLabel10.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularLabel10.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.circularLabel10.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularLabel10.Appearance.Options.UseBackColor = true;
            this.circularLabel10.Appearance.Options.UseBorderColor = true;
            this.circularLabel10.Appearance.Options.UseFont = true;
            this.circularLabel10.Location = new System.Drawing.Point(713, 161);
            this.circularLabel10.LookAndFeel.UseDefaultLookAndFeel = false;
            this.circularLabel10.Name = "circularLabel10";
            this.circularLabel10.Padding = new System.Windows.Forms.Padding(5);
            this.circularLabel10.Size = new System.Drawing.Size(149, 32);
            this.circularLabel10.TabIndex = 2;
            this.circularLabel10.Text = "Tổng tín chỉ đạt";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbNgaySinh.Appearance.Options.UseFont = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(121, 153);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Padding = new System.Windows.Forms.Padding(5);
            this.lbNgaySinh.Size = new System.Drawing.Size(42, 32);
            this.lbNgaySinh.TabIndex = 3;
            this.lbNgaySinh.Text = "null";
            // 
            // lbTenSV
            // 
            this.lbTenSV.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbTenSV.Appearance.Options.UseFont = true;
            this.lbTenSV.Location = new System.Drawing.Point(93, 103);
            this.lbTenSV.Name = "lbTenSV";
            this.lbTenSV.Padding = new System.Windows.Forms.Padding(5);
            this.lbTenSV.Size = new System.Drawing.Size(42, 32);
            this.lbTenSV.TabIndex = 3;
            this.lbTenSV.Text = "null";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcDiemCT);
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(416, 0);
            this.panelControl2.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1230, 648);
            this.panelControl2.TabIndex = 1;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(222)))), ((int)(((byte)(33)))));
            this.btnXuatExcel.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(186)))), ((int)(((byte)(51)))));
            this.btnXuatExcel.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Appearance.Options.UseBackColor = true;
            this.btnXuatExcel.Appearance.Options.UseBorderColor = true;
            this.btnXuatExcel.Appearance.Options.UseFont = true;
            this.btnXuatExcel.Appearance.Options.UseForeColor = true;
            this.btnXuatExcel.Location = new System.Drawing.Point(1014, 77);
            this.btnXuatExcel.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.btnXuatExcel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnXuatExcel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Padding = new System.Windows.Forms.Padding(3);
            this.btnXuatExcel.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnXuatExcel.Size = new System.Drawing.Size(153, 49);
            this.btnXuatExcel.TabIndex = 4;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // frmBangDiemFull
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1646, 648);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmBangDiemFull";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBangDiemFull";
            this.Load += new System.EventHandler(this.frmBangDiemFull_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopSelectAllResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circularPanel1)).EndInit();
            this.circularPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDiemCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit luLop;
        private System.Windows.Forms.BindingSource lopSelectAllResultBindingSource;
        private System.Windows.Forms.TreeView treeSV;
        private CircularPanel circularPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcDiemCT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private CircularLabel circularLabel1;
        private CircularLabel circularLabel2;
        private CircularLabel circularLabel5;
        private CircularLabel circularLabel3;
        private CircularLabel circularLabel6;
        private CircularLabel circularLabel8;
        private CircularLabel circularLabel9;
        private CircularLabel circularLabel4;
        private CircularLabel circularLabel7;
        private DevExpress.XtraEditors.LabelControl lbMaSV;
        private DevExpress.XtraEditors.LabelControl lbGioiTinh;
        private DevExpress.XtraEditors.LabelControl lbNoiSinh;
        private DevExpress.XtraEditors.LabelControl lblTB;
        private DevExpress.XtraEditors.LabelControl lbDanToc;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl lblXL;
        private DevExpress.XtraEditors.LabelControl lbNgaySinh;
        private DevExpress.XtraEditors.LabelControl lbTenSV;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.LabelControl lblTinChiDat;
        private CircularLabel circularLabel10;
        private CircularButton btnXuatExcel;
    }
}