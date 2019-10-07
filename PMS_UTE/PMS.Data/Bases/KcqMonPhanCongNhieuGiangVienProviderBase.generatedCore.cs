﻿#region Using directives

using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;

using PMS.Entities;
using PMS.Data;

#endregion

namespace PMS.Data.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="KcqMonPhanCongNhieuGiangVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KcqMonPhanCongNhieuGiangVienProviderBaseCore : EntityProviderBase<PMS.Entities.KcqMonPhanCongNhieuGiangVien, PMS.Entities.KcqMonPhanCongNhieuGiangVienKey>
	{		
		#region Get from Many To Many Relationship Functions
		#endregion	
		
		#region Delete Methods

		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to delete.</param>
		/// <returns>Returns true if operation suceeded.</returns>
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KcqMonPhanCongNhieuGiangVienKey key)
		{
			return Delete(transactionManager, key.Id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _id)
		{
			return Delete(null, _id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _id);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
		#endregion

		#region Get By Index Functions
		
		/// <summary>
		/// 	Gets a row from the DataSource based on its primary key.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to retrieve.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <returns>Returns an instance of the Entity class.</returns>
		public override PMS.Entities.KcqMonPhanCongNhieuGiangVien Get(TransactionManager transactionManager, PMS.Entities.KcqMonPhanCongNhieuGiangVienKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KcqMonPhanCongNhieuGiangVien index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqMonPhanCongNhieuGiangVien"/> class.</returns>
		public PMS.Entities.KcqMonPhanCongNhieuGiangVien GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqMonPhanCongNhieuGiangVien index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqMonPhanCongNhieuGiangVien"/> class.</returns>
		public PMS.Entities.KcqMonPhanCongNhieuGiangVien GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqMonPhanCongNhieuGiangVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqMonPhanCongNhieuGiangVien"/> class.</returns>
		public PMS.Entities.KcqMonPhanCongNhieuGiangVien GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqMonPhanCongNhieuGiangVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqMonPhanCongNhieuGiangVien"/> class.</returns>
		public PMS.Entities.KcqMonPhanCongNhieuGiangVien GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqMonPhanCongNhieuGiangVien index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqMonPhanCongNhieuGiangVien"/> class.</returns>
		public PMS.Entities.KcqMonPhanCongNhieuGiangVien GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqMonPhanCongNhieuGiangVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqMonPhanCongNhieuGiangVien"/> class.</returns>
		public abstract PMS.Entities.KcqMonPhanCongNhieuGiangVien GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KcqMonPhanCongNhieuGiangVien_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KcqMonPhanCongNhieuGiangVien_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqMonPhanCongNhieuGiangVien&gt;"/> instance.</returns>
		public TList<KcqMonPhanCongNhieuGiangVien> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqMonPhanCongNhieuGiangVien_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqMonPhanCongNhieuGiangVien&gt;"/> instance.</returns>
		public TList<KcqMonPhanCongNhieuGiangVien> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqMonPhanCongNhieuGiangVien_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqMonPhanCongNhieuGiangVien&gt;"/> instance.</returns>
		public TList<KcqMonPhanCongNhieuGiangVien> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqMonPhanCongNhieuGiangVien_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqMonPhanCongNhieuGiangVien&gt;"/> instance.</returns>
		public abstract TList<KcqMonPhanCongNhieuGiangVien> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KcqMonPhanCongNhieuGiangVien&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KcqMonPhanCongNhieuGiangVien&gt;"/></returns>
		public static TList<KcqMonPhanCongNhieuGiangVien> Fill(IDataReader reader, TList<KcqMonPhanCongNhieuGiangVien> rows, int start, int pageLength)
		{
			NetTiersProvider currentProvider = DataRepository.Provider;
            bool useEntityFactory = currentProvider.UseEntityFactory;
            bool enableEntityTracking = currentProvider.EnableEntityTracking;
            LoadPolicy currentLoadPolicy = currentProvider.CurrentLoadPolicy;
			Type entityCreationFactoryType = currentProvider.EntityCreationalFactoryType;
			
			// advance to the starting row
			for (int i = 0; i < start; i++)
			{
				if (!reader.Read())
				return rows; // not enough rows, just return
			}
			for (int i = 0; i < pageLength; i++)
			{
				if (!reader.Read())
					break; // we are done
					
				string key = null;
				
				PMS.Entities.KcqMonPhanCongNhieuGiangVien c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KcqMonPhanCongNhieuGiangVien")
					.Append("|").Append((System.Int32)reader[((int)KcqMonPhanCongNhieuGiangVienColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KcqMonPhanCongNhieuGiangVien>(
					key.ToString(), // EntityTrackingKey
					"KcqMonPhanCongNhieuGiangVien",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KcqMonPhanCongNhieuGiangVien();
				}
				
				if (!enableEntityTracking ||
					c.EntityState == EntityState.Added ||
					(enableEntityTracking &&
					
						(
							(currentLoadPolicy == LoadPolicy.PreserveChanges && c.EntityState == EntityState.Unchanged) ||
							(currentLoadPolicy == LoadPolicy.DiscardChanges && c.EntityState != EntityState.Unchanged)
						)
					))
				{
					c.SuppressEntityEvents = true;
					c.Id = (System.Int32)reader[(KcqMonPhanCongNhieuGiangVienColumn.Id.ToString())];
					c.MaMonHoc = (reader[KcqMonPhanCongNhieuGiangVienColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonPhanCongNhieuGiangVienColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (reader[KcqMonPhanCongNhieuGiangVienColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonPhanCongNhieuGiangVienColumn.TenMonHoc.ToString())];
					c.NhomMonHoc = (reader[KcqMonPhanCongNhieuGiangVienColumn.NhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonPhanCongNhieuGiangVienColumn.NhomMonHoc.ToString())];
					c.MaHocPhan = (reader[KcqMonPhanCongNhieuGiangVienColumn.MaHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonPhanCongNhieuGiangVienColumn.MaHocPhan.ToString())];
					c.NamHoc = (reader[KcqMonPhanCongNhieuGiangVienColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonPhanCongNhieuGiangVienColumn.NamHoc.ToString())];
					c.HocKy = (reader[KcqMonPhanCongNhieuGiangVienColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonPhanCongNhieuGiangVienColumn.HocKy.ToString())];
					c.MaLopHocPhan = (reader[KcqMonPhanCongNhieuGiangVienColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonPhanCongNhieuGiangVienColumn.MaLopHocPhan.ToString())];
					c.MaLop = (reader[KcqMonPhanCongNhieuGiangVienColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonPhanCongNhieuGiangVienColumn.MaLop.ToString())];
					c.MaGiangVienQuanLy = (reader[KcqMonPhanCongNhieuGiangVienColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonPhanCongNhieuGiangVienColumn.MaGiangVienQuanLy.ToString())];
					c.SoTinChi = (reader[KcqMonPhanCongNhieuGiangVienColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqMonPhanCongNhieuGiangVienColumn.SoTinChi.ToString())];
					c.SiSo = (reader[KcqMonPhanCongNhieuGiangVienColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqMonPhanCongNhieuGiangVienColumn.SiSo.ToString())];
					c.LopClc = (reader[KcqMonPhanCongNhieuGiangVienColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KcqMonPhanCongNhieuGiangVienColumn.LopClc.ToString())];
					c.SoTietDayChuNhat = (reader[KcqMonPhanCongNhieuGiangVienColumn.SoTietDayChuNhat.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqMonPhanCongNhieuGiangVienColumn.SoTietDayChuNhat.ToString())];
					c.SoTiet = (reader[KcqMonPhanCongNhieuGiangVienColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqMonPhanCongNhieuGiangVienColumn.SoTiet.ToString())];
					c.MaLoaiHocPhan = (reader[KcqMonPhanCongNhieuGiangVienColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqMonPhanCongNhieuGiangVienColumn.MaLoaiHocPhan.ToString())];
					c.MaLoaiGiangVien = (reader[KcqMonPhanCongNhieuGiangVienColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqMonPhanCongNhieuGiangVienColumn.MaLoaiGiangVien.ToString())];
					c.MaHocHam = (reader[KcqMonPhanCongNhieuGiangVienColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqMonPhanCongNhieuGiangVienColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[KcqMonPhanCongNhieuGiangVienColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqMonPhanCongNhieuGiangVienColumn.MaHocVi.ToString())];
					c.Nhom = (reader[KcqMonPhanCongNhieuGiangVienColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonPhanCongNhieuGiangVienColumn.Nhom.ToString())];
					c.NgayCapNhat = (reader[KcqMonPhanCongNhieuGiangVienColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqMonPhanCongNhieuGiangVienColumn.NgayCapNhat.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqMonPhanCongNhieuGiangVien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqMonPhanCongNhieuGiangVien"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KcqMonPhanCongNhieuGiangVien entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(KcqMonPhanCongNhieuGiangVienColumn.Id.ToString())];
			entity.MaMonHoc = (reader[KcqMonPhanCongNhieuGiangVienColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonPhanCongNhieuGiangVienColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (reader[KcqMonPhanCongNhieuGiangVienColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonPhanCongNhieuGiangVienColumn.TenMonHoc.ToString())];
			entity.NhomMonHoc = (reader[KcqMonPhanCongNhieuGiangVienColumn.NhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonPhanCongNhieuGiangVienColumn.NhomMonHoc.ToString())];
			entity.MaHocPhan = (reader[KcqMonPhanCongNhieuGiangVienColumn.MaHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonPhanCongNhieuGiangVienColumn.MaHocPhan.ToString())];
			entity.NamHoc = (reader[KcqMonPhanCongNhieuGiangVienColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonPhanCongNhieuGiangVienColumn.NamHoc.ToString())];
			entity.HocKy = (reader[KcqMonPhanCongNhieuGiangVienColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonPhanCongNhieuGiangVienColumn.HocKy.ToString())];
			entity.MaLopHocPhan = (reader[KcqMonPhanCongNhieuGiangVienColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonPhanCongNhieuGiangVienColumn.MaLopHocPhan.ToString())];
			entity.MaLop = (reader[KcqMonPhanCongNhieuGiangVienColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonPhanCongNhieuGiangVienColumn.MaLop.ToString())];
			entity.MaGiangVienQuanLy = (reader[KcqMonPhanCongNhieuGiangVienColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonPhanCongNhieuGiangVienColumn.MaGiangVienQuanLy.ToString())];
			entity.SoTinChi = (reader[KcqMonPhanCongNhieuGiangVienColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqMonPhanCongNhieuGiangVienColumn.SoTinChi.ToString())];
			entity.SiSo = (reader[KcqMonPhanCongNhieuGiangVienColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqMonPhanCongNhieuGiangVienColumn.SiSo.ToString())];
			entity.LopClc = (reader[KcqMonPhanCongNhieuGiangVienColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KcqMonPhanCongNhieuGiangVienColumn.LopClc.ToString())];
			entity.SoTietDayChuNhat = (reader[KcqMonPhanCongNhieuGiangVienColumn.SoTietDayChuNhat.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqMonPhanCongNhieuGiangVienColumn.SoTietDayChuNhat.ToString())];
			entity.SoTiet = (reader[KcqMonPhanCongNhieuGiangVienColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqMonPhanCongNhieuGiangVienColumn.SoTiet.ToString())];
			entity.MaLoaiHocPhan = (reader[KcqMonPhanCongNhieuGiangVienColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqMonPhanCongNhieuGiangVienColumn.MaLoaiHocPhan.ToString())];
			entity.MaLoaiGiangVien = (reader[KcqMonPhanCongNhieuGiangVienColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqMonPhanCongNhieuGiangVienColumn.MaLoaiGiangVien.ToString())];
			entity.MaHocHam = (reader[KcqMonPhanCongNhieuGiangVienColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqMonPhanCongNhieuGiangVienColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[KcqMonPhanCongNhieuGiangVienColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqMonPhanCongNhieuGiangVienColumn.MaHocVi.ToString())];
			entity.Nhom = (reader[KcqMonPhanCongNhieuGiangVienColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonPhanCongNhieuGiangVienColumn.Nhom.ToString())];
			entity.NgayCapNhat = (reader[KcqMonPhanCongNhieuGiangVienColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqMonPhanCongNhieuGiangVienColumn.NgayCapNhat.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqMonPhanCongNhieuGiangVien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqMonPhanCongNhieuGiangVien"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KcqMonPhanCongNhieuGiangVien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = Convert.IsDBNull(dataRow["TenMonHoc"]) ? null : (System.String)dataRow["TenMonHoc"];
			entity.NhomMonHoc = Convert.IsDBNull(dataRow["NhomMonHoc"]) ? null : (System.String)dataRow["NhomMonHoc"];
			entity.MaHocPhan = Convert.IsDBNull(dataRow["MaHocPhan"]) ? null : (System.String)dataRow["MaHocPhan"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.MaGiangVienQuanLy = Convert.IsDBNull(dataRow["MaGiangVienQuanLy"]) ? null : (System.String)dataRow["MaGiangVienQuanLy"];
			entity.SoTinChi = Convert.IsDBNull(dataRow["SoTinChi"]) ? null : (System.Int32?)dataRow["SoTinChi"];
			entity.SiSo = Convert.IsDBNull(dataRow["SiSo"]) ? null : (System.Int32?)dataRow["SiSo"];
			entity.LopClc = Convert.IsDBNull(dataRow["LopClc"]) ? null : (System.Boolean?)dataRow["LopClc"];
			entity.SoTietDayChuNhat = Convert.IsDBNull(dataRow["SoTietDayChuNhat"]) ? null : (System.Int32?)dataRow["SoTietDayChuNhat"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Int32?)dataRow["SoTiet"];
			entity.MaLoaiHocPhan = Convert.IsDBNull(dataRow["MaLoaiHocPhan"]) ? null : (System.Int32?)dataRow["MaLoaiHocPhan"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.Nhom = Convert.IsDBNull(dataRow["Nhom"]) ? null : (System.String)dataRow["Nhom"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.AcceptChanges();
		}
		#endregion 
		
		#region DeepLoad Methods
		/// <summary>
		/// Deep Loads the <see cref="IEntity"/> object with criteria based of the child 
		/// property collections only N Levels Deep based on the <see cref="DeepLoadType"/>.
		/// </summary>
		/// <remarks>
		/// Use this method with caution as it is possible to DeepLoad with Recursion and traverse an entire object graph.
		/// </remarks>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqMonPhanCongNhieuGiangVien"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KcqMonPhanCongNhieuGiangVien Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KcqMonPhanCongNhieuGiangVien entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			
			//Fire all DeepLoad Items
			foreach(KeyValuePair<Delegate, object> pair in deepHandles.Values)
		    {
                pair.Key.DynamicInvoke((object[])pair.Value);
		    }
			deepHandles = null;
		}
		
		#endregion 
		
		#region DeepSave Methods

		/// <summary>
		/// Deep Save the entire object graph of the PMS.Entities.KcqMonPhanCongNhieuGiangVien object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KcqMonPhanCongNhieuGiangVien instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KcqMonPhanCongNhieuGiangVien Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KcqMonPhanCongNhieuGiangVien entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			//Fire all DeepSave Items
			foreach(KeyValuePair<Delegate, object> pair in deepHandles.Values)
		    {
                pair.Key.DynamicInvoke((object[])pair.Value);
		    }
			
			// Save Root Entity through Provider, if not already saved in delete mode
			if (entity.IsDeleted)
				this.Save(transactionManager, entity);
				

			deepHandles = null;
						
			return true;
		}
		#endregion
	} // end class
	
	#region KcqMonPhanCongNhieuGiangVienChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KcqMonPhanCongNhieuGiangVien</c>
	///</summary>
	public enum KcqMonPhanCongNhieuGiangVienChildEntityTypes
	{
	}
	
	#endregion KcqMonPhanCongNhieuGiangVienChildEntityTypes
	
	#region KcqMonPhanCongNhieuGiangVienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KcqMonPhanCongNhieuGiangVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqMonPhanCongNhieuGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqMonPhanCongNhieuGiangVienFilterBuilder : SqlFilterBuilder<KcqMonPhanCongNhieuGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqMonPhanCongNhieuGiangVienFilterBuilder class.
		/// </summary>
		public KcqMonPhanCongNhieuGiangVienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqMonPhanCongNhieuGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqMonPhanCongNhieuGiangVienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqMonPhanCongNhieuGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqMonPhanCongNhieuGiangVienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqMonPhanCongNhieuGiangVienFilterBuilder
	
	#region KcqMonPhanCongNhieuGiangVienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KcqMonPhanCongNhieuGiangVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqMonPhanCongNhieuGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqMonPhanCongNhieuGiangVienParameterBuilder : ParameterizedSqlFilterBuilder<KcqMonPhanCongNhieuGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqMonPhanCongNhieuGiangVienParameterBuilder class.
		/// </summary>
		public KcqMonPhanCongNhieuGiangVienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqMonPhanCongNhieuGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqMonPhanCongNhieuGiangVienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqMonPhanCongNhieuGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqMonPhanCongNhieuGiangVienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqMonPhanCongNhieuGiangVienParameterBuilder
	
	#region KcqMonPhanCongNhieuGiangVienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KcqMonPhanCongNhieuGiangVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqMonPhanCongNhieuGiangVien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KcqMonPhanCongNhieuGiangVienSortBuilder : SqlSortBuilder<KcqMonPhanCongNhieuGiangVienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqMonPhanCongNhieuGiangVienSqlSortBuilder class.
		/// </summary>
		public KcqMonPhanCongNhieuGiangVienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KcqMonPhanCongNhieuGiangVienSortBuilder
	
} // end namespace