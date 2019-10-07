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
	/// This class is the base class for any <see cref="ViewKcqPhanNhomMonHocActProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewKcqPhanNhomMonHocActProviderBaseCore : EntityViewProviderBase<ViewKcqPhanNhomMonHocAct>
	{
		#region Custom Methods
		
		
		#region cust_View_KcqPhanNhomMonHoc_Act_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_KcqPhanNhomMonHoc_Act_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKcqPhanNhomMonHocAct&gt;"/> instance.</returns>
		public VList<ViewKcqPhanNhomMonHocAct> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KcqPhanNhomMonHoc_Act_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKcqPhanNhomMonHocAct&gt;"/> instance.</returns>
		public VList<ViewKcqPhanNhomMonHocAct> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KcqPhanNhomMonHoc_Act_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewKcqPhanNhomMonHocAct&gt;"/> instance.</returns>
		public VList<ViewKcqPhanNhomMonHocAct> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KcqPhanNhomMonHoc_Act_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKcqPhanNhomMonHocAct&gt;"/> instance.</returns>
		public abstract VList<ViewKcqPhanNhomMonHocAct> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewKcqPhanNhomMonHocAct&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewKcqPhanNhomMonHocAct&gt;"/></returns>
		protected static VList&lt;ViewKcqPhanNhomMonHocAct&gt; Fill(DataSet dataSet, VList<ViewKcqPhanNhomMonHocAct> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewKcqPhanNhomMonHocAct>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewKcqPhanNhomMonHocAct&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewKcqPhanNhomMonHocAct>"/></returns>
		protected static VList&lt;ViewKcqPhanNhomMonHocAct&gt; Fill(DataTable dataTable, VList<ViewKcqPhanNhomMonHocAct> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewKcqPhanNhomMonHocAct c = new ViewKcqPhanNhomMonHocAct();
					c.CurriculumId = (Convert.IsDBNull(row["CurriculumId"]))?string.Empty:(System.String)row["CurriculumId"];
					c.CurriculumName = (Convert.IsDBNull(row["CurriculumName"]))?string.Empty:(System.String)row["CurriculumName"];
					c.Credits = (Convert.IsDBNull(row["Credits"]))?0.0m:(System.Decimal)row["Credits"];
					c.DepartmentId = (Convert.IsDBNull(row["DepartmentId"]))?string.Empty:(System.String)row["DepartmentId"];
					c.DepartmentName = (Convert.IsDBNull(row["DepartmentName"]))?string.Empty:(System.String)row["DepartmentName"];
					c.StudyUnitTypeId = (Convert.IsDBNull(row["StudyUnitTypeId"]))?(int)0:(System.Int32?)row["StudyUnitTypeId"];
					c.NumberOfPeriods = (Convert.IsDBNull(row["NumberOfPeriods"]))?(int)0:(System.Int32?)row["NumberOfPeriods"];
					c.MaNhomMonHoc = (Convert.IsDBNull(row["MaNhomMonHoc"]))?(int)0:(System.Int32?)row["MaNhomMonHoc"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
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
		/// Fill an <see cref="VList&lt;ViewKcqPhanNhomMonHocAct&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewKcqPhanNhomMonHocAct&gt;"/></returns>
		protected VList<ViewKcqPhanNhomMonHocAct> Fill(IDataReader reader, VList<ViewKcqPhanNhomMonHocAct> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewKcqPhanNhomMonHocAct entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewKcqPhanNhomMonHocAct>("ViewKcqPhanNhomMonHocAct",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewKcqPhanNhomMonHocAct();
					}
					
					entity.SuppressEntityEvents = true;

					entity.CurriculumId = (System.String)reader["CurriculumId"];
					//entity.CurriculumId = (Convert.IsDBNull(reader["CurriculumId"]))?string.Empty:(System.String)reader["CurriculumId"];
					entity.CurriculumName = (System.String)reader["CurriculumName"];
					//entity.CurriculumName = (Convert.IsDBNull(reader["CurriculumName"]))?string.Empty:(System.String)reader["CurriculumName"];
					entity.Credits = (System.Decimal)reader["Credits"];
					//entity.Credits = (Convert.IsDBNull(reader["Credits"]))?0.0m:(System.Decimal)reader["Credits"];
					entity.DepartmentId = (System.String)reader["DepartmentId"];
					//entity.DepartmentId = (Convert.IsDBNull(reader["DepartmentId"]))?string.Empty:(System.String)reader["DepartmentId"];
					entity.DepartmentName = (System.String)reader["DepartmentName"];
					//entity.DepartmentName = (Convert.IsDBNull(reader["DepartmentName"]))?string.Empty:(System.String)reader["DepartmentName"];
					entity.StudyUnitTypeId = reader.IsDBNull(reader.GetOrdinal("StudyUnitTypeId")) ? null : (System.Int32?)reader["StudyUnitTypeId"];
					//entity.StudyUnitTypeId = (Convert.IsDBNull(reader["StudyUnitTypeId"]))?(int)0:(System.Int32?)reader["StudyUnitTypeId"];
					entity.NumberOfPeriods = reader.IsDBNull(reader.GetOrdinal("NumberOfPeriods")) ? null : (System.Int32?)reader["NumberOfPeriods"];
					//entity.NumberOfPeriods = (Convert.IsDBNull(reader["NumberOfPeriods"]))?(int)0:(System.Int32?)reader["NumberOfPeriods"];
					entity.MaNhomMonHoc = reader.IsDBNull(reader.GetOrdinal("MaNhomMonHoc")) ? null : (System.Int32?)reader["MaNhomMonHoc"];
					//entity.MaNhomMonHoc = (Convert.IsDBNull(reader["MaNhomMonHoc"]))?(int)0:(System.Int32?)reader["MaNhomMonHoc"];
					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
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
		/// Refreshes the <see cref="ViewKcqPhanNhomMonHocAct"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKcqPhanNhomMonHocAct"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewKcqPhanNhomMonHocAct entity)
		{
			reader.Read();
			entity.CurriculumId = (System.String)reader["CurriculumId"];
			//entity.CurriculumId = (Convert.IsDBNull(reader["CurriculumId"]))?string.Empty:(System.String)reader["CurriculumId"];
			entity.CurriculumName = (System.String)reader["CurriculumName"];
			//entity.CurriculumName = (Convert.IsDBNull(reader["CurriculumName"]))?string.Empty:(System.String)reader["CurriculumName"];
			entity.Credits = (System.Decimal)reader["Credits"];
			//entity.Credits = (Convert.IsDBNull(reader["Credits"]))?0.0m:(System.Decimal)reader["Credits"];
			entity.DepartmentId = (System.String)reader["DepartmentId"];
			//entity.DepartmentId = (Convert.IsDBNull(reader["DepartmentId"]))?string.Empty:(System.String)reader["DepartmentId"];
			entity.DepartmentName = (System.String)reader["DepartmentName"];
			//entity.DepartmentName = (Convert.IsDBNull(reader["DepartmentName"]))?string.Empty:(System.String)reader["DepartmentName"];
			entity.StudyUnitTypeId = reader.IsDBNull(reader.GetOrdinal("StudyUnitTypeId")) ? null : (System.Int32?)reader["StudyUnitTypeId"];
			//entity.StudyUnitTypeId = (Convert.IsDBNull(reader["StudyUnitTypeId"]))?(int)0:(System.Int32?)reader["StudyUnitTypeId"];
			entity.NumberOfPeriods = reader.IsDBNull(reader.GetOrdinal("NumberOfPeriods")) ? null : (System.Int32?)reader["NumberOfPeriods"];
			//entity.NumberOfPeriods = (Convert.IsDBNull(reader["NumberOfPeriods"]))?(int)0:(System.Int32?)reader["NumberOfPeriods"];
			entity.MaNhomMonHoc = reader.IsDBNull(reader.GetOrdinal("MaNhomMonHoc")) ? null : (System.Int32?)reader["MaNhomMonHoc"];
			//entity.MaNhomMonHoc = (Convert.IsDBNull(reader["MaNhomMonHoc"]))?(int)0:(System.Int32?)reader["MaNhomMonHoc"];
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewKcqPhanNhomMonHocAct"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKcqPhanNhomMonHocAct"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewKcqPhanNhomMonHocAct entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CurriculumId = (Convert.IsDBNull(dataRow["CurriculumId"]))?string.Empty:(System.String)dataRow["CurriculumId"];
			entity.CurriculumName = (Convert.IsDBNull(dataRow["CurriculumName"]))?string.Empty:(System.String)dataRow["CurriculumName"];
			entity.Credits = (Convert.IsDBNull(dataRow["Credits"]))?0.0m:(System.Decimal)dataRow["Credits"];
			entity.DepartmentId = (Convert.IsDBNull(dataRow["DepartmentId"]))?string.Empty:(System.String)dataRow["DepartmentId"];
			entity.DepartmentName = (Convert.IsDBNull(dataRow["DepartmentName"]))?string.Empty:(System.String)dataRow["DepartmentName"];
			entity.StudyUnitTypeId = (Convert.IsDBNull(dataRow["StudyUnitTypeId"]))?(int)0:(System.Int32?)dataRow["StudyUnitTypeId"];
			entity.NumberOfPeriods = (Convert.IsDBNull(dataRow["NumberOfPeriods"]))?(int)0:(System.Int32?)dataRow["NumberOfPeriods"];
			entity.MaNhomMonHoc = (Convert.IsDBNull(dataRow["MaNhomMonHoc"]))?(int)0:(System.Int32?)dataRow["MaNhomMonHoc"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewKcqPhanNhomMonHocActFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqPhanNhomMonHocAct"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqPhanNhomMonHocActFilterBuilder : SqlFilterBuilder<ViewKcqPhanNhomMonHocActColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqPhanNhomMonHocActFilterBuilder class.
		/// </summary>
		public ViewKcqPhanNhomMonHocActFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKcqPhanNhomMonHocActFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKcqPhanNhomMonHocActFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKcqPhanNhomMonHocActFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKcqPhanNhomMonHocActFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKcqPhanNhomMonHocActFilterBuilder

	#region ViewKcqPhanNhomMonHocActParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqPhanNhomMonHocAct"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqPhanNhomMonHocActParameterBuilder : ParameterizedSqlFilterBuilder<ViewKcqPhanNhomMonHocActColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqPhanNhomMonHocActParameterBuilder class.
		/// </summary>
		public ViewKcqPhanNhomMonHocActParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKcqPhanNhomMonHocActParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKcqPhanNhomMonHocActParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKcqPhanNhomMonHocActParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKcqPhanNhomMonHocActParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKcqPhanNhomMonHocActParameterBuilder
	
	#region ViewKcqPhanNhomMonHocActSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqPhanNhomMonHocAct"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewKcqPhanNhomMonHocActSortBuilder : SqlSortBuilder<ViewKcqPhanNhomMonHocActColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqPhanNhomMonHocActSqlSortBuilder class.
		/// </summary>
		public ViewKcqPhanNhomMonHocActSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewKcqPhanNhomMonHocActSortBuilder

} // end namespace