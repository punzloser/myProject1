using DevExpress.Skins;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class frmQuyen : DevExpress.XtraEditors.XtraForm
    {
        public frmQuyen()
        {
            InitializeComponent();

            var skin = GridSkins.GetSkin(treeList1.LookAndFeel);
            skin.Properties[GridSkins.OptShowTreeLine] = true;

            treeList1.CustomDrawNodeCell += treeList1_CustomDrawNodeCell;
            treeList1.CellValueChanging += treeList1_CellValueChanging;
        }

        QuanLiDiemEntities db = new QuanLiDiemEntities();
        private void frmQuyen_Load(object sender, EventArgs e)
        {
            var user = from a in db.TaiKhoan
                       select new
                       {
                          a.UserName,
                          a.FullName
                       };
            gridControl1.DataSource = user.ToList();
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var user = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["UserName"]);
            var result = from a in db.ChucNang
                         join b in db.ChucNang_TaiKhoan.Where(a => a.UserName == user.ToString())
                         on a.Menu equals b.Menu into c
                         from d in c.DefaultIfEmpty()
                         select new Quyen
                         {
                             Menu = a.Menu,
                             Detail = a.Detail,
                             QuyenThem = d.QuyenThem == null ? false : d.QuyenThem,
                             QuyenSua = d.QuyenSua == null ? false : d.QuyenSua,
                             QuyenXoa = d.QuyenXoa == null ? false : d.QuyenXoa,
                             Cam = d.Cam == null ? false : d.Cam,
                             ParentMenu = a.ParentMenu
                         };
            treeList1.DataSource = result.ToList();
            treeList1.ForceInitialize();
            treeList1.ExpandAll();
            treeList1.BestFitColumns();
        }

        #region TREELIST
        private void treeList1_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e)
        {
            if (e.Node.HasChildren)
            {
                e.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
                e.Appearance.Options.UseTextOptions = true;
            }
        }

        private void treeList1_CellValueChanging(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            e.Node.SetValue(e.Column, e.Value);
            SetCheckedChildNodes(e.Node, e.Column, (bool)e.Value);
            SetCheckedParentNodes(e.Node, e.Column, (bool)e.Value);
        }
        #endregion

        #region SET CHECK CHILD AND PARENT
        private void SetCheckedParentNodes(TreeListNode node, TreeListColumn col, bool check)
        {
            if (node.ParentNode != null)
            {
                bool b = false;
                for (int i = 0; i < node.ParentNode.Nodes.Count; i++)
                {
                    var state = (bool)node.ParentNode.Nodes[i][col];
                    if (!check.Equals(state))
                    {
                        b = true;
                        break;
                    }
                }
                bool bb = !b && check;
                node.ParentNode[col] = bb;
                SetCheckedParentNodes(node.ParentNode, col, check);
            }
        }

        private void SetCheckedChildNodes(TreeListNode node, TreeListColumn col, bool check)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                node.Nodes[i][col] = check;
                SetCheckedChildNodes(node.Nodes[i], col, check);
            }
        }
        #endregion

        private void btnRef_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQuyen_Load(sender, e);
        }

        private void btnUpdate_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var user = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["UserName"]);
            var node = treeList1.GetNodeList();

            for (int i = 0; i < node.Count; i++)
            {
                ChucNang_TaiKhoan cn = new ChucNang_TaiKhoan()
                {
                    UserName = user.ToString(),
                    Menu = node[i].GetDisplayText(colMenu),
                    SetTime = DateTime.Now,
                    QuyenThem = (bool)node[i].GetValue(colQThem),
                    QuyenSua = (bool)node[i].GetValue(colQSua),
                    QuyenXoa = (bool)node[i].GetValue(colQXoa),
                    Cam = (bool)node[i].GetValue(colCam)
                };
                db.ChucNang_TaiKhoan.AddOrUpdate(cn);
                
            }
            db.SaveChanges();
            XtraMessageBox.Show("Cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    public class Quyen
    {
        public String Menu { get; set; }
        public String Detail { get; set; }
        public bool? QuyenThem { get; set; }
        public bool? QuyenSua { get; set; }
        public bool? QuyenXoa { get; set; }
        public bool? Cam { get; set; }
        public String ParentMenu { get; set; }
    }
}