﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'GiangVien_PhucCap' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IGiangVienPhucCap 
	{
		/// <summary>			
		/// MaQuanLy : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "GiangVien_PhucCap"</remarks>
		System.Int32 MaQuanLy { get; set; }
				
		
		
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
		/// SoDot : 
		/// </summary>
		System.Int32?  SoDot  { get; set; }
		
		/// <summary>
		/// SoNgay : 
		/// </summary>
		System.Int32?  SoNgay  { get; set; }
		
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		System.DateTime?  NgayCapNhat  { get; set; }
		
		/// <summary>
		/// NguoiCapNhat : 
		/// </summary>
		System.String  NguoiCapNhat  { get; set; }
		
		/// <summary>
		/// TinhTrang : 
		/// </summary>
		System.Boolean?  TinhTrang  { get; set; }
		
		/// <summary>
		/// GhiChu : 
		/// </summary>
		System.String  GhiChu  { get; set; }
		
		/// <summary>
		/// MaPhuCap : 
		/// </summary>
		System.String  MaPhuCap  { get; set; }
		
		/// <summary>
		/// MaLopHocPhan : 
		/// </summary>
		System.String  MaLopHocPhan  { get; set; }
		
		/// <summary>
		/// MaMonHoc : 
		/// </summary>
		System.String  MaMonHoc  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


