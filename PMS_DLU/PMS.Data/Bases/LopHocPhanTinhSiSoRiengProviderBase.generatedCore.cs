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
	/// This class is the base class for any <see cref="LopHocPhanTinhSiSoRiengProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class LopHocPhanTinhSiSoRiengProviderBaseCore : EntityProviderBase<PMS.Entities.LopHocPhanTinhSiSoRieng, PMS.Entities.LopHocPhanTinhSiSoRiengKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.LopHocPhanTinhSiSoRiengKey key)
		{
			return Delete(transactionManager, key.MaLopHocPhan);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maLopHocPhan">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _maLopHocPhan)
		{
			return Delete(null, _maLopHocPhan);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _maLopHocPhan);		
		
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
		public override PMS.Entities.LopHocPhanTinhSiSoRieng Get(TransactionManager transactionManager, PMS.Entities.LopHocPhanTinhSiSoRiengKey key, int start, int pageLength)
		{
			return GetByMaLopHocPhan(transactionManager, key.MaLopHocPhan, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__LopHocPh__82581CD98307C478 index.
		/// </summary>
		/// <param name="_maLopHocPhan"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanTinhSiSoRieng"/> class.</returns>
		public PMS.Entities.LopHocPhanTinhSiSoRieng GetByMaLopHocPhan(System.String _maLopHocPhan)
		{
			int count = -1;
			return GetByMaLopHocPhan(null,_maLopHocPhan, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LopHocPh__82581CD98307C478 index.
		/// </summary>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanTinhSiSoRieng"/> class.</returns>
		public PMS.Entities.LopHocPhanTinhSiSoRieng GetByMaLopHocPhan(System.String _maLopHocPhan, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLopHocPhan(null, _maLopHocPhan, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LopHocPh__82581CD98307C478 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanTinhSiSoRieng"/> class.</returns>
		public PMS.Entities.LopHocPhanTinhSiSoRieng GetByMaLopHocPhan(TransactionManager transactionManager, System.String _maLopHocPhan)
		{
			int count = -1;
			return GetByMaLopHocPhan(transactionManager, _maLopHocPhan, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LopHocPh__82581CD98307C478 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanTinhSiSoRieng"/> class.</returns>
		public PMS.Entities.LopHocPhanTinhSiSoRieng GetByMaLopHocPhan(TransactionManager transactionManager, System.String _maLopHocPhan, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLopHocPhan(transactionManager, _maLopHocPhan, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LopHocPh__82581CD98307C478 index.
		/// </summary>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanTinhSiSoRieng"/> class.</returns>
		public PMS.Entities.LopHocPhanTinhSiSoRieng GetByMaLopHocPhan(System.String _maLopHocPhan, int start, int pageLength, out int count)
		{
			return GetByMaLopHocPhan(null, _maLopHocPhan, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LopHocPh__82581CD98307C478 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanTinhSiSoRieng"/> class.</returns>
		public abstract PMS.Entities.LopHocPhanTinhSiSoRieng GetByMaLopHocPhan(TransactionManager transactionManager, System.String _maLopHocPhan, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_LopHocPhanTinhSiSoRieng_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanTinhSiSoRieng_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;LopHocPhanTinhSiSoRieng&gt;"/> instance.</returns>
		public TList<LopHocPhanTinhSiSoRieng> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanTinhSiSoRieng_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;LopHocPhanTinhSiSoRieng&gt;"/> instance.</returns>
		public TList<LopHocPhanTinhSiSoRieng> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanTinhSiSoRieng_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;LopHocPhanTinhSiSoRieng&gt;"/> instance.</returns>
		public TList<LopHocPhanTinhSiSoRieng> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanTinhSiSoRieng_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;LopHocPhanTinhSiSoRieng&gt;"/> instance.</returns>
		public abstract TList<LopHocPhanTinhSiSoRieng> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;LopHocPhanTinhSiSoRieng&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;LopHocPhanTinhSiSoRieng&gt;"/></returns>
		public static TList<LopHocPhanTinhSiSoRieng> Fill(IDataReader reader, TList<LopHocPhanTinhSiSoRieng> rows, int start, int pageLength)
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
				
				PMS.Entities.LopHocPhanTinhSiSoRieng c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("LopHocPhanTinhSiSoRieng")
					.Append("|").Append((System.String)reader[((int)LopHocPhanTinhSiSoRiengColumn.MaLopHocPhan - 1)]).ToString();
					c = EntityManager.LocateOrCreate<LopHocPhanTinhSiSoRieng>(
					key.ToString(), // EntityTrackingKey
					"LopHocPhanTinhSiSoRieng",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.LopHocPhanTinhSiSoRieng();
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
					c.MaLopHocPhan = (System.String)reader[(LopHocPhanTinhSiSoRiengColumn.MaLopHocPhan.ToString())];
					c.OriginalMaLopHocPhan = c.MaLopHocPhan;
					c.SiSo = (reader[LopHocPhanTinhSiSoRiengColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(LopHocPhanTinhSiSoRiengColumn.SiSo.ToString())];
					c.GhiChu = (reader[LopHocPhanTinhSiSoRiengColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanTinhSiSoRiengColumn.GhiChu.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LopHocPhanTinhSiSoRieng"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LopHocPhanTinhSiSoRieng"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.LopHocPhanTinhSiSoRieng entity)
		{
			if (!reader.Read()) return;
			
			entity.MaLopHocPhan = (System.String)reader[(LopHocPhanTinhSiSoRiengColumn.MaLopHocPhan.ToString())];
			entity.OriginalMaLopHocPhan = (System.String)reader["MaLopHocPhan"];
			entity.SiSo = (reader[LopHocPhanTinhSiSoRiengColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(LopHocPhanTinhSiSoRiengColumn.SiSo.ToString())];
			entity.GhiChu = (reader[LopHocPhanTinhSiSoRiengColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanTinhSiSoRiengColumn.GhiChu.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LopHocPhanTinhSiSoRieng"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LopHocPhanTinhSiSoRieng"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.LopHocPhanTinhSiSoRieng entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLopHocPhan = (System.String)dataRow["MaLopHocPhan"];
			entity.OriginalMaLopHocPhan = (System.String)dataRow["MaLopHocPhan"];
			entity.SiSo = Convert.IsDBNull(dataRow["SiSo"]) ? null : (System.Int32?)dataRow["SiSo"];
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
		/// <param name="entity">The <see cref="PMS.Entities.LopHocPhanTinhSiSoRieng"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.LopHocPhanTinhSiSoRieng Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.LopHocPhanTinhSiSoRieng entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.LopHocPhanTinhSiSoRieng object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.LopHocPhanTinhSiSoRieng instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.LopHocPhanTinhSiSoRieng Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.LopHocPhanTinhSiSoRieng entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region LopHocPhanTinhSiSoRiengChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.LopHocPhanTinhSiSoRieng</c>
	///</summary>
	public enum LopHocPhanTinhSiSoRiengChildEntityTypes
	{
	}
	
	#endregion LopHocPhanTinhSiSoRiengChildEntityTypes
	
	#region LopHocPhanTinhSiSoRiengFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;LopHocPhanTinhSiSoRiengColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanTinhSiSoRieng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanTinhSiSoRiengFilterBuilder : SqlFilterBuilder<LopHocPhanTinhSiSoRiengColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanTinhSiSoRiengFilterBuilder class.
		/// </summary>
		public LopHocPhanTinhSiSoRiengFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LopHocPhanTinhSiSoRiengFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LopHocPhanTinhSiSoRiengFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LopHocPhanTinhSiSoRiengFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LopHocPhanTinhSiSoRiengFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LopHocPhanTinhSiSoRiengFilterBuilder
	
	#region LopHocPhanTinhSiSoRiengParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;LopHocPhanTinhSiSoRiengColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanTinhSiSoRieng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanTinhSiSoRiengParameterBuilder : ParameterizedSqlFilterBuilder<LopHocPhanTinhSiSoRiengColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanTinhSiSoRiengParameterBuilder class.
		/// </summary>
		public LopHocPhanTinhSiSoRiengParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LopHocPhanTinhSiSoRiengParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LopHocPhanTinhSiSoRiengParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LopHocPhanTinhSiSoRiengParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LopHocPhanTinhSiSoRiengParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LopHocPhanTinhSiSoRiengParameterBuilder
	
	#region LopHocPhanTinhSiSoRiengSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;LopHocPhanTinhSiSoRiengColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanTinhSiSoRieng"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class LopHocPhanTinhSiSoRiengSortBuilder : SqlSortBuilder<LopHocPhanTinhSiSoRiengColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanTinhSiSoRiengSqlSortBuilder class.
		/// </summary>
		public LopHocPhanTinhSiSoRiengSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion LopHocPhanTinhSiSoRiengSortBuilder
	
} // end namespace
