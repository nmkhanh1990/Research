﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Common
{
    public class ThongBao   //Tên biến thông báo nên sắp xếp theo A->Z cho dễ tìm.
    {
        public const string DU_LIEU_HOP_LE = "Dữ liệu hợp lệ";

        #region Giảng viên
        public const string BAC_LUONG_TRONG = "Bậc lương bỏ trống.";
        public const string CMND_KHONG_HOP_LE = "Số chứng minh nhân dân không hợp lệ.";
        public const string CMND_TRONG = "Số chứng minh nhân dân bỏ trống.";
        public const string CMND_TRUNG_LAP = "Số chứng minh nhân dân bị trùng.";
        public const string DON_VI_TRUC_THUOC_TRONG = "Đơn vị trực thuộc bỏ trống.";
        public const string DON_VI_GIANG_DAY_TRONG = "Đơn vị giảng dạy bỏ trống.";
        public const string HE_SO_LUONG_TRONG = "Hệ số lương bỏ trống.";
        public const string HO_TEN_TRONG = "Họ tên bỏ trống.";
        public const string HO_TEN_TRUNG_LAP = "Họ tên trùng.";
        public const string HOC_HAM_TRONG = "Học hàm bỏ trống.";
        public const string HOC_VI_TRONG = "Học vị bỏ trống.";
        public const string LOAI_GIANG_VIEN_TRONG = "Loại giảng viên bỏ trống.";
        public const string MA_QUAN_LY_TRONG = "Mã giảng viên không được bỏ trống.";
        public const string MA_QUAN_LY_TRUNG_LAP = "Mã giảng viên trùng.";
        public const string NGAY_HOP_DONG_KHONG_HOP_LE = "Ngày hợp đồng không hợp lệ.";
        public const string NGAY_HOP_DONG_TRONG = "Ngày hợp đồng bỏ trống";
        public const string TINH_TRANG_TRONG = "Tình trạng công việc bỏ trống.";
        #endregion
        #region Thông báo
        public const string LST_TrangThaiGiangVien = "Đã khóa bên bảng kê";
        public const string Str_ChonIn = "Vui lòng chọn những giảng viên muốn in";
        public const string Str_XuatFile = "Xuất file thành công.";
        public const string Str_LoiXuatFile = "Lỗi trong khi xuất file.";
        public const string Str_LuuChiTraGIANGVIEN = "Bạn muốn lưu chi trả cho những giảng viên đã chọn?";
        public const string Str_LuuThayDoiThanhCong = "Lưu thay đổi thành công.";
        public const string Str_LuuLoiXayRa = "Đã xảy ra lỗi trong quá trình lưu thay đổi.";
        public const string Str_GomNhom = "Gom nhóm bằng cách kéo tên cột thả vào đây";
        public const string Str_DongBo = "Đồng bộ thành công.";
        public const string Str_LoiDongBo = "Đã xảy ra lỗi trong quá trình đồng bộ.";
        public const string Str_VuiLongChonNamHoc = "Vui lòng chọn năm học - học kỳ - đợt chi trả.";
        public const string Str_ChotThanhCong = "Chốt thành công.";
        public const string Str_ThongBao = "Thông báo";
        public const string Str_CanhBao = "Cảnh báo";
        public const string Str_Loi = "Lỗi";
        public const string Str_ThongBaoDuLieu = "Dữ liệu chưa có";
        public const string Str_ChuaNhapFile = "Bạn chưa nhập tên file.";
        public const string Str_SoTietQuaGioHan = "Số tiết nhập quá giới hạn.";
        public const string Str_NgoaiThoiGianChamGiang = "Ngoài thời gian chấm giảng. Vui lòng liên hệ với quản trị viên để biết thêm chi tiết.";
        public const string Str_NgoaiThoiGiangChamGiangTrongKhoang = "Ngoài thời gian chấm giảng. Thời gian chấm giảng từ 06h00 đến 18h00 cùng ngày.";
        public const string Str_GioVao = "Vui lòng nhập giờ vào phải đúng định dạng hh:mm";
        public const string Str_GioRa = "Vui lòng nhập giờ ra phải đúng định dạng hh:mm";
        public const string Str_GhiChuNhapGio = "Vui lòng xem ghi chú trước khi nhập giờ.";
        public const string Str_KetQuaGio = "Vui lòng xem lại giờ vào phải nhỏ hơn giờ ra.";
        public const string Str_ChonLoaiBaoCao = "Vui lòng chọn báo cáo trước khi in.";
        public const string Str_KiemTraChot = "Dữ liệu hiện tại chưa chốt trong năm.";
        public const string Str_ChekNamHocHocKy = "Bạn chưa chọn nằm học, học kỳ.";
        public const string Str_ChonGiangVien = "Bạn chưa chọn Giảng viên.";
        public const string Str_ChonKhoa = "Bạn chưa chọn Khoa đơn vị.";
        public const string Str_VuiLong = "Vui lòng nhập vào.";
        public const string Str_InLoiXayRa = "Đã xảy ra lỗi trong quá trình in.";
        public const string Str_LocDuLieu = "Vui lòng lọc dữ liệu trước khi in.";
        public const string Str_ChonLanChot = "Vui lòng kiểm tra chốt trước theo học kỳ.";
        #endregion


        #region Khối lương đồ án và tiểu luận UTE
        public const string CHUA_CAU_HINH_HE_SO_NGOAI_NGU_title = "Thiếu hệ số môn giảng bằng tiếng nước ngoài.";
        public const string CHUA_CAU_HINH_HE_SO_message = "Vào 'Danh mục' -> 'Cấu hình hệ thống' -> 'Cấu hình chung (toàn bộ)' để thêm cấu hình cho hệ số này.";
        #endregion

    }
}
