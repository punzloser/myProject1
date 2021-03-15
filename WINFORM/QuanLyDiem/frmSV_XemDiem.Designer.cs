
namespace QuanLyDiem
{
    partial class frmSV_XemDiem
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleIconSet formatConditionRuleIconSet1 = new DevExpress.XtraEditors.FormatConditionRuleIconSet();
            DevExpress.XtraEditors.FormatConditionIconSet formatConditionIconSet1 = new DevExpress.XtraEditors.FormatConditionIconSet();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon1 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon2 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon3 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon4 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSV_XemDiem));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRule3ColorScale formatConditionRule3ColorScale1 = new DevExpress.XtraEditors.FormatConditionRule3ColorScale();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleIconSet formatConditionRuleIconSet2 = new DevExpress.XtraEditors.FormatConditionRuleIconSet();
            DevExpress.XtraEditors.FormatConditionIconSet formatConditionIconSet2 = new DevExpress.XtraEditors.FormatConditionIconSet();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon5 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon6 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon7 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            this.colCheckKQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChuyenCan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiemHP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiemHe4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.luHK = new DevExpress.XtraEditors.LookUpEdit();
            this.lbTenSV = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcXemDiem = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaMonHP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenMonHP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiuaKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuoiKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiemChu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luHK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcXemDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // colCheckKQ
            // 
            this.colCheckKQ.Caption = "Check KQ";
            this.colCheckKQ.FieldName = "Check";
            this.colCheckKQ.MinWidth = 30;
            this.colCheckKQ.Name = "colCheckKQ";
            this.colCheckKQ.OptionsColumn.AllowEdit = false;
            this.colCheckKQ.OptionsColumn.AllowFocus = false;
            this.colCheckKQ.OptionsColumn.AllowMove = false;
            this.colCheckKQ.OptionsColumn.AllowShowHide = false;
            this.colCheckKQ.OptionsColumn.AllowSize = false;
            this.colCheckKQ.Width = 112;
            // 
            // colKQ
            // 
            this.colKQ.AppearanceCell.Options.UseTextOptions = true;
            this.colKQ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKQ.AppearanceHeader.Options.UseTextOptions = true;
            this.colKQ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKQ.Caption = "Kết Quả";
            this.colKQ.FieldName = "KetQua";
            this.colKQ.MinWidth = 30;
            this.colKQ.Name = "colKQ";
            this.colKQ.OptionsColumn.AllowEdit = false;
            this.colKQ.OptionsColumn.AllowFocus = false;
            this.colKQ.OptionsColumn.AllowMove = false;
            this.colKQ.OptionsColumn.AllowShowHide = false;
            this.colKQ.OptionsColumn.AllowSize = false;
            this.colKQ.Visible = true;
            this.colKQ.VisibleIndex = 9;
            this.colKQ.Width = 176;
            // 
            // colChuyenCan
            // 
            this.colChuyenCan.AppearanceCell.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colChuyenCan.AppearanceCell.Options.UseFont = true;
            this.colChuyenCan.AppearanceCell.Options.UseTextOptions = true;
            this.colChuyenCan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colChuyenCan.AppearanceHeader.Options.UseTextOptions = true;
            this.colChuyenCan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colChuyenCan.Caption = "Chuyên Cần";
            this.colChuyenCan.FieldName = "ChuyenCan";
            this.colChuyenCan.MinWidth = 30;
            this.colChuyenCan.Name = "colChuyenCan";
            this.colChuyenCan.OptionsColumn.AllowEdit = false;
            this.colChuyenCan.OptionsColumn.AllowFocus = false;
            this.colChuyenCan.OptionsColumn.AllowMove = false;
            this.colChuyenCan.OptionsColumn.AllowShowHide = false;
            this.colChuyenCan.OptionsColumn.AllowSize = false;
            this.colChuyenCan.Visible = true;
            this.colChuyenCan.VisibleIndex = 3;
            this.colChuyenCan.Width = 137;
            // 
            // colDiemHP
            // 
            this.colDiemHP.AppearanceCell.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDiemHP.AppearanceCell.Options.UseFont = true;
            this.colDiemHP.AppearanceCell.Options.UseTextOptions = true;
            this.colDiemHP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiemHP.AppearanceHeader.Options.UseTextOptions = true;
            this.colDiemHP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiemHP.Caption = "Điểm HP";
            this.colDiemHP.FieldName = "DiemHP";
            this.colDiemHP.MinWidth = 30;
            this.colDiemHP.Name = "colDiemHP";
            this.colDiemHP.OptionsColumn.AllowEdit = false;
            this.colDiemHP.OptionsColumn.AllowFocus = false;
            this.colDiemHP.OptionsColumn.AllowMove = false;
            this.colDiemHP.OptionsColumn.AllowShowHide = false;
            this.colDiemHP.OptionsColumn.AllowSize = false;
            this.colDiemHP.Visible = true;
            this.colDiemHP.VisibleIndex = 6;
            this.colDiemHP.Width = 133;
            // 
            // colSoTin
            // 
            this.colSoTin.AppearanceCell.Options.UseTextOptions = true;
            this.colSoTin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoTin.AppearanceHeader.Options.UseTextOptions = true;
            this.colSoTin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoTin.Caption = "Số Tín";
            this.colSoTin.FieldName = "SoTin";
            this.colSoTin.MinWidth = 30;
            this.colSoTin.Name = "colSoTin";
            this.colSoTin.OptionsColumn.AllowEdit = false;
            this.colSoTin.OptionsColumn.AllowFocus = false;
            this.colSoTin.OptionsColumn.AllowMove = false;
            this.colSoTin.OptionsColumn.AllowShowHide = false;
            this.colSoTin.OptionsColumn.AllowSize = false;
            this.colSoTin.Visible = true;
            this.colSoTin.VisibleIndex = 2;
            this.colSoTin.Width = 133;
            // 
            // colDiemHe4
            // 
            this.colDiemHe4.AppearanceCell.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDiemHe4.AppearanceCell.Options.UseFont = true;
            this.colDiemHe4.AppearanceCell.Options.UseTextOptions = true;
            this.colDiemHe4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiemHe4.AppearanceHeader.Options.UseTextOptions = true;
            this.colDiemHe4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiemHe4.Caption = "Điểm Hệ 4";
            this.colDiemHe4.FieldName = "DiemHe4";
            this.colDiemHe4.MinWidth = 30;
            this.colDiemHe4.Name = "colDiemHe4";
            this.colDiemHe4.OptionsColumn.AllowEdit = false;
            this.colDiemHe4.OptionsColumn.AllowFocus = false;
            this.colDiemHe4.OptionsColumn.AllowMove = false;
            this.colDiemHe4.OptionsColumn.AllowShowHide = false;
            this.colDiemHe4.OptionsColumn.AllowSize = false;
            this.colDiemHe4.Visible = true;
            this.colDiemHe4.VisibleIndex = 8;
            this.colDiemHe4.Width = 133;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.luHK);
            this.panelControl1.Controls.Add(this.lbTenSV);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1796, 63);
            this.panelControl1.TabIndex = 0;
            // 
            // luHK
            // 
            this.luHK.Location = new System.Drawing.Point(1005, 20);
            this.luHK.Name = "luHK";
            this.luHK.Properties.Appearance.Options.UseTextOptions = true;
            this.luHK.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.luHK.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.SaddleBrown;
            this.luHK.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.luHK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luHK.Properties.LookAndFeel.SkinName = "Caramel";
            this.luHK.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.luHK.Properties.NullText = "[Chọn HK]";
            this.luHK.Size = new System.Drawing.Size(216, 27);
            this.luHK.TabIndex = 1;
            this.luHK.EditValueChanged += new System.EventHandler(this.luHK_EditValueChanged);
            // 
            // lbTenSV
            // 
            this.lbTenSV.Appearance.Font = new System.Drawing.Font("Verdana", 15F);
            this.lbTenSV.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbTenSV.Appearance.Options.UseFont = true;
            this.lbTenSV.Appearance.Options.UseForeColor = true;
            this.lbTenSV.Location = new System.Drawing.Point(618, 12);
            this.lbTenSV.Name = "lbTenSV";
            this.lbTenSV.Size = new System.Drawing.Size(77, 36);
            this.lbTenSV.TabIndex = 0;
            this.lbTenSV.Text = "None";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 13F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(56, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(479, 32);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "++ XEM THÔNG TIN ĐIỂM  ++  SV :";
            // 
            // gcXemDiem
            // 
            this.gcXemDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcXemDiem.Location = new System.Drawing.Point(0, 63);
            this.gcXemDiem.MainView = this.gridView1;
            this.gcXemDiem.Name = "gcXemDiem";
            this.gcXemDiem.Size = new System.Drawing.Size(1796, 542);
            this.gcXemDiem.TabIndex = 7;
            this.gcXemDiem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaMonHP,
            this.colTenMonHP,
            this.colSoTin,
            this.colChuyenCan,
            this.colGiuaKy,
            this.colCuoiKy,
            this.colDiemHP,
            this.colDiemChu,
            this.colDiemHe4,
            this.colKQ,
            this.colCheckKQ});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            gridFormatRule1.Column = this.colCheckKQ;
            gridFormatRule1.ColumnApplyTo = this.colKQ;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleIconSet1.AllowAnimation = DevExpress.Utils.DefaultBoolean.True;
            formatConditionIconSet1.CategoryName = "Symbols";
            formatConditionIconSetIcon1.PredefinedName = "Symbols3_1.png";
            formatConditionIconSetIcon1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            formatConditionIconSetIcon1.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon2.PredefinedName = "Symbols3_2.png";
            formatConditionIconSetIcon2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            formatConditionIconSetIcon2.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon3.PredefinedName = "Symbols3_3.png";
            formatConditionIconSetIcon3.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            formatConditionIconSetIcon3.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon4.Icon = ((System.Drawing.Image)(resources.GetObject("formatConditionIconSetIcon4.Icon")));
            formatConditionIconSetIcon4.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            formatConditionIconSetIcon4.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon1);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon2);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon3);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon4);
            formatConditionIconSet1.Name = "Symbols3Uncircled";
            formatConditionIconSet1.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRuleIconSet1.IconSet = formatConditionIconSet1;
            gridFormatRule1.Rule = formatConditionRuleIconSet1;
            gridFormatRule2.Column = this.colChuyenCan;
            gridFormatRule2.Name = "Format1";
            formatConditionRule3ColorScale1.AllowAnimation = DevExpress.Utils.DefaultBoolean.True;
            formatConditionRule3ColorScale1.AutomaticType = DevExpress.XtraEditors.FormatConditionAutomaticType.ValueBased;
            formatConditionRule3ColorScale1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            formatConditionRule3ColorScale1.MaximumColor = System.Drawing.Color.Lime;
            formatConditionRule3ColorScale1.MaximumType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRule3ColorScale1.Middle = new decimal(new int[] {
            5,
            0,
            0,
            0});
            formatConditionRule3ColorScale1.MiddleColor = System.Drawing.Color.Yellow;
            formatConditionRule3ColorScale1.MiddleType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRule3ColorScale1.MinimumColor = System.Drawing.Color.Red;
            formatConditionRule3ColorScale1.MinimumType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRule3ColorScale1.PredefinedName = "Green, Yellow, Red";
            gridFormatRule2.Rule = formatConditionRule3ColorScale1;
            gridFormatRule3.Column = this.colDiemHP;
            gridFormatRule3.Name = "Format2";
            formatConditionRuleIconSet2.AllowAnimation = DevExpress.Utils.DefaultBoolean.True;
            formatConditionIconSet2.CategoryName = "Ratings";
            formatConditionIconSetIcon5.PredefinedName = "Stars3_1.png";
            formatConditionIconSetIcon5.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            formatConditionIconSetIcon5.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon6.PredefinedName = "Stars3_2.png";
            formatConditionIconSetIcon6.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            formatConditionIconSetIcon6.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon7.PredefinedName = "Stars3_3.png";
            formatConditionIconSetIcon7.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSet2.Icons.Add(formatConditionIconSetIcon5);
            formatConditionIconSet2.Icons.Add(formatConditionIconSetIcon6);
            formatConditionIconSet2.Icons.Add(formatConditionIconSetIcon7);
            formatConditionIconSet2.Name = "Stars3";
            formatConditionIconSet2.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRuleIconSet2.IconSet = formatConditionIconSet2;
            gridFormatRule3.Rule = formatConditionRuleIconSet2;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.FormatRules.Add(gridFormatRule2);
            this.gridView1.FormatRules.Add(gridFormatRule3);
            this.gridView1.GridControl = this.gcXemDiem;
            this.gridView1.GroupPanelText = "XEM ĐIỂM";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsMenu.EnableGroupRowMenu = true;
            this.gridView1.OptionsMenu.ShowConditionalFormattingItem = true;
            // 
            // colMaMonHP
            // 
            this.colMaMonHP.AppearanceCell.Options.UseTextOptions = true;
            this.colMaMonHP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaMonHP.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaMonHP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaMonHP.Caption = "Mã Môn HP";
            this.colMaMonHP.FieldName = "MaMonHP";
            this.colMaMonHP.MinWidth = 30;
            this.colMaMonHP.Name = "colMaMonHP";
            this.colMaMonHP.OptionsColumn.AllowEdit = false;
            this.colMaMonHP.OptionsColumn.AllowFocus = false;
            this.colMaMonHP.OptionsColumn.AllowMove = false;
            this.colMaMonHP.OptionsColumn.AllowShowHide = false;
            this.colMaMonHP.OptionsColumn.AllowSize = false;
            this.colMaMonHP.Visible = true;
            this.colMaMonHP.VisibleIndex = 0;
            this.colMaMonHP.Width = 164;
            // 
            // colTenMonHP
            // 
            this.colTenMonHP.AppearanceCell.Options.UseTextOptions = true;
            this.colTenMonHP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenMonHP.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenMonHP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenMonHP.Caption = "Tên Môn HP";
            this.colTenMonHP.FieldName = "TenMonHP";
            this.colTenMonHP.MinWidth = 30;
            this.colTenMonHP.Name = "colTenMonHP";
            this.colTenMonHP.OptionsColumn.AllowEdit = false;
            this.colTenMonHP.OptionsColumn.AllowFocus = false;
            this.colTenMonHP.OptionsColumn.AllowMove = false;
            this.colTenMonHP.OptionsColumn.AllowShowHide = false;
            this.colTenMonHP.OptionsColumn.AllowSize = false;
            this.colTenMonHP.Visible = true;
            this.colTenMonHP.VisibleIndex = 1;
            this.colTenMonHP.Width = 485;
            // 
            // colGiuaKy
            // 
            this.colGiuaKy.AppearanceCell.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colGiuaKy.AppearanceCell.Options.UseFont = true;
            this.colGiuaKy.AppearanceCell.Options.UseTextOptions = true;
            this.colGiuaKy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGiuaKy.AppearanceHeader.Options.UseTextOptions = true;
            this.colGiuaKy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGiuaKy.Caption = "Giữa Kỳ";
            this.colGiuaKy.FieldName = "GiuaKi";
            this.colGiuaKy.MinWidth = 30;
            this.colGiuaKy.Name = "colGiuaKy";
            this.colGiuaKy.OptionsColumn.AllowEdit = false;
            this.colGiuaKy.OptionsColumn.AllowFocus = false;
            this.colGiuaKy.OptionsColumn.AllowMove = false;
            this.colGiuaKy.OptionsColumn.AllowShowHide = false;
            this.colGiuaKy.OptionsColumn.AllowSize = false;
            this.colGiuaKy.Visible = true;
            this.colGiuaKy.VisibleIndex = 4;
            this.colGiuaKy.Width = 133;
            // 
            // colCuoiKy
            // 
            this.colCuoiKy.AppearanceCell.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCuoiKy.AppearanceCell.Options.UseFont = true;
            this.colCuoiKy.AppearanceCell.Options.UseTextOptions = true;
            this.colCuoiKy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCuoiKy.AppearanceHeader.Options.UseTextOptions = true;
            this.colCuoiKy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCuoiKy.Caption = "Cuối Kỳ";
            this.colCuoiKy.FieldName = "CuoiKy";
            this.colCuoiKy.MinWidth = 30;
            this.colCuoiKy.Name = "colCuoiKy";
            this.colCuoiKy.OptionsColumn.AllowEdit = false;
            this.colCuoiKy.OptionsColumn.AllowFocus = false;
            this.colCuoiKy.OptionsColumn.AllowMove = false;
            this.colCuoiKy.OptionsColumn.AllowShowHide = false;
            this.colCuoiKy.OptionsColumn.AllowSize = false;
            this.colCuoiKy.Visible = true;
            this.colCuoiKy.VisibleIndex = 5;
            this.colCuoiKy.Width = 133;
            // 
            // colDiemChu
            // 
            this.colDiemChu.AppearanceCell.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDiemChu.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.colDiemChu.AppearanceCell.Options.UseFont = true;
            this.colDiemChu.AppearanceCell.Options.UseForeColor = true;
            this.colDiemChu.AppearanceCell.Options.UseTextOptions = true;
            this.colDiemChu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiemChu.AppearanceHeader.Options.UseTextOptions = true;
            this.colDiemChu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiemChu.Caption = "Điểm chữ";
            this.colDiemChu.FieldName = "DiemChu";
            this.colDiemChu.MinWidth = 30;
            this.colDiemChu.Name = "colDiemChu";
            this.colDiemChu.OptionsColumn.AllowEdit = false;
            this.colDiemChu.OptionsColumn.AllowFocus = false;
            this.colDiemChu.OptionsColumn.AllowMove = false;
            this.colDiemChu.OptionsColumn.AllowShowHide = false;
            this.colDiemChu.OptionsColumn.AllowSize = false;
            this.colDiemChu.Visible = true;
            this.colDiemChu.VisibleIndex = 7;
            this.colDiemChu.Width = 133;
            // 
            // frmSV_XemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1796, 605);
            this.Controls.Add(this.gcXemDiem);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmSV_XemDiem";
            this.Text = "frmSV_XemDiem";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luHK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcXemDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lbTenSV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcXemDiem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaMonHP;
        private DevExpress.XtraGrid.Columns.GridColumn colTenMonHP;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTin;
        private DevExpress.XtraGrid.Columns.GridColumn colChuyenCan;
        private DevExpress.XtraGrid.Columns.GridColumn colGiuaKy;
        private DevExpress.XtraGrid.Columns.GridColumn colDiemHP;
        private DevExpress.XtraGrid.Columns.GridColumn colDiemChu;
        private DevExpress.XtraGrid.Columns.GridColumn colDiemHe4;
        private DevExpress.XtraGrid.Columns.GridColumn colKQ;
        private DevExpress.XtraGrid.Columns.GridColumn colCuoiKy;
        private DevExpress.XtraGrid.Columns.GridColumn colCheckKQ;
        private DevExpress.XtraEditors.LookUpEdit luHK;
    }
}