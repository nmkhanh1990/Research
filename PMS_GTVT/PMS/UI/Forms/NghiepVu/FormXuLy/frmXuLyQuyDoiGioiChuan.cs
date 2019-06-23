using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmXuLyQuyDoiGioiChuan : XtraForm
    {
        #region Variable
        private DataParameter _inputParameter;
        bool QuyDoiBoSung = false;
        string _maTruong, MaDonVi, XmlData;
        string strTenTruong = string.Empty;
        int QuyDoiTheoGiangVienLopHocPhan;
        DateTime TuNgay, DenNgay;
        TList<GiangVien> _listGiangVien = DataServices.GiangVien.GetAll();
        TList<CauHinhChung> _listCauHinhChung = DataServices.CauHinhChung.GetAll();
        NumberFormatInfo num = new NumberFormatInfo();
        DataTable _duLieuQuyDoi;
        TList<HeSoGiangDayNhieuLopCungHocPhan> _listHeSoNhieuLop;
        /// <summary>
        /// Input param
        /// </summary>
        public struct DataParameter
        {
            public string NamHoc;
            public string HocKy;
        }
        int DotThanhToan;
        public string bacDaoTao;
        public string loaiHinhDaoTao;
        bool QuyDoiTamUng = false;
        #endregion

        #region Event Form
        public frmXuLyQuyDoiGioiChuan(string _namHoc, string _hocKy)
        {
            InitializeComponent();
            _inputParameter.NamHoc = _namHoc;
            _inputParameter.HocKy = _hocKy;
        }

        //Bo sung quy doi tiet thuc day
        public frmXuLyQuyDoiGioiChuan(string _namHoc, string _hocKy, bool _boSung)
        {
            InitializeComponent();
            _inputParameter.NamHoc = _namHoc;
            _inputParameter.HocKy = _hocKy;
            QuyDoiBoSung = _boSung;
        }

        public frmXuLyQuyDoiGioiChuan(string _namHoc, string _hocKy, string ma_truong)
        {
            InitializeComponent();
            _inputParameter.NamHoc = _namHoc;
            _inputParameter.HocKy = _hocKy;
            this._maTruong = ma_truong;
        }


        public frmXuLyQuyDoiGioiChuan(string _namHoc, string _hocKy, int _dotThanhToan, string bac, string he, string ma_truong)
        {
            InitializeComponent();
            _inputParameter.NamHoc = _namHoc;
            _inputParameter.HocKy = _hocKy;
            this._maTruong = ma_truong;
            DotThanhToan = _dotThanhToan;
            bacDaoTao = bac;
            loaiHinhDaoTao = he;
        }


        public frmXuLyQuyDoiGioiChuan(string _namHoc, string _hocKy, string ma_truong, string _maDonVi)
        {
            InitializeComponent();
            _inputParameter.NamHoc = _namHoc;
            _inputParameter.HocKy = _hocKy;
            this._maTruong = ma_truong;
            MaDonVi = _maDonVi;
        }

        public frmXuLyQuyDoiGioiChuan(string _namHoc, string _hocKy, string ma_truong, string _xmlData, int _quyDoiTheoGVLHP)
        {
            InitializeComponent();
            _inputParameter.NamHoc = _namHoc;
            _inputParameter.HocKy = _hocKy;
            this._maTruong = ma_truong;
            XmlData = _xmlData;
            QuyDoiTheoGiangVienLopHocPhan = _quyDoiTheoGVLHP;
        }

        public frmXuLyQuyDoiGioiChuan(DateTime _tuNgay, DateTime _denNgay, string ma_truong)
        {
            InitializeComponent();
            TuNgay = _tuNgay;
            DenNgay = _denNgay;
            this._maTruong = ma_truong;
        }

        public frmXuLyQuyDoiGioiChuan(string _namHoc, string _hocKy, string ma_truong, bool _tamUng)
        {
            InitializeComponent();
            _inputParameter.NamHoc = _namHoc;
            _inputParameter.HocKy = _hocKy;
            QuyDoiTamUng = _tamUng;
            this._maTruong = ma_truong;
        }

        public frmXuLyQuyDoiGioiChuan(DataTable dt, string _namHoc, string _hocKy, string ma_truong)
        {
            InitializeComponent();
            this._maTruong = ma_truong;
            this._duLieuQuyDoi = dt;
            _inputParameter.NamHoc = _namHoc;
            _inputParameter.HocKy = _hocKy;
        }

        private void frmXuLyTinhThanhToanGioGiang_Load(object sender, EventArgs e)
        {
            progressBar.Properties.Minimum = 0;
            progressBar.Position = 0;
            _listHeSoNhieuLop = DataServices.HeSoGiangDayNhieuLopCungHocPhan.GetByNamHocHocKy(_inputParameter.NamHoc,_inputParameter.HocKy);
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
            QuyDoiCDGTVT(index, NamHoc, HocKy);
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

        #region Cac ham bo tro

        #region IsNull
        object IsNull(object O)
        {
            if (O == null)
                O = 0;
            return O;
        }
        #endregion

        decimal ConvertDecimal(string s)
        {
            decimal result = 0;
            try
            {
                if (s.Contains("/"))
                    result = decimal.Parse(s.Split('/')[0].ToString()) / decimal.Parse(s.Split('/')[1].ToString());
                else
                    result = decimal.Parse(s);
            }
            catch
            {
                result = 0;
            }

            return result;
        }

        decimal HeSoNhieuLopCungHocPhan (TList<KhoiLuongGiangDayChiTiet> list, string ma_giang_vien, string ma_mon_hoc)
        {
            //list.Sort("Order By MaMonHoc");
            int dem = 0;
            foreach (KhoiLuongGiangDayChiTiet kl in list)
            {
                if(kl.MaGiangVien == ma_giang_vien && kl.MaMonHoc == ma_mon_hoc)
                {
                    ++dem;
                }
            }
            foreach (HeSoGiangDayNhieuLopCungHocPhan hs in _listHeSoNhieuLop)
            {
                if (hs.TuKhoan <= dem && dem <= (hs.DenKhoan == null ? 999 : hs.DenKhoan)) return decimal.Parse(hs.HeSo.ToString());
            }
            return 1;
        }
        #endregion

        #region QuyDoiCDGTVT
        void QuyDoiCDGTVT(int index, string NamHoc, string HocKy)
        {
            DevExpress.Common.Culture.AppCulture.InitCulture("en-US");
            try
            {
                TList<KhoiLuongGiangDayChiTiet> listKhoiLuong = new TList<KhoiLuongGiangDayChiTiet>();
                if (QuyDoiBoSung)
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKyBoSung(NamHoc, HocKy);
                    DataServices.KhoiLuongQuyDoi.DeleteKhoiLuongBoSungByNamHocHocKy(NamHoc, HocKy);
                }
                else
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKy(NamHoc, HocKy);
                    DataServices.KhoiLuongQuyDoi.DeleteByNamHocHocKy(NamHoc, HocKy);
                }
                int process = listKhoiLuong.Count;

                foreach (KhoiLuongGiangDayChiTiet klGiangDay in listKhoiLuong)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process, String.Format("GV: {0}.  LHP: {1}.  MH: {2}", klGiangDay.MaGiangVien, klGiangDay.MaLopHocPhan, klGiangDay.TenMonHoc));

                        KhoiLuongQuyDoi klQuyDoi = new KhoiLuongQuyDoi();
                        klQuyDoi.MaKhoiLuongGiangDay = klGiangDay.MaKhoiLuong;
                        klQuyDoi.MaGiangVien = klGiangDay.MaGiangVien;
                        klQuyDoi.MaLopHocPhan = klGiangDay.MaLopHocPhan;
                        klQuyDoi.NamHoc = klGiangDay.NamHoc;
                        klQuyDoi.HocKy = klGiangDay.HocKy;
                        klQuyDoi.MaMonHoc = klGiangDay.MaMonHoc;
                        klQuyDoi.TenMonHoc = klGiangDay.TenMonHoc;
                        klQuyDoi.SoTinChi = klGiangDay.SoTinChi;
                        klQuyDoi.SoLuong = klGiangDay.SoLuong;
                        klQuyDoi.MaLoaiHocPhan = klGiangDay.MaLoaiHocPhan;
                        klQuyDoi.LoaiHocPhan = klGiangDay.LoaiHocPhan;
                        klQuyDoi.MaBuoiHoc = klGiangDay.MaBuoiHoc;
                        klQuyDoi.MaLop = klGiangDay.MaLop;
                        klQuyDoi.TietBatDau = klGiangDay.TietBatDau;
                        klQuyDoi.SoTiet = klGiangDay.SoTiet;
                        klQuyDoi.SoTietDayNhieuLopHocPhan = klGiangDay.SoTietDayNhieuLopHocPhan;
                        klQuyDoi.TinhTrang = klGiangDay.TinhTrang;
                        klQuyDoi.NgayDay = klGiangDay.NgayDay;
                        klQuyDoi.MaBacDaoTao = klGiangDay.MaBacDaoTao;
                        klQuyDoi.MaKhoaHoc = klGiangDay.MaKhoaHoc;
                        klQuyDoi.MaKhoa = klGiangDay.MaKhoa;
                        klQuyDoi.MaNhomMonHoc = klGiangDay.MaNhomMonHoc;
                        klQuyDoi.MaPhongHoc = klGiangDay.MaPhongHoc;

                        double _heSoBacDaoTao = 0, _heSoLopDong = 0, _heSoMonThucTap = 0, _heSoCVHT = 0;
                        DataServices.HeSoBacDaoTao.GetByMaBacNamHocHocKy(klGiangDay.MaBacDaoTao, klGiangDay.NamHoc, klGiangDay.HocKy, ref _heSoBacDaoTao);
                        klQuyDoi.HeSoBacDaoTao = (decimal)_heSoBacDaoTao;

                        int _maNhomMonHoc = 0;
                        TList<PhanNhomMonHoc> _listNhomMonHoc = DataServices.PhanNhomMonHoc.GetByNamHocHocKyMaMonHoc(klQuyDoi.NamHoc, klQuyDoi.HocKy, klGiangDay.MaMonHoc);
                        if (_listNhomMonHoc.Count > 0)
                            _maNhomMonHoc = _listNhomMonHoc[0].MaNhomMonHoc;
                        else
                            _maNhomMonHoc = 9; //Nhóm môn học bình thường
                        klQuyDoi.MaNhomMonHoc = _maNhomMonHoc.ToString();

                        DataServices.HeSoLopDong.GetByNamHocHocKyBacDaoTaoNhomMonHocSiSo(klGiangDay.NamHoc, klGiangDay.HocKy, klGiangDay.MaBacDaoTao, klQuyDoi.MaNhomMonHoc, (int)klGiangDay.SoLuong, ref _heSoLopDong);
                        klQuyDoi.HeSoLopDong = (decimal)_heSoLopDong;

                        if (_maNhomMonHoc == 12) //Nhóm môn thực tập
                        {
                            if (num.NumberDecimalSeparator == ".")
                            {
                                _heSoMonThucTap = double.Parse(_listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số quy đổi thực hành sang lý thuyết").GiaTri);
                            }
                            if (num.NumberDecimalSeparator == ",")
                            {
                                string s = _listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số quy đổi thực hành sang lý thuyết").GiaTri.Replace(".", ",");
                                _heSoMonThucTap = double.Parse(s);
                            }
                        }
                        else
                            _heSoMonThucTap = 1;

                        klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = (decimal)_heSoMonThucTap;

                        //Hệ số này áp dụng theo số buổi học của 1 giảng viên dạy 1 môn học trong 1 tuần,
                        //nếu buổi này là buổi thứ 3 trở lên trong cùng 1 tuần thì hệ số là 0.75
                        double _heSoLopCungHocPhan = "LT".Contains(klGiangDay.LoaiHocPhan)
                            && klGiangDay.SoTietDayNhieuLopHocPhan > 0 ? 0.75 : 1;
                        //DataServices.HeSoGiangDayNhieuLopCungHocPhan.GetHeSo(klQuyDoi.NamHoc, klQuyDoi.HocKy, klQuyDoi.MaGiangVien, klQuyDoi.MaMonHoc, klQuyDoi.MaLopHocPhan, ref _heSoLopCungHocPhan);
                        klQuyDoi.HeSoNhieuLopHocPhan = (decimal)_heSoLopCungHocPhan;

                        if (klGiangDay.MaLichHoc == -2) //Những dòng CVHT
                        {
                            DataServices.HeSoCoVanHocTap.GetByNamHocHocKySiSo(klQuyDoi.NamHoc, klQuyDoi.HocKy, (int)klQuyDoi.SoLuong, ref _heSoCVHT);
                            if (klGiangDay.MaChucVu == 76) //Nếu là GVCN thì ko tính hệ số CVHT
                                _heSoCVHT = 1;
                            klQuyDoi.TietQuyDoi = klGiangDay.SoTiet * (decimal)_heSoCVHT;
                        }
                        else if (klGiangDay.MaLichHoc == -3) //Những dòng NCKH
                        {
                            klQuyDoi.TietQuyDoi = klGiangDay.SoTiet;
                        }
                        else
                        {
                            klQuyDoi.TietQuyDoi = //(klGiangDay.SoTietDayNhieuLopHocPhan > 0 ? klGiangDay.SoTietDayNhieuLopHocPhan : klGiangDay.SoTiet)
                                klGiangDay.SoTiet * (decimal)_heSoLopCungHocPhan * (decimal)_heSoBacDaoTao * (decimal)_heSoLopDong * (decimal)_heSoMonThucTap;
                            _heSoCVHT = 1;
                        }

                        klQuyDoi.HeSoTroCap = (decimal)_heSoCVHT;
                        DataServices.KhoiLuongQuyDoi.Insert(klQuyDoi);
                    }
                }
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

    }
}
