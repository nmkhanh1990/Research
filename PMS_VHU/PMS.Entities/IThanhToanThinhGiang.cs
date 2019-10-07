﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'ThanhToanThinhGiang' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IThanhToanThinhGiang 
	{
		/// <summary>			
		/// Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ThanhToanThinhGiang"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		System.String  NamHoc  { get; set; }
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		System.String  HocKy  { get; set; }
		
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		System.Int32?  MaGiangVien  { get; set; }
		
		/// <summary>
		/// MaLopHocPhan : 
		/// </summary>
		System.String  MaLopHocPhan  { get; set; }
		
		/// <summary>
		/// ChucDanh : 
		/// </summary>
		System.String  ChucDanh  { get; set; }
		
		/// <summary>
		/// MaLop : 
		/// </summary>
		System.String  MaLop  { get; set; }
		
		/// <summary>
		/// SiSo : 
		/// </summary>
		System.Int32?  SiSo  { get; set; }
		
		/// <summary>
		/// Stt : 
		/// </summary>
		System.Int32?  Stt  { get; set; }
		
		/// <summary>
		/// NoiDung : 
		/// </summary>
		System.String  NoiDung  { get; set; }
		
		/// <summary>
		/// SoTiet : 
		/// </summary>
		System.Decimal?  SoTiet  { get; set; }
		
		/// <summary>
		/// HeSo : 
		/// </summary>
		System.Decimal?  HeSo  { get; set; }
		
		/// <summary>
		/// HeSoChucDanh : 
		/// </summary>
		System.Decimal?  HeSoChucDanh  { get; set; }
		
		/// <summary>
		/// CongHeSo : 
		/// </summary>
		System.Decimal?  CongHeSo  { get; set; }
		
		/// <summary>
		/// DonGia : 
		/// </summary>
		System.Decimal?  DonGia  { get; set; }
		
		/// <summary>
		/// ThanhTien : 
		/// </summary>
		System.Decimal?  ThanhTien  { get; set; }
		
		/// <summary>
		/// Thue : 
		/// </summary>
		System.Decimal?  Thue  { get; set; }
		
		/// <summary>
		/// ConNhan : 
		/// </summary>
		System.Decimal?  ConNhan  { get; set; }
		
		/// <summary>
		/// GhiChu : 
		/// </summary>
		System.String  GhiChu  { get; set; }
		
		/// <summary>
		/// NgayXacNhan : 
		/// </summary>
		System.DateTime?  NgayXacNhan  { get; set; }
		
		/// <summary>
		/// HeSoNgoaiGio : 
		/// </summary>
		System.Decimal?  HeSoNgoaiGio  { get; set; }
		
		/// <summary>
		/// HeSoLopDong : 
		/// </summary>
		System.Decimal?  HeSoLopDong  { get; set; }
		
		/// <summary>
		/// HeSoKhoiNganh : 
		/// </summary>
		System.Decimal?  HeSoKhoiNganh  { get; set; }
		
		/// <summary>
		/// HeSoBacDaoTao : 
		/// </summary>
		System.Decimal?  HeSoBacDaoTao  { get; set; }
		
		/// <summary>
		/// HeSoNgonNgu : 
		/// </summary>
		System.Decimal?  HeSoNgonNgu  { get; set; }
		
		/// <summary>
		/// TietQuyDoi : 
		/// </summary>
		System.Decimal?  TietQuyDoi  { get; set; }
		
		/// <summary>
		/// SoTietTkb : 
		/// </summary>
		System.Decimal?  SoTietTkb  { get; set; }
		
		/// <summary>
		/// NgayNhap : 
		/// </summary>
		System.DateTime?  NgayNhap  { get; set; }
		
		/// <summary>
		/// XacNhan : 
		/// </summary>
		System.Boolean?  XacNhan  { get; set; }
		
		/// <summary>
		/// MaHocHam : 
		/// </summary>
		System.Int32?  MaHocHam  { get; set; }
		
		/// <summary>
		/// MaHocVi : 
		/// </summary>
		System.Int32?  MaHocVi  { get; set; }
		
		/// <summary>
		/// SiSoNhomThucHanh : 
		/// </summary>
		System.Decimal?  SiSoNhomThucHanh  { get; set; }
		
		/// <summary>
		/// HeSoQuyDoiThucHanhSangLyThuyet : 
		/// </summary>
		System.Decimal?  HeSoQuyDoiThucHanhSangLyThuyet  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

