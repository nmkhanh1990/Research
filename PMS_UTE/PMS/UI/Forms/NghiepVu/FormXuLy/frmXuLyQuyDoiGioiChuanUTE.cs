using System;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using PMS.Services;
using PMS.Entities;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmXuLyQuyDoiGioiChuanUTE : XtraForm
    {
        private DataParameter _inputParameter;

        /// <summary>
        /// Input param
        /// </summary>
        public struct DataParameter
        {
            public string NamHoc;
            public string HocKy;
            public int MaGiangVien;
            public bool QuyCheMoi;
        }

        public frmXuLyQuyDoiGioiChuanUTE(string _namHoc, string _hocKy, int _maGiangVien)
        {
            InitializeComponent();
            _inputParameter.NamHoc = _namHoc;
            _inputParameter.HocKy = _hocKy;
            _inputParameter.MaGiangVien = _maGiangVien;
        }

        public frmXuLyQuyDoiGioiChuanUTE(string _namHoc, string _hocKy)
        {
            InitializeComponent();
            _inputParameter.NamHoc = _namHoc;
            _inputParameter.HocKy = _hocKy;
        }
        public frmXuLyQuyDoiGioiChuanUTE(string _namHoc, string _hocKy, bool _quyCheMoi)
        {
            InitializeComponent();
            _inputParameter.NamHoc = _namHoc;
            _inputParameter.HocKy = _hocKy;
            _inputParameter.QuyCheMoi = _quyCheMoi;
        }
        /// <summary>
        /// DoWork
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                if (((DataParameter)e.Argument).QuyCheMoi == true)
                {
                    DataServices.UteKhoiLuongQuyDoi.QuyDoiTheoNamHocHocKyQuyCheMoi(((DataParameter)e.Argument).NamHoc, ((DataParameter)e.Argument).HocKy);
                    DataServices.UteKhoiLuongQuyDoi.QuyDoiTheoNamHocHocKy(((DataParameter)e.Argument).NamHoc, ((DataParameter)e.Argument).HocKy);
                    DataServices.UteThanhToanThuLao.ThanhToan(((DataParameter)e.Argument).NamHoc, ((DataParameter)e.Argument).HocKy);
                }
                else
                {
                    DataServices.UteKhoiLuongQuyDoi.QuyDoiTheoNamHocHocKy(((DataParameter)e.Argument).NamHoc, ((DataParameter)e.Argument).HocKy);
                    DataServices.UteThanhToanThuLao.ThanhToan(((DataParameter)e.Argument).NamHoc, ((DataParameter)e.Argument).HocKy);
                }
            }
            catch (Exception ex)
            {
                //Xem đơn giá có bị trùng hay ko (học vị null)
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static decimal? TinhHeSo(TList<QuyDoiGioChuan> listQuyDoiGioChuan, VList<ViewKhoiLuongGiangDay> vListChiTiet)
        {
            //Tinh he so quy doi
            QuyDoiGioChuan objQuyDoi = listQuyDoiGioChuan.Find(p => p.MaQuanLy == vListChiTiet[0].LoaiHocPhan);
            if (objQuyDoi != null)
            {
                foreach (KhoanQuyDoi k in DataServices.KhoanQuyDoi.GetByMaQuyDoi(objQuyDoi.MaQuyDoi))
                {
                    if (k.DenKhoan != null)
                    {
                        if (vListChiTiet[0].SoLuong > k.TuKhoan && vListChiTiet[0].SoLuong < k.DenKhoan)
                            return k.HeSo;
                    }
                    else
                    {
                        if (vListChiTiet[0].SoLuong > k.TuKhoan)
                            return k.HeSo;
                    }
                }
            }
            return 1;
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

        private void frmXuLyTinhThanhToanGioGiang_Load(object sender, EventArgs e)
        {
            progressBar.Properties.Minimum = 0;
            progressBar.Position = 0;
            //Do worker
            backgroundWorker.RunWorkerAsync(_inputParameter);
        }
    }
}