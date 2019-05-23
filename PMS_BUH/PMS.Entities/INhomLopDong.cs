﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'NhomLopDong' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface INhomLopDong 
	{
		/// <summary>			
		/// MaNhomLop : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "NhomLopDong"</remarks>
		System.Int32 MaNhomLop { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalMaNhomLop { get; set; }
			
		
		
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		System.String  MaQuanLy  { get; set; }
		
		/// <summary>
		/// TenNhomLop : 
		/// </summary>
		System.String  TenNhomLop  { get; set; }
		
		/// <summary>
		/// ThuTu : 
		/// </summary>
		System.Int32?  ThuTu  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _heSoLopDongMaNhomLop
		/// </summary>	
		TList<HeSoLopDong> HeSoLopDongCollection {  get;  set;}	

		#endregion Data Properties

	}
}


