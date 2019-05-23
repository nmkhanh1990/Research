﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'HeSoNgay' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IHeSoNgay 
	{
		/// <summary>			
		/// MaHeSo : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "HeSoNgay"</remarks>
		System.Int32 MaHeSo { get; set; }
				
		
		
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		System.String  MaQuanLy  { get; set; }
		
		/// <summary>
		/// TenHeSo : 
		/// </summary>
		System.String  TenHeSo  { get; set; }
		
		/// <summary>
		/// HeSo : 
		/// </summary>
		System.Decimal?  HeSo  { get; set; }
		
		/// <summary>
		/// TietBatDau : 
		/// </summary>
		System.Int32?  TietBatDau  { get; set; }
		
		/// <summary>
		/// TietKetThuc : 
		/// </summary>
		System.Int32?  TietKetThuc  { get; set; }
		
		/// <summary>
		/// TietNghiaVu : 
		/// </summary>
		System.Boolean?  TietNghiaVu  { get; set; }
		
		/// <summary>
		/// TrongGio : 
		/// </summary>
		System.Boolean?  TrongGio  { get; set; }
		
		/// <summary>
		/// MaBuoi : 
		/// </summary>
		System.String  MaBuoi  { get; set; }
		
		/// <summary>
		/// TenBuoi : 
		/// </summary>
		System.String  TenBuoi  { get; set; }
		
		/// <summary>
		/// ThuTu : 
		/// </summary>
		System.Int32?  ThuTu  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

