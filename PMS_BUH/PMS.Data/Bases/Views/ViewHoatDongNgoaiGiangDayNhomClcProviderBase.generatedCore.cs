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
	/// This class is the base class for any <see cref="ViewHoatDongNgoaiGiangDayNhomClcProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewHoatDongNgoaiGiangDayNhomClcProviderBaseCore : EntityViewProviderBase<ViewHoatDongNgoaiGiangDayNhomClc>
	{
		#region Custom Methods
		
		
		#region cust_view_HoatDongNgoaiGiangDay_NhomCLC_GetMaQuanLyNhomCLC
		
		/// <summary>
		///	This method wrap the 'cust_view_HoatDongNgoaiGiangDay_NhomCLC_GetMaQuanLyNhomCLC' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewHoatDongNgoaiGiangDayNhomClc&gt;"/> instance.</returns>
		public VList<ViewHoatDongNgoaiGiangDayNhomClc> GetMaQuanLyNhomCLC(System.String maQuanLy)
		{
			return GetMaQuanLyNhomCLC(null, 0, int.MaxValue , maQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_HoatDongNgoaiGiangDay_NhomCLC_GetMaQuanLyNhomCLC' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewHoatDongNgoaiGiangDayNhomClc&gt;"/> instance.</returns>
		public VList<ViewHoatDongNgoaiGiangDayNhomClc> GetMaQuanLyNhomCLC(int start, int pageLength, System.String maQuanLy)
		{
			return GetMaQuanLyNhomCLC(null, start, pageLength , maQuanLy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_view_HoatDongNgoaiGiangDay_NhomCLC_GetMaQuanLyNhomCLC' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewHoatDongNgoaiGiangDayNhomClc&gt;"/> instance.</returns>
		public VList<ViewHoatDongNgoaiGiangDayNhomClc> GetMaQuanLyNhomCLC(TransactionManager transactionManager, System.String maQuanLy)
		{
			return GetMaQuanLyNhomCLC(transactionManager, 0, int.MaxValue , maQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_HoatDongNgoaiGiangDay_NhomCLC_GetMaQuanLyNhomCLC' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewHoatDongNgoaiGiangDayNhomClc&gt;"/> instance.</returns>
		public abstract VList<ViewHoatDongNgoaiGiangDayNhomClc> GetMaQuanLyNhomCLC(TransactionManager transactionManager, int start, int pageLength, System.String maQuanLy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewHoatDongNgoaiGiangDayNhomClc&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewHoatDongNgoaiGiangDayNhomClc&gt;"/></returns>
		protected static VList&lt;ViewHoatDongNgoaiGiangDayNhomClc&gt; Fill(DataSet dataSet, VList<ViewHoatDongNgoaiGiangDayNhomClc> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewHoatDongNgoaiGiangDayNhomClc>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewHoatDongNgoaiGiangDayNhomClc&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewHoatDongNgoaiGiangDayNhomClc>"/></returns>
		protected static VList&lt;ViewHoatDongNgoaiGiangDayNhomClc&gt; Fill(DataTable dataTable, VList<ViewHoatDongNgoaiGiangDayNhomClc> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewHoatDongNgoaiGiangDayNhomClc c = new ViewHoatDongNgoaiGiangDayNhomClc();
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?(int)0:(System.Int32)row["MaQuanLy"];
					c.TenHoatDong = (Convert.IsDBNull(row["TenHoatDong"]))?string.Empty:(System.String)row["TenHoatDong"];
					c.MaDonViTinh = (Convert.IsDBNull(row["MaDonViTinh"]))?(int)0:(System.Int32?)row["MaDonViTinh"];
					c.SoLuong = (Convert.IsDBNull(row["SoLuong"]))?0.0m:(System.Decimal?)row["SoLuong"];
					c.MucQuyDoi = (Convert.IsDBNull(row["MucQuyDoi"]))?0.0m:(System.Decimal?)row["MucQuyDoi"];
					c.DonGia = (Convert.IsDBNull(row["DonGia"]))?0.0m:(System.Decimal?)row["DonGia"];
					c.GhiChu = (Convert.IsDBNull(row["GhiChu"]))?string.Empty:(System.String)row["GhiChu"];
					c.MaNhom = (Convert.IsDBNull(row["MaNhom"]))?string.Empty:(System.String)row["MaNhom"];
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
		/// Fill an <see cref="VList&lt;ViewHoatDongNgoaiGiangDayNhomClc&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewHoatDongNgoaiGiangDayNhomClc&gt;"/></returns>
		protected VList<ViewHoatDongNgoaiGiangDayNhomClc> Fill(IDataReader reader, VList<ViewHoatDongNgoaiGiangDayNhomClc> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewHoatDongNgoaiGiangDayNhomClc entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewHoatDongNgoaiGiangDayNhomClc>("ViewHoatDongNgoaiGiangDayNhomClc",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewHoatDongNgoaiGiangDayNhomClc();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaQuanLy = (System.Int32)reader["MaQuanLy"];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?(int)0:(System.Int32)reader["MaQuanLy"];
					entity.TenHoatDong = reader.IsDBNull(reader.GetOrdinal("TenHoatDong")) ? null : (System.String)reader["TenHoatDong"];
					//entity.TenHoatDong = (Convert.IsDBNull(reader["TenHoatDong"]))?string.Empty:(System.String)reader["TenHoatDong"];
					entity.MaDonViTinh = reader.IsDBNull(reader.GetOrdinal("MaDonViTinh")) ? null : (System.Int32?)reader["MaDonViTinh"];
					//entity.MaDonViTinh = (Convert.IsDBNull(reader["MaDonViTinh"]))?(int)0:(System.Int32?)reader["MaDonViTinh"];
					entity.SoLuong = reader.IsDBNull(reader.GetOrdinal("SoLuong")) ? null : (System.Decimal?)reader["SoLuong"];
					//entity.SoLuong = (Convert.IsDBNull(reader["SoLuong"]))?0.0m:(System.Decimal?)reader["SoLuong"];
					entity.MucQuyDoi = reader.IsDBNull(reader.GetOrdinal("MucQuyDoi")) ? null : (System.Decimal?)reader["MucQuyDoi"];
					//entity.MucQuyDoi = (Convert.IsDBNull(reader["MucQuyDoi"]))?0.0m:(System.Decimal?)reader["MucQuyDoi"];
					entity.DonGia = reader.IsDBNull(reader.GetOrdinal("DonGia")) ? null : (System.Decimal?)reader["DonGia"];
					//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal?)reader["DonGia"];
					entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.String)reader["GhiChu"];
					//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?string.Empty:(System.String)reader["GhiChu"];
					entity.MaNhom = reader.IsDBNull(reader.GetOrdinal("MaNhom")) ? null : (System.String)reader["MaNhom"];
					//entity.MaNhom = (Convert.IsDBNull(reader["MaNhom"]))?string.Empty:(System.String)reader["MaNhom"];
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
		/// Refreshes the <see cref="ViewHoatDongNgoaiGiangDayNhomClc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewHoatDongNgoaiGiangDayNhomClc"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewHoatDongNgoaiGiangDayNhomClc entity)
		{
			reader.Read();
			entity.MaQuanLy = (System.Int32)reader["MaQuanLy"];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?(int)0:(System.Int32)reader["MaQuanLy"];
			entity.TenHoatDong = reader.IsDBNull(reader.GetOrdinal("TenHoatDong")) ? null : (System.String)reader["TenHoatDong"];
			//entity.TenHoatDong = (Convert.IsDBNull(reader["TenHoatDong"]))?string.Empty:(System.String)reader["TenHoatDong"];
			entity.MaDonViTinh = reader.IsDBNull(reader.GetOrdinal("MaDonViTinh")) ? null : (System.Int32?)reader["MaDonViTinh"];
			//entity.MaDonViTinh = (Convert.IsDBNull(reader["MaDonViTinh"]))?(int)0:(System.Int32?)reader["MaDonViTinh"];
			entity.SoLuong = reader.IsDBNull(reader.GetOrdinal("SoLuong")) ? null : (System.Decimal?)reader["SoLuong"];
			//entity.SoLuong = (Convert.IsDBNull(reader["SoLuong"]))?0.0m:(System.Decimal?)reader["SoLuong"];
			entity.MucQuyDoi = reader.IsDBNull(reader.GetOrdinal("MucQuyDoi")) ? null : (System.Decimal?)reader["MucQuyDoi"];
			//entity.MucQuyDoi = (Convert.IsDBNull(reader["MucQuyDoi"]))?0.0m:(System.Decimal?)reader["MucQuyDoi"];
			entity.DonGia = reader.IsDBNull(reader.GetOrdinal("DonGia")) ? null : (System.Decimal?)reader["DonGia"];
			//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal?)reader["DonGia"];
			entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.String)reader["GhiChu"];
			//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?string.Empty:(System.String)reader["GhiChu"];
			entity.MaNhom = reader.IsDBNull(reader.GetOrdinal("MaNhom")) ? null : (System.String)reader["MaNhom"];
			//entity.MaNhom = (Convert.IsDBNull(reader["MaNhom"]))?string.Empty:(System.String)reader["MaNhom"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewHoatDongNgoaiGiangDayNhomClc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewHoatDongNgoaiGiangDayNhomClc"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewHoatDongNgoaiGiangDayNhomClc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?(int)0:(System.Int32)dataRow["MaQuanLy"];
			entity.TenHoatDong = (Convert.IsDBNull(dataRow["TenHoatDong"]))?string.Empty:(System.String)dataRow["TenHoatDong"];
			entity.MaDonViTinh = (Convert.IsDBNull(dataRow["MaDonViTinh"]))?(int)0:(System.Int32?)dataRow["MaDonViTinh"];
			entity.SoLuong = (Convert.IsDBNull(dataRow["SoLuong"]))?0.0m:(System.Decimal?)dataRow["SoLuong"];
			entity.MucQuyDoi = (Convert.IsDBNull(dataRow["MucQuyDoi"]))?0.0m:(System.Decimal?)dataRow["MucQuyDoi"];
			entity.DonGia = (Convert.IsDBNull(dataRow["DonGia"]))?0.0m:(System.Decimal?)dataRow["DonGia"];
			entity.GhiChu = (Convert.IsDBNull(dataRow["GhiChu"]))?string.Empty:(System.String)dataRow["GhiChu"];
			entity.MaNhom = (Convert.IsDBNull(dataRow["MaNhom"]))?string.Empty:(System.String)dataRow["MaNhom"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewHoatDongNgoaiGiangDayNhomClcFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHoatDongNgoaiGiangDayNhomClc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHoatDongNgoaiGiangDayNhomClcFilterBuilder : SqlFilterBuilder<ViewHoatDongNgoaiGiangDayNhomClcColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHoatDongNgoaiGiangDayNhomClcFilterBuilder class.
		/// </summary>
		public ViewHoatDongNgoaiGiangDayNhomClcFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewHoatDongNgoaiGiangDayNhomClcFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewHoatDongNgoaiGiangDayNhomClcFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewHoatDongNgoaiGiangDayNhomClcFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewHoatDongNgoaiGiangDayNhomClcFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewHoatDongNgoaiGiangDayNhomClcFilterBuilder

	#region ViewHoatDongNgoaiGiangDayNhomClcParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHoatDongNgoaiGiangDayNhomClc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHoatDongNgoaiGiangDayNhomClcParameterBuilder : ParameterizedSqlFilterBuilder<ViewHoatDongNgoaiGiangDayNhomClcColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHoatDongNgoaiGiangDayNhomClcParameterBuilder class.
		/// </summary>
		public ViewHoatDongNgoaiGiangDayNhomClcParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewHoatDongNgoaiGiangDayNhomClcParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewHoatDongNgoaiGiangDayNhomClcParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewHoatDongNgoaiGiangDayNhomClcParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewHoatDongNgoaiGiangDayNhomClcParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewHoatDongNgoaiGiangDayNhomClcParameterBuilder
	
	#region ViewHoatDongNgoaiGiangDayNhomClcSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHoatDongNgoaiGiangDayNhomClc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewHoatDongNgoaiGiangDayNhomClcSortBuilder : SqlSortBuilder<ViewHoatDongNgoaiGiangDayNhomClcColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHoatDongNgoaiGiangDayNhomClcSqlSortBuilder class.
		/// </summary>
		public ViewHoatDongNgoaiGiangDayNhomClcSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewHoatDongNgoaiGiangDayNhomClcSortBuilder

} // end namespace