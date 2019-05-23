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
	/// This class is the base class for any <see cref="ViewGiangVienHoatDongNgoaiGiangDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewGiangVienHoatDongNgoaiGiangDayProviderBaseCore : EntityViewProviderBase<ViewGiangVienHoatDongNgoaiGiangDay>
	{
		#region Custom Methods
		
		
		#region cust_view_giangvien_hoatDongngoaigiangday_GetByMaHoatDong
		
		/// <summary>
		///	This method wrap the 'cust_view_giangvien_hoatDongngoaigiangday_GetByMaHoatDong' stored procedure. 
		/// </summary>
		/// <param name="maHoatDong"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVienHoatDongNgoaiGiangDay&gt;"/> instance.</returns>
		public VList<ViewGiangVienHoatDongNgoaiGiangDay> GetByMaHoatDong(System.String maHoatDong)
		{
			return GetByMaHoatDong(null, 0, int.MaxValue , maHoatDong);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_giangvien_hoatDongngoaigiangday_GetByMaHoatDong' stored procedure. 
		/// </summary>
		/// <param name="maHoatDong"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVienHoatDongNgoaiGiangDay&gt;"/> instance.</returns>
		public VList<ViewGiangVienHoatDongNgoaiGiangDay> GetByMaHoatDong(int start, int pageLength, System.String maHoatDong)
		{
			return GetByMaHoatDong(null, start, pageLength , maHoatDong);
		}
				
		/// <summary>
		///	This method wrap the 'cust_view_giangvien_hoatDongngoaigiangday_GetByMaHoatDong' stored procedure. 
		/// </summary>
		/// <param name="maHoatDong"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewGiangVienHoatDongNgoaiGiangDay&gt;"/> instance.</returns>
		public VList<ViewGiangVienHoatDongNgoaiGiangDay> GetByMaHoatDong(TransactionManager transactionManager, System.String maHoatDong)
		{
			return GetByMaHoatDong(transactionManager, 0, int.MaxValue , maHoatDong);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_giangvien_hoatDongngoaigiangday_GetByMaHoatDong' stored procedure. 
		/// </summary>
		/// <param name="maHoatDong"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVienHoatDongNgoaiGiangDay&gt;"/> instance.</returns>
		public abstract VList<ViewGiangVienHoatDongNgoaiGiangDay> GetByMaHoatDong(TransactionManager transactionManager, int start, int pageLength, System.String maHoatDong);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewGiangVienHoatDongNgoaiGiangDay&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewGiangVienHoatDongNgoaiGiangDay&gt;"/></returns>
		protected static VList&lt;ViewGiangVienHoatDongNgoaiGiangDay&gt; Fill(DataSet dataSet, VList<ViewGiangVienHoatDongNgoaiGiangDay> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewGiangVienHoatDongNgoaiGiangDay>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewGiangVienHoatDongNgoaiGiangDay&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewGiangVienHoatDongNgoaiGiangDay>"/></returns>
		protected static VList&lt;ViewGiangVienHoatDongNgoaiGiangDay&gt; Fill(DataTable dataTable, VList<ViewGiangVienHoatDongNgoaiGiangDay> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewGiangVienHoatDongNgoaiGiangDay c = new ViewGiangVienHoatDongNgoaiGiangDay();
					c.MaHoatDong = (Convert.IsDBNull(row["MaHoatDong"]))?(int)0:(System.Int32)row["MaHoatDong"];
					c.TenHoatDong = (Convert.IsDBNull(row["TenHoatDong"]))?string.Empty:(System.String)row["TenHoatDong"];
					c.MucQuyDoi = (Convert.IsDBNull(row["MucQuyDoi"]))?0.0m:(System.Decimal?)row["MucQuyDoi"];
					c.GhiChu = (Convert.IsDBNull(row["GhiChu"]))?string.Empty:(System.String)row["GhiChu"];
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
		/// Fill an <see cref="VList&lt;ViewGiangVienHoatDongNgoaiGiangDay&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewGiangVienHoatDongNgoaiGiangDay&gt;"/></returns>
		protected VList<ViewGiangVienHoatDongNgoaiGiangDay> Fill(IDataReader reader, VList<ViewGiangVienHoatDongNgoaiGiangDay> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewGiangVienHoatDongNgoaiGiangDay entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewGiangVienHoatDongNgoaiGiangDay>("ViewGiangVienHoatDongNgoaiGiangDay",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewGiangVienHoatDongNgoaiGiangDay();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaHoatDong = (System.Int32)reader["MaHoatDong"];
					//entity.MaHoatDong = (Convert.IsDBNull(reader["MaHoatDong"]))?(int)0:(System.Int32)reader["MaHoatDong"];
					entity.TenHoatDong = reader.IsDBNull(reader.GetOrdinal("TenHoatDong")) ? null : (System.String)reader["TenHoatDong"];
					//entity.TenHoatDong = (Convert.IsDBNull(reader["TenHoatDong"]))?string.Empty:(System.String)reader["TenHoatDong"];
					entity.MucQuyDoi = reader.IsDBNull(reader.GetOrdinal("MucQuyDoi")) ? null : (System.Decimal?)reader["MucQuyDoi"];
					//entity.MucQuyDoi = (Convert.IsDBNull(reader["MucQuyDoi"]))?0.0m:(System.Decimal?)reader["MucQuyDoi"];
					entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.String)reader["GhiChu"];
					//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?string.Empty:(System.String)reader["GhiChu"];
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
		/// Refreshes the <see cref="ViewGiangVienHoatDongNgoaiGiangDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewGiangVienHoatDongNgoaiGiangDay"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewGiangVienHoatDongNgoaiGiangDay entity)
		{
			reader.Read();
			entity.MaHoatDong = (System.Int32)reader["MaHoatDong"];
			//entity.MaHoatDong = (Convert.IsDBNull(reader["MaHoatDong"]))?(int)0:(System.Int32)reader["MaHoatDong"];
			entity.TenHoatDong = reader.IsDBNull(reader.GetOrdinal("TenHoatDong")) ? null : (System.String)reader["TenHoatDong"];
			//entity.TenHoatDong = (Convert.IsDBNull(reader["TenHoatDong"]))?string.Empty:(System.String)reader["TenHoatDong"];
			entity.MucQuyDoi = reader.IsDBNull(reader.GetOrdinal("MucQuyDoi")) ? null : (System.Decimal?)reader["MucQuyDoi"];
			//entity.MucQuyDoi = (Convert.IsDBNull(reader["MucQuyDoi"]))?0.0m:(System.Decimal?)reader["MucQuyDoi"];
			entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.String)reader["GhiChu"];
			//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?string.Empty:(System.String)reader["GhiChu"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewGiangVienHoatDongNgoaiGiangDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewGiangVienHoatDongNgoaiGiangDay"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewGiangVienHoatDongNgoaiGiangDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaHoatDong = (Convert.IsDBNull(dataRow["MaHoatDong"]))?(int)0:(System.Int32)dataRow["MaHoatDong"];
			entity.TenHoatDong = (Convert.IsDBNull(dataRow["TenHoatDong"]))?string.Empty:(System.String)dataRow["TenHoatDong"];
			entity.MucQuyDoi = (Convert.IsDBNull(dataRow["MucQuyDoi"]))?0.0m:(System.Decimal?)dataRow["MucQuyDoi"];
			entity.GhiChu = (Convert.IsDBNull(dataRow["GhiChu"]))?string.Empty:(System.String)dataRow["GhiChu"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewGiangVienHoatDongNgoaiGiangDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienHoatDongNgoaiGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienHoatDongNgoaiGiangDayFilterBuilder : SqlFilterBuilder<ViewGiangVienHoatDongNgoaiGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienHoatDongNgoaiGiangDayFilterBuilder class.
		/// </summary>
		public ViewGiangVienHoatDongNgoaiGiangDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienHoatDongNgoaiGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewGiangVienHoatDongNgoaiGiangDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienHoatDongNgoaiGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewGiangVienHoatDongNgoaiGiangDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewGiangVienHoatDongNgoaiGiangDayFilterBuilder

	#region ViewGiangVienHoatDongNgoaiGiangDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienHoatDongNgoaiGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienHoatDongNgoaiGiangDayParameterBuilder : ParameterizedSqlFilterBuilder<ViewGiangVienHoatDongNgoaiGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienHoatDongNgoaiGiangDayParameterBuilder class.
		/// </summary>
		public ViewGiangVienHoatDongNgoaiGiangDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienHoatDongNgoaiGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewGiangVienHoatDongNgoaiGiangDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienHoatDongNgoaiGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewGiangVienHoatDongNgoaiGiangDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewGiangVienHoatDongNgoaiGiangDayParameterBuilder
	
	#region ViewGiangVienHoatDongNgoaiGiangDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienHoatDongNgoaiGiangDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewGiangVienHoatDongNgoaiGiangDaySortBuilder : SqlSortBuilder<ViewGiangVienHoatDongNgoaiGiangDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienHoatDongNgoaiGiangDaySqlSortBuilder class.
		/// </summary>
		public ViewGiangVienHoatDongNgoaiGiangDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewGiangVienHoatDongNgoaiGiangDaySortBuilder

} // end namespace
