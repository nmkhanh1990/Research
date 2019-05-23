﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'Tcb_KetQuaQuyDoi' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ITcbKetQuaQuyDoi 
	{
		/// <summary>			
		/// Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "Tcb_KetQuaQuyDoi"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// MaKhoiLuongGiangDay : 
		/// </summary>
		System.Int32?  MaKhoiLuongGiangDay  { get; set; }
		
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		System.String  MaGiangVien  { get; set; }
		
		/// <summary>
		/// MaLopHocPhan : 
		/// </summary>
		System.String  MaLopHocPhan  { get; set; }
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		System.String  NamHoc  { get; set; }
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		System.String  HocKy  { get; set; }
		
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
		System.Decimal?  SoTinChi  { get; set; }
		
		/// <summary>
		/// SoLuong : 
		/// </summary>
		System.Int32?  SoLuong  { get; set; }
		
		/// <summary>
		/// MaLoaiHocPhan : 
		/// </summary>
		System.String  MaLoaiHocPhan  { get; set; }
		
		/// <summary>
		/// LoaiHocPhan : 
		/// </summary>
		System.String  LoaiHocPhan  { get; set; }
		
		/// <summary>
		/// MaBuoiHoc : 
		/// </summary>
		System.Int32?  MaBuoiHoc  { get; set; }
		
		/// <summary>
		/// MaLop : 
		/// </summary>
		System.String  MaLop  { get; set; }
		
		/// <summary>
		/// TietBatDau : 
		/// </summary>
		System.Int32?  TietBatDau  { get; set; }
		
		/// <summary>
		/// SoTiet : 
		/// </summary>
		System.Int32?  SoTiet  { get; set; }
		
		/// <summary>
		/// TinhTrang : 
		/// </summary>
		System.Int32?  TinhTrang  { get; set; }
		
		/// <summary>
		/// NgayDay : 
		/// </summary>
		System.DateTime?  NgayDay  { get; set; }
		
		/// <summary>
		/// MaBacDaoTao : 
		/// </summary>
		System.String  MaBacDaoTao  { get; set; }
		
		/// <summary>
		/// MaKhoaHoc : 
		/// </summary>
		System.String  MaKhoaHoc  { get; set; }
		
		/// <summary>
		/// MaKhoa : 
		/// </summary>
		System.String  MaKhoa  { get; set; }
		
		/// <summary>
		/// MaNhomMonHoc : 
		/// </summary>
		System.String  MaNhomMonHoc  { get; set; }
		
		/// <summary>
		/// MaCoSo : 
		/// </summary>
		System.String  MaCoSo  { get; set; }
		
		/// <summary>
		/// HeSoLopDong : 
		/// </summary>
		System.Decimal?  HeSoLopDong  { get; set; }
		
		/// <summary>
		/// DonGia : 
		/// </summary>
		System.Decimal?  DonGia  { get; set; }
		
		/// <summary>
		/// ThanhTien : 
		/// </summary>
		System.Decimal?  ThanhTien  { get; set; }
		
		/// <summary>
		/// CongTacPhi : 
		/// </summary>
		System.Decimal?  CongTacPhi  { get; set; }
		
		/// <summary>
		/// TienGiangNgoaiGio : 
		/// </summary>
		System.Decimal?  TienGiangNgoaiGio  { get; set; }
		
		/// <summary>
		/// TongThanhTien : 
		/// </summary>
		System.Decimal?  TongThanhTien  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

