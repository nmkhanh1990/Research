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
	/// This class is the base class for any <see cref="LoaiThucHienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class LoaiThucHienProviderBaseCore : EntityProviderBase<PMS.Entities.LoaiThucHien, PMS.Entities.LoaiThucHienKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.LoaiThucHienKey key)
		{
			return Delete(transactionManager, key.MaLoaiThucHien);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maLoaiThucHien">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maLoaiThucHien)
		{
			return Delete(null, _maLoaiThucHien);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiThucHien">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maLoaiThucHien);		
		
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
		public override PMS.Entities.LoaiThucHien Get(TransactionManager transactionManager, PMS.Entities.LoaiThucHienKey key, int start, int pageLength)
		{
			return GetByMaLoaiThucHien(transactionManager, key.MaLoaiThucHien, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__LoaiThuc__F6BDE78BF1836182 index.
		/// </summary>
		/// <param name="_maLoaiThucHien"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiThucHien"/> class.</returns>
		public PMS.Entities.LoaiThucHien GetByMaLoaiThucHien(System.Int32 _maLoaiThucHien)
		{
			int count = -1;
			return GetByMaLoaiThucHien(null,_maLoaiThucHien, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LoaiThuc__F6BDE78BF1836182 index.
		/// </summary>
		/// <param name="_maLoaiThucHien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiThucHien"/> class.</returns>
		public PMS.Entities.LoaiThucHien GetByMaLoaiThucHien(System.Int32 _maLoaiThucHien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiThucHien(null, _maLoaiThucHien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LoaiThuc__F6BDE78BF1836182 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiThucHien"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiThucHien"/> class.</returns>
		public PMS.Entities.LoaiThucHien GetByMaLoaiThucHien(TransactionManager transactionManager, System.Int32 _maLoaiThucHien)
		{
			int count = -1;
			return GetByMaLoaiThucHien(transactionManager, _maLoaiThucHien, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LoaiThuc__F6BDE78BF1836182 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiThucHien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiThucHien"/> class.</returns>
		public PMS.Entities.LoaiThucHien GetByMaLoaiThucHien(TransactionManager transactionManager, System.Int32 _maLoaiThucHien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiThucHien(transactionManager, _maLoaiThucHien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LoaiThuc__F6BDE78BF1836182 index.
		/// </summary>
		/// <param name="_maLoaiThucHien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiThucHien"/> class.</returns>
		public PMS.Entities.LoaiThucHien GetByMaLoaiThucHien(System.Int32 _maLoaiThucHien, int start, int pageLength, out int count)
		{
			return GetByMaLoaiThucHien(null, _maLoaiThucHien, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LoaiThuc__F6BDE78BF1836182 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiThucHien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiThucHien"/> class.</returns>
		public abstract PMS.Entities.LoaiThucHien GetByMaLoaiThucHien(TransactionManager transactionManager, System.Int32 _maLoaiThucHien, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;LoaiThucHien&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;LoaiThucHien&gt;"/></returns>
		public static TList<LoaiThucHien> Fill(IDataReader reader, TList<LoaiThucHien> rows, int start, int pageLength)
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
				
				PMS.Entities.LoaiThucHien c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("LoaiThucHien")
					.Append("|").Append((System.Int32)reader[((int)LoaiThucHienColumn.MaLoaiThucHien - 1)]).ToString();
					c = EntityManager.LocateOrCreate<LoaiThucHien>(
					key.ToString(), // EntityTrackingKey
					"LoaiThucHien",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.LoaiThucHien();
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
					c.MaLoaiThucHien = (System.Int32)reader[(LoaiThucHienColumn.MaLoaiThucHien.ToString())];
					c.TenLoaiThucHien = (reader[LoaiThucHienColumn.TenLoaiThucHien.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiThucHienColumn.TenLoaiThucHien.ToString())];
					c.NgayThucHien = (reader[LoaiThucHienColumn.NgayThucHien.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(LoaiThucHienColumn.NgayThucHien.ToString())];
					c.NguoiThucHien = (reader[LoaiThucHienColumn.NguoiThucHien.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiThucHienColumn.NguoiThucHien.ToString())];
					c.TrangThaiDung = (reader[LoaiThucHienColumn.TrangThaiDung.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(LoaiThucHienColumn.TrangThaiDung.ToString())];
					c.GhiChu = (reader[LoaiThucHienColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiThucHienColumn.GhiChu.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LoaiThucHien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LoaiThucHien"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.LoaiThucHien entity)
		{
			if (!reader.Read()) return;
			
			entity.MaLoaiThucHien = (System.Int32)reader[(LoaiThucHienColumn.MaLoaiThucHien.ToString())];
			entity.TenLoaiThucHien = (reader[LoaiThucHienColumn.TenLoaiThucHien.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiThucHienColumn.TenLoaiThucHien.ToString())];
			entity.NgayThucHien = (reader[LoaiThucHienColumn.NgayThucHien.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(LoaiThucHienColumn.NgayThucHien.ToString())];
			entity.NguoiThucHien = (reader[LoaiThucHienColumn.NguoiThucHien.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiThucHienColumn.NguoiThucHien.ToString())];
			entity.TrangThaiDung = (reader[LoaiThucHienColumn.TrangThaiDung.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(LoaiThucHienColumn.TrangThaiDung.ToString())];
			entity.GhiChu = (reader[LoaiThucHienColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiThucHienColumn.GhiChu.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LoaiThucHien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LoaiThucHien"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.LoaiThucHien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLoaiThucHien = (System.Int32)dataRow["MaLoaiThucHien"];
			entity.TenLoaiThucHien = Convert.IsDBNull(dataRow["TenLoaiThucHien"]) ? null : (System.String)dataRow["TenLoaiThucHien"];
			entity.NgayThucHien = Convert.IsDBNull(dataRow["NgayThucHien"]) ? null : (System.DateTime?)dataRow["NgayThucHien"];
			entity.NguoiThucHien = Convert.IsDBNull(dataRow["NguoiThucHien"]) ? null : (System.String)dataRow["NguoiThucHien"];
			entity.TrangThaiDung = Convert.IsDBNull(dataRow["TrangThaiDung"]) ? null : (System.Boolean?)dataRow["TrangThaiDung"];
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
		/// <param name="entity">The <see cref="PMS.Entities.LoaiThucHien"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.LoaiThucHien Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.LoaiThucHien entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.LoaiThucHien object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.LoaiThucHien instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.LoaiThucHien Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.LoaiThucHien entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region LoaiThucHienChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.LoaiThucHien</c>
	///</summary>
	public enum LoaiThucHienChildEntityTypes
	{
	}
	
	#endregion LoaiThucHienChildEntityTypes
	
	#region LoaiThucHienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;LoaiThucHienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiThucHien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiThucHienFilterBuilder : SqlFilterBuilder<LoaiThucHienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiThucHienFilterBuilder class.
		/// </summary>
		public LoaiThucHienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LoaiThucHienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LoaiThucHienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LoaiThucHienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LoaiThucHienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LoaiThucHienFilterBuilder
	
	#region LoaiThucHienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;LoaiThucHienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiThucHien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiThucHienParameterBuilder : ParameterizedSqlFilterBuilder<LoaiThucHienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiThucHienParameterBuilder class.
		/// </summary>
		public LoaiThucHienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LoaiThucHienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LoaiThucHienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LoaiThucHienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LoaiThucHienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LoaiThucHienParameterBuilder
	
	#region LoaiThucHienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;LoaiThucHienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiThucHien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class LoaiThucHienSortBuilder : SqlSortBuilder<LoaiThucHienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiThucHienSqlSortBuilder class.
		/// </summary>
		public LoaiThucHienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion LoaiThucHienSortBuilder
	
} // end namespace
