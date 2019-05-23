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
	/// This class is the base class for any <see cref="CongThucTinhQuyDoiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CongThucTinhQuyDoiProviderBaseCore : EntityProviderBase<PMS.Entities.CongThucTinhQuyDoi, PMS.Entities.CongThucTinhQuyDoiKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.CongThucTinhQuyDoiKey key)
		{
			return Delete(transactionManager, key.MaCongThuc);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maCongThuc">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maCongThuc)
		{
			return Delete(null, _maCongThuc);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCongThuc">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maCongThuc);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK__CongThucT__MaLoa__0D1ECFAE key.
		///		FK__CongThucT__MaLoa__0D1ECFAE Description: 
		/// </summary>
		/// <param name="_maLoaiCongThuc"></param>
		/// <returns>Returns a typed collection of PMS.Entities.CongThucTinhQuyDoi objects.</returns>
		public TList<CongThucTinhQuyDoi> GetByMaLoaiCongThuc(System.String _maLoaiCongThuc)
		{
			int count = -1;
			return GetByMaLoaiCongThuc(_maLoaiCongThuc, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK__CongThucT__MaLoa__0D1ECFAE key.
		///		FK__CongThucT__MaLoa__0D1ECFAE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiCongThuc"></param>
		/// <returns>Returns a typed collection of PMS.Entities.CongThucTinhQuyDoi objects.</returns>
		/// <remarks></remarks>
		public TList<CongThucTinhQuyDoi> GetByMaLoaiCongThuc(TransactionManager transactionManager, System.String _maLoaiCongThuc)
		{
			int count = -1;
			return GetByMaLoaiCongThuc(transactionManager, _maLoaiCongThuc, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK__CongThucT__MaLoa__0D1ECFAE key.
		///		FK__CongThucT__MaLoa__0D1ECFAE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiCongThuc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.CongThucTinhQuyDoi objects.</returns>
		public TList<CongThucTinhQuyDoi> GetByMaLoaiCongThuc(TransactionManager transactionManager, System.String _maLoaiCongThuc, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiCongThuc(transactionManager, _maLoaiCongThuc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK__CongThucT__MaLoa__0D1ECFAE key.
		///		fkCongThuctMaLoa0d1Ecfae Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maLoaiCongThuc"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.CongThucTinhQuyDoi objects.</returns>
		public TList<CongThucTinhQuyDoi> GetByMaLoaiCongThuc(System.String _maLoaiCongThuc, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaLoaiCongThuc(null, _maLoaiCongThuc, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK__CongThucT__MaLoa__0D1ECFAE key.
		///		fkCongThuctMaLoa0d1Ecfae Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maLoaiCongThuc"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.CongThucTinhQuyDoi objects.</returns>
		public TList<CongThucTinhQuyDoi> GetByMaLoaiCongThuc(System.String _maLoaiCongThuc, int start, int pageLength,out int count)
		{
			return GetByMaLoaiCongThuc(null, _maLoaiCongThuc, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK__CongThucT__MaLoa__0D1ECFAE key.
		///		FK__CongThucT__MaLoa__0D1ECFAE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiCongThuc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.CongThucTinhQuyDoi objects.</returns>
		public abstract TList<CongThucTinhQuyDoi> GetByMaLoaiCongThuc(TransactionManager transactionManager, System.String _maLoaiCongThuc, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.CongThucTinhQuyDoi Get(TransactionManager transactionManager, PMS.Entities.CongThucTinhQuyDoiKey key, int start, int pageLength)
		{
			return GetByMaCongThuc(transactionManager, key.MaCongThuc, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__CongThuc__6E223AF74A64259B index.
		/// </summary>
		/// <param name="_maCongThuc"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CongThucTinhQuyDoi"/> class.</returns>
		public PMS.Entities.CongThucTinhQuyDoi GetByMaCongThuc(System.Int32 _maCongThuc)
		{
			int count = -1;
			return GetByMaCongThuc(null,_maCongThuc, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__CongThuc__6E223AF74A64259B index.
		/// </summary>
		/// <param name="_maCongThuc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CongThucTinhQuyDoi"/> class.</returns>
		public PMS.Entities.CongThucTinhQuyDoi GetByMaCongThuc(System.Int32 _maCongThuc, int start, int pageLength)
		{
			int count = -1;
			return GetByMaCongThuc(null, _maCongThuc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__CongThuc__6E223AF74A64259B index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCongThuc"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CongThucTinhQuyDoi"/> class.</returns>
		public PMS.Entities.CongThucTinhQuyDoi GetByMaCongThuc(TransactionManager transactionManager, System.Int32 _maCongThuc)
		{
			int count = -1;
			return GetByMaCongThuc(transactionManager, _maCongThuc, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__CongThuc__6E223AF74A64259B index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCongThuc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CongThucTinhQuyDoi"/> class.</returns>
		public PMS.Entities.CongThucTinhQuyDoi GetByMaCongThuc(TransactionManager transactionManager, System.Int32 _maCongThuc, int start, int pageLength)
		{
			int count = -1;
			return GetByMaCongThuc(transactionManager, _maCongThuc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__CongThuc__6E223AF74A64259B index.
		/// </summary>
		/// <param name="_maCongThuc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CongThucTinhQuyDoi"/> class.</returns>
		public PMS.Entities.CongThucTinhQuyDoi GetByMaCongThuc(System.Int32 _maCongThuc, int start, int pageLength, out int count)
		{
			return GetByMaCongThuc(null, _maCongThuc, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__CongThuc__6E223AF74A64259B index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCongThuc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CongThucTinhQuyDoi"/> class.</returns>
		public abstract PMS.Entities.CongThucTinhQuyDoi GetByMaCongThuc(TransactionManager transactionManager, System.Int32 _maCongThuc, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CongThucTinhQuyDoi&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CongThucTinhQuyDoi&gt;"/></returns>
		public static TList<CongThucTinhQuyDoi> Fill(IDataReader reader, TList<CongThucTinhQuyDoi> rows, int start, int pageLength)
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
				
				PMS.Entities.CongThucTinhQuyDoi c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CongThucTinhQuyDoi")
					.Append("|").Append((System.Int32)reader[((int)CongThucTinhQuyDoiColumn.MaCongThuc - 1)]).ToString();
					c = EntityManager.LocateOrCreate<CongThucTinhQuyDoi>(
					key.ToString(), // EntityTrackingKey
					"CongThucTinhQuyDoi",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.CongThucTinhQuyDoi();
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
					c.MaCongThuc = (System.Int32)reader[(CongThucTinhQuyDoiColumn.MaCongThuc.ToString())];
					c.MaLoaiCongThuc = (reader[CongThucTinhQuyDoiColumn.MaLoaiCongThuc.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhQuyDoiColumn.MaLoaiCongThuc.ToString())];
					c.NamHoc = (reader[CongThucTinhQuyDoiColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhQuyDoiColumn.NamHoc.ToString())];
					c.HocKy = (reader[CongThucTinhQuyDoiColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhQuyDoiColumn.HocKy.ToString())];
					c.CongThuc = (System.String)reader[(CongThucTinhQuyDoiColumn.CongThuc.ToString())];
					c.ToanHangSuDung = (System.String)reader[(CongThucTinhQuyDoiColumn.ToanHangSuDung.ToString())];
					c.ApDung = (reader[CongThucTinhQuyDoiColumn.ApDung.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(CongThucTinhQuyDoiColumn.ApDung.ToString())];
					c.DienGiai = (reader[CongThucTinhQuyDoiColumn.DienGiai.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhQuyDoiColumn.DienGiai.ToString())];
					c.TinhVuotDinhMuc = (reader[CongThucTinhQuyDoiColumn.TinhVuotDinhMuc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(CongThucTinhQuyDoiColumn.TinhVuotDinhMuc.ToString())];
					c.TinhVuotTran = (reader[CongThucTinhQuyDoiColumn.TinhVuotTran.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(CongThucTinhQuyDoiColumn.TinhVuotTran.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.CongThucTinhQuyDoi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.CongThucTinhQuyDoi"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.CongThucTinhQuyDoi entity)
		{
			if (!reader.Read()) return;
			
			entity.MaCongThuc = (System.Int32)reader[(CongThucTinhQuyDoiColumn.MaCongThuc.ToString())];
			entity.MaLoaiCongThuc = (reader[CongThucTinhQuyDoiColumn.MaLoaiCongThuc.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhQuyDoiColumn.MaLoaiCongThuc.ToString())];
			entity.NamHoc = (reader[CongThucTinhQuyDoiColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhQuyDoiColumn.NamHoc.ToString())];
			entity.HocKy = (reader[CongThucTinhQuyDoiColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhQuyDoiColumn.HocKy.ToString())];
			entity.CongThuc = (System.String)reader[(CongThucTinhQuyDoiColumn.CongThuc.ToString())];
			entity.ToanHangSuDung = (System.String)reader[(CongThucTinhQuyDoiColumn.ToanHangSuDung.ToString())];
			entity.ApDung = (reader[CongThucTinhQuyDoiColumn.ApDung.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(CongThucTinhQuyDoiColumn.ApDung.ToString())];
			entity.DienGiai = (reader[CongThucTinhQuyDoiColumn.DienGiai.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhQuyDoiColumn.DienGiai.ToString())];
			entity.TinhVuotDinhMuc = (reader[CongThucTinhQuyDoiColumn.TinhVuotDinhMuc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(CongThucTinhQuyDoiColumn.TinhVuotDinhMuc.ToString())];
			entity.TinhVuotTran = (reader[CongThucTinhQuyDoiColumn.TinhVuotTran.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(CongThucTinhQuyDoiColumn.TinhVuotTran.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.CongThucTinhQuyDoi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.CongThucTinhQuyDoi"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.CongThucTinhQuyDoi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaCongThuc = (System.Int32)dataRow["MaCongThuc"];
			entity.MaLoaiCongThuc = Convert.IsDBNull(dataRow["MaLoaiCongThuc"]) ? null : (System.String)dataRow["MaLoaiCongThuc"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.CongThuc = (System.String)dataRow["CongThuc"];
			entity.ToanHangSuDung = (System.String)dataRow["ToanHangSuDung"];
			entity.ApDung = Convert.IsDBNull(dataRow["ApDung"]) ? null : (System.Boolean?)dataRow["ApDung"];
			entity.DienGiai = Convert.IsDBNull(dataRow["DienGiai"]) ? null : (System.String)dataRow["DienGiai"];
			entity.TinhVuotDinhMuc = Convert.IsDBNull(dataRow["TinhVuotDinhMuc"]) ? null : (System.Boolean?)dataRow["TinhVuotDinhMuc"];
			entity.TinhVuotTran = Convert.IsDBNull(dataRow["TinhVuotTran"]) ? null : (System.Boolean?)dataRow["TinhVuotTran"];
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
		/// <param name="entity">The <see cref="PMS.Entities.CongThucTinhQuyDoi"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.CongThucTinhQuyDoi Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.CongThucTinhQuyDoi entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaLoaiCongThucSource	
			if (CanDeepLoad(entity, "LoaiCongThuc|MaLoaiCongThucSource", deepLoadType, innerList) 
				&& entity.MaLoaiCongThucSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaLoaiCongThuc ?? string.Empty);
				LoaiCongThuc tmpEntity = EntityManager.LocateEntity<LoaiCongThuc>(EntityLocator.ConstructKeyFromPkItems(typeof(LoaiCongThuc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaLoaiCongThucSource = tmpEntity;
				else
					entity.MaLoaiCongThucSource = DataRepository.LoaiCongThucProvider.GetByMaLoaiCongThuc(transactionManager, (entity.MaLoaiCongThuc ?? string.Empty));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaLoaiCongThucSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaLoaiCongThucSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.LoaiCongThucProvider.DeepLoad(transactionManager, entity.MaLoaiCongThucSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaLoaiCongThucSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.CongThucTinhQuyDoi object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.CongThucTinhQuyDoi instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.CongThucTinhQuyDoi Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.CongThucTinhQuyDoi entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaLoaiCongThucSource
			if (CanDeepSave(entity, "LoaiCongThuc|MaLoaiCongThucSource", deepSaveType, innerList) 
				&& entity.MaLoaiCongThucSource != null)
			{
				DataRepository.LoaiCongThucProvider.Save(transactionManager, entity.MaLoaiCongThucSource);
				entity.MaLoaiCongThuc = entity.MaLoaiCongThucSource.MaLoaiCongThuc;
			}
			#endregion 
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
	
	#region CongThucTinhQuyDoiChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.CongThucTinhQuyDoi</c>
	///</summary>
	public enum CongThucTinhQuyDoiChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>LoaiCongThuc</c> at MaLoaiCongThucSource
		///</summary>
		[ChildEntityType(typeof(LoaiCongThuc))]
		LoaiCongThuc,
	}
	
	#endregion CongThucTinhQuyDoiChildEntityTypes
	
	#region CongThucTinhQuyDoiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CongThucTinhQuyDoiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CongThucTinhQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CongThucTinhQuyDoiFilterBuilder : SqlFilterBuilder<CongThucTinhQuyDoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CongThucTinhQuyDoiFilterBuilder class.
		/// </summary>
		public CongThucTinhQuyDoiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CongThucTinhQuyDoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CongThucTinhQuyDoiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CongThucTinhQuyDoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CongThucTinhQuyDoiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CongThucTinhQuyDoiFilterBuilder
	
	#region CongThucTinhQuyDoiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CongThucTinhQuyDoiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CongThucTinhQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CongThucTinhQuyDoiParameterBuilder : ParameterizedSqlFilterBuilder<CongThucTinhQuyDoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CongThucTinhQuyDoiParameterBuilder class.
		/// </summary>
		public CongThucTinhQuyDoiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CongThucTinhQuyDoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CongThucTinhQuyDoiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CongThucTinhQuyDoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CongThucTinhQuyDoiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CongThucTinhQuyDoiParameterBuilder
	
	#region CongThucTinhQuyDoiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CongThucTinhQuyDoiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CongThucTinhQuyDoi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CongThucTinhQuyDoiSortBuilder : SqlSortBuilder<CongThucTinhQuyDoiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CongThucTinhQuyDoiSqlSortBuilder class.
		/// </summary>
		public CongThucTinhQuyDoiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CongThucTinhQuyDoiSortBuilder
	
} // end namespace
