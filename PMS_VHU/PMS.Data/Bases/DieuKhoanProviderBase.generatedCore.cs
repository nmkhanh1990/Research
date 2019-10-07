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
	/// This class is the base class for any <see cref="DieuKhoanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class DieuKhoanProviderBaseCore : EntityProviderBase<PMS.Entities.DieuKhoan, PMS.Entities.DieuKhoanKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.DieuKhoanKey key)
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
		/// 	Gets rows from the datasource based on the FK_DieuKhoan_DieuKhoan key.
		///		FK_DieuKhoan_DieuKhoan Description: 
		/// </summary>
		/// <param name="_parentId"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DieuKhoan objects.</returns>
		public TList<DieuKhoan> GetByParentId(System.Int32? _parentId)
		{
			int count = -1;
			return GetByParentId(_parentId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DieuKhoan_DieuKhoan key.
		///		FK_DieuKhoan_DieuKhoan Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_parentId"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DieuKhoan objects.</returns>
		/// <remarks></remarks>
		public TList<DieuKhoan> GetByParentId(TransactionManager transactionManager, System.Int32? _parentId)
		{
			int count = -1;
			return GetByParentId(transactionManager, _parentId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_DieuKhoan_DieuKhoan key.
		///		FK_DieuKhoan_DieuKhoan Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_parentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DieuKhoan objects.</returns>
		public TList<DieuKhoan> GetByParentId(TransactionManager transactionManager, System.Int32? _parentId, int start, int pageLength)
		{
			int count = -1;
			return GetByParentId(transactionManager, _parentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DieuKhoan_DieuKhoan key.
		///		fkDieuKhoanDieuKhoan Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_parentId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DieuKhoan objects.</returns>
		public TList<DieuKhoan> GetByParentId(System.Int32? _parentId, int start, int pageLength)
		{
			int count =  -1;
			return GetByParentId(null, _parentId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DieuKhoan_DieuKhoan key.
		///		fkDieuKhoanDieuKhoan Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_parentId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DieuKhoan objects.</returns>
		public TList<DieuKhoan> GetByParentId(System.Int32? _parentId, int start, int pageLength,out int count)
		{
			return GetByParentId(null, _parentId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DieuKhoan_DieuKhoan key.
		///		FK_DieuKhoan_DieuKhoan Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_parentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.DieuKhoan objects.</returns>
		public abstract TList<DieuKhoan> GetByParentId(TransactionManager transactionManager, System.Int32? _parentId, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.DieuKhoan Get(TransactionManager transactionManager, PMS.Entities.DieuKhoanKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_DieuKhoan index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DieuKhoan"/> class.</returns>
		public PMS.Entities.DieuKhoan GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DieuKhoan index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DieuKhoan"/> class.</returns>
		public PMS.Entities.DieuKhoan GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DieuKhoan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DieuKhoan"/> class.</returns>
		public PMS.Entities.DieuKhoan GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DieuKhoan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DieuKhoan"/> class.</returns>
		public PMS.Entities.DieuKhoan GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DieuKhoan index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DieuKhoan"/> class.</returns>
		public PMS.Entities.DieuKhoan GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DieuKhoan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DieuKhoan"/> class.</returns>
		public abstract PMS.Entities.DieuKhoan GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;DieuKhoan&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;DieuKhoan&gt;"/></returns>
		public static TList<DieuKhoan> Fill(IDataReader reader, TList<DieuKhoan> rows, int start, int pageLength)
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
				
				PMS.Entities.DieuKhoan c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("DieuKhoan")
					.Append("|").Append((System.Int32)reader[((int)DieuKhoanColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<DieuKhoan>(
					key.ToString(), // EntityTrackingKey
					"DieuKhoan",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.DieuKhoan();
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
					c.Id = (System.Int32)reader[(DieuKhoanColumn.Id.ToString())];
					c.ParentId = (reader[DieuKhoanColumn.ParentId.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DieuKhoanColumn.ParentId.ToString())];
					c.PhanLoai = (reader[DieuKhoanColumn.PhanLoai.ToString()] == DBNull.Value) ? null : (System.String)reader[(DieuKhoanColumn.PhanLoai.ToString())];
					c.Menu = (reader[DieuKhoanColumn.Menu.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(DieuKhoanColumn.Menu.ToString())];
					c.BeginGroup = (reader[DieuKhoanColumn.BeginGroup.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(DieuKhoanColumn.BeginGroup.ToString())];
					c.RibbonStyle = (reader[DieuKhoanColumn.RibbonStyle.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(DieuKhoanColumn.RibbonStyle.ToString())];
					c.DataLayout = (reader[DieuKhoanColumn.DataLayout.ToString()] == DBNull.Value) ? null : (System.Byte[])reader[(DieuKhoanColumn.DataLayout.ToString())];
					c.TenChucNang = (reader[DieuKhoanColumn.TenChucNang.ToString()] == DBNull.Value) ? null : (System.String)reader[(DieuKhoanColumn.TenChucNang.ToString())];
					c.NgayNhap = (reader[DieuKhoanColumn.NgayNhap.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(DieuKhoanColumn.NgayNhap.ToString())];
					c.NguoiNhap = (reader[DieuKhoanColumn.NguoiNhap.ToString()] == DBNull.Value) ? null : (System.String)reader[(DieuKhoanColumn.NguoiNhap.ToString())];
					c.TenForm = (reader[DieuKhoanColumn.TenForm.ToString()] == DBNull.Value) ? null : (System.String)reader[(DieuKhoanColumn.TenForm.ToString())];
					c.HinhAnh = (reader[DieuKhoanColumn.HinhAnh.ToString()] == DBNull.Value) ? null : (System.Byte[])reader[(DieuKhoanColumn.HinhAnh.ToString())];
					c.ThuTu = (reader[DieuKhoanColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DieuKhoanColumn.ThuTu.ToString())];
					c.TenPhuongThuc = (reader[DieuKhoanColumn.TenPhuongThuc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DieuKhoanColumn.TenPhuongThuc.ToString())];
					c.ThamSo = (reader[DieuKhoanColumn.ThamSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(DieuKhoanColumn.ThamSo.ToString())];
					c.KieuForm = (reader[DieuKhoanColumn.KieuForm.ToString()] == DBNull.Value) ? null : (System.String)reader[(DieuKhoanColumn.KieuForm.ToString())];
					c.NoiDung = (reader[DieuKhoanColumn.NoiDung.ToString()] == DBNull.Value) ? null : (System.String)reader[(DieuKhoanColumn.NoiDung.ToString())];
					c.TrangThai = (reader[DieuKhoanColumn.TrangThai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(DieuKhoanColumn.TrangThai.ToString())];
					c.TrangThaiChot = (reader[DieuKhoanColumn.TrangThaiChot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(DieuKhoanColumn.TrangThaiChot.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DieuKhoan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DieuKhoan"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.DieuKhoan entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(DieuKhoanColumn.Id.ToString())];
			entity.ParentId = (reader[DieuKhoanColumn.ParentId.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DieuKhoanColumn.ParentId.ToString())];
			entity.PhanLoai = (reader[DieuKhoanColumn.PhanLoai.ToString()] == DBNull.Value) ? null : (System.String)reader[(DieuKhoanColumn.PhanLoai.ToString())];
			entity.Menu = (reader[DieuKhoanColumn.Menu.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(DieuKhoanColumn.Menu.ToString())];
			entity.BeginGroup = (reader[DieuKhoanColumn.BeginGroup.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(DieuKhoanColumn.BeginGroup.ToString())];
			entity.RibbonStyle = (reader[DieuKhoanColumn.RibbonStyle.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(DieuKhoanColumn.RibbonStyle.ToString())];
			entity.DataLayout = (reader[DieuKhoanColumn.DataLayout.ToString()] == DBNull.Value) ? null : (System.Byte[])reader[(DieuKhoanColumn.DataLayout.ToString())];
			entity.TenChucNang = (reader[DieuKhoanColumn.TenChucNang.ToString()] == DBNull.Value) ? null : (System.String)reader[(DieuKhoanColumn.TenChucNang.ToString())];
			entity.NgayNhap = (reader[DieuKhoanColumn.NgayNhap.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(DieuKhoanColumn.NgayNhap.ToString())];
			entity.NguoiNhap = (reader[DieuKhoanColumn.NguoiNhap.ToString()] == DBNull.Value) ? null : (System.String)reader[(DieuKhoanColumn.NguoiNhap.ToString())];
			entity.TenForm = (reader[DieuKhoanColumn.TenForm.ToString()] == DBNull.Value) ? null : (System.String)reader[(DieuKhoanColumn.TenForm.ToString())];
			entity.HinhAnh = (reader[DieuKhoanColumn.HinhAnh.ToString()] == DBNull.Value) ? null : (System.Byte[])reader[(DieuKhoanColumn.HinhAnh.ToString())];
			entity.ThuTu = (reader[DieuKhoanColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DieuKhoanColumn.ThuTu.ToString())];
			entity.TenPhuongThuc = (reader[DieuKhoanColumn.TenPhuongThuc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DieuKhoanColumn.TenPhuongThuc.ToString())];
			entity.ThamSo = (reader[DieuKhoanColumn.ThamSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(DieuKhoanColumn.ThamSo.ToString())];
			entity.KieuForm = (reader[DieuKhoanColumn.KieuForm.ToString()] == DBNull.Value) ? null : (System.String)reader[(DieuKhoanColumn.KieuForm.ToString())];
			entity.NoiDung = (reader[DieuKhoanColumn.NoiDung.ToString()] == DBNull.Value) ? null : (System.String)reader[(DieuKhoanColumn.NoiDung.ToString())];
			entity.TrangThai = (reader[DieuKhoanColumn.TrangThai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(DieuKhoanColumn.TrangThai.ToString())];
			entity.TrangThaiChot = (reader[DieuKhoanColumn.TrangThaiChot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(DieuKhoanColumn.TrangThaiChot.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DieuKhoan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DieuKhoan"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.DieuKhoan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["ID"];
			entity.ParentId = Convert.IsDBNull(dataRow["ParentID"]) ? null : (System.Int32?)dataRow["ParentID"];
			entity.PhanLoai = Convert.IsDBNull(dataRow["PhanLoai"]) ? null : (System.String)dataRow["PhanLoai"];
			entity.Menu = Convert.IsDBNull(dataRow["Menu"]) ? null : (System.Boolean?)dataRow["Menu"];
			entity.BeginGroup = Convert.IsDBNull(dataRow["BeginGroup"]) ? null : (System.Boolean?)dataRow["BeginGroup"];
			entity.RibbonStyle = Convert.IsDBNull(dataRow["RibbonStyle"]) ? null : (System.Boolean?)dataRow["RibbonStyle"];
			entity.DataLayout = Convert.IsDBNull(dataRow["DataLayout"]) ? null : (System.Byte[])dataRow["DataLayout"];
			entity.TenChucNang = Convert.IsDBNull(dataRow["TenChucNang"]) ? null : (System.String)dataRow["TenChucNang"];
			entity.NgayNhap = Convert.IsDBNull(dataRow["NgayNhap"]) ? null : (System.DateTime?)dataRow["NgayNhap"];
			entity.NguoiNhap = Convert.IsDBNull(dataRow["NguoiNhap"]) ? null : (System.String)dataRow["NguoiNhap"];
			entity.TenForm = Convert.IsDBNull(dataRow["TenForm"]) ? null : (System.String)dataRow["TenForm"];
			entity.HinhAnh = Convert.IsDBNull(dataRow["HinhAnh"]) ? null : (System.Byte[])dataRow["HinhAnh"];
			entity.ThuTu = Convert.IsDBNull(dataRow["ThuTu"]) ? null : (System.Int32?)dataRow["ThuTu"];
			entity.TenPhuongThuc = Convert.IsDBNull(dataRow["TenPhuongThuc"]) ? null : (System.String)dataRow["TenPhuongThuc"];
			entity.ThamSo = Convert.IsDBNull(dataRow["ThamSo"]) ? null : (System.String)dataRow["ThamSo"];
			entity.KieuForm = Convert.IsDBNull(dataRow["KieuForm"]) ? null : (System.String)dataRow["KieuForm"];
			entity.NoiDung = Convert.IsDBNull(dataRow["NoiDung"]) ? null : (System.String)dataRow["NoiDung"];
			entity.TrangThai = Convert.IsDBNull(dataRow["TrangThai"]) ? null : (System.Boolean?)dataRow["TrangThai"];
			entity.TrangThaiChot = Convert.IsDBNull(dataRow["TrangThaiChot"]) ? null : (System.Boolean?)dataRow["TrangThaiChot"];
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
		/// <param name="entity">The <see cref="PMS.Entities.DieuKhoan"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.DieuKhoan Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.DieuKhoan entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region ParentIdSource	
			if (CanDeepLoad(entity, "DieuKhoan|ParentIdSource", deepLoadType, innerList) 
				&& entity.ParentIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ParentId ?? (int)0);
				DieuKhoan tmpEntity = EntityManager.LocateEntity<DieuKhoan>(EntityLocator.ConstructKeyFromPkItems(typeof(DieuKhoan), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ParentIdSource = tmpEntity;
				else
					entity.ParentIdSource = DataRepository.DieuKhoanProvider.GetById(transactionManager, (entity.ParentId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ParentIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ParentIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.DieuKhoanProvider.DeepLoad(transactionManager, entity.ParentIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ParentIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetById methods when available
			
			#region DieuKhoanCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<DieuKhoan>|DieuKhoanCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'DieuKhoanCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.DieuKhoanCollection = DataRepository.DieuKhoanProvider.GetByParentId(transactionManager, entity.Id);

				if (deep && entity.DieuKhoanCollection.Count > 0)
				{
					deepHandles.Add("DieuKhoanCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<DieuKhoan>) DataRepository.DieuKhoanProvider.DeepLoad,
						new object[] { transactionManager, entity.DieuKhoanCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
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
		/// Deep Save the entire object graph of the PMS.Entities.DieuKhoan object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.DieuKhoan instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.DieuKhoan Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.DieuKhoan entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region ParentIdSource
			if (CanDeepSave(entity, "DieuKhoan|ParentIdSource", deepSaveType, innerList) 
				&& entity.ParentIdSource != null)
			{
				DataRepository.DieuKhoanProvider.Save(transactionManager, entity.ParentIdSource);
				entity.ParentId = entity.ParentIdSource.Id;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<DieuKhoan>
				if (CanDeepSave(entity.DieuKhoanCollection, "List<DieuKhoan>|DieuKhoanCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(DieuKhoan child in entity.DieuKhoanCollection)
					{
						if(child.ParentIdSource != null)
						{
							child.ParentId = child.ParentIdSource.Id;
						}
						else
						{
							child.ParentId = entity.Id;
						}

					}

					if (entity.DieuKhoanCollection.Count > 0 || entity.DieuKhoanCollection.DeletedItems.Count > 0)
					{
						//DataRepository.DieuKhoanProvider.Save(transactionManager, entity.DieuKhoanCollection);
						
						deepHandles.Add("DieuKhoanCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< DieuKhoan >) DataRepository.DieuKhoanProvider.DeepSave,
							new object[] { transactionManager, entity.DieuKhoanCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
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
	
	#region DieuKhoanChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.DieuKhoan</c>
	///</summary>
	public enum DieuKhoanChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>DieuKhoan</c> at ParentIdSource
		///</summary>
		[ChildEntityType(typeof(DieuKhoan))]
		DieuKhoan,
		///<summary>
		/// Collection of <c>DieuKhoan</c> as OneToMany for DieuKhoanCollection
		///</summary>
		[ChildEntityType(typeof(TList<DieuKhoan>))]
		DieuKhoanCollection,
	}
	
	#endregion DieuKhoanChildEntityTypes
	
	#region DieuKhoanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;DieuKhoanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DieuKhoan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DieuKhoanFilterBuilder : SqlFilterBuilder<DieuKhoanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DieuKhoanFilterBuilder class.
		/// </summary>
		public DieuKhoanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DieuKhoanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DieuKhoanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DieuKhoanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DieuKhoanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DieuKhoanFilterBuilder
	
	#region DieuKhoanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;DieuKhoanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DieuKhoan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DieuKhoanParameterBuilder : ParameterizedSqlFilterBuilder<DieuKhoanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DieuKhoanParameterBuilder class.
		/// </summary>
		public DieuKhoanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DieuKhoanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DieuKhoanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DieuKhoanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DieuKhoanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DieuKhoanParameterBuilder
	
	#region DieuKhoanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;DieuKhoanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DieuKhoan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class DieuKhoanSortBuilder : SqlSortBuilder<DieuKhoanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DieuKhoanSqlSortBuilder class.
		/// </summary>
		public DieuKhoanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion DieuKhoanSortBuilder
	
} // end namespace
