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
	/// This class is the base class for any <see cref="PhanQuyenTheoKhoaProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PhanQuyenTheoKhoaProviderBaseCore : EntityProviderBase<PMS.Entities.PhanQuyenTheoKhoa, PMS.Entities.PhanQuyenTheoKhoaKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.PhanQuyenTheoKhoaKey key)
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
		public override PMS.Entities.PhanQuyenTheoKhoa Get(TransactionManager transactionManager, PMS.Entities.PhanQuyenTheoKhoaKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__PhanQuye__3214EC0776491402 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanQuyenTheoKhoa"/> class.</returns>
		public PMS.Entities.PhanQuyenTheoKhoa GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__PhanQuye__3214EC0776491402 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanQuyenTheoKhoa"/> class.</returns>
		public PMS.Entities.PhanQuyenTheoKhoa GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__PhanQuye__3214EC0776491402 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanQuyenTheoKhoa"/> class.</returns>
		public PMS.Entities.PhanQuyenTheoKhoa GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__PhanQuye__3214EC0776491402 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanQuyenTheoKhoa"/> class.</returns>
		public PMS.Entities.PhanQuyenTheoKhoa GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__PhanQuye__3214EC0776491402 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanQuyenTheoKhoa"/> class.</returns>
		public PMS.Entities.PhanQuyenTheoKhoa GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__PhanQuye__3214EC0776491402 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanQuyenTheoKhoa"/> class.</returns>
		public abstract PMS.Entities.PhanQuyenTheoKhoa GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_PhanQuyenTheoKhoa_GetByMaNhomKhoa 
		
		/// <summary>
		///	This method wrap the 'cust_PhanQuyenTheoKhoa_GetByMaNhomKhoa' stored procedure. 
		/// </summary>
		/// <param name="maTaiKhoa"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaNhomKhoa(System.Int32 maTaiKhoa)
		{
			return GetByMaNhomKhoa(null, 0, int.MaxValue , maTaiKhoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_PhanQuyenTheoKhoa_GetByMaNhomKhoa' stored procedure. 
		/// </summary>
		/// <param name="maTaiKhoa"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaNhomKhoa(int start, int pageLength, System.Int32 maTaiKhoa)
		{
			return GetByMaNhomKhoa(null, start, pageLength , maTaiKhoa);
		}
				
		/// <summary>
		///	This method wrap the 'cust_PhanQuyenTheoKhoa_GetByMaNhomKhoa' stored procedure. 
		/// </summary>
		/// <param name="maTaiKhoa"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaNhomKhoa(TransactionManager transactionManager, System.Int32 maTaiKhoa)
		{
			return GetByMaNhomKhoa(transactionManager, 0, int.MaxValue , maTaiKhoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_PhanQuyenTheoKhoa_GetByMaNhomKhoa' stored procedure. 
		/// </summary>
		/// <param name="maTaiKhoa"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByMaNhomKhoa(TransactionManager transactionManager, int start, int pageLength , System.Int32 maTaiKhoa);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PhanQuyenTheoKhoa&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PhanQuyenTheoKhoa&gt;"/></returns>
		public static TList<PhanQuyenTheoKhoa> Fill(IDataReader reader, TList<PhanQuyenTheoKhoa> rows, int start, int pageLength)
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
				
				PMS.Entities.PhanQuyenTheoKhoa c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PhanQuyenTheoKhoa")
					.Append("|").Append((System.Int32)reader[((int)PhanQuyenTheoKhoaColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<PhanQuyenTheoKhoa>(
					key.ToString(), // EntityTrackingKey
					"PhanQuyenTheoKhoa",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.PhanQuyenTheoKhoa();
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
					c.Id = (System.Int32)reader[(PhanQuyenTheoKhoaColumn.Id.ToString())];
					c.MaTaiKhoan = (reader[PhanQuyenTheoKhoaColumn.MaTaiKhoan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(PhanQuyenTheoKhoaColumn.MaTaiKhoan.ToString())];
					c.MaKhoa = (reader[PhanQuyenTheoKhoaColumn.MaKhoa.ToString()] == DBNull.Value) ? null : (System.String)reader[(PhanQuyenTheoKhoaColumn.MaKhoa.ToString())];
					c.DuocPhepChot = (reader[PhanQuyenTheoKhoaColumn.DuocPhepChot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(PhanQuyenTheoKhoaColumn.DuocPhepChot.ToString())];
					c.IdChucNang = (reader[PhanQuyenTheoKhoaColumn.IdChucNang.ToString()] == DBNull.Value) ? null : (System.String)reader[(PhanQuyenTheoKhoaColumn.IdChucNang.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.PhanQuyenTheoKhoa"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.PhanQuyenTheoKhoa"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.PhanQuyenTheoKhoa entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(PhanQuyenTheoKhoaColumn.Id.ToString())];
			entity.MaTaiKhoan = (reader[PhanQuyenTheoKhoaColumn.MaTaiKhoan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(PhanQuyenTheoKhoaColumn.MaTaiKhoan.ToString())];
			entity.MaKhoa = (reader[PhanQuyenTheoKhoaColumn.MaKhoa.ToString()] == DBNull.Value) ? null : (System.String)reader[(PhanQuyenTheoKhoaColumn.MaKhoa.ToString())];
			entity.DuocPhepChot = (reader[PhanQuyenTheoKhoaColumn.DuocPhepChot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(PhanQuyenTheoKhoaColumn.DuocPhepChot.ToString())];
			entity.IdChucNang = (reader[PhanQuyenTheoKhoaColumn.IdChucNang.ToString()] == DBNull.Value) ? null : (System.String)reader[(PhanQuyenTheoKhoaColumn.IdChucNang.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.PhanQuyenTheoKhoa"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.PhanQuyenTheoKhoa"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.PhanQuyenTheoKhoa entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaTaiKhoan = Convert.IsDBNull(dataRow["MaTaiKhoan"]) ? null : (System.Int32?)dataRow["MaTaiKhoan"];
			entity.MaKhoa = Convert.IsDBNull(dataRow["MaKhoa"]) ? null : (System.String)dataRow["MaKhoa"];
			entity.DuocPhepChot = Convert.IsDBNull(dataRow["DuocPhepChot"]) ? null : (System.Boolean?)dataRow["DuocPhepChot"];
			entity.IdChucNang = Convert.IsDBNull(dataRow["IdChucNang"]) ? null : (System.String)dataRow["IdChucNang"];
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
		/// <param name="entity">The <see cref="PMS.Entities.PhanQuyenTheoKhoa"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.PhanQuyenTheoKhoa Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.PhanQuyenTheoKhoa entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.PhanQuyenTheoKhoa object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.PhanQuyenTheoKhoa instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.PhanQuyenTheoKhoa Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.PhanQuyenTheoKhoa entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region PhanQuyenTheoKhoaChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.PhanQuyenTheoKhoa</c>
	///</summary>
	public enum PhanQuyenTheoKhoaChildEntityTypes
	{
	}
	
	#endregion PhanQuyenTheoKhoaChildEntityTypes
	
	#region PhanQuyenTheoKhoaFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PhanQuyenTheoKhoaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PhanQuyenTheoKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhanQuyenTheoKhoaFilterBuilder : SqlFilterBuilder<PhanQuyenTheoKhoaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PhanQuyenTheoKhoaFilterBuilder class.
		/// </summary>
		public PhanQuyenTheoKhoaFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PhanQuyenTheoKhoaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PhanQuyenTheoKhoaFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PhanQuyenTheoKhoaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PhanQuyenTheoKhoaFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PhanQuyenTheoKhoaFilterBuilder
	
	#region PhanQuyenTheoKhoaParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PhanQuyenTheoKhoaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PhanQuyenTheoKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhanQuyenTheoKhoaParameterBuilder : ParameterizedSqlFilterBuilder<PhanQuyenTheoKhoaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PhanQuyenTheoKhoaParameterBuilder class.
		/// </summary>
		public PhanQuyenTheoKhoaParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PhanQuyenTheoKhoaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PhanQuyenTheoKhoaParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PhanQuyenTheoKhoaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PhanQuyenTheoKhoaParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PhanQuyenTheoKhoaParameterBuilder
	
	#region PhanQuyenTheoKhoaSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PhanQuyenTheoKhoaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PhanQuyenTheoKhoa"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PhanQuyenTheoKhoaSortBuilder : SqlSortBuilder<PhanQuyenTheoKhoaColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PhanQuyenTheoKhoaSqlSortBuilder class.
		/// </summary>
		public PhanQuyenTheoKhoaSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PhanQuyenTheoKhoaSortBuilder
	
} // end namespace
