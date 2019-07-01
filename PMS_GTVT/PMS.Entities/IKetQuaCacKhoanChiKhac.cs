﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'KetQuaCacKhoanChiKhac' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IKetQuaCacKhoanChiKhac 
	{
		/// <summary>			
		/// Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "KetQuaCacKhoanChiKhac"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// MaGiangVienQuanLy : 
		/// </summary>
		System.String  MaGiangVienQuanLy  { get; set; }
		
		/// <summary>
		/// Lop : 
		/// </summary>
		System.String  Lop  { get; set; }
		
		/// <summary>
		/// MaSo : 
		/// </summary>
		System.String  MaSo  { get; set; }
		
		/// <summary>
		/// Ngay : 
		/// </summary>
		System.DateTime?  Ngay  { get; set; }
		
		/// <summary>
		/// NoiDung : 
		/// </summary>
		System.String  NoiDung  { get; set; }
		
		/// <summary>
		/// HeSo : 
		/// </summary>
		System.Decimal?  HeSo  { get; set; }
		
		/// <summary>
		/// SoTiet : 
		/// </summary>
		System.Decimal?  SoTiet  { get; set; }
		
		/// <summary>
		/// TienMotTiet : 
		/// </summary>
		System.Decimal?  TienMotTiet  { get; set; }
		
		/// <summary>
		/// ThanhTien : 
		/// </summary>
		System.Decimal?  ThanhTien  { get; set; }
		
		/// <summary>
		/// PhiCongTac : 
		/// </summary>
		System.Decimal?  PhiCongTac  { get; set; }
		
		/// <summary>
		/// TienGiangNgoaiGio : 
		/// </summary>
		System.Decimal?  TienGiangNgoaiGio  { get; set; }
		
		/// <summary>
		/// TongThanhTien : 
		/// </summary>
		System.Decimal?  TongThanhTien  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

