#region Using directives

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
	/// This class is the base class for any <see cref="ViewQuyetDinhDoiHocHamHocViBacLuongProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewQuyetDinhDoiHocHamHocViBacLuongProviderBaseCore : EntityViewProviderBase<ViewQuyetDinhDoiHocHamHocViBacLuong>
	{
		#region Custom Methods
		
		
		#region cust_view_QuyetDinhDoiHocHamHocViBacLuong_GetByMaGiangVien
		
		/// <summary>
		///	This method wrap the 'cust_view_QuyetDinhDoiHocHamHocViBacLuong_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewQuyetDinhDoiHocHamHocViBacLuong&gt;"/> instance.</returns>
		public VList<ViewQuyetDinhDoiHocHamHocViBacLuong> GetByMaGiangVien(System.Int32 maGiangVien)
		{
			return GetByMaGiangVien(null, 0, int.MaxValue , maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_QuyetDinhDoiHocHamHocViBacLuong_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewQuyetDinhDoiHocHamHocViBacLuong&gt;"/> instance.</returns>
		public VList<ViewQuyetDinhDoiHocHamHocViBacLuong> GetByMaGiangVien(int start, int pageLength, System.Int32 maGiangVien)
		{
			return GetByMaGiangVien(null, start, pageLength , maGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_view_QuyetDinhDoiHocHamHocViBacLuong_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewQuyetDinhDoiHocHamHocViBacLuong&gt;"/> instance.</returns>
		public VList<ViewQuyetDinhDoiHocHamHocViBacLuong> GetByMaGiangVien(TransactionManager transactionManager, System.Int32 maGiangVien)
		{
			return GetByMaGiangVien(transactionManager, 0, int.MaxValue , maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_QuyetDinhDoiHocHamHocViBacLuong_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewQuyetDinhDoiHocHamHocViBacLuong&gt;"/> instance.</returns>
		public abstract VList<ViewQuyetDinhDoiHocHamHocViBacLuong> GetByMaGiangVien(TransactionManager transactionManager, int start, int pageLength, System.Int32 maGiangVien);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewQuyetDinhDoiHocHamHocViBacLuong&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewQuyetDinhDoiHocHamHocViBacLuong&gt;"/></returns>
		protected static VList&lt;ViewQuyetDinhDoiHocHamHocViBacLuong&gt; Fill(DataSet dataSet, VList<ViewQuyetDinhDoiHocHamHocViBacLuong> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewQuyetDinhDoiHocHamHocViBacLuong>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewQuyetDinhDoiHocHamHocViBacLuong&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewQuyetDinhDoiHocHamHocViBacLuong>"/></returns>
		protected static VList&lt;ViewQuyetDinhDoiHocHamHocViBacLuong&gt; Fill(DataTable dataTable, VList<ViewQuyetDinhDoiHocHamHocViBacLuong> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewQuyetDinhDoiHocHamHocViBacLuong c = new ViewQuyetDinhDoiHocHamHocViBacLuong();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32?)row["MaGiangVien"];
					c.MaCu = (Convert.IsDBNull(row["MaCu"]))?(int)0:(System.Int32?)row["MaCu"];
					c.MaMoi = (Convert.IsDBNull(row["MaMoi"]))?(int)0:(System.Int32?)row["MaMoi"];
					c.TenCu = (Convert.IsDBNull(row["TenCu"]))?string.Empty:(System.String)row["TenCu"];
					c.TenMoi = (Convert.IsDBNull(row["TenMoi"]))?string.Empty:(System.String)row["TenMoi"];
					c.NgayHieuLuc = (Convert.IsDBNull(row["NgayHieuLuc"]))?DateTime.MinValue:(System.DateTime?)row["NgayHieuLuc"];
					c.LoaiQuyetDinh = (Convert.IsDBNull(row["LoaiQuyetDinh"]))?string.Empty:(System.String)row["LoaiQuyetDinh"];
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
		/// Fill an <see cref="VList&lt;ViewQuyetDinhDoiHocHamHocViBacLuong&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewQuyetDinhDoiHocHamHocViBacLuong&gt;"/></returns>
		protected VList<ViewQuyetDinhDoiHocHamHocViBacLuong> Fill(IDataReader reader, VList<ViewQuyetDinhDoiHocHamHocViBacLuong> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewQuyetDinhDoiHocHamHocViBacLuong entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewQuyetDinhDoiHocHamHocViBacLuong>("ViewQuyetDinhDoiHocHamHocViBacLuong",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewQuyetDinhDoiHocHamHocViBacLuong();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.Int32?)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
					entity.MaCu = reader.IsDBNull(reader.GetOrdinal("MaCu")) ? null : (System.Int32?)reader["MaCu"];
					//entity.MaCu = (Convert.IsDBNull(reader["MaCu"]))?(int)0:(System.Int32?)reader["MaCu"];
					entity.MaMoi = reader.IsDBNull(reader.GetOrdinal("MaMoi")) ? null : (System.Int32?)reader["MaMoi"];
					//entity.MaMoi = (Convert.IsDBNull(reader["MaMoi"]))?(int)0:(System.Int32?)reader["MaMoi"];
					entity.TenCu = reader.IsDBNull(reader.GetOrdinal("TenCu")) ? null : (System.String)reader["TenCu"];
					//entity.TenCu = (Convert.IsDBNull(reader["TenCu"]))?string.Empty:(System.String)reader["TenCu"];
					entity.TenMoi = reader.IsDBNull(reader.GetOrdinal("TenMoi")) ? null : (System.String)reader["TenMoi"];
					//entity.TenMoi = (Convert.IsDBNull(reader["TenMoi"]))?string.Empty:(System.String)reader["TenMoi"];
					entity.NgayHieuLuc = reader.IsDBNull(reader.GetOrdinal("NgayHieuLuc")) ? null : (System.DateTime?)reader["NgayHieuLuc"];
					//entity.NgayHieuLuc = (Convert.IsDBNull(reader["NgayHieuLuc"]))?DateTime.MinValue:(System.DateTime?)reader["NgayHieuLuc"];
					entity.LoaiQuyetDinh = (System.String)reader["LoaiQuyetDinh"];
					//entity.LoaiQuyetDinh = (Convert.IsDBNull(reader["LoaiQuyetDinh"]))?string.Empty:(System.String)reader["LoaiQuyetDinh"];
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
		/// Refreshes the <see cref="ViewQuyetDinhDoiHocHamHocViBacLuong"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewQuyetDinhDoiHocHamHocViBacLuong"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewQuyetDinhDoiHocHamHocViBacLuong entity)
		{
			reader.Read();
			entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.Int32?)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
			entity.MaCu = reader.IsDBNull(reader.GetOrdinal("MaCu")) ? null : (System.Int32?)reader["MaCu"];
			//entity.MaCu = (Convert.IsDBNull(reader["MaCu"]))?(int)0:(System.Int32?)reader["MaCu"];
			entity.MaMoi = reader.IsDBNull(reader.GetOrdinal("MaMoi")) ? null : (System.Int32?)reader["MaMoi"];
			//entity.MaMoi = (Convert.IsDBNull(reader["MaMoi"]))?(int)0:(System.Int32?)reader["MaMoi"];
			entity.TenCu = reader.IsDBNull(reader.GetOrdinal("TenCu")) ? null : (System.String)reader["TenCu"];
			//entity.TenCu = (Convert.IsDBNull(reader["TenCu"]))?string.Empty:(System.String)reader["TenCu"];
			entity.TenMoi = reader.IsDBNull(reader.GetOrdinal("TenMoi")) ? null : (System.String)reader["TenMoi"];
			//entity.TenMoi = (Convert.IsDBNull(reader["TenMoi"]))?string.Empty:(System.String)reader["TenMoi"];
			entity.NgayHieuLuc = reader.IsDBNull(reader.GetOrdinal("NgayHieuLuc")) ? null : (System.DateTime?)reader["NgayHieuLuc"];
			//entity.NgayHieuLuc = (Convert.IsDBNull(reader["NgayHieuLuc"]))?DateTime.MinValue:(System.DateTime?)reader["NgayHieuLuc"];
			entity.LoaiQuyetDinh = (System.String)reader["LoaiQuyetDinh"];
			//entity.LoaiQuyetDinh = (Convert.IsDBNull(reader["LoaiQuyetDinh"]))?string.Empty:(System.String)reader["LoaiQuyetDinh"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewQuyetDinhDoiHocHamHocViBacLuong"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewQuyetDinhDoiHocHamHocViBacLuong"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewQuyetDinhDoiHocHamHocViBacLuong entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32?)dataRow["MaGiangVien"];
			entity.MaCu = (Convert.IsDBNull(dataRow["MaCu"]))?(int)0:(System.Int32?)dataRow["MaCu"];
			entity.MaMoi = (Convert.IsDBNull(dataRow["MaMoi"]))?(int)0:(System.Int32?)dataRow["MaMoi"];
			entity.TenCu = (Convert.IsDBNull(dataRow["TenCu"]))?string.Empty:(System.String)dataRow["TenCu"];
			entity.TenMoi = (Convert.IsDBNull(dataRow["TenMoi"]))?string.Empty:(System.String)dataRow["TenMoi"];
			entity.NgayHieuLuc = (Convert.IsDBNull(dataRow["NgayHieuLuc"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayHieuLuc"];
			entity.LoaiQuyetDinh = (Convert.IsDBNull(dataRow["LoaiQuyetDinh"]))?string.Empty:(System.String)dataRow["LoaiQuyetDinh"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewQuyetDinhDoiHocHamHocViBacLuongFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewQuyetDinhDoiHocHamHocViBacLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewQuyetDinhDoiHocHamHocViBacLuongFilterBuilder : SqlFilterBuilder<ViewQuyetDinhDoiHocHamHocViBacLuongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewQuyetDinhDoiHocHamHocViBacLuongFilterBuilder class.
		/// </summary>
		public ViewQuyetDinhDoiHocHamHocViBacLuongFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewQuyetDinhDoiHocHamHocViBacLuongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewQuyetDinhDoiHocHamHocViBacLuongFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewQuyetDinhDoiHocHamHocViBacLuongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewQuyetDinhDoiHocHamHocViBacLuongFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewQuyetDinhDoiHocHamHocViBacLuongFilterBuilder

	#region ViewQuyetDinhDoiHocHamHocViBacLuongParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewQuyetDinhDoiHocHamHocViBacLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewQuyetDinhDoiHocHamHocViBacLuongParameterBuilder : ParameterizedSqlFilterBuilder<ViewQuyetDinhDoiHocHamHocViBacLuongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewQuyetDinhDoiHocHamHocViBacLuongParameterBuilder class.
		/// </summary>
		public ViewQuyetDinhDoiHocHamHocViBacLuongParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewQuyetDinhDoiHocHamHocViBacLuongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewQuyetDinhDoiHocHamHocViBacLuongParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewQuyetDinhDoiHocHamHocViBacLuongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewQuyetDinhDoiHocHamHocViBacLuongParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewQuyetDinhDoiHocHamHocViBacLuongParameterBuilder
	
	#region ViewQuyetDinhDoiHocHamHocViBacLuongSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewQuyetDinhDoiHocHamHocViBacLuong"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewQuyetDinhDoiHocHamHocViBacLuongSortBuilder : SqlSortBuilder<ViewQuyetDinhDoiHocHamHocViBacLuongColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewQuyetDinhDoiHocHamHocViBacLuongSqlSortBuilder class.
		/// </summary>
		public ViewQuyetDinhDoiHocHamHocViBacLuongSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewQuyetDinhDoiHocHamHocViBacLuongSortBuilder

} // end namespace
