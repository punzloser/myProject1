
namespace QuanLyDiem
{
    partial class frmXemPhanCong
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
            this.gVPhanCongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbTenGV = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcXemPC = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaMonHP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayKT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gVPhanCongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcXemPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gVPhanCongBindingSource
            // 
            this.gVPhanCongBindingSource.DataSource = typeof(QuanLyDiem.GV_PhanCong);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lbTenGV);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1248, 63);
            this.panelControl1.TabIndex = 1;
            // 
            // lbTenGV
            // 
            this.lbTenGV.Appearance.Font = new System.Drawing.Font("Verdana", 15F);
            this.lbTenGV.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbTenGV.Appearance.Options.UseFont = true;
            this.lbTenGV.Appearance.Options.UseForeColor = true;
            this.lbTenGV.Location = new System.Drawing.Point(674, 12);
            this.lbTenGV.Name = "lbTenGV";
            this.lbTenGV.Size = new System.Drawing.Size(77, 36);
            this.lbTenGV.TabIndex = 1;
            this.lbTenGV.Text = "None";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 13F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(56, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(571, 32);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "++ XEM THÔNG TIN PHÂN CÔNG  ++  GV :";
            // 
            // gcXemPC
            // 
            this.gcXemPC.DataSource = this.gVPhanCongBindingSource;
            this.gcXemPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcXemPC.Location = new System.Drawing.Point(0, 63);
            this.gcXemPC.MainView = this.gridView1;
            this.gcXemPC.Name = "gcXemPC";
            this.gcXemPC.Size = new System.Drawing.Size(1248, 440);
            this.gcXemPC.TabIndex = 3;
            this.gcXemPC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaGV,
            this.colMaMonHP,
            this.colMaLop,
            this.colNgayBD,
            this.colNgayKT});
            this.gridView1.GridControl = this.gcXemPC;
            this.gridView1.Name = "gridView1";
            // 
            // colMaGV
            // 
            this.colMaGV.Caption = "Tên GV";
            this.colMaGV.FieldName = "GiaoVien.TenGV";
            this.colMaGV.MinWidth = 30;
            this.colMaGV.Name = "colMaGV";
            this.colMaGV.Visible = true;
            this.colMaGV.VisibleIndex = 0;
            this.colMaGV.Width = 112;
            // 
            // colMaMonHP
            // 
            this.colMaMonHP.Caption = "Tên MH";
            this.colMaMonHP.FieldName = "MonHP.TenMonHP";
            this.colMaMonHP.MinWidth = 30;
            this.colMaMonHP.Name = "colMaMonHP";
            this.colMaMonHP.Visible = true;
            this.colMaMonHP.VisibleIndex = 1;
            this.colMaMonHP.Width = 112;
            // 
            // colMaLop
            // 
            this.colMaLop.Caption = "Tên Lớp";
            this.colMaLop.FieldName = "Lop.TenLop";
            this.colMaLop.MinWidth = 30;
            this.colMaLop.Name = "colMaLop";
            this.colMaLop.Visible = true;
            this.colMaLop.VisibleIndex = 2;
            this.colMaLop.Width = 112;
            // 
            // colNgayBD
            // 
            this.colNgayBD.Caption = "Ngày BD";
            this.colNgayBD.FieldName = "NgayBD";
            this.colNgayBD.MinWidth = 30;
            this.colNgayBD.Name = "colNgayBD";
            this.colNgayBD.Visible = true;
            this.colNgayBD.VisibleIndex = 3;
            this.colNgayBD.Width = 112;
            // 
            // colNgayKT
            // 
            this.colNgayKT.Caption = "Ngày KT";
            this.colNgayKT.FieldName = "NgayKT";
            this.colNgayKT.MinWidth = 30;
            this.colNgayKT.Name = "colNgayKT";
            this.colNgayKT.Visible = true;
            this.colNgayKT.VisibleIndex = 4;
            this.colNgayKT.Width = 112;
            // 
            // frmXemPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 503);
            this.Controls.Add(this.gcXemPC);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmXemPhanCong";
            this.Text = "frmXemPhanCong";
            this.Load += new System.EventHandler(this.frmXemPhanCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gVPhanCongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcXemPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource gVPhanCongBindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcXemPC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMaMonHP;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLop;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayBD;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKT;
        private DevExpress.XtraEditors.LabelControl lbTenGV;
    }
}