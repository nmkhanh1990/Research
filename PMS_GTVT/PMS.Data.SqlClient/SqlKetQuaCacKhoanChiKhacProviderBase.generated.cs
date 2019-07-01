﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file SqlKetQuaCacKhoanChiKhacProvider.cs instead.
*/

#region using directives

using System;
using System.Data;
using System.Data.Common;
using System.Text;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

using System.Collections;
using System.Collections.Specialized;

using System.Diagnostics;
using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;

#endregion

namespace PMS.Data.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="KetQuaCacKhoanChiKhac"/> entity.
	///</summary>
	public abstract partial class SqlKetQuaCacKhoanChiKhacProviderBase : KetQuaCacKhoanChiKhacProviderBase
	{
		#region Declarations
		
		string _connectionString;
	    bool _useStoredProcedure;
	    string _providerInvariantName;
			
		#endregion "Declarations"
			
		#region Constructors
		
		/// <summary>
		/// Creates a new <see cref="SqlKetQuaCacKhoanChiKhacProviderBase"/> instance.
		/// </summary>
		public SqlKetQuaCacKhoanChiKhacProviderBase()
		{
		}
	
	/// <summary>
	/// Creates a new <see cref="SqlKetQuaCacKhoanChiKhacProviderBase"/> instance.
	/// Uses connection string to connect to datasource.
	/// </summary>
	/// <param name="connectionString">The connection string to the database.</param>
	/// <param name="useStoredProcedure">A boolean value that indicates if we should use stored procedures or embedded queries.</param>
	/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
	public SqlKetQuaCacKhoanChiKhacProviderBase(string connectionString, bool useStoredProcedure, string providerInvariantName)
	{
		this._connectionString = connectionString;
		this._useStoredProcedure = useStoredProcedure;
		this._providerInvariantName = providerInvariantName;
	}
		
	#endregion "Constructors"
	
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
    /// <value><c>true</c> if we choose to use use stored procedures; otherwise, <c>false</c>.</value>
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
	
		#region Get Many To Many Relationship Functions
		#endregion
	
		#region Delete Functions
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_id">. Primary Key.</param>	
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Delete(TransactionManager transactionManager, System.Int32 _id)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_KetQuaCacKhoanChiKhac_Delete", _useStoredProcedure);
			database.AddInParameter(commandWrapper, "@Id", DbType.Int32, _id);
			
			//Provider Data Requesting Command Event
			OnDataRequesting(new CommandEventArgs(commandWrapper, "Delete")); 

			int results = 0;
			
			if (transactionManager != null)
			{	
				results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
			}
			else
			{
				results = Utility.ExecuteNonQuery(database,commandWrapper);
			}
			
			//Stop Tracking Now that it has been updated and persisted.
			if (DataRepository.Provider.EnableEntityTracking)
			{
				string entityKey = EntityLocator.ConstructKeyFromPkItems(typeof(KetQuaCacKhoanChiKhac)
					,_id);
                EntityManager.StopTracking(entityKey);
                
			}
			
			//Provider Data Requested Command Event
			OnDataRequested(new CommandEventArgs(commandWrapper, "Delete")); 

			commandWrapper = null;
			
			return Convert.ToBoolean(results);
		}//end Delete
		#endregion

		#region Find Functions

		#region Parsed Find Methods
		/// <summary>
		/// 	Returns rows meeting the whereClause condition from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out. The number of rows that match this query.</param>
		/// <remarks>Operators must be capitalized (OR, AND).</remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KetQuaCacKhoanChiKhac objects.</returns>
		public override TList<KetQuaCacKhoanChiKhac> Find(TransactionManager transactionManager, string whereClause, int start, int pageLength, out int count)
		{
			count = -1;
			if (whereClause.IndexOf(";") > -1)
				return new TList<KetQuaCacKhoanChiKhac>();
	
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_KetQuaCacKhoanChiKhac_Find", _useStoredProcedure);

		bool searchUsingOR = false;
		if (whereClause.IndexOf(" OR ") > 0) // did they want to do "a=b OR c=d OR..."?
			searchUsingOR = true;
		
		database.AddInParameter(commandWrapper, "@SearchUsingOR", DbType.Boolean, searchUsingOR);
		
		database.AddInParameter(commandWrapper, "@Id", DbType.Int32, DBNull.Value);
		database.AddInParameter(commandWrapper, "@MaGiangVienQuanLy", DbType.AnsiString, DBNull.Value);
		database.AddInParameter(commandWrapper, "@Lop", DbType.String, DBNull.Value);
		database.AddInParameter(commandWrapper, "@MaSo", DbType.String, DBNull.Value);
		database.AddInParameter(commandWrapper, "@Ngay", DbType.DateTime, DBNull.Value);
		database.AddInParameter(commandWrapper, "@NoiDung", DbType.String, DBNull.Value);
		database.AddInParameter(commandWrapper, "@HeSo", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@SoTiet", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@TienMotTiet", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@ThanhTien", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@PhiCongTac", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@TienGiangNgoaiGio", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@TongThanhTien", DbType.Decimal, DBNull.Value);
	
			// replace all instances of 'AND' and 'OR' because we already set searchUsingOR
			whereClause = whereClause.Replace(" AND ", "|").Replace(" OR ", "|") ; 
			string[] clauses = whereClause.ToLower().Split('|');
		
			// Here's what's going on below: Find a field, then to get the value we
			// drop the field name from the front, trim spaces, drop the '=' sign,
			// trim more spaces, and drop any outer single quotes.
			// Now handles the case when two fields start off the same way - like "Friendly='Yes' AND Friend='john'"
				
			char[] equalSign = {'='};
			char[] singleQuote = {'\''};
	   		foreach (string clause in clauses)
			{
				if (clause.Trim().StartsWith("id ") || clause.Trim().StartsWith("id="))
				{
					database.SetParameterValue(commandWrapper, "@Id", 
						clause.Trim().Remove(0,2).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("magiangvienquanly ") || clause.Trim().StartsWith("magiangvienquanly="))
				{
					database.SetParameterValue(commandWrapper, "@MaGiangVienQuanLy", 
						clause.Trim().Remove(0,17).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("lop ") || clause.Trim().StartsWith("lop="))
				{
					database.SetParameterValue(commandWrapper, "@Lop", 
						clause.Trim().Remove(0,3).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("maso ") || clause.Trim().StartsWith("maso="))
				{
					database.SetParameterValue(commandWrapper, "@MaSo", 
						clause.Trim().Remove(0,4).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("ngay ") || clause.Trim().StartsWith("ngay="))
				{
					database.SetParameterValue(commandWrapper, "@Ngay", 
						clause.Trim().Remove(0,4).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("noidung ") || clause.Trim().StartsWith("noidung="))
				{
					database.SetParameterValue(commandWrapper, "@NoiDung", 
						clause.Trim().Remove(0,7).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("heso ") || clause.Trim().StartsWith("heso="))
				{
					database.SetParameterValue(commandWrapper, "@HeSo", 
						clause.Trim().Remove(0,4).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("sotiet ") || clause.Trim().StartsWith("sotiet="))
				{
					database.SetParameterValue(commandWrapper, "@SoTiet", 
						clause.Trim().Remove(0,6).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("tienmottiet ") || clause.Trim().StartsWith("tienmottiet="))
				{
					database.SetParameterValue(commandWrapper, "@TienMotTiet", 
						clause.Trim().Remove(0,11).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("thanhtien ") || clause.Trim().StartsWith("thanhtien="))
				{
					database.SetParameterValue(commandWrapper, "@ThanhTien", 
						clause.Trim().Remove(0,9).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("phicongtac ") || clause.Trim().StartsWith("phicongtac="))
				{
					database.SetParameterValue(commandWrapper, "@PhiCongTac", 
						clause.Trim().Remove(0,10).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("tiengiangngoaigio ") || clause.Trim().StartsWith("tiengiangngoaigio="))
				{
					database.SetParameterValue(commandWrapper, "@TienGiangNgoaiGio", 
						clause.Trim().Remove(0,17).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("tongthanhtien ") || clause.Trim().StartsWith("tongthanhtien="))
				{
					database.SetParameterValue(commandWrapper, "@TongThanhTien", 
						clause.Trim().Remove(0,13).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
	
				throw new ArgumentException("Unable to use this part of the where clause in this version of Find: " + clause);
			}
					
			IDataReader reader = null;
			//Create Collection
			TList<KetQuaCacKhoanChiKhac> rows = new TList<KetQuaCacKhoanChiKhac>();
	
				
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "Find", rows)); 

				if (transactionManager != null)
				{
					reader = Utility.ExecuteReader(transactionManager, commandWrapper);
				}
				else
				{
					reader = Utility.ExecuteReader(database, commandWrapper);
				}		
				
				Fill(reader, rows, start, pageLength);
				
				if(reader.NextResult())
				{
					if(reader.Read())
					{
						count = reader.GetInt32(0);
					}
				}
				
				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "Find", rows)); 
			}
			finally
			{
				if (reader != null) 
					reader.Close();	
					
				commandWrapper = null;
			}
			return rows;
		}

		#endregion Parsed Find Methods
		
		#region Parameterized Find Methods
		
		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out. The number of rows that match this query.</param>
		/// <returns>Returns a typed collection of PMS.Entities.KetQuaCacKhoanChiKhac objects.</returns>
		public override TList<KetQuaCacKhoanChiKhac> Find(TransactionManager transactionManager, IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			SqlFilterParameterCollection filter = null;
			
			if (parameters == null)
				filter = new SqlFilterParameterCollection();
			else 
				filter = parameters.GetParameters();
				
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_KetQuaCacKhoanChiKhac_Find_Dynamic", typeof(KetQuaCacKhoanChiKhacColumn), filter, orderBy, start, pageLength);
		
			SqlFilterParameter param;

			for ( int i = 0; i < filter.Count; i++ )
			{
				param = filter[i];
				database.AddInParameter(commandWrapper, param.Name, param.DbType, param.GetValue());
			}

			TList<KetQuaCacKhoanChiKhac> rows = new TList<KetQuaCacKhoanChiKhac>();
			IDataReader reader = null;
			
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "Find", rows)); 

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
				
				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "Find", rows)); 
			}
			finally
			{
				if ( reader != null )
					reader.Close();
					
				commandWrapper = null;
			}
			
			return rows;
		}
		
		#endregion Parameterized Find Methods
		
		#endregion Find Functions
	
		#region GetAll Methods
				
		/// <summary>
		/// 	Gets All rows from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out. The number of rows that match this query.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KetQuaCacKhoanChiKhac objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override TList<KetQuaCacKhoanChiKhac> GetAll(TransactionManager transactionManager, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_KetQuaCacKhoanChiKhac_Get_List", _useStoredProcedure);
			
			IDataReader reader = null;
		
			//Create Collection
			TList<KetQuaCacKhoanChiKhac> rows = new TList<KetQuaCacKhoanChiKhac>();
			
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetAll", rows)); 
					
				if (transactionManager != null)
				{
					reader = Utility.ExecuteReader(transactionManager, commandWrapper);
				}
				else
				{
					reader = Utility.ExecuteReader(database, commandWrapper);
				}		
		
				Fill(reader, rows, start, pageLength);
				count = -1;
				if(reader.NextResult())
				{
					if(reader.Read())
					{
						count = reader.GetInt32(0);
					}
				}
				
				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetAll", rows)); 
			}
			finally 
			{
				if (reader != null) 
					reader.Close();
					
				commandWrapper = null;	
			}
			return rows;
		}//end getall
		
		#endregion
				
		#region GetPaged Methods
				
		/// <summary>
		/// Gets a page of rows from the DataSource.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">Number of rows in the DataSource.</param>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KetQuaCacKhoanChiKhac objects.</returns>
		public override TList<KetQuaCacKhoanChiKhac> GetPaged(TransactionManager transactionManager, string whereClause, string orderBy, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_KetQuaCacKhoanChiKhac_GetPaged", _useStoredProcedure);
		
			
            if (commandWrapper.CommandType == CommandType.Text
                && commandWrapper.CommandText != null)
            {
                commandWrapper.CommandText = commandWrapper.CommandText.Replace(SqlUtil.PAGE_INDEX, string.Concat(SqlUtil.PAGE_INDEX, Guid.NewGuid().ToString("N").Substring(0, 8)));
            }
			
			database.AddInParameter(commandWrapper, "@WhereClause", DbType.String, whereClause);
			database.AddInParameter(commandWrapper, "@OrderBy", DbType.String, orderBy);
			database.AddInParameter(commandWrapper, "@PageIndex", DbType.Int32, start);
			database.AddInParameter(commandWrapper, "@PageSize", DbType.Int32, pageLength);
		
			IDataReader reader = null;
			//Create Collection
			TList<KetQuaCacKhoanChiKhac> rows = new TList<KetQuaCacKhoanChiKhac>();
			
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetPaged", rows)); 

				if (transactionManager != null)
				{
					reader = Utility.ExecuteReader(transactionManager, commandWrapper);
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
				
				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetPaged", rows)); 

			}
			catch(Exception)
			{			
				throw;
			}
			finally
			{
				if (reader != null) 
					reader.Close();
				
				commandWrapper = null;
			}
			
			return rows;
		}
		
		#endregion	
		
		#region Get By Foreign Key Functions
	#endregion
	
		#region Get By Index Functions

		#region GetById
					
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KetQuaCacKhoanChiKhac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaCacKhoanChiKhac"/> class.</returns>
		/// <remarks></remarks>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override PMS.Entities.KetQuaCacKhoanChiKhac GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_KetQuaCacKhoanChiKhac_GetById", _useStoredProcedure);
			
				database.AddInParameter(commandWrapper, "@Id", DbType.Int32, _id);
			
			IDataReader reader = null;
			TList<KetQuaCacKhoanChiKhac> tmp = new TList<KetQuaCacKhoanChiKhac>();
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetById", tmp)); 

				if (transactionManager != null)
				{
					reader = Utility.ExecuteReader(transactionManager, commandWrapper);
				}
				else
				{
					reader = Utility.ExecuteReader(database, commandWrapper);
				}		
		
				//Create collection and fill
				Fill(reader, tmp, start, pageLength);
				count = -1;
				if(reader.NextResult())
				{
					if(reader.Read())
					{
						count = reader.GetInt32(0);
					}
				}
				
				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetById", tmp));
			}
			finally 
			{
				if (reader != null) 
					reader.Close();
					
				commandWrapper = null;
			}
			
			if (tmp.Count == 1)
			{
				return tmp[0];
			}
			else if (tmp.Count == 0)
			{
				return null;
			}
			else
			{
				throw new DataException("Cannot find the unique instance of the class.");
			}
			
			//return rows;
		}
		
		#endregion

	#endregion Get By Index Functions

		#region Insert Methods
		/// <summary>
		/// Lets you efficiently bulk insert many entities to the database.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entities">The entities.</param>
		/// <remarks>
		///		After inserting into the datasource, the PMS.Entities.KetQuaCacKhoanChiKhac object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>	
		public override void BulkInsert(TransactionManager transactionManager, TList<PMS.Entities.KetQuaCacKhoanChiKhac> entities)
		{
			//System.Data.SqlClient.SqlBulkCopy bulkCopy = new System.Data.SqlClient.SqlBulkCopy(this._connectionString, System.Data.SqlClient.SqlBulkCopyOptions.CheckConstraints); //, null);
			
			System.Data.SqlClient.SqlBulkCopy bulkCopy = null;
	
			if (transactionManager != null && transactionManager.IsOpen)
			{			
				System.Data.SqlClient.SqlConnection cnx = transactionManager.TransactionObject.Connection as System.Data.SqlClient.SqlConnection;
				System.Data.SqlClient.SqlTransaction transaction = transactionManager.TransactionObject as System.Data.SqlClient.SqlTransaction;
				bulkCopy = new System.Data.SqlClient.SqlBulkCopy(cnx, System.Data.SqlClient.SqlBulkCopyOptions.CheckConstraints, transaction); //, null);
			}
			else
			{
				bulkCopy = new System.Data.SqlClient.SqlBulkCopy(this._connectionString, System.Data.SqlClient.SqlBulkCopyOptions.CheckConstraints); //, null);
			}
			
			bulkCopy.BulkCopyTimeout = 360;
			bulkCopy.DestinationTableName = "KetQuaCacKhoanChiKhac";
			
			DataTable dataTable = new DataTable();
			DataColumn col0 = dataTable.Columns.Add("Id", typeof(System.Int32));
			col0.AllowDBNull = false;		
			DataColumn col1 = dataTable.Columns.Add("MaGiangVienQuanLy", typeof(System.String));
			col1.AllowDBNull = true;		
			DataColumn col2 = dataTable.Columns.Add("Lop", typeof(System.String));
			col2.AllowDBNull = true;		
			DataColumn col3 = dataTable.Columns.Add("MaSo", typeof(System.String));
			col3.AllowDBNull = true;		
			DataColumn col4 = dataTable.Columns.Add("Ngay", typeof(System.DateTime));
			col4.AllowDBNull = true;		
			DataColumn col5 = dataTable.Columns.Add("NoiDung", typeof(System.String));
			col5.AllowDBNull = true;		
			DataColumn col6 = dataTable.Columns.Add("HeSo", typeof(System.Decimal));
			col6.AllowDBNull = true;		
			DataColumn col7 = dataTable.Columns.Add("SoTiet", typeof(System.Decimal));
			col7.AllowDBNull = true;		
			DataColumn col8 = dataTable.Columns.Add("TienMotTiet", typeof(System.Decimal));
			col8.AllowDBNull = true;		
			DataColumn col9 = dataTable.Columns.Add("ThanhTien", typeof(System.Decimal));
			col9.AllowDBNull = true;		
			DataColumn col10 = dataTable.Columns.Add("PhiCongTac", typeof(System.Decimal));
			col10.AllowDBNull = true;		
			DataColumn col11 = dataTable.Columns.Add("TienGiangNgoaiGio", typeof(System.Decimal));
			col11.AllowDBNull = true;		
			DataColumn col12 = dataTable.Columns.Add("TongThanhTien", typeof(System.Decimal));
			col12.AllowDBNull = true;		
			
			bulkCopy.ColumnMappings.Add("Id", "Id");
			bulkCopy.ColumnMappings.Add("MaGiangVienQuanLy", "MaGiangVienQuanLy");
			bulkCopy.ColumnMappings.Add("Lop", "Lop");
			bulkCopy.ColumnMappings.Add("MaSo", "MaSo");
			bulkCopy.ColumnMappings.Add("Ngay", "Ngay");
			bulkCopy.ColumnMappings.Add("NoiDung", "NoiDung");
			bulkCopy.ColumnMappings.Add("HeSo", "HeSo");
			bulkCopy.ColumnMappings.Add("SoTiet", "SoTiet");
			bulkCopy.ColumnMappings.Add("TienMotTiet", "TienMotTiet");
			bulkCopy.ColumnMappings.Add("ThanhTien", "ThanhTien");
			bulkCopy.ColumnMappings.Add("PhiCongTac", "PhiCongTac");
			bulkCopy.ColumnMappings.Add("TienGiangNgoaiGio", "TienGiangNgoaiGio");
			bulkCopy.ColumnMappings.Add("TongThanhTien", "TongThanhTien");
			
			foreach(PMS.Entities.KetQuaCacKhoanChiKhac entity in entities)
			{
				if (entity.EntityState != EntityState.Added)
					continue;
					
				DataRow row = dataTable.NewRow();
				
					row["Id"] = entity.Id;
							
				
					row["MaGiangVienQuanLy"] = entity.MaGiangVienQuanLy;
							
				
					row["Lop"] = entity.Lop;
							
				
					row["MaSo"] = entity.MaSo;
							
				
					row["Ngay"] = entity.Ngay.HasValue ? (object) entity.Ngay  : System.DBNull.Value;
							
				
					row["NoiDung"] = entity.NoiDung;
							
				
					row["HeSo"] = entity.HeSo.HasValue ? (object) entity.HeSo  : System.DBNull.Value;
							
				
					row["SoTiet"] = entity.SoTiet.HasValue ? (object) entity.SoTiet  : System.DBNull.Value;
							
				
					row["TienMotTiet"] = entity.TienMotTiet.HasValue ? (object) entity.TienMotTiet  : System.DBNull.Value;
							
				
					row["ThanhTien"] = entity.ThanhTien.HasValue ? (object) entity.ThanhTien  : System.DBNull.Value;
							
				
					row["PhiCongTac"] = entity.PhiCongTac.HasValue ? (object) entity.PhiCongTac  : System.DBNull.Value;
							
				
					row["TienGiangNgoaiGio"] = entity.TienGiangNgoaiGio.HasValue ? (object) entity.TienGiangNgoaiGio  : System.DBNull.Value;
							
				
					row["TongThanhTien"] = entity.TongThanhTien.HasValue ? (object) entity.TongThanhTien  : System.DBNull.Value;
							
				
				dataTable.Rows.Add(row);
			}		
			
			// send the data to the server		
			bulkCopy.WriteToServer(dataTable);		
			
			// update back the state
			foreach(PMS.Entities.KetQuaCacKhoanChiKhac entity in entities)
			{
				if (entity.EntityState != EntityState.Added)
					continue;
			
				entity.AcceptChanges();
			}
		}
				
		/// <summary>
		/// 	Inserts a PMS.Entities.KetQuaCacKhoanChiKhac object into the datasource using a transaction.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">PMS.Entities.KetQuaCacKhoanChiKhac object to insert.</param>
		/// <remarks>
		///		After inserting into the datasource, the PMS.Entities.KetQuaCacKhoanChiKhac object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>	
		/// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Insert(TransactionManager transactionManager, PMS.Entities.KetQuaCacKhoanChiKhac entity)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_KetQuaCacKhoanChiKhac_Insert", _useStoredProcedure);
			
			database.AddOutParameter(commandWrapper, "@Id", DbType.Int32, 4);
            database.AddInParameter(commandWrapper, "@MaGiangVienQuanLy", DbType.AnsiString, entity.MaGiangVienQuanLy );
            database.AddInParameter(commandWrapper, "@Lop", DbType.String, entity.Lop );
            database.AddInParameter(commandWrapper, "@MaSo", DbType.String, entity.MaSo );
			database.AddInParameter(commandWrapper, "@Ngay", DbType.DateTime, (entity.Ngay.HasValue ? (object) entity.Ngay  : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@NoiDung", DbType.String, entity.NoiDung );
			database.AddInParameter(commandWrapper, "@HeSo", DbType.Decimal, (entity.HeSo.HasValue ? (object) entity.HeSo  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@SoTiet", DbType.Decimal, (entity.SoTiet.HasValue ? (object) entity.SoTiet  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@TienMotTiet", DbType.Decimal, (entity.TienMotTiet.HasValue ? (object) entity.TienMotTiet  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@ThanhTien", DbType.Decimal, (entity.ThanhTien.HasValue ? (object) entity.ThanhTien  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@PhiCongTac", DbType.Decimal, (entity.PhiCongTac.HasValue ? (object) entity.PhiCongTac  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@TienGiangNgoaiGio", DbType.Decimal, (entity.TienGiangNgoaiGio.HasValue ? (object) entity.TienGiangNgoaiGio  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@TongThanhTien", DbType.Decimal, (entity.TongThanhTien.HasValue ? (object) entity.TongThanhTien  : System.DBNull.Value));
			
			int results = 0;
			
			//Provider Data Requesting Command Event
			OnDataRequesting(new CommandEventArgs(commandWrapper, "Insert", entity));
				
			if (transactionManager != null)
			{
				results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
			}
			else
			{
				results = Utility.ExecuteNonQuery(database,commandWrapper);
			}
					
			object _id = database.GetParameterValue(commandWrapper, "@Id");
			entity.Id = (System.Int32)_id;
			
			
			entity.AcceptChanges();
	
			//Provider Data Requested Command Event
			OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

			return Convert.ToBoolean(results);
		}	
		#endregion

		#region Update Methods
				
		/// <summary>
		/// 	Update an existing row in the datasource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">PMS.Entities.KetQuaCacKhoanChiKhac object to update.</param>
		/// <remarks>
		///		After updating the datasource, the PMS.Entities.KetQuaCacKhoanChiKhac object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>
		/// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Update(TransactionManager transactionManager, PMS.Entities.KetQuaCacKhoanChiKhac entity)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_KetQuaCacKhoanChiKhac_Update", _useStoredProcedure);
			
            database.AddInParameter(commandWrapper, "@Id", DbType.Int32, entity.Id );
            database.AddInParameter(commandWrapper, "@MaGiangVienQuanLy", DbType.AnsiString, entity.MaGiangVienQuanLy );
            database.AddInParameter(commandWrapper, "@Lop", DbType.String, entity.Lop );
            database.AddInParameter(commandWrapper, "@MaSo", DbType.String, entity.MaSo );
			database.AddInParameter(commandWrapper, "@Ngay", DbType.DateTime, (entity.Ngay.HasValue ? (object) entity.Ngay : System.DBNull.Value) );
            database.AddInParameter(commandWrapper, "@NoiDung", DbType.String, entity.NoiDung );
			database.AddInParameter(commandWrapper, "@HeSo", DbType.Decimal, (entity.HeSo.HasValue ? (object) entity.HeSo : System.DBNull.Value) );
			database.AddInParameter(commandWrapper, "@SoTiet", DbType.Decimal, (entity.SoTiet.HasValue ? (object) entity.SoTiet : System.DBNull.Value) );
			database.AddInParameter(commandWrapper, "@TienMotTiet", DbType.Decimal, (entity.TienMotTiet.HasValue ? (object) entity.TienMotTiet : System.DBNull.Value) );
			database.AddInParameter(commandWrapper, "@ThanhTien", DbType.Decimal, (entity.ThanhTien.HasValue ? (object) entity.ThanhTien : System.DBNull.Value) );
			database.AddInParameter(commandWrapper, "@PhiCongTac", DbType.Decimal, (entity.PhiCongTac.HasValue ? (object) entity.PhiCongTac : System.DBNull.Value) );
			database.AddInParameter(commandWrapper, "@TienGiangNgoaiGio", DbType.Decimal, (entity.TienGiangNgoaiGio.HasValue ? (object) entity.TienGiangNgoaiGio : System.DBNull.Value) );
			database.AddInParameter(commandWrapper, "@TongThanhTien", DbType.Decimal, (entity.TongThanhTien.HasValue ? (object) entity.TongThanhTien : System.DBNull.Value) );
			
			int results = 0;
			
			//Provider Data Requesting Command Event
			OnDataRequesting(new CommandEventArgs(commandWrapper, "Update", entity));

			if (transactionManager != null)
			{
				results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
			}
			else
			{
				results = Utility.ExecuteNonQuery(database,commandWrapper);
			}
			
			//Stop Tracking Now that it has been updated and persisted.
			if (DataRepository.Provider.EnableEntityTracking)
            {
                EntityManager.StopTracking(entity.EntityTrackingKey);				
            }
			
			
			entity.AcceptChanges();
			
			//Provider Data Requested Command Event
			OnDataRequested(new CommandEventArgs(commandWrapper, "Update", entity));

			return Convert.ToBoolean(results);
		}
			
		#endregion
		
		#region Custom Methods
	

		#region cust_KetQuaCacKhoanChiKhac_Luu
					
		/// <summary>
		///	This method wraps the 'cust_KetQuaCacKhoanChiKhac_Luu' stored procedure. 
		/// </summary>	
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object.</param>
		/// <remark>This method is generated from a stored procedure.</remark>
		public override void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.DateTime tuNgay, System.DateTime denNgay, ref System.Int32 reVal)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.cust_KetQuaCacKhoanChiKhac_Luu", true);
			
			database.AddInParameter(commandWrapper, "@XmlData", DbType.String,  xmlData );
			database.AddInParameter(commandWrapper, "@TuNgay", DbType.DateTime,  tuNgay );
			database.AddInParameter(commandWrapper, "@DenNgay", DbType.DateTime,  denNgay );
	
			database.AddParameter(commandWrapper, "@ReVal", DbType.Int32, 4, ParameterDirection.InputOutput, true, 10, 0, string.Empty, DataRowVersion.Current, reVal);
			
			//Provider Data Requesting Command Event
			OnDataRequesting(new CommandEventArgs(commandWrapper, "Luu", (IEntity)null));

			if (transactionManager != null)
			{	
				Utility.ExecuteNonQuery(transactionManager, commandWrapper );
			}
			else
			{
				Utility.ExecuteNonQuery(database, commandWrapper);
			}
						
			//Provider Data Requested Command Event
			OnDataRequested(new CommandEventArgs(commandWrapper, "Luu", (IEntity)null));

			reVal =  Utility.GetParameterValue<System.Int32>(commandWrapper.Parameters["@ReVal"]);

				
				return;
		}
		#endregion
		#endregion
	}//end class
} // end namespace