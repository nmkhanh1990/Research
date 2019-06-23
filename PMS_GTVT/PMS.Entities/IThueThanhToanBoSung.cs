﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'ThueThanhToanBoSung' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IThueThanhToanBoSung 
	{
		/// <summary>			
		/// Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ThueThanhToanBoSung"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		System.Int32?  MaGiangVien  { get; set; }
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		System.String  NamHoc  { get; set; }
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		System.String  HocKy  { get; set; }
		
		/// <summary>
		/// Thue : 
		/// </summary>
		System.Decimal?  Thue  { get; set; }
		
		/// <summary>
		/// GhiChu : 
		/// </summary>
		System.String  GhiChu  { get; set; }
		
		/// <summary>
		/// SoTietNckhDaTru : 
		/// </summary>
		System.Decimal?  SoTietNckhDaTru  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


