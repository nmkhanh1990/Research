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
	/// This class is the base class for any <see cref="VChiTietQuyDoiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class VChiTietQuyDoiProviderBaseCore : EntityViewProviderBase<VChiTietQuyDoi>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;VChiTietQuyDoi&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;VChiTietQuyDoi&gt;"/></returns>
		protected static VList&lt;VChiTietQuyDoi&gt; Fill(DataSet dataSet, VList<VChiTietQuyDoi> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<VChiTietQuyDoi>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;VChiTietQuyDoi&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<VChiTietQuyDoi>"/></returns>
		protected static VList&lt;VChiTietQuyDoi&gt; Fill(DataTable dataTable, VList<VChiTietQuyDoi> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					VChiTietQuyDoi c = new VChiTietQuyDoi();
					c.MaKhoa = (Convert.IsDBNull(row["MaKhoa"]))?string.Empty:(System.String)row["MaKhoa"];
					c.TenKhoa = (Convert.IsDBNull(row["TenKhoa"]))?string.Empty:(System.String)row["TenKhoa"];
					c.MaBoMon = (Convert.IsDBNull(row["MaBoMon"]))?string.Empty:(System.String)row["MaBoMon"];
					c.TenBoMon = (Convert.IsDBNull(row["TenBoMon"]))?string.Empty:(System.String)row["TenBoMon"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.SoTiet1 = (Convert.IsDBNull(row["SoTiet1"]))?0.0m:(System.Decimal?)row["SoTiet1"];
					c.TietDoAn1 = (Convert.IsDBNull(row["TietDoAn1"]))?0.0m:(System.Decimal?)row["TietDoAn1"];
					c.SoTiet2 = (Convert.IsDBNull(row["SoTiet2"]))?0.0m:(System.Decimal?)row["SoTiet2"];
					c.TietDoAn2 = (Convert.IsDBNull(row["TietDoAn2"]))?0.0m:(System.Decimal?)row["TietDoAn2"];
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
		/// Fill an <see cref="VList&lt;VChiTietQuyDoi&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;VChiTietQuyDoi&gt;"/></returns>
		protected VList<VChiTietQuyDoi> Fill(IDataReader reader, VList<VChiTietQuyDoi> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					VChiTietQuyDoi entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<VChiTietQuyDoi>("VChiTietQuyDoi",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new VChiTietQuyDoi();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaKhoa = reader.IsDBNull(reader.GetOrdinal("MaKhoa")) ? null : (System.String)reader["MaKhoa"];
					//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
					entity.TenKhoa = reader.IsDBNull(reader.GetOrdinal("TenKhoa")) ? null : (System.String)reader["TenKhoa"];
					//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
					entity.MaBoMon = (System.String)reader["MaBoMon"];
					//entity.MaBoMon = (Convert.IsDBNull(reader["MaBoMon"]))?string.Empty:(System.String)reader["MaBoMon"];
					entity.TenBoMon = (System.String)reader["TenBoMon"];
					//entity.TenBoMon = (Convert.IsDBNull(reader["TenBoMon"]))?string.Empty:(System.String)reader["TenBoMon"];
					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.SoTiet1 = reader.IsDBNull(reader.GetOrdinal("SoTiet1")) ? null : (System.Decimal?)reader["SoTiet1"];
					//entity.SoTiet1 = (Convert.IsDBNull(reader["SoTiet1"]))?0.0m:(System.Decimal?)reader["SoTiet1"];
					entity.TietDoAn1 = reader.IsDBNull(reader.GetOrdinal("TietDoAn1")) ? null : (System.Decimal?)reader["TietDoAn1"];
					//entity.TietDoAn1 = (Convert.IsDBNull(reader["TietDoAn1"]))?0.0m:(System.Decimal?)reader["TietDoAn1"];
					entity.SoTiet2 = reader.IsDBNull(reader.GetOrdinal("SoTiet2")) ? null : (System.Decimal?)reader["SoTiet2"];
					//entity.SoTiet2 = (Convert.IsDBNull(reader["SoTiet2"]))?0.0m:(System.Decimal?)reader["SoTiet2"];
					entity.TietDoAn2 = reader.IsDBNull(reader.GetOrdinal("TietDoAn2")) ? null : (System.Decimal?)reader["TietDoAn2"];
					//entity.TietDoAn2 = (Convert.IsDBNull(reader["TietDoAn2"]))?0.0m:(System.Decimal?)reader["TietDoAn2"];
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
		/// Refreshes the <see cref="VChiTietQuyDoi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="VChiTietQuyDoi"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, VChiTietQuyDoi entity)
		{
			reader.Read();
			entity.MaKhoa = reader.IsDBNull(reader.GetOrdinal("MaKhoa")) ? null : (System.String)reader["MaKhoa"];
			//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
			entity.TenKhoa = reader.IsDBNull(reader.GetOrdinal("TenKhoa")) ? null : (System.String)reader["TenKhoa"];
			//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
			entity.MaBoMon = (System.String)reader["MaBoMon"];
			//entity.MaBoMon = (Convert.IsDBNull(reader["MaBoMon"]))?string.Empty:(System.String)reader["MaBoMon"];
			entity.TenBoMon = (System.String)reader["TenBoMon"];
			//entity.TenBoMon = (Convert.IsDBNull(reader["TenBoMon"]))?string.Empty:(System.String)reader["TenBoMon"];
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.SoTiet1 = reader.IsDBNull(reader.GetOrdinal("SoTiet1")) ? null : (System.Decimal?)reader["SoTiet1"];
			//entity.SoTiet1 = (Convert.IsDBNull(reader["SoTiet1"]))?0.0m:(System.Decimal?)reader["SoTiet1"];
			entity.TietDoAn1 = reader.IsDBNull(reader.GetOrdinal("TietDoAn1")) ? null : (System.Decimal?)reader["TietDoAn1"];
			//entity.TietDoAn1 = (Convert.IsDBNull(reader["TietDoAn1"]))?0.0m:(System.Decimal?)reader["TietDoAn1"];
			entity.SoTiet2 = reader.IsDBNull(reader.GetOrdinal("SoTiet2")) ? null : (System.Decimal?)reader["SoTiet2"];
			//entity.SoTiet2 = (Convert.IsDBNull(reader["SoTiet2"]))?0.0m:(System.Decimal?)reader["SoTiet2"];
			entity.TietDoAn2 = reader.IsDBNull(reader.GetOrdinal("TietDoAn2")) ? null : (System.Decimal?)reader["TietDoAn2"];
			//entity.TietDoAn2 = (Convert.IsDBNull(reader["TietDoAn2"]))?0.0m:(System.Decimal?)reader["TietDoAn2"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="VChiTietQuyDoi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="VChiTietQuyDoi"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, VChiTietQuyDoi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaKhoa = (Convert.IsDBNull(dataRow["MaKhoa"]))?string.Empty:(System.String)dataRow["MaKhoa"];
			entity.TenKhoa = (Convert.IsDBNull(dataRow["TenKhoa"]))?string.Empty:(System.String)dataRow["TenKhoa"];
			entity.MaBoMon = (Convert.IsDBNull(dataRow["MaBoMon"]))?string.Empty:(System.String)dataRow["MaBoMon"];
			entity.TenBoMon = (Convert.IsDBNull(dataRow["TenBoMon"]))?string.Empty:(System.String)dataRow["TenBoMon"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.SoTiet1 = (Convert.IsDBNull(dataRow["SoTiet1"]))?0.0m:(System.Decimal?)dataRow["SoTiet1"];
			entity.TietDoAn1 = (Convert.IsDBNull(dataRow["TietDoAn1"]))?0.0m:(System.Decimal?)dataRow["TietDoAn1"];
			entity.SoTiet2 = (Convert.IsDBNull(dataRow["SoTiet2"]))?0.0m:(System.Decimal?)dataRow["SoTiet2"];
			entity.TietDoAn2 = (Convert.IsDBNull(dataRow["TietDoAn2"]))?0.0m:(System.Decimal?)dataRow["TietDoAn2"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region VChiTietQuyDoiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VChiTietQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VChiTietQuyDoiFilterBuilder : SqlFilterBuilder<VChiTietQuyDoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VChiTietQuyDoiFilterBuilder class.
		/// </summary>
		public VChiTietQuyDoiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VChiTietQuyDoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VChiTietQuyDoiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VChiTietQuyDoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VChiTietQuyDoiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VChiTietQuyDoiFilterBuilder

	#region VChiTietQuyDoiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VChiTietQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VChiTietQuyDoiParameterBuilder : ParameterizedSqlFilterBuilder<VChiTietQuyDoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VChiTietQuyDoiParameterBuilder class.
		/// </summary>
		public VChiTietQuyDoiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VChiTietQuyDoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VChiTietQuyDoiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VChiTietQuyDoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VChiTietQuyDoiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VChiTietQuyDoiParameterBuilder
	
	#region VChiTietQuyDoiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VChiTietQuyDoi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class VChiTietQuyDoiSortBuilder : SqlSortBuilder<VChiTietQuyDoiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VChiTietQuyDoiSqlSortBuilder class.
		/// </summary>
		public VChiTietQuyDoiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion VChiTietQuyDoiSortBuilder

} // end namespace