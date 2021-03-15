
namespace QuanLyDiem
{
    partial class frmGiaoVienHinhAnh
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
            this.gcGV = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLink = new DevExpress.XtraEditors.SimpleButton();
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            this.luChonTheoCV = new DevExpress.XtraEditors.LookUpEdit();
            this.txtIDgvIMG = new DevExpress.XtraEditors.TextEdit();
            this.imgGV = new DevExpress.XtraEditors.PictureEdit();
            this.txtMaGV = new DevExpress.XtraEditors.TextEdit();
            this.txtFile = new DevExpress.XtraEditors.TextEdit();
            this.luTenGV = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForMaSV1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForIMG = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForGiaoVien = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMaGV = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFileIMG2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForGV_IMG = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnDuongDan = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuongDan1 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gcGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luChonTheoCV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDgvIMG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luTenGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaSV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFileIMG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGV_IMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcGV
            // 
            this.gcGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcGV.Location = new System.Drawing.Point(0, 0);
            this.gcGV.MainView = this.gridView1;
            this.gcGV.Name = "gcGV";
            this.gcGV.Size = new System.Drawing.Size(781, 604);
            this.gcGV.TabIndex = 0;
            this.gcGV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gcGV;
            this.gridView1.GroupPanelText = "IMAGE";
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên GV";
            this.gridColumn1.FieldName = "TenGV";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 329;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "IMG";
            this.gridColumn2.FieldName = "IMG";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 195;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mã GV";
            this.gridColumn3.FieldName = "MaGV";
            this.gridColumn3.MinWidth = 30;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 221;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.btnXoa);
            this.dataLayoutControl1.Controls.Add(this.btnLink);
            this.dataLayoutControl1.Controls.Add(this.controlNavigator1);
            this.dataLayoutControl1.Controls.Add(this.luChonTheoCV);
            this.dataLayoutControl1.Controls.Add(this.txtIDgvIMG);
            this.dataLayoutControl1.Controls.Add(this.imgGV);
            this.dataLayoutControl1.Controls.Add(this.txtMaGV);
            this.dataLayoutControl1.Controls.Add(this.txtFile);
            this.dataLayoutControl1.Controls.Add(this.luTenGV);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(2, 2);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(579, 600);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(12, 136);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(555, 32);
            this.btnXoa.StyleController = this.dataLayoutControl1;
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa HA";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLink
            // 
            this.btnLink.Location = new System.Drawing.Point(291, 100);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(276, 32);
            this.btnLink.StyleController = this.dataLayoutControl1;
            this.btnLink.TabIndex = 19;
            this.btnLink.Text = "--Đường dẫn--";
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // controlNavigator1
            // 
            this.controlNavigator1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlNavigator1.Appearance.Options.UseFont = true;
            this.controlNavigator1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.controlNavigator1.Location = new System.Drawing.Point(12, 12);
            this.controlNavigator1.Name = "controlNavigator1";
            this.controlNavigator1.NavigatableControl = this.gcGV;
            this.controlNavigator1.Padding = new System.Windows.Forms.Padding(2);
            this.controlNavigator1.Size = new System.Drawing.Size(555, 40);
            this.controlNavigator1.StyleController = this.dataLayoutControl1;
            this.controlNavigator1.TabIndex = 13;
            this.controlNavigator1.Text = "controlNavigator1";
            this.controlNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
            this.controlNavigator1.TextStringFormat = "Tổng GV {0} / {1}";
            // 
            // luChonTheoCV
            // 
            this.luChonTheoCV.Location = new System.Drawing.Point(184, 63);
            this.luChonTheoCV.Margin = new System.Windows.Forms.Padding(4);
            this.luChonTheoCV.Name = "luChonTheoCV";
            this.luChonTheoCV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luChonTheoCV.Properties.NullText = "";
            this.luChonTheoCV.Size = new System.Drawing.Size(374, 26);
            this.luChonTheoCV.StyleController = this.dataLayoutControl1;
            this.luChonTheoCV.TabIndex = 8;
            this.luChonTheoCV.EditValueChanged += new System.EventHandler(this.luChonTheoCV_EditValueChanged);
            // 
            // txtIDgvIMG
            // 
            this.txtIDgvIMG.Location = new System.Drawing.Point(454, 172);
            this.txtIDgvIMG.Name = "txtIDgvIMG";
            this.txtIDgvIMG.Size = new System.Drawing.Size(113, 26);
            this.txtIDgvIMG.StyleController = this.dataLayoutControl1;
            this.txtIDgvIMG.TabIndex = 14;
            // 
            // imgGV
            // 
            this.imgGV.Location = new System.Drawing.Point(12, 212);
            this.imgGV.Name = "imgGV";
            this.imgGV.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.imgGV.Size = new System.Drawing.Size(555, 344);
            this.imgGV.StyleController = this.dataLayoutControl1;
            this.imgGV.TabIndex = 15;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(175, 172);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(112, 26);
            this.txtMaGV.StyleController = this.dataLayoutControl1;
            this.txtMaGV.TabIndex = 16;
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(12, 100);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(275, 26);
            this.txtFile.StyleController = this.dataLayoutControl1;
            this.txtFile.TabIndex = 17;
            // 
            // luTenGV
            // 
            this.luTenGV.Location = new System.Drawing.Point(176, 561);
            this.luTenGV.Name = "luTenGV";
            this.luTenGV.Size = new System.Drawing.Size(390, 26);
            this.luTenGV.StyleController = this.dataLayoutControl1;
            this.luTenGV.TabIndex = 18;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.ItemForMaSV1,
            this.layoutControlGroup1,
            this.ItemForMaGV,
            this.ItemForFileIMG2,
            this.layoutControlItem2,
            this.ItemForGV_IMG,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(579, 600);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.controlNavigator1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(559, 44);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 190);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(559, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForMaSV1
            // 
            this.ItemForMaSV1.Control = this.luChonTheoCV;
            this.ItemForMaSV1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.ItemForMaSV1.CustomizationFormText = "Ma SV";
            this.ItemForMaSV1.Location = new System.Drawing.Point(0, 44);
            this.ItemForMaSV1.Name = "ItemForMaSV1";
            this.ItemForMaSV1.Padding = new DevExpress.XtraLayout.Utils.Padding(11, 11, 9, 9);
            this.ItemForMaSV1.Size = new System.Drawing.Size(559, 44);
            this.ItemForMaSV1.Text = "Chọn Theo Chức Vụ";
            this.ItemForMaSV1.TextSize = new System.Drawing.Size(160, 18);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForIMG,
            this.ItemForGiaoVien});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 200);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(559, 380);
            // 
            // ItemForIMG
            // 
            this.ItemForIMG.Control = this.imgGV;
            this.ItemForIMG.Location = new System.Drawing.Point(0, 0);
            this.ItemForIMG.Name = "ItemForIMG";
            this.ItemForIMG.Size = new System.Drawing.Size(559, 348);
            this.ItemForIMG.StartNewLine = true;
            this.ItemForIMG.Text = "IMG";
            this.ItemForIMG.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForIMG.TextVisible = false;
            // 
            // ItemForGiaoVien
            // 
            this.ItemForGiaoVien.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForGiaoVien.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ItemForGiaoVien.Control = this.luTenGV;
            this.ItemForGiaoVien.Location = new System.Drawing.Point(0, 348);
            this.ItemForGiaoVien.Name = "ItemForGiaoVien";
            this.ItemForGiaoVien.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.ItemForGiaoVien.Size = new System.Drawing.Size(559, 32);
            this.ItemForGiaoVien.Text = "Tên GV";
            this.ItemForGiaoVien.TextSize = new System.Drawing.Size(160, 18);
            // 
            // ItemForMaGV
            // 
            this.ItemForMaGV.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForMaGV.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ItemForMaGV.Control = this.txtMaGV;
            this.ItemForMaGV.Location = new System.Drawing.Point(0, 160);
            this.ItemForMaGV.Name = "ItemForMaGV";
            this.ItemForMaGV.Size = new System.Drawing.Size(279, 30);
            this.ItemForMaGV.Text = "Mã GV";
            this.ItemForMaGV.TextSize = new System.Drawing.Size(160, 18);
            // 
            // ItemForFileIMG2
            // 
            this.ItemForFileIMG2.Control = this.txtFile;
            this.ItemForFileIMG2.Location = new System.Drawing.Point(0, 88);
            this.ItemForFileIMG2.Name = "ItemForFileIMG2";
            this.ItemForFileIMG2.Size = new System.Drawing.Size(279, 36);
            this.ItemForFileIMG2.Text = "File IMG";
            this.ItemForFileIMG2.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForFileIMG2.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnLink;
            this.layoutControlItem2.Location = new System.Drawing.Point(279, 88);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(280, 36);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ItemForGV_IMG
            // 
            this.ItemForGV_IMG.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForGV_IMG.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ItemForGV_IMG.Control = this.txtIDgvIMG;
            this.ItemForGV_IMG.Location = new System.Drawing.Point(279, 160);
            this.ItemForGV_IMG.Name = "ItemForGV_IMG";
            this.ItemForGV_IMG.Size = new System.Drawing.Size(280, 30);
            this.ItemForGV_IMG.Text = "GV_IMG";
            this.ItemForGV_IMG.TextSize = new System.Drawing.Size(160, 18);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnXoa;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 124);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(559, 36);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // btnDuongDan
            // 
            this.btnDuongDan.Location = new System.Drawing.Point(291, 100);
            this.btnDuongDan.Name = "btnDuongDan";
            this.btnDuongDan.Size = new System.Drawing.Size(276, 32);
            this.btnDuongDan.TabIndex = 18;
            this.btnDuongDan.Text = "-- Đường dẫn --";
            // 
            // btnDuongDan1
            // 
            this.btnDuongDan1.Location = new System.Drawing.Point(291, 100);
            this.btnDuongDan1.Name = "btnDuongDan1";
            this.btnDuongDan1.Size = new System.Drawing.Size(276, 32);
            this.btnDuongDan1.TabIndex = 18;
            this.btnDuongDan1.Text = "-- Đường dẫn --";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dataLayoutControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(583, 604);
            this.panelControl2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gcGV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(583, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 604);
            this.panel1.TabIndex = 3;
            // 
            // frmGiaoVienHinhAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelControl2);
            this.Name = "frmGiaoVienHinhAnh";
            this.Text = "frmGiaoVienHinhAnh";
            this.Load += new System.EventHandler(this.frmGiaoVienHinhAnh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luChonTheoCV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDgvIMG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luTenGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaSV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFileIMG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGV_IMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnDuongDan;
        private DevExpress.XtraEditors.SimpleButton btnDuongDan1;
        private DevExpress.XtraEditors.LookUpEdit luChonTheoCV;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMaSV1;
        private DevExpress.XtraEditors.TextEdit txtIDgvIMG;
        private DevExpress.XtraEditors.PictureEdit imgGV;
        private DevExpress.XtraEditors.TextEdit txtMaGV;
        private DevExpress.XtraEditors.TextEdit txtFile;
        private DevExpress.XtraEditors.TextEdit luTenGV;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGV_IMG;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIMG;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMaGV;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFileIMG2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGiaoVien;
        private DevExpress.XtraEditors.SimpleButton btnLink;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.GridControl gcGV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}