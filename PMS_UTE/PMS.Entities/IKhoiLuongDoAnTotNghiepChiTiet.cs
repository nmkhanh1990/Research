﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'KhoiLuongDoAnTotNghiepChiTiet' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IKhoiLuongDoAnTotNghiepChiTiet 
	{
		/// <summary>			
		/// Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "KhoiLuongDoAnTotNghiepChiTiet"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		System.Int32?  MaGiangVien  { get; set; }
		
		/// <summary>
		/// HoTen : 
		/// </summary>
		System.String  HoTen  { get; set; }
		
		/// <summary>
		/// MaMonHoc : 
		/// </summary>
		System.String  MaMonHoc  { get; set; }
		
		/// <summary>
		/// TenMonHoc : 
		/// </summary>
		System.String  TenMonHoc  { get; set; }
		
		/// <summary>
		/// SoTinChi : 
		/// </summary>
		System.Int32?  SoTinChi  { get; set; }
		
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
		/// MaLop : 
		/// </summary>
		System.String  MaLop  { get; set; }
		
		/// <summary>
		/// Nhom : 
		/// </summary>
		System.String  Nhom  { get; set; }
		
		/// <summary>
		/// MaLoaiHocPhan : 
		/// </summary>
		System.Int32?  MaLoaiHocPhan  { get; set; }
		
		/// <summary>
		/// LopClc : 
		/// </summary>
		System.Boolean?  LopClc  { get; set; }
		
		/// <summary>
		/// SoLuongHuongDan : 
		/// </summary>
		System.Int32?  SoLuongHuongDan  { get; set; }
		
		/// <summary>
		/// SoTiet : 
		/// </summary>
		System.Decimal?  SoTiet  { get; set; }
		
		/// <summary>
		/// DonGia : 
		/// </summary>
		System.Decimal?  DonGia  { get; set; }
		
		/// <summary>
		/// SoTien : 
		/// </summary>
		System.Decimal?  SoTien  { get; set; }
		
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		System.DateTime?  NgayCapNhat  { get; set; }
		
		/// <summary>
		/// HeSoHocKy : 
		/// </summary>
		System.Decimal?  HeSoHocKy  { get; set; }
		
		/// <summary>
		/// HeSoThamGia : 
		/// </summary>
		System.Decimal?  HeSoThamGia  { get; set; }
		
		/// <summary>
		/// SoLuongDeTai : 
		/// </summary>
		System.Int32?  SoLuongDeTai  { get; set; }
		
		/// <summary>
		/// LoaiThamGia : 
		/// </summary>
		System.String  LoaiThamGia  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


