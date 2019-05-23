﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file SqlTrangThaiGiangVienProvider.cs instead.
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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="TrangThaiGiangVien"/> entity.
	///</summary>
	public abstract partial class SqlTrangThaiGiangVienProviderBase : TrangThaiGiangVienProviderBase
	{
		#region Declarations
		
		string _connectionString;
	    bool _useStoredProcedure;
	    string _providerInvariantName;
			
		#endregion "Declarations"
			
		#region Constructors
		
		/// <summary>
		/// Creates a new <see cref="SqlTrangThaiGiangVienProviderBase"/> instance.
		/// </summary>
		public SqlTrangThaiGiangVienProviderBase()
		{
		}
	
	/// <summary>
	/// Creates a new <see cref="SqlTrangThaiGiangVienProviderBase"/> instance.
	/// Uses connection string to connect to datasource.
	/// </summary>
	/// <param name="connectionString">The connection string to the database.</param>
	/// <param name="useStoredProcedure">A boolean value that indicates if we should use stored procedures or embedded queries.</param>
	/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
	public SqlTrangThaiGiangVienProviderBase(string connectionString, bool useStoredProcedure, string providerInvariantName)
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
		/// <param name="_maKhoa">. Primary Key.</param>	
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Delete(TransactionManager transactionManager, System.Int32 _maKhoa)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_TrangThaiGiangVien_Delete", _useStoredProcedure);
			database.AddInParameter(commandWrapper, "@MaKhoa", DbType.Int32, _maKhoa);
			
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
				string entityKey = EntityLocator.ConstructKeyFromPkItems(typeof(TrangThaiGiangVien)
					,_maKhoa);
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
		/// <returns>Returns a typed collection of PMS.Entities.TrangThaiGiangVien objects.</returns>
		public override TList<TrangThaiGiangVien> Find(TransactionManager transactionManager, string whereClause, int start, int pageLength, out int count)
		{
			count = -1;
			if (whereClause.IndexOf(";") > -1)
				return new TList<TrangThaiGiangVien>();
	
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_TrangThaiGiangVien_Find", _useStoredProcedure);

		bool searchUsingOR = false;
		if (whereClause.IndexOf(" OR ") > 0) // did they want to do "a=b OR c=d OR..."?
			searchUsingOR = true;
		
		database.AddInParameter(commandWrapper, "@SearchUsingOR", DbType.Boolean, searchUsingOR);
		
		database.AddInParameter(commandWrapper, "@MaKhoa", DbType.Int32, DBNull.Value);
		database.AddInParameter(commandWrapper, "@MaGiangVien", DbType.AnsiString, DBNull.Value);
		database.AddInParameter(commandWrapper, "@MaLopHocPhan", DbType.String, DBNull.Value);
		database.AddInParameter(commandWrapper, "@IdChucNang", DbType.Int32, DBNull.Value);
		database.AddInParameter(commandWrapper, "@NgayCapNhat", DbType.DateTime, DBNull.Value);
		database.AddInParameter(commandWrapper, "@NguoiCapNhat", DbType.String, DBNull.Value);
		database.AddInParameter(commandWrapper, "@TrangThai", DbType.Boolean, DBNull.Value);
		database.AddInParameter(commandWrapper, "@NameFrom", DbType.String, DBNull.Value);
		database.AddInParameter(commandWrapper, "@NamHoc", DbType.String, DBNull.Value);
		database.AddInParameter(commandWrapper, "@HocKy", DbType.String, DBNull.Value);
	
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
				if (clause.Trim().StartsWith("makhoa ") || clause.Trim().StartsWith("makhoa="))
				{
					database.SetParameterValue(commandWrapper, "@MaKhoa", 
						clause.Trim().Remove(0,6).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("magiangvien ") || clause.Trim().StartsWith("magiangvien="))
				{
					database.SetParameterValue(commandWrapper, "@MaGiangVien", 
						clause.Trim().Remove(0,11).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("malophocphan ") || clause.Trim().StartsWith("malophocphan="))
				{
					database.SetParameterValue(commandWrapper, "@MaLopHocPhan", 
						clause.Trim().Remove(0,12).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("idchucnang ") || clause.Trim().StartsWith("idchucnang="))
				{
					database.SetParameterValue(commandWrapper, "@IdChucNang", 
						clause.Trim().Remove(0,10).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("ngaycapnhat ") || clause.Trim().StartsWith("ngaycapnhat="))
				{
					database.SetParameterValue(commandWrapper, "@NgayCapNhat", 
						clause.Trim().Remove(0,11).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("nguoicapnhat ") || clause.Trim().StartsWith("nguoicapnhat="))
				{
					database.SetParameterValue(commandWrapper, "@NguoiCapNhat", 
						clause.Trim().Remove(0,12).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("trangthai ") || clause.Trim().StartsWith("trangthai="))
				{
					database.SetParameterValue(commandWrapper, "@TrangThai", 
						clause.Trim().Remove(0,9).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("namefrom ") || clause.Trim().StartsWith("namefrom="))
				{
					database.SetParameterValue(commandWrapper, "@NameFrom", 
						clause.Trim().Remove(0,8).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("namhoc ") || clause.Trim().StartsWith("namhoc="))
				{
					database.SetParameterValue(commandWrapper, "@NamHoc", 
						clause.Trim().Remove(0,6).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("hocky ") || clause.Trim().StartsWith("hocky="))
				{
					database.SetParameterValue(commandWrapper, "@HocKy", 
						clause.Trim().Remove(0,5).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
	
				throw new ArgumentException("Unable to use this part of the where clause in this version of Find: " + clause);
			}
					
			IDataReader reader = null;
			//Create Collection
			TList<TrangThaiGiangVien> rows = new TList<TrangThaiGiangVien>();
	
				
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
		/// <returns>Returns a typed collection of PMS.Entities.TrangThaiGiangVien objects.</returns>
		public override TList<TrangThaiGiangVien> Find(TransactionManager transactionManager, IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			SqlFilterParameterCollection filter = null;
			
			if (parameters == null)
				filter = new SqlFilterParameterCollection();
			else 
				filter = parameters.GetParameters();
				
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_TrangThaiGiangVien_Find_Dynamic", typeof(TrangThaiGiangVienColumn), filter, orderBy, start, pageLength);
		
			SqlFilterParameter param;

			for ( int i = 0; i < filter.Count; i++ )
			{
				param = filter[i];
				database.AddInParameter(commandWrapper, param.Name, param.DbType, param.GetValue());
			}

			TList<TrangThaiGiangVien> rows = new TList<TrangThaiGiangVien>();
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
		/// <returns>Returns a typed collection of PMS.Entities.TrangThaiGiangVien objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override TList<TrangThaiGiangVien> GetAll(TransactionManager transactionManager, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_TrangThaiGiangVien_Get_List", _useStoredProcedure);
			
			IDataReader reader = null;
		
			//Create Collection
			TList<TrangThaiGiangVien> rows = new TList<TrangThaiGiangVien>();
			
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
		/// <returns>Returns a typed collection of PMS.Entities.TrangThaiGiangVien objects.</returns>
		public override TList<TrangThaiGiangVien> GetPaged(TransactionManager transactionManager, string whereClause, string orderBy, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_TrangThaiGiangVien_GetPaged", _useStoredProcedure);
		
			
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
			TList<TrangThaiGiangVien> rows = new TList<TrangThaiGiangVien>();
			
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

		#region GetByMaKhoa
					
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__TrangTha__65390405C6C801F6 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoa"></param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TrangThaiGiangVien"/> class.</returns>
		/// <remarks></remarks>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override PMS.Entities.TrangThaiGiangVien GetByMaKhoa(TransactionManager transactionManager, System.Int32 _maKhoa, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_TrangThaiGiangVien_GetByMaKhoa", _useStoredProcedure);
			
				database.AddInParameter(commandWrapper, "@MaKhoa", DbType.Int32, _maKhoa);
			
			IDataReader reader = null;
			TList<TrangThaiGiangVien> tmp = new TList<TrangThaiGiangVien>();
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByMaKhoa", tmp)); 

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
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetByMaKhoa", tmp));
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
		///		After inserting into the datasource, the PMS.Entities.TrangThaiGiangVien object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>	
		public override void BulkInsert(TransactionManager transactionManager, TList<PMS.Entities.TrangThaiGiangVien> entities)
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
			bulkCopy.DestinationTableName = "TrangThaiGiangVien";
			
			DataTable dataTable = new DataTable();
			DataColumn col0 = dataTable.Columns.Add("MaKhoa", typeof(System.Int32));
			col0.AllowDBNull = false;		
			DataColumn col1 = dataTable.Columns.Add("MaGiangVien", typeof(System.String));
			col1.AllowDBNull = true;		
			DataColumn col2 = dataTable.Columns.Add("MaLopHocPhan", typeof(System.String));
			col2.AllowDBNull = true;		
			DataColumn col3 = dataTable.Columns.Add("IdChucNang", typeof(System.Int32));
			col3.AllowDBNull = true;		
			DataColumn col4 = dataTable.Columns.Add("NgayCapNhat", typeof(System.DateTime));
			col4.AllowDBNull = true;		
			DataColumn col5 = dataTable.Columns.Add("NguoiCapNhat", typeof(System.String));
			col5.AllowDBNull = true;		
			DataColumn col6 = dataTable.Columns.Add("TrangThai", typeof(System.Boolean));
			col6.AllowDBNull = true;		
			DataColumn col7 = dataTable.Columns.Add("NameFrom", typeof(System.String));
			col7.AllowDBNull = true;		
			DataColumn col8 = dataTable.Columns.Add("NamHoc", typeof(System.String));
			col8.AllowDBNull = true;		
			DataColumn col9 = dataTable.Columns.Add("HocKy", typeof(System.String));
			col9.AllowDBNull = true;		
			
			bulkCopy.ColumnMappings.Add("MaKhoa", "MaKhoa");
			bulkCopy.ColumnMappings.Add("MaGiangVien", "MaGiangVien");
			bulkCopy.ColumnMappings.Add("MaLopHocPhan", "MaLopHocPhan");
			bulkCopy.ColumnMappings.Add("IdChucNang", "IdChucNang");
			bulkCopy.ColumnMappings.Add("NgayCapNhat", "NgayCapNhat");
			bulkCopy.ColumnMappings.Add("NguoiCapNhat", "NguoiCapNhat");
			bulkCopy.ColumnMappings.Add("TrangThai", "TrangThai");
			bulkCopy.ColumnMappings.Add("NameFrom", "NameFrom");
			bulkCopy.ColumnMappings.Add("NamHoc", "NamHoc");
			bulkCopy.ColumnMappings.Add("HocKy", "HocKy");
			
			foreach(PMS.Entities.TrangThaiGiangVien entity in entities)
			{
				if (entity.EntityState != EntityState.Added)
					continue;
					
				DataRow row = dataTable.NewRow();
				
					row["MaKhoa"] = entity.MaKhoa;
							
				
					row["MaGiangVien"] = entity.MaGiangVien;
							
				
					row["MaLopHocPhan"] = entity.MaLopHocPhan;
							
				
					row["IdChucNang"] = entity.IdChucNang.HasValue ? (object) entity.IdChucNang  : System.DBNull.Value;
							
				
					row["NgayCapNhat"] = entity.NgayCapNhat.HasValue ? (object) entity.NgayCapNhat  : System.DBNull.Value;
							
				
					row["NguoiCapNhat"] = entity.NguoiCapNhat;
							
				
					row["TrangThai"] = entity.TrangThai.HasValue ? (object) entity.TrangThai  : System.DBNull.Value;
							
				
					row["NameFrom"] = entity.NameFrom;
							
				
					row["NamHoc"] = entity.NamHoc;
							
				
					row["HocKy"] = entity.HocKy;
							
				
				dataTable.Rows.Add(row);
			}		
			
			// send the data to the server		
			bulkCopy.WriteToServer(dataTable);		
			
			// update back the state
			foreach(PMS.Entities.TrangThaiGiangVien entity in entities)
			{
				if (entity.EntityState != EntityState.Added)
					continue;
			
				entity.AcceptChanges();
			}
		}
				
		/// <summary>
		/// 	Inserts a PMS.Entities.TrangThaiGiangVien object into the datasource using a transaction.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">PMS.Entities.TrangThaiGiangVien object to insert.</param>
		/// <remarks>
		///		After inserting into the datasource, the PMS.Entities.TrangThaiGiangVien object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>	
		/// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Insert(TransactionManager transactionManager, PMS.Entities.TrangThaiGiangVien entity)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_TrangThaiGiangVien_Insert", _useStoredProcedure);
			
			database.AddOutParameter(commandWrapper, "@MaKhoa", DbType.Int32, 4);
            database.AddInParameter(commandWrapper, "@MaGiangVien", DbType.AnsiString, entity.MaGiangVien );
            database.AddInParameter(commandWrapper, "@MaLopHocPhan", DbType.String, entity.MaLopHocPhan );
			database.AddInParameter(commandWrapper, "@IdChucNang", DbType.Int32, (entity.IdChucNang.HasValue ? (object) entity.IdChucNang  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@NgayCapNhat", DbType.DateTime, (entity.NgayCapNhat.HasValue ? (object) entity.NgayCapNhat  : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@NguoiCapNhat", DbType.String, entity.NguoiCapNhat );
			database.AddInParameter(commandWrapper, "@TrangThai", DbType.Boolean, (entity.TrangThai.HasValue ? (object) entity.TrangThai  : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@NameFrom", DbType.String, entity.NameFrom );
            database.AddInParameter(commandWrapper, "@NamHoc", DbType.String, entity.NamHoc );
            database.AddInParameter(commandWrapper, "@HocKy", DbType.String, entity.HocKy );
			
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
					
			object _maKhoa = database.GetParameterValue(commandWrapper, "@MaKhoa");
			entity.MaKhoa = (System.Int32)_maKhoa;
			
			
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
		/// <param name="entity">PMS.Entities.TrangThaiGiangVien object to update.</param>
		/// <remarks>
		///		After updating the datasource, the PMS.Entities.TrangThaiGiangVien object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>
		/// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Update(TransactionManager transactionManager, PMS.Entities.TrangThaiGiangVien entity)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_TrangThaiGiangVien_Update", _useStoredProcedure);
			
            database.AddInParameter(commandWrapper, "@MaKhoa", DbType.Int32, entity.MaKhoa );
            database.AddInParameter(commandWrapper, "@MaGiangVien", DbType.AnsiString, entity.MaGiangVien );
            database.AddInParameter(commandWrapper, "@MaLopHocPhan", DbType.String, entity.MaLopHocPhan );
			database.AddInParameter(commandWrapper, "@IdChucNang", DbType.Int32, (entity.IdChucNang.HasValue ? (object) entity.IdChucNang : System.DBNull.Value) );
			database.AddInParameter(commandWrapper, "@NgayCapNhat", DbType.DateTime, (entity.NgayCapNhat.HasValue ? (object) entity.NgayCapNhat : System.DBNull.Value) );
            database.AddInParameter(commandWrapper, "@NguoiCapNhat", DbType.String, entity.NguoiCapNhat );
			database.AddInParameter(commandWrapper, "@TrangThai", DbType.Boolean, (entity.TrangThai.HasValue ? (object) entity.TrangThai : System.DBNull.Value) );
            database.AddInParameter(commandWrapper, "@NameFrom", DbType.String, entity.NameFrom );
            database.AddInParameter(commandWrapper, "@NamHoc", DbType.String, entity.NamHoc );
            database.AddInParameter(commandWrapper, "@HocKy", DbType.String, entity.HocKy );
			
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
	

		#region cust_TrangThaiGiangVien_GetGiangVienNamHocHocKy
					
		/// <summary>
		///	This method wraps the 'cust_TrangThaiGiangVien_GetGiangVienNamHocHocKy' stored procedure. 
		/// </summary>	
		/// <param name="nameFrom"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="where"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object.</param>
		/// <remark>This method is generated from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;TrangThaiGiangVien&gt;"/> instance.</returns>
		public override TList<TrangThaiGiangVien> GetGiangVienNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String nameFrom, System.String namHoc, System.String hocKy, System.String where)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.cust_TrangThaiGiangVien_GetGiangVienNamHocHocKy", true);
			
			database.AddInParameter(commandWrapper, "@NameFrom", DbType.String,  nameFrom );
			database.AddInParameter(commandWrapper, "@NamHoc", DbType.String,  namHoc );
			database.AddInParameter(commandWrapper, "@HocKy", DbType.String,  hocKy );
			database.AddInParameter(commandWrapper, "@where", DbType.String,  where );
	
			
			IDataReader reader = null;
			
			//Create Collection
				TList<TrangThaiGiangVien> rows = new TList<TrangThaiGiangVien>();
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetGiangVienNamHocHocKy", rows));
	
				if (transactionManager != null)
				{	
					reader = Utility.ExecuteReader(transactionManager, commandWrapper);
				}
				else
				{
					reader = Utility.ExecuteReader(database, commandWrapper);
				}	
				
				try
				{    
					Fill(reader, rows, start, pageLength);
				}
				finally
				{
					if (reader != null) 
						reader.Close();
				}
				
				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetGiangVienNamHocHocKy", rows));


				return rows;
		}
		#endregion
		#endregion
	}//end class
} // end namespace