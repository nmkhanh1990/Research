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
	/// This class is the base class for any <see cref="ThanhToanTienKhacProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ThanhToanTienKhacProviderBaseCore : EntityProviderBase<PMS.Entities.ThanhToanTienKhac, PMS.Entities.ThanhToanTienKhacKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ThanhToanTienKhacKey key)
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
		public override PMS.Entities.ThanhToanTienKhac Get(TransactionManager transactionManager, PMS.Entities.ThanhToanTienKhacKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__ThanhToa__3214EC073740C056 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhToanTienKhac"/> class.</returns>
		public PMS.Entities.ThanhToanTienKhac GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__ThanhToa__3214EC073740C056 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhToanTienKhac"/> class.</returns>
		public PMS.Entities.ThanhToanTienKhac GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__ThanhToa__3214EC073740C056 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhToanTienKhac"/> class.</returns>
		public PMS.Entities.ThanhToanTienKhac GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__ThanhToa__3214EC073740C056 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhToanTienKhac"/> class.</returns>
		public PMS.Entities.ThanhToanTienKhac GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__ThanhToa__3214EC073740C056 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhToanTienKhac"/> class.</returns>
		public PMS.Entities.ThanhToanTienKhac GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__ThanhToa__3214EC073740C056 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhToanTienKhac"/> class.</returns>
		public abstract PMS.Entities.ThanhToanTienKhac GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_ThanhToanTienKhac_LuuXacNhanChiTra 
		
		/// <summary>
		///	This method wrap the 'cust_ThanhToanTienKhac_LuuXacNhanChiTra' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuXacNhanChiTra(System.String xmlData, ref System.Int32 reVal)
		{
			 LuuXacNhanChiTra(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhToanTienKhac_LuuXacNhanChiTra' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuXacNhanChiTra(int start, int pageLength, System.String xmlData, ref System.Int32 reVal)
		{
			 LuuXacNhanChiTra(null, start, pageLength , xmlData, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThanhToanTienKhac_LuuXacNhanChiTra' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuXacNhanChiTra(TransactionManager transactionManager, System.String xmlData, ref System.Int32 reVal)
		{
			 LuuXacNhanChiTra(transactionManager, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhToanTienKhac_LuuXacNhanChiTra' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuXacNhanChiTra(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ThanhToanTienKhac&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ThanhToanTienKhac&gt;"/></returns>
		public static TList<ThanhToanTienKhac> Fill(IDataReader reader, TList<ThanhToanTienKhac> rows, int start, int pageLength)
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
				
				PMS.Entities.ThanhToanTienKhac c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ThanhToanTienKhac")
					.Append("|").Append((System.Int32)reader[((int)ThanhToanTienKhacColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ThanhToanTienKhac>(
					key.ToString(), // EntityTrackingKey
					"ThanhToanTienKhac",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ThanhToanTienKhac();
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
					c.Id = (System.Int32)reader[(ThanhToanTienKhacColumn.Id.ToString())];
					c.MaGiangVien = (reader[ThanhToanTienKhacColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhToanTienKhacColumn.MaGiangVien.ToString())];
					c.MaLopHocPhan = (reader[ThanhToanTienKhacColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhToanTienKhacColumn.MaLopHocPhan.ToString())];
					c.MaHoatDong = (reader[ThanhToanTienKhacColumn.MaHoatDong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhToanTienKhacColumn.MaHoatDong.ToString())];
					c.SoTietDaiTra = (reader[ThanhToanTienKhacColumn.SoTietDaiTra.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanTienKhacColumn.SoTietDaiTra.ToString())];
					c.DonGiaDaiTra = (reader[ThanhToanTienKhacColumn.DonGiaDaiTra.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanTienKhacColumn.DonGiaDaiTra.ToString())];
					c.SoTietClc = (reader[ThanhToanTienKhacColumn.SoTietClc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanTienKhacColumn.SoTietClc.ToString())];
					c.DonGiaClc = (reader[ThanhToanTienKhacColumn.DonGiaClc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanTienKhacColumn.DonGiaClc.ToString())];
					c.NgayCapNhat = (reader[ThanhToanTienKhacColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThanhToanTienKhacColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[ThanhToanTienKhacColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhToanTienKhacColumn.NguoiCapNhat.ToString())];
					c.NgayChiTra = (reader[ThanhToanTienKhacColumn.NgayChiTra.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThanhToanTienKhacColumn.NgayChiTra.ToString())];
					c.XacNhanChiTra = (reader[ThanhToanTienKhacColumn.XacNhanChiTra.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThanhToanTienKhacColumn.XacNhanChiTra.ToString())];
					c.GhiChu = (reader[ThanhToanTienKhacColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhToanTienKhacColumn.GhiChu.ToString())];
					c.NamHoc = (reader[ThanhToanTienKhacColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhToanTienKhacColumn.NamHoc.ToString())];
					c.HocKy = (reader[ThanhToanTienKhacColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhToanTienKhacColumn.HocKy.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThanhToanTienKhac"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThanhToanTienKhac"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ThanhToanTienKhac entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(ThanhToanTienKhacColumn.Id.ToString())];
			entity.MaGiangVien = (reader[ThanhToanTienKhacColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhToanTienKhacColumn.MaGiangVien.ToString())];
			entity.MaLopHocPhan = (reader[ThanhToanTienKhacColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhToanTienKhacColumn.MaLopHocPhan.ToString())];
			entity.MaHoatDong = (reader[ThanhToanTienKhacColumn.MaHoatDong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhToanTienKhacColumn.MaHoatDong.ToString())];
			entity.SoTietDaiTra = (reader[ThanhToanTienKhacColumn.SoTietDaiTra.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanTienKhacColumn.SoTietDaiTra.ToString())];
			entity.DonGiaDaiTra = (reader[ThanhToanTienKhacColumn.DonGiaDaiTra.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanTienKhacColumn.DonGiaDaiTra.ToString())];
			entity.SoTietClc = (reader[ThanhToanTienKhacColumn.SoTietClc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanTienKhacColumn.SoTietClc.ToString())];
			entity.DonGiaClc = (reader[ThanhToanTienKhacColumn.DonGiaClc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanTienKhacColumn.DonGiaClc.ToString())];
			entity.NgayCapNhat = (reader[ThanhToanTienKhacColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThanhToanTienKhacColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[ThanhToanTienKhacColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhToanTienKhacColumn.NguoiCapNhat.ToString())];
			entity.NgayChiTra = (reader[ThanhToanTienKhacColumn.NgayChiTra.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThanhToanTienKhacColumn.NgayChiTra.ToString())];
			entity.XacNhanChiTra = (reader[ThanhToanTienKhacColumn.XacNhanChiTra.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThanhToanTienKhacColumn.XacNhanChiTra.ToString())];
			entity.GhiChu = (reader[ThanhToanTienKhacColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhToanTienKhacColumn.GhiChu.ToString())];
			entity.NamHoc = (reader[ThanhToanTienKhacColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhToanTienKhacColumn.NamHoc.ToString())];
			entity.HocKy = (reader[ThanhToanTienKhacColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhToanTienKhacColumn.HocKy.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThanhToanTienKhac"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThanhToanTienKhac"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ThanhToanTienKhac entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.String)dataRow["MaGiangVien"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.MaHoatDong = Convert.IsDBNull(dataRow["MaHoatDong"]) ? null : (System.Int32?)dataRow["MaHoatDong"];
			entity.SoTietDaiTra = Convert.IsDBNull(dataRow["SoTietDaiTra"]) ? null : (System.Decimal?)dataRow["SoTietDaiTra"];
			entity.DonGiaDaiTra = Convert.IsDBNull(dataRow["DonGiaDaiTra"]) ? null : (System.Decimal?)dataRow["DonGiaDaiTra"];
			entity.SoTietClc = Convert.IsDBNull(dataRow["SoTietClc"]) ? null : (System.Decimal?)dataRow["SoTietClc"];
			entity.DonGiaClc = Convert.IsDBNull(dataRow["DonGiaClc"]) ? null : (System.Decimal?)dataRow["DonGiaClc"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.NgayChiTra = Convert.IsDBNull(dataRow["NgayChiTra"]) ? null : (System.DateTime?)dataRow["NgayChiTra"];
			entity.XacNhanChiTra = Convert.IsDBNull(dataRow["XacNhanChiTra"]) ? null : (System.Boolean?)dataRow["XacNhanChiTra"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ThanhToanTienKhac"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ThanhToanTienKhac Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ThanhToanTienKhac entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.ThanhToanTienKhac object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ThanhToanTienKhac instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ThanhToanTienKhac Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ThanhToanTienKhac entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region ThanhToanTienKhacChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ThanhToanTienKhac</c>
	///</summary>
	public enum ThanhToanTienKhacChildEntityTypes
	{
	}
	
	#endregion ThanhToanTienKhacChildEntityTypes
	
	#region ThanhToanTienKhacFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ThanhToanTienKhacColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhToanTienKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThanhToanTienKhacFilterBuilder : SqlFilterBuilder<ThanhToanTienKhacColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhToanTienKhacFilterBuilder class.
		/// </summary>
		public ThanhToanTienKhacFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThanhToanTienKhacFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThanhToanTienKhacFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThanhToanTienKhacFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThanhToanTienKhacFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThanhToanTienKhacFilterBuilder
	
	#region ThanhToanTienKhacParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ThanhToanTienKhacColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhToanTienKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThanhToanTienKhacParameterBuilder : ParameterizedSqlFilterBuilder<ThanhToanTienKhacColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhToanTienKhacParameterBuilder class.
		/// </summary>
		public ThanhToanTienKhacParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThanhToanTienKhacParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThanhToanTienKhacParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThanhToanTienKhacParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThanhToanTienKhacParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThanhToanTienKhacParameterBuilder
	
	#region ThanhToanTienKhacSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ThanhToanTienKhacColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhToanTienKhac"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ThanhToanTienKhacSortBuilder : SqlSortBuilder<ThanhToanTienKhacColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhToanTienKhacSqlSortBuilder class.
		/// </summary>
		public ThanhToanTienKhacSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ThanhToanTienKhacSortBuilder
	
} // end namespace
