using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
            txtUser.Properties.CharacterCasing = CharacterCasing.Upper;
            txtPass.Properties.CharacterCasing = CharacterCasing.Upper;
        }

        QuanLiDiemEntities db = new QuanLiDiemEntities();
        HashPass hc = new HashPass();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = db.TaiKhoan.Where(a => a.UserName == txtUser.Text).FirstOrDefault();

            if (user != null)
            {
                String value = hc.Hash(txtPass.Text);
                if (user.Pass == value && value.Length.CompareTo(30) > 0)
                {

                    ClassTaiKhoan.TaiKhoan = user.UserName;
                    frmMain frm = new frmMain();
                    frm.Show();
                    this.Hide();
                }
                else if (user.Pass == (txtPass.Text))
                {
                    ClassTaiKhoan.TaiKhoan = user.UserName;
                    frmMain frm = new frmMain();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    XtraMessageBox.Show("Sai mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                XtraMessageBox.Show("Tài khoản không tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}