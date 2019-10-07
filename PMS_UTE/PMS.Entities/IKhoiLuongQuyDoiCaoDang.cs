﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'KhoiLuongQuyDoiCaoDang' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IKhoiLuongQuyDoiCaoDang 
	{
		/// <summary>			
		/// MaKhoiLuongQuyDoiCaoDang : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "KhoiLuongQuyDoiCaoDang"</remarks>
		System.Int32 MaKhoiLuongQuyDoiCaoDang { get; set; }
				
		
		
		/// <summary>
		/// TietQuyDoiLT : 
		/// </summary>
		System.Decimal?  TietQuyDoiLt  { get; set; }
		
		/// <summary>
		/// TietQuyDoiTH : 
		/// </summary>
		System.Decimal?  TietQuyDoiTh  { get; set; }
		
		/// <summary>
		/// TongTietQuyDoi : 
		/// </summary>
		System.Decimal?  TongTietQuyDoi  { get; set; }
		
		/// <summary>
		/// MaKhoiLuongCaoDang : 
		/// </summary>
		System.Int32?  MaKhoiLuongCaoDang  { get; set; }
		
		/// <summary>
		/// MaLoaiGiangVien : 
		/// </summary>
		System.Int32?  MaLoaiGiangVien  { get; set; }
		
		/// <summary>
		/// MaHocHam : 
		/// </summary>
		System.Int32?  MaHocHam  { get; set; }
		
		/// <summary>
		/// MaHocVi : 
		/// </summary>
		System.Int32?  MaHocVi  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


