﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'ChiTienThuLaoGiangDay' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IChiTienThuLaoGiangDay 
	{
		/// <summary>			
		/// Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ChiTienThuLaoGiangDay"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		System.String  NamHoc  { get; set; }
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		System.String  HocKy  { get; set; }
		
		/// <summary>
		/// MaCanBoGiangDay : 
		/// </summary>
		System.String  MaCanBoGiangDay  { get; set; }
		
		/// <summary>
		/// Oid : 
		/// </summary>
		System.Guid?  Oid  { get; set; }
		
		/// <summary>
		/// LaGiangVienThinhGiang : 
		/// </summary>
		System.Boolean?  LaGiangVienThinhGiang  { get; set; }
		
		/// <summary>
		/// TongTien : 
		/// </summary>
		System.Decimal?  TongTien  { get; set; }
		
		/// <summary>
		/// SoChungTuHrm : 
		/// </summary>
		System.String  SoChungTuHrm  { get; set; }
		
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		System.String  NgayCapNhat  { get; set; }
		
		/// <summary>
		/// NguoiCapNhat : 
		/// </summary>
		System.String  NguoiCapNhat  { get; set; }
		
		/// <summary>
		/// NgayLayDuLieu : 
		/// </summary>
		System.String  NgayLayDuLieu  { get; set; }
		
		/// <summary>
		/// MaMonHoc : 
		/// </summary>
		System.String  MaMonHoc  { get; set; }
		
		/// <summary>
		/// TongSoTietQuyDoi : 
		/// </summary>
		System.Decimal?  TongSoTietQuyDoi  { get; set; }
		
		/// <summary>
		/// MaLopHocPhan : 
		/// </summary>
		System.String  MaLopHocPhan  { get; set; }
		
		/// <summary>
		/// MaLopSinhVien : 
		/// </summary>
		System.String  MaLopSinhVien  { get; set; }
		
		/// <summary>
		/// LopClc : 
		/// </summary>
		System.Boolean?  LopClc  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


