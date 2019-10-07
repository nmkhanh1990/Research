﻿#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using PMS.Entities;
using PMS.Data;

#endregion

namespace PMS.Data.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="ViewKcqMonTinhTheoQuyCheMoiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewKcqMonTinhTheoQuyCheMoiProviderBaseCore : EntityViewProviderBase<ViewKcqMonTinhTheoQuyCheMoi>
	{
		#region Custom Methods
		
		
		#region cust_View_KcqMonTinhTheoQuyCheMoi_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_KcqMonTinhTheoQuyCheMoi_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKcqMonTinhTheoQuyCheMoi&gt;"/> instance.</returns>
		public VList<ViewKcqMonTinhTheoQuyCheMoi> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KcqMonTinhTheoQuyCheMoi_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKcqMonTinhTheoQuyCheMoi&gt;"/> instance.</returns>
		public VList<ViewKcqMonTinhTheoQuyCheMoi> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KcqMonTinhTheoQuyCheMoi_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewKcqMonTinhTheoQuyCheMoi&gt;"/> instance.</returns>
		public VList<ViewKcqMonTinhTheoQuyCheMoi> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KcqMonTinhTheoQuyCheMoi_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKcqMonTinhTheoQuyCheMoi&gt;"/> instance.</returns>
		public abstract VList<ViewKcqMonTinhTheoQuyCheMoi> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewKcqMonTinhTheoQuyCheMoi&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewKcqMonTinhTheoQuyCheMoi&gt;"/></returns>
		protected static VList&lt;ViewKcqMonTinhTheoQuyCheMoi&gt; Fill(DataSet dataSet, VList<ViewKcqMonTinhTheoQuyCheMoi> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewKcqMonTinhTheoQuyCheMoi>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewKcqMonTinhTheoQuyCheMoi&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewKcqMonTinhTheoQuyCheMoi>"/></returns>
		protected static VList&lt;ViewKcqMonTinhTheoQuyCheMoi&gt; Fill(DataTable dataTable, VList<ViewKcqMonTinhTheoQuyCheMoi> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewKcqMonTinhTheoQuyCheMoi c = new ViewKcqMonTinhTheoQuyCheMoi();
					c.Id = (Convert.IsDBNull(row["Id"]))?(int)0:(System.Int32)row["Id"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.SoTinChi = (Convert.IsDBNull(row["SoTinChi"]))?0.0m:(System.Decimal)row["SoTinChi"];
					c.NgayCapNhat = (Convert.IsDBNull(row["NgayCapNhat"]))?string.Empty:(System.String)row["NgayCapNhat"];
					c.NguoiCapNhat = (Convert.IsDBNull(row["NguoiCapNhat"]))?string.Empty:(System.String)row["NguoiCapNhat"];
					c.Chon = (Convert.IsDBNull(row["Chon"]))?false:(System.Boolean?)row["Chon"];
					c.AcceptChanges();
					rows.Add(c);
					pagelen -= 1;
				}
				recordnum += 1;
			}
			return rows;
		}
		*/	
						
		///<summary>
		/// Fill an <see cref="VList&lt;ViewKcqMonTinhTheoQuyCheMoi&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewKcqMonTinhTheoQuyCheMoi&gt;"/></returns>
		protected VList<ViewKcqMonTinhTheoQuyCheMoi> Fill(IDataReader reader, VList<ViewKcqMonTinhTheoQuyCheMoi> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewKcqMonTinhTheoQuyCheMoi entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewKcqMonTinhTheoQuyCheMoi>("ViewKcqMonTinhTheoQuyCheMoi",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewKcqMonTinhTheoQuyCheMoi();
					}
					
					entity.SuppressEntityEvents = true;

					entity.Id = (System.Int32)reader["Id"];
					//entity.Id = (Convert.IsDBNull(reader["Id"]))?(int)0:(System.Int32)reader["Id"];
					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.MaMonHoc = (System.String)reader["MaMonHoc"];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = (System.String)reader["TenMonHoc"];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.SoTinChi = (System.Decimal)reader["SoTinChi"];
					//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?0.0m:(System.Decimal)reader["SoTinChi"];
					entity.NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (System.String)reader["NgayCapNhat"];
					//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?string.Empty:(System.String)reader["NgayCapNhat"];
					entity.NguoiCapNhat = reader.IsDBNull(reader.GetOrdinal("NguoiCapNhat")) ? null : (System.String)reader["NguoiCapNhat"];
					//entity.NguoiCapNhat = (Convert.IsDBNull(reader["NguoiCapNhat"]))?string.Empty:(System.String)reader["NguoiCapNhat"];
					entity.Chon = reader.IsDBNull(reader.GetOrdinal("Chon")) ? null : (System.Boolean?)reader["Chon"];
					//entity.Chon = (Convert.IsDBNull(reader["Chon"]))?false:(System.Boolean?)reader["Chon"];
					entity.AcceptChanges();
					entity.SuppressEntityEvents = false;
					
					rows.Add(entity);
					pageLength -= 1;
				}
				recordnum += 1;
			}
			return rows;
		}
		
		
		/// <summary>
		/// Refreshes the <see cref="ViewKcqMonTinhTheoQuyCheMoi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKcqMonTinhTheoQuyCheMoi"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewKcqMonTinhTheoQuyCheMoi entity)
		{
			reader.Read();
			entity.Id = (System.Int32)reader["Id"];
			//entity.Id = (Convert.IsDBNull(reader["Id"]))?(int)0:(System.Int32)reader["Id"];
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.MaMonHoc = (System.String)reader["MaMonHoc"];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = (System.String)reader["TenMonHoc"];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.SoTinChi = (System.Decimal)reader["SoTinChi"];
			//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?0.0m:(System.Decimal)reader["SoTinChi"];
			entity.NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (System.String)reader["NgayCapNhat"];
			//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?string.Empty:(System.String)reader["NgayCapNhat"];
			entity.NguoiCapNhat = reader.IsDBNull(reader.GetOrdinal("NguoiCapNhat")) ? null : (System.String)reader["NguoiCapNhat"];
			//entity.NguoiCapNhat = (Convert.IsDBNull(reader["NguoiCapNhat"]))?string.Empty:(System.String)reader["NguoiCapNhat"];
			entity.Chon = reader.IsDBNull(reader.GetOrdinal("Chon")) ? null : (System.Boolean?)reader["Chon"];
			//entity.Chon = (Convert.IsDBNull(reader["Chon"]))?false:(System.Boolean?)reader["Chon"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewKcqMonTinhTheoQuyCheMoi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKcqMonTinhTheoQuyCheMoi"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewKcqMonTinhTheoQuyCheMoi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (Convert.IsDBNull(dataRow["Id"]))?(int)0:(System.Int32)dataRow["Id"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.SoTinChi = (Convert.IsDBNull(dataRow["SoTinChi"]))?0.0m:(System.Decimal)dataRow["SoTinChi"];
			entity.NgayCapNhat = (Convert.IsDBNull(dataRow["NgayCapNhat"]))?string.Empty:(System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = (Convert.IsDBNull(dataRow["NguoiCapNhat"]))?string.Empty:(System.String)dataRow["NguoiCapNhat"];
			entity.Chon = (Convert.IsDBNull(dataRow["Chon"]))?false:(System.Boolean?)dataRow["Chon"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewKcqMonTinhTheoQuyCheMoiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqMonTinhTheoQuyCheMoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqMonTinhTheoQuyCheMoiFilterBuilder : SqlFilterBuilder<ViewKcqMonTinhTheoQuyCheMoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqMonTinhTheoQuyCheMoiFilterBuilder class.
		/// </summary>
		public ViewKcqMonTinhTheoQuyCheMoiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKcqMonTinhTheoQuyCheMoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKcqMonTinhTheoQuyCheMoiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKcqMonTinhTheoQuyCheMoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKcqMonTinhTheoQuyCheMoiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKcqMonTinhTheoQuyCheMoiFilterBuilder

	#region ViewKcqMonTinhTheoQuyCheMoiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqMonTinhTheoQuyCheMoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqMonTinhTheoQuyCheMoiParameterBuilder : ParameterizedSqlFilterBuilder<ViewKcqMonTinhTheoQuyCheMoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqMonTinhTheoQuyCheMoiParameterBuilder class.
		/// </summary>
		public ViewKcqMonTinhTheoQuyCheMoiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKcqMonTinhTheoQuyCheMoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKcqMonTinhTheoQuyCheMoiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKcqMonTinhTheoQuyCheMoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKcqMonTinhTheoQuyCheMoiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKcqMonTinhTheoQuyCheMoiParameterBuilder
	
	#region ViewKcqMonTinhTheoQuyCheMoiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqMonTinhTheoQuyCheMoi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewKcqMonTinhTheoQuyCheMoiSortBuilder : SqlSortBuilder<ViewKcqMonTinhTheoQuyCheMoiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqMonTinhTheoQuyCheMoiSqlSortBuilder class.
		/// </summary>
		public ViewKcqMonTinhTheoQuyCheMoiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewKcqMonTinhTheoQuyCheMoiSortBuilder

} // end namespace