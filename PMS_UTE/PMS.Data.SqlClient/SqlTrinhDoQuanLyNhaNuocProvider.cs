﻿#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.ComponentModel;

using PMS.Entities;
using PMS.Data;

#endregion

namespace PMS.Data.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="TrinhDoQuanLyNhaNuoc"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlTrinhDoQuanLyNhaNuocProvider: SqlTrinhDoQuanLyNhaNuocProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlTrinhDoQuanLyNhaNuocProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlTrinhDoQuanLyNhaNuocProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
	}
}