﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'QuyChe' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IQuyChe 
	{
		/// <summary>			
		/// MaQuyChe : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "QuyChe"</remarks>
		System.String MaQuyChe { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.String OriginalMaQuyChe { get; set; }
			
		
		
		/// <summary>
		/// TenQuyChe : 
		/// </summary>
		System.String  TenQuyChe  { get; set; }
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		System.String  NamHoc  { get; set; }
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		System.String  HocKy  { get; set; }
		
		/// <summary>
		/// NoiDung : 
		/// </summary>
		System.String  NoiDung  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


