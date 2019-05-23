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
	/// This class is the base class for any <see cref="LoaiCongThucProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class LoaiCongThucProviderBaseCore : EntityProviderBase<PMS.Entities.LoaiCongThuc, PMS.Entities.LoaiCongThucKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.LoaiCongThucKey key)
		{
			return Delete(transactionManager, key.MaLoaiCongThuc);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maLoaiCongThuc">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _maLoaiCongThuc)
		{
			return Delete(null, _maLoaiCongThuc);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiCongThuc">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _maLoaiCongThuc);		
		
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
		public override PMS.Entities.LoaiCongThuc Get(TransactionManager transactionManager, PMS.Entities.LoaiCongThucKey key, int start, int pageLength)
		{
			return GetByMaLoaiCongThuc(transactionManager, key.MaLoaiCongThuc, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__LoaiCong__A1B2EF8DFCE01227 index.
		/// </summary>
		/// <param name="_maLoaiCongThuc"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiCongThuc"/> class.</returns>
		public PMS.Entities.LoaiCongThuc GetByMaLoaiCongThuc(System.String _maLoaiCongThuc)
		{
			int count = -1;
			return GetByMaLoaiCongThuc(null,_maLoaiCongThuc, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LoaiCong__A1B2EF8DFCE01227 index.
		/// </summary>
		/// <param name="_maLoaiCongThuc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiCongThuc"/> class.</returns>
		public PMS.Entities.LoaiCongThuc GetByMaLoaiCongThuc(System.String _maLoaiCongThuc, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiCongThuc(null, _maLoaiCongThuc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LoaiCong__A1B2EF8DFCE01227 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiCongThuc"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiCongThuc"/> class.</returns>
		public PMS.Entities.LoaiCongThuc GetByMaLoaiCongThuc(TransactionManager transactionManager, System.String _maLoaiCongThuc)
		{
			int count = -1;
			return GetByMaLoaiCongThuc(transactionManager, _maLoaiCongThuc, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LoaiCong__A1B2EF8DFCE01227 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiCongThuc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiCongThuc"/> class.</returns>
		public PMS.Entities.LoaiCongThuc GetByMaLoaiCongThuc(TransactionManager transactionManager, System.String _maLoaiCongThuc, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiCongThuc(transactionManager, _maLoaiCongThuc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LoaiCong__A1B2EF8DFCE01227 index.
		/// </summary>
		/// <param name="_maLoaiCongThuc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiCongThuc"/> class.</returns>
		public PMS.Entities.LoaiCongThuc GetByMaLoaiCongThuc(System.String _maLoaiCongThuc, int start, int pageLength, out int count)
		{
			return GetByMaLoaiCongThuc(null, _maLoaiCongThuc, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LoaiCong__A1B2EF8DFCE01227 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiCongThuc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiCongThuc"/> class.</returns>
		public abstract PMS.Entities.LoaiCongThuc GetByMaLoaiCongThuc(TransactionManager transactionManager, System.String _maLoaiCongThuc, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;LoaiCongThuc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;LoaiCongThuc&gt;"/></returns>
		public static TList<LoaiCongThuc> Fill(IDataReader reader, TList<LoaiCongThuc> rows, int start, int pageLength)
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
				
				PMS.Entities.LoaiCongThuc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("LoaiCongThuc")
					.Append("|").Append((System.String)reader[((int)LoaiCongThucColumn.MaLoaiCongThuc - 1)]).ToString();
					c = EntityManager.LocateOrCreate<LoaiCongThuc>(
					key.ToString(), // EntityTrackingKey
					"LoaiCongThuc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.LoaiCongThuc();
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
					c.MaLoaiCongThuc = (System.String)reader[(LoaiCongThucColumn.MaLoaiCongThuc.ToString())];
					c.OriginalMaLoaiCongThuc = c.MaLoaiCongThuc;
					c.TenLoaiCongThuc = (reader[LoaiCongThucColumn.TenLoaiCongThuc.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiCongThucColumn.TenLoaiCongThuc.ToString())];
					c.GhiChu = (reader[LoaiCongThucColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiCongThucColumn.GhiChu.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LoaiCongThuc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LoaiCongThuc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.LoaiCongThuc entity)
		{
			if (!reader.Read()) return;
			
			entity.MaLoaiCongThuc = (System.String)reader[(LoaiCongThucColumn.MaLoaiCongThuc.ToString())];
			entity.OriginalMaLoaiCongThuc = (System.String)reader["MaLoaiCongThuc"];
			entity.TenLoaiCongThuc = (reader[LoaiCongThucColumn.TenLoaiCongThuc.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiCongThucColumn.TenLoaiCongThuc.ToString())];
			entity.GhiChu = (reader[LoaiCongThucColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiCongThucColumn.GhiChu.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LoaiCongThuc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LoaiCongThuc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.LoaiCongThuc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLoaiCongThuc = (System.String)dataRow["MaLoaiCongThuc"];
			entity.OriginalMaLoaiCongThuc = (System.String)dataRow["MaLoaiCongThuc"];
			entity.TenLoaiCongThuc = Convert.IsDBNull(dataRow["TenLoaiCongThuc"]) ? null : (System.String)dataRow["TenLoaiCongThuc"];
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
		/// <param name="entity">The <see cref="PMS.Entities.LoaiCongThuc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.LoaiCongThuc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.LoaiCongThuc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaLoaiCongThuc methods when available
			
			#region CongThucTinhQuyDoiCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CongThucTinhQuyDoi>|CongThucTinhQuyDoiCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CongThucTinhQuyDoiCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CongThucTinhQuyDoiCollection = DataRepository.CongThucTinhQuyDoiProvider.GetByMaLoaiCongThuc(transactionManager, entity.MaLoaiCongThuc);

				if (deep && entity.CongThucTinhQuyDoiCollection.Count > 0)
				{
					deepHandles.Add("CongThucTinhQuyDoiCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CongThucTinhQuyDoi>) DataRepository.CongThucTinhQuyDoiProvider.DeepLoad,
						new object[] { transactionManager, entity.CongThucTinhQuyDoiCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
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
		/// Deep Save the entire object graph of the PMS.Entities.LoaiCongThuc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.LoaiCongThuc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.LoaiCongThuc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.LoaiCongThuc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<CongThucTinhQuyDoi>
				if (CanDeepSave(entity.CongThucTinhQuyDoiCollection, "List<CongThucTinhQuyDoi>|CongThucTinhQuyDoiCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CongThucTinhQuyDoi child in entity.CongThucTinhQuyDoiCollection)
					{
						if(child.MaLoaiCongThucSource != null)
						{
							child.MaLoaiCongThuc = child.MaLoaiCongThucSource.MaLoaiCongThuc;
						}
						else
						{
							child.MaLoaiCongThuc = entity.MaLoaiCongThuc;
						}

					}

					if (entity.CongThucTinhQuyDoiCollection.Count > 0 || entity.CongThucTinhQuyDoiCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CongThucTinhQuyDoiProvider.Save(transactionManager, entity.CongThucTinhQuyDoiCollection);
						
						deepHandles.Add("CongThucTinhQuyDoiCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CongThucTinhQuyDoi >) DataRepository.CongThucTinhQuyDoiProvider.DeepSave,
							new object[] { transactionManager, entity.CongThucTinhQuyDoiCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
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
	
	#region LoaiCongThucChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.LoaiCongThuc</c>
	///</summary>
	public enum LoaiCongThucChildEntityTypes
	{
		///<summary>
		/// Collection of <c>LoaiCongThuc</c> as OneToMany for CongThucTinhQuyDoiCollection
		///</summary>
		[ChildEntityType(typeof(TList<CongThucTinhQuyDoi>))]
		CongThucTinhQuyDoiCollection,
	}
	
	#endregion LoaiCongThucChildEntityTypes
	
	#region LoaiCongThucFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;LoaiCongThucColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiCongThuc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiCongThucFilterBuilder : SqlFilterBuilder<LoaiCongThucColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiCongThucFilterBuilder class.
		/// </summary>
		public LoaiCongThucFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LoaiCongThucFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LoaiCongThucFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LoaiCongThucFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LoaiCongThucFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LoaiCongThucFilterBuilder
	
	#region LoaiCongThucParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;LoaiCongThucColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiCongThuc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiCongThucParameterBuilder : ParameterizedSqlFilterBuilder<LoaiCongThucColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiCongThucParameterBuilder class.
		/// </summary>
		public LoaiCongThucParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LoaiCongThucParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LoaiCongThucParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LoaiCongThucParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LoaiCongThucParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LoaiCongThucParameterBuilder
	
	#region LoaiCongThucSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;LoaiCongThucColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiCongThuc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class LoaiCongThucSortBuilder : SqlSortBuilder<LoaiCongThucColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiCongThucSqlSortBuilder class.
		/// </summary>
		public LoaiCongThucSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion LoaiCongThucSortBuilder
	
} // end namespace
