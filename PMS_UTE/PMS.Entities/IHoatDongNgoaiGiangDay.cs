﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'HoatDongNgoaiGiangDay' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IHoatDongNgoaiGiangDay 
	{
		/// <summary>			
		/// MaQuanLy : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "HoatDongNgoaiGiangDay"</remarks>
		System.Int32 MaQuanLy { get; set; }
				
		
		
		/// <summary>
		/// TenHoatDong : 
		/// </summary>
		System.String  TenHoatDong  { get; set; }
		
		/// <summary>
		/// MaDonViTinh : 
		/// </summary>
		System.Int32?  MaDonViTinh  { get; set; }
		
		/// <summary>
		/// SoLuong : 
		/// </summary>
		System.Decimal?  SoLuong  { get; set; }
		
		/// <summary>
		/// MucQuyDoi : 
		/// </summary>
		System.Decimal?  MucQuyDoi  { get; set; }
		
		/// <summary>
		/// DonGia : 
		/// </summary>
		System.Decimal?  DonGia  { get; set; }
		
		/// <summary>
		/// GhiChu : 
		/// </summary>
		System.String  GhiChu  { get; set; }
		
		/// <summary>
		/// MaNhom : 
		/// </summary>
		System.String  MaNhom  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _giangVienHoatDongNgoaiGiangDayMaHoatDong
		/// </summary>	
		TList<GiangVienHoatDongNgoaiGiangDay> GiangVienHoatDongNgoaiGiangDayCollection {  get;  set;}	

		#endregion Data Properties

	}
}


