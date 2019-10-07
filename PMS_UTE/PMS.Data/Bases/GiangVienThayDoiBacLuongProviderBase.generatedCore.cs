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
	/// This class is the base class for any <see cref="GiangVienThayDoiBacLuongProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GiangVienThayDoiBacLuongProviderBaseCore : EntityProviderBase<PMS.Entities.GiangVienThayDoiBacLuong, PMS.Entities.GiangVienThayDoiBacLuongKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.GiangVienThayDoiBacLuongKey key)
		{
			return Delete(transactionManager, key.MaQuanLy);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maQuanLy">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maQuanLy)
		{
			return Delete(null, _maQuanLy);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maQuanLy);		
		
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
		public override PMS.Entities.GiangVienThayDoiBacLuong Get(TransactionManager transactionManager, PMS.Entities.GiangVienThayDoiBacLuongKey key, int start, int pageLength)
		{
			return GetByMaQuanLy(transactionManager, key.MaQuanLy, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__GiangVie__2AB9EAF8307D3E5C index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienThayDoiBacLuong"/> class.</returns>
		public PMS.Entities.GiangVienThayDoiBacLuong GetByMaQuanLy(System.Int32 _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(null,_maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__2AB9EAF8307D3E5C index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienThayDoiBacLuong"/> class.</returns>
		public PMS.Entities.GiangVienThayDoiBacLuong GetByMaQuanLy(System.Int32 _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__2AB9EAF8307D3E5C index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienThayDoiBacLuong"/> class.</returns>
		public PMS.Entities.GiangVienThayDoiBacLuong GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__2AB9EAF8307D3E5C index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienThayDoiBacLuong"/> class.</returns>
		public PMS.Entities.GiangVienThayDoiBacLuong GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__2AB9EAF8307D3E5C index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienThayDoiBacLuong"/> class.</returns>
		public PMS.Entities.GiangVienThayDoiBacLuong GetByMaQuanLy(System.Int32 _maQuanLy, int start, int pageLength, out int count)
		{
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__2AB9EAF8307D3E5C index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienThayDoiBacLuong"/> class.</returns>
		public abstract PMS.Entities.GiangVienThayDoiBacLuong GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_GiangVienThayDoiBacLuong_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienThayDoiBacLuong_Luu' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maBacLuongCu"> A <c>System.Int32</c> instance.</param>
		/// <param name="maBacLuongMoi"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayHieuLuc"> A <c>System.DateTime</c> instance.</param>
		/// <param name="ngayCapNhat"> A <c>System.DateTime</c> instance.</param>
		/// <param name="user"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.Int32 maGiangVien, System.Int32 maBacLuongCu, System.Int32 maBacLuongMoi, System.DateTime ngayHieuLuc, System.DateTime ngayCapNhat, System.String user, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , maGiangVien, maBacLuongCu, maBacLuongMoi, ngayHieuLuc, ngayCapNhat, user, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienThayDoiBacLuong_Luu' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maBacLuongCu"> A <c>System.Int32</c> instance.</param>
		/// <param name="maBacLuongMoi"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayHieuLuc"> A <c>System.DateTime</c> instance.</param>
		/// <param name="ngayCapNhat"> A <c>System.DateTime</c> instance.</param>
		/// <param name="user"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.Int32 maGiangVien, System.Int32 maBacLuongCu, System.Int32 maBacLuongMoi, System.DateTime ngayHieuLuc, System.DateTime ngayCapNhat, System.String user, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , maGiangVien, maBacLuongCu, maBacLuongMoi, ngayHieuLuc, ngayCapNhat, user, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienThayDoiBacLuong_Luu' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maBacLuongCu"> A <c>System.Int32</c> instance.</param>
		/// <param name="maBacLuongMoi"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayHieuLuc"> A <c>System.DateTime</c> instance.</param>
		/// <param name="ngayCapNhat"> A <c>System.DateTime</c> instance.</param>
		/// <param name="user"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.Int32 maGiangVien, System.Int32 maBacLuongCu, System.Int32 maBacLuongMoi, System.DateTime ngayHieuLuc, System.DateTime ngayCapNhat, System.String user, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , maGiangVien, maBacLuongCu, maBacLuongMoi, ngayHieuLuc, ngayCapNhat, user, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienThayDoiBacLuong_Luu' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maBacLuongCu"> A <c>System.Int32</c> instance.</param>
		/// <param name="maBacLuongMoi"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayHieuLuc"> A <c>System.DateTime</c> instance.</param>
		/// <param name="ngayCapNhat"> A <c>System.DateTime</c> instance.</param>
		/// <param name="user"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.Int32 maGiangVien, System.Int32 maBacLuongCu, System.Int32 maBacLuongMoi, System.DateTime ngayHieuLuc, System.DateTime ngayCapNhat, System.String user, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GiangVienThayDoiBacLuong&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GiangVienThayDoiBacLuong&gt;"/></returns>
		public static TList<GiangVienThayDoiBacLuong> Fill(IDataReader reader, TList<GiangVienThayDoiBacLuong> rows, int start, int pageLength)
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
				
				PMS.Entities.GiangVienThayDoiBacLuong c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GiangVienThayDoiBacLuong")
					.Append("|").Append((System.Int32)reader[((int)GiangVienThayDoiBacLuongColumn.MaQuanLy - 1)]).ToString();
					c = EntityManager.LocateOrCreate<GiangVienThayDoiBacLuong>(
					key.ToString(), // EntityTrackingKey
					"GiangVienThayDoiBacLuong",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.GiangVienThayDoiBacLuong();
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
					c.MaQuanLy = (System.Int32)reader[(GiangVienThayDoiBacLuongColumn.MaQuanLy.ToString())];
					c.OriginalMaQuanLy = c.MaQuanLy;
					c.MaGiangVien = (reader[GiangVienThayDoiBacLuongColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienThayDoiBacLuongColumn.MaGiangVien.ToString())];
					c.MaBacLuongCu = (reader[GiangVienThayDoiBacLuongColumn.MaBacLuongCu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienThayDoiBacLuongColumn.MaBacLuongCu.ToString())];
					c.MaBacLuong = (reader[GiangVienThayDoiBacLuongColumn.MaBacLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienThayDoiBacLuongColumn.MaBacLuong.ToString())];
					c.NgayHieuLuc = (reader[GiangVienThayDoiBacLuongColumn.NgayHieuLuc.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienThayDoiBacLuongColumn.NgayHieuLuc.ToString())];
					c.NgayCapNhat = (reader[GiangVienThayDoiBacLuongColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienThayDoiBacLuongColumn.NgayCapNhat.ToString())];
					c.UserId = (reader[GiangVienThayDoiBacLuongColumn.UserId.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienThayDoiBacLuongColumn.UserId.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienThayDoiBacLuong"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienThayDoiBacLuong"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.GiangVienThayDoiBacLuong entity)
		{
			if (!reader.Read()) return;
			
			entity.MaQuanLy = (System.Int32)reader[(GiangVienThayDoiBacLuongColumn.MaQuanLy.ToString())];
			entity.OriginalMaQuanLy = (System.Int32)reader["MaQuanLy"];
			entity.MaGiangVien = (reader[GiangVienThayDoiBacLuongColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienThayDoiBacLuongColumn.MaGiangVien.ToString())];
			entity.MaBacLuongCu = (reader[GiangVienThayDoiBacLuongColumn.MaBacLuongCu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienThayDoiBacLuongColumn.MaBacLuongCu.ToString())];
			entity.MaBacLuong = (reader[GiangVienThayDoiBacLuongColumn.MaBacLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienThayDoiBacLuongColumn.MaBacLuong.ToString())];
			entity.NgayHieuLuc = (reader[GiangVienThayDoiBacLuongColumn.NgayHieuLuc.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienThayDoiBacLuongColumn.NgayHieuLuc.ToString())];
			entity.NgayCapNhat = (reader[GiangVienThayDoiBacLuongColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienThayDoiBacLuongColumn.NgayCapNhat.ToString())];
			entity.UserId = (reader[GiangVienThayDoiBacLuongColumn.UserId.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienThayDoiBacLuongColumn.UserId.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienThayDoiBacLuong"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienThayDoiBacLuong"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.GiangVienThayDoiBacLuong entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaQuanLy = (System.Int32)dataRow["MaQuanLy"];
			entity.OriginalMaQuanLy = (System.Int32)dataRow["MaQuanLy"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.MaBacLuongCu = Convert.IsDBNull(dataRow["MaBacLuongCu"]) ? null : (System.Int32?)dataRow["MaBacLuongCu"];
			entity.MaBacLuong = Convert.IsDBNull(dataRow["MaBacLuong"]) ? null : (System.Int32?)dataRow["MaBacLuong"];
			entity.NgayHieuLuc = Convert.IsDBNull(dataRow["NgayHieuLuc"]) ? null : (System.DateTime?)dataRow["NgayHieuLuc"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.UserId = Convert.IsDBNull(dataRow["UserID"]) ? null : (System.String)dataRow["UserID"];
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
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienThayDoiBacLuong"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienThayDoiBacLuong Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.GiangVienThayDoiBacLuong entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.GiangVienThayDoiBacLuong object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.GiangVienThayDoiBacLuong instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienThayDoiBacLuong Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.GiangVienThayDoiBacLuong entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region GiangVienThayDoiBacLuongChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.GiangVienThayDoiBacLuong</c>
	///</summary>
	public enum GiangVienThayDoiBacLuongChildEntityTypes
	{
	}
	
	#endregion GiangVienThayDoiBacLuongChildEntityTypes
	
	#region GiangVienThayDoiBacLuongFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GiangVienThayDoiBacLuongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienThayDoiBacLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienThayDoiBacLuongFilterBuilder : SqlFilterBuilder<GiangVienThayDoiBacLuongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiBacLuongFilterBuilder class.
		/// </summary>
		public GiangVienThayDoiBacLuongFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiBacLuongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienThayDoiBacLuongFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiBacLuongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienThayDoiBacLuongFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienThayDoiBacLuongFilterBuilder
	
	#region GiangVienThayDoiBacLuongParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GiangVienThayDoiBacLuongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienThayDoiBacLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienThayDoiBacLuongParameterBuilder : ParameterizedSqlFilterBuilder<GiangVienThayDoiBacLuongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiBacLuongParameterBuilder class.
		/// </summary>
		public GiangVienThayDoiBacLuongParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiBacLuongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienThayDoiBacLuongParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiBacLuongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienThayDoiBacLuongParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienThayDoiBacLuongParameterBuilder
	
	#region GiangVienThayDoiBacLuongSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GiangVienThayDoiBacLuongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienThayDoiBacLuong"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GiangVienThayDoiBacLuongSortBuilder : SqlSortBuilder<GiangVienThayDoiBacLuongColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiBacLuongSqlSortBuilder class.
		/// </summary>
		public GiangVienThayDoiBacLuongSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GiangVienThayDoiBacLuongSortBuilder
	
} // end namespace
