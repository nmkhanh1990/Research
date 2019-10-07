﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'ThuLaoGiangDayDaiHocLopClc' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IThuLaoGiangDayDaiHocLopClc 
	{
		/// <summary>			
		/// Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ThuLaoGiangDayDaiHocLopClc"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// Stt : 
		/// </summary>
		System.Int32  Stt  { get; set; }
		
		/// <summary>
		/// PhanLoaiGiangVien : 
		/// </summary>
		System.String  PhanLoaiGiangVien  { get; set; }
		
		/// <summary>
		/// MaNhomMon : 
		/// </summary>
		System.Int32?  MaNhomMon  { get; set; }
		
		/// <summary>
		/// MaHocHam : 
		/// </summary>
		System.Int32?  MaHocHam  { get; set; }
		
		/// <summary>
		/// MaHocVi : 
		/// </summary>
		System.String  MaHocVi  { get; set; }
		
		/// <summary>
		/// DonGia : 
		/// </summary>
		System.Decimal?  DonGia  { get; set; }
		
		/// <summary>
		/// NguoiCapNhat : 
		/// </summary>
		System.String  NguoiCapNhat  { get; set; }
		
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		System.DateTime?  NgayCapNhat  { get; set; }
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		System.String  NamHoc  { get; set; }
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		System.String  HocKy  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


