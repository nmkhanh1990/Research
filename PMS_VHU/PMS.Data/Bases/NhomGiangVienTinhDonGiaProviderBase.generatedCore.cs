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
	/// This class is the base class for any <see cref="NhomGiangVienTinhDonGiaProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class NhomGiangVienTinhDonGiaProviderBaseCore : EntityProviderBase<PMS.Entities.NhomGiangVienTinhDonGia, PMS.Entities.NhomGiangVienTinhDonGiaKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.NhomGiangVienTinhDonGiaKey key)
		{
			return Delete(transactionManager, key.MaNhom);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maNhom">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _maNhom)
		{
			return Delete(null, _maNhom);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhom">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _maNhom);		
		
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
		public override PMS.Entities.NhomGiangVienTinhDonGia Get(TransactionManager transactionManager, PMS.Entities.NhomGiangVienTinhDonGiaKey key, int start, int pageLength)
		{
			return GetByMaNhom(transactionManager, key.MaNhom, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__NhomGian__234F91CDE891B99E index.
		/// </summary>
		/// <param name="_maNhom"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomGiangVienTinhDonGia"/> class.</returns>
		public PMS.Entities.NhomGiangVienTinhDonGia GetByMaNhom(System.String _maNhom)
		{
			int count = -1;
			return GetByMaNhom(null,_maNhom, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__NhomGian__234F91CDE891B99E index.
		/// </summary>
		/// <param name="_maNhom"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomGiangVienTinhDonGia"/> class.</returns>
		public PMS.Entities.NhomGiangVienTinhDonGia GetByMaNhom(System.String _maNhom, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNhom(null, _maNhom, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__NhomGian__234F91CDE891B99E index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhom"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomGiangVienTinhDonGia"/> class.</returns>
		public PMS.Entities.NhomGiangVienTinhDonGia GetByMaNhom(TransactionManager transactionManager, System.String _maNhom)
		{
			int count = -1;
			return GetByMaNhom(transactionManager, _maNhom, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__NhomGian__234F91CDE891B99E index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhom"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomGiangVienTinhDonGia"/> class.</returns>
		public PMS.Entities.NhomGiangVienTinhDonGia GetByMaNhom(TransactionManager transactionManager, System.String _maNhom, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNhom(transactionManager, _maNhom, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__NhomGian__234F91CDE891B99E index.
		/// </summary>
		/// <param name="_maNhom"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomGiangVienTinhDonGia"/> class.</returns>
		public PMS.Entities.NhomGiangVienTinhDonGia GetByMaNhom(System.String _maNhom, int start, int pageLength, out int count)
		{
			return GetByMaNhom(null, _maNhom, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__NhomGian__234F91CDE891B99E index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhom"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomGiangVienTinhDonGia"/> class.</returns>
		public abstract PMS.Entities.NhomGiangVienTinhDonGia GetByMaNhom(TransactionManager transactionManager, System.String _maNhom, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;NhomGiangVienTinhDonGia&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;NhomGiangVienTinhDonGia&gt;"/></returns>
		public static TList<NhomGiangVienTinhDonGia> Fill(IDataReader reader, TList<NhomGiangVienTinhDonGia> rows, int start, int pageLength)
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
				
				PMS.Entities.NhomGiangVienTinhDonGia c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("NhomGiangVienTinhDonGia")
					.Append("|").Append((System.String)reader[((int)NhomGiangVienTinhDonGiaColumn.MaNhom - 1)]).ToString();
					c = EntityManager.LocateOrCreate<NhomGiangVienTinhDonGia>(
					key.ToString(), // EntityTrackingKey
					"NhomGiangVienTinhDonGia",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.NhomGiangVienTinhDonGia();
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
					c.MaNhom = (System.String)reader[(NhomGiangVienTinhDonGiaColumn.MaNhom.ToString())];
					c.OriginalMaNhom = c.MaNhom;
					c.TenNhom = (reader[NhomGiangVienTinhDonGiaColumn.TenNhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(NhomGiangVienTinhDonGiaColumn.TenNhom.ToString())];
					c.GhiChu = (reader[NhomGiangVienTinhDonGiaColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(NhomGiangVienTinhDonGiaColumn.GhiChu.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.NhomGiangVienTinhDonGia"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.NhomGiangVienTinhDonGia"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.NhomGiangVienTinhDonGia entity)
		{
			if (!reader.Read()) return;
			
			entity.MaNhom = (System.String)reader[(NhomGiangVienTinhDonGiaColumn.MaNhom.ToString())];
			entity.OriginalMaNhom = (System.String)reader["MaNhom"];
			entity.TenNhom = (reader[NhomGiangVienTinhDonGiaColumn.TenNhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(NhomGiangVienTinhDonGiaColumn.TenNhom.ToString())];
			entity.GhiChu = (reader[NhomGiangVienTinhDonGiaColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(NhomGiangVienTinhDonGiaColumn.GhiChu.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.NhomGiangVienTinhDonGia"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.NhomGiangVienTinhDonGia"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.NhomGiangVienTinhDonGia entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaNhom = (System.String)dataRow["MaNhom"];
			entity.OriginalMaNhom = (System.String)dataRow["MaNhom"];
			entity.TenNhom = Convert.IsDBNull(dataRow["TenNhom"]) ? null : (System.String)dataRow["TenNhom"];
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
		/// <param name="entity">The <see cref="PMS.Entities.NhomGiangVienTinhDonGia"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.NhomGiangVienTinhDonGia Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.NhomGiangVienTinhDonGia entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.NhomGiangVienTinhDonGia object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.NhomGiangVienTinhDonGia instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.NhomGiangVienTinhDonGia Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.NhomGiangVienTinhDonGia entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region NhomGiangVienTinhDonGiaChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.NhomGiangVienTinhDonGia</c>
	///</summary>
	public enum NhomGiangVienTinhDonGiaChildEntityTypes
	{
	}
	
	#endregion NhomGiangVienTinhDonGiaChildEntityTypes
	
	#region NhomGiangVienTinhDonGiaFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;NhomGiangVienTinhDonGiaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomGiangVienTinhDonGia"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NhomGiangVienTinhDonGiaFilterBuilder : SqlFilterBuilder<NhomGiangVienTinhDonGiaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomGiangVienTinhDonGiaFilterBuilder class.
		/// </summary>
		public NhomGiangVienTinhDonGiaFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NhomGiangVienTinhDonGiaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NhomGiangVienTinhDonGiaFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NhomGiangVienTinhDonGiaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NhomGiangVienTinhDonGiaFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NhomGiangVienTinhDonGiaFilterBuilder
	
	#region NhomGiangVienTinhDonGiaParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;NhomGiangVienTinhDonGiaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomGiangVienTinhDonGia"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NhomGiangVienTinhDonGiaParameterBuilder : ParameterizedSqlFilterBuilder<NhomGiangVienTinhDonGiaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomGiangVienTinhDonGiaParameterBuilder class.
		/// </summary>
		public NhomGiangVienTinhDonGiaParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NhomGiangVienTinhDonGiaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NhomGiangVienTinhDonGiaParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NhomGiangVienTinhDonGiaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NhomGiangVienTinhDonGiaParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NhomGiangVienTinhDonGiaParameterBuilder
	
	#region NhomGiangVienTinhDonGiaSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;NhomGiangVienTinhDonGiaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomGiangVienTinhDonGia"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class NhomGiangVienTinhDonGiaSortBuilder : SqlSortBuilder<NhomGiangVienTinhDonGiaColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomGiangVienTinhDonGiaSqlSortBuilder class.
		/// </summary>
		public NhomGiangVienTinhDonGiaSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion NhomGiangVienTinhDonGiaSortBuilder
	
} // end namespace