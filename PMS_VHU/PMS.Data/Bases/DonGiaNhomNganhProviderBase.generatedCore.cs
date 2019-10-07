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
	/// This class is the base class for any <see cref="DonGiaNhomNganhProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class DonGiaNhomNganhProviderBaseCore : EntityProviderBase<PMS.Entities.DonGiaNhomNganh, PMS.Entities.DonGiaNhomNganhKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.DonGiaNhomNganhKey key)
		{
			return Delete(transactionManager, key.MaDonGiaNhomNganh);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maDonGiaNhomNganh">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maDonGiaNhomNganh)
		{
			return Delete(null, _maDonGiaNhomNganh);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDonGiaNhomNganh">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maDonGiaNhomNganh);		
		
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
		public override PMS.Entities.DonGiaNhomNganh Get(TransactionManager transactionManager, PMS.Entities.DonGiaNhomNganhKey key, int start, int pageLength)
		{
			return GetByMaDonGiaNhomNganh(transactionManager, key.MaDonGiaNhomNganh, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__DonGiaNh__6C4D3F4DAEC7DC52 index.
		/// </summary>
		/// <param name="_maDonGiaNhomNganh"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaNhomNganh"/> class.</returns>
		public PMS.Entities.DonGiaNhomNganh GetByMaDonGiaNhomNganh(System.Int32 _maDonGiaNhomNganh)
		{
			int count = -1;
			return GetByMaDonGiaNhomNganh(null,_maDonGiaNhomNganh, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__DonGiaNh__6C4D3F4DAEC7DC52 index.
		/// </summary>
		/// <param name="_maDonGiaNhomNganh"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaNhomNganh"/> class.</returns>
		public PMS.Entities.DonGiaNhomNganh GetByMaDonGiaNhomNganh(System.Int32 _maDonGiaNhomNganh, int start, int pageLength)
		{
			int count = -1;
			return GetByMaDonGiaNhomNganh(null, _maDonGiaNhomNganh, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__DonGiaNh__6C4D3F4DAEC7DC52 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDonGiaNhomNganh"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaNhomNganh"/> class.</returns>
		public PMS.Entities.DonGiaNhomNganh GetByMaDonGiaNhomNganh(TransactionManager transactionManager, System.Int32 _maDonGiaNhomNganh)
		{
			int count = -1;
			return GetByMaDonGiaNhomNganh(transactionManager, _maDonGiaNhomNganh, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__DonGiaNh__6C4D3F4DAEC7DC52 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDonGiaNhomNganh"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaNhomNganh"/> class.</returns>
		public PMS.Entities.DonGiaNhomNganh GetByMaDonGiaNhomNganh(TransactionManager transactionManager, System.Int32 _maDonGiaNhomNganh, int start, int pageLength)
		{
			int count = -1;
			return GetByMaDonGiaNhomNganh(transactionManager, _maDonGiaNhomNganh, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__DonGiaNh__6C4D3F4DAEC7DC52 index.
		/// </summary>
		/// <param name="_maDonGiaNhomNganh"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaNhomNganh"/> class.</returns>
		public PMS.Entities.DonGiaNhomNganh GetByMaDonGiaNhomNganh(System.Int32 _maDonGiaNhomNganh, int start, int pageLength, out int count)
		{
			return GetByMaDonGiaNhomNganh(null, _maDonGiaNhomNganh, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__DonGiaNh__6C4D3F4DAEC7DC52 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDonGiaNhomNganh"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaNhomNganh"/> class.</returns>
		public abstract PMS.Entities.DonGiaNhomNganh GetByMaDonGiaNhomNganh(TransactionManager transactionManager, System.Int32 _maDonGiaNhomNganh, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;DonGiaNhomNganh&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;DonGiaNhomNganh&gt;"/></returns>
		public static TList<DonGiaNhomNganh> Fill(IDataReader reader, TList<DonGiaNhomNganh> rows, int start, int pageLength)
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
				
				PMS.Entities.DonGiaNhomNganh c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("DonGiaNhomNganh")
					.Append("|").Append((System.Int32)reader[((int)DonGiaNhomNganhColumn.MaDonGiaNhomNganh - 1)]).ToString();
					c = EntityManager.LocateOrCreate<DonGiaNhomNganh>(
					key.ToString(), // EntityTrackingKey
					"DonGiaNhomNganh",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.DonGiaNhomNganh();
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
					c.MaDonGiaNhomNganh = (System.Int32)reader[(DonGiaNhomNganhColumn.MaDonGiaNhomNganh.ToString())];
					c.MaQuanLy = (reader[DonGiaNhomNganhColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaNhomNganhColumn.MaQuanLy.ToString())];
					c.MaTenNhomNganh = (reader[DonGiaNhomNganhColumn.MaTenNhomNganh.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaNhomNganhColumn.MaTenNhomNganh.ToString())];
					c.GiaTri = (reader[DonGiaNhomNganhColumn.GiaTri.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DonGiaNhomNganhColumn.GiaTri.ToString())];
					c.GhiChu = (reader[DonGiaNhomNganhColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaNhomNganhColumn.GhiChu.ToString())];
					c.TinhTrang = (reader[DonGiaNhomNganhColumn.TinhTrang.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(DonGiaNhomNganhColumn.TinhTrang.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DonGiaNhomNganh"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DonGiaNhomNganh"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.DonGiaNhomNganh entity)
		{
			if (!reader.Read()) return;
			
			entity.MaDonGiaNhomNganh = (System.Int32)reader[(DonGiaNhomNganhColumn.MaDonGiaNhomNganh.ToString())];
			entity.MaQuanLy = (reader[DonGiaNhomNganhColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaNhomNganhColumn.MaQuanLy.ToString())];
			entity.MaTenNhomNganh = (reader[DonGiaNhomNganhColumn.MaTenNhomNganh.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaNhomNganhColumn.MaTenNhomNganh.ToString())];
			entity.GiaTri = (reader[DonGiaNhomNganhColumn.GiaTri.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DonGiaNhomNganhColumn.GiaTri.ToString())];
			entity.GhiChu = (reader[DonGiaNhomNganhColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaNhomNganhColumn.GhiChu.ToString())];
			entity.TinhTrang = (reader[DonGiaNhomNganhColumn.TinhTrang.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(DonGiaNhomNganhColumn.TinhTrang.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DonGiaNhomNganh"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DonGiaNhomNganh"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.DonGiaNhomNganh entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaDonGiaNhomNganh = (System.Int32)dataRow["MaDonGiaNhomNganh"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.MaTenNhomNganh = Convert.IsDBNull(dataRow["MaTenNhomNganh"]) ? null : (System.String)dataRow["MaTenNhomNganh"];
			entity.GiaTri = Convert.IsDBNull(dataRow["GiaTri"]) ? null : (System.Int32?)dataRow["GiaTri"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
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
		/// <param name="entity">The <see cref="PMS.Entities.DonGiaNhomNganh"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.DonGiaNhomNganh Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.DonGiaNhomNganh entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.DonGiaNhomNganh object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.DonGiaNhomNganh instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.DonGiaNhomNganh Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.DonGiaNhomNganh entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region DonGiaNhomNganhChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.DonGiaNhomNganh</c>
	///</summary>
	public enum DonGiaNhomNganhChildEntityTypes
	{
	}
	
	#endregion DonGiaNhomNganhChildEntityTypes
	
	#region DonGiaNhomNganhFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;DonGiaNhomNganhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaNhomNganh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaNhomNganhFilterBuilder : SqlFilterBuilder<DonGiaNhomNganhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaNhomNganhFilterBuilder class.
		/// </summary>
		public DonGiaNhomNganhFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DonGiaNhomNganhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DonGiaNhomNganhFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DonGiaNhomNganhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DonGiaNhomNganhFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DonGiaNhomNganhFilterBuilder
	
	#region DonGiaNhomNganhParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;DonGiaNhomNganhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaNhomNganh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaNhomNganhParameterBuilder : ParameterizedSqlFilterBuilder<DonGiaNhomNganhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaNhomNganhParameterBuilder class.
		/// </summary>
		public DonGiaNhomNganhParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DonGiaNhomNganhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DonGiaNhomNganhParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DonGiaNhomNganhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DonGiaNhomNganhParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DonGiaNhomNganhParameterBuilder
	
	#region DonGiaNhomNganhSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;DonGiaNhomNganhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaNhomNganh"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class DonGiaNhomNganhSortBuilder : SqlSortBuilder<DonGiaNhomNganhColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaNhomNganhSqlSortBuilder class.
		/// </summary>
		public DonGiaNhomNganhSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion DonGiaNhomNganhSortBuilder
	
} // end namespace
