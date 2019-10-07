﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'KcqUte_KhoiLuongQuyDoi' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IKcqUteKhoiLuongQuyDoi 
	{
		/// <summary>			
		/// Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "KcqUte_KhoiLuongQuyDoi"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// IdKhoiLuongGiangDay : 
		/// </summary>
		System.Int32  IdKhoiLuongGiangDay  { get; set; }
		
		/// <summary>
		/// HeSoLopDongLyThuyet : 
		/// </summary>
		System.Decimal?  HeSoLopDongLyThuyet  { get; set; }
		
		/// <summary>
		/// HeSoLopDongThTnTt : 
		/// </summary>
		System.Decimal?  HeSoLopDongThTnTt  { get; set; }
		
		/// <summary>
		/// TietQuyDoi : 
		/// </summary>
		System.Decimal?  TietQuyDoi  { get; set; }
		
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		System.DateTime?  NgayCapNhat  { get; set; }
		
		/// <summary>
		/// SoGioThucGiangTrenLop : 
		/// </summary>
		System.Decimal?  SoGioThucGiangTrenLop  { get; set; }
		
		/// <summary>
		/// SoGioChuanTinhThem : 
		/// </summary>
		System.Decimal?  SoGioChuanTinhThem  { get; set; }
		
		/// <summary>
		/// HeSoHocKy : 
		/// </summary>
		System.Decimal?  HeSoHocKy  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties
	

		/// <summary>
		///	Holds a  KcqUteThanhToanThuLao entity object
		///	which is related to this object through the relation _kcqUteThanhToanThuLaoIdKhoiLuongQuyDoi
		/// </summary>
		KcqUteThanhToanThuLao KcqUteThanhToanThuLao { get; set; }

		#endregion Data Properties

	}
}


