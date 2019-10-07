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
	/// This class is the base class for any <see cref="ViewBoMonProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewBoMonProviderBaseCore : EntityViewProviderBase<ViewBoMon>
	{
		#region Custom Methods
		
		
		#region cust_View_BoMon_GetDonViGiangDay
		
		/// <summary>
		///	This method wrap the 'cust_View_BoMon_GetDonViGiangDay' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewBoMon&gt;"/> instance.</returns>
		public VList<ViewBoMon> GetDonViGiangDay(System.String maDonVi)
		{
			return GetDonViGiangDay(null, 0, int.MaxValue , maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_BoMon_GetDonViGiangDay' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewBoMon&gt;"/> instance.</returns>
		public VList<ViewBoMon> GetDonViGiangDay(int start, int pageLength, System.String maDonVi)
		{
			return GetDonViGiangDay(null, start, pageLength , maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_BoMon_GetDonViGiangDay' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewBoMon&gt;"/> instance.</returns>
		public VList<ViewBoMon> GetDonViGiangDay(TransactionManager transactionManager, System.String maDonVi)
		{
			return GetDonViGiangDay(transactionManager, 0, int.MaxValue , maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_BoMon_GetDonViGiangDay' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewBoMon&gt;"/> instance.</returns>
		public abstract VList<ViewBoMon> GetDonViGiangDay(TransactionManager transactionManager, int start, int pageLength, System.String maDonVi);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewBoMon&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewBoMon&gt;"/></returns>
		protected static VList&lt;ViewBoMon&gt; Fill(DataSet dataSet, VList<ViewBoMon> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewBoMon>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewBoMon&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewBoMon>"/></returns>
		protected static VList&lt;ViewBoMon&gt; Fill(DataTable dataTable, VList<ViewBoMon> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewBoMon c = new ViewBoMon();
					c.MaBoMon = (Convert.IsDBNull(row["MaBoMon"]))?string.Empty:(System.String)row["MaBoMon"];
					c.TenBoMon = (Convert.IsDBNull(row["TenBoMon"]))?string.Empty:(System.String)row["TenBoMon"];
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
		/// Fill an <see cref="VList&lt;ViewBoMon&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewBoMon&gt;"/></returns>
		protected VList<ViewBoMon> Fill(IDataReader reader, VList<ViewBoMon> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewBoMon entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewBoMon>("ViewBoMon",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewBoMon();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaBoMon = (System.String)reader["MaBoMon"];
					//entity.MaBoMon = (Convert.IsDBNull(reader["MaBoMon"]))?string.Empty:(System.String)reader["MaBoMon"];
					entity.TenBoMon = (System.String)reader["TenBoMon"];
					//entity.TenBoMon = (Convert.IsDBNull(reader["TenBoMon"]))?string.Empty:(System.String)reader["TenBoMon"];
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
		/// Refreshes the <see cref="ViewBoMon"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewBoMon"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewBoMon entity)
		{
			reader.Read();
			entity.MaBoMon = (System.String)reader["MaBoMon"];
			//entity.MaBoMon = (Convert.IsDBNull(reader["MaBoMon"]))?string.Empty:(System.String)reader["MaBoMon"];
			entity.TenBoMon = (System.String)reader["TenBoMon"];
			//entity.TenBoMon = (Convert.IsDBNull(reader["TenBoMon"]))?string.Empty:(System.String)reader["TenBoMon"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewBoMon"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewBoMon"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewBoMon entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaBoMon = (Convert.IsDBNull(dataRow["MaBoMon"]))?string.Empty:(System.String)dataRow["MaBoMon"];
			entity.TenBoMon = (Convert.IsDBNull(dataRow["TenBoMon"]))?string.Empty:(System.String)dataRow["TenBoMon"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewBoMonFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBoMon"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewBoMonFilterBuilder : SqlFilterBuilder<ViewBoMonColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBoMonFilterBuilder class.
		/// </summary>
		public ViewBoMonFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewBoMonFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewBoMonFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewBoMonFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewBoMonFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewBoMonFilterBuilder

	#region ViewBoMonParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBoMon"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewBoMonParameterBuilder : ParameterizedSqlFilterBuilder<ViewBoMonColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBoMonParameterBuilder class.
		/// </summary>
		public ViewBoMonParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewBoMonParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewBoMonParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewBoMonParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewBoMonParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewBoMonParameterBuilder
	
	#region ViewBoMonSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBoMon"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewBoMonSortBuilder : SqlSortBuilder<ViewBoMonColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBoMonSqlSortBuilder class.
		/// </summary>
		public ViewBoMonSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewBoMonSortBuilder

} // end namespace
