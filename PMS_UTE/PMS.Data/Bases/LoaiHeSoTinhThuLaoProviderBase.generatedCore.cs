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
	/// This class is the base class for any <see cref="LoaiHeSoTinhThuLaoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class LoaiHeSoTinhThuLaoProviderBaseCore : EntityProviderBase<PMS.Entities.LoaiHeSoTinhThuLao, PMS.Entities.LoaiHeSoTinhThuLaoKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.LoaiHeSoTinhThuLaoKey key)
		{
			return Delete(transactionManager, key.MaLoaiHeSo);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maLoaiHeSo">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maLoaiHeSo)
		{
			return Delete(null, _maLoaiHeSo);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiHeSo">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maLoaiHeSo);		
		
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
		public override PMS.Entities.LoaiHeSoTinhThuLao Get(TransactionManager transactionManager, PMS.Entities.LoaiHeSoTinhThuLaoKey key, int start, int pageLength)
		{
			return GetByMaLoaiHeSo(transactionManager, key.MaLoaiHeSo, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_LoaiHeSoTinhThuLao_1 index.
		/// </summary>
		/// <param name="_maLoaiHeSo"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiHeSoTinhThuLao"/> class.</returns>
		public PMS.Entities.LoaiHeSoTinhThuLao GetByMaLoaiHeSo(System.Int32 _maLoaiHeSo)
		{
			int count = -1;
			return GetByMaLoaiHeSo(null,_maLoaiHeSo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LoaiHeSoTinhThuLao_1 index.
		/// </summary>
		/// <param name="_maLoaiHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiHeSoTinhThuLao"/> class.</returns>
		public PMS.Entities.LoaiHeSoTinhThuLao GetByMaLoaiHeSo(System.Int32 _maLoaiHeSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiHeSo(null, _maLoaiHeSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LoaiHeSoTinhThuLao_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiHeSo"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiHeSoTinhThuLao"/> class.</returns>
		public PMS.Entities.LoaiHeSoTinhThuLao GetByMaLoaiHeSo(TransactionManager transactionManager, System.Int32 _maLoaiHeSo)
		{
			int count = -1;
			return GetByMaLoaiHeSo(transactionManager, _maLoaiHeSo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LoaiHeSoTinhThuLao_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiHeSoTinhThuLao"/> class.</returns>
		public PMS.Entities.LoaiHeSoTinhThuLao GetByMaLoaiHeSo(TransactionManager transactionManager, System.Int32 _maLoaiHeSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiHeSo(transactionManager, _maLoaiHeSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LoaiHeSoTinhThuLao_1 index.
		/// </summary>
		/// <param name="_maLoaiHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiHeSoTinhThuLao"/> class.</returns>
		public PMS.Entities.LoaiHeSoTinhThuLao GetByMaLoaiHeSo(System.Int32 _maLoaiHeSo, int start, int pageLength, out int count)
		{
			return GetByMaLoaiHeSo(null, _maLoaiHeSo, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LoaiHeSoTinhThuLao_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiHeSoTinhThuLao"/> class.</returns>
		public abstract PMS.Entities.LoaiHeSoTinhThuLao GetByMaLoaiHeSo(TransactionManager transactionManager, System.Int32 _maLoaiHeSo, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;LoaiHeSoTinhThuLao&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;LoaiHeSoTinhThuLao&gt;"/></returns>
		public static TList<LoaiHeSoTinhThuLao> Fill(IDataReader reader, TList<LoaiHeSoTinhThuLao> rows, int start, int pageLength)
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
				
				PMS.Entities.LoaiHeSoTinhThuLao c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("LoaiHeSoTinhThuLao")
					.Append("|").Append((System.Int32)reader[((int)LoaiHeSoTinhThuLaoColumn.MaLoaiHeSo - 1)]).ToString();
					c = EntityManager.LocateOrCreate<LoaiHeSoTinhThuLao>(
					key.ToString(), // EntityTrackingKey
					"LoaiHeSoTinhThuLao",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.LoaiHeSoTinhThuLao();
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
					c.MaLoaiHeSo = (System.Int32)reader[(LoaiHeSoTinhThuLaoColumn.MaLoaiHeSo.ToString())];
					c.MaQuanLy = (System.String)reader[(LoaiHeSoTinhThuLaoColumn.MaQuanLy.ToString())];
					c.TenLoaiHeSo = (reader[LoaiHeSoTinhThuLaoColumn.TenLoaiHeSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiHeSoTinhThuLaoColumn.TenLoaiHeSo.ToString())];
					c.TenBang = (reader[LoaiHeSoTinhThuLaoColumn.TenBang.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiHeSoTinhThuLaoColumn.TenBang.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LoaiHeSoTinhThuLao"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LoaiHeSoTinhThuLao"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.LoaiHeSoTinhThuLao entity)
		{
			if (!reader.Read()) return;
			
			entity.MaLoaiHeSo = (System.Int32)reader[(LoaiHeSoTinhThuLaoColumn.MaLoaiHeSo.ToString())];
			entity.MaQuanLy = (System.String)reader[(LoaiHeSoTinhThuLaoColumn.MaQuanLy.ToString())];
			entity.TenLoaiHeSo = (reader[LoaiHeSoTinhThuLaoColumn.TenLoaiHeSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiHeSoTinhThuLaoColumn.TenLoaiHeSo.ToString())];
			entity.TenBang = (reader[LoaiHeSoTinhThuLaoColumn.TenBang.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiHeSoTinhThuLaoColumn.TenBang.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LoaiHeSoTinhThuLao"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LoaiHeSoTinhThuLao"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.LoaiHeSoTinhThuLao entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLoaiHeSo = (System.Int32)dataRow["MaLoaiHeSo"];
			entity.MaQuanLy = (System.String)dataRow["MaQuanLy"];
			entity.TenLoaiHeSo = Convert.IsDBNull(dataRow["TenLoaiHeSo"]) ? null : (System.String)dataRow["TenLoaiHeSo"];
			entity.TenBang = Convert.IsDBNull(dataRow["TenBang"]) ? null : (System.String)dataRow["TenBang"];
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
		/// <param name="entity">The <see cref="PMS.Entities.LoaiHeSoTinhThuLao"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.LoaiHeSoTinhThuLao Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.LoaiHeSoTinhThuLao entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaLoaiHeSo methods when available
			
			#region CongThucTinhHeSoCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CongThucTinhHeSo>|CongThucTinhHeSoCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CongThucTinhHeSoCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CongThucTinhHeSoCollection = DataRepository.CongThucTinhHeSoProvider.GetByMaLoaiHeSo(transactionManager, entity.MaLoaiHeSo);

				if (deep && entity.CongThucTinhHeSoCollection.Count > 0)
				{
					deepHandles.Add("CongThucTinhHeSoCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CongThucTinhHeSo>) DataRepository.CongThucTinhHeSoProvider.DeepLoad,
						new object[] { transactionManager, entity.CongThucTinhHeSoCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.LoaiHeSoTinhThuLao object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.LoaiHeSoTinhThuLao instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.LoaiHeSoTinhThuLao Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.LoaiHeSoTinhThuLao entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<CongThucTinhHeSo>
				if (CanDeepSave(entity.CongThucTinhHeSoCollection, "List<CongThucTinhHeSo>|CongThucTinhHeSoCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CongThucTinhHeSo child in entity.CongThucTinhHeSoCollection)
					{
						if(child.MaLoaiHeSoSource != null)
						{
							child.MaLoaiHeSo = child.MaLoaiHeSoSource.MaLoaiHeSo;
						}
						else
						{
							child.MaLoaiHeSo = entity.MaLoaiHeSo;
						}

					}

					if (entity.CongThucTinhHeSoCollection.Count > 0 || entity.CongThucTinhHeSoCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CongThucTinhHeSoProvider.Save(transactionManager, entity.CongThucTinhHeSoCollection);
						
						deepHandles.Add("CongThucTinhHeSoCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CongThucTinhHeSo >) DataRepository.CongThucTinhHeSoProvider.DeepSave,
							new object[] { transactionManager, entity.CongThucTinhHeSoCollection, deepSaveType, childTypes, innerList }
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
	
	#region LoaiHeSoTinhThuLaoChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.LoaiHeSoTinhThuLao</c>
	///</summary>
	public enum LoaiHeSoTinhThuLaoChildEntityTypes
	{
		///<summary>
		/// Collection of <c>LoaiHeSoTinhThuLao</c> as OneToMany for CongThucTinhHeSoCollection
		///</summary>
		[ChildEntityType(typeof(TList<CongThucTinhHeSo>))]
		CongThucTinhHeSoCollection,
	}
	
	#endregion LoaiHeSoTinhThuLaoChildEntityTypes
	
	#region LoaiHeSoTinhThuLaoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;LoaiHeSoTinhThuLaoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiHeSoTinhThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiHeSoTinhThuLaoFilterBuilder : SqlFilterBuilder<LoaiHeSoTinhThuLaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiHeSoTinhThuLaoFilterBuilder class.
		/// </summary>
		public LoaiHeSoTinhThuLaoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LoaiHeSoTinhThuLaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LoaiHeSoTinhThuLaoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LoaiHeSoTinhThuLaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LoaiHeSoTinhThuLaoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LoaiHeSoTinhThuLaoFilterBuilder
	
	#region LoaiHeSoTinhThuLaoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;LoaiHeSoTinhThuLaoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiHeSoTinhThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiHeSoTinhThuLaoParameterBuilder : ParameterizedSqlFilterBuilder<LoaiHeSoTinhThuLaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiHeSoTinhThuLaoParameterBuilder class.
		/// </summary>
		public LoaiHeSoTinhThuLaoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LoaiHeSoTinhThuLaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LoaiHeSoTinhThuLaoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LoaiHeSoTinhThuLaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LoaiHeSoTinhThuLaoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LoaiHeSoTinhThuLaoParameterBuilder
	
	#region LoaiHeSoTinhThuLaoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;LoaiHeSoTinhThuLaoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiHeSoTinhThuLao"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class LoaiHeSoTinhThuLaoSortBuilder : SqlSortBuilder<LoaiHeSoTinhThuLaoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiHeSoTinhThuLaoSqlSortBuilder class.
		/// </summary>
		public LoaiHeSoTinhThuLaoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion LoaiHeSoTinhThuLaoSortBuilder
	
} // end namespace
