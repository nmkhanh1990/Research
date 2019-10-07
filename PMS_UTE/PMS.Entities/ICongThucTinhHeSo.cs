﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'CongThucTinhHeSo' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ICongThucTinhHeSo 
	{
		/// <summary>			
		/// ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "CongThucTinhHeSo"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// MaLoaiHeSo : 
		/// </summary>
		System.Int32?  MaLoaiHeSo  { get; set; }
		
		/// <summary>
		/// MaHeSoTinhCongThuc : 
		/// </summary>
		System.String  MaHeSoTinhCongThuc  { get; set; }
		
		/// <summary>
		/// TenHienThiCongThuc : 
		/// </summary>
		System.String  TenHienThiCongThuc  { get; set; }
		
		/// <summary>
		/// ThamSoDauVao : 
		/// </summary>
		System.String  ThamSoDauVao  { get; set; }
		
		/// <summary>
		/// CotCanTinh : 
		/// </summary>
		System.String  CotCanTinh  { get; set; }
		
		/// <summary>
		/// ApDung : 
		/// </summary>
		System.Boolean?  ApDung  { get; set; }
		
		/// <summary>
		/// ToanTu : 
		/// </summary>
		System.String  ToanTu  { get; set; }
		
		/// <summary>
		/// DefaultValue : 
		/// </summary>
		System.Decimal?  DefaultValue  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

