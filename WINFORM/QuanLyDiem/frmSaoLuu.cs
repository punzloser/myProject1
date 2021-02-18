using DevExpress.XtraEditors;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class frmSaoLuu : DevExpress.XtraEditors.XtraForm
    {
        public frmSaoLuu()
        {
            InitializeComponent();
        }
        QuanLiDiemEntities db = new QuanLiDiemEntities();


        private void btnBackup_Click(object sender, EventArgs e)
        {
            pgbarBackup.EditValue = 0;
            try
            {
                // if connect to SQL server authentication (Au) instead of Window Au
                // codeproject.com/Articles/26390/SQL-Server-2005-Database-Backup-and-Restore-using
                //ServerConnection connection = new ServerConnection(serverName, userName, password);

                SqlConnection sqlCon = new SqlConnection(@"Data Source= DESKTOP-DVL97US\SQLEXPRESS; Integrated Security=True;");

                ServerConnection connection = new ServerConnection(sqlCon);
                Server dbServer = new Server(connection);

                Backup dbBackup = new Backup(); /*{ Action = BackupActionType.Database, Database = txtDatabase.Text};   the same*/
                dbBackup.Action = BackupActionType.Database;
                dbBackup.BackupSetDescription = "Back up on " + DateTime.Now.ToShortDateString();
                dbBackup.BackupSetName = "FullBackUp";
                dbBackup.Database = txtDatabase.Text;

                //Declare a BackupDeviceItem
                if (txtDuongDan.Text == "")
                {
                    BackupDeviceItem deviceItem = new BackupDeviceItem(@"C:\Test\" + @"\QLD_" + DateTime.Today.Day + DateTime.Today.Month + DateTime.Today.Year + ".bak", DeviceType.File);
                    dbBackup.Devices.Add(deviceItem);
                }
                else
                {
                    BackupDeviceItem deviceItem = new BackupDeviceItem(txtDuongDan.Text, DeviceType.File);

                    dbBackup.Devices.Add(deviceItem);
                }
                dbBackup.Initialize = true;
                dbBackup.PercentComplete += DbBackup_PercentComplete;
                dbBackup.Complete += DbBackup_Complete;
                dbBackup.SqlBackup(dbServer);
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Có lỗi xảy ra ! vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lbStatus.Invoke((MethodInvoker)delegate
                {
                    lbStatus.Text = e.Error.Message;
                });
                lbStatus.ForeColor = Color.LightGreen;
            }
        }

        private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            pgbarBackup.Invoke((MethodInvoker)delegate
            {
                pgbarBackup.EditValue = e.Percent;
                pgbarBackup.Update();
            });
            lbPercent.Invoke((MethodInvoker)delegate
            {
                lbPercent.Text = $"{e.Percent}" + "%";
                lbPercent.ForeColor = Color.LightSkyBlue;
            });
        }

        private void btnChon_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folder_selected = new FolderBrowserDialog(); //dùng để duyệt chọn 1 folder
            if (folder_selected.ShowDialog() == DialogResult.OK)
            {
                txtDuongDan.Text = folder_selected.SelectedPath + @"\QLD_" + DateTime.Today.Day + DateTime.Today.Month + DateTime.Today.Year + ".bak";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}