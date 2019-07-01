﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'QuyUocDatTenLopHocPhan' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IQuyUocDatTenLopHocPhan 
	{
		/// <summary>			
		/// Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "QuyUocDatTenLopHocPhan"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// MaHinhThucDaoTao : 
		/// </summary>
		System.String  MaHinhThucDaoTao  { get; set; }
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		System.String  NamHoc  { get; set; }
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		System.String  HocKy  { get; set; }
		
		/// <summary>
		/// TuMaLop : 
		/// </summary>
		System.String  TuMaLop  { get; set; }
		
		/// <summary>
		/// DenMaLop : 
		/// </summary>
		System.String  DenMaLop  { get; set; }
		
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

