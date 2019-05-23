﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'KcqKhoiLuongThucTapCuoiKhoa' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IKcqKhoiLuongThucTapCuoiKhoa 
	{
		/// <summary>			
		/// Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "KcqKhoiLuongThucTapCuoiKhoa"</remarks>
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
		/// MaMonHoc : 
		/// </summary>
		System.String  MaMonHoc  { get; set; }
		
		/// <summary>
		/// MaLopHocPhan : 
		/// </summary>
		System.String  MaLopHocPhan  { get; set; }
		
		/// <summary>
		/// MaLoaiHocPhan : 
		/// </summary>
		System.Int32?  MaLoaiHocPhan  { get; set; }
		
		/// <summary>
		/// MaNhom : 
		/// </summary>
		System.String  MaNhom  { get; set; }
		
		/// <summary>
		/// MaLop : 
		/// </summary>
		System.String  MaLop  { get; set; }
		
		/// <summary>
		/// SiSo : 
		/// </summary>
		System.Int32?  SiSo  { get; set; }
		
		/// <summary>
		/// SoTinChi : 
		/// </summary>
		System.Int32?  SoTinChi  { get; set; }
		
		/// <summary>
		/// SoTuan : 
		/// </summary>
		System.Int32?  SoTuan  { get; set; }
		
		/// <summary>
		/// HeSoHocKy : 
		/// </summary>
		System.Decimal?  HeSoHocKy  { get; set; }
		
		/// <summary>
		/// TietQuyDoi : 
		/// </summary>
		System.Decimal?  TietQuyDoi  { get; set; }
		
		/// <summary>
		/// DonGia : 
		/// </summary>
		System.Decimal?  DonGia  { get; set; }
		
		/// <summary>
		/// MaDiaDiem : 
		/// </summary>
		System.Int32?  MaDiaDiem  { get; set; }
		
		/// <summary>
		/// HeSoDiaDiem : 
		/// </summary>
		System.Decimal?  HeSoDiaDiem  { get; set; }
		
		/// <summary>
		/// DonGiaDiaDiem : 
		/// </summary>
		System.Decimal?  DonGiaDiaDiem  { get; set; }
		
		/// <summary>
		/// TienXeDiaDiem : 
		/// </summary>
		System.Decimal?  TienXeDiaDiem  { get; set; }
		
		/// <summary>
		/// ThanhTienGiangDay : 
		/// </summary>
		System.Decimal?  ThanhTienGiangDay  { get; set; }
		
		/// <summary>
		/// GhiChu : 
		/// </summary>
		System.String  GhiChu  { get; set; }
		
		/// <summary>
		/// DotThanhToan : 
		/// </summary>
		System.String  DotThanhToan  { get; set; }
		
		/// <summary>
		/// MaDonVi : 
		/// </summary>
		System.String  MaDonVi  { get; set; }
		
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
		/// HeSoQuyDoi : 
		/// </summary>
		System.Decimal?  HeSoQuyDoi  { get; set; }
		
		/// <summary>
		/// Loai : 
		/// </summary>
		System.String  Loai  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

