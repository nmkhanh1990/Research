﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'Ute_ThanhToanThuLao' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IUteThanhToanThuLao 
	{
		/// <summary>			
		/// IdKhoiLuongQuyDoi : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "Ute_ThanhToanThuLao"</remarks>
		System.Int32 IdKhoiLuongQuyDoi { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalIdKhoiLuongQuyDoi { get; set; }
			
		
		
		/// <summary>
		/// MaMonHoc : 
		/// </summary>
		System.String  MaMonHoc  { get; set; }
		
		/// <summary>
		/// TenMonHoc : 
		/// </summary>
		System.String  TenMonHoc  { get; set; }
		
		/// <summary>
		/// NhomMonHoc : 
		/// </summary>
		System.String  NhomMonHoc  { get; set; }
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		System.String  NamHoc  { get; set; }
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		System.String  HocKy  { get; set; }
		
		/// <summary>
		/// MaLopHocPhan : 
		/// </summary>
		System.String  MaLopHocPhan  { get; set; }
		
		/// <summary>
		/// Nhom : 
		/// </summary>
		System.String  Nhom  { get; set; }
		
		/// <summary>
		/// MaLop : 
		/// </summary>
		System.String  MaLop  { get; set; }
		
		/// <summary>
		/// SoTinChi : 
		/// </summary>
		System.Int32?  SoTinChi  { get; set; }
		
		/// <summary>
		/// SoTiet : 
		/// </summary>
		System.Int32?  SoTiet  { get; set; }
		
		/// <summary>
		/// SiSo : 
		/// </summary>
		System.Int32?  SiSo  { get; set; }
		
		/// <summary>
		/// LopClc : 
		/// </summary>
		System.Boolean?  LopClc  { get; set; }
		
		/// <summary>
		/// SoTietDayChuNhat : 
		/// </summary>
		System.Int32?  SoTietDayChuNhat  { get; set; }
		
		/// <summary>
		/// MaLoaiHocPhan : 
		/// </summary>
		System.Int32?  MaLoaiHocPhan  { get; set; }
		
		/// <summary>
		/// HeSoLopDongLyThuyet : 
		/// </summary>
		System.Decimal?  HeSoLopDongLyThuyet  { get; set; }
		
		/// <summary>
		/// HeSoLopDongThTnTt : 
		/// </summary>
		System.Decimal?  HeSoLopDongThTnTt  { get; set; }
		
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		System.String  MaQuanLy  { get; set; }
		
		/// <summary>
		/// Ho : 
		/// </summary>
		System.String  Ho  { get; set; }
		
		/// <summary>
		/// Ten : 
		/// </summary>
		System.String  Ten  { get; set; }
		
		/// <summary>
		/// HoTen : 
		/// </summary>
		System.String  HoTen  { get; set; }
		
		/// <summary>
		/// MaHocHam : 
		/// </summary>
		System.Int32?  MaHocHam  { get; set; }
		
		/// <summary>
		/// MaHocVi : 
		/// </summary>
		System.Int32?  MaHocVi  { get; set; }
		
		/// <summary>
		/// MaLoaiGiangVien : 
		/// </summary>
		System.Int32?  MaLoaiGiangVien  { get; set; }
		
		/// <summary>
		/// MaDonVi : 
		/// </summary>
		System.String  MaDonVi  { get; set; }
		
		/// <summary>
		/// DonGia : 
		/// </summary>
		System.Decimal?  DonGia  { get; set; }
		
		/// <summary>
		/// TietQuyDoi : 
		/// </summary>
		System.Decimal?  TietQuyDoi  { get; set; }
		
		/// <summary>
		/// ThanhTienDayChuNhat : 
		/// </summary>
		System.Decimal?  ThanhTienDayChuNhat  { get; set; }
		
		/// <summary>
		/// ThanhTien : 
		/// </summary>
		System.Decimal?  ThanhTien  { get; set; }
		
		/// <summary>
		/// TongThanhTien : 
		/// </summary>
		System.Decimal?  TongThanhTien  { get; set; }
		
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		System.DateTime?  NgayCapNhat  { get; set; }
		
		/// <summary>
		/// DaChot : 
		/// </summary>
		System.Boolean?  DaChot  { get; set; }
		
		/// <summary>
		/// HeSoHocKy : 
		/// </summary>
		System.Decimal?  HeSoHocKy  { get; set; }
		
		/// <summary>
		/// SoGioThucGiangTrenLop : 
		/// </summary>
		System.Decimal?  SoGioThucGiangTrenLop  { get; set; }
		
		/// <summary>
		/// SoGioChuanTinhThem : 
		/// </summary>
		System.Decimal?  SoGioChuanTinhThem  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


