using System;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using PMS.Entities;
using PMS.Services;
using System.Globalization;
using System.Threading;
using System.Data;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmXuLyImport : XtraForm
    {
        #region Variable
        private DataParameter _inputParameter;       
        NumberFormatInfo num = new NumberFormatInfo();
        
        /// <summary>
        /// Input param
        /// </summary>
        public struct DataParameter
        {
            public string NamHoc;
            public string HocKy;
            public DataTable _duLieuQuyDoi;
        }
       
        #endregion

        #region Event Form
        public frmXuLyImport(string _namHoc, string _hocKy,DataTable dbTable)
        {
            InitializeComponent();
            _inputParameter.NamHoc = _namHoc;
            _inputParameter.HocKy = _hocKy;
            _inputParameter._duLieuQuyDoi = dbTable;
        }

        //Bo sung quy doi tiet thuc day
        
      

        private void frmXuLyTinhThanhToanGioGiang_Load(object sender, EventArgs e)
        {
            progressBar.Properties.Minimum = 0;
            progressBar.Position = 0;
            //Do worker
            backgroundWorker.RunWorkerAsync(_inputParameter);
        }

        #endregion

        #region backgroundWorker
        /// <summary>
        /// DoWork
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int index = 1;
            string NamHoc = ((DataParameter)e.Argument).NamHoc;
            string HocKy = ((DataParameter)e.Argument).HocKy;
            DataTable dbTable = ((DataParameter)e.Argument)._duLieuQuyDoi;
            ImportDataBase(index, NamHoc, HocKy, dbTable);
        }

        private void backgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar.Position = e.ProgressPercentage;
            lblTenHoiDong.Text = e.UserState.ToString();
            progressBar.Update();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            XtraMessageBox.Show("Đã hoàn tất quy đổi khối lượng giảng dạy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        #endregion

        
              
        #region Import
        void ImportDataBase(int index, string NamHoc, string HocKy,DataTable tbl)
        {
            try
            {                            
                int process = tbl.Rows.Count;
                foreach (DataRow dritem in tbl.Rows)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        string strGiangVien = tbl.Columns[0].ColumnName;
                        string strMaLopHocPhan = tbl.Columns[1].ColumnName;
                        string strNamHoc = tbl.Columns[2].ColumnName;
                        backgroundWorker.ReportProgress(index++ * 100 / process, String.Format("GV: {0}.  LHP: {1}.  MH: {2}",dritem[strGiangVien].ToString()
                                                                                                                             , dritem[strMaLopHocPhan].ToString()
                                                                                                                             , dritem[strNamHoc].ToString()));

                        
                    }
                }
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
