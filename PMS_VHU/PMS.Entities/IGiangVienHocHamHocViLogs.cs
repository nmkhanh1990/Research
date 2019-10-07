﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'GiangVien_HocHamHocVi_Logs' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IGiangVienHocHamHocViLogs 
	{
		/// <summary>			
		/// MaQuanLy : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "GiangVien_HocHamHocVi_Logs"</remarks>
		System.Int32 MaQuanLy { get; set; }
				
		
		
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		System.Int32?  MaGiangVien  { get; set; }
		
		/// <summary>
		/// MaHocHam : 
		/// </summary>
		System.Int32?  MaHocHam  { get; set; }
		
		/// <summary>
		/// MaHocVi : 
		/// </summary>
		System.Int32?  MaHocVi  { get; set; }
		
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


