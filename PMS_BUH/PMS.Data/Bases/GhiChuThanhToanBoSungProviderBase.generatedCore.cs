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
	/// This class is the base class for any <see cref="GhiChuThanhToanBoSungProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GhiChuThanhToanBoSungProviderBaseCore : EntityProviderBase<PMS.Entities.GhiChuThanhToanBoSung, PMS.Entities.GhiChuThanhToanBoSungKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.GhiChuThanhToanBoSungKey key)
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
		public override PMS.Entities.GhiChuThanhToanBoSung Get(TransactionManager transactionManager, PMS.Entities.GhiChuThanhToanBoSungKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GhiChuThanhToanBoSung index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GhiChuThanhToanBoSung"/> class.</returns>
		public PMS.Entities.GhiChuThanhToanBoSung GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GhiChuThanhToanBoSung index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GhiChuThanhToanBoSung"/> class.</returns>
		public PMS.Entities.GhiChuThanhToanBoSung GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GhiChuThanhToanBoSung index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GhiChuThanhToanBoSung"/> class.</returns>
		public PMS.Entities.GhiChuThanhToanBoSung GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GhiChuThanhToanBoSung index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GhiChuThanhToanBoSung"/> class.</returns>
		public PMS.Entities.GhiChuThanhToanBoSung GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GhiChuThanhToanBoSung index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GhiChuThanhToanBoSung"/> class.</returns>
		public PMS.Entities.GhiChuThanhToanBoSung GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GhiChuThanhToanBoSung index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GhiChuThanhToanBoSung"/> class.</returns>
		public abstract PMS.Entities.GhiChuThanhToanBoSung GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_GhiChuThanhToanBoSung_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_GhiChuThanhToanBoSung_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reval)
		{
			 Luu(null, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reval);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GhiChuThanhToanBoSung_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reval)
		{
			 Luu(null, start, pageLength , xmlData, namHoc, hocKy, ref reval);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GhiChuThanhToanBoSung_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reval)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reval);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GhiChuThanhToanBoSung_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reval);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GhiChuThanhToanBoSung&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GhiChuThanhToanBoSung&gt;"/></returns>
		public static TList<GhiChuThanhToanBoSung> Fill(IDataReader reader, TList<GhiChuThanhToanBoSung> rows, int start, int pageLength)
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
				
				PMS.Entities.GhiChuThanhToanBoSung c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GhiChuThanhToanBoSung")
					.Append("|").Append((System.Int32)reader[((int)GhiChuThanhToanBoSungColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<GhiChuThanhToanBoSung>(
					key.ToString(), // EntityTrackingKey
					"GhiChuThanhToanBoSung",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.GhiChuThanhToanBoSung();
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
					c.Id = (System.Int32)reader[(GhiChuThanhToanBoSungColumn.Id.ToString())];
					c.NamHoc = (reader[GhiChuThanhToanBoSungColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GhiChuThanhToanBoSungColumn.NamHoc.ToString())];
					c.HocKy = (reader[GhiChuThanhToanBoSungColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GhiChuThanhToanBoSungColumn.HocKy.ToString())];
					c.MaGiangVien = (reader[GhiChuThanhToanBoSungColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GhiChuThanhToanBoSungColumn.MaGiangVien.ToString())];
					c.GhiChu = (reader[GhiChuThanhToanBoSungColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(GhiChuThanhToanBoSungColumn.GhiChu.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GhiChuThanhToanBoSung"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GhiChuThanhToanBoSung"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.GhiChuThanhToanBoSung entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(GhiChuThanhToanBoSungColumn.Id.ToString())];
			entity.NamHoc = (reader[GhiChuThanhToanBoSungColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GhiChuThanhToanBoSungColumn.NamHoc.ToString())];
			entity.HocKy = (reader[GhiChuThanhToanBoSungColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GhiChuThanhToanBoSungColumn.HocKy.ToString())];
			entity.MaGiangVien = (reader[GhiChuThanhToanBoSungColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GhiChuThanhToanBoSungColumn.MaGiangVien.ToString())];
			entity.GhiChu = (reader[GhiChuThanhToanBoSungColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(GhiChuThanhToanBoSungColumn.GhiChu.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GhiChuThanhToanBoSung"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GhiChuThanhToanBoSung"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.GhiChuThanhToanBoSung entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
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
		/// <param name="entity">The <see cref="PMS.Entities.GhiChuThanhToanBoSung"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.GhiChuThanhToanBoSung Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.GhiChuThanhToanBoSung entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.GhiChuThanhToanBoSung object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.GhiChuThanhToanBoSung instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.GhiChuThanhToanBoSung Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.GhiChuThanhToanBoSung entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region GhiChuThanhToanBoSungChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.GhiChuThanhToanBoSung</c>
	///</summary>
	public enum GhiChuThanhToanBoSungChildEntityTypes
	{
	}
	
	#endregion GhiChuThanhToanBoSungChildEntityTypes
	
	#region GhiChuThanhToanBoSungFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GhiChuThanhToanBoSungColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GhiChuThanhToanBoSung"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GhiChuThanhToanBoSungFilterBuilder : SqlFilterBuilder<GhiChuThanhToanBoSungColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GhiChuThanhToanBoSungFilterBuilder class.
		/// </summary>
		public GhiChuThanhToanBoSungFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GhiChuThanhToanBoSungFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GhiChuThanhToanBoSungFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GhiChuThanhToanBoSungFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GhiChuThanhToanBoSungFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GhiChuThanhToanBoSungFilterBuilder
	
	#region GhiChuThanhToanBoSungParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GhiChuThanhToanBoSungColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GhiChuThanhToanBoSung"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GhiChuThanhToanBoSungParameterBuilder : ParameterizedSqlFilterBuilder<GhiChuThanhToanBoSungColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GhiChuThanhToanBoSungParameterBuilder class.
		/// </summary>
		public GhiChuThanhToanBoSungParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GhiChuThanhToanBoSungParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GhiChuThanhToanBoSungParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GhiChuThanhToanBoSungParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GhiChuThanhToanBoSungParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GhiChuThanhToanBoSungParameterBuilder
	
	#region GhiChuThanhToanBoSungSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GhiChuThanhToanBoSungColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GhiChuThanhToanBoSung"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GhiChuThanhToanBoSungSortBuilder : SqlSortBuilder<GhiChuThanhToanBoSungColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GhiChuThanhToanBoSungSqlSortBuilder class.
		/// </summary>
		public GhiChuThanhToanBoSungSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GhiChuThanhToanBoSungSortBuilder
	
} // end namespace
