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
	/// This class is the base class for any <see cref="HeSoQuyDoiThucHanhSangLyThuyetProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class HeSoQuyDoiThucHanhSangLyThuyetProviderBaseCore : EntityProviderBase<PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet, PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyetKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyetKey key)
		{
			return Delete(transactionManager, key.NamHoc, key.HocKy);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_namHoc">. Primary Key.</param>
		/// <param name="_hocKy">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _namHoc, System.String _hocKy)
		{
			return Delete(null, _namHoc, _hocKy);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_namHoc">. Primary Key.</param>
		/// <param name="_hocKy">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _namHoc, System.String _hocKy);		
		
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
		public override PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet Get(TransactionManager transactionManager, PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyetKey key, int start, int pageLength)
		{
			return GetByNamHocHocKy(transactionManager, key.NamHoc, key.HocKy, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_HSTHLT index.
		/// </summary>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet"/> class.</returns>
		public PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet GetByNamHocHocKy(System.String _namHoc, System.String _hocKy)
		{
			int count = -1;
			return GetByNamHocHocKy(null,_namHoc, _hocKy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HSTHLT index.
		/// </summary>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet"/> class.</returns>
		public PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet GetByNamHocHocKy(System.String _namHoc, System.String _hocKy, int start, int pageLength)
		{
			int count = -1;
			return GetByNamHocHocKy(null, _namHoc, _hocKy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HSTHLT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet"/> class.</returns>
		public PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet GetByNamHocHocKy(TransactionManager transactionManager, System.String _namHoc, System.String _hocKy)
		{
			int count = -1;
			return GetByNamHocHocKy(transactionManager, _namHoc, _hocKy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HSTHLT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet"/> class.</returns>
		public PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet GetByNamHocHocKy(TransactionManager transactionManager, System.String _namHoc, System.String _hocKy, int start, int pageLength)
		{
			int count = -1;
			return GetByNamHocHocKy(transactionManager, _namHoc, _hocKy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HSTHLT index.
		/// </summary>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet"/> class.</returns>
		public PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet GetByNamHocHocKy(System.String _namHoc, System.String _hocKy, int start, int pageLength, out int count)
		{
			return GetByNamHocHocKy(null, _namHoc, _hocKy, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HSTHLT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet"/> class.</returns>
		public abstract PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet GetByNamHocHocKy(TransactionManager transactionManager, System.String _namHoc, System.String _hocKy, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;HeSoQuyDoiThucHanhSangLyThuyet&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;HeSoQuyDoiThucHanhSangLyThuyet&gt;"/></returns>
		public static TList<HeSoQuyDoiThucHanhSangLyThuyet> Fill(IDataReader reader, TList<HeSoQuyDoiThucHanhSangLyThuyet> rows, int start, int pageLength)
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
				
				PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("HeSoQuyDoiThucHanhSangLyThuyet")
					.Append("|").Append((System.String)reader[((int)HeSoQuyDoiThucHanhSangLyThuyetColumn.NamHoc - 1)])
					.Append("|").Append((System.String)reader[((int)HeSoQuyDoiThucHanhSangLyThuyetColumn.HocKy - 1)]).ToString();
					c = EntityManager.LocateOrCreate<HeSoQuyDoiThucHanhSangLyThuyet>(
					key.ToString(), // EntityTrackingKey
					"HeSoQuyDoiThucHanhSangLyThuyet",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet();
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
					c.HeSo = (System.Decimal)reader[(HeSoQuyDoiThucHanhSangLyThuyetColumn.HeSo.ToString())];
					c.NamHoc = (System.String)reader[(HeSoQuyDoiThucHanhSangLyThuyetColumn.NamHoc.ToString())];
					c.OriginalNamHoc = c.NamHoc;
					c.HocKy = (System.String)reader[(HeSoQuyDoiThucHanhSangLyThuyetColumn.HocKy.ToString())];
					c.OriginalHocKy = c.HocKy;
					c.GhiChu = (reader[HeSoQuyDoiThucHanhSangLyThuyetColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoQuyDoiThucHanhSangLyThuyetColumn.GhiChu.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet entity)
		{
			if (!reader.Read()) return;
			
			entity.HeSo = (System.Decimal)reader[(HeSoQuyDoiThucHanhSangLyThuyetColumn.HeSo.ToString())];
			entity.NamHoc = (System.String)reader[(HeSoQuyDoiThucHanhSangLyThuyetColumn.NamHoc.ToString())];
			entity.OriginalNamHoc = (System.String)reader["NamHoc"];
			entity.HocKy = (System.String)reader[(HeSoQuyDoiThucHanhSangLyThuyetColumn.HocKy.ToString())];
			entity.OriginalHocKy = (System.String)reader["HocKy"];
			entity.GhiChu = (reader[HeSoQuyDoiThucHanhSangLyThuyetColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoQuyDoiThucHanhSangLyThuyetColumn.GhiChu.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.HeSo = (System.Decimal)dataRow["HeSo"];
			entity.NamHoc = (System.String)dataRow["NamHoc"];
			entity.OriginalNamHoc = (System.String)dataRow["NamHoc"];
			entity.HocKy = (System.String)dataRow["HocKy"];
			entity.OriginalHocKy = (System.String)dataRow["HocKy"];
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
		/// <param name="entity">The <see cref="PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region HeSoQuyDoiThucHanhSangLyThuyetChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.HeSoQuyDoiThucHanhSangLyThuyet</c>
	///</summary>
	public enum HeSoQuyDoiThucHanhSangLyThuyetChildEntityTypes
	{
	}
	
	#endregion HeSoQuyDoiThucHanhSangLyThuyetChildEntityTypes
	
	#region HeSoQuyDoiThucHanhSangLyThuyetFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;HeSoQuyDoiThucHanhSangLyThuyetColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoQuyDoiThucHanhSangLyThuyet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoQuyDoiThucHanhSangLyThuyetFilterBuilder : SqlFilterBuilder<HeSoQuyDoiThucHanhSangLyThuyetColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoQuyDoiThucHanhSangLyThuyetFilterBuilder class.
		/// </summary>
		public HeSoQuyDoiThucHanhSangLyThuyetFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoQuyDoiThucHanhSangLyThuyetFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoQuyDoiThucHanhSangLyThuyetFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoQuyDoiThucHanhSangLyThuyetFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoQuyDoiThucHanhSangLyThuyetFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoQuyDoiThucHanhSangLyThuyetFilterBuilder
	
	#region HeSoQuyDoiThucHanhSangLyThuyetParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;HeSoQuyDoiThucHanhSangLyThuyetColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoQuyDoiThucHanhSangLyThuyet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoQuyDoiThucHanhSangLyThuyetParameterBuilder : ParameterizedSqlFilterBuilder<HeSoQuyDoiThucHanhSangLyThuyetColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoQuyDoiThucHanhSangLyThuyetParameterBuilder class.
		/// </summary>
		public HeSoQuyDoiThucHanhSangLyThuyetParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoQuyDoiThucHanhSangLyThuyetParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoQuyDoiThucHanhSangLyThuyetParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoQuyDoiThucHanhSangLyThuyetParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoQuyDoiThucHanhSangLyThuyetParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoQuyDoiThucHanhSangLyThuyetParameterBuilder
	
	#region HeSoQuyDoiThucHanhSangLyThuyetSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;HeSoQuyDoiThucHanhSangLyThuyetColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoQuyDoiThucHanhSangLyThuyet"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class HeSoQuyDoiThucHanhSangLyThuyetSortBuilder : SqlSortBuilder<HeSoQuyDoiThucHanhSangLyThuyetColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoQuyDoiThucHanhSangLyThuyetSqlSortBuilder class.
		/// </summary>
		public HeSoQuyDoiThucHanhSangLyThuyetSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion HeSoQuyDoiThucHanhSangLyThuyetSortBuilder
	
} // end namespace
