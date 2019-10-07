﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'DinhMucGioChuan' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IDinhMucGioChuan 
	{
		/// <summary>			
		/// MaDinhMuc : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "DinhMucGioChuan"</remarks>
		System.Int32 MaDinhMuc { get; set; }
				
		
		
		/// <summary>
		/// STT : 
		/// </summary>
		System.Int32?  Stt  { get; set; }
		
		/// <summary>
		/// MaHocHam : 
		/// </summary>
		System.Int32?  MaHocHam  { get; set; }
		
		/// <summary>
		/// MaHocVi : 
		/// </summary>
		System.Int32?  MaHocVi  { get; set; }
		
		/// <summary>
		/// DinhMucMonHoc : 
		/// </summary>
		System.Int32?  DinhMucMonHoc  { get; set; }
		
		/// <summary>
		/// DinhMucMonGdtcQp : 
		/// </summary>
		System.Int32?  DinhMucMonGdtcQp  { get; set; }
		
		/// <summary>
		/// DinhMucNckh : 
		/// </summary>
		System.Int32?  DinhMucNckh  { get; set; }
		
		/// <summary>
		/// HeSoLuongTangThem : 
		/// </summary>
		System.Decimal?  HeSoLuongTangThem  { get; set; }
		
		/// <summary>
		/// MaBacLuong : 
		/// </summary>
		System.String  MaBacLuong  { get; set; }
		
		/// <summary>
		/// DinhMucHoatDongChuyenMonKhac : 
		/// </summary>
		System.Int32?  DinhMucHoatDongChuyenMonKhac  { get; set; }
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		System.String  NamHoc  { get; set; }
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		System.String  HocKy  { get; set; }
		
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		System.String  NgayCapNhat  { get; set; }
		
		/// <summary>
		/// NguoiCapNhat : 
		/// </summary>
		System.String  NguoiCapNhat  { get; set; }
		
		/// <summary>
		/// TongDinhMuc : 
		/// </summary>
		System.Int32?  TongDinhMuc  { get; set; }
		
		/// <summary>
		/// HeSo : 
		/// </summary>
		System.Decimal?  HeSo  { get; set; }
		
		/// <summary>
		/// PhanLoaiGiangVien : 
		/// </summary>
		System.String  PhanLoaiGiangVien  { get; set; }
		
		/// <summary>
		/// TuHeSoLuong : 
		/// </summary>
		System.Decimal?  TuHeSoLuong  { get; set; }
		
		/// <summary>
		/// DenHeSoLuong : 
		/// </summary>
		System.Decimal?  DenHeSoLuong  { get; set; }
		
		/// <summary>
		/// MaBacDaoTao : 
		/// </summary>
		System.String  MaBacDaoTao  { get; set; }
		
		/// <summary>
		/// MaLoaiHinhDaoTao : 
		/// </summary>
		System.String  MaLoaiHinhDaoTao  { get; set; }
		
		/// <summary>
		/// MaNhomGiangVien : 
		/// </summary>
		System.String  MaNhomGiangVien  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


