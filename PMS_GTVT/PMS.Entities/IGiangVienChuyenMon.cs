﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'GiangVien_ChuyenMon' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IGiangVienChuyenMon 
	{
		/// <summary>			
		/// MaPhanCong : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "GiangVien_ChuyenMon"</remarks>
		System.Int32 MaPhanCong { get; set; }
				
		
		
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		System.Int32?  MaGiangVien  { get; set; }
		
		/// <summary>
		/// MaMonHoc : 
		/// </summary>
		System.String  MaMonHoc  { get; set; }
		
		/// <summary>
		/// NgayPhanCong : 
		/// </summary>
		System.DateTime?  NgayPhanCong  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

