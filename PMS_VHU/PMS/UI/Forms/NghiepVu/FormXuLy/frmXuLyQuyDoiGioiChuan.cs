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
            QuyDoiVHU (index, NamHoc, HocKy);
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
        #endregion

        #region QuyDoiVHU
        void QuyDoiVHU(int index, string NamHoc, string HocKy)
        {
            try
            {
                strTenTruong = Common.Globals.GetMaTruong(_listCauHinhChung, "Tên trường");
                int iichekc = Common.XuLyGiaoDien.CheckMaTruong(_maTruong, strTenTruong);
                string xmlData = "";
                TList<KhoiLuongGiangDayChiTiet> listKhoiLuong = new TList<KhoiLuongGiangDayChiTiet>();
                if (QuyDoiBoSung == false)
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKy(NamHoc, HocKy);
                    DataServices.KhoiLuongQuyDoi.DeleteByNamHocHocKy(NamHoc, HocKy);
                }
                else
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKyBoSung(NamHoc, HocKy);
                    DataServices.KhoiLuongQuyDoi.DeleteKhoiLuongBoSungByNamHocHocKy(NamHoc, HocKy);
                }
                int process = listKhoiLuong.Count;

                num = Thread.CurrentThread.CurrentUICulture.NumberFormat;

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
                        klQuyDoi.TinhTrang = klGiangDay.TinhTrang;
                        klQuyDoi.NgayDay = klGiangDay.NgayDay;
                        klQuyDoi.MaBacDaoTao = klGiangDay.MaBacDaoTao;
                        klQuyDoi.MaKhoaHoc = klGiangDay.MaKhoaHoc;
                        klQuyDoi.MaKhoa = klGiangDay.MaKhoa;
                        klQuyDoi.MaNhomMonHoc = klGiangDay.MaNhomMonHoc;
                        klQuyDoi.MaPhongHoc = klGiangDay.MaPhongHoc;
                       
                        string Thu;
                        try
                        {
                            Thu = klGiangDay.NgayDay.Value.DayOfWeek.ToString("d");
                        }
                        catch
                        { Thu = "1"; } //Nếu không có ngày dạy (dữ liệu import) thì coi như là ngày thường

                        if (Thu == "0") Thu = "7"; //Chủ nhật trên form = 0, dưới sql = 7

                        if (klGiangDay.MaHocHam == null)
                        {
                            XtraMessageBox.Show("Học hàm bị rỗng!");
                        }
                        if (klGiangDay.MaHocVi == null)
                        {
                            XtraMessageBox.Show("Học vị bị rỗng!");
                        }
                        if (klGiangDay.MaLoaiGiangVien == null)
                        {
                            XtraMessageBox.Show("Loại giảng viên bị rỗng!");
                        }

                        DataTable _heSoQuyDoi = new DataTable();
                        IDataReader reader = DataServices.GiangVien.GetHeSoQuyDoiTietChuanChung(NamHoc, HocKy, klQuyDoi.MaBacDaoTao
                            , klQuyDoi.MaLopHocPhan, klQuyDoi.MaMonHoc, (int)klQuyDoi.SoLuong, klQuyDoi.MaLop
                            , klQuyDoi.MaLoaiHocPhan.ToString(), (DateTime)klQuyDoi.NgayDay
                            , (int)klQuyDoi.TietBatDau, Thu
                            , (int)klGiangDay.MaHocHam
                            , (int)klGiangDay.MaHocVi
                            , klQuyDoi.MaPhongHoc, klQuyDoi.MaKhoa
                            , (bool)klGiangDay.DaoTaoTinChi
                            , (int)klGiangDay.MaLoaiGiangVien);
                        _heSoQuyDoi.Load(reader);

                        DataRow _rowHeSo = _heSoQuyDoi.Rows[0];

                        klQuyDoi.HeSoLopDong = decimal.Parse(_rowHeSo["HeSoLopDong"].ToString());
                        klQuyDoi.HeSoBacDaoTao = decimal.Parse(_rowHeSo["HeSoBacDaoTao"].ToString());
                        klQuyDoi.NgonNguGiangDay = _rowHeSo["NgonNguGiangDay"].ToString();
                        klQuyDoi.HeSoNgonNgu = decimal.Parse(_rowHeSo["HeSoNgonNgu"].ToString());
                        klQuyDoi.HeSoClcCntn = decimal.Parse(_rowHeSo["HeSoClcCntn"].ToString());
                        klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = decimal.Parse(_rowHeSo["HeSoQuyDoiThucHanhSangLyThuyet"].ToString());
                        klQuyDoi.HeSoNgoaiGio = decimal.Parse(_rowHeSo["HeSoNgoaiGio"].ToString());
                        klQuyDoi.HeSoChucDanhChuyenMon = decimal.Parse(_rowHeSo["HeSoChucDanhChuyenMon"].ToString());
                        klQuyDoi.HeSoCoSo = decimal.Parse(_rowHeSo["HeSoCoSo"].ToString());

                        if (!String.IsNullOrEmpty(klGiangDay.MaKhoaCuaMonHoc) && "26".Contains(klGiangDay.MaKhoaCuaMonHoc)) //Khoa nghê thuật
                        {
                            //Số tiết quy đổi = số tiết thực tế * hệ số LT (1) hoặc TH (0.8) * hệ số lớp đông
                            klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet * klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet * klQuyDoi.HeSoLopDong;
                        }
                        else if (klQuyDoi.MaLopHocPhan.Contains("HQ"))
                        {
                            klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet * klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet
                                * (1 + klQuyDoi.HeSoNgoaiGio + klQuyDoi.HeSoLopDong) * (decimal)1.5;
                        }
                        else
                        {
                            klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet * klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet 
                                * (1 + klQuyDoi.HeSoNgoaiGio + klQuyDoi.HeSoLopDong);
                        }

                        xmlData += "<Input _01MKL=\"" + klQuyDoi.MaKhoiLuongGiangDay
                                + "\" _02MGV=\"" + klQuyDoi.MaGiangVien
                                + "\" _03MLHP=\"" + klQuyDoi.MaLopHocPhan
                                + "\" _04NH=\"" + klQuyDoi.NamHoc
                                + "\" _05HK=\"" + klQuyDoi.HocKy
                                + "\" _06MMH=\"" + klQuyDoi.MaMonHoc
                                + "\" _07TMH=\"" + System.Security.SecurityElement.Escape(klQuyDoi.TenMonHoc)
                                + "\" _08STC=\"" + Common.Globals.ReplaceDotEnviroment(klQuyDoi.SoTinChi, "decimal", true)
                                + "\" _09SL=\"" + klQuyDoi.SoLuong
                                + "\" _10MLHP=\"" + klQuyDoi.MaLoaiHocPhan
                                + "\" _11LHP=\"" + klQuyDoi.LoaiHocPhan
                                + "\" _12MBH=\"" + klQuyDoi.MaBuoiHoc
                                + "\" _13ML=\"" + System.Security.SecurityElement.Escape(klQuyDoi.MaLop)
                                + "\" _14TBD=\"" + klQuyDoi.TietBatDau
                                + "\" _15ST=\"" + Common.Globals.ReplaceDotEnviroment(klQuyDoi.SoTiet, "decimal", true)
                                + "\" _16TT=\"" + klQuyDoi.TinhTrang
                                + "\" _17ND=\"" + ((DateTime)klQuyDoi.NgayDay).ToString("yyyy/MM/dd")
                                + "\" _18MBDT=\"" + klQuyDoi.MaBacDaoTao
                                + "\" _19MKH=\"" + klQuyDoi.MaKhoaHoc
                                + "\" _20MK=\"" + klQuyDoi.MaKhoa
                                + "\" _21MNMH=\"" + klQuyDoi.MaNhomMonHoc
                                + "\" _22MPH=\"" + klQuyDoi.MaPhongHoc
                                + "\" _23HSCV=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoCongViec, "decimal")
                                + "\" _24HSBDT=\"" + Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoBacDaoTao, "decimal", true)
                                + "\" _25HSNN=\"" + Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoNgonNgu, "decimal", true)
                                + "\" _26HSCDCM=\"" + Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoChucDanhChuyenMon, "decimal", true)
                                + "\" _27HSLD=\"" + Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoLopDong, "decimal", true)
                                + "\" _28HSCS=\"" + Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoCoSo, "decimal", true)
                                + "\" _29STTTQD=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.SoTietThucTeQuyDoi, "decimal")
                                + "\" _30TQD=\"" + Common.Globals.ReplaceDotEnviroment(klQuyDoi.TietQuyDoi, "decimal", true)
                                + "\" _31HSQDTHSLT=\"" + Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet, "decimal", true)//klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet
                                + "\" _32HSNG=\"" + Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoNgoaiGio, "decimal", true)//klQuyDoi.HeSoNgoaiGio
                                + "\" _33LL=\"" + ""//klQuyDoi.LoaiLop
                                + "\" _34HSCLCCNTN=\"" + Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoClcCntn, "decimal", true)//klQuyDoi.HeSoClcCntn
                                + "\" _35HSTGMCN=\"" + 0 //Common.Globals.ReplaceDotEnviroment(0, "decimal")
                                + "\" _36NNGD=\"" + klQuyDoi.NgonNguGiangDay
                                + "\" _37HSTCGD=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")
                                + "\" _38HSTC=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoTroCap, "decimal")
                                + "\" _39HSL=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")
                                + "\" _40HSMM=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")
                                + "\" _41HSNCTC=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoNienCheTinChi, "decimal")
                                + "\" _42GC=\"" + string.Empty //klQuyDoi.GhiChu
                                + "\" _43MTT=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.MucThanhToan, "decimal")
                                + "\" />";
                    }
                }

                xmlData = "<Root>" + xmlData + "</Root>";
                int kq = 0;
                DataServices.KhoiLuongQuyDoi.LuuQuyDoiAll(xmlData, NamHoc, HocKy, ref kq);
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
