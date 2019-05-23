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
	/// This class is the base class for any <see cref="ThucGiangMonThucTeTuHocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ThucGiangMonThucTeTuHocProviderBaseCore : EntityProviderBase<PMS.Entities.ThucGiangMonThucTeTuHoc, PMS.Entities.ThucGiangMonThucTeTuHocKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ThucGiangMonThucTeTuHocKey key)
		{
			return Delete(transactionManager, key.MaQuanLy);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maQuanLy">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maQuanLy)
		{
			return Delete(null, _maQuanLy);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maQuanLy);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ThucGiangMonThucTeTuHoc_HeSoCongViec key.
		///		FK_ThucGiangMonThucTeTuHoc_HeSoCongViec Description: 
		/// </summary>
		/// <param name="_maHeSoCongViec"></param>
		/// <returns>Returns a typed collection of PMS.Entities.ThucGiangMonThucTeTuHoc objects.</returns>
		public TList<ThucGiangMonThucTeTuHoc> GetByMaHeSoCongViec(System.Int32? _maHeSoCongViec)
		{
			int count = -1;
			return GetByMaHeSoCongViec(_maHeSoCongViec, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ThucGiangMonThucTeTuHoc_HeSoCongViec key.
		///		FK_ThucGiangMonThucTeTuHoc_HeSoCongViec Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSoCongViec"></param>
		/// <returns>Returns a typed collection of PMS.Entities.ThucGiangMonThucTeTuHoc objects.</returns>
		/// <remarks></remarks>
		public TList<ThucGiangMonThucTeTuHoc> GetByMaHeSoCongViec(TransactionManager transactionManager, System.Int32? _maHeSoCongViec)
		{
			int count = -1;
			return GetByMaHeSoCongViec(transactionManager, _maHeSoCongViec, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ThucGiangMonThucTeTuHoc_HeSoCongViec key.
		///		FK_ThucGiangMonThucTeTuHoc_HeSoCongViec Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSoCongViec"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.ThucGiangMonThucTeTuHoc objects.</returns>
		public TList<ThucGiangMonThucTeTuHoc> GetByMaHeSoCongViec(TransactionManager transactionManager, System.Int32? _maHeSoCongViec, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHeSoCongViec(transactionManager, _maHeSoCongViec, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ThucGiangMonThucTeTuHoc_HeSoCongViec key.
		///		fkThucGiangMonThucTeTuHocHeSoCongViec Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHeSoCongViec"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.ThucGiangMonThucTeTuHoc objects.</returns>
		public TList<ThucGiangMonThucTeTuHoc> GetByMaHeSoCongViec(System.Int32? _maHeSoCongViec, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaHeSoCongViec(null, _maHeSoCongViec, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ThucGiangMonThucTeTuHoc_HeSoCongViec key.
		///		fkThucGiangMonThucTeTuHocHeSoCongViec Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHeSoCongViec"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.ThucGiangMonThucTeTuHoc objects.</returns>
		public TList<ThucGiangMonThucTeTuHoc> GetByMaHeSoCongViec(System.Int32? _maHeSoCongViec, int start, int pageLength,out int count)
		{
			return GetByMaHeSoCongViec(null, _maHeSoCongViec, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ThucGiangMonThucTeTuHoc_HeSoCongViec key.
		///		FK_ThucGiangMonThucTeTuHoc_HeSoCongViec Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSoCongViec"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.ThucGiangMonThucTeTuHoc objects.</returns>
		public abstract TList<ThucGiangMonThucTeTuHoc> GetByMaHeSoCongViec(TransactionManager transactionManager, System.Int32? _maHeSoCongViec, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.ThucGiangMonThucTeTuHoc Get(TransactionManager transactionManager, PMS.Entities.ThucGiangMonThucTeTuHocKey key, int start, int pageLength)
		{
			return GetByMaQuanLy(transactionManager, key.MaQuanLy, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ThucGiangMonThucTeTuHoc_1 index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThucGiangMonThucTeTuHoc"/> class.</returns>
		public PMS.Entities.ThucGiangMonThucTeTuHoc GetByMaQuanLy(System.Int32 _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(null,_maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThucGiangMonThucTeTuHoc_1 index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThucGiangMonThucTeTuHoc"/> class.</returns>
		public PMS.Entities.ThucGiangMonThucTeTuHoc GetByMaQuanLy(System.Int32 _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThucGiangMonThucTeTuHoc_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThucGiangMonThucTeTuHoc"/> class.</returns>
		public PMS.Entities.ThucGiangMonThucTeTuHoc GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThucGiangMonThucTeTuHoc_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThucGiangMonThucTeTuHoc"/> class.</returns>
		public PMS.Entities.ThucGiangMonThucTeTuHoc GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThucGiangMonThucTeTuHoc_1 index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThucGiangMonThucTeTuHoc"/> class.</returns>
		public PMS.Entities.ThucGiangMonThucTeTuHoc GetByMaQuanLy(System.Int32 _maQuanLy, int start, int pageLength, out int count)
		{
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThucGiangMonThucTeTuHoc_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThucGiangMonThucTeTuHoc"/> class.</returns>
		public abstract PMS.Entities.ThucGiangMonThucTeTuHoc GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_ThucGiangMonThucTeTuHoc_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_ThucGiangMonThucTeTuHoc_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThucGiangMonThucTeTuHoc_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThucGiangMonThucTeTuHoc_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThucGiangMonThucTeTuHoc_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_ThucGiangMonThucTeTuHoc_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_ThucGiangMonThucTeTuHoc_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThucGiangMonThucTeTuHoc_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThucGiangMonThucTeTuHoc_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThucGiangMonThucTeTuHoc_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ThucGiangMonThucTeTuHoc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ThucGiangMonThucTeTuHoc&gt;"/></returns>
		public static TList<ThucGiangMonThucTeTuHoc> Fill(IDataReader reader, TList<ThucGiangMonThucTeTuHoc> rows, int start, int pageLength)
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
				
				PMS.Entities.ThucGiangMonThucTeTuHoc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ThucGiangMonThucTeTuHoc")
					.Append("|").Append((System.Int32)reader[((int)ThucGiangMonThucTeTuHocColumn.MaQuanLy - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ThucGiangMonThucTeTuHoc>(
					key.ToString(), // EntityTrackingKey
					"ThucGiangMonThucTeTuHoc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ThucGiangMonThucTeTuHoc();
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
					c.MaQuanLy = (System.Int32)reader[(ThucGiangMonThucTeTuHocColumn.MaQuanLy.ToString())];
					c.MaLopHocPhan = (reader[ThucGiangMonThucTeTuHocColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThucGiangMonThucTeTuHocColumn.MaLopHocPhan.ToString())];
					c.MaHeSoCongViec = (reader[ThucGiangMonThucTeTuHocColumn.MaHeSoCongViec.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThucGiangMonThucTeTuHocColumn.MaHeSoCongViec.ToString())];
					c.NamHoc = (reader[ThucGiangMonThucTeTuHocColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThucGiangMonThucTeTuHocColumn.NamHoc.ToString())];
					c.HocKy = (reader[ThucGiangMonThucTeTuHocColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThucGiangMonThucTeTuHocColumn.HocKy.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThucGiangMonThucTeTuHoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThucGiangMonThucTeTuHoc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ThucGiangMonThucTeTuHoc entity)
		{
			if (!reader.Read()) return;
			
			entity.MaQuanLy = (System.Int32)reader[(ThucGiangMonThucTeTuHocColumn.MaQuanLy.ToString())];
			entity.MaLopHocPhan = (reader[ThucGiangMonThucTeTuHocColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThucGiangMonThucTeTuHocColumn.MaLopHocPhan.ToString())];
			entity.MaHeSoCongViec = (reader[ThucGiangMonThucTeTuHocColumn.MaHeSoCongViec.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThucGiangMonThucTeTuHocColumn.MaHeSoCongViec.ToString())];
			entity.NamHoc = (reader[ThucGiangMonThucTeTuHocColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThucGiangMonThucTeTuHocColumn.NamHoc.ToString())];
			entity.HocKy = (reader[ThucGiangMonThucTeTuHocColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThucGiangMonThucTeTuHocColumn.HocKy.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThucGiangMonThucTeTuHoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThucGiangMonThucTeTuHoc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ThucGiangMonThucTeTuHoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaQuanLy = (System.Int32)dataRow["MaQuanLy"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.MaHeSoCongViec = Convert.IsDBNull(dataRow["MaHeSoCongViec"]) ? null : (System.Int32?)dataRow["MaHeSoCongViec"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ThucGiangMonThucTeTuHoc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ThucGiangMonThucTeTuHoc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ThucGiangMonThucTeTuHoc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaHeSoCongViecSource	
			if (CanDeepLoad(entity, "HeSoCongViec|MaHeSoCongViecSource", deepLoadType, innerList) 
				&& entity.MaHeSoCongViecSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaHeSoCongViec ?? (int)0);
				HeSoCongViec tmpEntity = EntityManager.LocateEntity<HeSoCongViec>(EntityLocator.ConstructKeyFromPkItems(typeof(HeSoCongViec), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaHeSoCongViecSource = tmpEntity;
				else
					entity.MaHeSoCongViecSource = DataRepository.HeSoCongViecProvider.GetByMaHeSo(transactionManager, (entity.MaHeSoCongViec ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaHeSoCongViecSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaHeSoCongViecSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.HeSoCongViecProvider.DeepLoad(transactionManager, entity.MaHeSoCongViecSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaHeSoCongViecSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.ThucGiangMonThucTeTuHoc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ThucGiangMonThucTeTuHoc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ThucGiangMonThucTeTuHoc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ThucGiangMonThucTeTuHoc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaHeSoCongViecSource
			if (CanDeepSave(entity, "HeSoCongViec|MaHeSoCongViecSource", deepSaveType, innerList) 
				&& entity.MaHeSoCongViecSource != null)
			{
				DataRepository.HeSoCongViecProvider.Save(transactionManager, entity.MaHeSoCongViecSource);
				entity.MaHeSoCongViec = entity.MaHeSoCongViecSource.MaHeSo;
			}
			#endregion 
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
	
	#region ThucGiangMonThucTeTuHocChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ThucGiangMonThucTeTuHoc</c>
	///</summary>
	public enum ThucGiangMonThucTeTuHocChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>HeSoCongViec</c> at MaHeSoCongViecSource
		///</summary>
		[ChildEntityType(typeof(HeSoCongViec))]
		HeSoCongViec,
	}
	
	#endregion ThucGiangMonThucTeTuHocChildEntityTypes
	
	#region ThucGiangMonThucTeTuHocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ThucGiangMonThucTeTuHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThucGiangMonThucTeTuHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThucGiangMonThucTeTuHocFilterBuilder : SqlFilterBuilder<ThucGiangMonThucTeTuHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThucGiangMonThucTeTuHocFilterBuilder class.
		/// </summary>
		public ThucGiangMonThucTeTuHocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThucGiangMonThucTeTuHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThucGiangMonThucTeTuHocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThucGiangMonThucTeTuHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThucGiangMonThucTeTuHocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThucGiangMonThucTeTuHocFilterBuilder
	
	#region ThucGiangMonThucTeTuHocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ThucGiangMonThucTeTuHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThucGiangMonThucTeTuHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThucGiangMonThucTeTuHocParameterBuilder : ParameterizedSqlFilterBuilder<ThucGiangMonThucTeTuHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThucGiangMonThucTeTuHocParameterBuilder class.
		/// </summary>
		public ThucGiangMonThucTeTuHocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThucGiangMonThucTeTuHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThucGiangMonThucTeTuHocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThucGiangMonThucTeTuHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThucGiangMonThucTeTuHocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThucGiangMonThucTeTuHocParameterBuilder
	
	#region ThucGiangMonThucTeTuHocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ThucGiangMonThucTeTuHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThucGiangMonThucTeTuHoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ThucGiangMonThucTeTuHocSortBuilder : SqlSortBuilder<ThucGiangMonThucTeTuHocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThucGiangMonThucTeTuHocSqlSortBuilder class.
		/// </summary>
		public ThucGiangMonThucTeTuHocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ThucGiangMonThucTeTuHocSortBuilder
	
} // end namespace
