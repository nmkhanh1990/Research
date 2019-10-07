﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file SqlGiangVienThayDoiHocViProvider.cs instead.
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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="GiangVienThayDoiHocVi"/> entity.
	///</summary>
	public abstract partial class SqlGiangVienThayDoiHocViProviderBase : GiangVienThayDoiHocViProviderBase
	{
		#region Declarations
		
		string _connectionString;
	    bool _useStoredProcedure;
	    string _providerInvariantName;
			
		#endregion "Declarations"
			
		#region Constructors
		
		/// <summary>
		/// Creates a new <see cref="SqlGiangVienThayDoiHocViProviderBase"/> instance.
		/// </summary>
		public SqlGiangVienThayDoiHocViProviderBase()
		{
		}
	
	/// <summary>
	/// Creates a new <see cref="SqlGiangVienThayDoiHocViProviderBase"/> instance.
	/// Uses connection string to connect to datasource.
	/// </summary>
	/// <param name="connectionString">The connection string to the database.</param>
	/// <param name="useStoredProcedure">A boolean value that indicates if we should use stored procedures or embedded queries.</param>
	/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
	public SqlGiangVienThayDoiHocViProviderBase(string connectionString, bool useStoredProcedure, string providerInvariantName)
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
		/// <param name="_maQuanLy">. Primary Key.</param>	
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Delete(TransactionManager transactionManager, System.Int32 _maQuanLy)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_GIangVienThayDoiHocVi_Delete", _useStoredProcedure);
			database.AddInParameter(commandWrapper, "@MaQuanLy", DbType.Int32, _maQuanLy);
			
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
				string entityKey = EntityLocator.ConstructKeyFromPkItems(typeof(GiangVienThayDoiHocVi)
					,_maQuanLy);
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
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienThayDoiHocVi objects.</returns>
		public override TList<GiangVienThayDoiHocVi> Find(TransactionManager transactionManager, string whereClause, int start, int pageLength, out int count)
		{
			count = -1;
			if (whereClause.IndexOf(";") > -1)
				return new TList<GiangVienThayDoiHocVi>();
	
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_GIangVienThayDoiHocVi_Find", _useStoredProcedure);

		bool searchUsingOR = false;
		if (whereClause.IndexOf(" OR ") > 0) // did they want to do "a=b OR c=d OR..."?
			searchUsingOR = true;
		
		database.AddInParameter(commandWrapper, "@SearchUsingOR", DbType.Boolean, searchUsingOR);
		
		database.AddInParameter(commandWrapper, "@MaQuanLy", DbType.Int32, DBNull.Value);
		database.AddInParameter(commandWrapper, "@MaGiangVien", DbType.Int32, DBNull.Value);
		database.AddInParameter(commandWrapper, "@MaHocViCu", DbType.Int32, DBNull.Value);
		database.AddInParameter(commandWrapper, "@MaHocVi", DbType.Int32, DBNull.Value);
		database.AddInParameter(commandWrapper, "@NgayHieuLuc", DbType.DateTime, DBNull.Value);
		database.AddInParameter(commandWrapper, "@NgayCapNhat", DbType.DateTime, DBNull.Value);
		database.AddInParameter(commandWrapper, "@User", DbType.AnsiString, DBNull.Value);
	
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
				if (clause.Trim().StartsWith("maquanly ") || clause.Trim().StartsWith("maquanly="))
				{
					database.SetParameterValue(commandWrapper, "@MaQuanLy", 
						clause.Trim().Remove(0,8).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("magiangvien ") || clause.Trim().StartsWith("magiangvien="))
				{
					database.SetParameterValue(commandWrapper, "@MaGiangVien", 
						clause.Trim().Remove(0,11).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("mahocvicu ") || clause.Trim().StartsWith("mahocvicu="))
				{
					database.SetParameterValue(commandWrapper, "@MaHocViCu", 
						clause.Trim().Remove(0,9).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("mahocvi ") || clause.Trim().StartsWith("mahocvi="))
				{
					database.SetParameterValue(commandWrapper, "@MaHocVi", 
						clause.Trim().Remove(0,7).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("ngayhieuluc ") || clause.Trim().StartsWith("ngayhieuluc="))
				{
					database.SetParameterValue(commandWrapper, "@NgayHieuLuc", 
						clause.Trim().Remove(0,11).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("ngaycapnhat ") || clause.Trim().StartsWith("ngaycapnhat="))
				{
					database.SetParameterValue(commandWrapper, "@NgayCapNhat", 
						clause.Trim().Remove(0,11).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("user ") || clause.Trim().StartsWith("user="))
				{
					database.SetParameterValue(commandWrapper, "@User", 
						clause.Trim().Remove(0,4).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
	
				throw new ArgumentException("Unable to use this part of the where clause in this version of Find: " + clause);
			}
					
			IDataReader reader = null;
			//Create Collection
			TList<GiangVienThayDoiHocVi> rows = new TList<GiangVienThayDoiHocVi>();
	
				
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
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienThayDoiHocVi objects.</returns>
		public override TList<GiangVienThayDoiHocVi> Find(TransactionManager transactionManager, IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			SqlFilterParameterCollection filter = null;
			
			if (parameters == null)
				filter = new SqlFilterParameterCollection();
			else 
				filter = parameters.GetParameters();
				
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_GIangVienThayDoiHocVi_Find_Dynamic", typeof(GiangVienThayDoiHocViColumn), filter, orderBy, start, pageLength);
		
			SqlFilterParameter param;

			for ( int i = 0; i < filter.Count; i++ )
			{
				param = filter[i];
				database.AddInParameter(commandWrapper, param.Name, param.DbType, param.GetValue());
			}

			TList<GiangVienThayDoiHocVi> rows = new TList<GiangVienThayDoiHocVi>();
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
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienThayDoiHocVi objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override TList<GiangVienThayDoiHocVi> GetAll(TransactionManager transactionManager, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_GIangVienThayDoiHocVi_Get_List", _useStoredProcedure);
			
			IDataReader reader = null;
		
			//Create Collection
			TList<GiangVienThayDoiHocVi> rows = new TList<GiangVienThayDoiHocVi>();
			
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
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienThayDoiHocVi objects.</returns>
		public override TList<GiangVienThayDoiHocVi> GetPaged(TransactionManager transactionManager, string whereClause, string orderBy, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_GIangVienThayDoiHocVi_GetPaged", _useStoredProcedure);
		
			
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
			TList<GiangVienThayDoiHocVi> rows = new TList<GiangVienThayDoiHocVi>();
			
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

		#region GetByMaQuanLy
					
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThayDoiHocVi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienThayDoiHocVi"/> class.</returns>
		/// <remarks></remarks>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override PMS.Entities.GiangVienThayDoiHocVi GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_GIangVienThayDoiHocVi_GetByMaQuanLy", _useStoredProcedure);
			
				database.AddInParameter(commandWrapper, "@MaQuanLy", DbType.Int32, _maQuanLy);
			
			IDataReader reader = null;
			TList<GiangVienThayDoiHocVi> tmp = new TList<GiangVienThayDoiHocVi>();
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByMaQuanLy", tmp)); 

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
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetByMaQuanLy", tmp));
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
		///		After inserting into the datasource, the PMS.Entities.GiangVienThayDoiHocVi object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>	
		public override void BulkInsert(TransactionManager transactionManager, TList<PMS.Entities.GiangVienThayDoiHocVi> entities)
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
			bulkCopy.DestinationTableName = "GIangVienThayDoiHocVi";
			
			DataTable dataTable = new DataTable();
			DataColumn col0 = dataTable.Columns.Add("MaQuanLy", typeof(System.Int32));
			col0.AllowDBNull = false;		
			DataColumn col1 = dataTable.Columns.Add("MaGiangVien", typeof(System.Int32));
			col1.AllowDBNull = true;		
			DataColumn col2 = dataTable.Columns.Add("MaHocViCu", typeof(System.Int32));
			col2.AllowDBNull = true;		
			DataColumn col3 = dataTable.Columns.Add("MaHocVi", typeof(System.Int32));
			col3.AllowDBNull = true;		
			DataColumn col4 = dataTable.Columns.Add("NgayHieuLuc", typeof(System.DateTime));
			col4.AllowDBNull = true;		
			DataColumn col5 = dataTable.Columns.Add("NgayCapNhat", typeof(System.DateTime));
			col5.AllowDBNull = true;		
			DataColumn col6 = dataTable.Columns.Add("User", typeof(System.String));
			col6.AllowDBNull = true;		
			
			bulkCopy.ColumnMappings.Add("MaQuanLy", "MaQuanLy");
			bulkCopy.ColumnMappings.Add("MaGiangVien", "MaGiangVien");
			bulkCopy.ColumnMappings.Add("MaHocViCu", "MaHocViCu");
			bulkCopy.ColumnMappings.Add("MaHocVi", "MaHocVi");
			bulkCopy.ColumnMappings.Add("NgayHieuLuc", "NgayHieuLuc");
			bulkCopy.ColumnMappings.Add("NgayCapNhat", "NgayCapNhat");
			bulkCopy.ColumnMappings.Add("User", "User");
			
			foreach(PMS.Entities.GiangVienThayDoiHocVi entity in entities)
			{
				if (entity.EntityState != EntityState.Added)
					continue;
					
				DataRow row = dataTable.NewRow();
				
					row["MaQuanLy"] = entity.MaQuanLy;
							
				
					row["MaGiangVien"] = entity.MaGiangVien.HasValue ? (object) entity.MaGiangVien  : System.DBNull.Value;
							
				
					row["MaHocViCu"] = entity.MaHocViCu.HasValue ? (object) entity.MaHocViCu  : System.DBNull.Value;
							
				
					row["MaHocVi"] = entity.MaHocVi.HasValue ? (object) entity.MaHocVi  : System.DBNull.Value;
							
				
					row["NgayHieuLuc"] = entity.NgayHieuLuc.HasValue ? (object) entity.NgayHieuLuc  : System.DBNull.Value;
							
				
					row["NgayCapNhat"] = entity.NgayCapNhat.HasValue ? (object) entity.NgayCapNhat  : System.DBNull.Value;
							
				
					row["User"] = entity.User;
							
				
				dataTable.Rows.Add(row);
			}		
			
			// send the data to the server		
			bulkCopy.WriteToServer(dataTable);		
			
			// update back the state
			foreach(PMS.Entities.GiangVienThayDoiHocVi entity in entities)
			{
				if (entity.EntityState != EntityState.Added)
					continue;
			
				entity.AcceptChanges();
			}
		}
				
		/// <summary>
		/// 	Inserts a PMS.Entities.GiangVienThayDoiHocVi object into the datasource using a transaction.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">PMS.Entities.GiangVienThayDoiHocVi object to insert.</param>
		/// <remarks>
		///		After inserting into the datasource, the PMS.Entities.GiangVienThayDoiHocVi object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>	
		/// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Insert(TransactionManager transactionManager, PMS.Entities.GiangVienThayDoiHocVi entity)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_GIangVienThayDoiHocVi_Insert", _useStoredProcedure);
			
			database.AddOutParameter(commandWrapper, "@MaQuanLy", DbType.Int32, 4);
			database.AddInParameter(commandWrapper, "@MaGiangVien", DbType.Int32, (entity.MaGiangVien.HasValue ? (object) entity.MaGiangVien  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@MaHocViCu", DbType.Int32, (entity.MaHocViCu.HasValue ? (object) entity.MaHocViCu  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@MaHocVi", DbType.Int32, (entity.MaHocVi.HasValue ? (object) entity.MaHocVi  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@NgayHieuLuc", DbType.DateTime, (entity.NgayHieuLuc.HasValue ? (object) entity.NgayHieuLuc  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@NgayCapNhat", DbType.DateTime, (entity.NgayCapNhat.HasValue ? (object) entity.NgayCapNhat  : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@User", DbType.AnsiString, entity.User );
			
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
					
			object _maQuanLy = database.GetParameterValue(commandWrapper, "@MaQuanLy");
			entity.MaQuanLy = (System.Int32)_maQuanLy;
			
			
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
		/// <param name="entity">PMS.Entities.GiangVienThayDoiHocVi object to update.</param>
		/// <remarks>
		///		After updating the datasource, the PMS.Entities.GiangVienThayDoiHocVi object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>
		/// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Update(TransactionManager transactionManager, PMS.Entities.GiangVienThayDoiHocVi entity)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_GIangVienThayDoiHocVi_Update", _useStoredProcedure);
			
            database.AddInParameter(commandWrapper, "@MaQuanLy", DbType.Int32, entity.MaQuanLy );
			database.AddInParameter(commandWrapper, "@MaGiangVien", DbType.Int32, (entity.MaGiangVien.HasValue ? (object) entity.MaGiangVien : System.DBNull.Value) );
			database.AddInParameter(commandWrapper, "@MaHocViCu", DbType.Int32, (entity.MaHocViCu.HasValue ? (object) entity.MaHocViCu : System.DBNull.Value) );
			database.AddInParameter(commandWrapper, "@MaHocVi", DbType.Int32, (entity.MaHocVi.HasValue ? (object) entity.MaHocVi : System.DBNull.Value) );
			database.AddInParameter(commandWrapper, "@NgayHieuLuc", DbType.DateTime, (entity.NgayHieuLuc.HasValue ? (object) entity.NgayHieuLuc : System.DBNull.Value) );
			database.AddInParameter(commandWrapper, "@NgayCapNhat", DbType.DateTime, (entity.NgayCapNhat.HasValue ? (object) entity.NgayCapNhat : System.DBNull.Value) );
            database.AddInParameter(commandWrapper, "@User", DbType.AnsiString, entity.User );
			
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
	

		#region cust_GiangVienThayDoiHocVi_Luu
					
		/// <summary>
		///	This method wraps the 'cust_GiangVienThayDoiHocVi_Luu' stored procedure. 
		/// </summary>	
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocViCu"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocViMoi"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayHieuLuc"> A <c>System.DateTime</c> instance.</param>
		/// <param name="ngayCapNhat"> A <c>System.DateTime</c> instance.</param>
		/// <param name="user"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object.</param>
		/// <remark>This method is generated from a stored procedure.</remark>
		public override void Luu(TransactionManager transactionManager, int start, int pageLength , System.Int32 maGiangVien, System.Int32 maHocViCu, System.Int32 maHocViMoi, System.DateTime ngayHieuLuc, System.DateTime ngayCapNhat, System.String user, ref System.Int32 reVal)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.cust_GiangVienThayDoiHocVi_Luu", true);
			
			database.AddInParameter(commandWrapper, "@MaGiangVien", DbType.Int32,  maGiangVien );
			database.AddInParameter(commandWrapper, "@MaHocViCu", DbType.Int32,  maHocViCu );
			database.AddInParameter(commandWrapper, "@MaHocViMoi", DbType.Int32,  maHocViMoi );
			database.AddInParameter(commandWrapper, "@NgayHieuLuc", DbType.DateTime,  ngayHieuLuc );
			database.AddInParameter(commandWrapper, "@NgayCapNhat", DbType.DateTime,  ngayCapNhat );
			database.AddInParameter(commandWrapper, "@User", DbType.AnsiString,  user );
	
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
