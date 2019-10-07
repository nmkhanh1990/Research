﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'SdhNhomMonHoc' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISdhNhomMonHoc 
	{
		/// <summary>			
		/// MaNhomMon : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SdhNhomMonHoc"</remarks>
		System.Int32 MaNhomMon { get; set; }
				
		
		
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		System.String  MaQuanLy  { get; set; }
		
		/// <summary>
		/// TenNhomMon : 
		/// </summary>
		System.String  TenNhomMon  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


