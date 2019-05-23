﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'TrinhDoChinhTri' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ITrinhDoChinhTri 
	{
		/// <summary>			
		/// MaTrinhDoChinhTri : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "TrinhDoChinhTri"</remarks>
		System.Int32 MaTrinhDoChinhTri { get; set; }
				
		
		
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		System.String  MaQuanLy  { get; set; }
		
		/// <summary>
		/// TenTrinhDoChinhTri : 
		/// </summary>
		System.String  TenTrinhDoChinhTri  { get; set; }
		
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
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _giangVienMaTrinhDoChinhTri
		/// </summary>	
		TList<GiangVien> GiangVienCollection {  get;  set;}	

		#endregion Data Properties

	}
}

