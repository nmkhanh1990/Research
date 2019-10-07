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
	/// This class is the base class for any <see cref="NhomGiangVienTinhDinhMucProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class NhomGiangVienTinhDinhMucProviderBaseCore : EntityProviderBase<PMS.Entities.NhomGiangVienTinhDinhMuc, PMS.Entities.NhomGiangVienTinhDinhMucKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.NhomGiangVienTinhDinhMucKey key)
		{
			return Delete(transactionManager, key.MaNhomGiangVien);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maNhomGiangVien">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _maNhomGiangVien)
		{
			return Delete(null, _maNhomGiangVien);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomGiangVien">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _maNhomGiangVien);		
		
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
		public override PMS.Entities.NhomGiangVienTinhDinhMuc Get(TransactionManager transactionManager, PMS.Entities.NhomGiangVienTinhDinhMucKey key, int start, int pageLength)
		{
			return GetByMaNhomGiangVien(transactionManager, key.MaNhomGiangVien, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__NhomGian__EF82F5D3A0F76D0F index.
		/// </summary>
		/// <param name="_maNhomGiangVien"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomGiangVienTinhDinhMuc"/> class.</returns>
		public PMS.Entities.NhomGiangVienTinhDinhMuc GetByMaNhomGiangVien(System.String _maNhomGiangVien)
		{
			int count = -1;
			return GetByMaNhomGiangVien(null,_maNhomGiangVien, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__NhomGian__EF82F5D3A0F76D0F index.
		/// </summary>
		/// <param name="_maNhomGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomGiangVienTinhDinhMuc"/> class.</returns>
		public PMS.Entities.NhomGiangVienTinhDinhMuc GetByMaNhomGiangVien(System.String _maNhomGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNhomGiangVien(null, _maNhomGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__NhomGian__EF82F5D3A0F76D0F index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomGiangVienTinhDinhMuc"/> class.</returns>
		public PMS.Entities.NhomGiangVienTinhDinhMuc GetByMaNhomGiangVien(TransactionManager transactionManager, System.String _maNhomGiangVien)
		{
			int count = -1;
			return GetByMaNhomGiangVien(transactionManager, _maNhomGiangVien, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__NhomGian__EF82F5D3A0F76D0F index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomGiangVienTinhDinhMuc"/> class.</returns>
		public PMS.Entities.NhomGiangVienTinhDinhMuc GetByMaNhomGiangVien(TransactionManager transactionManager, System.String _maNhomGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNhomGiangVien(transactionManager, _maNhomGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__NhomGian__EF82F5D3A0F76D0F index.
		/// </summary>
		/// <param name="_maNhomGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomGiangVienTinhDinhMuc"/> class.</returns>
		public PMS.Entities.NhomGiangVienTinhDinhMuc GetByMaNhomGiangVien(System.String _maNhomGiangVien, int start, int pageLength, out int count)
		{
			return GetByMaNhomGiangVien(null, _maNhomGiangVien, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__NhomGian__EF82F5D3A0F76D0F index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomGiangVienTinhDinhMuc"/> class.</returns>
		public abstract PMS.Entities.NhomGiangVienTinhDinhMuc GetByMaNhomGiangVien(TransactionManager transactionManager, System.String _maNhomGiangVien, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;NhomGiangVienTinhDinhMuc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;NhomGiangVienTinhDinhMuc&gt;"/></returns>
		public static TList<NhomGiangVienTinhDinhMuc> Fill(IDataReader reader, TList<NhomGiangVienTinhDinhMuc> rows, int start, int pageLength)
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
				
				PMS.Entities.NhomGiangVienTinhDinhMuc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("NhomGiangVienTinhDinhMuc")
					.Append("|").Append((System.String)reader[((int)NhomGiangVienTinhDinhMucColumn.MaNhomGiangVien - 1)]).ToString();
					c = EntityManager.LocateOrCreate<NhomGiangVienTinhDinhMuc>(
					key.ToString(), // EntityTrackingKey
					"NhomGiangVienTinhDinhMuc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.NhomGiangVienTinhDinhMuc();
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
					c.MaNhomGiangVien = (System.String)reader[(NhomGiangVienTinhDinhMucColumn.MaNhomGiangVien.ToString())];
					c.OriginalMaNhomGiangVien = c.MaNhomGiangVien;
					c.TenNhomGiangVien = (reader[NhomGiangVienTinhDinhMucColumn.TenNhomGiangVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(NhomGiangVienTinhDinhMucColumn.TenNhomGiangVien.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.NhomGiangVienTinhDinhMuc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.NhomGiangVienTinhDinhMuc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.NhomGiangVienTinhDinhMuc entity)
		{
			if (!reader.Read()) return;
			
			entity.MaNhomGiangVien = (System.String)reader[(NhomGiangVienTinhDinhMucColumn.MaNhomGiangVien.ToString())];
			entity.OriginalMaNhomGiangVien = (System.String)reader["MaNhomGiangVien"];
			entity.TenNhomGiangVien = (reader[NhomGiangVienTinhDinhMucColumn.TenNhomGiangVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(NhomGiangVienTinhDinhMucColumn.TenNhomGiangVien.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.NhomGiangVienTinhDinhMuc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.NhomGiangVienTinhDinhMuc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.NhomGiangVienTinhDinhMuc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaNhomGiangVien = (System.String)dataRow["MaNhomGiangVien"];
			entity.OriginalMaNhomGiangVien = (System.String)dataRow["MaNhomGiangVien"];
			entity.TenNhomGiangVien = Convert.IsDBNull(dataRow["TenNhomGiangVien"]) ? null : (System.String)dataRow["TenNhomGiangVien"];
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
		/// <param name="entity">The <see cref="PMS.Entities.NhomGiangVienTinhDinhMuc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.NhomGiangVienTinhDinhMuc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.NhomGiangVienTinhDinhMuc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.NhomGiangVienTinhDinhMuc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.NhomGiangVienTinhDinhMuc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.NhomGiangVienTinhDinhMuc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.NhomGiangVienTinhDinhMuc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region NhomGiangVienTinhDinhMucChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.NhomGiangVienTinhDinhMuc</c>
	///</summary>
	public enum NhomGiangVienTinhDinhMucChildEntityTypes
	{
	}
	
	#endregion NhomGiangVienTinhDinhMucChildEntityTypes
	
	#region NhomGiangVienTinhDinhMucFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;NhomGiangVienTinhDinhMucColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomGiangVienTinhDinhMuc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NhomGiangVienTinhDinhMucFilterBuilder : SqlFilterBuilder<NhomGiangVienTinhDinhMucColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomGiangVienTinhDinhMucFilterBuilder class.
		/// </summary>
		public NhomGiangVienTinhDinhMucFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NhomGiangVienTinhDinhMucFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NhomGiangVienTinhDinhMucFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NhomGiangVienTinhDinhMucFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NhomGiangVienTinhDinhMucFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NhomGiangVienTinhDinhMucFilterBuilder
	
	#region NhomGiangVienTinhDinhMucParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;NhomGiangVienTinhDinhMucColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomGiangVienTinhDinhMuc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NhomGiangVienTinhDinhMucParameterBuilder : ParameterizedSqlFilterBuilder<NhomGiangVienTinhDinhMucColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomGiangVienTinhDinhMucParameterBuilder class.
		/// </summary>
		public NhomGiangVienTinhDinhMucParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NhomGiangVienTinhDinhMucParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NhomGiangVienTinhDinhMucParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NhomGiangVienTinhDinhMucParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NhomGiangVienTinhDinhMucParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NhomGiangVienTinhDinhMucParameterBuilder
	
	#region NhomGiangVienTinhDinhMucSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;NhomGiangVienTinhDinhMucColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomGiangVienTinhDinhMuc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class NhomGiangVienTinhDinhMucSortBuilder : SqlSortBuilder<NhomGiangVienTinhDinhMucColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomGiangVienTinhDinhMucSqlSortBuilder class.
		/// </summary>
		public NhomGiangVienTinhDinhMucSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion NhomGiangVienTinhDinhMucSortBuilder
	
} // end namespace
