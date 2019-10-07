using DevExpress.Common.Grid;
using DevExpress.XtraEditors;
using PMS.Common;
using System;
using System.Data;
using System.Windows.Forms;

namespace PMS.UI.Forms.NghiepVu.ChucNangCon
{
    public partial class frmImportFileExcel : XtraForm
    {
        SpreadsheetGear.IWorkbookSet _workbookSet = SpreadsheetGear.Factory.GetWorkbookSet();
        string _direct = string.Empty;

        public DataTable ImportData
        {
            get
            {
                return bindingSourceCauTrucImport.DataSource as DataTable;
            }
        }

        public frmImportFileExcel()
        {
            InitializeComponent();
        }

        //private void btnChonFile_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        using (OpenFileDialog ofdFiles = new OpenFileDialog { Filter = "(*.xls)|*.xls|(*.xlsx)|*.xlsx" })
        //        {
        //            if (ofdFiles.ShowDialog() == DialogResult.OK)
        //            {
        //                btnChonFile.Text = ofdFiles.FileName;
        //                if (btnChonFile.Text == string.Empty)
        //                    return;
        //                else
        //                {
        //                    _workbookSet = SpreadsheetGear.Factory.GetWorkbookSet();
        //                    _direct = btnChonFile.Text.ToString().Trim();
        //                    _workbookSet.Workbooks.Open(_direct);
        //                    DataTable dt = new DataTable();
        //                    dt.Columns.Add("ID", typeof(int));
        //                    dt.Columns.Add("Name");
        //                    for (int i = 0; i < _workbookSet.Workbooks[0].Sheets.Count; i++)
        //                        dt.Rows.Add(i, _workbookSet.Workbooks[0].Sheets[i].Name);
        //                    bindingSourceSheet.DataSource = dt;
        //                }
        //            }
        //        }
        //    }
        //    catch { }
        //}

        private void frmImportFileExcel_Load(object sender, EventArgs e)
        {
            #region Init Sheet
            AppGridLookupEdit.InitGridLookUp(cboSheet, false, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboSheet, new string[] { "Name" }, new string[] { "Tên sheet" });
            cboSheet.Properties.DisplayMember = "Name";
            cboSheet.Properties.ValueMember = "ID";
            cboSheet.Properties.NullText = string.Empty;
            #endregion

            #region Init Filename
            AppGridLookupEdit.InitGridLookUp(cboLoaiDuLieu, new string[] { "FileName" }
                , new string[] { "Loại dữ liệu" }, new int[] { 290 }, "Id", "FileName", 300, 300);
            AppGridLookupEdit.InitPopupFormSize(cboLoaiDuLieu, 300, 300);
            cboLoaiDuLieu.Properties.DisplayMember = "FileName";
            cboLoaiDuLieu.Properties.ValueMember = "Id";
            cboLoaiDuLieu.Properties.NullText = string.Empty;
            #endregion

            InitData();
        }

        #region InitData
        void InitData()
        {
            DataTable tblFileName = new DataTable();
            tblFileName.Columns.Add(new DataColumn("Id", typeof(LoaiDuLieuImport)));
            tblFileName.Columns.Add(new DataColumn("FileName", typeof(string)));

            tblFileName.Rows.Add(LoaiDuLieuImport.TienTruTamUng, "Tiền trừ tạm ứng");
            
            bindingSourceFileName.DataSource = tblFileName;
            bindingSourceFileName.Sort = "FileName";
        }
        #endregion

        private void btnXemFile_Click(object sender, EventArgs e)
        {
            try
            {
                _workbookSet = SpreadsheetGear.Factory.GetWorkbookSet();
                _direct = btnChonFile.Text.ToString().Trim();
                _workbookSet.Workbooks.Open(_direct);
                SpreadsheetGear.Windows.Forms.WorkbookDesigner v3 = new SpreadsheetGear.Windows.Forms.WorkbookDesigner(_workbookSet);
                v3.Show();
            }
            catch
            {
                MessageBox.Show("Đường dẫn file không đúng.", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboLoaiDuLieu.EditValue != null)
                {
                    string xmlData = "";
                    DataTable dt = bindingSourceCauTrucImport.DataSource as DataTable;
                    foreach(DataRow row in dt.Rows)
                    {
                        xmlData += "<Object ";
                        foreach(DataColumn column in dt.Columns)
                        {
                            xmlData += column.ColumnName + "=\"" + row[column] + "\" ";
                        }
                        xmlData += "/>";
                    }
                    XuLyGiaoDien.ThongBao("Import thành công!\n", MessageBoxIcon.Information, true);
                    this.Hide();
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng chọn loại dữ liệu muốn import.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboLoaiDuLieu.Focus();
                }
            }
            catch (Exception ex)
            {
                XuLyGiaoDien.ThongBaoLoi(ex, true);
            }
        }

        private void btnXuatFileCauTruc_Click(object sender, EventArgs e)
        {
            if (cboLoaiDuLieu.EditValue != null)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.FileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\CauTrucImportGiangVien.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlCauTruc.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn loại dữ liệu muốn xuất cấu trúc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLoaiDuLieu.Focus();
            }
        }

        private void cboCauTrucImport_EditValueChanged(object sender, EventArgs e)
        {
            #region Init Grid cấu trúc
            switch((LoaiDuLieuImport)cboLoaiDuLieu.EditValue)
            {
                case LoaiDuLieuImport.TienTruTamUng:
                    AppGridView.InitGridView(gridViewCauTruc, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, false, ""
                        , new string[] { "MaGiangVien", "TienTruTamUng" }, new string[] { "MaGiangVien", "TienTruTamUng" }, new int[] { 100, 100 });
                    break;
                default:
                    break;
            }
            #endregion
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            bindingSourceCauTrucImport.DataSource = XuLyTapTin.LoadExcelFile();
            gridViewCauTruc.OptionsView.RowAutoHeight = true;
        }

        private void btnChonFile_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}