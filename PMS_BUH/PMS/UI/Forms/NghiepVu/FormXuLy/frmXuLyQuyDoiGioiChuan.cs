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
            QuyDoiBUH(index, NamHoc, HocKy);
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

        #region QuyDoiBUH
        void QuyDoiBUH(int index, string NamHoc, string HocKy)
        {
            try
            {
                TList<KhoiLuongGiangDayChiTiet> listKhoiLuong = new TList<KhoiLuongGiangDayChiTiet>();
                if (QuyDoiBoSung == false)
                {
                    TList<KhoiLuongGiangDayChiTiet> list = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKy((string)this._duLieuQuyDoi.Rows[0]["NamHoc"], (string)this._duLieuQuyDoi.Rows[0]["HocKy"]);
                    foreach (KhoiLuongGiangDayChiTiet khoiLuong in list)
                    {
                        foreach (DataRow row in this._duLieuQuyDoi.Rows)
                        {
                            if (khoiLuong.MaGiangVien.Equals((string)row["MaGiangVien"]) 
                                && khoiLuong.MaLopHocPhan.Equals((string)row["MaLopHocPhan"])
                                && khoiLuong.NamHoc.Equals((string)row["NamHoc"])
                                && khoiLuong.HocKy.Equals((string)row["HocKy"]))
                            {
                                listKhoiLuong.Add(khoiLuong);
                                break;
                            }
                        }
                    }
                }
                
                int process = listKhoiLuong.Count;

                string xmlData = "";

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

                        //double _heSoLuong = 0, _hesoChucDanhChuyenMon = 0, _heSoNgoaiGio = 0, _heSoMonGiangMoi = 0;

                        DataTable tbHeSoQuyDoiTietChuan = new DataTable();
                        IDataReader reader = DataServices.GiangVien.GetHeSoQuyDoiTietChuan (
                            klQuyDoi.MaGiangVien, NamHoc, HocKy, klQuyDoi.MaMonHoc, (int)klQuyDoi.SoLuong, 
                            (int)klQuyDoi.TietBatDau, (DateTime)klQuyDoi.NgayDay, klQuyDoi.MaPhongHoc, 
                            klQuyDoi.MaLopHocPhan, (int)klQuyDoi.SoTiet);
                        tbHeSoQuyDoiTietChuan.Load(reader);

                        DataRow rowHeSo = tbHeSoQuyDoiTietChuan.Rows[0];

                        klQuyDoi.HeSoLuong = decimal.Parse(rowHeSo["HeSoLuong"].ToString());

                        //double _heSoLopDongGDTC chính là HeSoCongViec
                        klQuyDoi.HeSoCongViec = decimal.Parse(rowHeSo["HeSoLopDongGdtc"].ToString());

                        klQuyDoi.HeSoLopDong = decimal.Parse(rowHeSo["HeSoLopDong"].ToString());

                        klQuyDoi.HeSoNgoaiGio = decimal.Parse(rowHeSo["HeSoNgoaiGio"].ToString());

                        klQuyDoi.HeSoChucDanhChuyenMon = decimal.Parse(rowHeSo["HeSoChucDanhChuyenMon"].ToString());

                        klQuyDoi.HeSoCoSo = decimal.Parse(rowHeSo["HeSoCoSo"].ToString());

                        klQuyDoi.HeSoMonMoi = decimal.Parse(rowHeSo["HeSoMonGiangMoi"].ToString());

                        klQuyDoi.NgonNguGiangDay = rowHeSo["NgonNguGiangDay"].ToString();

                        klQuyDoi.LoaiLop = rowHeSo["LoaiLop"].ToString();

                        if (klQuyDoi.LoaiLop == "CLC")  //Lop CLC
                        {
                            if (klQuyDoi.HeSoCongViec != -1)    //Lop GDTC
                                klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet
                                                    * ( 1
                                                        + klQuyDoi.HeSoLopDong
                                                        + klQuyDoi.HeSoLuong
                                                        + klQuyDoi.HeSoChucDanhChuyenMon
                                                        + klQuyDoi.HeSoNgoaiGio
                                                        + klQuyDoi.HeSoCoSo
                                                        + klQuyDoi.HeSoMonMoi );
                            else klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet;
                        }
                        else
                        {
                            if (klQuyDoi.HeSoCongViec != -1)    //Lop GDTC
                                klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet
                                                    * klQuyDoi.HeSoCongViec
                                                    * ( 1 
                                                        + klQuyDoi.HeSoLopDong
                                                        + klQuyDoi.HeSoLuong
                                                        + klQuyDoi.HeSoChucDanhChuyenMon
                                                        + klQuyDoi.HeSoNgoaiGio
                                                        + klQuyDoi.HeSoCoSo
                                                        + klQuyDoi.HeSoMonMoi );
                            else if (klQuyDoi.NgonNguGiangDay == "TIENGANH") //Mon chuyen nganh giang bang tieng anh.
                                klQuyDoi.TietQuyDoi = (klQuyDoi.SoTiet
                                                    * ( 1
                                                        + klQuyDoi.HeSoLopDong
                                                        + klQuyDoi.HeSoLuong
                                                        + klQuyDoi.HeSoChucDanhChuyenMon
                                                        + klQuyDoi.HeSoNgoaiGio
                                                        + klQuyDoi.HeSoCoSo
                                                        + klQuyDoi.HeSoMonMoi ))
                                                    + klQuyDoi.SoTiet;
                            else
                                klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet
                                                    * ( 1
                                                        + klQuyDoi.HeSoLopDong
                                                        + klQuyDoi.HeSoLuong
                                                        + klQuyDoi.HeSoChucDanhChuyenMon
                                                        + klQuyDoi.HeSoNgoaiGio
                                                        + klQuyDoi.HeSoCoSo
                                                        + klQuyDoi.HeSoMonMoi );
                        }

                        xmlData += "<Input _00MKL=\"" + klQuyDoi.MaKhoiLuongGiangDay
                                    + "\" _01MGV=\"" + klQuyDoi.MaGiangVien
                                    + "\" _02MLHP=\"" + klQuyDoi.MaLopHocPhan
                                    + "\" _03NH=\"" + klQuyDoi.NamHoc
                                    + "\" _04HK=\"" + klQuyDoi.HocKy
                                    + "\" _05MMH=\"" + klQuyDoi.MaMonHoc
                                    + "\" _06TMH=\"" + System.Security.SecurityElement.Escape(klQuyDoi.TenMonHoc)
                                    + "\" _07STC=\"" + Common.Globals.ReplaceDotEnviroment(klQuyDoi.SoTinChi, "decimal", true)
                                    + "\" _08SL=\"" + klQuyDoi.SoLuong
                                    + "\" _09MLOHP=\"" + klQuyDoi.MaLoaiHocPhan
                                    + "\" _10LOHP=\"" + klQuyDoi.LoaiHocPhan
                                    + "\" _11MBH=\"" + klQuyDoi.MaBuoiHoc
                                    + "\" _12ML=\"" + System.Security.SecurityElement.Escape(klQuyDoi.MaLop)
                                    + "\" _13TBD=\"" + klQuyDoi.TietBatDau
                                    + "\" _14ST=\"" + Common.Globals.ReplaceDotEnviroment(klQuyDoi.SoTiet, "decimal", true)
                                    + "\" _15TT=\"" + klQuyDoi.TinhTrang
                                    + "\" _16ND=\"" + ((DateTime)klQuyDoi.NgayDay).ToString("dd/MM/yyyy")
                                    + "\" _17MBDT=\"" + klQuyDoi.MaBacDaoTao
                                    + "\" _18MHK=\"" + klQuyDoi.MaKhoaHoc
                                    + "\" _19MK=\"" + klQuyDoi.MaKhoa
                                    + "\" _20MNMH=\"" + klQuyDoi.MaNhomMonHoc
                                    + "\" _21MPH=\"" + klQuyDoi.MaPhongHoc
                                    + "\" _22HSL=\"" + Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoLuong, "decimal", true)
                                    + "\" _23HSLD=\"" + Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoLopDong, "decimal", true)
                                    + "\" _24HSNG=\"" + Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoNgoaiGio, "decimal", true)
                                    + "\" _25HSCD=\"" + Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoChucDanhChuyenMon, "decimal", true)
                                    + "\" _26HSCS=\"" + Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoCoSo, "decimal", true)
                                    + "\" _27HSMM=\"" + Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoMonMoi, "decimal", true)
                                    + "\" _28NNGD=\"" + klQuyDoi.NgonNguGiangDay
                                    + "\" _29LL=\"" + klQuyDoi.LoaiLop
                                    + "\" _30TQD=\"" + Common.Globals.ReplaceDotEnviroment(klQuyDoi.TietQuyDoi, "decimal", true)
                                    + "\" />";
                    }
                }

                xmlData = "<Root>" + xmlData + "</Root>";

                int kq = 0;
                DataServices.KhoiLuongQuyDoi.LuuQuyDoi(xmlData, NamHoc, HocKy, ref kq);
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
