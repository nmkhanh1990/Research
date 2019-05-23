﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'NhomHoatDongNgoaiGiangDay' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface INhomHoatDongNgoaiGiangDay 
	{
		/// <summary>			
		/// MaNhom : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "NhomHoatDongNgoaiGiangDay"</remarks>
		System.String MaNhom { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.String OriginalMaNhom { get; set; }
			
		
		
		/// <summary>
		/// TenNhom : 
		/// </summary>
		System.String  TenNhom  { get; set; }
		
		/// <summary>
		/// GhiChu : 
		/// </summary>
		System.String  GhiChu  { get; set; }
		
		/// <summary>
		/// OrderBy : 
		/// </summary>
		System.Int32?  OrderBy  { get; set; }
		
		/// <summary>
		/// NhomCLC : 
		/// </summary>
		System.Boolean?  NhomClc  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _hoatDongNgoaiGiangDayMaNhom
		/// </summary>	
		TList<HoatDongNgoaiGiangDay> HoatDongNgoaiGiangDayCollection {  get;  set;}	

		#endregion Data Properties

	}
}

