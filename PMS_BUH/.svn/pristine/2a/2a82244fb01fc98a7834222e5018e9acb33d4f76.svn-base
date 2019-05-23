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
	/// This class is the base class for any <see cref="CongThucTinhHeSoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CongThucTinhHeSoProviderBaseCore : EntityProviderBase<PMS.Entities.CongThucTinhHeSo, PMS.Entities.CongThucTinhHeSoKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.CongThucTinhHeSoKey key)
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
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CongThucTinhHeSo_CongThucTinhHeSo key.
		///		FK_CongThucTinhHeSo_CongThucTinhHeSo Description: 
		/// </summary>
		/// <param name="_maLoaiHeSo"></param>
		/// <returns>Returns a typed collection of PMS.Entities.CongThucTinhHeSo objects.</returns>
		public TList<CongThucTinhHeSo> GetByMaLoaiHeSo(System.Int32? _maLoaiHeSo)
		{
			int count = -1;
			return GetByMaLoaiHeSo(_maLoaiHeSo, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CongThucTinhHeSo_CongThucTinhHeSo key.
		///		FK_CongThucTinhHeSo_CongThucTinhHeSo Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiHeSo"></param>
		/// <returns>Returns a typed collection of PMS.Entities.CongThucTinhHeSo objects.</returns>
		/// <remarks></remarks>
		public TList<CongThucTinhHeSo> GetByMaLoaiHeSo(TransactionManager transactionManager, System.Int32? _maLoaiHeSo)
		{
			int count = -1;
			return GetByMaLoaiHeSo(transactionManager, _maLoaiHeSo, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CongThucTinhHeSo_CongThucTinhHeSo key.
		///		FK_CongThucTinhHeSo_CongThucTinhHeSo Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.CongThucTinhHeSo objects.</returns>
		public TList<CongThucTinhHeSo> GetByMaLoaiHeSo(TransactionManager transactionManager, System.Int32? _maLoaiHeSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiHeSo(transactionManager, _maLoaiHeSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CongThucTinhHeSo_CongThucTinhHeSo key.
		///		fkCongThucTinhHeSoCongThucTinhHeSo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maLoaiHeSo"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.CongThucTinhHeSo objects.</returns>
		public TList<CongThucTinhHeSo> GetByMaLoaiHeSo(System.Int32? _maLoaiHeSo, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaLoaiHeSo(null, _maLoaiHeSo, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CongThucTinhHeSo_CongThucTinhHeSo key.
		///		fkCongThucTinhHeSoCongThucTinhHeSo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maLoaiHeSo"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.CongThucTinhHeSo objects.</returns>
		public TList<CongThucTinhHeSo> GetByMaLoaiHeSo(System.Int32? _maLoaiHeSo, int start, int pageLength,out int count)
		{
			return GetByMaLoaiHeSo(null, _maLoaiHeSo, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CongThucTinhHeSo_CongThucTinhHeSo key.
		///		FK_CongThucTinhHeSo_CongThucTinhHeSo Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.CongThucTinhHeSo objects.</returns>
		public abstract TList<CongThucTinhHeSo> GetByMaLoaiHeSo(TransactionManager transactionManager, System.Int32? _maLoaiHeSo, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.CongThucTinhHeSo Get(TransactionManager transactionManager, PMS.Entities.CongThucTinhHeSoKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_BangHeSoCongThucTinh index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CongThucTinhHeSo"/> class.</returns>
		public PMS.Entities.CongThucTinhHeSo GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_BangHeSoCongThucTinh index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CongThucTinhHeSo"/> class.</returns>
		public PMS.Entities.CongThucTinhHeSo GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_BangHeSoCongThucTinh index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CongThucTinhHeSo"/> class.</returns>
		public PMS.Entities.CongThucTinhHeSo GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_BangHeSoCongThucTinh index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CongThucTinhHeSo"/> class.</returns>
		public PMS.Entities.CongThucTinhHeSo GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_BangHeSoCongThucTinh index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CongThucTinhHeSo"/> class.</returns>
		public PMS.Entities.CongThucTinhHeSo GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_BangHeSoCongThucTinh index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CongThucTinhHeSo"/> class.</returns>
		public abstract PMS.Entities.CongThucTinhHeSo GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CongThucTinhHeSo&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CongThucTinhHeSo&gt;"/></returns>
		public static TList<CongThucTinhHeSo> Fill(IDataReader reader, TList<CongThucTinhHeSo> rows, int start, int pageLength)
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
				
				PMS.Entities.CongThucTinhHeSo c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CongThucTinhHeSo")
					.Append("|").Append((System.Int32)reader[((int)CongThucTinhHeSoColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<CongThucTinhHeSo>(
					key.ToString(), // EntityTrackingKey
					"CongThucTinhHeSo",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.CongThucTinhHeSo();
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
					c.Id = (System.Int32)reader[(CongThucTinhHeSoColumn.Id.ToString())];
					c.MaLoaiHeSo = (reader[CongThucTinhHeSoColumn.MaLoaiHeSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(CongThucTinhHeSoColumn.MaLoaiHeSo.ToString())];
					c.MaHeSoTinhCongThuc = (reader[CongThucTinhHeSoColumn.MaHeSoTinhCongThuc.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhHeSoColumn.MaHeSoTinhCongThuc.ToString())];
					c.TenHienThiCongThuc = (reader[CongThucTinhHeSoColumn.TenHienThiCongThuc.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhHeSoColumn.TenHienThiCongThuc.ToString())];
					c.ThamSoDauVao = (reader[CongThucTinhHeSoColumn.ThamSoDauVao.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhHeSoColumn.ThamSoDauVao.ToString())];
					c.CotCanTinh = (reader[CongThucTinhHeSoColumn.CotCanTinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhHeSoColumn.CotCanTinh.ToString())];
					c.ApDung = (reader[CongThucTinhHeSoColumn.ApDung.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(CongThucTinhHeSoColumn.ApDung.ToString())];
					c.ToanTu = (reader[CongThucTinhHeSoColumn.ToanTu.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhHeSoColumn.ToanTu.ToString())];
					c.DefaultValue = (reader[CongThucTinhHeSoColumn.DefaultValue.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(CongThucTinhHeSoColumn.DefaultValue.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.CongThucTinhHeSo"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.CongThucTinhHeSo"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.CongThucTinhHeSo entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(CongThucTinhHeSoColumn.Id.ToString())];
			entity.MaLoaiHeSo = (reader[CongThucTinhHeSoColumn.MaLoaiHeSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(CongThucTinhHeSoColumn.MaLoaiHeSo.ToString())];
			entity.MaHeSoTinhCongThuc = (reader[CongThucTinhHeSoColumn.MaHeSoTinhCongThuc.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhHeSoColumn.MaHeSoTinhCongThuc.ToString())];
			entity.TenHienThiCongThuc = (reader[CongThucTinhHeSoColumn.TenHienThiCongThuc.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhHeSoColumn.TenHienThiCongThuc.ToString())];
			entity.ThamSoDauVao = (reader[CongThucTinhHeSoColumn.ThamSoDauVao.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhHeSoColumn.ThamSoDauVao.ToString())];
			entity.CotCanTinh = (reader[CongThucTinhHeSoColumn.CotCanTinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhHeSoColumn.CotCanTinh.ToString())];
			entity.ApDung = (reader[CongThucTinhHeSoColumn.ApDung.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(CongThucTinhHeSoColumn.ApDung.ToString())];
			entity.ToanTu = (reader[CongThucTinhHeSoColumn.ToanTu.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhHeSoColumn.ToanTu.ToString())];
			entity.DefaultValue = (reader[CongThucTinhHeSoColumn.DefaultValue.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(CongThucTinhHeSoColumn.DefaultValue.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.CongThucTinhHeSo"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.CongThucTinhHeSo"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.CongThucTinhHeSo entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["ID"];
			entity.MaLoaiHeSo = Convert.IsDBNull(dataRow["MaLoaiHeSo"]) ? null : (System.Int32?)dataRow["MaLoaiHeSo"];
			entity.MaHeSoTinhCongThuc = Convert.IsDBNull(dataRow["MaHeSoTinhCongThuc"]) ? null : (System.String)dataRow["MaHeSoTinhCongThuc"];
			entity.TenHienThiCongThuc = Convert.IsDBNull(dataRow["TenHienThiCongThuc"]) ? null : (System.String)dataRow["TenHienThiCongThuc"];
			entity.ThamSoDauVao = Convert.IsDBNull(dataRow["ThamSoDauVao"]) ? null : (System.String)dataRow["ThamSoDauVao"];
			entity.CotCanTinh = Convert.IsDBNull(dataRow["CotCanTinh"]) ? null : (System.String)dataRow["CotCanTinh"];
			entity.ApDung = Convert.IsDBNull(dataRow["ApDung"]) ? null : (System.Boolean?)dataRow["ApDung"];
			entity.ToanTu = Convert.IsDBNull(dataRow["ToanTu"]) ? null : (System.String)dataRow["ToanTu"];
			entity.DefaultValue = Convert.IsDBNull(dataRow["DefaultValue"]) ? null : (System.Decimal?)dataRow["DefaultValue"];
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
		/// <param name="entity">The <see cref="PMS.Entities.CongThucTinhHeSo"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.CongThucTinhHeSo Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.CongThucTinhHeSo entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaLoaiHeSoSource	
			if (CanDeepLoad(entity, "LoaiHeSoTinhThuLao|MaLoaiHeSoSource", deepLoadType, innerList) 
				&& entity.MaLoaiHeSoSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaLoaiHeSo ?? (int)0);
				LoaiHeSoTinhThuLao tmpEntity = EntityManager.LocateEntity<LoaiHeSoTinhThuLao>(EntityLocator.ConstructKeyFromPkItems(typeof(LoaiHeSoTinhThuLao), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaLoaiHeSoSource = tmpEntity;
				else
					entity.MaLoaiHeSoSource = DataRepository.LoaiHeSoTinhThuLaoProvider.GetByMaLoaiHeSo(transactionManager, (entity.MaLoaiHeSo ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaLoaiHeSoSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaLoaiHeSoSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.LoaiHeSoTinhThuLaoProvider.DeepLoad(transactionManager, entity.MaLoaiHeSoSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaLoaiHeSoSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.CongThucTinhHeSo object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.CongThucTinhHeSo instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.CongThucTinhHeSo Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.CongThucTinhHeSo entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaLoaiHeSoSource
			if (CanDeepSave(entity, "LoaiHeSoTinhThuLao|MaLoaiHeSoSource", deepSaveType, innerList) 
				&& entity.MaLoaiHeSoSource != null)
			{
				DataRepository.LoaiHeSoTinhThuLaoProvider.Save(transactionManager, entity.MaLoaiHeSoSource);
				entity.MaLoaiHeSo = entity.MaLoaiHeSoSource.MaLoaiHeSo;
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
	
	#region CongThucTinhHeSoChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.CongThucTinhHeSo</c>
	///</summary>
	public enum CongThucTinhHeSoChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>LoaiHeSoTinhThuLao</c> at MaLoaiHeSoSource
		///</summary>
		[ChildEntityType(typeof(LoaiHeSoTinhThuLao))]
		LoaiHeSoTinhThuLao,
	}
	
	#endregion CongThucTinhHeSoChildEntityTypes
	
	#region CongThucTinhHeSoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CongThucTinhHeSoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CongThucTinhHeSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CongThucTinhHeSoFilterBuilder : SqlFilterBuilder<CongThucTinhHeSoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CongThucTinhHeSoFilterBuilder class.
		/// </summary>
		public CongThucTinhHeSoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CongThucTinhHeSoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CongThucTinhHeSoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CongThucTinhHeSoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CongThucTinhHeSoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CongThucTinhHeSoFilterBuilder
	
	#region CongThucTinhHeSoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CongThucTinhHeSoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CongThucTinhHeSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CongThucTinhHeSoParameterBuilder : ParameterizedSqlFilterBuilder<CongThucTinhHeSoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CongThucTinhHeSoParameterBuilder class.
		/// </summary>
		public CongThucTinhHeSoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CongThucTinhHeSoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CongThucTinhHeSoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CongThucTinhHeSoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CongThucTinhHeSoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CongThucTinhHeSoParameterBuilder
	
	#region CongThucTinhHeSoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CongThucTinhHeSoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CongThucTinhHeSo"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CongThucTinhHeSoSortBuilder : SqlSortBuilder<CongThucTinhHeSoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CongThucTinhHeSoSqlSortBuilder class.
		/// </summary>
		public CongThucTinhHeSoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CongThucTinhHeSoSortBuilder
	
} // end namespace
