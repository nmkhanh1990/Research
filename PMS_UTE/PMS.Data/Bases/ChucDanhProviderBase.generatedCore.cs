#region Using directives

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
	/// This class is the base class for any <see cref="ChucDanhProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ChucDanhProviderBaseCore : EntityProviderBase<PMS.Entities.ChucDanh, PMS.Entities.ChucDanhKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ChucDanhKey key)
		{
			return Delete(transactionManager, key.MaChucDanh);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maChucDanh">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maChucDanh)
		{
			return Delete(null, _maChucDanh);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChucDanh">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maChucDanh);		
		
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
		public override PMS.Entities.ChucDanh Get(TransactionManager transactionManager, PMS.Entities.ChucDanhKey key, int start, int pageLength)
		{
			return GetByMaChucDanh(transactionManager, key.MaChucDanh, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__ChucDanh__3D954CAEEEEDC87B index.
		/// </summary>
		/// <param name="_maChucDanh"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChucDanh"/> class.</returns>
		public PMS.Entities.ChucDanh GetByMaChucDanh(System.Int32 _maChucDanh)
		{
			int count = -1;
			return GetByMaChucDanh(null,_maChucDanh, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__ChucDanh__3D954CAEEEEDC87B index.
		/// </summary>
		/// <param name="_maChucDanh"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChucDanh"/> class.</returns>
		public PMS.Entities.ChucDanh GetByMaChucDanh(System.Int32 _maChucDanh, int start, int pageLength)
		{
			int count = -1;
			return GetByMaChucDanh(null, _maChucDanh, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__ChucDanh__3D954CAEEEEDC87B index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChucDanh"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChucDanh"/> class.</returns>
		public PMS.Entities.ChucDanh GetByMaChucDanh(TransactionManager transactionManager, System.Int32 _maChucDanh)
		{
			int count = -1;
			return GetByMaChucDanh(transactionManager, _maChucDanh, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__ChucDanh__3D954CAEEEEDC87B index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChucDanh"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChucDanh"/> class.</returns>
		public PMS.Entities.ChucDanh GetByMaChucDanh(TransactionManager transactionManager, System.Int32 _maChucDanh, int start, int pageLength)
		{
			int count = -1;
			return GetByMaChucDanh(transactionManager, _maChucDanh, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__ChucDanh__3D954CAEEEEDC87B index.
		/// </summary>
		/// <param name="_maChucDanh"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChucDanh"/> class.</returns>
		public PMS.Entities.ChucDanh GetByMaChucDanh(System.Int32 _maChucDanh, int start, int pageLength, out int count)
		{
			return GetByMaChucDanh(null, _maChucDanh, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__ChucDanh__3D954CAEEEEDC87B index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChucDanh"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChucDanh"/> class.</returns>
		public abstract PMS.Entities.ChucDanh GetByMaChucDanh(TransactionManager transactionManager, System.Int32 _maChucDanh, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ChucDanh&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ChucDanh&gt;"/></returns>
		public static TList<ChucDanh> Fill(IDataReader reader, TList<ChucDanh> rows, int start, int pageLength)
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
				
				PMS.Entities.ChucDanh c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ChucDanh")
					.Append("|").Append((System.Int32)reader[((int)ChucDanhColumn.MaChucDanh - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ChucDanh>(
					key.ToString(), // EntityTrackingKey
					"ChucDanh",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ChucDanh();
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
					c.MaChucDanh = (System.Int32)reader[(ChucDanhColumn.MaChucDanh.ToString())];
					c.MaQuanLy = (System.String)reader[(ChucDanhColumn.MaQuanLy.ToString())];
					c.TenChucDanh = (reader[ChucDanhColumn.TenChucDanh.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChucDanhColumn.TenChucDanh.ToString())];
					c.ThuTu = (reader[ChucDanhColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChucDanhColumn.ThuTu.ToString())];
					c.Hrmid = (reader[ChucDanhColumn.Hrmid.ToString()] == DBNull.Value) ? null : (System.Guid?)reader[(ChucDanhColumn.Hrmid.ToString())];
					c.TinhTrang = (reader[ChucDanhColumn.TinhTrang.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ChucDanhColumn.TinhTrang.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ChucDanh"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ChucDanh"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ChucDanh entity)
		{
			if (!reader.Read()) return;
			
			entity.MaChucDanh = (System.Int32)reader[(ChucDanhColumn.MaChucDanh.ToString())];
			entity.MaQuanLy = (System.String)reader[(ChucDanhColumn.MaQuanLy.ToString())];
			entity.TenChucDanh = (reader[ChucDanhColumn.TenChucDanh.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChucDanhColumn.TenChucDanh.ToString())];
			entity.ThuTu = (reader[ChucDanhColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChucDanhColumn.ThuTu.ToString())];
			entity.Hrmid = (reader[ChucDanhColumn.Hrmid.ToString()] == DBNull.Value) ? null : (System.Guid?)reader[(ChucDanhColumn.Hrmid.ToString())];
			entity.TinhTrang = (reader[ChucDanhColumn.TinhTrang.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ChucDanhColumn.TinhTrang.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ChucDanh"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ChucDanh"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ChucDanh entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaChucDanh = (System.Int32)dataRow["MaChucDanh"];
			entity.MaQuanLy = (System.String)dataRow["MaQuanLy"];
			entity.TenChucDanh = Convert.IsDBNull(dataRow["TenChucDanh"]) ? null : (System.String)dataRow["TenChucDanh"];
			entity.ThuTu = Convert.IsDBNull(dataRow["ThuTu"]) ? null : (System.Int32?)dataRow["ThuTu"];
			entity.Hrmid = Convert.IsDBNull(dataRow["HRMID"]) ? null : (System.Guid?)dataRow["HRMID"];
			entity.TinhTrang = Convert.IsDBNull(dataRow["TinhTrang"]) ? null : (System.Boolean?)dataRow["TinhTrang"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ChucDanh"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ChucDanh Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ChucDanh entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.ChucDanh object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ChucDanh instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ChucDanh Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ChucDanh entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region ChucDanhChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ChucDanh</c>
	///</summary>
	public enum ChucDanhChildEntityTypes
	{
	}
	
	#endregion ChucDanhChildEntityTypes
	
	#region ChucDanhFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ChucDanhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChucDanh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChucDanhFilterBuilder : SqlFilterBuilder<ChucDanhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChucDanhFilterBuilder class.
		/// </summary>
		public ChucDanhFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ChucDanhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ChucDanhFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ChucDanhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ChucDanhFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ChucDanhFilterBuilder
	
	#region ChucDanhParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ChucDanhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChucDanh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChucDanhParameterBuilder : ParameterizedSqlFilterBuilder<ChucDanhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChucDanhParameterBuilder class.
		/// </summary>
		public ChucDanhParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ChucDanhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ChucDanhParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ChucDanhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ChucDanhParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ChucDanhParameterBuilder
	
	#region ChucDanhSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ChucDanhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChucDanh"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ChucDanhSortBuilder : SqlSortBuilder<ChucDanhColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChucDanhSqlSortBuilder class.
		/// </summary>
		public ChucDanhSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ChucDanhSortBuilder
	
} // end namespace
