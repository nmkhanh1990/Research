﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'GiamTruDinhMuc' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IGiamTruDinhMuc 
	{
		/// <summary>			
		/// MaQuanLy : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "GiamTruDinhMuc"</remarks>
		System.Int32 MaQuanLy { get; set; }
				
		
		
		/// <summary>
		/// NoiDungGiamTru : 
		/// </summary>
		System.String  NoiDungGiamTru  { get; set; }
		
		/// <summary>
		/// PhanTramGiamTru : 
		/// </summary>
		System.Decimal?  PhanTramGiamTru  { get; set; }
		
		/// <summary>
		/// GhiChu : 
		/// </summary>
		System.String  GhiChu  { get; set; }
		
		/// <summary>
		/// MucGiam : 
		/// </summary>
		System.Decimal?  MucGiam  { get; set; }
		
		/// <summary>
		/// DonVi : 
		/// </summary>
		System.String  DonVi  { get; set; }
		
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		System.String  NgayCapNhat  { get; set; }
		
		/// <summary>
		/// NguoiCapNhat : 
		/// </summary>
		System.String  NguoiCapNhat  { get; set; }
		
		/// <summary>
		/// MucGiamNckh : 
		/// </summary>
		System.Decimal?  MucGiamNckh  { get; set; }
		
		/// <summary>
		/// PhanTramGiamTruNckh : 
		/// </summary>
		System.Decimal?  PhanTramGiamTruNckh  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _giangVienGiamTruDinhMucMaGiamTru
		/// </summary>	
		TList<GiangVienGiamTruDinhMuc> GiangVienGiamTruDinhMucCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _tietNghiaVuMaGiamTruKhac
		/// </summary>	
		TList<TietNghiaVu> TietNghiaVuCollection {  get;  set;}	

		#endregion Data Properties

	}
}


