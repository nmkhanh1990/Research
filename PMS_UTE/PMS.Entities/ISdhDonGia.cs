﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'SdhDonGia' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISdhDonGia 
	{
		/// <summary>			
		/// Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SdhDonGia"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		System.String  MaQuanLy  { get; set; }
		
		/// <summary>
		/// MaLoaiGiangVien : 
		/// </summary>
		System.Int32?  MaLoaiGiangVien  { get; set; }
		
		/// <summary>
		/// MaHocHam : 
		/// </summary>
		System.Int32?  MaHocHam  { get; set; }
		
		/// <summary>
		/// MaHocVi : 
		/// </summary>
		System.Int32?  MaHocVi  { get; set; }
		
		/// <summary>
		/// DonGia : 
		/// </summary>
		System.Decimal?  DonGia  { get; set; }
		
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		System.DateTime?  NgayCapNhat  { get; set; }
		
		/// <summary>
		/// NguoiCapNhat : 
		/// </summary>
		System.String  NguoiCapNhat  { get; set; }
		
		/// <summary>
		/// DonGiaClc : 
		/// </summary>
		System.Decimal?  DonGiaClc  { get; set; }
		
		/// <summary>
		/// HeSoQuyDoiChatLuong : 
		/// </summary>
		System.Decimal?  HeSoQuyDoiChatLuong  { get; set; }
		
		/// <summary>
		/// DonGiaTrongChuan : 
		/// </summary>
		System.Decimal?  DonGiaTrongChuan  { get; set; }
		
		/// <summary>
		/// DonGiaNgoaiChuan : 
		/// </summary>
		System.Decimal?  DonGiaNgoaiChuan  { get; set; }
		
		/// <summary>
		/// MaHinhThucDaoTao : 
		/// </summary>
		System.String  MaHinhThucDaoTao  { get; set; }
		
		/// <summary>
		/// BacDaoTao : 
		/// </summary>
		System.String  BacDaoTao  { get; set; }
		
		/// <summary>
		/// NgonNguGiangDay : 
		/// </summary>
		System.String  NgonNguGiangDay  { get; set; }
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		System.String  NamHoc  { get; set; }
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		System.String  HocKy  { get; set; }
		
		/// <summary>
		/// TietBatDauDay : 
		/// </summary>
		System.Int32?  TietBatDauDay  { get; set; }
		
		/// <summary>
		/// TietKetThucDay : 
		/// </summary>
		System.Int32?  TietKetThucDay  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


