﻿
/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewThamDinhLuanVanThacSy.cs instead.
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
	/// An object representation of the 'View_ThamDinhLuanVanThacSy' View.
	///</summary>
	/// <remarks>
	/// IMPORTANT!!! You should not modify this partial  class, modify the ViewThamDinhLuanVanThacSy.cs file instead.
	/// All custom implementations should be done in the <see cref="ViewThamDinhLuanVanThacSy"/> class.
	/// </remarks>
	[DataObject]
	public partial class ViewThamDinhLuanVanThacSyServiceBase : ServiceViewBase<ViewThamDinhLuanVanThacSy>
	{

		#region Constructors
		///<summary>
		/// Creates a new <see cref="ViewThamDinhLuanVanThacSy"/> instance .
		///</summary>
		public ViewThamDinhLuanVanThacSyServiceBase() : base()
		{
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewThamDinhLuanVanThacSy"/> instance.
		///</summary>
		///<param name="_id"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_maGiangVien"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_ho"></param>
		///<param name="_ten"></param>
		///<param name="_hoTen"></param>
		///<param name="_soLuong"></param>
		///<param name="_donGia"></param>
		///<param name="_soTien"></param>
		///<param name="_ghiChu"></param>
		///<param name="_chot"></param>
		///<param name="_ngayCapNhat"></param>
		///<param name="_nguoiCapNhat"></param>
		public static ViewThamDinhLuanVanThacSy CreateViewThamDinhLuanVanThacSy(System.Int32 _id, System.String _namHoc, System.String _hocKy, System.Int32? _maGiangVien, System.String _maQuanLy, System.String _ho, System.String _ten, System.String _hoTen, System.Int32? _soLuong, System.Decimal? _donGia, System.Decimal? _soTien, System.String _ghiChu, System.Boolean? _chot, System.String _ngayCapNhat, System.String _nguoiCapNhat)
		{
			ViewThamDinhLuanVanThacSy newEntityViewThamDinhLuanVanThacSy = new ViewThamDinhLuanVanThacSy();
			newEntityViewThamDinhLuanVanThacSy.Id  = _id;
			newEntityViewThamDinhLuanVanThacSy.NamHoc  = _namHoc;
			newEntityViewThamDinhLuanVanThacSy.HocKy  = _hocKy;
			newEntityViewThamDinhLuanVanThacSy.MaGiangVien  = _maGiangVien;
			newEntityViewThamDinhLuanVanThacSy.MaQuanLy  = _maQuanLy;
			newEntityViewThamDinhLuanVanThacSy.Ho  = _ho;
			newEntityViewThamDinhLuanVanThacSy.Ten  = _ten;
			newEntityViewThamDinhLuanVanThacSy.HoTen  = _hoTen;
			newEntityViewThamDinhLuanVanThacSy.SoLuong  = _soLuong;
			newEntityViewThamDinhLuanVanThacSy.DonGia  = _donGia;
			newEntityViewThamDinhLuanVanThacSy.SoTien  = _soTien;
			newEntityViewThamDinhLuanVanThacSy.GhiChu  = _ghiChu;
			newEntityViewThamDinhLuanVanThacSy.Chot  = _chot;
			newEntityViewThamDinhLuanVanThacSy.NgayCapNhat  = _ngayCapNhat;
			newEntityViewThamDinhLuanVanThacSy.NguoiCapNhat  = _nguoiCapNhat;
			return newEntityViewThamDinhLuanVanThacSy;
		}
		#endregion Constructors

		#region Fields
		//private static SecurityContext<ViewThamDinhLuanVanThacSy> securityContext = new SecurityContext<ViewThamDinhLuanVanThacSy>();
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		private static readonly int defaultMaxRecords = 1000000;
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
		public override VList<ViewThamDinhLuanVanThacSy> Get(string whereClause, string orderBy)
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
		/// <returns>Returns a typed collection TList{ViewThamDinhLuanVanThacSy} of <c>ViewThamDinhLuanVanThacSy</c> objects.</returns>
		public override VList<ViewThamDinhLuanVanThacSy> Get(string whereClause, string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Get");
								
			// get this data
			VList<ViewThamDinhLuanVanThacSy> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewThamDinhLuanVanThacSyProvider.Get(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// Get a complete collection of <see cref="ViewThamDinhLuanVanThacSy" /> entities.
		/// </summary>
		/// <returns></returns>
		public virtual VList<ViewThamDinhLuanVanThacSy> GetAll() 
		{
			int totalCount = -1;
			return GetAll(0, defaultMaxRecords, out totalCount);
		}

       
		/// <summary>
		/// Get a set portion of a complete list of <see cref="ViewThamDinhLuanVanThacSy" /> entities
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">out parameter, number of total rows in given query.</param>
		/// <returns>a <see cref="TList{ViewThamDinhLuanVanThacSy}"/> </returns>
		public override VList<ViewThamDinhLuanVanThacSy> GetAll(int start, int pageLength, out int totalCount) 
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetAll");
			
			// get this data
			VList<ViewThamDinhLuanVanThacSy> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;					

				//Access repository
				list = dataProvider.ViewThamDinhLuanVanThacSyProvider.GetAll(transactionManager, start, pageLength, out totalCount);	
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
		/// Gets a page of <see cref="TList{ViewThamDinhLuanVanThacSy}" /> rows from the DataSource.
		/// </summary>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewThamDinhLuanVanThacSy</c> objects.</returns>
		public virtual VList<ViewThamDinhLuanVanThacSy> GetPaged(out int totalCount)
		{
			return GetPaged(null, null, 0, defaultMaxRecords, out totalCount);
		}
		
		/// <summary>
		/// Gets a page of <see cref="TList{ViewThamDinhLuanVanThacSy}" /> rows from the DataSource.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewThamDinhLuanVanThacSy</c> objects.</returns>
		public virtual VList<ViewThamDinhLuanVanThacSy> GetPaged(int start, int pageLength, out int totalCount)
		{
			return GetPaged(null, null, start, pageLength, out totalCount);
		}

		/// <summary>
		/// Gets a page of entity rows with a <see cref="TList{ViewThamDinhLuanVanThacSy}" /> from the DataSource with a where clause and order by clause.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC).</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewThamDinhLuanVanThacSy</c> objects.</returns>
		public override VList<ViewThamDinhLuanVanThacSy> GetPaged(string whereClause,string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetPaged");
			
			// get this data
			VList<ViewThamDinhLuanVanThacSy> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewThamDinhLuanVanThacSyProvider.GetPaged(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// <returns>Returns a typed collection of <c>ViewThamDinhLuanVanThacSy</c> objects.</returns>
		public virtual VList<ViewThamDinhLuanVanThacSy> Find(IFilterParameterCollection parameters)
		{
			return Find(parameters, null);
		}
		
		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <returns>Returns a typed collection of <c>ViewThamDinhLuanVanThacSy</c> objects.</returns>
		public virtual VList<ViewThamDinhLuanVanThacSy> Find(IFilterParameterCollection parameters, string orderBy)
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
		/// <returns>Returns a typed collection of <c>ViewThamDinhLuanVanThacSy</c> objects.</returns>
		public override VList<ViewThamDinhLuanVanThacSy> Find(IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Find");
								
			// get this data
			TransactionManager transactionManager = null; 
			VList<ViewThamDinhLuanVanThacSy> list = null;
			count = -1;
			
			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewThamDinhLuanVanThacSyProvider.Find(transactionManager, parameters, orderBy, start, pageLength, out count);
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
		
		#region cust_View_ThamDinhLuanVanThacSy_GetByNamHocHocKy
		/// <summary>
		///	This method wrap the 'cust_View_ThamDinhLuanVanThacSy_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewThamDinhLuanVanThacSy}"/> instance.</returns>
		public virtual VList<ViewThamDinhLuanVanThacSy> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy( namHoc, hocKy, 0, defaultMaxRecords );
		}
	
		/// <summary>
		///	This method wrap the 'cust_View_ThamDinhLuanVanThacSy_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewThamDinhLuanVanThacSy}"/> instance.</returns>
		public virtual VList<ViewThamDinhLuanVanThacSy> GetByNamHocHocKy(System.String namHoc, System.String hocKy, int start, int pageLength)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetByNamHocHocKy");
			
		
			VList<ViewThamDinhLuanVanThacSy> result = null; 
			TransactionManager transactionManager = null; 
			
			try
            {
				bool isBorrowedTransaction = ConnectionScope.Current.HasTransaction;				
				
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
                
				//Call Custom Procedure from Repository
				result = dataProvider.ViewThamDinhLuanVanThacSyProvider.GetByNamHocHocKy(transactionManager, start, pageLength , namHoc, hocKy);
	        
            	
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
			
			return result;
		}
		#endregion 
		#endregion
		
		#endregion Data Access Methods
		
	
	}//End Class
} // end namespace



