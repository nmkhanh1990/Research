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
	/// This class is the base class for any <see cref="GiangVienPhucCapProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GiangVienPhucCapProviderBaseCore : EntityProviderBase<PMS.Entities.GiangVienPhucCap, PMS.Entities.GiangVienPhucCapKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.GiangVienPhucCapKey key)
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
		public override PMS.Entities.GiangVienPhucCap Get(TransactionManager transactionManager, PMS.Entities.GiangVienPhucCapKey key, int start, int pageLength)
		{
			return GetByMaQuanLy(transactionManager, key.MaQuanLy, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__GiangVie__2AB9EAF8EBD348FC index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienPhucCap"/> class.</returns>
		public PMS.Entities.GiangVienPhucCap GetByMaQuanLy(System.Int32 _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(null,_maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__2AB9EAF8EBD348FC index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienPhucCap"/> class.</returns>
		public PMS.Entities.GiangVienPhucCap GetByMaQuanLy(System.Int32 _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__2AB9EAF8EBD348FC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienPhucCap"/> class.</returns>
		public PMS.Entities.GiangVienPhucCap GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__2AB9EAF8EBD348FC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienPhucCap"/> class.</returns>
		public PMS.Entities.GiangVienPhucCap GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__2AB9EAF8EBD348FC index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienPhucCap"/> class.</returns>
		public PMS.Entities.GiangVienPhucCap GetByMaQuanLy(System.Int32 _maQuanLy, int start, int pageLength, out int count)
		{
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__2AB9EAF8EBD348FC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienPhucCap"/> class.</returns>
		public abstract PMS.Entities.GiangVienPhucCap GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_GiangVien_PhucCap_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_PhucCap_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienPhucCap&gt;"/> instance.</returns>
		public TList<GiangVienPhucCap> GetByNamHocHocKy(System.String namHoc, System.String hocKy, System.String donVi)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy, donVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_PhucCap_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienPhucCap&gt;"/> instance.</returns>
		public TList<GiangVienPhucCap> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy, donVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_PhucCap_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienPhucCap&gt;"/> instance.</returns>
		public TList<GiangVienPhucCap> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_PhucCap_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienPhucCap&gt;"/> instance.</returns>
		public abstract TList<GiangVienPhucCap> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String donVi);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GiangVienPhucCap&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GiangVienPhucCap&gt;"/></returns>
		public static TList<GiangVienPhucCap> Fill(IDataReader reader, TList<GiangVienPhucCap> rows, int start, int pageLength)
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
				
				PMS.Entities.GiangVienPhucCap c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GiangVienPhucCap")
					.Append("|").Append((System.Int32)reader[((int)GiangVienPhucCapColumn.MaQuanLy - 1)]).ToString();
					c = EntityManager.LocateOrCreate<GiangVienPhucCap>(
					key.ToString(), // EntityTrackingKey
					"GiangVienPhucCap",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.GiangVienPhucCap();
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
					c.MaQuanLy = (System.Int32)reader[(GiangVienPhucCapColumn.MaQuanLy.ToString())];
					c.MaGiangVien = (reader[GiangVienPhucCapColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienPhucCapColumn.MaGiangVien.ToString())];
					c.NamHoc = (reader[GiangVienPhucCapColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhucCapColumn.NamHoc.ToString())];
					c.HocKy = (reader[GiangVienPhucCapColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhucCapColumn.HocKy.ToString())];
					c.SoDot = (reader[GiangVienPhucCapColumn.SoDot.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienPhucCapColumn.SoDot.ToString())];
					c.SoNgay = (reader[GiangVienPhucCapColumn.SoNgay.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienPhucCapColumn.SoNgay.ToString())];
					c.NgayCapNhat = (reader[GiangVienPhucCapColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienPhucCapColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[GiangVienPhucCapColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhucCapColumn.NguoiCapNhat.ToString())];
					c.TinhTrang = (reader[GiangVienPhucCapColumn.TinhTrang.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienPhucCapColumn.TinhTrang.ToString())];
					c.GhiChu = (reader[GiangVienPhucCapColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhucCapColumn.GhiChu.ToString())];
					c.MaPhuCap = (reader[GiangVienPhucCapColumn.MaPhuCap.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhucCapColumn.MaPhuCap.ToString())];
					c.MaLopHocPhan = (reader[GiangVienPhucCapColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhucCapColumn.MaLopHocPhan.ToString())];
					c.MaMonHoc = (reader[GiangVienPhucCapColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhucCapColumn.MaMonHoc.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienPhucCap"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienPhucCap"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.GiangVienPhucCap entity)
		{
			if (!reader.Read()) return;
			
			entity.MaQuanLy = (System.Int32)reader[(GiangVienPhucCapColumn.MaQuanLy.ToString())];
			entity.MaGiangVien = (reader[GiangVienPhucCapColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienPhucCapColumn.MaGiangVien.ToString())];
			entity.NamHoc = (reader[GiangVienPhucCapColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhucCapColumn.NamHoc.ToString())];
			entity.HocKy = (reader[GiangVienPhucCapColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhucCapColumn.HocKy.ToString())];
			entity.SoDot = (reader[GiangVienPhucCapColumn.SoDot.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienPhucCapColumn.SoDot.ToString())];
			entity.SoNgay = (reader[GiangVienPhucCapColumn.SoNgay.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienPhucCapColumn.SoNgay.ToString())];
			entity.NgayCapNhat = (reader[GiangVienPhucCapColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienPhucCapColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[GiangVienPhucCapColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhucCapColumn.NguoiCapNhat.ToString())];
			entity.TinhTrang = (reader[GiangVienPhucCapColumn.TinhTrang.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienPhucCapColumn.TinhTrang.ToString())];
			entity.GhiChu = (reader[GiangVienPhucCapColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhucCapColumn.GhiChu.ToString())];
			entity.MaPhuCap = (reader[GiangVienPhucCapColumn.MaPhuCap.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhucCapColumn.MaPhuCap.ToString())];
			entity.MaLopHocPhan = (reader[GiangVienPhucCapColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhucCapColumn.MaLopHocPhan.ToString())];
			entity.MaMonHoc = (reader[GiangVienPhucCapColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhucCapColumn.MaMonHoc.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienPhucCap"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienPhucCap"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.GiangVienPhucCap entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaQuanLy = (System.Int32)dataRow["MaQuanLy"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.SoDot = Convert.IsDBNull(dataRow["SoDot"]) ? null : (System.Int32?)dataRow["SoDot"];
			entity.SoNgay = Convert.IsDBNull(dataRow["SoNgay"]) ? null : (System.Int32?)dataRow["SoNgay"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.TinhTrang = Convert.IsDBNull(dataRow["TinhTrang"]) ? null : (System.Boolean?)dataRow["TinhTrang"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.MaPhuCap = Convert.IsDBNull(dataRow["MaPhuCap"]) ? null : (System.String)dataRow["MaPhuCap"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
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
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienPhucCap"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienPhucCap Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.GiangVienPhucCap entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.GiangVienPhucCap object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.GiangVienPhucCap instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienPhucCap Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.GiangVienPhucCap entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region GiangVienPhucCapChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.GiangVienPhucCap</c>
	///</summary>
	public enum GiangVienPhucCapChildEntityTypes
	{
	}
	
	#endregion GiangVienPhucCapChildEntityTypes
	
	#region GiangVienPhucCapFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GiangVienPhucCapColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienPhucCap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienPhucCapFilterBuilder : SqlFilterBuilder<GiangVienPhucCapColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienPhucCapFilterBuilder class.
		/// </summary>
		public GiangVienPhucCapFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienPhucCapFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienPhucCapFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienPhucCapFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienPhucCapFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienPhucCapFilterBuilder
	
	#region GiangVienPhucCapParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GiangVienPhucCapColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienPhucCap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienPhucCapParameterBuilder : ParameterizedSqlFilterBuilder<GiangVienPhucCapColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienPhucCapParameterBuilder class.
		/// </summary>
		public GiangVienPhucCapParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienPhucCapParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienPhucCapParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienPhucCapParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienPhucCapParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienPhucCapParameterBuilder
	
	#region GiangVienPhucCapSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GiangVienPhucCapColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienPhucCap"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GiangVienPhucCapSortBuilder : SqlSortBuilder<GiangVienPhucCapColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienPhucCapSqlSortBuilder class.
		/// </summary>
		public GiangVienPhucCapSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GiangVienPhucCapSortBuilder
	
} // end namespace
