﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'ReportManagerments' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IReportManagerments 
	{
		/// <summary>			
		/// Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ReportManagerments"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// ReportName : 
		/// </summary>
		System.String  ReportName  { get; set; }
		
		/// <summary>
		/// Storeprocedure : 
		/// </summary>
		System.String  Storeprocedure  { get; set; }
		
		/// <summary>
		/// FileName : 
		/// </summary>
		System.String  FileName  { get; set; }
		
		/// <summary>
		/// Note1 : 
		/// </summary>
		System.String  Note1  { get; set; }
		
		/// <summary>
		/// Note2 : 
		/// </summary>
		System.String  Note2  { get; set; }
		
		/// <summary>
		/// Note3 : 
		/// </summary>
		System.String  Note3  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

