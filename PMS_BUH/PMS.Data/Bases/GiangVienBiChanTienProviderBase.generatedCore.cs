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
	/// This class is the base class for any <see cref="GiangVienBiChanTienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GiangVienBiChanTienProviderBaseCore : EntityProviderBase<PMS.Entities.GiangVienBiChanTien, PMS.Entities.GiangVienBiChanTienKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.GiangVienBiChanTienKey key)
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
		public override PMS.Entities.GiangVienBiChanTien Get(TransactionManager transactionManager, PMS.Entities.GiangVienBiChanTienKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__GiangVie__3214EC0768A468B1 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienBiChanTien"/> class.</returns>
		public PMS.Entities.GiangVienBiChanTien GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__3214EC0768A468B1 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienBiChanTien"/> class.</returns>
		public PMS.Entities.GiangVienBiChanTien GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__3214EC0768A468B1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienBiChanTien"/> class.</returns>
		public PMS.Entities.GiangVienBiChanTien GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__3214EC0768A468B1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienBiChanTien"/> class.</returns>
		public PMS.Entities.GiangVienBiChanTien GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__3214EC0768A468B1 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienBiChanTien"/> class.</returns>
		public PMS.Entities.GiangVienBiChanTien GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__3214EC0768A468B1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienBiChanTien"/> class.</returns>
		public abstract PMS.Entities.GiangVienBiChanTien GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_GiangVienBiChanTien_LuuThayDoi 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienBiChanTien_LuuThayDoi' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuThayDoi(System.String xmlData, ref System.Int32 reVal)
		{
			 LuuThayDoi(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienBiChanTien_LuuThayDoi' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuThayDoi(int start, int pageLength, System.String xmlData, ref System.Int32 reVal)
		{
			 LuuThayDoi(null, start, pageLength , xmlData, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienBiChanTien_LuuThayDoi' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuThayDoi(TransactionManager transactionManager, System.String xmlData, ref System.Int32 reVal)
		{
			 LuuThayDoi(transactionManager, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienBiChanTien_LuuThayDoi' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuThayDoi(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GiangVienBiChanTien&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GiangVienBiChanTien&gt;"/></returns>
		public static TList<GiangVienBiChanTien> Fill(IDataReader reader, TList<GiangVienBiChanTien> rows, int start, int pageLength)
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
				
				PMS.Entities.GiangVienBiChanTien c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GiangVienBiChanTien")
					.Append("|").Append((System.Int32)reader[((int)GiangVienBiChanTienColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<GiangVienBiChanTien>(
					key.ToString(), // EntityTrackingKey
					"GiangVienBiChanTien",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.GiangVienBiChanTien();
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
					c.Id = (System.Int32)reader[(GiangVienBiChanTienColumn.Id.ToString())];
					c.MaGiangVien = (System.Int32)reader[(GiangVienBiChanTienColumn.MaGiangVien.ToString())];
					c.NamHoc = (reader[GiangVienBiChanTienColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienBiChanTienColumn.NamHoc.ToString())];
					c.HocKy = (reader[GiangVienBiChanTienColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienBiChanTienColumn.HocKy.ToString())];
					c.BiChan = (reader[GiangVienBiChanTienColumn.BiChan.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienBiChanTienColumn.BiChan.ToString())];
					c.GhiChu = (reader[GiangVienBiChanTienColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienBiChanTienColumn.GhiChu.ToString())];
					c.ThanhTienThanhToan = (reader[GiangVienBiChanTienColumn.ThanhTienThanhToan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienBiChanTienColumn.ThanhTienThanhToan.ToString())];
					c.ThanhTienSauChan = (reader[GiangVienBiChanTienColumn.ThanhTienSauChan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienBiChanTienColumn.ThanhTienSauChan.ToString())];
					c.TietXetVuot = (reader[GiangVienBiChanTienColumn.TietXetVuot.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienBiChanTienColumn.TietXetVuot.ToString())];
					c.TietCanTren = (reader[GiangVienBiChanTienColumn.TietCanTren.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienBiChanTienColumn.TietCanTren.ToString())];
					c.TietVuotCanTren = (reader[GiangVienBiChanTienColumn.TietVuotCanTren.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienBiChanTienColumn.TietVuotCanTren.ToString())];
					c.TietThanhToan = (reader[GiangVienBiChanTienColumn.TietThanhToan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienBiChanTienColumn.TietThanhToan.ToString())];
					c.ThanhTienVuot = (reader[GiangVienBiChanTienColumn.ThanhTienVuot.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienBiChanTienColumn.ThanhTienVuot.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienBiChanTien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienBiChanTien"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.GiangVienBiChanTien entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(GiangVienBiChanTienColumn.Id.ToString())];
			entity.MaGiangVien = (System.Int32)reader[(GiangVienBiChanTienColumn.MaGiangVien.ToString())];
			entity.NamHoc = (reader[GiangVienBiChanTienColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienBiChanTienColumn.NamHoc.ToString())];
			entity.HocKy = (reader[GiangVienBiChanTienColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienBiChanTienColumn.HocKy.ToString())];
			entity.BiChan = (reader[GiangVienBiChanTienColumn.BiChan.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienBiChanTienColumn.BiChan.ToString())];
			entity.GhiChu = (reader[GiangVienBiChanTienColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienBiChanTienColumn.GhiChu.ToString())];
			entity.ThanhTienThanhToan = (reader[GiangVienBiChanTienColumn.ThanhTienThanhToan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienBiChanTienColumn.ThanhTienThanhToan.ToString())];
			entity.ThanhTienSauChan = (reader[GiangVienBiChanTienColumn.ThanhTienSauChan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienBiChanTienColumn.ThanhTienSauChan.ToString())];
			entity.TietXetVuot = (reader[GiangVienBiChanTienColumn.TietXetVuot.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienBiChanTienColumn.TietXetVuot.ToString())];
			entity.TietCanTren = (reader[GiangVienBiChanTienColumn.TietCanTren.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienBiChanTienColumn.TietCanTren.ToString())];
			entity.TietVuotCanTren = (reader[GiangVienBiChanTienColumn.TietVuotCanTren.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienBiChanTienColumn.TietVuotCanTren.ToString())];
			entity.TietThanhToan = (reader[GiangVienBiChanTienColumn.TietThanhToan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienBiChanTienColumn.TietThanhToan.ToString())];
			entity.ThanhTienVuot = (reader[GiangVienBiChanTienColumn.ThanhTienVuot.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienBiChanTienColumn.ThanhTienVuot.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienBiChanTien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienBiChanTien"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.GiangVienBiChanTien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaGiangVien = (System.Int32)dataRow["MaGiangVien"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.BiChan = Convert.IsDBNull(dataRow["BiChan"]) ? null : (System.Boolean?)dataRow["BiChan"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.ThanhTienThanhToan = Convert.IsDBNull(dataRow["ThanhTienThanhToan"]) ? null : (System.Decimal?)dataRow["ThanhTienThanhToan"];
			entity.ThanhTienSauChan = Convert.IsDBNull(dataRow["ThanhTienSauChan"]) ? null : (System.Decimal?)dataRow["ThanhTienSauChan"];
			entity.TietXetVuot = Convert.IsDBNull(dataRow["TietXetVuot"]) ? null : (System.Decimal?)dataRow["TietXetVuot"];
			entity.TietCanTren = Convert.IsDBNull(dataRow["TietCanTren"]) ? null : (System.Decimal?)dataRow["TietCanTren"];
			entity.TietVuotCanTren = Convert.IsDBNull(dataRow["TietVuotCanTren"]) ? null : (System.Decimal?)dataRow["TietVuotCanTren"];
			entity.TietThanhToan = Convert.IsDBNull(dataRow["TietThanhToan"]) ? null : (System.Decimal?)dataRow["TietThanhToan"];
			entity.ThanhTienVuot = Convert.IsDBNull(dataRow["ThanhTienVuot"]) ? null : (System.Decimal?)dataRow["ThanhTienVuot"];
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
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienBiChanTien"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienBiChanTien Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.GiangVienBiChanTien entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.GiangVienBiChanTien object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.GiangVienBiChanTien instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienBiChanTien Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.GiangVienBiChanTien entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region GiangVienBiChanTienChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.GiangVienBiChanTien</c>
	///</summary>
	public enum GiangVienBiChanTienChildEntityTypes
	{
	}
	
	#endregion GiangVienBiChanTienChildEntityTypes
	
	#region GiangVienBiChanTienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GiangVienBiChanTienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienBiChanTien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienBiChanTienFilterBuilder : SqlFilterBuilder<GiangVienBiChanTienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienBiChanTienFilterBuilder class.
		/// </summary>
		public GiangVienBiChanTienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienBiChanTienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienBiChanTienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienBiChanTienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienBiChanTienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienBiChanTienFilterBuilder
	
	#region GiangVienBiChanTienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GiangVienBiChanTienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienBiChanTien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienBiChanTienParameterBuilder : ParameterizedSqlFilterBuilder<GiangVienBiChanTienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienBiChanTienParameterBuilder class.
		/// </summary>
		public GiangVienBiChanTienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienBiChanTienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienBiChanTienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienBiChanTienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienBiChanTienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienBiChanTienParameterBuilder
	
	#region GiangVienBiChanTienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GiangVienBiChanTienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienBiChanTien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GiangVienBiChanTienSortBuilder : SqlSortBuilder<GiangVienBiChanTienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienBiChanTienSqlSortBuilder class.
		/// </summary>
		public GiangVienBiChanTienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GiangVienBiChanTienSortBuilder
	
} // end namespace