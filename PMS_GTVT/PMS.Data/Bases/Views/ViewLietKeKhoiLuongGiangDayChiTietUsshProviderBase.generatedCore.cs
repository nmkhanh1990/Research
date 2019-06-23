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
	/// This class is the base class for any <see cref="ViewLietKeKhoiLuongGiangDayChiTietUsshProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewLietKeKhoiLuongGiangDayChiTietUsshProviderBaseCore : EntityViewProviderBase<ViewLietKeKhoiLuongGiangDayChiTietUssh>
	{
		#region Custom Methods
		
		
		#region cust_View_LietKeKhoiLuongGiangDayChiTiet_USSH_GetByBacLoaiHinhNamHocHocKyDot
		
		/// <summary>
		///	This method wrap the 'cust_View_LietKeKhoiLuongGiangDayChiTiet_USSH_GetByBacLoaiHinhNamHocHocKyDot' stored procedure. 
		/// </summary>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByBacLoaiHinhNamHocHocKyDot(System.String bacDaoTao, System.String loaiHinhDaoTao, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio)
		{
			return GetByBacLoaiHinhNamHocHocKyDot(null, 0, int.MaxValue , bacDaoTao, loaiHinhDaoTao, namHoc, hocKy, maCauHinhChotGio);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_LietKeKhoiLuongGiangDayChiTiet_USSH_GetByBacLoaiHinhNamHocHocKyDot' stored procedure. 
		/// </summary>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByBacLoaiHinhNamHocHocKyDot(int start, int pageLength, System.String bacDaoTao, System.String loaiHinhDaoTao, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio)
		{
			return GetByBacLoaiHinhNamHocHocKyDot(null, start, pageLength , bacDaoTao, loaiHinhDaoTao, namHoc, hocKy, maCauHinhChotGio);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_LietKeKhoiLuongGiangDayChiTiet_USSH_GetByBacLoaiHinhNamHocHocKyDot' stored procedure. 
		/// </summary>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByBacLoaiHinhNamHocHocKyDot(TransactionManager transactionManager, System.String bacDaoTao, System.String loaiHinhDaoTao, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio)
		{
			return GetByBacLoaiHinhNamHocHocKyDot(transactionManager, 0, int.MaxValue , bacDaoTao, loaiHinhDaoTao, namHoc, hocKy, maCauHinhChotGio);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_LietKeKhoiLuongGiangDayChiTiet_USSH_GetByBacLoaiHinhNamHocHocKyDot' stored procedure. 
		/// </summary>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByBacLoaiHinhNamHocHocKyDot(TransactionManager transactionManager, int start, int pageLength, System.String bacDaoTao, System.String loaiHinhDaoTao, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio);
		
		#endregion

		
		#region cust_View_LietKeKhoiLuongGiangDayChiTiet_USSH_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_LietKeKhoiLuongGiangDayChiTiet_USSH_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="where"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy(System.String namHoc, System.String hocKy, System.String maDonVi, System.String where)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, where);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_LietKeKhoiLuongGiangDayChiTiet_USSH_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="where"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, System.String where)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy, maDonVi, where);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_LietKeKhoiLuongGiangDayChiTiet_USSH_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="where"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, System.String where)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, where);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_LietKeKhoiLuongGiangDayChiTiet_USSH_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="where"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, System.String where);
		
		#endregion

		
		#region cust_View_LietKeKhoiLuongGiangDayChiTiet_USSH_GetByNamHocHocKyCauHinhChotGio
		
		/// <summary>
		///	This method wrap the 'cust_View_LietKeKhoiLuongGiangDayChiTiet_USSH_GetByNamHocHocKyCauHinhChotGio' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyCauHinhChotGio(System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio)
		{
			return GetByNamHocHocKyCauHinhChotGio(null, 0, int.MaxValue , namHoc, hocKy, maCauHinhChotGio);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_LietKeKhoiLuongGiangDayChiTiet_USSH_GetByNamHocHocKyCauHinhChotGio' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyCauHinhChotGio(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio)
		{
			return GetByNamHocHocKyCauHinhChotGio(null, start, pageLength , namHoc, hocKy, maCauHinhChotGio);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_LietKeKhoiLuongGiangDayChiTiet_USSH_GetByNamHocHocKyCauHinhChotGio' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyCauHinhChotGio(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio)
		{
			return GetByNamHocHocKyCauHinhChotGio(transactionManager, 0, int.MaxValue , namHoc, hocKy, maCauHinhChotGio);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_LietKeKhoiLuongGiangDayChiTiet_USSH_GetByNamHocHocKyCauHinhChotGio' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyCauHinhChotGio(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio);
		
		#endregion

		
		#region cust_View_LietKeKhoiLuongGiangDayChiTiet_USSH_GetByNamHocHocKyKhoaDonVi
		
		/// <summary>
		///	This method wrap the 'cust_View_LietKeKhoiLuongGiangDayChiTiet_USSH_GetByNamHocHocKyKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyKhoaDonVi(System.String namHoc, System.String hocKy, System.String khoaDonVi)
		{
			return GetByNamHocHocKyKhoaDonVi(null, 0, int.MaxValue , namHoc, hocKy, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_LietKeKhoiLuongGiangDayChiTiet_USSH_GetByNamHocHocKyKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyKhoaDonVi(int start, int pageLength, System.String namHoc, System.String hocKy, System.String khoaDonVi)
		{
			return GetByNamHocHocKyKhoaDonVi(null, start, pageLength , namHoc, hocKy, khoaDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_LietKeKhoiLuongGiangDayChiTiet_USSH_GetByNamHocHocKyKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyKhoaDonVi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String khoaDonVi)
		{
			return GetByNamHocHocKyKhoaDonVi(transactionManager, 0, int.MaxValue , namHoc, hocKy, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_LietKeKhoiLuongGiangDayChiTiet_USSH_GetByNamHocHocKyKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyKhoaDonVi(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.String khoaDonVi);
		
		#endregion

		
		#region cust_View_LietKeKhoiLuongGiangDayChiTiet_USSH_GetByNamHocHocKyCauHinhChotGioKhoaDonVi
		
		/// <summary>
		///	This method wrap the 'cust_View_LietKeKhoiLuongGiangDayChiTiet_USSH_GetByNamHocHocKyCauHinhChotGioKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyCauHinhChotGioKhoaDonVi(System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio, System.String khoaDonVi)
		{
			return GetByNamHocHocKyCauHinhChotGioKhoaDonVi(null, 0, int.MaxValue , namHoc, hocKy, maCauHinhChotGio, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_LietKeKhoiLuongGiangDayChiTiet_USSH_GetByNamHocHocKyCauHinhChotGioKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyCauHinhChotGioKhoaDonVi(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio, System.String khoaDonVi)
		{
			return GetByNamHocHocKyCauHinhChotGioKhoaDonVi(null, start, pageLength , namHoc, hocKy, maCauHinhChotGio, khoaDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_LietKeKhoiLuongGiangDayChiTiet_USSH_GetByNamHocHocKyCauHinhChotGioKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyCauHinhChotGioKhoaDonVi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio, System.String khoaDonVi)
		{
			return GetByNamHocHocKyCauHinhChotGioKhoaDonVi(transactionManager, 0, int.MaxValue , namHoc, hocKy, maCauHinhChotGio, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_LietKeKhoiLuongGiangDayChiTiet_USSH_GetByNamHocHocKyCauHinhChotGioKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyCauHinhChotGioKhoaDonVi(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio, System.String khoaDonVi);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewLietKeKhoiLuongGiangDayChiTietUssh&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewLietKeKhoiLuongGiangDayChiTietUssh&gt;"/></returns>
		protected static VList&lt;ViewLietKeKhoiLuongGiangDayChiTietUssh&gt; Fill(DataSet dataSet, VList<ViewLietKeKhoiLuongGiangDayChiTietUssh> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewLietKeKhoiLuongGiangDayChiTietUssh>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewLietKeKhoiLuongGiangDayChiTietUssh&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewLietKeKhoiLuongGiangDayChiTietUssh>"/></returns>
		protected static VList&lt;ViewLietKeKhoiLuongGiangDayChiTietUssh&gt; Fill(DataTable dataTable, VList<ViewLietKeKhoiLuongGiangDayChiTietUssh> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewLietKeKhoiLuongGiangDayChiTietUssh c = new ViewLietKeKhoiLuongGiangDayChiTietUssh();
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.MaHocHam = (Convert.IsDBNull(row["MaHocHam"]))?(int)0:(System.Int32?)row["MaHocHam"];
					c.MaHocVi = (Convert.IsDBNull(row["MaHocVi"]))?(int)0:(System.Int32?)row["MaHocVi"];
					c.MaLoaiGiangVien = (Convert.IsDBNull(row["MaLoaiGiangVien"]))?(int)0:(System.Int32?)row["MaLoaiGiangVien"];
					c.MaDonVi = (Convert.IsDBNull(row["MaDonVi"]))?string.Empty:(System.String)row["MaDonVi"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.LoaiHocPhan = (Convert.IsDBNull(row["LoaiHocPhan"]))?string.Empty:(System.String)row["LoaiHocPhan"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.Nhom = (Convert.IsDBNull(row["Nhom"]))?string.Empty:(System.String)row["Nhom"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.SiSo = (Convert.IsDBNull(row["SiSo"]))?0.0m:(System.Decimal?)row["SiSo"];
					c.SoTiet = (Convert.IsDBNull(row["SoTiet"]))?0.0m:(System.Decimal?)row["SoTiet"];
					c.TenCoSo = (Convert.IsDBNull(row["TenCoSo"]))?string.Empty:(System.String)row["TenCoSo"];
					c.HeSoLopDong = (Convert.IsDBNull(row["HeSoLopDong"]))?0.0m:(System.Decimal?)row["HeSoLopDong"];
					c.HeSoCoSo = (Convert.IsDBNull(row["HeSoCoSo"]))?0.0m:(System.Decimal?)row["HeSoCoSo"];
					c.HeSoQuyDoiThucHanhSangLyThuyet = (Convert.IsDBNull(row["HeSoQuyDoiThucHanhSangLyThuyet"]))?0.0m:(System.Decimal?)row["HeSoQuyDoiThucHanhSangLyThuyet"];
					c.TietQuyDoi = (Convert.IsDBNull(row["TietQuyDoi"]))?0.0m:(System.Decimal?)row["TietQuyDoi"];
					c.MaHinhThucDaoTao = (Convert.IsDBNull(row["MaHinhThucDaoTao"]))?string.Empty:(System.String)row["MaHinhThucDaoTao"];
					c.HeSoChucDanhChuyenMon = (Convert.IsDBNull(row["HeSoChucDanhChuyenMon"]))?0.0m:(System.Decimal?)row["HeSoChucDanhChuyenMon"];
					c.HeSoClcCntn = (Convert.IsDBNull(row["HeSoClcCntn"]))?0.0m:(System.Decimal?)row["HeSoClcCntn"];
					c.HeSoThinhGiangMonChuyenNganh = (Convert.IsDBNull(row["HeSoThinhGiangMonChuyenNganh"]))?0.0m:(System.Decimal?)row["HeSoThinhGiangMonChuyenNganh"];
					c.MaNhomMonHoc = (Convert.IsDBNull(row["MaNhomMonHoc"]))?string.Empty:(System.String)row["MaNhomMonHoc"];
					c.LoaiLop = (Convert.IsDBNull(row["LoaiLop"]))?string.Empty:(System.String)row["LoaiLop"];
					c.NgonNguGiangDay = (Convert.IsDBNull(row["NgonNguGiangDay"]))?string.Empty:(System.String)row["NgonNguGiangDay"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.MaKhoaHoc = (Convert.IsDBNull(row["MaKhoaHoc"]))?string.Empty:(System.String)row["MaKhoaHoc"];
					c.HeSoTroCap = (Convert.IsDBNull(row["HeSoTroCap"]))?0.0m:(System.Decimal?)row["HeSoTroCap"];
					c.HeSoLuong = (Convert.IsDBNull(row["HeSoLuong"]))?0.0m:(System.Decimal?)row["HeSoLuong"];
					c.HeSoMonMoi = (Convert.IsDBNull(row["HeSoMonMoi"]))?0.0m:(System.Decimal?)row["HeSoMonMoi"];
					c.HeSoNgoaiGio = (Convert.IsDBNull(row["HeSoNgoaiGio"]))?0.0m:(System.Decimal?)row["HeSoNgoaiGio"];
					c.PhanLoai = (Convert.IsDBNull(row["PhanLoai"]))?string.Empty:(System.String)row["PhanLoai"];
					c.HeSoNienCheTinChi = (Convert.IsDBNull(row["HeSoNienCheTinChi"]))?0.0m:(System.Decimal?)row["HeSoNienCheTinChi"];
					c.HeSoNgonNgu = (Convert.IsDBNull(row["HeSoNgonNgu"]))?0.0m:(System.Decimal?)row["HeSoNgonNgu"];
					c.HeSoBacDaoTao = (Convert.IsDBNull(row["HeSoBacDaoTao"]))?0.0m:(System.Decimal?)row["HeSoBacDaoTao"];
					c.MaLoaiHocPhan = (Convert.IsDBNull(row["MaLoaiHocPhan"]))?(byte)0:(System.Byte?)row["MaLoaiHocPhan"];
					c.HeSoKhoiNganh = (Convert.IsDBNull(row["HeSoKhoiNganh"]))?0.0m:(System.Decimal?)row["HeSoKhoiNganh"];
					c.MaBacDaoTao = (Convert.IsDBNull(row["MaBacDaoTao"]))?string.Empty:(System.String)row["MaBacDaoTao"];
					c.MaLoaiHinhDaoTao = (Convert.IsDBNull(row["MaLoaiHinhDaoTao"]))?string.Empty:(System.String)row["MaLoaiHinhDaoTao"];
					c.GhiChu = (Convert.IsDBNull(row["GhiChu"]))?string.Empty:(System.String)row["GhiChu"];
					c.HeSoCongViec = (Convert.IsDBNull(row["HeSoCongViec"]))?0.0m:(System.Decimal?)row["HeSoCongViec"];
					c.SoTietThucTeQuyDoi = (Convert.IsDBNull(row["SoTietThucTeQuyDoi"]))?0.0m:(System.Decimal?)row["SoTietThucTeQuyDoi"];
					c.MaCoSo = (Convert.IsDBNull(row["MaCoSo"]))?string.Empty:(System.String)row["MaCoSo"];
					c.MucThanhToan = (Convert.IsDBNull(row["MucThanhToan"]))?0.0m:(System.Decimal?)row["MucThanhToan"];
					c.MaCauHinhChotGio = (Convert.IsDBNull(row["MaCauHinhChotGio"]))?(int)0:(System.Int32?)row["MaCauHinhChotGio"];
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
		/// Fill an <see cref="VList&lt;ViewLietKeKhoiLuongGiangDayChiTietUssh&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewLietKeKhoiLuongGiangDayChiTietUssh&gt;"/></returns>
		protected VList<ViewLietKeKhoiLuongGiangDayChiTietUssh> Fill(IDataReader reader, VList<ViewLietKeKhoiLuongGiangDayChiTietUssh> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewLietKeKhoiLuongGiangDayChiTietUssh entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewLietKeKhoiLuongGiangDayChiTietUssh>("ViewLietKeKhoiLuongGiangDayChiTietUssh",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewLietKeKhoiLuongGiangDayChiTietUssh();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaQuanLy = (System.String)reader["MaQuanLy"];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.MaHocHam = reader.IsDBNull(reader.GetOrdinal("MaHocHam")) ? null : (System.Int32?)reader["MaHocHam"];
					//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?(int)0:(System.Int32?)reader["MaHocHam"];
					entity.MaHocVi = reader.IsDBNull(reader.GetOrdinal("MaHocVi")) ? null : (System.Int32?)reader["MaHocVi"];
					//entity.MaHocVi = (Convert.IsDBNull(reader["MaHocVi"]))?(int)0:(System.Int32?)reader["MaHocVi"];
					entity.MaLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("MaLoaiGiangVien")) ? null : (System.Int32?)reader["MaLoaiGiangVien"];
					//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
					entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
					//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.LoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("LoaiHocPhan")) ? null : (System.String)reader["LoaiHocPhan"];
					//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
					entity.MaMonHoc = reader.IsDBNull(reader.GetOrdinal("MaMonHoc")) ? null : (System.String)reader["MaMonHoc"];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = reader.IsDBNull(reader.GetOrdinal("TenMonHoc")) ? null : (System.String)reader["TenMonHoc"];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.Nhom = reader.IsDBNull(reader.GetOrdinal("Nhom")) ? null : (System.String)reader["Nhom"];
					//entity.Nhom = (Convert.IsDBNull(reader["Nhom"]))?string.Empty:(System.String)reader["Nhom"];
					entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.SiSo = reader.IsDBNull(reader.GetOrdinal("SiSo")) ? null : (System.Decimal?)reader["SiSo"];
					//entity.SiSo = (Convert.IsDBNull(reader["SiSo"]))?0.0m:(System.Decimal?)reader["SiSo"];
					entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Decimal?)reader["SoTiet"];
					//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?0.0m:(System.Decimal?)reader["SoTiet"];
					entity.TenCoSo = reader.IsDBNull(reader.GetOrdinal("TenCoSo")) ? null : (System.String)reader["TenCoSo"];
					//entity.TenCoSo = (Convert.IsDBNull(reader["TenCoSo"]))?string.Empty:(System.String)reader["TenCoSo"];
					entity.HeSoLopDong = reader.IsDBNull(reader.GetOrdinal("HeSoLopDong")) ? null : (System.Decimal?)reader["HeSoLopDong"];
					//entity.HeSoLopDong = (Convert.IsDBNull(reader["HeSoLopDong"]))?0.0m:(System.Decimal?)reader["HeSoLopDong"];
					entity.HeSoCoSo = reader.IsDBNull(reader.GetOrdinal("HeSoCoSo")) ? null : (System.Decimal?)reader["HeSoCoSo"];
					//entity.HeSoCoSo = (Convert.IsDBNull(reader["HeSoCoSo"]))?0.0m:(System.Decimal?)reader["HeSoCoSo"];
					entity.HeSoQuyDoiThucHanhSangLyThuyet = reader.IsDBNull(reader.GetOrdinal("HeSoQuyDoiThucHanhSangLyThuyet")) ? null : (System.Decimal?)reader["HeSoQuyDoiThucHanhSangLyThuyet"];
					//entity.HeSoQuyDoiThucHanhSangLyThuyet = (Convert.IsDBNull(reader["HeSoQuyDoiThucHanhSangLyThuyet"]))?0.0m:(System.Decimal?)reader["HeSoQuyDoiThucHanhSangLyThuyet"];
					entity.TietQuyDoi = reader.IsDBNull(reader.GetOrdinal("TietQuyDoi")) ? null : (System.Decimal?)reader["TietQuyDoi"];
					//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
					entity.MaHinhThucDaoTao = reader.IsDBNull(reader.GetOrdinal("MaHinhThucDaoTao")) ? null : (System.String)reader["MaHinhThucDaoTao"];
					//entity.MaHinhThucDaoTao = (Convert.IsDBNull(reader["MaHinhThucDaoTao"]))?string.Empty:(System.String)reader["MaHinhThucDaoTao"];
					entity.HeSoChucDanhChuyenMon = reader.IsDBNull(reader.GetOrdinal("HeSoChucDanhChuyenMon")) ? null : (System.Decimal?)reader["HeSoChucDanhChuyenMon"];
					//entity.HeSoChucDanhChuyenMon = (Convert.IsDBNull(reader["HeSoChucDanhChuyenMon"]))?0.0m:(System.Decimal?)reader["HeSoChucDanhChuyenMon"];
					entity.HeSoClcCntn = reader.IsDBNull(reader.GetOrdinal("HeSoClcCntn")) ? null : (System.Decimal?)reader["HeSoClcCntn"];
					//entity.HeSoClcCntn = (Convert.IsDBNull(reader["HeSoClcCntn"]))?0.0m:(System.Decimal?)reader["HeSoClcCntn"];
					entity.HeSoThinhGiangMonChuyenNganh = reader.IsDBNull(reader.GetOrdinal("HeSoThinhGiangMonChuyenNganh")) ? null : (System.Decimal?)reader["HeSoThinhGiangMonChuyenNganh"];
					//entity.HeSoThinhGiangMonChuyenNganh = (Convert.IsDBNull(reader["HeSoThinhGiangMonChuyenNganh"]))?0.0m:(System.Decimal?)reader["HeSoThinhGiangMonChuyenNganh"];
					entity.MaNhomMonHoc = reader.IsDBNull(reader.GetOrdinal("MaNhomMonHoc")) ? null : (System.String)reader["MaNhomMonHoc"];
					//entity.MaNhomMonHoc = (Convert.IsDBNull(reader["MaNhomMonHoc"]))?string.Empty:(System.String)reader["MaNhomMonHoc"];
					entity.LoaiLop = reader.IsDBNull(reader.GetOrdinal("LoaiLop")) ? null : (System.String)reader["LoaiLop"];
					//entity.LoaiLop = (Convert.IsDBNull(reader["LoaiLop"]))?string.Empty:(System.String)reader["LoaiLop"];
					entity.NgonNguGiangDay = reader.IsDBNull(reader.GetOrdinal("NgonNguGiangDay")) ? null : (System.String)reader["NgonNguGiangDay"];
					//entity.NgonNguGiangDay = (Convert.IsDBNull(reader["NgonNguGiangDay"]))?string.Empty:(System.String)reader["NgonNguGiangDay"];
					entity.MaLopHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLopHocPhan")) ? null : (System.String)reader["MaLopHocPhan"];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.MaKhoaHoc = reader.IsDBNull(reader.GetOrdinal("MaKhoaHoc")) ? null : (System.String)reader["MaKhoaHoc"];
					//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
					entity.HeSoTroCap = reader.IsDBNull(reader.GetOrdinal("HeSoTroCap")) ? null : (System.Decimal?)reader["HeSoTroCap"];
					//entity.HeSoTroCap = (Convert.IsDBNull(reader["HeSoTroCap"]))?0.0m:(System.Decimal?)reader["HeSoTroCap"];
					entity.HeSoLuong = reader.IsDBNull(reader.GetOrdinal("HeSoLuong")) ? null : (System.Decimal?)reader["HeSoLuong"];
					//entity.HeSoLuong = (Convert.IsDBNull(reader["HeSoLuong"]))?0.0m:(System.Decimal?)reader["HeSoLuong"];
					entity.HeSoMonMoi = reader.IsDBNull(reader.GetOrdinal("HeSoMonMoi")) ? null : (System.Decimal?)reader["HeSoMonMoi"];
					//entity.HeSoMonMoi = (Convert.IsDBNull(reader["HeSoMonMoi"]))?0.0m:(System.Decimal?)reader["HeSoMonMoi"];
					entity.HeSoNgoaiGio = reader.IsDBNull(reader.GetOrdinal("HeSoNgoaiGio")) ? null : (System.Decimal?)reader["HeSoNgoaiGio"];
					//entity.HeSoNgoaiGio = (Convert.IsDBNull(reader["HeSoNgoaiGio"]))?0.0m:(System.Decimal?)reader["HeSoNgoaiGio"];
					entity.PhanLoai = reader.IsDBNull(reader.GetOrdinal("PhanLoai")) ? null : (System.String)reader["PhanLoai"];
					//entity.PhanLoai = (Convert.IsDBNull(reader["PhanLoai"]))?string.Empty:(System.String)reader["PhanLoai"];
					entity.HeSoNienCheTinChi = reader.IsDBNull(reader.GetOrdinal("HeSoNienCheTinChi")) ? null : (System.Decimal?)reader["HeSoNienCheTinChi"];
					//entity.HeSoNienCheTinChi = (Convert.IsDBNull(reader["HeSoNienCheTinChi"]))?0.0m:(System.Decimal?)reader["HeSoNienCheTinChi"];
					entity.HeSoNgonNgu = reader.IsDBNull(reader.GetOrdinal("HeSoNgonNgu")) ? null : (System.Decimal?)reader["HeSoNgonNgu"];
					//entity.HeSoNgonNgu = (Convert.IsDBNull(reader["HeSoNgonNgu"]))?0.0m:(System.Decimal?)reader["HeSoNgonNgu"];
					entity.HeSoBacDaoTao = reader.IsDBNull(reader.GetOrdinal("HeSoBacDaoTao")) ? null : (System.Decimal?)reader["HeSoBacDaoTao"];
					//entity.HeSoBacDaoTao = (Convert.IsDBNull(reader["HeSoBacDaoTao"]))?0.0m:(System.Decimal?)reader["HeSoBacDaoTao"];
					entity.MaLoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLoaiHocPhan")) ? null : (System.Byte?)reader["MaLoaiHocPhan"];
					//entity.MaLoaiHocPhan = (Convert.IsDBNull(reader["MaLoaiHocPhan"]))?(byte)0:(System.Byte?)reader["MaLoaiHocPhan"];
					entity.HeSoKhoiNganh = reader.IsDBNull(reader.GetOrdinal("HeSoKhoiNganh")) ? null : (System.Decimal?)reader["HeSoKhoiNganh"];
					//entity.HeSoKhoiNganh = (Convert.IsDBNull(reader["HeSoKhoiNganh"]))?0.0m:(System.Decimal?)reader["HeSoKhoiNganh"];
					entity.MaBacDaoTao = reader.IsDBNull(reader.GetOrdinal("MaBacDaoTao")) ? null : (System.String)reader["MaBacDaoTao"];
					//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
					entity.MaLoaiHinhDaoTao = reader.IsDBNull(reader.GetOrdinal("MaLoaiHinhDaoTao")) ? null : (System.String)reader["MaLoaiHinhDaoTao"];
					//entity.MaLoaiHinhDaoTao = (Convert.IsDBNull(reader["MaLoaiHinhDaoTao"]))?string.Empty:(System.String)reader["MaLoaiHinhDaoTao"];
					entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.String)reader["GhiChu"];
					//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?string.Empty:(System.String)reader["GhiChu"];
					entity.HeSoCongViec = reader.IsDBNull(reader.GetOrdinal("HeSoCongViec")) ? null : (System.Decimal?)reader["HeSoCongViec"];
					//entity.HeSoCongViec = (Convert.IsDBNull(reader["HeSoCongViec"]))?0.0m:(System.Decimal?)reader["HeSoCongViec"];
					entity.SoTietThucTeQuyDoi = reader.IsDBNull(reader.GetOrdinal("SoTietThucTeQuyDoi")) ? null : (System.Decimal?)reader["SoTietThucTeQuyDoi"];
					//entity.SoTietThucTeQuyDoi = (Convert.IsDBNull(reader["SoTietThucTeQuyDoi"]))?0.0m:(System.Decimal?)reader["SoTietThucTeQuyDoi"];
					entity.MaCoSo = reader.IsDBNull(reader.GetOrdinal("MaCoSo")) ? null : (System.String)reader["MaCoSo"];
					//entity.MaCoSo = (Convert.IsDBNull(reader["MaCoSo"]))?string.Empty:(System.String)reader["MaCoSo"];
					entity.MucThanhToan = reader.IsDBNull(reader.GetOrdinal("MucThanhToan")) ? null : (System.Decimal?)reader["MucThanhToan"];
					//entity.MucThanhToan = (Convert.IsDBNull(reader["MucThanhToan"]))?0.0m:(System.Decimal?)reader["MucThanhToan"];
					entity.MaCauHinhChotGio = reader.IsDBNull(reader.GetOrdinal("MaCauHinhChotGio")) ? null : (System.Int32?)reader["MaCauHinhChotGio"];
					//entity.MaCauHinhChotGio = (Convert.IsDBNull(reader["MaCauHinhChotGio"]))?(int)0:(System.Int32?)reader["MaCauHinhChotGio"];
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
		/// Refreshes the <see cref="ViewLietKeKhoiLuongGiangDayChiTietUssh"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewLietKeKhoiLuongGiangDayChiTietUssh"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewLietKeKhoiLuongGiangDayChiTietUssh entity)
		{
			reader.Read();
			entity.MaQuanLy = (System.String)reader["MaQuanLy"];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.MaHocHam = reader.IsDBNull(reader.GetOrdinal("MaHocHam")) ? null : (System.Int32?)reader["MaHocHam"];
			//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?(int)0:(System.Int32?)reader["MaHocHam"];
			entity.MaHocVi = reader.IsDBNull(reader.GetOrdinal("MaHocVi")) ? null : (System.Int32?)reader["MaHocVi"];
			//entity.MaHocVi = (Convert.IsDBNull(reader["MaHocVi"]))?(int)0:(System.Int32?)reader["MaHocVi"];
			entity.MaLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("MaLoaiGiangVien")) ? null : (System.Int32?)reader["MaLoaiGiangVien"];
			//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
			entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
			//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.LoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("LoaiHocPhan")) ? null : (System.String)reader["LoaiHocPhan"];
			//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
			entity.MaMonHoc = reader.IsDBNull(reader.GetOrdinal("MaMonHoc")) ? null : (System.String)reader["MaMonHoc"];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = reader.IsDBNull(reader.GetOrdinal("TenMonHoc")) ? null : (System.String)reader["TenMonHoc"];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.Nhom = reader.IsDBNull(reader.GetOrdinal("Nhom")) ? null : (System.String)reader["Nhom"];
			//entity.Nhom = (Convert.IsDBNull(reader["Nhom"]))?string.Empty:(System.String)reader["Nhom"];
			entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.SiSo = reader.IsDBNull(reader.GetOrdinal("SiSo")) ? null : (System.Decimal?)reader["SiSo"];
			//entity.SiSo = (Convert.IsDBNull(reader["SiSo"]))?0.0m:(System.Decimal?)reader["SiSo"];
			entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Decimal?)reader["SoTiet"];
			//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?0.0m:(System.Decimal?)reader["SoTiet"];
			entity.TenCoSo = reader.IsDBNull(reader.GetOrdinal("TenCoSo")) ? null : (System.String)reader["TenCoSo"];
			//entity.TenCoSo = (Convert.IsDBNull(reader["TenCoSo"]))?string.Empty:(System.String)reader["TenCoSo"];
			entity.HeSoLopDong = reader.IsDBNull(reader.GetOrdinal("HeSoLopDong")) ? null : (System.Decimal?)reader["HeSoLopDong"];
			//entity.HeSoLopDong = (Convert.IsDBNull(reader["HeSoLopDong"]))?0.0m:(System.Decimal?)reader["HeSoLopDong"];
			entity.HeSoCoSo = reader.IsDBNull(reader.GetOrdinal("HeSoCoSo")) ? null : (System.Decimal?)reader["HeSoCoSo"];
			//entity.HeSoCoSo = (Convert.IsDBNull(reader["HeSoCoSo"]))?0.0m:(System.Decimal?)reader["HeSoCoSo"];
			entity.HeSoQuyDoiThucHanhSangLyThuyet = reader.IsDBNull(reader.GetOrdinal("HeSoQuyDoiThucHanhSangLyThuyet")) ? null : (System.Decimal?)reader["HeSoQuyDoiThucHanhSangLyThuyet"];
			//entity.HeSoQuyDoiThucHanhSangLyThuyet = (Convert.IsDBNull(reader["HeSoQuyDoiThucHanhSangLyThuyet"]))?0.0m:(System.Decimal?)reader["HeSoQuyDoiThucHanhSangLyThuyet"];
			entity.TietQuyDoi = reader.IsDBNull(reader.GetOrdinal("TietQuyDoi")) ? null : (System.Decimal?)reader["TietQuyDoi"];
			//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
			entity.MaHinhThucDaoTao = reader.IsDBNull(reader.GetOrdinal("MaHinhThucDaoTao")) ? null : (System.String)reader["MaHinhThucDaoTao"];
			//entity.MaHinhThucDaoTao = (Convert.IsDBNull(reader["MaHinhThucDaoTao"]))?string.Empty:(System.String)reader["MaHinhThucDaoTao"];
			entity.HeSoChucDanhChuyenMon = reader.IsDBNull(reader.GetOrdinal("HeSoChucDanhChuyenMon")) ? null : (System.Decimal?)reader["HeSoChucDanhChuyenMon"];
			//entity.HeSoChucDanhChuyenMon = (Convert.IsDBNull(reader["HeSoChucDanhChuyenMon"]))?0.0m:(System.Decimal?)reader["HeSoChucDanhChuyenMon"];
			entity.HeSoClcCntn = reader.IsDBNull(reader.GetOrdinal("HeSoClcCntn")) ? null : (System.Decimal?)reader["HeSoClcCntn"];
			//entity.HeSoClcCntn = (Convert.IsDBNull(reader["HeSoClcCntn"]))?0.0m:(System.Decimal?)reader["HeSoClcCntn"];
			entity.HeSoThinhGiangMonChuyenNganh = reader.IsDBNull(reader.GetOrdinal("HeSoThinhGiangMonChuyenNganh")) ? null : (System.Decimal?)reader["HeSoThinhGiangMonChuyenNganh"];
			//entity.HeSoThinhGiangMonChuyenNganh = (Convert.IsDBNull(reader["HeSoThinhGiangMonChuyenNganh"]))?0.0m:(System.Decimal?)reader["HeSoThinhGiangMonChuyenNganh"];
			entity.MaNhomMonHoc = reader.IsDBNull(reader.GetOrdinal("MaNhomMonHoc")) ? null : (System.String)reader["MaNhomMonHoc"];
			//entity.MaNhomMonHoc = (Convert.IsDBNull(reader["MaNhomMonHoc"]))?string.Empty:(System.String)reader["MaNhomMonHoc"];
			entity.LoaiLop = reader.IsDBNull(reader.GetOrdinal("LoaiLop")) ? null : (System.String)reader["LoaiLop"];
			//entity.LoaiLop = (Convert.IsDBNull(reader["LoaiLop"]))?string.Empty:(System.String)reader["LoaiLop"];
			entity.NgonNguGiangDay = reader.IsDBNull(reader.GetOrdinal("NgonNguGiangDay")) ? null : (System.String)reader["NgonNguGiangDay"];
			//entity.NgonNguGiangDay = (Convert.IsDBNull(reader["NgonNguGiangDay"]))?string.Empty:(System.String)reader["NgonNguGiangDay"];
			entity.MaLopHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLopHocPhan")) ? null : (System.String)reader["MaLopHocPhan"];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.MaKhoaHoc = reader.IsDBNull(reader.GetOrdinal("MaKhoaHoc")) ? null : (System.String)reader["MaKhoaHoc"];
			//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
			entity.HeSoTroCap = reader.IsDBNull(reader.GetOrdinal("HeSoTroCap")) ? null : (System.Decimal?)reader["HeSoTroCap"];
			//entity.HeSoTroCap = (Convert.IsDBNull(reader["HeSoTroCap"]))?0.0m:(System.Decimal?)reader["HeSoTroCap"];
			entity.HeSoLuong = reader.IsDBNull(reader.GetOrdinal("HeSoLuong")) ? null : (System.Decimal?)reader["HeSoLuong"];
			//entity.HeSoLuong = (Convert.IsDBNull(reader["HeSoLuong"]))?0.0m:(System.Decimal?)reader["HeSoLuong"];
			entity.HeSoMonMoi = reader.IsDBNull(reader.GetOrdinal("HeSoMonMoi")) ? null : (System.Decimal?)reader["HeSoMonMoi"];
			//entity.HeSoMonMoi = (Convert.IsDBNull(reader["HeSoMonMoi"]))?0.0m:(System.Decimal?)reader["HeSoMonMoi"];
			entity.HeSoNgoaiGio = reader.IsDBNull(reader.GetOrdinal("HeSoNgoaiGio")) ? null : (System.Decimal?)reader["HeSoNgoaiGio"];
			//entity.HeSoNgoaiGio = (Convert.IsDBNull(reader["HeSoNgoaiGio"]))?0.0m:(System.Decimal?)reader["HeSoNgoaiGio"];
			entity.PhanLoai = reader.IsDBNull(reader.GetOrdinal("PhanLoai")) ? null : (System.String)reader["PhanLoai"];
			//entity.PhanLoai = (Convert.IsDBNull(reader["PhanLoai"]))?string.Empty:(System.String)reader["PhanLoai"];
			entity.HeSoNienCheTinChi = reader.IsDBNull(reader.GetOrdinal("HeSoNienCheTinChi")) ? null : (System.Decimal?)reader["HeSoNienCheTinChi"];
			//entity.HeSoNienCheTinChi = (Convert.IsDBNull(reader["HeSoNienCheTinChi"]))?0.0m:(System.Decimal?)reader["HeSoNienCheTinChi"];
			entity.HeSoNgonNgu = reader.IsDBNull(reader.GetOrdinal("HeSoNgonNgu")) ? null : (System.Decimal?)reader["HeSoNgonNgu"];
			//entity.HeSoNgonNgu = (Convert.IsDBNull(reader["HeSoNgonNgu"]))?0.0m:(System.Decimal?)reader["HeSoNgonNgu"];
			entity.HeSoBacDaoTao = reader.IsDBNull(reader.GetOrdinal("HeSoBacDaoTao")) ? null : (System.Decimal?)reader["HeSoBacDaoTao"];
			//entity.HeSoBacDaoTao = (Convert.IsDBNull(reader["HeSoBacDaoTao"]))?0.0m:(System.Decimal?)reader["HeSoBacDaoTao"];
			entity.MaLoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLoaiHocPhan")) ? null : (System.Byte?)reader["MaLoaiHocPhan"];
			//entity.MaLoaiHocPhan = (Convert.IsDBNull(reader["MaLoaiHocPhan"]))?(byte)0:(System.Byte?)reader["MaLoaiHocPhan"];
			entity.HeSoKhoiNganh = reader.IsDBNull(reader.GetOrdinal("HeSoKhoiNganh")) ? null : (System.Decimal?)reader["HeSoKhoiNganh"];
			//entity.HeSoKhoiNganh = (Convert.IsDBNull(reader["HeSoKhoiNganh"]))?0.0m:(System.Decimal?)reader["HeSoKhoiNganh"];
			entity.MaBacDaoTao = reader.IsDBNull(reader.GetOrdinal("MaBacDaoTao")) ? null : (System.String)reader["MaBacDaoTao"];
			//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
			entity.MaLoaiHinhDaoTao = reader.IsDBNull(reader.GetOrdinal("MaLoaiHinhDaoTao")) ? null : (System.String)reader["MaLoaiHinhDaoTao"];
			//entity.MaLoaiHinhDaoTao = (Convert.IsDBNull(reader["MaLoaiHinhDaoTao"]))?string.Empty:(System.String)reader["MaLoaiHinhDaoTao"];
			entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.String)reader["GhiChu"];
			//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?string.Empty:(System.String)reader["GhiChu"];
			entity.HeSoCongViec = reader.IsDBNull(reader.GetOrdinal("HeSoCongViec")) ? null : (System.Decimal?)reader["HeSoCongViec"];
			//entity.HeSoCongViec = (Convert.IsDBNull(reader["HeSoCongViec"]))?0.0m:(System.Decimal?)reader["HeSoCongViec"];
			entity.SoTietThucTeQuyDoi = reader.IsDBNull(reader.GetOrdinal("SoTietThucTeQuyDoi")) ? null : (System.Decimal?)reader["SoTietThucTeQuyDoi"];
			//entity.SoTietThucTeQuyDoi = (Convert.IsDBNull(reader["SoTietThucTeQuyDoi"]))?0.0m:(System.Decimal?)reader["SoTietThucTeQuyDoi"];
			entity.MaCoSo = reader.IsDBNull(reader.GetOrdinal("MaCoSo")) ? null : (System.String)reader["MaCoSo"];
			//entity.MaCoSo = (Convert.IsDBNull(reader["MaCoSo"]))?string.Empty:(System.String)reader["MaCoSo"];
			entity.MucThanhToan = reader.IsDBNull(reader.GetOrdinal("MucThanhToan")) ? null : (System.Decimal?)reader["MucThanhToan"];
			//entity.MucThanhToan = (Convert.IsDBNull(reader["MucThanhToan"]))?0.0m:(System.Decimal?)reader["MucThanhToan"];
			entity.MaCauHinhChotGio = reader.IsDBNull(reader.GetOrdinal("MaCauHinhChotGio")) ? null : (System.Int32?)reader["MaCauHinhChotGio"];
			//entity.MaCauHinhChotGio = (Convert.IsDBNull(reader["MaCauHinhChotGio"]))?(int)0:(System.Int32?)reader["MaCauHinhChotGio"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewLietKeKhoiLuongGiangDayChiTietUssh"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewLietKeKhoiLuongGiangDayChiTietUssh"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewLietKeKhoiLuongGiangDayChiTietUssh entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.MaHocHam = (Convert.IsDBNull(dataRow["MaHocHam"]))?(int)0:(System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = (Convert.IsDBNull(dataRow["MaHocVi"]))?(int)0:(System.Int32?)dataRow["MaHocVi"];
			entity.MaLoaiGiangVien = (Convert.IsDBNull(dataRow["MaLoaiGiangVien"]))?(int)0:(System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaDonVi = (Convert.IsDBNull(dataRow["MaDonVi"]))?string.Empty:(System.String)dataRow["MaDonVi"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.LoaiHocPhan = (Convert.IsDBNull(dataRow["LoaiHocPhan"]))?string.Empty:(System.String)dataRow["LoaiHocPhan"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.Nhom = (Convert.IsDBNull(dataRow["Nhom"]))?string.Empty:(System.String)dataRow["Nhom"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.SiSo = (Convert.IsDBNull(dataRow["SiSo"]))?0.0m:(System.Decimal?)dataRow["SiSo"];
			entity.SoTiet = (Convert.IsDBNull(dataRow["SoTiet"]))?0.0m:(System.Decimal?)dataRow["SoTiet"];
			entity.TenCoSo = (Convert.IsDBNull(dataRow["TenCoSo"]))?string.Empty:(System.String)dataRow["TenCoSo"];
			entity.HeSoLopDong = (Convert.IsDBNull(dataRow["HeSoLopDong"]))?0.0m:(System.Decimal?)dataRow["HeSoLopDong"];
			entity.HeSoCoSo = (Convert.IsDBNull(dataRow["HeSoCoSo"]))?0.0m:(System.Decimal?)dataRow["HeSoCoSo"];
			entity.HeSoQuyDoiThucHanhSangLyThuyet = (Convert.IsDBNull(dataRow["HeSoQuyDoiThucHanhSangLyThuyet"]))?0.0m:(System.Decimal?)dataRow["HeSoQuyDoiThucHanhSangLyThuyet"];
			entity.TietQuyDoi = (Convert.IsDBNull(dataRow["TietQuyDoi"]))?0.0m:(System.Decimal?)dataRow["TietQuyDoi"];
			entity.MaHinhThucDaoTao = (Convert.IsDBNull(dataRow["MaHinhThucDaoTao"]))?string.Empty:(System.String)dataRow["MaHinhThucDaoTao"];
			entity.HeSoChucDanhChuyenMon = (Convert.IsDBNull(dataRow["HeSoChucDanhChuyenMon"]))?0.0m:(System.Decimal?)dataRow["HeSoChucDanhChuyenMon"];
			entity.HeSoClcCntn = (Convert.IsDBNull(dataRow["HeSoClcCntn"]))?0.0m:(System.Decimal?)dataRow["HeSoClcCntn"];
			entity.HeSoThinhGiangMonChuyenNganh = (Convert.IsDBNull(dataRow["HeSoThinhGiangMonChuyenNganh"]))?0.0m:(System.Decimal?)dataRow["HeSoThinhGiangMonChuyenNganh"];
			entity.MaNhomMonHoc = (Convert.IsDBNull(dataRow["MaNhomMonHoc"]))?string.Empty:(System.String)dataRow["MaNhomMonHoc"];
			entity.LoaiLop = (Convert.IsDBNull(dataRow["LoaiLop"]))?string.Empty:(System.String)dataRow["LoaiLop"];
			entity.NgonNguGiangDay = (Convert.IsDBNull(dataRow["NgonNguGiangDay"]))?string.Empty:(System.String)dataRow["NgonNguGiangDay"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.MaKhoaHoc = (Convert.IsDBNull(dataRow["MaKhoaHoc"]))?string.Empty:(System.String)dataRow["MaKhoaHoc"];
			entity.HeSoTroCap = (Convert.IsDBNull(dataRow["HeSoTroCap"]))?0.0m:(System.Decimal?)dataRow["HeSoTroCap"];
			entity.HeSoLuong = (Convert.IsDBNull(dataRow["HeSoLuong"]))?0.0m:(System.Decimal?)dataRow["HeSoLuong"];
			entity.HeSoMonMoi = (Convert.IsDBNull(dataRow["HeSoMonMoi"]))?0.0m:(System.Decimal?)dataRow["HeSoMonMoi"];
			entity.HeSoNgoaiGio = (Convert.IsDBNull(dataRow["HeSoNgoaiGio"]))?0.0m:(System.Decimal?)dataRow["HeSoNgoaiGio"];
			entity.PhanLoai = (Convert.IsDBNull(dataRow["PhanLoai"]))?string.Empty:(System.String)dataRow["PhanLoai"];
			entity.HeSoNienCheTinChi = (Convert.IsDBNull(dataRow["HeSoNienCheTinChi"]))?0.0m:(System.Decimal?)dataRow["HeSoNienCheTinChi"];
			entity.HeSoNgonNgu = (Convert.IsDBNull(dataRow["HeSoNgonNgu"]))?0.0m:(System.Decimal?)dataRow["HeSoNgonNgu"];
			entity.HeSoBacDaoTao = (Convert.IsDBNull(dataRow["HeSoBacDaoTao"]))?0.0m:(System.Decimal?)dataRow["HeSoBacDaoTao"];
			entity.MaLoaiHocPhan = (Convert.IsDBNull(dataRow["MaLoaiHocPhan"]))?(byte)0:(System.Byte?)dataRow["MaLoaiHocPhan"];
			entity.HeSoKhoiNganh = (Convert.IsDBNull(dataRow["HeSoKhoiNganh"]))?0.0m:(System.Decimal?)dataRow["HeSoKhoiNganh"];
			entity.MaBacDaoTao = (Convert.IsDBNull(dataRow["MaBacDaoTao"]))?string.Empty:(System.String)dataRow["MaBacDaoTao"];
			entity.MaLoaiHinhDaoTao = (Convert.IsDBNull(dataRow["MaLoaiHinhDaoTao"]))?string.Empty:(System.String)dataRow["MaLoaiHinhDaoTao"];
			entity.GhiChu = (Convert.IsDBNull(dataRow["GhiChu"]))?string.Empty:(System.String)dataRow["GhiChu"];
			entity.HeSoCongViec = (Convert.IsDBNull(dataRow["HeSoCongViec"]))?0.0m:(System.Decimal?)dataRow["HeSoCongViec"];
			entity.SoTietThucTeQuyDoi = (Convert.IsDBNull(dataRow["SoTietThucTeQuyDoi"]))?0.0m:(System.Decimal?)dataRow["SoTietThucTeQuyDoi"];
			entity.MaCoSo = (Convert.IsDBNull(dataRow["MaCoSo"]))?string.Empty:(System.String)dataRow["MaCoSo"];
			entity.MucThanhToan = (Convert.IsDBNull(dataRow["MucThanhToan"]))?0.0m:(System.Decimal?)dataRow["MucThanhToan"];
			entity.MaCauHinhChotGio = (Convert.IsDBNull(dataRow["MaCauHinhChotGio"]))?(int)0:(System.Int32?)dataRow["MaCauHinhChotGio"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewLietKeKhoiLuongGiangDayChiTietUsshFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLietKeKhoiLuongGiangDayChiTietUssh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLietKeKhoiLuongGiangDayChiTietUsshFilterBuilder : SqlFilterBuilder<ViewLietKeKhoiLuongGiangDayChiTietUsshColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLietKeKhoiLuongGiangDayChiTietUsshFilterBuilder class.
		/// </summary>
		public ViewLietKeKhoiLuongGiangDayChiTietUsshFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewLietKeKhoiLuongGiangDayChiTietUsshFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewLietKeKhoiLuongGiangDayChiTietUsshFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewLietKeKhoiLuongGiangDayChiTietUsshFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewLietKeKhoiLuongGiangDayChiTietUsshFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewLietKeKhoiLuongGiangDayChiTietUsshFilterBuilder

	#region ViewLietKeKhoiLuongGiangDayChiTietUsshParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLietKeKhoiLuongGiangDayChiTietUssh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLietKeKhoiLuongGiangDayChiTietUsshParameterBuilder : ParameterizedSqlFilterBuilder<ViewLietKeKhoiLuongGiangDayChiTietUsshColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLietKeKhoiLuongGiangDayChiTietUsshParameterBuilder class.
		/// </summary>
		public ViewLietKeKhoiLuongGiangDayChiTietUsshParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewLietKeKhoiLuongGiangDayChiTietUsshParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewLietKeKhoiLuongGiangDayChiTietUsshParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewLietKeKhoiLuongGiangDayChiTietUsshParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewLietKeKhoiLuongGiangDayChiTietUsshParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewLietKeKhoiLuongGiangDayChiTietUsshParameterBuilder
	
	#region ViewLietKeKhoiLuongGiangDayChiTietUsshSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLietKeKhoiLuongGiangDayChiTietUssh"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewLietKeKhoiLuongGiangDayChiTietUsshSortBuilder : SqlSortBuilder<ViewLietKeKhoiLuongGiangDayChiTietUsshColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLietKeKhoiLuongGiangDayChiTietUsshSqlSortBuilder class.
		/// </summary>
		public ViewLietKeKhoiLuongGiangDayChiTietUsshSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewLietKeKhoiLuongGiangDayChiTietUsshSortBuilder

} // end namespace
