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
	/// This class is the base class for any <see cref="LopHocPhanTheoNhomGiangVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class LopHocPhanTheoNhomGiangVienProviderBaseCore : EntityProviderBase<PMS.Entities.LopHocPhanTheoNhomGiangVien, PMS.Entities.LopHocPhanTheoNhomGiangVienKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.LopHocPhanTheoNhomGiangVienKey key)
		{
			return Delete(transactionManager, key.MaLopHocPhan, key.MaNhomGiangVien);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maLopHocPhan">. Primary Key.</param>
		/// <param name="_maNhomGiangVien">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _maLopHocPhan, System.String _maNhomGiangVien)
		{
			return Delete(null, _maLopHocPhan, _maNhomGiangVien);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan">. Primary Key.</param>
		/// <param name="_maNhomGiangVien">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _maLopHocPhan, System.String _maNhomGiangVien);		
		
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
		public override PMS.Entities.LopHocPhanTheoNhomGiangVien Get(TransactionManager transactionManager, PMS.Entities.LopHocPhanTheoNhomGiangVienKey key, int start, int pageLength)
		{
			return GetByMaLopHocPhanMaNhomGiangVien(transactionManager, key.MaLopHocPhan, key.MaNhomGiangVien, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__LopHocPh__ACA033849CD96D08 index.
		/// </summary>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maNhomGiangVien"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanTheoNhomGiangVien"/> class.</returns>
		public PMS.Entities.LopHocPhanTheoNhomGiangVien GetByMaLopHocPhanMaNhomGiangVien(System.String _maLopHocPhan, System.String _maNhomGiangVien)
		{
			int count = -1;
			return GetByMaLopHocPhanMaNhomGiangVien(null,_maLopHocPhan, _maNhomGiangVien, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LopHocPh__ACA033849CD96D08 index.
		/// </summary>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maNhomGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanTheoNhomGiangVien"/> class.</returns>
		public PMS.Entities.LopHocPhanTheoNhomGiangVien GetByMaLopHocPhanMaNhomGiangVien(System.String _maLopHocPhan, System.String _maNhomGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLopHocPhanMaNhomGiangVien(null, _maLopHocPhan, _maNhomGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LopHocPh__ACA033849CD96D08 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maNhomGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanTheoNhomGiangVien"/> class.</returns>
		public PMS.Entities.LopHocPhanTheoNhomGiangVien GetByMaLopHocPhanMaNhomGiangVien(TransactionManager transactionManager, System.String _maLopHocPhan, System.String _maNhomGiangVien)
		{
			int count = -1;
			return GetByMaLopHocPhanMaNhomGiangVien(transactionManager, _maLopHocPhan, _maNhomGiangVien, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LopHocPh__ACA033849CD96D08 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maNhomGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanTheoNhomGiangVien"/> class.</returns>
		public PMS.Entities.LopHocPhanTheoNhomGiangVien GetByMaLopHocPhanMaNhomGiangVien(TransactionManager transactionManager, System.String _maLopHocPhan, System.String _maNhomGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLopHocPhanMaNhomGiangVien(transactionManager, _maLopHocPhan, _maNhomGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LopHocPh__ACA033849CD96D08 index.
		/// </summary>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maNhomGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanTheoNhomGiangVien"/> class.</returns>
		public PMS.Entities.LopHocPhanTheoNhomGiangVien GetByMaLopHocPhanMaNhomGiangVien(System.String _maLopHocPhan, System.String _maNhomGiangVien, int start, int pageLength, out int count)
		{
			return GetByMaLopHocPhanMaNhomGiangVien(null, _maLopHocPhan, _maNhomGiangVien, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LopHocPh__ACA033849CD96D08 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maNhomGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanTheoNhomGiangVien"/> class.</returns>
		public abstract PMS.Entities.LopHocPhanTheoNhomGiangVien GetByMaLopHocPhanMaNhomGiangVien(TransactionManager transactionManager, System.String _maLopHocPhan, System.String _maNhomGiangVien, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_LopHocPhanTheoNhomGiangVien_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanTheoNhomGiangVien_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanTheoNhomGiangVien_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanTheoNhomGiangVien_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanTheoNhomGiangVien_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_LopHocPhanTheoNhomGiangVien_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanTheoNhomGiangVien_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanTheoNhomGiangVien_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanTheoNhomGiangVien_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanTheoNhomGiangVien_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;LopHocPhanTheoNhomGiangVien&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;LopHocPhanTheoNhomGiangVien&gt;"/></returns>
		public static TList<LopHocPhanTheoNhomGiangVien> Fill(IDataReader reader, TList<LopHocPhanTheoNhomGiangVien> rows, int start, int pageLength)
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
				
				PMS.Entities.LopHocPhanTheoNhomGiangVien c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("LopHocPhanTheoNhomGiangVien")
					.Append("|").Append((System.String)reader[((int)LopHocPhanTheoNhomGiangVienColumn.MaLopHocPhan - 1)])
					.Append("|").Append((System.String)reader[((int)LopHocPhanTheoNhomGiangVienColumn.MaNhomGiangVien - 1)]).ToString();
					c = EntityManager.LocateOrCreate<LopHocPhanTheoNhomGiangVien>(
					key.ToString(), // EntityTrackingKey
					"LopHocPhanTheoNhomGiangVien",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.LopHocPhanTheoNhomGiangVien();
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
					c.MaLopHocPhan = (System.String)reader[(LopHocPhanTheoNhomGiangVienColumn.MaLopHocPhan.ToString())];
					c.OriginalMaLopHocPhan = c.MaLopHocPhan;
					c.MaNhomGiangVien = (System.String)reader[(LopHocPhanTheoNhomGiangVienColumn.MaNhomGiangVien.ToString())];
					c.OriginalMaNhomGiangVien = c.MaNhomGiangVien;
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LopHocPhanTheoNhomGiangVien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LopHocPhanTheoNhomGiangVien"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.LopHocPhanTheoNhomGiangVien entity)
		{
			if (!reader.Read()) return;
			
			entity.MaLopHocPhan = (System.String)reader[(LopHocPhanTheoNhomGiangVienColumn.MaLopHocPhan.ToString())];
			entity.OriginalMaLopHocPhan = (System.String)reader["MaLopHocPhan"];
			entity.MaNhomGiangVien = (System.String)reader[(LopHocPhanTheoNhomGiangVienColumn.MaNhomGiangVien.ToString())];
			entity.OriginalMaNhomGiangVien = (System.String)reader["MaNhomGiangVien"];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LopHocPhanTheoNhomGiangVien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LopHocPhanTheoNhomGiangVien"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.LopHocPhanTheoNhomGiangVien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLopHocPhan = (System.String)dataRow["MaLopHocPhan"];
			entity.OriginalMaLopHocPhan = (System.String)dataRow["MaLopHocPhan"];
			entity.MaNhomGiangVien = (System.String)dataRow["MaNhomGiangVien"];
			entity.OriginalMaNhomGiangVien = (System.String)dataRow["MaNhomGiangVien"];
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
		/// <param name="entity">The <see cref="PMS.Entities.LopHocPhanTheoNhomGiangVien"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.LopHocPhanTheoNhomGiangVien Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.LopHocPhanTheoNhomGiangVien entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.LopHocPhanTheoNhomGiangVien object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.LopHocPhanTheoNhomGiangVien instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.LopHocPhanTheoNhomGiangVien Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.LopHocPhanTheoNhomGiangVien entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region LopHocPhanTheoNhomGiangVienChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.LopHocPhanTheoNhomGiangVien</c>
	///</summary>
	public enum LopHocPhanTheoNhomGiangVienChildEntityTypes
	{
	}
	
	#endregion LopHocPhanTheoNhomGiangVienChildEntityTypes
	
	#region LopHocPhanTheoNhomGiangVienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;LopHocPhanTheoNhomGiangVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanTheoNhomGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanTheoNhomGiangVienFilterBuilder : SqlFilterBuilder<LopHocPhanTheoNhomGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanTheoNhomGiangVienFilterBuilder class.
		/// </summary>
		public LopHocPhanTheoNhomGiangVienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LopHocPhanTheoNhomGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LopHocPhanTheoNhomGiangVienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LopHocPhanTheoNhomGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LopHocPhanTheoNhomGiangVienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LopHocPhanTheoNhomGiangVienFilterBuilder
	
	#region LopHocPhanTheoNhomGiangVienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;LopHocPhanTheoNhomGiangVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanTheoNhomGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanTheoNhomGiangVienParameterBuilder : ParameterizedSqlFilterBuilder<LopHocPhanTheoNhomGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanTheoNhomGiangVienParameterBuilder class.
		/// </summary>
		public LopHocPhanTheoNhomGiangVienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LopHocPhanTheoNhomGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LopHocPhanTheoNhomGiangVienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LopHocPhanTheoNhomGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LopHocPhanTheoNhomGiangVienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LopHocPhanTheoNhomGiangVienParameterBuilder
	
	#region LopHocPhanTheoNhomGiangVienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;LopHocPhanTheoNhomGiangVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanTheoNhomGiangVien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class LopHocPhanTheoNhomGiangVienSortBuilder : SqlSortBuilder<LopHocPhanTheoNhomGiangVienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanTheoNhomGiangVienSqlSortBuilder class.
		/// </summary>
		public LopHocPhanTheoNhomGiangVienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion LopHocPhanTheoNhomGiangVienSortBuilder
	
} // end namespace
