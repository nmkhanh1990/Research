﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'GiangVienCamKetKhongTruThue' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IGiangVienCamKetKhongTruThue 
	{
		/// <summary>			
		/// MaGiangVien : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "GiangVienCamKetKhongTruThue"</remarks>
		System.Int32 MaGiangVien { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalMaGiangVien { get; set; }
			
		/// <summary>			
		/// NamHoc : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "GiangVienCamKetKhongTruThue"</remarks>
		System.String NamHoc { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.String OriginalNamHoc { get; set; }
			
		/// <summary>			
		/// HocKy : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "GiangVienCamKetKhongTruThue"</remarks>
		System.String HocKy { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.String OriginalHocKy { get; set; }
			
		
		
		/// <summary>
		/// GhiChu : 
		/// </summary>
		System.String  GhiChu  { get; set; }
		
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		System.String  NgayCapNhat  { get; set; }
		
		/// <summary>
		/// NguoiCapNhat : 
		/// </summary>
		System.String  NguoiCapNhat  { get; set; }
		
		/// <summary>
		/// ThueTNCN : 
		/// </summary>
		System.Decimal?  ThueTncn  { get; set; }
		
		/// <summary>
		/// XacNhanThue : 
		/// </summary>
		System.Boolean?  XacNhanThue  { get; set; }
		
		/// <summary>
		/// XacNhanKhongThue : 
		/// </summary>
		System.Boolean?  XacNhanKhongThue  { get; set; }
		
		/// <summary>
		/// MaHoatDong : 
		/// </summary>
		System.Int32?  MaHoatDong  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

