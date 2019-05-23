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
	/// This class is the base class for any <see cref="QuyCheProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class QuyCheProviderBaseCore : EntityProviderBase<PMS.Entities.QuyChe, PMS.Entities.QuyCheKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.QuyCheKey key)
		{
			return Delete(transactionManager, key.MaQuyChe);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maQuyChe">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _maQuyChe)
		{
			return Delete(null, _maQuyChe);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuyChe">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _maQuyChe);		
		
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
		public override PMS.Entities.QuyChe Get(TransactionManager transactionManager, PMS.Entities.QuyCheKey key, int start, int pageLength)
		{
			return GetByMaQuyChe(transactionManager, key.MaQuyChe, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__QuyChe__1978305DDA62686F index.
		/// </summary>
		/// <param name="_maQuyChe"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyChe"/> class.</returns>
		public PMS.Entities.QuyChe GetByMaQuyChe(System.String _maQuyChe)
		{
			int count = -1;
			return GetByMaQuyChe(null,_maQuyChe, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__QuyChe__1978305DDA62686F index.
		/// </summary>
		/// <param name="_maQuyChe"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyChe"/> class.</returns>
		public PMS.Entities.QuyChe GetByMaQuyChe(System.String _maQuyChe, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuyChe(null, _maQuyChe, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__QuyChe__1978305DDA62686F index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuyChe"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyChe"/> class.</returns>
		public PMS.Entities.QuyChe GetByMaQuyChe(TransactionManager transactionManager, System.String _maQuyChe)
		{
			int count = -1;
			return GetByMaQuyChe(transactionManager, _maQuyChe, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__QuyChe__1978305DDA62686F index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuyChe"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyChe"/> class.</returns>
		public PMS.Entities.QuyChe GetByMaQuyChe(TransactionManager transactionManager, System.String _maQuyChe, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuyChe(transactionManager, _maQuyChe, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__QuyChe__1978305DDA62686F index.
		/// </summary>
		/// <param name="_maQuyChe"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyChe"/> class.</returns>
		public PMS.Entities.QuyChe GetByMaQuyChe(System.String _maQuyChe, int start, int pageLength, out int count)
		{
			return GetByMaQuyChe(null, _maQuyChe, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__QuyChe__1978305DDA62686F index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuyChe"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyChe"/> class.</returns>
		public abstract PMS.Entities.QuyChe GetByMaQuyChe(TransactionManager transactionManager, System.String _maQuyChe, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UQ__QuyChe__CF4A7707C2DBB10D index.
		/// </summary>
		/// <param name="_tenQuyChe"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyChe"/> class.</returns>
		public PMS.Entities.QuyChe GetByTenQuyChe(System.String _tenQuyChe)
		{
			int count = -1;
			return GetByTenQuyChe(null,_tenQuyChe, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UQ__QuyChe__CF4A7707C2DBB10D index.
		/// </summary>
		/// <param name="_tenQuyChe"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyChe"/> class.</returns>
		public PMS.Entities.QuyChe GetByTenQuyChe(System.String _tenQuyChe, int start, int pageLength)
		{
			int count = -1;
			return GetByTenQuyChe(null, _tenQuyChe, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UQ__QuyChe__CF4A7707C2DBB10D index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_tenQuyChe"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyChe"/> class.</returns>
		public PMS.Entities.QuyChe GetByTenQuyChe(TransactionManager transactionManager, System.String _tenQuyChe)
		{
			int count = -1;
			return GetByTenQuyChe(transactionManager, _tenQuyChe, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UQ__QuyChe__CF4A7707C2DBB10D index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_tenQuyChe"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyChe"/> class.</returns>
		public PMS.Entities.QuyChe GetByTenQuyChe(TransactionManager transactionManager, System.String _tenQuyChe, int start, int pageLength)
		{
			int count = -1;
			return GetByTenQuyChe(transactionManager, _tenQuyChe, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UQ__QuyChe__CF4A7707C2DBB10D index.
		/// </summary>
		/// <param name="_tenQuyChe"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyChe"/> class.</returns>
		public PMS.Entities.QuyChe GetByTenQuyChe(System.String _tenQuyChe, int start, int pageLength, out int count)
		{
			return GetByTenQuyChe(null, _tenQuyChe, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UQ__QuyChe__CF4A7707C2DBB10D index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_tenQuyChe"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyChe"/> class.</returns>
		public abstract PMS.Entities.QuyChe GetByTenQuyChe(TransactionManager transactionManager, System.String _tenQuyChe, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;QuyChe&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;QuyChe&gt;"/></returns>
		public static TList<QuyChe> Fill(IDataReader reader, TList<QuyChe> rows, int start, int pageLength)
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
				
				PMS.Entities.QuyChe c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("QuyChe")
					.Append("|").Append((System.String)reader[((int)QuyCheColumn.MaQuyChe - 1)]).ToString();
					c = EntityManager.LocateOrCreate<QuyChe>(
					key.ToString(), // EntityTrackingKey
					"QuyChe",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.QuyChe();
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
					c.MaQuyChe = (System.String)reader[(QuyCheColumn.MaQuyChe.ToString())];
					c.OriginalMaQuyChe = c.MaQuyChe;
					c.TenQuyChe = (reader[QuyCheColumn.TenQuyChe.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyCheColumn.TenQuyChe.ToString())];
					c.NamHoc = (reader[QuyCheColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyCheColumn.NamHoc.ToString())];
					c.HocKy = (reader[QuyCheColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyCheColumn.HocKy.ToString())];
					c.NoiDung = (reader[QuyCheColumn.NoiDung.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyCheColumn.NoiDung.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.QuyChe"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.QuyChe"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.QuyChe entity)
		{
			if (!reader.Read()) return;
			
			entity.MaQuyChe = (System.String)reader[(QuyCheColumn.MaQuyChe.ToString())];
			entity.OriginalMaQuyChe = (System.String)reader["MaQuyChe"];
			entity.TenQuyChe = (reader[QuyCheColumn.TenQuyChe.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyCheColumn.TenQuyChe.ToString())];
			entity.NamHoc = (reader[QuyCheColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyCheColumn.NamHoc.ToString())];
			entity.HocKy = (reader[QuyCheColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyCheColumn.HocKy.ToString())];
			entity.NoiDung = (reader[QuyCheColumn.NoiDung.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyCheColumn.NoiDung.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.QuyChe"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.QuyChe"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.QuyChe entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaQuyChe = (System.String)dataRow["MaQuyChe"];
			entity.OriginalMaQuyChe = (System.String)dataRow["MaQuyChe"];
			entity.TenQuyChe = Convert.IsDBNull(dataRow["TenQuyChe"]) ? null : (System.String)dataRow["TenQuyChe"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.NoiDung = Convert.IsDBNull(dataRow["NoiDung"]) ? null : (System.String)dataRow["NoiDung"];
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
		/// <param name="entity">The <see cref="PMS.Entities.QuyChe"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.QuyChe Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.QuyChe entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.QuyChe object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.QuyChe instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.QuyChe Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.QuyChe entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region QuyCheChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.QuyChe</c>
	///</summary>
	public enum QuyCheChildEntityTypes
	{
	}
	
	#endregion QuyCheChildEntityTypes
	
	#region QuyCheFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;QuyCheColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyChe"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyCheFilterBuilder : SqlFilterBuilder<QuyCheColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyCheFilterBuilder class.
		/// </summary>
		public QuyCheFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the QuyCheFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public QuyCheFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the QuyCheFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public QuyCheFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion QuyCheFilterBuilder
	
	#region QuyCheParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;QuyCheColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyChe"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyCheParameterBuilder : ParameterizedSqlFilterBuilder<QuyCheColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyCheParameterBuilder class.
		/// </summary>
		public QuyCheParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the QuyCheParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public QuyCheParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the QuyCheParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public QuyCheParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion QuyCheParameterBuilder
	
	#region QuyCheSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;QuyCheColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyChe"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class QuyCheSortBuilder : SqlSortBuilder<QuyCheColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyCheSqlSortBuilder class.
		/// </summary>
		public QuyCheSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion QuyCheSortBuilder
	
} // end namespace
