﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'ThoiGianGiangDay' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IThoiGianGiangDay 
	{
		/// <summary>			
		/// NamHoc : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ThoiGianGiangDay"</remarks>
		System.String NamHoc { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.String OriginalNamHoc { get; set; }
			
		/// <summary>			
		/// HocKy : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ThoiGianGiangDay"</remarks>
		System.String HocKy { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.String OriginalHocKy { get; set; }
			
		
		
		/// <summary>
		/// NgayBatDau : 
		/// </summary>
		System.DateTime?  NgayBatDau  { get; set; }
		
		/// <summary>
		/// NgayKetThuc : 
		/// </summary>
		System.DateTime?  NgayKetThuc  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

