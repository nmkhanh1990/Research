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
	/// This class is the base class for any <see cref="GiangVienTheoDotProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GiangVienTheoDotProviderBaseCore : EntityProviderBase<PMS.Entities.GiangVienTheoDot, PMS.Entities.GiangVienTheoDotKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.GiangVienTheoDotKey key)
		{
			return Delete(transactionManager, key.Id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _id)
		{
			return Delete(null, _id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _id);		
		
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
		public override PMS.Entities.GiangVienTheoDot Get(TransactionManager transactionManager, PMS.Entities.GiangVienTheoDotKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__GiangVie__3214EC2738079A8E index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienTheoDot"/> class.</returns>
		public PMS.Entities.GiangVienTheoDot GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__3214EC2738079A8E index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienTheoDot"/> class.</returns>
		public PMS.Entities.GiangVienTheoDot GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__3214EC2738079A8E index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienTheoDot"/> class.</returns>
		public PMS.Entities.GiangVienTheoDot GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__3214EC2738079A8E index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienTheoDot"/> class.</returns>
		public PMS.Entities.GiangVienTheoDot GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__3214EC2738079A8E index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienTheoDot"/> class.</returns>
		public PMS.Entities.GiangVienTheoDot GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__3214EC2738079A8E index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienTheoDot"/> class.</returns>
		public abstract PMS.Entities.GiangVienTheoDot GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GiangVienTheoDot&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GiangVienTheoDot&gt;"/></returns>
		public static TList<GiangVienTheoDot> Fill(IDataReader reader, TList<GiangVienTheoDot> rows, int start, int pageLength)
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
				
				PMS.Entities.GiangVienTheoDot c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GiangVienTheoDot")
					.Append("|").Append((System.Int32)reader[((int)GiangVienTheoDotColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<GiangVienTheoDot>(
					key.ToString(), // EntityTrackingKey
					"GiangVienTheoDot",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.GiangVienTheoDot();
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
					c.Id = (System.Int32)reader[(GiangVienTheoDotColumn.Id.ToString())];
					c.MaGiangVien = (reader[GiangVienTheoDotColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTheoDotColumn.MaGiangVien.ToString())];
					c.StnckhThucHien = (reader[GiangVienTheoDotColumn.StnckhThucHien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTheoDotColumn.StnckhThucHien.ToString())];
					c.StnckhDuocTru = (reader[GiangVienTheoDotColumn.StnckhDuocTru.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTheoDotColumn.StnckhDuocTru.ToString())];
					c.DinhMuc = (reader[GiangVienTheoDotColumn.DinhMuc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTheoDotColumn.DinhMuc.ToString())];
					c.GiamTruDinhMuc = (reader[GiangVienTheoDotColumn.GiamTruDinhMuc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTheoDotColumn.GiamTruDinhMuc.ToString())];
					c.DotThanhToan = (reader[GiangVienTheoDotColumn.DotThanhToan.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTheoDotColumn.DotThanhToan.ToString())];
					c.NamHoc = (reader[GiangVienTheoDotColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTheoDotColumn.NamHoc.ToString())];
					c.HocKy = (reader[GiangVienTheoDotColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTheoDotColumn.HocKy.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienTheoDot"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienTheoDot"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.GiangVienTheoDot entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(GiangVienTheoDotColumn.Id.ToString())];
			entity.MaGiangVien = (reader[GiangVienTheoDotColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTheoDotColumn.MaGiangVien.ToString())];
			entity.StnckhThucHien = (reader[GiangVienTheoDotColumn.StnckhThucHien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTheoDotColumn.StnckhThucHien.ToString())];
			entity.StnckhDuocTru = (reader[GiangVienTheoDotColumn.StnckhDuocTru.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTheoDotColumn.StnckhDuocTru.ToString())];
			entity.DinhMuc = (reader[GiangVienTheoDotColumn.DinhMuc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTheoDotColumn.DinhMuc.ToString())];
			entity.GiamTruDinhMuc = (reader[GiangVienTheoDotColumn.GiamTruDinhMuc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTheoDotColumn.GiamTruDinhMuc.ToString())];
			entity.DotThanhToan = (reader[GiangVienTheoDotColumn.DotThanhToan.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTheoDotColumn.DotThanhToan.ToString())];
			entity.NamHoc = (reader[GiangVienTheoDotColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTheoDotColumn.NamHoc.ToString())];
			entity.HocKy = (reader[GiangVienTheoDotColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTheoDotColumn.HocKy.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienTheoDot"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienTheoDot"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.GiangVienTheoDot entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["ID"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.String)dataRow["MaGiangVien"];
			entity.StnckhThucHien = Convert.IsDBNull(dataRow["STNCKHThucHien"]) ? null : (System.Decimal?)dataRow["STNCKHThucHien"];
			entity.StnckhDuocTru = Convert.IsDBNull(dataRow["STNCKHDuocTru"]) ? null : (System.Decimal?)dataRow["STNCKHDuocTru"];
			entity.DinhMuc = Convert.IsDBNull(dataRow["DinhMuc"]) ? null : (System.Decimal?)dataRow["DinhMuc"];
			entity.GiamTruDinhMuc = Convert.IsDBNull(dataRow["GiamTruDinhMuc"]) ? null : (System.Decimal?)dataRow["GiamTruDinhMuc"];
			entity.DotThanhToan = Convert.IsDBNull(dataRow["DotThanhToan"]) ? null : (System.String)dataRow["DotThanhToan"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
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
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienTheoDot"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienTheoDot Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.GiangVienTheoDot entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.GiangVienTheoDot object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.GiangVienTheoDot instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienTheoDot Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.GiangVienTheoDot entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region GiangVienTheoDotChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.GiangVienTheoDot</c>
	///</summary>
	public enum GiangVienTheoDotChildEntityTypes
	{
	}
	
	#endregion GiangVienTheoDotChildEntityTypes
	
	#region GiangVienTheoDotFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GiangVienTheoDotColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienTheoDot"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienTheoDotFilterBuilder : SqlFilterBuilder<GiangVienTheoDotColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienTheoDotFilterBuilder class.
		/// </summary>
		public GiangVienTheoDotFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienTheoDotFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienTheoDotFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienTheoDotFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienTheoDotFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienTheoDotFilterBuilder
	
	#region GiangVienTheoDotParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GiangVienTheoDotColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienTheoDot"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienTheoDotParameterBuilder : ParameterizedSqlFilterBuilder<GiangVienTheoDotColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienTheoDotParameterBuilder class.
		/// </summary>
		public GiangVienTheoDotParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienTheoDotParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienTheoDotParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienTheoDotParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienTheoDotParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienTheoDotParameterBuilder
	
	#region GiangVienTheoDotSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GiangVienTheoDotColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienTheoDot"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GiangVienTheoDotSortBuilder : SqlSortBuilder<GiangVienTheoDotColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienTheoDotSqlSortBuilder class.
		/// </summary>
		public GiangVienTheoDotSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GiangVienTheoDotSortBuilder
	
} // end namespace
