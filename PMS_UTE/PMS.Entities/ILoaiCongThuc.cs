﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'LoaiCongThuc' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ILoaiCongThuc 
	{
		/// <summary>			
		/// MaLoaiCongThuc : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "LoaiCongThuc"</remarks>
		System.String MaLoaiCongThuc { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.String OriginalMaLoaiCongThuc { get; set; }
			
		
		
		/// <summary>
		/// TenLoaiCongThuc : 
		/// </summary>
		System.String  TenLoaiCongThuc  { get; set; }
		
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


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _congThucTinhQuyDoiMaLoaiCongThuc
		/// </summary>	
		TList<CongThucTinhQuyDoi> CongThucTinhQuyDoiCollection {  get;  set;}	

		#endregion Data Properties

	}
}

