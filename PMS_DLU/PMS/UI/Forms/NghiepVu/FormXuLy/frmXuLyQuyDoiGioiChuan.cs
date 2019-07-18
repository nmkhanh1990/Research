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
            QuyDoiDLU(index, NamHoc, HocKy, bacDaoTao, loaiHinhDaoTao);
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

        #region QuyDoiDLU
        void QuyDoiDLU(int index, string NamHoc, string HocKy, string bac, string he)
        {
            try
            {
                string xmlData = "";

                TList<KhoiLuongGiangDayChiTiet> listKhoiLuong = new TList<KhoiLuongGiangDayChiTiet>();

                //listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKyCauHinhChotGio(NamHoc, HocKy, DotThanhToan);
                listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByBacLoaiHinhNamHocHocKyDot(bac, he, NamHoc, HocKy, DotThanhToan);
                //DataServices.KhoiLuongQuyDoi.DeleteByNamHocHocKyCauHinhChotGio(_namHoc, _hocKy, _dotThanhToan);

                int process = listKhoiLuong.Count;

                num = Thread.CurrentThread.CurrentUICulture.NumberFormat;

                DateTime time = DateTime.Now;
                //Common.XuLyTapTin.OpenTextFileForWrite("ThoiGianXuLy.txt"); 

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
                        klQuyDoi.SoLuong = klGiangDay.SoLuong; // == null ? 0 : klGiangDay.SoLuong;
                        klQuyDoi.MaLoaiHocPhan = klGiangDay.MaLoaiHocPhan;
                        klQuyDoi.LoaiHocPhan = klGiangDay.LoaiHocPhan;
                        klQuyDoi.MaBuoiHoc = klGiangDay.MaBuoiHoc == null ? 0 : klGiangDay.MaBuoiHoc;
                        klQuyDoi.MaLop = klGiangDay.MaLop;
                        klQuyDoi.TietBatDau = klGiangDay.TietBatDau == null ? 0 : klGiangDay.TietBatDau;
                        klQuyDoi.SoTiet = klGiangDay.SoTiet; // == null ? 0 : klGiangDay.SoTiet;
                        klQuyDoi.TinhTrang = klGiangDay.TinhTrang;
                        klQuyDoi.NgayDay = klGiangDay.NgayDay == null ? DateTime.Now : klGiangDay.NgayDay;
                        klQuyDoi.MaBacDaoTao = klGiangDay.MaBacDaoTao;
                        klQuyDoi.MaKhoaHoc = klGiangDay.MaKhoaHoc;
                        klQuyDoi.MaKhoa = klGiangDay.MaKhoa;
                        klQuyDoi.MaNhomMonHoc = klGiangDay.MaNhomMonHoc;
                        klQuyDoi.MaPhongHoc = klGiangDay.MaPhongHoc;

                        if (klGiangDay.SoLuong == null || klGiangDay.LoaiHocPhan == null || klGiangDay.MaBacDaoTao == null  //|| klGiangDay.MaNhomMonHoc == null
                            || klGiangDay.MaHocHam == null || klGiangDay.MaHocVi == null || klGiangDay.SoTiet == null)      //|| klGiangDay.MaLoaiGiangVien == null
                        {
                            klQuyDoi.GhiChu = "Thiếu dữ liệu cần quy đổi!";
                        }
                        else
                        {
                            string Thu;
                            try
                            {
                                Thu = klGiangDay.NgayDay.Value.DayOfWeek.ToString("d");
                            }
                            catch
                            { Thu = "1"; }  //Nếu không có ngày dạy (dữ liệu import) thì coi như là ngày thường

                            DataTable _heSoQuyDoi = new DataTable();
                            IDataReader reader = DataServices.GiangVien.GetHeSoQuyDoiTietChuanChung(NamHoc, HocKy, klQuyDoi.MaBacDaoTao, klQuyDoi.MaLopHocPhan
                                , klQuyDoi.MaMonHoc, (int)klQuyDoi.SoLuong, klQuyDoi.MaLop, klQuyDoi.MaLoaiHocPhan.ToString(), (DateTime)klQuyDoi.NgayDay.GetValueOrDefault()
                                , (int)klQuyDoi.TietBatDau.GetValueOrDefault()
                                , Thu
                                , (int)klGiangDay.MaHocHam   // == null ? 0 : klGiangDay.MaHocHam)
                                , (int)klGiangDay.MaHocVi    // == null ? 0 : klGiangDay.MaHocVi)
                                , klQuyDoi.MaPhongHoc
                                , klQuyDoi.MaKhoa
                                , (bool)(klGiangDay.DaoTaoTinChi == null ? false : klGiangDay.DaoTaoTinChi)
                                , (int)(klGiangDay.MaLoaiGiangVien == null ? 0 : klGiangDay.MaLoaiGiangVien)
                                );
                            _heSoQuyDoi.Load(reader);

                            DataRow _rowHeSo = _heSoQuyDoi.Rows[0];

                            klQuyDoi.HeSoLopDong = decimal.Parse(_rowHeSo["HeSoLopDong"].ToString());
                            klQuyDoi.HeSoBacDaoTao = decimal.Parse(_rowHeSo["HeSoBacDaoTao"].ToString());
                            //klQuyDoi.NgonNguGiangDay = _rowHeSo["NgonNguGiangDay"].ToString();
                            //klQuyDoi.HeSoNgonNgu = decimal.Parse(_rowHeSo["HeSoNgonNgu"].ToString());
                            klQuyDoi.MaKhoaCuaMonHoc = _rowHeSo["MaKhoaLopHocPhan"].ToString();
                            klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = decimal.Parse(_rowHeSo["HeSoQuyDoiThucHanhSangLyThuyet"].ToString());
                            //klQuyDoi.HeSoNgoaiGio = decimal.Parse(_rowHeSo["HeSoNgoaiGio"].ToString());
                            //klQuyDoi.HeSoCoSo = decimal.Parse(_rowHeSo["HeSoCoSo"].ToString());
                            klQuyDoi.HeSoChucDanhChuyenMon = decimal.Parse(_rowHeSo["HeSoChucDanhChuyenMon"].ToString());

                            //if (klQuyDoi.MaGiangVien.Equals("011.210.00003") && klQuyDoi.MaLopHocPhan.Equals("162NH111301")) //<< test 
                            //{
                            //    string str = "debug";
                            //}

                            if (klQuyDoi.LoaiHocPhan.Equals("LT") || "TD".Contains(klQuyDoi.MaKhoaCuaMonHoc)) //Lý thuyết hoặc GDTC
                            {
                                klQuyDoi.TietQuyDoi = (klQuyDoi.HeSoLopDong + klQuyDoi.HeSoBacDaoTao
                                         + klQuyDoi.HeSoChucDanhChuyenMon) * klQuyDoi.SoTiet;
                                //klQuyDoi.TietQuyDoi = (1 + (klQuyDoi.HeSoBacDaoTao - 1) + (klQuyDoi.HeSoLopDong - 1)); //QNU
                            }
                            else //Thực hành
                            {
                                int _siSoNhomThucHanh = (int)_rowHeSo["SiSoNhomThucHanh"];
                                klQuyDoi.HeSoChucDanhChuyenMon = (decimal)_rowHeSo["HeSoChucDanhThucHanh"];
                                klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = (decimal)_rowHeSo["HeSoQuyDoiThucHanhSangLyThuyet"];
                                klQuyDoi.HeSoLopDong = (decimal)_rowHeSo["HeSoLopDong"];

                                if (_siSoNhomThucHanh == 0 && klQuyDoi.NamHoc.Equals("2015-2016"))
                                {
                                    _siSoNhomThucHanh = (int)klQuyDoi.SoLuong;
                                }

                                decimal _soNhomThucHanh;
                                _soNhomThucHanh = (int)klQuyDoi.SoLuong / (decimal)_siSoNhomThucHanh; //Common.XuLySo.LamTronLen((int)klQuyDoi.SoLuong * 1.0 / _siSoNhomThucHanh);
                                if (0 < _soNhomThucHanh && _soNhomThucHanh < 1) _soNhomThucHanh = 1; //Nếu số sinh viên trong lớp nhỏ hơn _siSoNhomThucHanh thì coi như là 1 nhóm

                                if (!"CH;NC".Contains(klQuyDoi.MaBacDaoTao) && "CQ".Contains(klGiangDay.MaLoaiHinhDaoTao)) //Chính quy
                                {
                                    //Các môn giáo dục thể chất: Số tiết thực dạy * (HSLĐ + HSHH)
                                    //Các môn thực hành đại cương: số SV / 25 * ST thực dạy * hs thực hành * (HSHH)
                                    //Các môn thực hành chuyên nghiệp xã hội: ST thực dạy * HS thực hành * (HSLĐ + HSHH)
                                    //Các môn thực hành chuyên nghiệp tự nhiên: Số SV / 15 * ST thực dạy * HS thực hành * (HSHH)
                                    klQuyDoi.TietQuyDoi =
                                        //(_soNhomThucHanh * klQuyDoi.SoTiet * klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet)
                                        //* (klQuyDoi.HeSoLopDong + klQuyDoi.HeSoChucDanhChuyenMon); //Quy chế cũ
                                        (klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet + klQuyDoi.HeSoChucDanhChuyenMon)
                                        * klQuyDoi.SoTiet * _soNhomThucHanh;
                                }
                                else if ("CH;NC".Contains(klQuyDoi.MaBacDaoTao)) //Sau đại học
                                {
                                    klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet * (klQuyDoi.HeSoChucDanhChuyenMon + klQuyDoi.HeSoBacDaoTao);
                                }
                                else if ("TC;B2".Contains(klGiangDay.MaLoaiHinhDaoTao)) //Không chính quy
                                {
                                    klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet * (klQuyDoi.HeSoChucDanhChuyenMon + klQuyDoi.HeSoBacDaoTao);
                                }
                            }
                            klQuyDoi.GhiChu = "Đã quy đổi";
                        }
                        //now = DateTime.Now;
                        //Common.XuLyTapTin.WriteTextFile("Xử lý:\t" + Common.XuLyThoiGian.SoMillisecond(time, now) + Environment.NewLine);
                        //time = now;
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
                                //+ "\" _23HSCV=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoCongViec, "decimal")
                                + "\" _24HSBDT=\"" + Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoBacDaoTao, "decimal", true)
                                //+ "\" _25HSNN=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoNgonNgu, "decimal")
                                + "\" _26HSCDCM=\"" + Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoChucDanhChuyenMon, "decimal", true)
                                + "\" _27HSLD=\"" + Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoLopDong, "decimal", true)
                                //+ "\" _28HSCS=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoCoSo, "decimal")
                                //+ "\" _29STTTQD=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.SoTietThucTeQuyDoi, "decimal")
                                + "\" _30TQD=\"" + Common.Globals.ReplaceDotEnviroment(klQuyDoi.TietQuyDoi, "decimal", true)
                                + "\" _31HSQDTHSLT=\"" + Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet, "decimal", true)//klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet
                                //+ "\" _32HSNG=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoNgoaiGio, "decimal")//klQuyDoi.HeSoNgoaiGio
                                //+ "\" _33LL=\"" + ""//klQuyDoi.LoaiLop
                                //+ "\" _34HSCLCCNTN=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoClcCntn, "decimal")//klQuyDoi.HeSoClcCntn
                                + "\" _35HSTGMCN=\"" + 0 //klQuyDoi.HeSoThinhGiangMonChuyenNganh
                                //+ "\" _36NNGD=\"" + ""//klQuyDoi.NgonNguGiangDay
                                //+ "\" _37HSTCGD=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoTroCapGiangDay
                                //+ "\" _38HSTC=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoTroCap, "decimal")//klQuyDoi.HeSoTroCap
                                //+ "\" _39HSL=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoLuong
                                //+ "\" _40HSMM=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoMonMoi
                                //+ "\" _41HSNCTC=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoNienCheTinChi, "decimal")
                                //+ "\" _42HSKN=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoKhoiNganh, "decimal")
                                + "\" _43GC=\"" + klQuyDoi.GhiChu
                                + "\" _44MTT=\"" + 0  //PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.MucThanhToan, "decimal")
                                + "\" _45MKMH=\"" + klQuyDoi.MaKhoaCuaMonHoc
                                + "\" />";
                    }
                }

                xmlData = "<Root>" + xmlData + "</Root>";
                int kq = 0;
                DataServices.KhoiLuongQuyDoi.LuuQuyDoiTheoDotAll(xmlData, NamHoc, HocKy, DotThanhToan, ref kq);
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

    }
}
