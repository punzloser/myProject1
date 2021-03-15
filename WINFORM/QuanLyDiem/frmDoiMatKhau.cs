using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
            txtOld.Properties.CharacterCasing = CharacterCasing.Upper;
            txtNew.Properties.CharacterCasing = CharacterCasing.Upper;
            txtConfirm.Properties.CharacterCasing = CharacterCasing.Upper;
        }

        QuanLiDiemEntities db = new QuanLiDiemEntities();
        HashPass hc = new HashPass();

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtOld.Text) || String.IsNullOrWhiteSpace(txtNew.Text))
            {
                XtraMessageBox.Show("Vui lòng nhập thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                //var pass = db.TaiKhoan.Where(a => a.Pass == txtOld.Text && a.UserName == ClassTaiKhoan.TaiKhoan).SingleOrDefault();

                var pass = from a in db.TaiKhoan
                           where a.Pass == txtOld.Text
                           && ClassTaiKhoan.TaiKhoan == a.UserName
                           select a;

                var key = db.ChucNang.Where(a => a.App == txtKey.Text).FirstOrDefault();

                if (txtNew.Text == txtOld.Text)
                {
                        XtraMessageBox.Show("Mật khẩu mới không thể trùng mật khẩu cũ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (pass.SingleOrDefault() != null)
                {
                    if (key != null)
                    {
                        TaiKhoan change = pass.SingleOrDefault();
                        change.Pass = hc.Hash(txtNew.Text);
                        db.SaveChanges();
                        XtraMessageBox.Show("Đổi mật khẩu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("Key không chính xác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Mật khẩu cũ không chính xác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNew_Validating(object sender, CancelEventArgs e)
        {
            if(txtOld.Text == "")
            {
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txtNew.Text))
                {
                    e.Cancel = true;
                    XtraMessageBox.Show("Nhập vào mật khẩu mới !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNew.Focus();
                }
                else if (txtNew.Text.Length >= 100)
                {
                    e.Cancel = true;
                    XtraMessageBox.Show("Nhập khẩu tối đa 100 kí tự !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNew.Text = "";
                    txtNew.Focus();
                }
                else
                {
                    e.Cancel = false;
                }
            }
            
        }

        private void txtConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirm.Text.Trim().CompareTo(txtNew.Text.Trim()) == 0)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                XtraMessageBox.Show("Nhập lại mật khẩu không khớp !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirm.Focus();
            }
            
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtOld.Focus();
        }
    }
}