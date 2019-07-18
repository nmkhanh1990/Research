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
	/// This class is the base class for any <see cref="DonGiaPhuCapProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class DonGiaPhuCapProviderBaseCore : EntityProviderBase<PMS.Entities.DonGiaPhuCap, PMS.Entities.DonGiaPhuCapKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.DonGiaPhuCapKey key)
		{
			return Delete(transactionManager, key.IdPhuCap);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_idPhuCap">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _idPhuCap)
		{
			return Delete(null, _idPhuCap);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idPhuCap">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _idPhuCap);		
		
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
		public override PMS.Entities.DonGiaPhuCap Get(TransactionManager transactionManager, PMS.Entities.DonGiaPhuCapKey key, int start, int pageLength)
		{
			return GetByIdPhuCap(transactionManager, key.IdPhuCap, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__DonGiaPh__3F2D0337534A919C index.
		/// </summary>
		/// <param name="_idPhuCap"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaPhuCap"/> class.</returns>
		public PMS.Entities.DonGiaPhuCap GetByIdPhuCap(System.Int32 _idPhuCap)
		{
			int count = -1;
			return GetByIdPhuCap(null,_idPhuCap, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__DonGiaPh__3F2D0337534A919C index.
		/// </summary>
		/// <param name="_idPhuCap"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaPhuCap"/> class.</returns>
		public PMS.Entities.DonGiaPhuCap GetByIdPhuCap(System.Int32 _idPhuCap, int start, int pageLength)
		{
			int count = -1;
			return GetByIdPhuCap(null, _idPhuCap, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__DonGiaPh__3F2D0337534A919C index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idPhuCap"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaPhuCap"/> class.</returns>
		public PMS.Entities.DonGiaPhuCap GetByIdPhuCap(TransactionManager transactionManager, System.Int32 _idPhuCap)
		{
			int count = -1;
			return GetByIdPhuCap(transactionManager, _idPhuCap, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__DonGiaPh__3F2D0337534A919C index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idPhuCap"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaPhuCap"/> class.</returns>
		public PMS.Entities.DonGiaPhuCap GetByIdPhuCap(TransactionManager transactionManager, System.Int32 _idPhuCap, int start, int pageLength)
		{
			int count = -1;
			return GetByIdPhuCap(transactionManager, _idPhuCap, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__DonGiaPh__3F2D0337534A919C index.
		/// </summary>
		/// <param name="_idPhuCap"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaPhuCap"/> class.</returns>
		public PMS.Entities.DonGiaPhuCap GetByIdPhuCap(System.Int32 _idPhuCap, int start, int pageLength, out int count)
		{
			return GetByIdPhuCap(null, _idPhuCap, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__DonGiaPh__3F2D0337534A919C index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idPhuCap"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaPhuCap"/> class.</returns>
		public abstract PMS.Entities.DonGiaPhuCap GetByIdPhuCap(TransactionManager transactionManager, System.Int32 _idPhuCap, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;DonGiaPhuCap&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;DonGiaPhuCap&gt;"/></returns>
		public static TList<DonGiaPhuCap> Fill(IDataReader reader, TList<DonGiaPhuCap> rows, int start, int pageLength)
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
				
				PMS.Entities.DonGiaPhuCap c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("DonGiaPhuCap")
					.Append("|").Append((System.Int32)reader[((int)DonGiaPhuCapColumn.IdPhuCap - 1)]).ToString();
					c = EntityManager.LocateOrCreate<DonGiaPhuCap>(
					key.ToString(), // EntityTrackingKey
					"DonGiaPhuCap",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.DonGiaPhuCap();
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
					c.IdPhuCap = (System.Int32)reader[(DonGiaPhuCapColumn.IdPhuCap.ToString())];
					c.MaQuanLy = (reader[DonGiaPhuCapColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaPhuCapColumn.MaQuanLy.ToString())];
					c.TenPhuCap = (reader[DonGiaPhuCapColumn.TenPhuCap.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaPhuCapColumn.TenPhuCap.ToString())];
					c.DonGia = (reader[DonGiaPhuCapColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaPhuCapColumn.DonGia.ToString())];
					c.DonVi = (reader[DonGiaPhuCapColumn.DonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaPhuCapColumn.DonVi.ToString())];
					c.NgayCapNhat = (reader[DonGiaPhuCapColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(DonGiaPhuCapColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[DonGiaPhuCapColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaPhuCapColumn.NguoiCapNhat.ToString())];
					c.TinhTrang = (reader[DonGiaPhuCapColumn.TinhTrang.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(DonGiaPhuCapColumn.TinhTrang.ToString())];
					c.GhiChu = (reader[DonGiaPhuCapColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaPhuCapColumn.GhiChu.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DonGiaPhuCap"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DonGiaPhuCap"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.DonGiaPhuCap entity)
		{
			if (!reader.Read()) return;
			
			entity.IdPhuCap = (System.Int32)reader[(DonGiaPhuCapColumn.IdPhuCap.ToString())];
			entity.MaQuanLy = (reader[DonGiaPhuCapColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaPhuCapColumn.MaQuanLy.ToString())];
			entity.TenPhuCap = (reader[DonGiaPhuCapColumn.TenPhuCap.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaPhuCapColumn.TenPhuCap.ToString())];
			entity.DonGia = (reader[DonGiaPhuCapColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaPhuCapColumn.DonGia.ToString())];
			entity.DonVi = (reader[DonGiaPhuCapColumn.DonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaPhuCapColumn.DonVi.ToString())];
			entity.NgayCapNhat = (reader[DonGiaPhuCapColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(DonGiaPhuCapColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[DonGiaPhuCapColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaPhuCapColumn.NguoiCapNhat.ToString())];
			entity.TinhTrang = (reader[DonGiaPhuCapColumn.TinhTrang.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(DonGiaPhuCapColumn.TinhTrang.ToString())];
			entity.GhiChu = (reader[DonGiaPhuCapColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaPhuCapColumn.GhiChu.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DonGiaPhuCap"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DonGiaPhuCap"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.DonGiaPhuCap entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.IdPhuCap = (System.Int32)dataRow["IDPhuCap"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.TenPhuCap = Convert.IsDBNull(dataRow["TenPhuCap"]) ? null : (System.String)dataRow["TenPhuCap"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.DonVi = Convert.IsDBNull(dataRow["DonVi"]) ? null : (System.String)dataRow["DonVi"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.TinhTrang = Convert.IsDBNull(dataRow["TinhTrang"]) ? null : (System.Boolean?)dataRow["TinhTrang"];
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
		/// <param name="entity">The <see cref="PMS.Entities.DonGiaPhuCap"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.DonGiaPhuCap Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.DonGiaPhuCap entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.DonGiaPhuCap object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.DonGiaPhuCap instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.DonGiaPhuCap Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.DonGiaPhuCap entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region DonGiaPhuCapChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.DonGiaPhuCap</c>
	///</summary>
	public enum DonGiaPhuCapChildEntityTypes
	{
	}
	
	#endregion DonGiaPhuCapChildEntityTypes
	
	#region DonGiaPhuCapFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;DonGiaPhuCapColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaPhuCap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaPhuCapFilterBuilder : SqlFilterBuilder<DonGiaPhuCapColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaPhuCapFilterBuilder class.
		/// </summary>
		public DonGiaPhuCapFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DonGiaPhuCapFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DonGiaPhuCapFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DonGiaPhuCapFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DonGiaPhuCapFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DonGiaPhuCapFilterBuilder
	
	#region DonGiaPhuCapParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;DonGiaPhuCapColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaPhuCap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaPhuCapParameterBuilder : ParameterizedSqlFilterBuilder<DonGiaPhuCapColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaPhuCapParameterBuilder class.
		/// </summary>
		public DonGiaPhuCapParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DonGiaPhuCapParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DonGiaPhuCapParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DonGiaPhuCapParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DonGiaPhuCapParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DonGiaPhuCapParameterBuilder
	
	#region DonGiaPhuCapSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;DonGiaPhuCapColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaPhuCap"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class DonGiaPhuCapSortBuilder : SqlSortBuilder<DonGiaPhuCapColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaPhuCapSqlSortBuilder class.
		/// </summary>
		public DonGiaPhuCapSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion DonGiaPhuCapSortBuilder
	
} // end namespace
