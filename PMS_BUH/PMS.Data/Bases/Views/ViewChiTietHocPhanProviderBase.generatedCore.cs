﻿#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using PMS.Entities;
using PMS.Data;

#endregion

namespace PMS.Data.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="ViewChiTietHocPhanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewChiTietHocPhanProviderBaseCore : EntityViewProviderBase<ViewChiTietHocPhan>
	{
		#region Custom Methods
		
		
		#region cust_View_ChiTiet_HocPhan_GetByMaGiangVienMaLopHocPhanMaLop
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_HocPhan_GetByMaGiangVienMaLopHocPhanMaLop' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewChiTietHocPhan&gt;"/> instance.</returns>
		public VList<ViewChiTietHocPhan> GetByMaGiangVienMaLopHocPhanMaLop(System.String maGiangVien, System.String maLopHocPhan, System.String maLop)
		{
			return GetByMaGiangVienMaLopHocPhanMaLop(null, 0, int.MaxValue , maGiangVien, maLopHocPhan, maLop);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_HocPhan_GetByMaGiangVienMaLopHocPhanMaLop' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewChiTietHocPhan&gt;"/> instance.</returns>
		public VList<ViewChiTietHocPhan> GetByMaGiangVienMaLopHocPhanMaLop(int start, int pageLength, System.String maGiangVien, System.String maLopHocPhan, System.String maLop)
		{
			return GetByMaGiangVienMaLopHocPhanMaLop(null, start, pageLength , maGiangVien, maLopHocPhan, maLop);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_HocPhan_GetByMaGiangVienMaLopHocPhanMaLop' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewChiTietHocPhan&gt;"/> instance.</returns>
		public VList<ViewChiTietHocPhan> GetByMaGiangVienMaLopHocPhanMaLop(TransactionManager transactionManager, System.String maGiangVien, System.String maLopHocPhan, System.String maLop)
		{
			return GetByMaGiangVienMaLopHocPhanMaLop(transactionManager, 0, int.MaxValue , maGiangVien, maLopHocPhan, maLop);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_HocPhan_GetByMaGiangVienMaLopHocPhanMaLop' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewChiTietHocPhan&gt;"/> instance.</returns>
		public abstract VList<ViewChiTietHocPhan> GetByMaGiangVienMaLopHocPhanMaLop(TransactionManager transactionManager, int start, int pageLength, System.String maGiangVien, System.String maLopHocPhan, System.String maLop);
		
		#endregion

		
		#region cust_View_ChiTiet_HocPhan_GetByMaLopHocPhan
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_HocPhan_GetByMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewChiTietHocPhan&gt;"/> instance.</returns>
		public VList<ViewChiTietHocPhan> GetByMaLopHocPhan(System.String maLopHocPhan)
		{
			return GetByMaLopHocPhan(null, 0, int.MaxValue , maLopHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_HocPhan_GetByMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewChiTietHocPhan&gt;"/> instance.</returns>
		public VList<ViewChiTietHocPhan> GetByMaLopHocPhan(int start, int pageLength, System.String maLopHocPhan)
		{
			return GetByMaLopHocPhan(null, start, pageLength , maLopHocPhan);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_HocPhan_GetByMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewChiTietHocPhan&gt;"/> instance.</returns>
		public VList<ViewChiTietHocPhan> GetByMaLopHocPhan(TransactionManager transactionManager, System.String maLopHocPhan)
		{
			return GetByMaLopHocPhan(transactionManager, 0, int.MaxValue , maLopHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_HocPhan_GetByMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewChiTietHocPhan&gt;"/> instance.</returns>
		public abstract VList<ViewChiTietHocPhan> GetByMaLopHocPhan(TransactionManager transactionManager, int start, int pageLength, System.String maLopHocPhan);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewChiTietHocPhan&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewChiTietHocPhan&gt;"/></returns>
		protected static VList&lt;ViewChiTietHocPhan&gt; Fill(DataSet dataSet, VList<ViewChiTietHocPhan> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewChiTietHocPhan>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewChiTietHocPhan&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewChiTietHocPhan>"/></returns>
		protected static VList&lt;ViewChiTietHocPhan&gt; Fill(DataTable dataTable, VList<ViewChiTietHocPhan> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewChiTietHocPhan c = new ViewChiTietHocPhan();
					c.MaLichHoc = (Convert.IsDBNull(row["MaLichHoc"]))?(int)0:(System.Int32)row["MaLichHoc"];
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?string.Empty:(System.String)row["MaGiangVien"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.SoTinChi = (Convert.IsDBNull(row["SoTinChi"]))?0.0m:(System.Decimal?)row["SoTinChi"];
					c.SoLuong = (Convert.IsDBNull(row["SoLuong"]))?(int)0:(System.Int32?)row["SoLuong"];
					c.MaLoaiHocPhan = (Convert.IsDBNull(row["MaLoaiHocPhan"]))?(byte)0:(System.Byte)row["MaLoaiHocPhan"];
					c.LoaiHocPhan = (Convert.IsDBNull(row["LoaiHocPhan"]))?string.Empty:(System.String)row["LoaiHocPhan"];
					c.Nam = (Convert.IsDBNull(row["Nam"]))?(int)0:(System.Int32?)row["Nam"];
					c.Tuan = (Convert.IsDBNull(row["Tuan"]))?(int)0:(System.Int32?)row["Tuan"];
					c.MaPhong = (Convert.IsDBNull(row["MaPhong"]))?string.Empty:(System.String)row["MaPhong"];
					c.MaToaNha = (Convert.IsDBNull(row["MaToaNha"]))?string.Empty:(System.String)row["MaToaNha"];
					c.DonViTinh = (Convert.IsDBNull(row["DonViTinh"]))?string.Empty:(System.String)row["DonViTinh"];
					c.MaCoSo = (Convert.IsDBNull(row["MaCoSo"]))?string.Empty:(System.String)row["MaCoSo"];
					c.MaBuoiHoc = (Convert.IsDBNull(row["MaBuoiHoc"]))?(int)0:(System.Int32?)row["MaBuoiHoc"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.TietBatDau = (Convert.IsDBNull(row["TietBatDau"]))?(int)0:(System.Int32?)row["TietBatDau"];
					c.SoTiet = (Convert.IsDBNull(row["SoTiet"]))?(int)0:(System.Int32?)row["SoTiet"];
					c.LoaiHocKy = (Convert.IsDBNull(row["LoaiHocKy"]))?(byte)0:(System.Byte?)row["LoaiHocKy"];
					c.HeSoCoSo = (Convert.IsDBNull(row["HeSoCoSo"]))?0.0m:(System.Decimal)row["HeSoCoSo"];
					c.HeSoHocKy = (Convert.IsDBNull(row["HeSoHocKy"]))?0.0m:(System.Decimal)row["HeSoHocKy"];
					c.TinhTrang = (Convert.IsDBNull(row["TinhTrang"]))?(int)0:(System.Int32)row["TinhTrang"];
					c.AcceptChanges();
					rows.Add(c);
					pagelen -= 1;
				}
				recordnum += 1;
			}
			return rows;
		}
		*/	
						
		///<summary>
		/// Fill an <see cref="VList&lt;ViewChiTietHocPhan&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewChiTietHocPhan&gt;"/></returns>
		protected VList<ViewChiTietHocPhan> Fill(IDataReader reader, VList<ViewChiTietHocPhan> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewChiTietHocPhan entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewChiTietHocPhan>("ViewChiTietHocPhan",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewChiTietHocPhan();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaLichHoc = (System.Int32)reader["MaLichHoc"];
					//entity.MaLichHoc = (Convert.IsDBNull(reader["MaLichHoc"]))?(int)0:(System.Int32)reader["MaLichHoc"];
					entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.String)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
					entity.MaLopHocPhan = (System.String)reader["MaLopHocPhan"];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.NamHoc = (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.MaMonHoc = (System.String)reader["MaMonHoc"];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = (System.String)reader["TenMonHoc"];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.SoTinChi = reader.IsDBNull(reader.GetOrdinal("SoTinChi")) ? null : (System.Decimal?)reader["SoTinChi"];
					//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?0.0m:(System.Decimal?)reader["SoTinChi"];
					entity.SoLuong = reader.IsDBNull(reader.GetOrdinal("SoLuong")) ? null : (System.Int32?)reader["SoLuong"];
					//entity.SoLuong = (Convert.IsDBNull(reader["SoLuong"]))?(int)0:(System.Int32?)reader["SoLuong"];
					entity.MaLoaiHocPhan = (System.Byte)reader["MaLoaiHocPhan"];
					//entity.MaLoaiHocPhan = (Convert.IsDBNull(reader["MaLoaiHocPhan"]))?(byte)0:(System.Byte)reader["MaLoaiHocPhan"];
					entity.LoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("LoaiHocPhan")) ? null : (System.String)reader["LoaiHocPhan"];
					//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
					entity.Nam = reader.IsDBNull(reader.GetOrdinal("Nam")) ? null : (System.Int32?)reader["Nam"];
					//entity.Nam = (Convert.IsDBNull(reader["Nam"]))?(int)0:(System.Int32?)reader["Nam"];
					entity.Tuan = reader.IsDBNull(reader.GetOrdinal("Tuan")) ? null : (System.Int32?)reader["Tuan"];
					//entity.Tuan = (Convert.IsDBNull(reader["Tuan"]))?(int)0:(System.Int32?)reader["Tuan"];
					entity.MaPhong = reader.IsDBNull(reader.GetOrdinal("MaPhong")) ? null : (System.String)reader["MaPhong"];
					//entity.MaPhong = (Convert.IsDBNull(reader["MaPhong"]))?string.Empty:(System.String)reader["MaPhong"];
					entity.MaToaNha = reader.IsDBNull(reader.GetOrdinal("MaToaNha")) ? null : (System.String)reader["MaToaNha"];
					//entity.MaToaNha = (Convert.IsDBNull(reader["MaToaNha"]))?string.Empty:(System.String)reader["MaToaNha"];
					entity.DonViTinh = reader.IsDBNull(reader.GetOrdinal("DonViTinh")) ? null : (System.String)reader["DonViTinh"];
					//entity.DonViTinh = (Convert.IsDBNull(reader["DonViTinh"]))?string.Empty:(System.String)reader["DonViTinh"];
					entity.MaCoSo = (System.String)reader["MaCoSo"];
					//entity.MaCoSo = (Convert.IsDBNull(reader["MaCoSo"]))?string.Empty:(System.String)reader["MaCoSo"];
					entity.MaBuoiHoc = reader.IsDBNull(reader.GetOrdinal("MaBuoiHoc")) ? null : (System.Int32?)reader["MaBuoiHoc"];
					//entity.MaBuoiHoc = (Convert.IsDBNull(reader["MaBuoiHoc"]))?(int)0:(System.Int32?)reader["MaBuoiHoc"];
					entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.TietBatDau = reader.IsDBNull(reader.GetOrdinal("TietBatDau")) ? null : (System.Int32?)reader["TietBatDau"];
					//entity.TietBatDau = (Convert.IsDBNull(reader["TietBatDau"]))?(int)0:(System.Int32?)reader["TietBatDau"];
					entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Int32?)reader["SoTiet"];
					//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
					entity.LoaiHocKy = reader.IsDBNull(reader.GetOrdinal("LoaiHocKy")) ? null : (System.Byte?)reader["LoaiHocKy"];
					//entity.LoaiHocKy = (Convert.IsDBNull(reader["LoaiHocKy"]))?(byte)0:(System.Byte?)reader["LoaiHocKy"];
					entity.HeSoCoSo = (System.Decimal)reader["HeSoCoSo"];
					//entity.HeSoCoSo = (Convert.IsDBNull(reader["HeSoCoSo"]))?0.0m:(System.Decimal)reader["HeSoCoSo"];
					entity.HeSoHocKy = (System.Decimal)reader["HeSoHocKy"];
					//entity.HeSoHocKy = (Convert.IsDBNull(reader["HeSoHocKy"]))?0.0m:(System.Decimal)reader["HeSoHocKy"];
					entity.TinhTrang = (System.Int32)reader["TinhTrang"];
					//entity.TinhTrang = (Convert.IsDBNull(reader["TinhTrang"]))?(int)0:(System.Int32)reader["TinhTrang"];
					entity.AcceptChanges();
					entity.SuppressEntityEvents = false;
					
					rows.Add(entity);
					pageLength -= 1;
				}
				recordnum += 1;
			}
			return rows;
		}
		
		
		/// <summary>
		/// Refreshes the <see cref="ViewChiTietHocPhan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewChiTietHocPhan"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewChiTietHocPhan entity)
		{
			reader.Read();
			entity.MaLichHoc = (System.Int32)reader["MaLichHoc"];
			//entity.MaLichHoc = (Convert.IsDBNull(reader["MaLichHoc"]))?(int)0:(System.Int32)reader["MaLichHoc"];
			entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.String)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
			entity.MaLopHocPhan = (System.String)reader["MaLopHocPhan"];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.NamHoc = (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.MaMonHoc = (System.String)reader["MaMonHoc"];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = (System.String)reader["TenMonHoc"];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.SoTinChi = reader.IsDBNull(reader.GetOrdinal("SoTinChi")) ? null : (System.Decimal?)reader["SoTinChi"];
			//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?0.0m:(System.Decimal?)reader["SoTinChi"];
			entity.SoLuong = reader.IsDBNull(reader.GetOrdinal("SoLuong")) ? null : (System.Int32?)reader["SoLuong"];
			//entity.SoLuong = (Convert.IsDBNull(reader["SoLuong"]))?(int)0:(System.Int32?)reader["SoLuong"];
			entity.MaLoaiHocPhan = (System.Byte)reader["MaLoaiHocPhan"];
			//entity.MaLoaiHocPhan = (Convert.IsDBNull(reader["MaLoaiHocPhan"]))?(byte)0:(System.Byte)reader["MaLoaiHocPhan"];
			entity.LoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("LoaiHocPhan")) ? null : (System.String)reader["LoaiHocPhan"];
			//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
			entity.Nam = reader.IsDBNull(reader.GetOrdinal("Nam")) ? null : (System.Int32?)reader["Nam"];
			//entity.Nam = (Convert.IsDBNull(reader["Nam"]))?(int)0:(System.Int32?)reader["Nam"];
			entity.Tuan = reader.IsDBNull(reader.GetOrdinal("Tuan")) ? null : (System.Int32?)reader["Tuan"];
			//entity.Tuan = (Convert.IsDBNull(reader["Tuan"]))?(int)0:(System.Int32?)reader["Tuan"];
			entity.MaPhong = reader.IsDBNull(reader.GetOrdinal("MaPhong")) ? null : (System.String)reader["MaPhong"];
			//entity.MaPhong = (Convert.IsDBNull(reader["MaPhong"]))?string.Empty:(System.String)reader["MaPhong"];
			entity.MaToaNha = reader.IsDBNull(reader.GetOrdinal("MaToaNha")) ? null : (System.String)reader["MaToaNha"];
			//entity.MaToaNha = (Convert.IsDBNull(reader["MaToaNha"]))?string.Empty:(System.String)reader["MaToaNha"];
			entity.DonViTinh = reader.IsDBNull(reader.GetOrdinal("DonViTinh")) ? null : (System.String)reader["DonViTinh"];
			//entity.DonViTinh = (Convert.IsDBNull(reader["DonViTinh"]))?string.Empty:(System.String)reader["DonViTinh"];
			entity.MaCoSo = (System.String)reader["MaCoSo"];
			//entity.MaCoSo = (Convert.IsDBNull(reader["MaCoSo"]))?string.Empty:(System.String)reader["MaCoSo"];
			entity.MaBuoiHoc = reader.IsDBNull(reader.GetOrdinal("MaBuoiHoc")) ? null : (System.Int32?)reader["MaBuoiHoc"];
			//entity.MaBuoiHoc = (Convert.IsDBNull(reader["MaBuoiHoc"]))?(int)0:(System.Int32?)reader["MaBuoiHoc"];
			entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.TietBatDau = reader.IsDBNull(reader.GetOrdinal("TietBatDau")) ? null : (System.Int32?)reader["TietBatDau"];
			//entity.TietBatDau = (Convert.IsDBNull(reader["TietBatDau"]))?(int)0:(System.Int32?)reader["TietBatDau"];
			entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Int32?)reader["SoTiet"];
			//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
			entity.LoaiHocKy = reader.IsDBNull(reader.GetOrdinal("LoaiHocKy")) ? null : (System.Byte?)reader["LoaiHocKy"];
			//entity.LoaiHocKy = (Convert.IsDBNull(reader["LoaiHocKy"]))?(byte)0:(System.Byte?)reader["LoaiHocKy"];
			entity.HeSoCoSo = (System.Decimal)reader["HeSoCoSo"];
			//entity.HeSoCoSo = (Convert.IsDBNull(reader["HeSoCoSo"]))?0.0m:(System.Decimal)reader["HeSoCoSo"];
			entity.HeSoHocKy = (System.Decimal)reader["HeSoHocKy"];
			//entity.HeSoHocKy = (Convert.IsDBNull(reader["HeSoHocKy"]))?0.0m:(System.Decimal)reader["HeSoHocKy"];
			entity.TinhTrang = (System.Int32)reader["TinhTrang"];
			//entity.TinhTrang = (Convert.IsDBNull(reader["TinhTrang"]))?(int)0:(System.Int32)reader["TinhTrang"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewChiTietHocPhan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewChiTietHocPhan"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewChiTietHocPhan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLichHoc = (Convert.IsDBNull(dataRow["MaLichHoc"]))?(int)0:(System.Int32)dataRow["MaLichHoc"];
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?string.Empty:(System.String)dataRow["MaGiangVien"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.SoTinChi = (Convert.IsDBNull(dataRow["SoTinChi"]))?0.0m:(System.Decimal?)dataRow["SoTinChi"];
			entity.SoLuong = (Convert.IsDBNull(dataRow["SoLuong"]))?(int)0:(System.Int32?)dataRow["SoLuong"];
			entity.MaLoaiHocPhan = (Convert.IsDBNull(dataRow["MaLoaiHocPhan"]))?(byte)0:(System.Byte)dataRow["MaLoaiHocPhan"];
			entity.LoaiHocPhan = (Convert.IsDBNull(dataRow["LoaiHocPhan"]))?string.Empty:(System.String)dataRow["LoaiHocPhan"];
			entity.Nam = (Convert.IsDBNull(dataRow["Nam"]))?(int)0:(System.Int32?)dataRow["Nam"];
			entity.Tuan = (Convert.IsDBNull(dataRow["Tuan"]))?(int)0:(System.Int32?)dataRow["Tuan"];
			entity.MaPhong = (Convert.IsDBNull(dataRow["MaPhong"]))?string.Empty:(System.String)dataRow["MaPhong"];
			entity.MaToaNha = (Convert.IsDBNull(dataRow["MaToaNha"]))?string.Empty:(System.String)dataRow["MaToaNha"];
			entity.DonViTinh = (Convert.IsDBNull(dataRow["DonViTinh"]))?string.Empty:(System.String)dataRow["DonViTinh"];
			entity.MaCoSo = (Convert.IsDBNull(dataRow["MaCoSo"]))?string.Empty:(System.String)dataRow["MaCoSo"];
			entity.MaBuoiHoc = (Convert.IsDBNull(dataRow["MaBuoiHoc"]))?(int)0:(System.Int32?)dataRow["MaBuoiHoc"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.TietBatDau = (Convert.IsDBNull(dataRow["TietBatDau"]))?(int)0:(System.Int32?)dataRow["TietBatDau"];
			entity.SoTiet = (Convert.IsDBNull(dataRow["SoTiet"]))?(int)0:(System.Int32?)dataRow["SoTiet"];
			entity.LoaiHocKy = (Convert.IsDBNull(dataRow["LoaiHocKy"]))?(byte)0:(System.Byte?)dataRow["LoaiHocKy"];
			entity.HeSoCoSo = (Convert.IsDBNull(dataRow["HeSoCoSo"]))?0.0m:(System.Decimal)dataRow["HeSoCoSo"];
			entity.HeSoHocKy = (Convert.IsDBNull(dataRow["HeSoHocKy"]))?0.0m:(System.Decimal)dataRow["HeSoHocKy"];
			entity.TinhTrang = (Convert.IsDBNull(dataRow["TinhTrang"]))?(int)0:(System.Int32)dataRow["TinhTrang"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewChiTietHocPhanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietHocPhanFilterBuilder : SqlFilterBuilder<ViewChiTietHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietHocPhanFilterBuilder class.
		/// </summary>
		public ViewChiTietHocPhanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewChiTietHocPhanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewChiTietHocPhanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewChiTietHocPhanFilterBuilder

	#region ViewChiTietHocPhanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietHocPhanParameterBuilder : ParameterizedSqlFilterBuilder<ViewChiTietHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietHocPhanParameterBuilder class.
		/// </summary>
		public ViewChiTietHocPhanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewChiTietHocPhanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewChiTietHocPhanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewChiTietHocPhanParameterBuilder
	
	#region ViewChiTietHocPhanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietHocPhan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewChiTietHocPhanSortBuilder : SqlSortBuilder<ViewChiTietHocPhanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietHocPhanSqlSortBuilder class.
		/// </summary>
		public ViewChiTietHocPhanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewChiTietHocPhanSortBuilder

} // end namespace