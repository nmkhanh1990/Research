﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'HeSoLopDong' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IHeSoLopDong 
	{
		/// <summary>			
		/// MaHeSo : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "HeSoLopDong"</remarks>
		System.Int32 MaHeSo { get; set; }
				
		
		
		/// <summary>
		/// STT : 
		/// </summary>
		System.Int32?  Stt  { get; set; }
		
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		System.String  MaQuanLy  { get; set; }
		
		/// <summary>
		/// MaBacDaoTao : 
		/// </summary>
		System.String  MaBacDaoTao  { get; set; }
		
		/// <summary>
		/// MaNhomMonHoc : 
		/// </summary>
		System.String  MaNhomMonHoc  { get; set; }
		
		/// <summary>
		/// TuKhoan : 
		/// </summary>
		System.Int32?  TuKhoan  { get; set; }
		
		/// <summary>
		/// DenKhoan : 
		/// </summary>
		System.Int32?  DenKhoan  { get; set; }
		
		/// <summary>
		/// HeSo : 
		/// </summary>
		System.Decimal?  HeSo  { get; set; }
		
		/// <summary>
		/// NgayBDApDung : 
		/// </summary>
		System.DateTime?  NgayBdApDung  { get; set; }
		
		/// <summary>
		/// NgayKTApDung : 
		/// </summary>
		System.DateTime?  NgayKtApDung  { get; set; }
		
		/// <summary>
		/// MaLoaiKhoiLuong : 
		/// </summary>
		System.String  MaLoaiKhoiLuong  { get; set; }
		
		/// <summary>
		/// HocKyApDung : 
		/// </summary>
		System.String  HocKyApDung  { get; set; }
		
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
		/// LoaiLop : 
		/// </summary>
		System.String  LoaiLop  { get; set; }
		
		/// <summary>
		/// MaDonVi : 
		/// </summary>
		System.String  MaDonVi  { get; set; }
		
		/// <summary>
		/// MaLoaiGiangVien : 
		/// </summary>
		System.String  MaLoaiGiangVien  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


