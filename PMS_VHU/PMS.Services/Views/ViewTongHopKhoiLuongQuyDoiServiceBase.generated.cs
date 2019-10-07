﻿
/*
	File generated by NetTiers templates [www.NetTiers.com]
	Generated on : Friday, December 10, 2010
	Important: Do not modify this file. Edit the file ViewTongHopKhoiLuongQuyDoi.cs instead.
*/

#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Security;
using System.Data;

using PMS.Entities;
using PMS.Entities.Validation;
using Entities = PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;


using Microsoft.Practices.EnterpriseLibrary.Logging;

#endregion 

namespace PMS.Services
{		
	
	///<summary>
	/// An object representation of the 'View_TongHop_KhoiLuong_QuyDoi' View.
	///</summary>
	/// <remarks>
	/// IMPORTANT!!! You should not modify this partial  class, modify the ViewTongHopKhoiLuongQuyDoi.cs file instead.
	/// All custom implementations should be done in the <see cref="ViewTongHopKhoiLuongQuyDoi"/> class.
	/// </remarks>
	[DataObject]
	public partial class ViewTongHopKhoiLuongQuyDoiServiceBase : ServiceViewBase<ViewTongHopKhoiLuongQuyDoi>
	{

		#region Constructors
		///<summary>
		/// Creates a new <see cref="ViewTongHopKhoiLuongQuyDoi"/> instance .
		///</summary>
		public ViewTongHopKhoiLuongQuyDoiServiceBase() : base()
		{
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewTongHopKhoiLuongQuyDoi"/> instance.
		///</summary>
		///<param name="_maDonVi"></param>
		///<param name="_tenDonVi"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_tietQuyDoi1"></param>
		///<param name="_tietDoAn1"></param>
		///<param name="_tietQuyDoi2"></param>
		///<param name="_tietDoAn2"></param>
		public static ViewTongHopKhoiLuongQuyDoi CreateViewTongHopKhoiLuongQuyDoi(System.String _maDonVi, System.String _tenDonVi, System.String _namHoc, System.String _hocKy, System.Decimal? _tietQuyDoi1, System.Decimal? _tietDoAn1, System.Decimal? _tietQuyDoi2, System.Decimal? _tietDoAn2)
		{
			ViewTongHopKhoiLuongQuyDoi newEntityViewTongHopKhoiLuongQuyDoi = new ViewTongHopKhoiLuongQuyDoi();
			newEntityViewTongHopKhoiLuongQuyDoi.MaDonVi  = _maDonVi;
			newEntityViewTongHopKhoiLuongQuyDoi.TenDonVi  = _tenDonVi;
			newEntityViewTongHopKhoiLuongQuyDoi.NamHoc  = _namHoc;
			newEntityViewTongHopKhoiLuongQuyDoi.HocKy  = _hocKy;
			newEntityViewTongHopKhoiLuongQuyDoi.TietQuyDoi1  = _tietQuyDoi1;
			newEntityViewTongHopKhoiLuongQuyDoi.TietDoAn1  = _tietDoAn1;
			newEntityViewTongHopKhoiLuongQuyDoi.TietQuyDoi2  = _tietQuyDoi2;
			newEntityViewTongHopKhoiLuongQuyDoi.TietDoAn2  = _tietDoAn2;
			return newEntityViewTongHopKhoiLuongQuyDoi;
		}
		#endregion Constructors

		#region Fields
		//private static SecurityContext<ViewTongHopKhoiLuongQuyDoi> securityContext = new SecurityContext<ViewTongHopKhoiLuongQuyDoi>();
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		private static readonly int defaultMaxRecords = 10000;
		#endregion 
		
		#region Data Access Methods
			
		#region Get 
		/// <summary>
		/// Attempts to do a parameterized version of a simple whereclause. 
		/// Returns rows meeting the whereClause condition from the DataSource.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
        /// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <remarks>Does NOT Support Advanced Operations such as SubSelects.  See GetPaged for that functionality.</remarks>
		/// <returns>Returns a typed collection of Entity objects.</returns>
		public override VList<ViewTongHopKhoiLuongQuyDoi> Get(string whereClause, string orderBy)
		{
			int totalCount = -1;
			return Get(whereClause, orderBy, 0, defaultMaxRecords, out totalCount);
		}

		/// <summary>
		/// Returns rows meeting the whereClause condition from the DataSource.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
        /// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">out parameter to get total records for query</param>
		/// <remarks>Does NOT Support Advanced Operations such as SubSelects.  See GetPaged for that functionality.</remarks>
		/// <returns>Returns a typed collection TList{ViewTongHopKhoiLuongQuyDoi} of <c>ViewTongHopKhoiLuongQuyDoi</c> objects.</returns>
		public override VList<ViewTongHopKhoiLuongQuyDoi> Get(string whereClause, string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Get");
								
			// get this data
			VList<ViewTongHopKhoiLuongQuyDoi> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewTongHopKhoiLuongQuyDoiProvider.Get(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
				//if borrowed tran, leave open for next call
			}
            catch (Exception exc)
            {
				//if open, rollback, it's possible this is part of a larger commit
                if (transactionManager != null && transactionManager.IsOpen) 
					transactionManager.Rollback();
				
				//Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy)) 
					throw;
			}
			return list;
		}
		
		#endregion Get Methods
		
		#region GetAll
		/// <summary>
		/// Get a complete collection of <see cref="ViewTongHopKhoiLuongQuyDoi" /> entities.
		/// </summary>
		/// <returns></returns>
		public virtual VList<ViewTongHopKhoiLuongQuyDoi> GetAll() 
		{
			int totalCount = -1;
			return GetAll(0, defaultMaxRecords, out totalCount);
		}

       
		/// <summary>
		/// Get a set portion of a complete list of <see cref="ViewTongHopKhoiLuongQuyDoi" /> entities
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">out parameter, number of total rows in given query.</param>
		/// <returns>a <see cref="TList{ViewTongHopKhoiLuongQuyDoi}"/> </returns>
		public override VList<ViewTongHopKhoiLuongQuyDoi> GetAll(int start, int pageLength, out int totalCount) 
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetAll");
			
			// get this data
			VList<ViewTongHopKhoiLuongQuyDoi> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;					

				//Access repository
				list = dataProvider.ViewTongHopKhoiLuongQuyDoiProvider.GetAll(transactionManager, start, pageLength, out totalCount);	
			}
            catch (Exception exc)
            {
				//if open, rollback, it's possible this is part of a larger commit
                if (transactionManager != null && transactionManager.IsOpen) 
					transactionManager.Rollback();
				
				//Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy)) 
					throw;
			}
			return list;
		}
		#endregion GetAll

		#region GetPaged
		/// <summary>
		/// Gets a page of <see cref="TList{ViewTongHopKhoiLuongQuyDoi}" /> rows from the DataSource.
		/// </summary>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewTongHopKhoiLuongQuyDoi</c> objects.</returns>
		public virtual VList<ViewTongHopKhoiLuongQuyDoi> GetPaged(out int totalCount)
		{
			return GetPaged(null, null, 0, defaultMaxRecords, out totalCount);
		}
		
		/// <summary>
		/// Gets a page of <see cref="TList{ViewTongHopKhoiLuongQuyDoi}" /> rows from the DataSource.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewTongHopKhoiLuongQuyDoi</c> objects.</returns>
		public virtual VList<ViewTongHopKhoiLuongQuyDoi> GetPaged(int start, int pageLength, out int totalCount)
		{
			return GetPaged(null, null, start, pageLength, out totalCount);
		}

		/// <summary>
		/// Gets a page of entity rows with a <see cref="TList{ViewTongHopKhoiLuongQuyDoi}" /> from the DataSource with a where clause and order by clause.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC).</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewTongHopKhoiLuongQuyDoi</c> objects.</returns>
		public override VList<ViewTongHopKhoiLuongQuyDoi> GetPaged(string whereClause,string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetPaged");
			
			// get this data
			VList<ViewTongHopKhoiLuongQuyDoi> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewTongHopKhoiLuongQuyDoiProvider.GetPaged(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
				//if borrowed tran, leave open for next call
			}
            catch (Exception exc)
            {
				//if open, rollback, it's possible this is part of a larger commit
                if (transactionManager != null && transactionManager.IsOpen) 
					transactionManager.Rollback();
				
				//Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy)) 
					throw;
			}
			return list;			
		}
		
		/// <summary>
		/// Gets the number of rows in the DataSource that match the specified whereClause.
		/// This method is only provided as a workaround for the ObjectDataSource's need to 
		/// execute another method to discover the total count instead of using another param, like our out param.  
		/// This method should be avoided if using the ObjectDataSource or another method.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="totalCount">Number of rows in the DataSource.</param>
		/// <returns>Returns the number of rows.</returns>
		public int GetTotalItems(string whereClause, out int totalCount)
		{
			GetPaged(whereClause, null, 0, defaultMaxRecords, out totalCount);
			return totalCount;
		}
		#endregion GetPaged	

		#region Find Methods

		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <returns>Returns a typed collection of <c>ViewTongHopKhoiLuongQuyDoi</c> objects.</returns>
		public virtual VList<ViewTongHopKhoiLuongQuyDoi> Find(IFilterParameterCollection parameters)
		{
			return Find(parameters, null);
		}
		
		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <returns>Returns a typed collection of <c>ViewTongHopKhoiLuongQuyDoi</c> objects.</returns>
		public virtual VList<ViewTongHopKhoiLuongQuyDoi> Find(IFilterParameterCollection parameters, string orderBy)
		{
			int count = 0;
			return Find(parameters, orderBy, 0, defaultMaxRecords, out count);
		}
		
		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out. The number of rows that match this query.</param>
		/// <returns>Returns a typed collection of <c>ViewTongHopKhoiLuongQuyDoi</c> objects.</returns>
		public override VList<ViewTongHopKhoiLuongQuyDoi> Find(IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Find");
								
			// get this data
			TransactionManager transactionManager = null; 
			VList<ViewTongHopKhoiLuongQuyDoi> list = null;
			count = -1;
			
			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewTongHopKhoiLuongQuyDoiProvider.Find(transactionManager, parameters, orderBy, start, pageLength, out count);
			}
            catch (Exception exc)
            {
				//if open, rollback, it's possible this is part of a larger commit
                if (transactionManager != null && transactionManager.IsOpen) 
					transactionManager.Rollback();
				
				//Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy)) 
					throw;
			}
			
			return list;
		}
		
		#endregion Find Methods
		
		#region Custom Methods
		
		#region cust_View_TongHop_KhoiLuong_QuyDoi_GetByNamHocHocKy
		/// <summary>
		///	This method wrap the 'cust_View_TongHop_KhoiLuong_QuyDoi_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public virtual void GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			 GetByNamHocHocKy( namHoc, hocKy, 0, defaultMaxRecords );
		}
	
		/// <summary>
		///	This method wrap the 'cust_View_TongHop_KhoiLuong_QuyDoi_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public virtual void GetByNamHocHocKy(System.String namHoc, System.String hocKy, int start, int pageLength)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetByNamHocHocKy");
			
		
			 
			TransactionManager transactionManager = null; 
			
			try
            {
				bool isBorrowedTransaction = ConnectionScope.Current.HasTransaction;				
				
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction();
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
                
				//Call Custom Procedure from Repository
				dataProvider.ViewTongHopKhoiLuongQuyDoiProvider.GetByNamHocHocKy(transactionManager, start, pageLength , namHoc, hocKy);
	        
				//If success, Commit
				if(!isBorrowedTransaction && transactionManager != null && transactionManager.IsOpen)
					transactionManager.Commit();
            	
			}
            catch (Exception exc)
            {
				//if open, rollback
                if (transactionManager != null && transactionManager.IsOpen)
                        transactionManager.Rollback();
                    
				//Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy)) 
					throw;
            }
			
			return ;
		}
		#endregion 
		#endregion
		
		#endregion Data Access Methods
		
	
	}//End Class
} // end namespace



