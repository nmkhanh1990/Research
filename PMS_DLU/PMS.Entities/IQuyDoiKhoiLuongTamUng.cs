﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'QuyDoiKhoiLuongTamUng' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IQuyDoiKhoiLuongTamUng 
	{
		/// <summary>			
		/// Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "QuyDoiKhoiLuongTamUng"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// MaKhoiLuongTamUng : 
		/// </summary>
		System.Int32?  MaKhoiLuongTamUng  { get; set; }
		
		/// <summary>
		/// HeSoCongViec : 
		/// </summary>
		System.Decimal?  HeSoCongViec  { get; set; }
		
		/// <summary>
		/// HeSoBacDaoTao : 
		/// </summary>
		System.Decimal?  HeSoBacDaoTao  { get; set; }
		
		/// <summary>
		/// HeSoNgonNgu : 
		/// </summary>
		System.Decimal?  HeSoNgonNgu  { get; set; }
		
		/// <summary>
		/// HeSoChucDanhChuyenMon : 
		/// </summary>
		System.Decimal?  HeSoChucDanhChuyenMon  { get; set; }
		
		/// <summary>
		/// HeSoLopDong : 
		/// </summary>
		System.Decimal?  HeSoLopDong  { get; set; }
		
		/// <summary>
		/// HeSoCoSo : 
		/// </summary>
		System.Decimal?  HeSoCoSo  { get; set; }
		
		/// <summary>
		/// SoTietThucTeQuyDoi : 
		/// </summary>
		System.Decimal?  SoTietThucTeQuyDoi  { get; set; }
		
		/// <summary>
		/// TietQuyDoi : 
		/// </summary>
		System.Decimal?  TietQuyDoi  { get; set; }
		
		/// <summary>
		/// HeSoQuyDoiThucHanhSangLyThuyet : 
		/// </summary>
		System.Decimal?  HeSoQuyDoiThucHanhSangLyThuyet  { get; set; }
		
		/// <summary>
		/// HeSoNgoaiGio : 
		/// </summary>
		System.Decimal?  HeSoNgoaiGio  { get; set; }
		
		/// <summary>
		/// LoaiLop : 
		/// </summary>
		System.String  LoaiLop  { get; set; }
		
		/// <summary>
		/// HeSoClcCntn : 
		/// </summary>
		System.Decimal?  HeSoClcCntn  { get; set; }
		
		/// <summary>
		/// HeSoThinhGiangMonChuyenNganh : 
		/// </summary>
		System.Decimal?  HeSoThinhGiangMonChuyenNganh  { get; set; }
		
		/// <summary>
		/// HeSoTroCap : 
		/// </summary>
		System.Decimal?  HeSoTroCap  { get; set; }
		
		/// <summary>
		/// HeSoLuong : 
		/// </summary>
		System.Decimal?  HeSoLuong  { get; set; }
		
		/// <summary>
		/// HeSoMonMoi : 
		/// </summary>
		System.Decimal?  HeSoMonMoi  { get; set; }
		
		/// <summary>
		/// HeSoNienCheTinChi : 
		/// </summary>
		System.Decimal?  HeSoNienCheTinChi  { get; set; }
		
		/// <summary>
		/// GhiChu : 
		/// </summary>
		System.String  GhiChu  { get; set; }
		
		/// <summary>
		/// Chot : 
		/// </summary>
		System.Boolean?  Chot  { get; set; }
		
		/// <summary>
		/// MucThanhToan : 
		/// </summary>
		System.Decimal?  MucThanhToan  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

