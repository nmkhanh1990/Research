﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'HeSoQuyDoiThucHanhSangLyThuyet' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IHeSoQuyDoiThucHanhSangLyThuyet 
	{
		/// <summary>			
		/// NamHoc : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "HeSoQuyDoiThucHanhSangLyThuyet"</remarks>
		System.String NamHoc { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.String OriginalNamHoc { get; set; }
			
		/// <summary>			
		/// HocKy : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "HeSoQuyDoiThucHanhSangLyThuyet"</remarks>
		System.String HocKy { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.String OriginalHocKy { get; set; }
			
		
		
		/// <summary>
		/// HeSo : 
		/// </summary>
		System.Decimal  HeSo  { get; set; }
		
		/// <summary>
		/// GhiChu : 
		/// </summary>
		System.String  GhiChu  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


