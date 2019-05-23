﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'LoaiNhanVien' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ILoaiNhanVien 
	{
		/// <summary>			
		/// MaLoaiNhanVien : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "LoaiNhanVien"</remarks>
		System.Int32 MaLoaiNhanVien { get; set; }
				
		
		
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		System.String  MaQuanLy  { get; set; }
		
		/// <summary>
		/// TenLoaiNhanVien : 
		/// </summary>
		System.String  TenLoaiNhanVien  { get; set; }
		
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
		/// HRMID : 
		/// </summary>
		System.Guid?  Hrmid  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _giangVienMaLoaiNhanVien
		/// </summary>	
		TList<GiangVien> GiangVienCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _quyDinhTienCanTrenMaLoaiNhanVien
		/// </summary>	
		TList<QuyDinhTienCanTren> QuyDinhTienCanTrenCollection {  get;  set;}	

		#endregion Data Properties

	}
}


