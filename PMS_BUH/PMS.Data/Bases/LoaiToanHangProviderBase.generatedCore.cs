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
	/// This class is the base class for any <see cref="LoaiToanHangProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class LoaiToanHangProviderBaseCore : EntityProviderBase<PMS.Entities.LoaiToanHang, PMS.Entities.LoaiToanHangKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.LoaiToanHangKey key)
		{
			return Delete(transactionManager, key.MaLoaiToanHang);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maLoaiToanHang">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _maLoaiToanHang)
		{
			return Delete(null, _maLoaiToanHang);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiToanHang">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _maLoaiToanHang);		
		
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
		public override PMS.Entities.LoaiToanHang Get(TransactionManager transactionManager, PMS.Entities.LoaiToanHangKey key, int start, int pageLength)
		{
			return GetByMaLoaiToanHang(transactionManager, key.MaLoaiToanHang, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__LoaiToan__D3C8BDD7B6F98920 index.
		/// </summary>
		/// <param name="_maLoaiToanHang"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiToanHang"/> class.</returns>
		public PMS.Entities.LoaiToanHang GetByMaLoaiToanHang(System.String _maLoaiToanHang)
		{
			int count = -1;
			return GetByMaLoaiToanHang(null,_maLoaiToanHang, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LoaiToan__D3C8BDD7B6F98920 index.
		/// </summary>
		/// <param name="_maLoaiToanHang"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiToanHang"/> class.</returns>
		public PMS.Entities.LoaiToanHang GetByMaLoaiToanHang(System.String _maLoaiToanHang, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiToanHang(null, _maLoaiToanHang, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LoaiToan__D3C8BDD7B6F98920 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiToanHang"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiToanHang"/> class.</returns>
		public PMS.Entities.LoaiToanHang GetByMaLoaiToanHang(TransactionManager transactionManager, System.String _maLoaiToanHang)
		{
			int count = -1;
			return GetByMaLoaiToanHang(transactionManager, _maLoaiToanHang, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LoaiToan__D3C8BDD7B6F98920 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiToanHang"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiToanHang"/> class.</returns>
		public PMS.Entities.LoaiToanHang GetByMaLoaiToanHang(TransactionManager transactionManager, System.String _maLoaiToanHang, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiToanHang(transactionManager, _maLoaiToanHang, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LoaiToan__D3C8BDD7B6F98920 index.
		/// </summary>
		/// <param name="_maLoaiToanHang"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiToanHang"/> class.</returns>
		public PMS.Entities.LoaiToanHang GetByMaLoaiToanHang(System.String _maLoaiToanHang, int start, int pageLength, out int count)
		{
			return GetByMaLoaiToanHang(null, _maLoaiToanHang, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LoaiToan__D3C8BDD7B6F98920 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiToanHang"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiToanHang"/> class.</returns>
		public abstract PMS.Entities.LoaiToanHang GetByMaLoaiToanHang(TransactionManager transactionManager, System.String _maLoaiToanHang, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;LoaiToanHang&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;LoaiToanHang&gt;"/></returns>
		public static TList<LoaiToanHang> Fill(IDataReader reader, TList<LoaiToanHang> rows, int start, int pageLength)
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
				
				PMS.Entities.LoaiToanHang c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("LoaiToanHang")
					.Append("|").Append((System.String)reader[((int)LoaiToanHangColumn.MaLoaiToanHang - 1)]).ToString();
					c = EntityManager.LocateOrCreate<LoaiToanHang>(
					key.ToString(), // EntityTrackingKey
					"LoaiToanHang",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.LoaiToanHang();
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
					c.MaLoaiToanHang = (System.String)reader[(LoaiToanHangColumn.MaLoaiToanHang.ToString())];
					c.OriginalMaLoaiToanHang = c.MaLoaiToanHang;
					c.TenLoaiToanHang = (reader[LoaiToanHangColumn.TenLoaiToanHang.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiToanHangColumn.TenLoaiToanHang.ToString())];
					c.TenBang = (reader[LoaiToanHangColumn.TenBang.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiToanHangColumn.TenBang.ToString())];
					c.GhiChu = (reader[LoaiToanHangColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiToanHangColumn.GhiChu.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LoaiToanHang"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LoaiToanHang"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.LoaiToanHang entity)
		{
			if (!reader.Read()) return;
			
			entity.MaLoaiToanHang = (System.String)reader[(LoaiToanHangColumn.MaLoaiToanHang.ToString())];
			entity.OriginalMaLoaiToanHang = (System.String)reader["MaLoaiToanHang"];
			entity.TenLoaiToanHang = (reader[LoaiToanHangColumn.TenLoaiToanHang.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiToanHangColumn.TenLoaiToanHang.ToString())];
			entity.TenBang = (reader[LoaiToanHangColumn.TenBang.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiToanHangColumn.TenBang.ToString())];
			entity.GhiChu = (reader[LoaiToanHangColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiToanHangColumn.GhiChu.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LoaiToanHang"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LoaiToanHang"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.LoaiToanHang entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLoaiToanHang = (System.String)dataRow["MaLoaiToanHang"];
			entity.OriginalMaLoaiToanHang = (System.String)dataRow["MaLoaiToanHang"];
			entity.TenLoaiToanHang = Convert.IsDBNull(dataRow["TenLoaiToanHang"]) ? null : (System.String)dataRow["TenLoaiToanHang"];
			entity.TenBang = Convert.IsDBNull(dataRow["TenBang"]) ? null : (System.String)dataRow["TenBang"];
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
		/// <param name="entity">The <see cref="PMS.Entities.LoaiToanHang"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.LoaiToanHang Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.LoaiToanHang entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaLoaiToanHang methods when available
			
			#region CongThucTinhGiaTriToanHangCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CongThucTinhGiaTriToanHang>|CongThucTinhGiaTriToanHangCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CongThucTinhGiaTriToanHangCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CongThucTinhGiaTriToanHangCollection = DataRepository.CongThucTinhGiaTriToanHangProvider.GetByMaLoaiToanHang(transactionManager, entity.MaLoaiToanHang);

				if (deep && entity.CongThucTinhGiaTriToanHangCollection.Count > 0)
				{
					deepHandles.Add("CongThucTinhGiaTriToanHangCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CongThucTinhGiaTriToanHang>) DataRepository.CongThucTinhGiaTriToanHangProvider.DeepLoad,
						new object[] { transactionManager, entity.CongThucTinhGiaTriToanHangCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.LoaiToanHang object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.LoaiToanHang instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.LoaiToanHang Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.LoaiToanHang entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<CongThucTinhGiaTriToanHang>
				if (CanDeepSave(entity.CongThucTinhGiaTriToanHangCollection, "List<CongThucTinhGiaTriToanHang>|CongThucTinhGiaTriToanHangCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CongThucTinhGiaTriToanHang child in entity.CongThucTinhGiaTriToanHangCollection)
					{
						if(child.MaLoaiToanHangSource != null)
						{
							child.MaLoaiToanHang = child.MaLoaiToanHangSource.MaLoaiToanHang;
						}
						else
						{
							child.MaLoaiToanHang = entity.MaLoaiToanHang;
						}

					}

					if (entity.CongThucTinhGiaTriToanHangCollection.Count > 0 || entity.CongThucTinhGiaTriToanHangCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CongThucTinhGiaTriToanHangProvider.Save(transactionManager, entity.CongThucTinhGiaTriToanHangCollection);
						
						deepHandles.Add("CongThucTinhGiaTriToanHangCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CongThucTinhGiaTriToanHang >) DataRepository.CongThucTinhGiaTriToanHangProvider.DeepSave,
							new object[] { transactionManager, entity.CongThucTinhGiaTriToanHangCollection, deepSaveType, childTypes, innerList }
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
	
	#region LoaiToanHangChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.LoaiToanHang</c>
	///</summary>
	public enum LoaiToanHangChildEntityTypes
	{
		///<summary>
		/// Collection of <c>LoaiToanHang</c> as OneToMany for CongThucTinhGiaTriToanHangCollection
		///</summary>
		[ChildEntityType(typeof(TList<CongThucTinhGiaTriToanHang>))]
		CongThucTinhGiaTriToanHangCollection,
	}
	
	#endregion LoaiToanHangChildEntityTypes
	
	#region LoaiToanHangFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;LoaiToanHangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiToanHang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiToanHangFilterBuilder : SqlFilterBuilder<LoaiToanHangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiToanHangFilterBuilder class.
		/// </summary>
		public LoaiToanHangFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LoaiToanHangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LoaiToanHangFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LoaiToanHangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LoaiToanHangFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LoaiToanHangFilterBuilder
	
	#region LoaiToanHangParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;LoaiToanHangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiToanHang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiToanHangParameterBuilder : ParameterizedSqlFilterBuilder<LoaiToanHangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiToanHangParameterBuilder class.
		/// </summary>
		public LoaiToanHangParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LoaiToanHangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LoaiToanHangParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LoaiToanHangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LoaiToanHangParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LoaiToanHangParameterBuilder
	
	#region LoaiToanHangSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;LoaiToanHangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiToanHang"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class LoaiToanHangSortBuilder : SqlSortBuilder<LoaiToanHangColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiToanHangSqlSortBuilder class.
		/// </summary>
		public LoaiToanHangSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion LoaiToanHangSortBuilder
	
} // end namespace
