﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'GIangVienThayDoiHocVi' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IGiangVienThayDoiHocVi 
	{
		/// <summary>			
		/// MaQuanLy : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "GIangVienThayDoiHocVi"</remarks>
		System.Int32 MaQuanLy { get; set; }
				
		
		
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		System.Int32?  MaGiangVien  { get; set; }
		
		/// <summary>
		/// MaHocViCu : 
		/// </summary>
		System.Int32?  MaHocViCu  { get; set; }
		
		/// <summary>
		/// MaHocVi : 
		/// </summary>
		System.Int32?  MaHocVi  { get; set; }
		
		/// <summary>
		/// NgayHieuLuc : 
		/// </summary>
		System.DateTime?  NgayHieuLuc  { get; set; }
		
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		System.DateTime?  NgayCapNhat  { get; set; }
		
		/// <summary>
		/// User : 
		/// </summary>
		System.String  User  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


