using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmXuLyDongBoDuLieu : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        private const int CP_NOCLOSE_BUTTON = 0x200;
        private string namhoc;
        private string hocky;
        private string maTruong;
        private string maDonVi;
        DateTime TuNgay, DenNgay;
        int q; string message;
        bool TamUng = false;
        int DotThanhToan;
        private DataTable duLieuDuocChon;
        #endregion

        #region Event Form
        public frmXuLyDongBoDuLieu()
        {
            InitializeComponent();
        }

        public frmXuLyDongBoDuLieu(DataTable dt)
        {
            InitializeComponent();
            this.duLieuDuocChon = dt;
        }

        public frmXuLyDongBoDuLieu(string namhoc,string hocky)
        {
            InitializeComponent();
            this.namhoc = namhoc;
            this.hocky = hocky;
            
        }

        public frmXuLyDongBoDuLieu(string namhoc, string hocky, string _maTruong)
        {
            InitializeComponent();
            this.namhoc = namhoc;
            this.hocky = hocky;
            this.maTruong = _maTruong;
        }

        public frmXuLyDongBoDuLieu(string namhoc, string hocky, int _dotThanhToan, string _maTruong)
        {
            InitializeComponent();
            this.namhoc = namhoc;
            this.hocky = hocky;
            DotThanhToan = _dotThanhToan;
            this.maTruong = _maTruong;
        }

        public frmXuLyDongBoDuLieu(string namhoc, string hocky, string _maTruong, string _maDonVi)
        {
            InitializeComponent();
            this.namhoc = namhoc;
            this.hocky = hocky;
            this.maTruong = _maTruong;
            this.maDonVi = _maDonVi;
        }

        public frmXuLyDongBoDuLieu(DateTime _tuNgay, DateTime _denNgay, string _maTruong)
        {
            InitializeComponent();
            TuNgay = _tuNgay;
            DenNgay = _denNgay;
            maTruong = _maTruong;
        }

        public frmXuLyDongBoDuLieu(string namhoc, string hocky, string _maTruong, bool _tamUng)
        {
            InitializeComponent();
            this.namhoc = namhoc;
            this.hocky = hocky;
            this.maTruong = _maTruong;
            TamUng = _tamUng;
        }

        private void frmXuLyDongBoDuLieu_Load(object sender, EventArgs e)
        {

            progressBar.Properties.Minimum = 0;
            progressBar.Position = 0;
            marqueeProgressBarControl1.Text = "Đang đồng bộ, xin vui lòng chờ trong ít phút...";
            
            //Do worker
            backgroundWorker.RunWorkerAsync();

           // button1_Click(sender, e); 
           
        }
        #endregion

        #region Event BackgroundWorker
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (maTruong)
            {
                default:
                    DongBoCacTruongConLai();
                    break;
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
            if (q == 1)
            {
                XtraMessageBox.Show("Đã hoàn tất việc đồng bộ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Quá trình đồng bộ dữ liệu thất bại.\n" + message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        #endregion

        #region Ham xu ly dong bo cac truong

        void DongBoCacTruongConLai()
        {
            try
            {
                if (maDonVi != "" && maDonVi != null)
                {
                    DataServices.ViewKhoiLuongGiangDay.DongBoTheoDonVi(namhoc, hocky, maDonVi);                   
                }                
                else
                {
                    DataServices.ViewKhoiLuongGiangDay.DongBo(namhoc, hocky);                   
                }
                q = 1;
            }
            catch (Exception ex)
            {
               q = 0;
               message = ex.Message;
               throw;
            }
        }

        void DongBoTamUng()
        {
            try
            {
                DataServices.KhoiLuongTamUng.DongBo(namhoc, hocky);
                q = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                q = 0;
            }
            
        }

        #endregion
    }
}