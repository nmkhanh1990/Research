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
	/// This class is the base class for any <see cref="TrangThaiGiangVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class TrangThaiGiangVienProviderBaseCore : EntityProviderBase<PMS.Entities.TrangThaiGiangVien, PMS.Entities.TrangThaiGiangVienKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.TrangThaiGiangVienKey key)
		{
			return Delete(transactionManager, key.MaKhoa);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maKhoa">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maKhoa)
		{
			return Delete(null, _maKhoa);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoa">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maKhoa);		
		
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
		public override PMS.Entities.TrangThaiGiangVien Get(TransactionManager transactionManager, PMS.Entities.TrangThaiGiangVienKey key, int start, int pageLength)
		{
			return GetByMaKhoa(transactionManager, key.MaKhoa, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__TrangTha__65390405C6C801F6 index.
		/// </summary>
		/// <param name="_maKhoa"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TrangThaiGiangVien"/> class.</returns>
		public PMS.Entities.TrangThaiGiangVien GetByMaKhoa(System.Int32 _maKhoa)
		{
			int count = -1;
			return GetByMaKhoa(null,_maKhoa, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__TrangTha__65390405C6C801F6 index.
		/// </summary>
		/// <param name="_maKhoa"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TrangThaiGiangVien"/> class.</returns>
		public PMS.Entities.TrangThaiGiangVien GetByMaKhoa(System.Int32 _maKhoa, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoa(null, _maKhoa, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__TrangTha__65390405C6C801F6 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoa"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TrangThaiGiangVien"/> class.</returns>
		public PMS.Entities.TrangThaiGiangVien GetByMaKhoa(TransactionManager transactionManager, System.Int32 _maKhoa)
		{
			int count = -1;
			return GetByMaKhoa(transactionManager, _maKhoa, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__TrangTha__65390405C6C801F6 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoa"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TrangThaiGiangVien"/> class.</returns>
		public PMS.Entities.TrangThaiGiangVien GetByMaKhoa(TransactionManager transactionManager, System.Int32 _maKhoa, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoa(transactionManager, _maKhoa, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__TrangTha__65390405C6C801F6 index.
		/// </summary>
		/// <param name="_maKhoa"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TrangThaiGiangVien"/> class.</returns>
		public PMS.Entities.TrangThaiGiangVien GetByMaKhoa(System.Int32 _maKhoa, int start, int pageLength, out int count)
		{
			return GetByMaKhoa(null, _maKhoa, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__TrangTha__65390405C6C801F6 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoa"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TrangThaiGiangVien"/> class.</returns>
		public abstract PMS.Entities.TrangThaiGiangVien GetByMaKhoa(TransactionManager transactionManager, System.Int32 _maKhoa, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_TrangThaiGiangVien_GetGiangVienNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_TrangThaiGiangVien_GetGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="nameFrom"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="where"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;TrangThaiGiangVien&gt;"/> instance.</returns>
		public TList<TrangThaiGiangVien> GetGiangVienNamHocHocKy(System.String nameFrom, System.String namHoc, System.String hocKy, System.String where)
		{
			return GetGiangVienNamHocHocKy(null, 0, int.MaxValue , nameFrom, namHoc, hocKy, where);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TrangThaiGiangVien_GetGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="nameFrom"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="where"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;TrangThaiGiangVien&gt;"/> instance.</returns>
		public TList<TrangThaiGiangVien> GetGiangVienNamHocHocKy(int start, int pageLength, System.String nameFrom, System.String namHoc, System.String hocKy, System.String where)
		{
			return GetGiangVienNamHocHocKy(null, start, pageLength , nameFrom, namHoc, hocKy, where);
		}
				
		/// <summary>
		///	This method wrap the 'cust_TrangThaiGiangVien_GetGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="nameFrom"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="where"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;TrangThaiGiangVien&gt;"/> instance.</returns>
		public TList<TrangThaiGiangVien> GetGiangVienNamHocHocKy(TransactionManager transactionManager, System.String nameFrom, System.String namHoc, System.String hocKy, System.String where)
		{
			return GetGiangVienNamHocHocKy(transactionManager, 0, int.MaxValue , nameFrom, namHoc, hocKy, where);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TrangThaiGiangVien_GetGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="nameFrom"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="where"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;TrangThaiGiangVien&gt;"/> instance.</returns>
		public abstract TList<TrangThaiGiangVien> GetGiangVienNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String nameFrom, System.String namHoc, System.String hocKy, System.String where);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;TrangThaiGiangVien&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;TrangThaiGiangVien&gt;"/></returns>
		public static TList<TrangThaiGiangVien> Fill(IDataReader reader, TList<TrangThaiGiangVien> rows, int start, int pageLength)
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
				
				PMS.Entities.TrangThaiGiangVien c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("TrangThaiGiangVien")
					.Append("|").Append((System.Int32)reader[((int)TrangThaiGiangVienColumn.MaKhoa - 1)]).ToString();
					c = EntityManager.LocateOrCreate<TrangThaiGiangVien>(
					key.ToString(), // EntityTrackingKey
					"TrangThaiGiangVien",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.TrangThaiGiangVien();
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
					c.MaKhoa = (System.Int32)reader[(TrangThaiGiangVienColumn.MaKhoa.ToString())];
					c.MaGiangVien = (reader[TrangThaiGiangVienColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(TrangThaiGiangVienColumn.MaGiangVien.ToString())];
					c.MaLopHocPhan = (reader[TrangThaiGiangVienColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(TrangThaiGiangVienColumn.MaLopHocPhan.ToString())];
					c.IdChucNang = (reader[TrangThaiGiangVienColumn.IdChucNang.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TrangThaiGiangVienColumn.IdChucNang.ToString())];
					c.NgayCapNhat = (reader[TrangThaiGiangVienColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(TrangThaiGiangVienColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[TrangThaiGiangVienColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(TrangThaiGiangVienColumn.NguoiCapNhat.ToString())];
					c.TrangThai = (reader[TrangThaiGiangVienColumn.TrangThai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(TrangThaiGiangVienColumn.TrangThai.ToString())];
					c.NameFrom = (reader[TrangThaiGiangVienColumn.NameFrom.ToString()] == DBNull.Value) ? null : (System.String)reader[(TrangThaiGiangVienColumn.NameFrom.ToString())];
					c.NamHoc = (reader[TrangThaiGiangVienColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(TrangThaiGiangVienColumn.NamHoc.ToString())];
					c.HocKy = (reader[TrangThaiGiangVienColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(TrangThaiGiangVienColumn.HocKy.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.TrangThaiGiangVien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.TrangThaiGiangVien"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.TrangThaiGiangVien entity)
		{
			if (!reader.Read()) return;
			
			entity.MaKhoa = (System.Int32)reader[(TrangThaiGiangVienColumn.MaKhoa.ToString())];
			entity.MaGiangVien = (reader[TrangThaiGiangVienColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(TrangThaiGiangVienColumn.MaGiangVien.ToString())];
			entity.MaLopHocPhan = (reader[TrangThaiGiangVienColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(TrangThaiGiangVienColumn.MaLopHocPhan.ToString())];
			entity.IdChucNang = (reader[TrangThaiGiangVienColumn.IdChucNang.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TrangThaiGiangVienColumn.IdChucNang.ToString())];
			entity.NgayCapNhat = (reader[TrangThaiGiangVienColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(TrangThaiGiangVienColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[TrangThaiGiangVienColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(TrangThaiGiangVienColumn.NguoiCapNhat.ToString())];
			entity.TrangThai = (reader[TrangThaiGiangVienColumn.TrangThai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(TrangThaiGiangVienColumn.TrangThai.ToString())];
			entity.NameFrom = (reader[TrangThaiGiangVienColumn.NameFrom.ToString()] == DBNull.Value) ? null : (System.String)reader[(TrangThaiGiangVienColumn.NameFrom.ToString())];
			entity.NamHoc = (reader[TrangThaiGiangVienColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(TrangThaiGiangVienColumn.NamHoc.ToString())];
			entity.HocKy = (reader[TrangThaiGiangVienColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(TrangThaiGiangVienColumn.HocKy.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.TrangThaiGiangVien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.TrangThaiGiangVien"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.TrangThaiGiangVien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaKhoa = (System.Int32)dataRow["MaKhoa"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.String)dataRow["MaGiangVien"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.IdChucNang = Convert.IsDBNull(dataRow["IdChucNang"]) ? null : (System.Int32?)dataRow["IdChucNang"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.TrangThai = Convert.IsDBNull(dataRow["TrangThai"]) ? null : (System.Boolean?)dataRow["TrangThai"];
			entity.NameFrom = Convert.IsDBNull(dataRow["NameFrom"]) ? null : (System.String)dataRow["NameFrom"];
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
		/// <param name="entity">The <see cref="PMS.Entities.TrangThaiGiangVien"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.TrangThaiGiangVien Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.TrangThaiGiangVien entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.TrangThaiGiangVien object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.TrangThaiGiangVien instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.TrangThaiGiangVien Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.TrangThaiGiangVien entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region TrangThaiGiangVienChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.TrangThaiGiangVien</c>
	///</summary>
	public enum TrangThaiGiangVienChildEntityTypes
	{
	}
	
	#endregion TrangThaiGiangVienChildEntityTypes
	
	#region TrangThaiGiangVienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;TrangThaiGiangVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrangThaiGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrangThaiGiangVienFilterBuilder : SqlFilterBuilder<TrangThaiGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrangThaiGiangVienFilterBuilder class.
		/// </summary>
		public TrangThaiGiangVienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TrangThaiGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TrangThaiGiangVienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TrangThaiGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TrangThaiGiangVienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TrangThaiGiangVienFilterBuilder
	
	#region TrangThaiGiangVienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;TrangThaiGiangVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrangThaiGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrangThaiGiangVienParameterBuilder : ParameterizedSqlFilterBuilder<TrangThaiGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrangThaiGiangVienParameterBuilder class.
		/// </summary>
		public TrangThaiGiangVienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TrangThaiGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TrangThaiGiangVienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TrangThaiGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TrangThaiGiangVienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TrangThaiGiangVienParameterBuilder
	
	#region TrangThaiGiangVienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;TrangThaiGiangVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrangThaiGiangVien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class TrangThaiGiangVienSortBuilder : SqlSortBuilder<TrangThaiGiangVienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrangThaiGiangVienSqlSortBuilder class.
		/// </summary>
		public TrangThaiGiangVienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion TrangThaiGiangVienSortBuilder
	
} // end namespace
