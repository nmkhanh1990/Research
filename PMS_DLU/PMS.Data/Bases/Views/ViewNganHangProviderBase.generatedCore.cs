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
	/// This class is the base class for any <see cref="ViewNganHangProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewNganHangProviderBaseCore : EntityViewProviderBase<ViewNganHang>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewNganHang&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewNganHang&gt;"/></returns>
		protected static VList&lt;ViewNganHang&gt; Fill(DataSet dataSet, VList<ViewNganHang> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewNganHang>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewNganHang&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewNganHang>"/></returns>
		protected static VList&lt;ViewNganHang&gt; Fill(DataTable dataTable, VList<ViewNganHang> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewNganHang c = new ViewNganHang();
					c.Hrmid = (Convert.IsDBNull(row["HRMID"]))?Guid.Empty:(System.Guid)row["HRMID"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.TenNganHang = (Convert.IsDBNull(row["TenNganHang"]))?string.Empty:(System.String)row["TenNganHang"];
					c.TenVietTat = (Convert.IsDBNull(row["TenVietTat"]))?string.Empty:(System.String)row["TenVietTat"];
					c.TrucThuoc = (Convert.IsDBNull(row["TrucThuoc"]))?string.Empty:(System.String)row["TrucThuoc"];
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
		/// Fill an <see cref="VList&lt;ViewNganHang&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewNganHang&gt;"/></returns>
		protected VList<ViewNganHang> Fill(IDataReader reader, VList<ViewNganHang> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewNganHang entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewNganHang>("ViewNganHang",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewNganHang();
					}
					
					entity.SuppressEntityEvents = true;

					entity.Hrmid = (System.Guid)reader["Hrmid"];
					//entity.Hrmid = (Convert.IsDBNull(reader["HRMID"]))?Guid.Empty:(System.Guid)reader["HRMID"];
					entity.MaQuanLy = reader.IsDBNull(reader.GetOrdinal("MaQuanLy")) ? null : (System.String)reader["MaQuanLy"];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.TenNganHang = reader.IsDBNull(reader.GetOrdinal("TenNganHang")) ? null : (System.String)reader["TenNganHang"];
					//entity.TenNganHang = (Convert.IsDBNull(reader["TenNganHang"]))?string.Empty:(System.String)reader["TenNganHang"];
					entity.TenVietTat = reader.IsDBNull(reader.GetOrdinal("TenVietTat")) ? null : (System.String)reader["TenVietTat"];
					//entity.TenVietTat = (Convert.IsDBNull(reader["TenVietTat"]))?string.Empty:(System.String)reader["TenVietTat"];
					entity.TrucThuoc = (System.String)reader["TrucThuoc"];
					//entity.TrucThuoc = (Convert.IsDBNull(reader["TrucThuoc"]))?string.Empty:(System.String)reader["TrucThuoc"];
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
		/// Refreshes the <see cref="ViewNganHang"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewNganHang"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewNganHang entity)
		{
			reader.Read();
			entity.Hrmid = (System.Guid)reader["Hrmid"];
			//entity.Hrmid = (Convert.IsDBNull(reader["HRMID"]))?Guid.Empty:(System.Guid)reader["HRMID"];
			entity.MaQuanLy = reader.IsDBNull(reader.GetOrdinal("MaQuanLy")) ? null : (System.String)reader["MaQuanLy"];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.TenNganHang = reader.IsDBNull(reader.GetOrdinal("TenNganHang")) ? null : (System.String)reader["TenNganHang"];
			//entity.TenNganHang = (Convert.IsDBNull(reader["TenNganHang"]))?string.Empty:(System.String)reader["TenNganHang"];
			entity.TenVietTat = reader.IsDBNull(reader.GetOrdinal("TenVietTat")) ? null : (System.String)reader["TenVietTat"];
			//entity.TenVietTat = (Convert.IsDBNull(reader["TenVietTat"]))?string.Empty:(System.String)reader["TenVietTat"];
			entity.TrucThuoc = (System.String)reader["TrucThuoc"];
			//entity.TrucThuoc = (Convert.IsDBNull(reader["TrucThuoc"]))?string.Empty:(System.String)reader["TrucThuoc"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewNganHang"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewNganHang"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewNganHang entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Hrmid = (Convert.IsDBNull(dataRow["HRMID"]))?Guid.Empty:(System.Guid)dataRow["HRMID"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.TenNganHang = (Convert.IsDBNull(dataRow["TenNganHang"]))?string.Empty:(System.String)dataRow["TenNganHang"];
			entity.TenVietTat = (Convert.IsDBNull(dataRow["TenVietTat"]))?string.Empty:(System.String)dataRow["TenVietTat"];
			entity.TrucThuoc = (Convert.IsDBNull(dataRow["TrucThuoc"]))?string.Empty:(System.String)dataRow["TrucThuoc"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewNganHangFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewNganHang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewNganHangFilterBuilder : SqlFilterBuilder<ViewNganHangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewNganHangFilterBuilder class.
		/// </summary>
		public ViewNganHangFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewNganHangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewNganHangFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewNganHangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewNganHangFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewNganHangFilterBuilder

	#region ViewNganHangParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewNganHang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewNganHangParameterBuilder : ParameterizedSqlFilterBuilder<ViewNganHangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewNganHangParameterBuilder class.
		/// </summary>
		public ViewNganHangParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewNganHangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewNganHangParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewNganHangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewNganHangParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewNganHangParameterBuilder
	
	#region ViewNganHangSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewNganHang"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewNganHangSortBuilder : SqlSortBuilder<ViewNganHangColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewNganHangSqlSortBuilder class.
		/// </summary>
		public ViewNganHangSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewNganHangSortBuilder

} // end namespace
