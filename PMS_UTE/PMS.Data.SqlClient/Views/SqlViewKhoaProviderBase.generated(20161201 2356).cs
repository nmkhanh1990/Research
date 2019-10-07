﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewKhoa.cs instead.
*/

#region Using directives

using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using PMS.Entities;
using PMS.Data.Bases;

#endregion

namespace PMS.Data.SqlClient
{
/// <summary>
///	This class is the base repository for the CRUD operations on the ViewKhoa objects.
/// </summary>
public abstract partial class SqlViewKhoaProviderBase : ViewKhoaProviderBase
{
	
	string _connectionString;
    bool _useStoredProcedure;
    string _providerInvariantName;
		
	#region Constructors
	
	/// <summary>
	/// Creates a new <see cref="SqlViewKhoaProviderBase"/> instance.
	/// Uses connection string to connect to datasource.
	/// </summary>
	protected SqlViewKhoaProviderBase()
	{		
	}
	
	/// <summary>
	/// Creates a new <see cref="SqlViewKhoaProviderBase"/> instance.
	/// Uses connection string to connect to datasource.
	/// </summary>
	/// <param name="connectionString">The connection string to the database.</param>
	/// <param name="useStoredProcedure">A boolean value that indicates if we use stored procedures or embedded queries.</param>
	/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
	public SqlViewKhoaProviderBase(string connectionString, bool useStoredProcedure, string providerInvariantName)
	{
		this._connectionString = connectionString;
		this._useStoredProcedure = useStoredProcedure;
		this._providerInvariantName = providerInvariantName;
	}
			
	#endregion 
	
	#region Public properties
	/// <summary>
    /// Gets or sets the connection string.
    /// </summary>
    /// <value>The connection string.</value>
    public string ConnectionString
	{
		get {return this._connectionString;}
		set {this._connectionString = value;}
	}
	
	/// <summary>
    /// Gets or sets a value indicating whether to use stored procedures.
    /// </summary>
    /// <value><c>true</c> if we choose to use stored procedures; otherwise, <c>false</c>.</value>
	public bool UseStoredProcedure
	{
		get {return this._useStoredProcedure;}
		set {this._useStoredProcedure = value;}
	}
	
	/// <summary>
    /// Gets or sets the invariant provider name listed in the DbProviderFactories machine.config section.
    /// </summary>
    /// <value>The name of the provider invariant.</value>
    public string ProviderInvariantName
    {
        get { return this._providerInvariantName; }
        set { this._providerInvariantName = value; }
    }
	#endregion
		
	
	#region GetAll Methods
	
	/// <summary>
	/// Gets All rows from the DataSource.
	/// </summary>
	/// <param name="transactionManager"><see cref="TransactionManager"/> object.</param>
	/// <param name="start">Row number at which to start reading.</param>
	/// <param name="pageLength">Number of rows to return.</param>
	/// <param name="count">The total number of rows in the data source.</param>
	/// <remarks></remarks>
	/// <returns>Returns a typed collection of ViewKhoa objects.</returns>
	public override VList<ViewKhoa> GetAll(TransactionManager transactionManager, int start, int pageLength, out int count)
	{
		SqlDatabase database = new SqlDatabase(this._connectionString);
		DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_View_Khoa_Get_List", _useStoredProcedure);
		
		IDataReader reader = null;
		//Create Collection
		VList<ViewKhoa> rows = new VList<ViewKhoa>();
		
		try
		{
			if (transactionManager != null)
			{
				reader = Utility.ExecuteReader(transactionManager, commandWrapper);
			}
			else
			{
				reader = Utility.ExecuteReader(database, commandWrapper);
			}
		
			Fill(reader, rows, start, pageLength);
			count = rows.Count;

			if(reader.NextResult())
			{
				if(reader.Read())
				{
					count = reader.GetInt32(0);
				}
			}
		}
		finally
		{
			if (reader != null)
				reader.Close();
		}
		return rows;
	}//end getall
	
	#endregion
	
	#region Get Methods
			
	/// <summary>
	/// Gets a page of rows from the DataSource.
	/// </summary>
	/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
	/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
	/// <param name="start">Row number at which to start reading.</param>
	/// <param name="pageLength">Number of rows to return.</param>
	/// <param name="count">The total number of rows in the data source.</param>
	/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
	/// <remarks></remarks>
	/// <returns>Returns a typed collection of ViewKhoa objects.</returns>
	public override VList<ViewKhoa> Get(TransactionManager transactionManager, string whereClause, string orderBy, int start, int pageLength, out int count)
	{
		SqlDatabase database = new SqlDatabase(this._connectionString);
		DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_View_Khoa_Get", _useStoredProcedure);

		database.AddInParameter(commandWrapper, "@WhereClause", DbType.String, whereClause);
		database.AddInParameter(commandWrapper, "@OrderBy", DbType.String, orderBy);
		database.AddInParameter(commandWrapper, "@PageIndex", DbType.Int32, start);
		database.AddInParameter(commandWrapper, "@PageSize", DbType.Int32, pageLength);
	
		IDataReader reader = null;
		//Create Collection
		VList<ViewKhoa> rows = new VList<ViewKhoa>();
		
		try
		{
			if (transactionManager != null)
			{
				reader = Utility.ExecuteReader(transactionManager,commandWrapper);
			}
			else
			{
				reader = Utility.ExecuteReader(database, commandWrapper);
			}

			Fill(reader, rows, 0, int.MaxValue);
			count = rows.Count;

			if(reader.NextResult())
			{
				if(reader.Read())
				{
					count = reader.GetInt32(0);
				}
			}
		}
		finally
		{
		     if (reader != null)
		     	 reader.Close();
		}
		return rows;
	}
	
	#endregion
	
	#region Find Methods
	
	#region Parameterized Find Methods
	
	/// <summary>
	/// Returns rows from the DataSource that meet the parameter conditions.
	/// </summary>
	/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
	/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
	/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
	/// <param name="start">Row number at which to start reading.</param>
	/// <param name="pageLength">Number of rows to return.</param>
	/// <param name="count">out. The number of rows that match this query.</param>
	/// <returns>Returns a typed collection of ViewKhoa objects.</returns>
	public override VList<ViewKhoa> Find(TransactionManager transactionManager, IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
	{
		SqlFilterParameterCollection filter = null;
		
		if (parameters == null)
			filter = new SqlFilterParameterCollection();
		else 
			filter = parameters.GetParameters();
			
		SqlDatabase database = new SqlDatabase(this._connectionString);
		DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_View_Khoa_Find_Dynamic", typeof(ViewKhoaColumn), filter, orderBy, start, pageLength);
		
		SqlFilterParameter param;

		for ( int i = 0; i < filter.Count; i++ )
		{
			param = filter[i];
			database.AddInParameter(commandWrapper, param.Name, param.DbType, param.GetValue());
		}

		VList<ViewKhoa> rows = new VList<ViewKhoa>();
		IDataReader reader = null;
		
		try
		{
			if ( transactionManager != null )
			{
				reader = Utility.ExecuteReader(transactionManager, commandWrapper);
			}
			else
			{
				reader = Utility.ExecuteReader(database, commandWrapper);
			}
			
			Fill(reader, rows, 0, int.MaxValue);
			count = rows.Count;
			
			if ( reader.NextResult() )
			{
				if ( reader.Read() )
				{
					count = reader.GetInt32(0);
				}
			}
		}
		finally
		{
			if ( reader != null )
				reader.Close();
		}
		
		return rows;
	}
	
	#endregion Parameterized Find Methods

	#endregion 

	#region Custom Methods
	

	#region cust_View_Khoa_BoMon_GetByMaKhoa
	
	/// <summary>
	///	This method wraps the 'cust_View_Khoa_BoMon_GetByMaKhoa' stored procedure. 
	/// </summary>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
	/// <param name="start">Row number at which to start reading.</param>
	/// <param name="pageLength">Number of rows to return.</param>
	/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
	/// <remark>This method is generated from a stored procedure.</remark>
	/// <returns>A <see cref="IDataReader"/> instance.</returns>
	public override IDataReader BoMon_GetByMaKhoa(TransactionManager transactionManager, int start, int pageLength, System.String maKhoa)
	{
		SqlDatabase database = new SqlDatabase(this._connectionString);
		DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.cust_View_Khoa_BoMon_GetByMaKhoa", true);
		
		database.AddInParameter(commandWrapper, "@MaKhoa", DbType.AnsiString,  maKhoa );
		

		try
		{
			
			IDataReader dr = null;
			
			if (transactionManager != null)
			{	
				dr = Utility.ExecuteReader(transactionManager,commandWrapper);
			}
			else
			{
				dr = Utility.ExecuteReader(database, commandWrapper);
			}
			
			
			
			return dr;
		}
		catch(SqlException ex)
		{
			throw new DataException("A data access error occured, please check inner SqlException.", ex);
		}
	}
	#endregion

	#region cust_View_Khoa_BoMon_GetByMaBoMon
	
	/// <summary>
	///	This method wraps the 'cust_View_Khoa_BoMon_GetByMaBoMon' stored procedure. 
	/// </summary>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
	/// <param name="start">Row number at which to start reading.</param>
	/// <param name="pageLength">Number of rows to return.</param>
	/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
	/// <remark>This method is generated from a stored procedure.</remark>
	/// <returns>A <see cref="IDataReader"/> instance.</returns>
	public override IDataReader BoMon_GetByMaBoMon(TransactionManager transactionManager, int start, int pageLength, System.String maBoMon)
	{
		SqlDatabase database = new SqlDatabase(this._connectionString);
		DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.cust_View_Khoa_BoMon_GetByMaBoMon", true);
		
		database.AddInParameter(commandWrapper, "@MaBoMon", DbType.String,  maBoMon );
		

		try
		{
			
			IDataReader dr = null;
			
			if (transactionManager != null)
			{	
				dr = Utility.ExecuteReader(transactionManager,commandWrapper);
			}
			else
			{
				dr = Utility.ExecuteReader(database, commandWrapper);
			}
			
			
			
			return dr;
		}
		catch(SqlException ex)
		{
			throw new DataException("A data access error occured, please check inner SqlException.", ex);
		}
	}
	#endregion

	#region cust_View_Khoa_GetAllKhoa
	
	/// <summary>
	///	This method wraps the 'cust_View_Khoa_GetAllKhoa' stored procedure. 
	/// </summary>
	/// <param name="start">Row number at which to start reading.</param>
	/// <param name="pageLength">Number of rows to return.</param>
	/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
	/// <remark>This method is generated from a stored procedure.</remark>
	/// <returns>A <see cref="IDataReader"/> instance.</returns>
	public override IDataReader GetAllKhoa(TransactionManager transactionManager, int start, int pageLength)
	{
		SqlDatabase database = new SqlDatabase(this._connectionString);
		DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.cust_View_Khoa_GetAllKhoa", true);
		
		

		try
		{
			
			IDataReader dr = null;
			
			if (transactionManager != null)
			{	
				dr = Utility.ExecuteReader(transactionManager,commandWrapper);
			}
			else
			{
				dr = Utility.ExecuteReader(database, commandWrapper);
			}
			
			
			
			return dr;
		}
		catch(SqlException ex)
		{
			throw new DataException("A data access error occured, please check inner SqlException.", ex);
		}
	}
	#endregion

	#region cust_View_Khoa_BoMon_GetByMaCoSo
	
	/// <summary>
	///	This method wraps the 'cust_View_Khoa_BoMon_GetByMaCoSo' stored procedure. 
	/// </summary>
		/// <param name="coSo"> A <c>System.String</c> instance.</param>
	/// <param name="start">Row number at which to start reading.</param>
	/// <param name="pageLength">Number of rows to return.</param>
	/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
	/// <remark>This method is generated from a stored procedure.</remark>
	/// <returns>A <see cref="IDataReader"/> instance.</returns>
	public override IDataReader BoMon_GetByMaCoSo(TransactionManager transactionManager, int start, int pageLength, System.String coSo)
	{
		SqlDatabase database = new SqlDatabase(this._connectionString);
		DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.cust_View_Khoa_BoMon_GetByMaCoSo", true);
		
		database.AddInParameter(commandWrapper, "@CoSo", DbType.AnsiString,  coSo );
		

		try
		{
			
			IDataReader dr = null;
			
			if (transactionManager != null)
			{	
				dr = Utility.ExecuteReader(transactionManager,commandWrapper);
			}
			else
			{
				dr = Utility.ExecuteReader(database, commandWrapper);
			}
			
			
			
			return dr;
		}
		catch(SqlException ex)
		{
			throw new DataException("A data access error occured, please check inner SqlException.", ex);
		}
	}
	#endregion

	#region cust_View_Khoa_GetBoMonByKhoa
	
	/// <summary>
	///	This method wraps the 'cust_View_Khoa_GetBoMonByKhoa' stored procedure. 
	/// </summary>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
	/// <param name="start">Row number at which to start reading.</param>
	/// <param name="pageLength">Number of rows to return.</param>
	/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
	/// <remark>This method is generated from a stored procedure.</remark>
	/// <returns>A <see cref="IDataReader"/> instance.</returns>
	public override IDataReader GetBoMonByKhoa(TransactionManager transactionManager, int start, int pageLength, System.String khoa)
	{
		SqlDatabase database = new SqlDatabase(this._connectionString);
		DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.cust_View_Khoa_GetBoMonByKhoa", true);
		
		database.AddInParameter(commandWrapper, "@Khoa", DbType.AnsiString,  khoa );
		

		try
		{
			
			IDataReader dr = null;
			
			if (transactionManager != null)
			{	
				dr = Utility.ExecuteReader(transactionManager,commandWrapper);
			}
			else
			{
				dr = Utility.ExecuteReader(database, commandWrapper);
			}
			
			
			
			return dr;
		}
		catch(SqlException ex)
		{
			throw new DataException("A data access error occured, please check inner SqlException.", ex);
		}
	}
	#endregion

	#endregion


	}//end class
} // end namespace
