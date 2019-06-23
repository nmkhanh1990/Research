﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'ChotKhoiLuongGiangDay' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IChotKhoiLuongGiangDay 
	{
		/// <summary>			
		/// Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ChotKhoiLuongGiangDay"</remarks>
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
		/// LyThuyetThucHanh : 
		/// </summary>
		System.Boolean?  LyThuyetThucHanh  { get; set; }
		
		/// <summary>
		/// DoAnMonHoc : 
		/// </summary>
		System.Boolean?  DoAnMonHoc  { get; set; }
		
		/// <summary>
		/// DoAnTotNghiep : 
		/// </summary>
		System.Boolean?  DoAnTotNghiep  { get; set; }
		
		/// <summary>
		/// KhoiLuongKhac : 
		/// </summary>
		System.Boolean?  KhoiLuongKhac  { get; set; }
		
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		System.DateTime?  NgayCapNhat  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


