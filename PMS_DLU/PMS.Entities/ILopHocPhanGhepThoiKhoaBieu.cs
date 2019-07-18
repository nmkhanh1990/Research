﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'LopHocPhanGhepThoiKhoaBieu' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ILopHocPhanGhepThoiKhoaBieu 
	{
		/// <summary>			
		/// Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "LopHocPhanGhepThoiKhoaBieu"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// SoThuTu : 
		/// </summary>
		System.Int32?  SoThuTu  { get; set; }
		
		/// <summary>
		/// MaLopHocPhan : 
		/// </summary>
		System.String  MaLopHocPhan  { get; set; }
		
		/// <summary>
		/// MaCanBoGiangDay : 
		/// </summary>
		System.String  MaCanBoGiangDay  { get; set; }
		
		/// <summary>
		/// MaMonHoc : 
		/// </summary>
		System.String  MaMonHoc  { get; set; }
		
		/// <summary>
		/// TenMonHoc : 
		/// </summary>
		System.String  TenMonHoc  { get; set; }
		
		/// <summary>
		/// MaBacDaoTao : 
		/// </summary>
		System.String  MaBacDaoTao  { get; set; }
		
		/// <summary>
		/// SiSoTruocGhep : 
		/// </summary>
		System.Int32?  SiSoTruocGhep  { get; set; }
		
		/// <summary>
		/// SiSoSauGhep : 
		/// </summary>
		System.Int32?  SiSoSauGhep  { get; set; }
		
		/// <summary>
		/// MaLopTruocGhep : 
		/// </summary>
		System.String  MaLopTruocGhep  { get; set; }
		
		/// <summary>
		/// MaLopSauGhep : 
		/// </summary>
		System.String  MaLopSauGhep  { get; set; }
		
		/// <summary>
		/// LopChinh : 
		/// </summary>
		System.Boolean?  LopChinh  { get; set; }
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		System.String  NamHoc  { get; set; }
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		System.String  HocKy  { get; set; }
		
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

		#endregion Data Properties

	}
}

