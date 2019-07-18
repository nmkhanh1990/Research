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
	/// This class is the base class for any <see cref="CongThucTinhGiaTriToanHangProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CongThucTinhGiaTriToanHangProviderBaseCore : EntityProviderBase<PMS.Entities.CongThucTinhGiaTriToanHang, PMS.Entities.CongThucTinhGiaTriToanHangKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.CongThucTinhGiaTriToanHangKey key)
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
		/// 	Gets rows from the datasource based on the FK__CongThucT__MaLoa__018DECC8 key.
		///		FK__CongThucT__MaLoa__018DECC8 Description: 
		/// </summary>
		/// <param name="_maLoaiToanHang"></param>
		/// <returns>Returns a typed collection of PMS.Entities.CongThucTinhGiaTriToanHang objects.</returns>
		public TList<CongThucTinhGiaTriToanHang> GetByMaLoaiToanHang(System.String _maLoaiToanHang)
		{
			int count = -1;
			return GetByMaLoaiToanHang(_maLoaiToanHang, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK__CongThucT__MaLoa__018DECC8 key.
		///		FK__CongThucT__MaLoa__018DECC8 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiToanHang"></param>
		/// <returns>Returns a typed collection of PMS.Entities.CongThucTinhGiaTriToanHang objects.</returns>
		/// <remarks></remarks>
		public TList<CongThucTinhGiaTriToanHang> GetByMaLoaiToanHang(TransactionManager transactionManager, System.String _maLoaiToanHang)
		{
			int count = -1;
			return GetByMaLoaiToanHang(transactionManager, _maLoaiToanHang, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK__CongThucT__MaLoa__018DECC8 key.
		///		FK__CongThucT__MaLoa__018DECC8 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiToanHang"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.CongThucTinhGiaTriToanHang objects.</returns>
		public TList<CongThucTinhGiaTriToanHang> GetByMaLoaiToanHang(TransactionManager transactionManager, System.String _maLoaiToanHang, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiToanHang(transactionManager, _maLoaiToanHang, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK__CongThucT__MaLoa__018DECC8 key.
		///		fkCongThuctMaLoa018Decc8 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maLoaiToanHang"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.CongThucTinhGiaTriToanHang objects.</returns>
		public TList<CongThucTinhGiaTriToanHang> GetByMaLoaiToanHang(System.String _maLoaiToanHang, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaLoaiToanHang(null, _maLoaiToanHang, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK__CongThucT__MaLoa__018DECC8 key.
		///		fkCongThuctMaLoa018Decc8 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maLoaiToanHang"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.CongThucTinhGiaTriToanHang objects.</returns>
		public TList<CongThucTinhGiaTriToanHang> GetByMaLoaiToanHang(System.String _maLoaiToanHang, int start, int pageLength,out int count)
		{
			return GetByMaLoaiToanHang(null, _maLoaiToanHang, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK__CongThucT__MaLoa__018DECC8 key.
		///		FK__CongThucT__MaLoa__018DECC8 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiToanHang"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.CongThucTinhGiaTriToanHang objects.</returns>
		public abstract TList<CongThucTinhGiaTriToanHang> GetByMaLoaiToanHang(TransactionManager transactionManager, System.String _maLoaiToanHang, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.CongThucTinhGiaTriToanHang Get(TransactionManager transactionManager, PMS.Entities.CongThucTinhGiaTriToanHangKey key, int start, int pageLength)
		{
			return GetByMaCongThuc(transactionManager, key.MaCongThuc, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__CongThuc__6E223AF72B449D7F index.
		/// </summary>
		/// <param name="_maCongThuc"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CongThucTinhGiaTriToanHang"/> class.</returns>
		public PMS.Entities.CongThucTinhGiaTriToanHang GetByMaCongThuc(System.Int32 _maCongThuc)
		{
			int count = -1;
			return GetByMaCongThuc(null,_maCongThuc, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__CongThuc__6E223AF72B449D7F index.
		/// </summary>
		/// <param name="_maCongThuc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CongThucTinhGiaTriToanHang"/> class.</returns>
		public PMS.Entities.CongThucTinhGiaTriToanHang GetByMaCongThuc(System.Int32 _maCongThuc, int start, int pageLength)
		{
			int count = -1;
			return GetByMaCongThuc(null, _maCongThuc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__CongThuc__6E223AF72B449D7F index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCongThuc"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CongThucTinhGiaTriToanHang"/> class.</returns>
		public PMS.Entities.CongThucTinhGiaTriToanHang GetByMaCongThuc(TransactionManager transactionManager, System.Int32 _maCongThuc)
		{
			int count = -1;
			return GetByMaCongThuc(transactionManager, _maCongThuc, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__CongThuc__6E223AF72B449D7F index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCongThuc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CongThucTinhGiaTriToanHang"/> class.</returns>
		public PMS.Entities.CongThucTinhGiaTriToanHang GetByMaCongThuc(TransactionManager transactionManager, System.Int32 _maCongThuc, int start, int pageLength)
		{
			int count = -1;
			return GetByMaCongThuc(transactionManager, _maCongThuc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__CongThuc__6E223AF72B449D7F index.
		/// </summary>
		/// <param name="_maCongThuc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CongThucTinhGiaTriToanHang"/> class.</returns>
		public PMS.Entities.CongThucTinhGiaTriToanHang GetByMaCongThuc(System.Int32 _maCongThuc, int start, int pageLength, out int count)
		{
			return GetByMaCongThuc(null, _maCongThuc, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__CongThuc__6E223AF72B449D7F index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCongThuc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CongThucTinhGiaTriToanHang"/> class.</returns>
		public abstract PMS.Entities.CongThucTinhGiaTriToanHang GetByMaCongThuc(TransactionManager transactionManager, System.Int32 _maCongThuc, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CongThucTinhGiaTriToanHang&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CongThucTinhGiaTriToanHang&gt;"/></returns>
		public static TList<CongThucTinhGiaTriToanHang> Fill(IDataReader reader, TList<CongThucTinhGiaTriToanHang> rows, int start, int pageLength)
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
				
				PMS.Entities.CongThucTinhGiaTriToanHang c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CongThucTinhGiaTriToanHang")
					.Append("|").Append((System.Int32)reader[((int)CongThucTinhGiaTriToanHangColumn.MaCongThuc - 1)]).ToString();
					c = EntityManager.LocateOrCreate<CongThucTinhGiaTriToanHang>(
					key.ToString(), // EntityTrackingKey
					"CongThucTinhGiaTriToanHang",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.CongThucTinhGiaTriToanHang();
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
					c.MaCongThuc = (System.Int32)reader[(CongThucTinhGiaTriToanHangColumn.MaCongThuc.ToString())];
					c.MaLoaiToanHang = (reader[CongThucTinhGiaTriToanHangColumn.MaLoaiToanHang.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhGiaTriToanHangColumn.MaLoaiToanHang.ToString())];
					c.NamHoc = (reader[CongThucTinhGiaTriToanHangColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhGiaTriToanHangColumn.NamHoc.ToString())];
					c.HocKy = (reader[CongThucTinhGiaTriToanHangColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhGiaTriToanHangColumn.HocKy.ToString())];
					c.ApDung = (reader[CongThucTinhGiaTriToanHangColumn.ApDung.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(CongThucTinhGiaTriToanHangColumn.ApDung.ToString())];
					c.DienGiai = (reader[CongThucTinhGiaTriToanHangColumn.DienGiai.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhGiaTriToanHangColumn.DienGiai.ToString())];
					c.TenHamThucHien = (reader[CongThucTinhGiaTriToanHangColumn.TenHamThucHien.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhGiaTriToanHangColumn.TenHamThucHien.ToString())];
					c.ThamSoDauVao = (reader[CongThucTinhGiaTriToanHangColumn.ThamSoDauVao.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhGiaTriToanHangColumn.ThamSoDauVao.ToString())];
					c.CotLayGiaTri = (reader[CongThucTinhGiaTriToanHangColumn.CotLayGiaTri.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhGiaTriToanHangColumn.CotLayGiaTri.ToString())];
					c.GiaTriMacDinh = (reader[CongThucTinhGiaTriToanHangColumn.GiaTriMacDinh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(CongThucTinhGiaTriToanHangColumn.GiaTriMacDinh.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.CongThucTinhGiaTriToanHang"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.CongThucTinhGiaTriToanHang"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.CongThucTinhGiaTriToanHang entity)
		{
			if (!reader.Read()) return;
			
			entity.MaCongThuc = (System.Int32)reader[(CongThucTinhGiaTriToanHangColumn.MaCongThuc.ToString())];
			entity.MaLoaiToanHang = (reader[CongThucTinhGiaTriToanHangColumn.MaLoaiToanHang.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhGiaTriToanHangColumn.MaLoaiToanHang.ToString())];
			entity.NamHoc = (reader[CongThucTinhGiaTriToanHangColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhGiaTriToanHangColumn.NamHoc.ToString())];
			entity.HocKy = (reader[CongThucTinhGiaTriToanHangColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhGiaTriToanHangColumn.HocKy.ToString())];
			entity.ApDung = (reader[CongThucTinhGiaTriToanHangColumn.ApDung.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(CongThucTinhGiaTriToanHangColumn.ApDung.ToString())];
			entity.DienGiai = (reader[CongThucTinhGiaTriToanHangColumn.DienGiai.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhGiaTriToanHangColumn.DienGiai.ToString())];
			entity.TenHamThucHien = (reader[CongThucTinhGiaTriToanHangColumn.TenHamThucHien.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhGiaTriToanHangColumn.TenHamThucHien.ToString())];
			entity.ThamSoDauVao = (reader[CongThucTinhGiaTriToanHangColumn.ThamSoDauVao.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhGiaTriToanHangColumn.ThamSoDauVao.ToString())];
			entity.CotLayGiaTri = (reader[CongThucTinhGiaTriToanHangColumn.CotLayGiaTri.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucTinhGiaTriToanHangColumn.CotLayGiaTri.ToString())];
			entity.GiaTriMacDinh = (reader[CongThucTinhGiaTriToanHangColumn.GiaTriMacDinh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(CongThucTinhGiaTriToanHangColumn.GiaTriMacDinh.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.CongThucTinhGiaTriToanHang"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.CongThucTinhGiaTriToanHang"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.CongThucTinhGiaTriToanHang entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaCongThuc = (System.Int32)dataRow["MaCongThuc"];
			entity.MaLoaiToanHang = Convert.IsDBNull(dataRow["MaLoaiToanHang"]) ? null : (System.String)dataRow["MaLoaiToanHang"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.ApDung = Convert.IsDBNull(dataRow["ApDung"]) ? null : (System.Boolean?)dataRow["ApDung"];
			entity.DienGiai = Convert.IsDBNull(dataRow["DienGiai"]) ? null : (System.String)dataRow["DienGiai"];
			entity.TenHamThucHien = Convert.IsDBNull(dataRow["TenHamThucHien"]) ? null : (System.String)dataRow["TenHamThucHien"];
			entity.ThamSoDauVao = Convert.IsDBNull(dataRow["ThamSoDauVao"]) ? null : (System.String)dataRow["ThamSoDauVao"];
			entity.CotLayGiaTri = Convert.IsDBNull(dataRow["CotLayGiaTri"]) ? null : (System.String)dataRow["CotLayGiaTri"];
			entity.GiaTriMacDinh = Convert.IsDBNull(dataRow["GiaTriMacDinh"]) ? null : (System.Decimal?)dataRow["GiaTriMacDinh"];
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
		/// <param name="entity">The <see cref="PMS.Entities.CongThucTinhGiaTriToanHang"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.CongThucTinhGiaTriToanHang Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.CongThucTinhGiaTriToanHang entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaLoaiToanHangSource	
			if (CanDeepLoad(entity, "LoaiToanHang|MaLoaiToanHangSource", deepLoadType, innerList) 
				&& entity.MaLoaiToanHangSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaLoaiToanHang ?? string.Empty);
				LoaiToanHang tmpEntity = EntityManager.LocateEntity<LoaiToanHang>(EntityLocator.ConstructKeyFromPkItems(typeof(LoaiToanHang), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaLoaiToanHangSource = tmpEntity;
				else
					entity.MaLoaiToanHangSource = DataRepository.LoaiToanHangProvider.GetByMaLoaiToanHang(transactionManager, (entity.MaLoaiToanHang ?? string.Empty));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaLoaiToanHangSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaLoaiToanHangSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.LoaiToanHangProvider.DeepLoad(transactionManager, entity.MaLoaiToanHangSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaLoaiToanHangSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.CongThucTinhGiaTriToanHang object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.CongThucTinhGiaTriToanHang instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.CongThucTinhGiaTriToanHang Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.CongThucTinhGiaTriToanHang entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaLoaiToanHangSource
			if (CanDeepSave(entity, "LoaiToanHang|MaLoaiToanHangSource", deepSaveType, innerList) 
				&& entity.MaLoaiToanHangSource != null)
			{
				DataRepository.LoaiToanHangProvider.Save(transactionManager, entity.MaLoaiToanHangSource);
				entity.MaLoaiToanHang = entity.MaLoaiToanHangSource.MaLoaiToanHang;
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
	
	#region CongThucTinhGiaTriToanHangChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.CongThucTinhGiaTriToanHang</c>
	///</summary>
	public enum CongThucTinhGiaTriToanHangChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>LoaiToanHang</c> at MaLoaiToanHangSource
		///</summary>
		[ChildEntityType(typeof(LoaiToanHang))]
		LoaiToanHang,
	}
	
	#endregion CongThucTinhGiaTriToanHangChildEntityTypes
	
	#region CongThucTinhGiaTriToanHangFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CongThucTinhGiaTriToanHangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CongThucTinhGiaTriToanHang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CongThucTinhGiaTriToanHangFilterBuilder : SqlFilterBuilder<CongThucTinhGiaTriToanHangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CongThucTinhGiaTriToanHangFilterBuilder class.
		/// </summary>
		public CongThucTinhGiaTriToanHangFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CongThucTinhGiaTriToanHangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CongThucTinhGiaTriToanHangFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CongThucTinhGiaTriToanHangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CongThucTinhGiaTriToanHangFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CongThucTinhGiaTriToanHangFilterBuilder
	
	#region CongThucTinhGiaTriToanHangParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CongThucTinhGiaTriToanHangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CongThucTinhGiaTriToanHang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CongThucTinhGiaTriToanHangParameterBuilder : ParameterizedSqlFilterBuilder<CongThucTinhGiaTriToanHangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CongThucTinhGiaTriToanHangParameterBuilder class.
		/// </summary>
		public CongThucTinhGiaTriToanHangParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CongThucTinhGiaTriToanHangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CongThucTinhGiaTriToanHangParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CongThucTinhGiaTriToanHangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CongThucTinhGiaTriToanHangParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CongThucTinhGiaTriToanHangParameterBuilder
	
	#region CongThucTinhGiaTriToanHangSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CongThucTinhGiaTriToanHangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CongThucTinhGiaTriToanHang"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CongThucTinhGiaTriToanHangSortBuilder : SqlSortBuilder<CongThucTinhGiaTriToanHangColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CongThucTinhGiaTriToanHangSqlSortBuilder class.
		/// </summary>
		public CongThucTinhGiaTriToanHangSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CongThucTinhGiaTriToanHangSortBuilder
	
} // end namespace
