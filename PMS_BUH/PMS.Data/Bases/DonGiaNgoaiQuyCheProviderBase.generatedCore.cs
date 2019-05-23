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
	/// This class is the base class for any <see cref="DonGiaNgoaiQuyCheProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class DonGiaNgoaiQuyCheProviderBaseCore : EntityProviderBase<PMS.Entities.DonGiaNgoaiQuyChe, PMS.Entities.DonGiaNgoaiQuyCheKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.DonGiaNgoaiQuyCheKey key)
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
		public override PMS.Entities.DonGiaNgoaiQuyChe Get(TransactionManager transactionManager, PMS.Entities.DonGiaNgoaiQuyCheKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_DonGiaNgoaiQuyChe index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaNgoaiQuyChe"/> class.</returns>
		public PMS.Entities.DonGiaNgoaiQuyChe GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGiaNgoaiQuyChe index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaNgoaiQuyChe"/> class.</returns>
		public PMS.Entities.DonGiaNgoaiQuyChe GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGiaNgoaiQuyChe index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaNgoaiQuyChe"/> class.</returns>
		public PMS.Entities.DonGiaNgoaiQuyChe GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGiaNgoaiQuyChe index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaNgoaiQuyChe"/> class.</returns>
		public PMS.Entities.DonGiaNgoaiQuyChe GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGiaNgoaiQuyChe index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaNgoaiQuyChe"/> class.</returns>
		public PMS.Entities.DonGiaNgoaiQuyChe GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGiaNgoaiQuyChe index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaNgoaiQuyChe"/> class.</returns>
		public abstract PMS.Entities.DonGiaNgoaiQuyChe GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_DonGiaNgoaiQuyChe_SaoChep 
		
		/// <summary>
		///	This method wrap the 'cust_DonGiaNgoaiQuyChe_SaoChep' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyDich"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void SaoChep(System.String namHocNguon, System.String hocKyNguon, System.String namHocDich, System.String hocKyDich)
		{
			 SaoChep(null, 0, int.MaxValue , namHocNguon, hocKyNguon, namHocDich, hocKyDich);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DonGiaNgoaiQuyChe_SaoChep' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyDich"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void SaoChep(int start, int pageLength, System.String namHocNguon, System.String hocKyNguon, System.String namHocDich, System.String hocKyDich)
		{
			 SaoChep(null, start, pageLength , namHocNguon, hocKyNguon, namHocDich, hocKyDich);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DonGiaNgoaiQuyChe_SaoChep' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyDich"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void SaoChep(TransactionManager transactionManager, System.String namHocNguon, System.String hocKyNguon, System.String namHocDich, System.String hocKyDich)
		{
			 SaoChep(transactionManager, 0, int.MaxValue , namHocNguon, hocKyNguon, namHocDich, hocKyDich);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DonGiaNgoaiQuyChe_SaoChep' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyDich"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void SaoChep(TransactionManager transactionManager, int start, int pageLength , System.String namHocNguon, System.String hocKyNguon, System.String namHocDich, System.String hocKyDich);
		
		#endregion
		
		#region cust_DonGiaNgoaiQuyChe_GetByMaQuanLyNamHocHocKyLopClc 
		
		/// <summary>
		///	This method wrap the 'cust_DonGiaNgoaiQuyChe_GetByMaQuanLyNamHocHocKyLopClc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lopClc"> A <c>System.Boolean</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaQuanLyNamHocHocKyLopClc(System.String maQuanLy, System.String namHoc, System.String hocKy, System.Boolean lopClc, ref System.Int32 reVal)
		{
			 GetByMaQuanLyNamHocHocKyLopClc(null, 0, int.MaxValue , maQuanLy, namHoc, hocKy, lopClc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DonGiaNgoaiQuyChe_GetByMaQuanLyNamHocHocKyLopClc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lopClc"> A <c>System.Boolean</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaQuanLyNamHocHocKyLopClc(int start, int pageLength, System.String maQuanLy, System.String namHoc, System.String hocKy, System.Boolean lopClc, ref System.Int32 reVal)
		{
			 GetByMaQuanLyNamHocHocKyLopClc(null, start, pageLength , maQuanLy, namHoc, hocKy, lopClc, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DonGiaNgoaiQuyChe_GetByMaQuanLyNamHocHocKyLopClc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lopClc"> A <c>System.Boolean</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaQuanLyNamHocHocKyLopClc(TransactionManager transactionManager, System.String maQuanLy, System.String namHoc, System.String hocKy, System.Boolean lopClc, ref System.Int32 reVal)
		{
			 GetByMaQuanLyNamHocHocKyLopClc(transactionManager, 0, int.MaxValue , maQuanLy, namHoc, hocKy, lopClc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DonGiaNgoaiQuyChe_GetByMaQuanLyNamHocHocKyLopClc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lopClc"> A <c>System.Boolean</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByMaQuanLyNamHocHocKyLopClc(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLy, System.String namHoc, System.String hocKy, System.Boolean lopClc, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_DonGiaNgoaiQuyChe_GetByMaGiangVienNgayDay 
		
		/// <summary>
		///	This method wrap the 'cust_DonGiaNgoaiQuyChe_GetByMaGiangVienNgayDay' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DonGiaNgoaiQuyChe&gt;"/> instance.</returns>
		public TList<DonGiaNgoaiQuyChe> GetByMaGiangVienNgayDay(System.Int32 maGiangVien, System.DateTime ngayDay)
		{
			return GetByMaGiangVienNgayDay(null, 0, int.MaxValue , maGiangVien, ngayDay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DonGiaNgoaiQuyChe_GetByMaGiangVienNgayDay' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DonGiaNgoaiQuyChe&gt;"/> instance.</returns>
		public TList<DonGiaNgoaiQuyChe> GetByMaGiangVienNgayDay(int start, int pageLength, System.Int32 maGiangVien, System.DateTime ngayDay)
		{
			return GetByMaGiangVienNgayDay(null, start, pageLength , maGiangVien, ngayDay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DonGiaNgoaiQuyChe_GetByMaGiangVienNgayDay' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DonGiaNgoaiQuyChe&gt;"/> instance.</returns>
		public TList<DonGiaNgoaiQuyChe> GetByMaGiangVienNgayDay(TransactionManager transactionManager, System.Int32 maGiangVien, System.DateTime ngayDay)
		{
			return GetByMaGiangVienNgayDay(transactionManager, 0, int.MaxValue , maGiangVien, ngayDay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DonGiaNgoaiQuyChe_GetByMaGiangVienNgayDay' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DonGiaNgoaiQuyChe&gt;"/> instance.</returns>
		public abstract TList<DonGiaNgoaiQuyChe> GetByMaGiangVienNgayDay(TransactionManager transactionManager, int start, int pageLength , System.Int32 maGiangVien, System.DateTime ngayDay);
		
		#endregion
		
		#region cust_DonGiaNgoaiQuyChe_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_DonGiaNgoaiQuyChe_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DonGiaNgoaiQuyChe_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DonGiaNgoaiQuyChe_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DonGiaNgoaiQuyChe_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;DonGiaNgoaiQuyChe&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;DonGiaNgoaiQuyChe&gt;"/></returns>
		public static TList<DonGiaNgoaiQuyChe> Fill(IDataReader reader, TList<DonGiaNgoaiQuyChe> rows, int start, int pageLength)
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
				
				PMS.Entities.DonGiaNgoaiQuyChe c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("DonGiaNgoaiQuyChe")
					.Append("|").Append((System.Int32)reader[((int)DonGiaNgoaiQuyCheColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<DonGiaNgoaiQuyChe>(
					key.ToString(), // EntityTrackingKey
					"DonGiaNgoaiQuyChe",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.DonGiaNgoaiQuyChe();
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
					c.MaGiangVien = (System.Int32)reader[(DonGiaNgoaiQuyCheColumn.MaGiangVien.ToString())];
					c.NamHoc = (reader[DonGiaNgoaiQuyCheColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaNgoaiQuyCheColumn.NamHoc.ToString())];
					c.HocKy = (reader[DonGiaNgoaiQuyCheColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaNgoaiQuyCheColumn.HocKy.ToString())];
					c.DonGiaDaiTra = (reader[DonGiaNgoaiQuyCheColumn.DonGiaDaiTra.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaNgoaiQuyCheColumn.DonGiaDaiTra.ToString())];
					c.DonGiaClc = (reader[DonGiaNgoaiQuyCheColumn.DonGiaClc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaNgoaiQuyCheColumn.DonGiaClc.ToString())];
					c.GhiChu = (reader[DonGiaNgoaiQuyCheColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaNgoaiQuyCheColumn.GhiChu.ToString())];
					c.NgayCapNhat = (reader[DonGiaNgoaiQuyCheColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(DonGiaNgoaiQuyCheColumn.NgayCapNhat.ToString())];
					c.TuNgay = (reader[DonGiaNgoaiQuyCheColumn.TuNgay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(DonGiaNgoaiQuyCheColumn.TuNgay.ToString())];
					c.DenNgay = (reader[DonGiaNgoaiQuyCheColumn.DenNgay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(DonGiaNgoaiQuyCheColumn.DenNgay.ToString())];
					c.Id = (System.Int32)reader[(DonGiaNgoaiQuyCheColumn.Id.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DonGiaNgoaiQuyChe"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DonGiaNgoaiQuyChe"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.DonGiaNgoaiQuyChe entity)
		{
			if (!reader.Read()) return;
			
			entity.MaGiangVien = (System.Int32)reader[(DonGiaNgoaiQuyCheColumn.MaGiangVien.ToString())];
			entity.NamHoc = (reader[DonGiaNgoaiQuyCheColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaNgoaiQuyCheColumn.NamHoc.ToString())];
			entity.HocKy = (reader[DonGiaNgoaiQuyCheColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaNgoaiQuyCheColumn.HocKy.ToString())];
			entity.DonGiaDaiTra = (reader[DonGiaNgoaiQuyCheColumn.DonGiaDaiTra.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaNgoaiQuyCheColumn.DonGiaDaiTra.ToString())];
			entity.DonGiaClc = (reader[DonGiaNgoaiQuyCheColumn.DonGiaClc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaNgoaiQuyCheColumn.DonGiaClc.ToString())];
			entity.GhiChu = (reader[DonGiaNgoaiQuyCheColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaNgoaiQuyCheColumn.GhiChu.ToString())];
			entity.NgayCapNhat = (reader[DonGiaNgoaiQuyCheColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(DonGiaNgoaiQuyCheColumn.NgayCapNhat.ToString())];
			entity.TuNgay = (reader[DonGiaNgoaiQuyCheColumn.TuNgay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(DonGiaNgoaiQuyCheColumn.TuNgay.ToString())];
			entity.DenNgay = (reader[DonGiaNgoaiQuyCheColumn.DenNgay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(DonGiaNgoaiQuyCheColumn.DenNgay.ToString())];
			entity.Id = (System.Int32)reader[(DonGiaNgoaiQuyCheColumn.Id.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DonGiaNgoaiQuyChe"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DonGiaNgoaiQuyChe"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.DonGiaNgoaiQuyChe entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (System.Int32)dataRow["MaGiangVien"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.DonGiaDaiTra = Convert.IsDBNull(dataRow["DonGiaDaiTra"]) ? null : (System.Decimal?)dataRow["DonGiaDaiTra"];
			entity.DonGiaClc = Convert.IsDBNull(dataRow["DonGiaClc"]) ? null : (System.Decimal?)dataRow["DonGiaClc"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.TuNgay = Convert.IsDBNull(dataRow["TuNgay"]) ? null : (System.DateTime?)dataRow["TuNgay"];
			entity.DenNgay = Convert.IsDBNull(dataRow["DenNgay"]) ? null : (System.DateTime?)dataRow["DenNgay"];
			entity.Id = (System.Int32)dataRow["Id"];
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
		/// <param name="entity">The <see cref="PMS.Entities.DonGiaNgoaiQuyChe"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.DonGiaNgoaiQuyChe Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.DonGiaNgoaiQuyChe entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.DonGiaNgoaiQuyChe object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.DonGiaNgoaiQuyChe instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.DonGiaNgoaiQuyChe Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.DonGiaNgoaiQuyChe entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region DonGiaNgoaiQuyCheChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.DonGiaNgoaiQuyChe</c>
	///</summary>
	public enum DonGiaNgoaiQuyCheChildEntityTypes
	{
	}
	
	#endregion DonGiaNgoaiQuyCheChildEntityTypes
	
	#region DonGiaNgoaiQuyCheFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;DonGiaNgoaiQuyCheColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaNgoaiQuyChe"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaNgoaiQuyCheFilterBuilder : SqlFilterBuilder<DonGiaNgoaiQuyCheColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaNgoaiQuyCheFilterBuilder class.
		/// </summary>
		public DonGiaNgoaiQuyCheFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DonGiaNgoaiQuyCheFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DonGiaNgoaiQuyCheFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DonGiaNgoaiQuyCheFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DonGiaNgoaiQuyCheFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DonGiaNgoaiQuyCheFilterBuilder
	
	#region DonGiaNgoaiQuyCheParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;DonGiaNgoaiQuyCheColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaNgoaiQuyChe"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaNgoaiQuyCheParameterBuilder : ParameterizedSqlFilterBuilder<DonGiaNgoaiQuyCheColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaNgoaiQuyCheParameterBuilder class.
		/// </summary>
		public DonGiaNgoaiQuyCheParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DonGiaNgoaiQuyCheParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DonGiaNgoaiQuyCheParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DonGiaNgoaiQuyCheParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DonGiaNgoaiQuyCheParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DonGiaNgoaiQuyCheParameterBuilder
	
	#region DonGiaNgoaiQuyCheSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;DonGiaNgoaiQuyCheColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaNgoaiQuyChe"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class DonGiaNgoaiQuyCheSortBuilder : SqlSortBuilder<DonGiaNgoaiQuyCheColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaNgoaiQuyCheSqlSortBuilder class.
		/// </summary>
		public DonGiaNgoaiQuyCheSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion DonGiaNgoaiQuyCheSortBuilder
	
} // end namespace
