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
	/// This class is the base class for any <see cref="DonGiaTheoLopHocPhanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class DonGiaTheoLopHocPhanProviderBaseCore : EntityProviderBase<PMS.Entities.DonGiaTheoLopHocPhan, PMS.Entities.DonGiaTheoLopHocPhanKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.DonGiaTheoLopHocPhanKey key)
		{
			return Delete(transactionManager, key.Id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int64 _id)
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
		public abstract bool Delete(TransactionManager transactionManager, System.Int64 _id);		
		
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
		public override PMS.Entities.DonGiaTheoLopHocPhan Get(TransactionManager transactionManager, PMS.Entities.DonGiaTheoLopHocPhanKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__DonGiaTh__3214EC272B310436 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaTheoLopHocPhan"/> class.</returns>
		public PMS.Entities.DonGiaTheoLopHocPhan GetById(System.Int64 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__DonGiaTh__3214EC272B310436 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaTheoLopHocPhan"/> class.</returns>
		public PMS.Entities.DonGiaTheoLopHocPhan GetById(System.Int64 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__DonGiaTh__3214EC272B310436 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaTheoLopHocPhan"/> class.</returns>
		public PMS.Entities.DonGiaTheoLopHocPhan GetById(TransactionManager transactionManager, System.Int64 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__DonGiaTh__3214EC272B310436 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaTheoLopHocPhan"/> class.</returns>
		public PMS.Entities.DonGiaTheoLopHocPhan GetById(TransactionManager transactionManager, System.Int64 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__DonGiaTh__3214EC272B310436 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaTheoLopHocPhan"/> class.</returns>
		public PMS.Entities.DonGiaTheoLopHocPhan GetById(System.Int64 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__DonGiaTh__3214EC272B310436 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaTheoLopHocPhan"/> class.</returns>
		public abstract PMS.Entities.DonGiaTheoLopHocPhan GetById(TransactionManager transactionManager, System.Int64 _id, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UQ__DonGiaTh__F5462252E0F5D162 index.
		/// </summary>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maBacDaoTao"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaTheoLopHocPhan"/> class.</returns>
		public PMS.Entities.DonGiaTheoLopHocPhan GetByMaLopHocPhanMaBacDaoTao(System.String _maLopHocPhan, System.String _maBacDaoTao)
		{
			int count = -1;
			return GetByMaLopHocPhanMaBacDaoTao(null,_maLopHocPhan, _maBacDaoTao, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UQ__DonGiaTh__F5462252E0F5D162 index.
		/// </summary>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maBacDaoTao"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaTheoLopHocPhan"/> class.</returns>
		public PMS.Entities.DonGiaTheoLopHocPhan GetByMaLopHocPhanMaBacDaoTao(System.String _maLopHocPhan, System.String _maBacDaoTao, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLopHocPhanMaBacDaoTao(null, _maLopHocPhan, _maBacDaoTao, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UQ__DonGiaTh__F5462252E0F5D162 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maBacDaoTao"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaTheoLopHocPhan"/> class.</returns>
		public PMS.Entities.DonGiaTheoLopHocPhan GetByMaLopHocPhanMaBacDaoTao(TransactionManager transactionManager, System.String _maLopHocPhan, System.String _maBacDaoTao)
		{
			int count = -1;
			return GetByMaLopHocPhanMaBacDaoTao(transactionManager, _maLopHocPhan, _maBacDaoTao, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UQ__DonGiaTh__F5462252E0F5D162 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maBacDaoTao"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaTheoLopHocPhan"/> class.</returns>
		public PMS.Entities.DonGiaTheoLopHocPhan GetByMaLopHocPhanMaBacDaoTao(TransactionManager transactionManager, System.String _maLopHocPhan, System.String _maBacDaoTao, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLopHocPhanMaBacDaoTao(transactionManager, _maLopHocPhan, _maBacDaoTao, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UQ__DonGiaTh__F5462252E0F5D162 index.
		/// </summary>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maBacDaoTao"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaTheoLopHocPhan"/> class.</returns>
		public PMS.Entities.DonGiaTheoLopHocPhan GetByMaLopHocPhanMaBacDaoTao(System.String _maLopHocPhan, System.String _maBacDaoTao, int start, int pageLength, out int count)
		{
			return GetByMaLopHocPhanMaBacDaoTao(null, _maLopHocPhan, _maBacDaoTao, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UQ__DonGiaTh__F5462252E0F5D162 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maBacDaoTao"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaTheoLopHocPhan"/> class.</returns>
		public abstract PMS.Entities.DonGiaTheoLopHocPhan GetByMaLopHocPhanMaBacDaoTao(TransactionManager transactionManager, System.String _maLopHocPhan, System.String _maBacDaoTao, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_DonGiaTheoLopHocPhan_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_DonGiaTheoLopHocPhan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DonGiaTheoLopHocPhan&gt;"/> instance.</returns>
		public TList<DonGiaTheoLopHocPhan> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DonGiaTheoLopHocPhan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DonGiaTheoLopHocPhan&gt;"/> instance.</returns>
		public TList<DonGiaTheoLopHocPhan> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DonGiaTheoLopHocPhan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DonGiaTheoLopHocPhan&gt;"/> instance.</returns>
		public TList<DonGiaTheoLopHocPhan> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DonGiaTheoLopHocPhan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DonGiaTheoLopHocPhan&gt;"/> instance.</returns>
		public abstract TList<DonGiaTheoLopHocPhan> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;DonGiaTheoLopHocPhan&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;DonGiaTheoLopHocPhan&gt;"/></returns>
		public static TList<DonGiaTheoLopHocPhan> Fill(IDataReader reader, TList<DonGiaTheoLopHocPhan> rows, int start, int pageLength)
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
				
				PMS.Entities.DonGiaTheoLopHocPhan c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("DonGiaTheoLopHocPhan")
					.Append("|").Append((System.Int64)reader[((int)DonGiaTheoLopHocPhanColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<DonGiaTheoLopHocPhan>(
					key.ToString(), // EntityTrackingKey
					"DonGiaTheoLopHocPhan",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.DonGiaTheoLopHocPhan();
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
					c.Id = (System.Int64)reader[(DonGiaTheoLopHocPhanColumn.Id.ToString())];
					c.MaLopHocPhan = (reader[DonGiaTheoLopHocPhanColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaTheoLopHocPhanColumn.MaLopHocPhan.ToString())];
					c.MaBacDaoTao = (reader[DonGiaTheoLopHocPhanColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaTheoLopHocPhanColumn.MaBacDaoTao.ToString())];
					c.DonGia = (reader[DonGiaTheoLopHocPhanColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Double?)reader[(DonGiaTheoLopHocPhanColumn.DonGia.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DonGiaTheoLopHocPhan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DonGiaTheoLopHocPhan"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.DonGiaTheoLopHocPhan entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int64)reader[(DonGiaTheoLopHocPhanColumn.Id.ToString())];
			entity.MaLopHocPhan = (reader[DonGiaTheoLopHocPhanColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaTheoLopHocPhanColumn.MaLopHocPhan.ToString())];
			entity.MaBacDaoTao = (reader[DonGiaTheoLopHocPhanColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaTheoLopHocPhanColumn.MaBacDaoTao.ToString())];
			entity.DonGia = (reader[DonGiaTheoLopHocPhanColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Double?)reader[(DonGiaTheoLopHocPhanColumn.DonGia.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DonGiaTheoLopHocPhan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DonGiaTheoLopHocPhan"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.DonGiaTheoLopHocPhan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int64)dataRow["ID"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.MaBacDaoTao = Convert.IsDBNull(dataRow["MaBacDaoTao"]) ? null : (System.String)dataRow["MaBacDaoTao"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Double?)dataRow["DonGia"];
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
		/// <param name="entity">The <see cref="PMS.Entities.DonGiaTheoLopHocPhan"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.DonGiaTheoLopHocPhan Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.DonGiaTheoLopHocPhan entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.DonGiaTheoLopHocPhan object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.DonGiaTheoLopHocPhan instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.DonGiaTheoLopHocPhan Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.DonGiaTheoLopHocPhan entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region DonGiaTheoLopHocPhanChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.DonGiaTheoLopHocPhan</c>
	///</summary>
	public enum DonGiaTheoLopHocPhanChildEntityTypes
	{
	}
	
	#endregion DonGiaTheoLopHocPhanChildEntityTypes
	
	#region DonGiaTheoLopHocPhanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;DonGiaTheoLopHocPhanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaTheoLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaTheoLopHocPhanFilterBuilder : SqlFilterBuilder<DonGiaTheoLopHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaTheoLopHocPhanFilterBuilder class.
		/// </summary>
		public DonGiaTheoLopHocPhanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DonGiaTheoLopHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DonGiaTheoLopHocPhanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DonGiaTheoLopHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DonGiaTheoLopHocPhanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DonGiaTheoLopHocPhanFilterBuilder
	
	#region DonGiaTheoLopHocPhanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;DonGiaTheoLopHocPhanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaTheoLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaTheoLopHocPhanParameterBuilder : ParameterizedSqlFilterBuilder<DonGiaTheoLopHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaTheoLopHocPhanParameterBuilder class.
		/// </summary>
		public DonGiaTheoLopHocPhanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DonGiaTheoLopHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DonGiaTheoLopHocPhanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DonGiaTheoLopHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DonGiaTheoLopHocPhanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DonGiaTheoLopHocPhanParameterBuilder
	
	#region DonGiaTheoLopHocPhanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;DonGiaTheoLopHocPhanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaTheoLopHocPhan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class DonGiaTheoLopHocPhanSortBuilder : SqlSortBuilder<DonGiaTheoLopHocPhanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaTheoLopHocPhanSqlSortBuilder class.
		/// </summary>
		public DonGiaTheoLopHocPhanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion DonGiaTheoLopHocPhanSortBuilder
	
} // end namespace
