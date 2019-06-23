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
	/// This class is the base class for any <see cref="DonGiaChamBaiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class DonGiaChamBaiProviderBaseCore : EntityProviderBase<PMS.Entities.DonGiaChamBai, PMS.Entities.DonGiaChamBaiKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.DonGiaChamBaiKey key)
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
		public override PMS.Entities.DonGiaChamBai Get(TransactionManager transactionManager, PMS.Entities.DonGiaChamBaiKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_DonGiaChamBai index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaChamBai"/> class.</returns>
		public PMS.Entities.DonGiaChamBai GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGiaChamBai index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaChamBai"/> class.</returns>
		public PMS.Entities.DonGiaChamBai GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGiaChamBai index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaChamBai"/> class.</returns>
		public PMS.Entities.DonGiaChamBai GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGiaChamBai index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaChamBai"/> class.</returns>
		public PMS.Entities.DonGiaChamBai GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGiaChamBai index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaChamBai"/> class.</returns>
		public PMS.Entities.DonGiaChamBai GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGiaChamBai index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaChamBai"/> class.</returns>
		public abstract PMS.Entities.DonGiaChamBai GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_DonGiaChamBai_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_DonGiaChamBai_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DonGiaChamBai&gt;"/> instance.</returns>
		public TList<DonGiaChamBai> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DonGiaChamBai_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DonGiaChamBai&gt;"/> instance.</returns>
		public TList<DonGiaChamBai> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DonGiaChamBai_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DonGiaChamBai&gt;"/> instance.</returns>
		public TList<DonGiaChamBai> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DonGiaChamBai_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DonGiaChamBai&gt;"/> instance.</returns>
		public abstract TList<DonGiaChamBai> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_DonGiaChamBai_SaoChep 
		
		/// <summary>
		///	This method wrap the 'cust_DonGiaChamBai_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_DonGiaChamBai_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_DonGiaChamBai_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_DonGiaChamBai_SaoChep' stored procedure. 
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
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;DonGiaChamBai&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;DonGiaChamBai&gt;"/></returns>
		public static TList<DonGiaChamBai> Fill(IDataReader reader, TList<DonGiaChamBai> rows, int start, int pageLength)
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
				
				PMS.Entities.DonGiaChamBai c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("DonGiaChamBai")
					.Append("|").Append((System.Int32)reader[((int)DonGiaChamBaiColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<DonGiaChamBai>(
					key.ToString(), // EntityTrackingKey
					"DonGiaChamBai",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.DonGiaChamBai();
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
					c.Id = (System.Int32)reader[(DonGiaChamBaiColumn.Id.ToString())];
					c.NamHoc = (reader[DonGiaChamBaiColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaChamBaiColumn.NamHoc.ToString())];
					c.HocKy = (reader[DonGiaChamBaiColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaChamBaiColumn.HocKy.ToString())];
					c.MaQuanLy = (reader[DonGiaChamBaiColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaChamBaiColumn.MaQuanLy.ToString())];
					c.TenDonGia = (reader[DonGiaChamBaiColumn.TenDonGia.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaChamBaiColumn.TenDonGia.ToString())];
					c.DonGia = (reader[DonGiaChamBaiColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaChamBaiColumn.DonGia.ToString())];
					c.TietQuyChuan = (reader[DonGiaChamBaiColumn.TietQuyChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaChamBaiColumn.TietQuyChuan.ToString())];
					c.BacDaoTao = (reader[DonGiaChamBaiColumn.BacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaChamBaiColumn.BacDaoTao.ToString())];
					c.NgayCapNhat = (reader[DonGiaChamBaiColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaChamBaiColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[DonGiaChamBaiColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaChamBaiColumn.NguoiCapNhat.ToString())];
					c.MaKyThi = (reader[DonGiaChamBaiColumn.MaKyThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaChamBaiColumn.MaKyThi.ToString())];
					c.MaHinhThucThi = (reader[DonGiaChamBaiColumn.MaHinhThucThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaChamBaiColumn.MaHinhThucThi.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DonGiaChamBai"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DonGiaChamBai"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.DonGiaChamBai entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(DonGiaChamBaiColumn.Id.ToString())];
			entity.NamHoc = (reader[DonGiaChamBaiColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaChamBaiColumn.NamHoc.ToString())];
			entity.HocKy = (reader[DonGiaChamBaiColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaChamBaiColumn.HocKy.ToString())];
			entity.MaQuanLy = (reader[DonGiaChamBaiColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaChamBaiColumn.MaQuanLy.ToString())];
			entity.TenDonGia = (reader[DonGiaChamBaiColumn.TenDonGia.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaChamBaiColumn.TenDonGia.ToString())];
			entity.DonGia = (reader[DonGiaChamBaiColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaChamBaiColumn.DonGia.ToString())];
			entity.TietQuyChuan = (reader[DonGiaChamBaiColumn.TietQuyChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaChamBaiColumn.TietQuyChuan.ToString())];
			entity.BacDaoTao = (reader[DonGiaChamBaiColumn.BacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaChamBaiColumn.BacDaoTao.ToString())];
			entity.NgayCapNhat = (reader[DonGiaChamBaiColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaChamBaiColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[DonGiaChamBaiColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaChamBaiColumn.NguoiCapNhat.ToString())];
			entity.MaKyThi = (reader[DonGiaChamBaiColumn.MaKyThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaChamBaiColumn.MaKyThi.ToString())];
			entity.MaHinhThucThi = (reader[DonGiaChamBaiColumn.MaHinhThucThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaChamBaiColumn.MaHinhThucThi.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DonGiaChamBai"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DonGiaChamBai"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.DonGiaChamBai entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.TenDonGia = Convert.IsDBNull(dataRow["TenDonGia"]) ? null : (System.String)dataRow["TenDonGia"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.TietQuyChuan = Convert.IsDBNull(dataRow["TietQuyChuan"]) ? null : (System.Decimal?)dataRow["TietQuyChuan"];
			entity.BacDaoTao = Convert.IsDBNull(dataRow["BacDaoTao"]) ? null : (System.String)dataRow["BacDaoTao"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.MaKyThi = Convert.IsDBNull(dataRow["MaKyThi"]) ? null : (System.String)dataRow["MaKyThi"];
			entity.MaHinhThucThi = Convert.IsDBNull(dataRow["MaHinhThucThi"]) ? null : (System.String)dataRow["MaHinhThucThi"];
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
		/// <param name="entity">The <see cref="PMS.Entities.DonGiaChamBai"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.DonGiaChamBai Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.DonGiaChamBai entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.DonGiaChamBai object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.DonGiaChamBai instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.DonGiaChamBai Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.DonGiaChamBai entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region DonGiaChamBaiChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.DonGiaChamBai</c>
	///</summary>
	public enum DonGiaChamBaiChildEntityTypes
	{
	}
	
	#endregion DonGiaChamBaiChildEntityTypes
	
	#region DonGiaChamBaiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;DonGiaChamBaiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaChamBai"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaChamBaiFilterBuilder : SqlFilterBuilder<DonGiaChamBaiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaChamBaiFilterBuilder class.
		/// </summary>
		public DonGiaChamBaiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DonGiaChamBaiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DonGiaChamBaiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DonGiaChamBaiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DonGiaChamBaiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DonGiaChamBaiFilterBuilder
	
	#region DonGiaChamBaiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;DonGiaChamBaiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaChamBai"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaChamBaiParameterBuilder : ParameterizedSqlFilterBuilder<DonGiaChamBaiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaChamBaiParameterBuilder class.
		/// </summary>
		public DonGiaChamBaiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DonGiaChamBaiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DonGiaChamBaiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DonGiaChamBaiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DonGiaChamBaiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DonGiaChamBaiParameterBuilder
	
	#region DonGiaChamBaiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;DonGiaChamBaiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaChamBai"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class DonGiaChamBaiSortBuilder : SqlSortBuilder<DonGiaChamBaiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaChamBaiSqlSortBuilder class.
		/// </summary>
		public DonGiaChamBaiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion DonGiaChamBaiSortBuilder
	
} // end namespace
