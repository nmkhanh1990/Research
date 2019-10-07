﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'KhoiLuongGiangDayTheoTuan' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IKhoiLuongGiangDayTheoTuan 
	{
		/// <summary>			
		/// MaKhoiLuong : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "KhoiLuongGiangDayTheoTuan"</remarks>
		System.Int32 MaKhoiLuong { get; set; }
				
		
		
		/// <summary>
		/// MaToaNha : 
		/// </summary>
		System.String  MaToaNha  { get; set; }
		
		/// <summary>
		/// MaLopHocPhan : 
		/// </summary>
		System.String  MaLopHocPhan  { get; set; }
		
		/// <summary>
		/// MaLop : 
		/// </summary>
		System.String  MaLop  { get; set; }
		
		/// <summary>
		/// MaNhom : 
		/// </summary>
		System.String  MaNhom  { get; set; }
		
		/// <summary>
		/// LoaiHocPhan : 
		/// </summary>
		System.String  LoaiHocPhan  { get; set; }
		
		/// <summary>
		/// PhanLoai : 
		/// </summary>
		System.String  PhanLoai  { get; set; }
		
		/// <summary>
		/// MaMonHoc : 
		/// </summary>
		System.String  MaMonHoc  { get; set; }
		
		/// <summary>
		/// DienGiai : 
		/// </summary>
		System.String  DienGiai  { get; set; }
		
		/// <summary>
		/// SoTiet : 
		/// </summary>
		System.Decimal?  SoTiet  { get; set; }
		
		/// <summary>
		/// SoTinChi : 
		/// </summary>
		System.Decimal?  SoTinChi  { get; set; }
		
		/// <summary>
		/// SiSoLop : 
		/// </summary>
		System.Int32?  SiSoLop  { get; set; }
		
		/// <summary>
		/// SoNhom : 
		/// </summary>
		System.Int32?  SoNhom  { get; set; }
		
		/// <summary>
		/// MaDiaDiem : 
		/// </summary>
		System.String  MaDiaDiem  { get; set; }
		
		/// <summary>
		/// NgayBatDau : 
		/// </summary>
		System.DateTime?  NgayBatDau  { get; set; }
		
		/// <summary>
		/// NgayKetThuc : 
		/// </summary>
		System.DateTime?  NgayKetThuc  { get; set; }
		
		/// <summary>
		/// ChatLuongCao : 
		/// </summary>
		System.Decimal?  ChatLuongCao  { get; set; }
		
		/// <summary>
		/// NgoaiGio : 
		/// </summary>
		System.Decimal?  NgoaiGio  { get; set; }
		
		/// <summary>
		/// TrongGio : 
		/// </summary>
		System.Decimal?  TrongGio  { get; set; }
		
		/// <summary>
		/// HeSoLopDong : 
		/// </summary>
		System.Decimal?  HeSoLopDong  { get; set; }
		
		/// <summary>
		/// HeSoCoSo : 
		/// </summary>
		System.Decimal?  HeSoCoSo  { get; set; }
		
		/// <summary>
		/// HeSoHocKy : 
		/// </summary>
		System.Decimal?  HeSoHocKy  { get; set; }
		
		/// <summary>
		/// HeSoThanhPhan : 
		/// </summary>
		System.Decimal?  HeSoThanhPhan  { get; set; }
		
		/// <summary>
		/// HeSoTrongGio : 
		/// </summary>
		System.Decimal?  HeSoTrongGio  { get; set; }
		
		/// <summary>
		/// HeSoNgoaiGio : 
		/// </summary>
		System.Decimal?  HeSoNgoaiGio  { get; set; }
		
		/// <summary>
		/// TietQuyDoi : 
		/// </summary>
		System.Decimal?  TietQuyDoi  { get; set; }
		
		/// <summary>
		/// LoaiHocKy : 
		/// </summary>
		System.Int32?  LoaiHocKy  { get; set; }
		
		/// <summary>
		/// ThoiKhoaBieu : 
		/// </summary>
		System.String  ThoiKhoaBieu  { get; set; }
		
		/// <summary>
		/// NgayTao : 
		/// </summary>
		System.DateTime?  NgayTao  { get; set; }
		
		/// <summary>
		/// Tuan : 
		/// </summary>
		System.Int32?  Tuan  { get; set; }
		
		/// <summary>
		/// Nam : 
		/// </summary>
		System.Int32?  Nam  { get; set; }
		
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		System.String  MaQuanLy  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

