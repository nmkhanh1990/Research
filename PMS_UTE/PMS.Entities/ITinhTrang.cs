﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'TinhTrang' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ITinhTrang 
	{
		/// <summary>			
		/// MaTinhTrang : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "TinhTrang"</remarks>
		System.Int32 MaTinhTrang { get; set; }
				
		
		
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		System.String  MaQuanLy  { get; set; }
		
		/// <summary>
		/// TenTinhTrang : 
		/// </summary>
		System.String  TenTinhTrang  { get; set; }
		
		/// <summary>
		/// ThuTu : 
		/// </summary>
		System.Int32?  ThuTu  { get; set; }
		
		/// <summary>
		/// HRMID : 
		/// </summary>
		System.Guid?  Hrmid  { get; set; }
		
		/// <summary>
		/// TinhTrang : 
		/// </summary>
		System.Boolean?  TinhTrang  { get; set; }
		
		/// <summary>
		/// TrangThai : 
		/// </summary>
		System.Boolean?  TrangThai  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _giangVienMaTinhTrang
		/// </summary>	
		TList<GiangVien> GiangVienCollection {  get;  set;}	

		#endregion Data Properties

	}
}


