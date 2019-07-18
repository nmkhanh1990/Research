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
	/// This class is the base class for any <see cref="TieuDeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class TieuDeProviderBaseCore : EntityProviderBase<PMS.Entities.TieuDe, PMS.Entities.TieuDeKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.TieuDeKey key)
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
		public override PMS.Entities.TieuDe Get(TransactionManager transactionManager, PMS.Entities.TieuDeKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__TieuDe__3214EC077A730886 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TieuDe"/> class.</returns>
		public PMS.Entities.TieuDe GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__TieuDe__3214EC077A730886 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TieuDe"/> class.</returns>
		public PMS.Entities.TieuDe GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__TieuDe__3214EC077A730886 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TieuDe"/> class.</returns>
		public PMS.Entities.TieuDe GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__TieuDe__3214EC077A730886 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TieuDe"/> class.</returns>
		public PMS.Entities.TieuDe GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__TieuDe__3214EC077A730886 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TieuDe"/> class.</returns>
		public PMS.Entities.TieuDe GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__TieuDe__3214EC077A730886 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TieuDe"/> class.</returns>
		public abstract PMS.Entities.TieuDe GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;TieuDe&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;TieuDe&gt;"/></returns>
		public static TList<TieuDe> Fill(IDataReader reader, TList<TieuDe> rows, int start, int pageLength)
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
				
				PMS.Entities.TieuDe c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("TieuDe")
					.Append("|").Append((System.Int32)reader[((int)TieuDeColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<TieuDe>(
					key.ToString(), // EntityTrackingKey
					"TieuDe",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.TieuDe();
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
					c.Id = (System.Int32)reader[(TieuDeColumn.Id.ToString())];
					c.IdFileName = (reader[TieuDeColumn.IdFileName.ToString()] == DBNull.Value) ? null : (System.String)reader[(TieuDeColumn.IdFileName.ToString())];
					c.IdTitleVn = (reader[TieuDeColumn.IdTitleVn.ToString()] == DBNull.Value) ? null : (System.String)reader[(TieuDeColumn.IdTitleVn.ToString())];
					c.IdTitleEn = (reader[TieuDeColumn.IdTitleEn.ToString()] == DBNull.Value) ? null : (System.String)reader[(TieuDeColumn.IdTitleEn.ToString())];
					c.IdSize = (reader[TieuDeColumn.IdSize.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TieuDeColumn.IdSize.ToString())];
					c.Stt = (reader[TieuDeColumn.Stt.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TieuDeColumn.Stt.ToString())];
					c.MaTruong = (reader[TieuDeColumn.MaTruong.ToString()] == DBNull.Value) ? null : (System.String)reader[(TieuDeColumn.MaTruong.ToString())];
					c.TrangThai = (reader[TieuDeColumn.TrangThai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(TieuDeColumn.TrangThai.ToString())];
					c.IdFrom = (reader[TieuDeColumn.IdFrom.ToString()] == DBNull.Value) ? null : (System.String)reader[(TieuDeColumn.IdFrom.ToString())];
					c.IdAn = (reader[TieuDeColumn.IdAn.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TieuDeColumn.IdAn.ToString())];
					c.IdFormatField = (reader[TieuDeColumn.IdFormatField.ToString()] == DBNull.Value) ? null : (System.String)reader[(TieuDeColumn.IdFormatField.ToString())];
					c.IdHideField = (reader[TieuDeColumn.IdHideField.ToString()] == DBNull.Value) ? null : (System.String)reader[(TieuDeColumn.IdHideField.ToString())];
					c.IdSummaryField = (reader[TieuDeColumn.IdSummaryField.ToString()] == DBNull.Value) ? null : (System.String)reader[(TieuDeColumn.IdSummaryField.ToString())];
					c.IdReadOnlyField = (reader[TieuDeColumn.IdReadOnlyField.ToString()] == DBNull.Value) ? null : (System.String)reader[(TieuDeColumn.IdReadOnlyField.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.TieuDe"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.TieuDe"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.TieuDe entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(TieuDeColumn.Id.ToString())];
			entity.IdFileName = (reader[TieuDeColumn.IdFileName.ToString()] == DBNull.Value) ? null : (System.String)reader[(TieuDeColumn.IdFileName.ToString())];
			entity.IdTitleVn = (reader[TieuDeColumn.IdTitleVn.ToString()] == DBNull.Value) ? null : (System.String)reader[(TieuDeColumn.IdTitleVn.ToString())];
			entity.IdTitleEn = (reader[TieuDeColumn.IdTitleEn.ToString()] == DBNull.Value) ? null : (System.String)reader[(TieuDeColumn.IdTitleEn.ToString())];
			entity.IdSize = (reader[TieuDeColumn.IdSize.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TieuDeColumn.IdSize.ToString())];
			entity.Stt = (reader[TieuDeColumn.Stt.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TieuDeColumn.Stt.ToString())];
			entity.MaTruong = (reader[TieuDeColumn.MaTruong.ToString()] == DBNull.Value) ? null : (System.String)reader[(TieuDeColumn.MaTruong.ToString())];
			entity.TrangThai = (reader[TieuDeColumn.TrangThai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(TieuDeColumn.TrangThai.ToString())];
			entity.IdFrom = (reader[TieuDeColumn.IdFrom.ToString()] == DBNull.Value) ? null : (System.String)reader[(TieuDeColumn.IdFrom.ToString())];
			entity.IdAn = (reader[TieuDeColumn.IdAn.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TieuDeColumn.IdAn.ToString())];
			entity.IdFormatField = (reader[TieuDeColumn.IdFormatField.ToString()] == DBNull.Value) ? null : (System.String)reader[(TieuDeColumn.IdFormatField.ToString())];
			entity.IdHideField = (reader[TieuDeColumn.IdHideField.ToString()] == DBNull.Value) ? null : (System.String)reader[(TieuDeColumn.IdHideField.ToString())];
			entity.IdSummaryField = (reader[TieuDeColumn.IdSummaryField.ToString()] == DBNull.Value) ? null : (System.String)reader[(TieuDeColumn.IdSummaryField.ToString())];
			entity.IdReadOnlyField = (reader[TieuDeColumn.IdReadOnlyField.ToString()] == DBNull.Value) ? null : (System.String)reader[(TieuDeColumn.IdReadOnlyField.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.TieuDe"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.TieuDe"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.TieuDe entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.IdFileName = Convert.IsDBNull(dataRow["IdFileName"]) ? null : (System.String)dataRow["IdFileName"];
			entity.IdTitleVn = Convert.IsDBNull(dataRow["IdTitleVN"]) ? null : (System.String)dataRow["IdTitleVN"];
			entity.IdTitleEn = Convert.IsDBNull(dataRow["IdTitleEN"]) ? null : (System.String)dataRow["IdTitleEN"];
			entity.IdSize = Convert.IsDBNull(dataRow["IdSize"]) ? null : (System.Int32?)dataRow["IdSize"];
			entity.Stt = Convert.IsDBNull(dataRow["STT"]) ? null : (System.Int32?)dataRow["STT"];
			entity.MaTruong = Convert.IsDBNull(dataRow["MaTruong"]) ? null : (System.String)dataRow["MaTruong"];
			entity.TrangThai = Convert.IsDBNull(dataRow["TrangThai"]) ? null : (System.Boolean?)dataRow["TrangThai"];
			entity.IdFrom = Convert.IsDBNull(dataRow["IDFrom"]) ? null : (System.String)dataRow["IDFrom"];
			entity.IdAn = Convert.IsDBNull(dataRow["IdAn"]) ? null : (System.Int32?)dataRow["IdAn"];
			entity.IdFormatField = Convert.IsDBNull(dataRow["IdFormatField"]) ? null : (System.String)dataRow["IdFormatField"];
			entity.IdHideField = Convert.IsDBNull(dataRow["IdHideField"]) ? null : (System.String)dataRow["IdHideField"];
			entity.IdSummaryField = Convert.IsDBNull(dataRow["IdSummaryField"]) ? null : (System.String)dataRow["IdSummaryField"];
			entity.IdReadOnlyField = Convert.IsDBNull(dataRow["IdReadOnlyField"]) ? null : (System.String)dataRow["IdReadOnlyField"];
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
		/// <param name="entity">The <see cref="PMS.Entities.TieuDe"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.TieuDe Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.TieuDe entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.TieuDe object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.TieuDe instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.TieuDe Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.TieuDe entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region TieuDeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.TieuDe</c>
	///</summary>
	public enum TieuDeChildEntityTypes
	{
	}
	
	#endregion TieuDeChildEntityTypes
	
	#region TieuDeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;TieuDeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TieuDe"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TieuDeFilterBuilder : SqlFilterBuilder<TieuDeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TieuDeFilterBuilder class.
		/// </summary>
		public TieuDeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TieuDeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TieuDeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TieuDeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TieuDeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TieuDeFilterBuilder
	
	#region TieuDeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;TieuDeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TieuDe"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TieuDeParameterBuilder : ParameterizedSqlFilterBuilder<TieuDeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TieuDeParameterBuilder class.
		/// </summary>
		public TieuDeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TieuDeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TieuDeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TieuDeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TieuDeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TieuDeParameterBuilder
	
	#region TieuDeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;TieuDeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TieuDe"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class TieuDeSortBuilder : SqlSortBuilder<TieuDeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TieuDeSqlSortBuilder class.
		/// </summary>
		public TieuDeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion TieuDeSortBuilder
	
} // end namespace