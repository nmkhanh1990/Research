﻿
/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewGiamTruGioChuan.cs instead.
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
	/// An object representation of the 'View_GiamTruGioChuan' View.
	///</summary>
	/// <remarks>
	/// IMPORTANT!!! You should not modify this partial  class, modify the ViewGiamTruGioChuan.cs file instead.
	/// All custom implementations should be done in the <see cref="ViewGiamTruGioChuan"/> class.
	/// </remarks>
	[DataObject]
	public partial class ViewGiamTruGioChuanServiceBase : ServiceViewBase<ViewGiamTruGioChuan>
	{

		#region Constructors
		///<summary>
		/// Creates a new <see cref="ViewGiamTruGioChuan"/> instance .
		///</summary>
		public ViewGiamTruGioChuanServiceBase() : base()
		{
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewGiamTruGioChuan"/> instance.
		///</summary>
		///<param name="_maGiangVien"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_ho"></param>
		///<param name="_ten"></param>
		///<param name="_hoTen"></param>
		///<param name="_tenHocHam"></param>
		///<param name="_tenHocVi"></param>
		///<param name="_tenLoaiGiangVien"></param>
		///<param name="_maDonVi"></param>
		///<param name="_tenDonVi"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_gioGiamChatLuongCao"></param>
		///<param name="_gioGiamSauDaiHoc"></param>
		///<param name="_gioGiamNckh"></param>
		///<param name="_ghiChu"></param>
		///<param name="_ngayCapNhat"></param>
		///<param name="_nguoiCapNhat"></param>
		public static ViewGiamTruGioChuan CreateViewGiamTruGioChuan(System.Int32? _maGiangVien, System.String _maQuanLy, System.String _ho, System.String _ten, System.String _hoTen, System.String _tenHocHam, System.String _tenHocVi, System.String _tenLoaiGiangVien, System.String _maDonVi, System.String _tenDonVi, System.String _namHoc, System.String _hocKy, System.Decimal? _gioGiamChatLuongCao, System.Decimal? _gioGiamSauDaiHoc, System.Decimal? _gioGiamNckh, System.String _ghiChu, System.DateTime? _ngayCapNhat, System.String _nguoiCapNhat)
		{
			ViewGiamTruGioChuan newEntityViewGiamTruGioChuan = new ViewGiamTruGioChuan();
			newEntityViewGiamTruGioChuan.MaGiangVien  = _maGiangVien;
			newEntityViewGiamTruGioChuan.MaQuanLy  = _maQuanLy;
			newEntityViewGiamTruGioChuan.Ho  = _ho;
			newEntityViewGiamTruGioChuan.Ten  = _ten;
			newEntityViewGiamTruGioChuan.HoTen  = _hoTen;
			newEntityViewGiamTruGioChuan.TenHocHam  = _tenHocHam;
			newEntityViewGiamTruGioChuan.TenHocVi  = _tenHocVi;
			newEntityViewGiamTruGioChuan.TenLoaiGiangVien  = _tenLoaiGiangVien;
			newEntityViewGiamTruGioChuan.MaDonVi  = _maDonVi;
			newEntityViewGiamTruGioChuan.TenDonVi  = _tenDonVi;
			newEntityViewGiamTruGioChuan.NamHoc  = _namHoc;
			newEntityViewGiamTruGioChuan.HocKy  = _hocKy;
			newEntityViewGiamTruGioChuan.GioGiamChatLuongCao  = _gioGiamChatLuongCao;
			newEntityViewGiamTruGioChuan.GioGiamSauDaiHoc  = _gioGiamSauDaiHoc;
			newEntityViewGiamTruGioChuan.GioGiamNckh  = _gioGiamNckh;
			newEntityViewGiamTruGioChuan.GhiChu  = _ghiChu;
			newEntityViewGiamTruGioChuan.NgayCapNhat  = _ngayCapNhat;
			newEntityViewGiamTruGioChuan.NguoiCapNhat  = _nguoiCapNhat;
			return newEntityViewGiamTruGioChuan;
		}
		#endregion Constructors

		#region Fields
		//private static SecurityContext<ViewGiamTruGioChuan> securityContext = new SecurityContext<ViewGiamTruGioChuan>();
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
		public override VList<ViewGiamTruGioChuan> Get(string whereClause, string orderBy)
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
		/// <returns>Returns a typed collection TList{ViewGiamTruGioChuan} of <c>ViewGiamTruGioChuan</c> objects.</returns>
		public override VList<ViewGiamTruGioChuan> Get(string whereClause, string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Get");
								
			// get this data
			VList<ViewGiamTruGioChuan> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewGiamTruGioChuanProvider.Get(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// Get a complete collection of <see cref="ViewGiamTruGioChuan" /> entities.
		/// </summary>
		/// <returns></returns>
		public virtual VList<ViewGiamTruGioChuan> GetAll() 
		{
			int totalCount = -1;
			return GetAll(0, defaultMaxRecords, out totalCount);
		}

       
		/// <summary>
		/// Get a set portion of a complete list of <see cref="ViewGiamTruGioChuan" /> entities
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">out parameter, number of total rows in given query.</param>
		/// <returns>a <see cref="TList{ViewGiamTruGioChuan}"/> </returns>
		public override VList<ViewGiamTruGioChuan> GetAll(int start, int pageLength, out int totalCount) 
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetAll");
			
			// get this data
			VList<ViewGiamTruGioChuan> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;					

				//Access repository
				list = dataProvider.ViewGiamTruGioChuanProvider.GetAll(transactionManager, start, pageLength, out totalCount);	
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
		/// Gets a page of <see cref="TList{ViewGiamTruGioChuan}" /> rows from the DataSource.
		/// </summary>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewGiamTruGioChuan</c> objects.</returns>
		public virtual VList<ViewGiamTruGioChuan> GetPaged(out int totalCount)
		{
			return GetPaged(null, null, 0, defaultMaxRecords, out totalCount);
		}
		
		/// <summary>
		/// Gets a page of <see cref="TList{ViewGiamTruGioChuan}" /> rows from the DataSource.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewGiamTruGioChuan</c> objects.</returns>
		public virtual VList<ViewGiamTruGioChuan> GetPaged(int start, int pageLength, out int totalCount)
		{
			return GetPaged(null, null, start, pageLength, out totalCount);
		}

		/// <summary>
		/// Gets a page of entity rows with a <see cref="TList{ViewGiamTruGioChuan}" /> from the DataSource with a where clause and order by clause.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC).</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewGiamTruGioChuan</c> objects.</returns>
		public override VList<ViewGiamTruGioChuan> GetPaged(string whereClause,string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetPaged");
			
			// get this data
			VList<ViewGiamTruGioChuan> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewGiamTruGioChuanProvider.GetPaged(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// <returns>Returns a typed collection of <c>ViewGiamTruGioChuan</c> objects.</returns>
		public virtual VList<ViewGiamTruGioChuan> Find(IFilterParameterCollection parameters)
		{
			return Find(parameters, null);
		}
		
		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <returns>Returns a typed collection of <c>ViewGiamTruGioChuan</c> objects.</returns>
		public virtual VList<ViewGiamTruGioChuan> Find(IFilterParameterCollection parameters, string orderBy)
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
		/// <returns>Returns a typed collection of <c>ViewGiamTruGioChuan</c> objects.</returns>
		public override VList<ViewGiamTruGioChuan> Find(IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Find");
								
			// get this data
			TransactionManager transactionManager = null; 
			VList<ViewGiamTruGioChuan> list = null;
			count = -1;
			
			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewGiamTruGioChuanProvider.Find(transactionManager, parameters, orderBy, start, pageLength, out count);
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
		
		#region cust_View_GiamTruGioChuan_GetByNamHocHocKy
		/// <summary>
		///	This method wrap the 'cust_View_GiamTruGioChuan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewGiamTruGioChuan}"/> instance.</returns>
		public virtual VList<ViewGiamTruGioChuan> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy( namHoc, hocKy, 0, defaultMaxRecords );
		}
	
		/// <summary>
		///	This method wrap the 'cust_View_GiamTruGioChuan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewGiamTruGioChuan}"/> instance.</returns>
		public virtual VList<ViewGiamTruGioChuan> GetByNamHocHocKy(System.String namHoc, System.String hocKy, int start, int pageLength)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetByNamHocHocKy");
			
		
			VList<ViewGiamTruGioChuan> result = null; 
			TransactionManager transactionManager = null; 
			
			try
            {
				bool isBorrowedTransaction = ConnectionScope.Current.HasTransaction;				
				
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
                
				//Call Custom Procedure from Repository
				result = dataProvider.ViewGiamTruGioChuanProvider.GetByNamHocHocKy(transactionManager, start, pageLength , namHoc, hocKy);
	        
            	
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
		
		#region cust_View_GiamTruGioChuan_GetByNamHoc
		/// <summary>
		///	This method wrap the 'cust_View_GiamTruGioChuan_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewGiamTruGioChuan}"/> instance.</returns>
		public virtual VList<ViewGiamTruGioChuan> GetByNamHoc(System.String namHoc)
		{
			return GetByNamHoc( namHoc, 0, defaultMaxRecords );
		}
	
		/// <summary>
		///	This method wrap the 'cust_View_GiamTruGioChuan_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewGiamTruGioChuan}"/> instance.</returns>
		public virtual VList<ViewGiamTruGioChuan> GetByNamHoc(System.String namHoc, int start, int pageLength)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetByNamHoc");
			
		
			VList<ViewGiamTruGioChuan> result = null; 
			TransactionManager transactionManager = null; 
			
			try
            {
				bool isBorrowedTransaction = ConnectionScope.Current.HasTransaction;				
				
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
                
				//Call Custom Procedure from Repository
				result = dataProvider.ViewGiamTruGioChuanProvider.GetByNamHoc(transactionManager, start, pageLength , namHoc);
	        
            	
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
		
		#region cust_View_GiamTruGioChuan_Luu
		/// <summary>
		///	This method wrap the 'cust_View_GiamTruGioChuan_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public virtual void Luu(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu( xmlData, namHoc, hocKy, ref reVal, 0, defaultMaxRecords );
		}
	
		/// <summary>
		///	This method wrap the 'cust_View_GiamTruGioChuan_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public virtual void Luu(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal, int start, int pageLength)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Luu");
			
		
			 
			TransactionManager transactionManager = null; 
			
			try
            {
				bool isBorrowedTransaction = ConnectionScope.Current.HasTransaction;				
				
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction();
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
                
				//Call Custom Procedure from Repository
				dataProvider.ViewGiamTruGioChuanProvider.Luu(transactionManager, start, pageLength , xmlData, namHoc, hocKy, ref reVal);
	        
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
		
		#region cust_View_GiamTruGioChuan_GetByNamHocHocKyKhoaDonVi
		/// <summary>
		///	This method wrap the 'cust_View_GiamTruGioChuan_GetByNamHocHocKyKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewGiamTruGioChuan}"/> instance.</returns>
		public virtual VList<ViewGiamTruGioChuan> GetByNamHocHocKyKhoaDonVi(System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetByNamHocHocKyKhoaDonVi( namHoc, hocKy, maDonVi, 0, defaultMaxRecords );
		}
	
		/// <summary>
		///	This method wrap the 'cust_View_GiamTruGioChuan_GetByNamHocHocKyKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewGiamTruGioChuan}"/> instance.</returns>
		public virtual VList<ViewGiamTruGioChuan> GetByNamHocHocKyKhoaDonVi(System.String namHoc, System.String hocKy, System.String maDonVi, int start, int pageLength)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetByNamHocHocKyKhoaDonVi");
			
		
			VList<ViewGiamTruGioChuan> result = null; 
			TransactionManager transactionManager = null; 
			
			try
            {
				bool isBorrowedTransaction = ConnectionScope.Current.HasTransaction;				
				
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
                
				//Call Custom Procedure from Repository
				result = dataProvider.ViewGiamTruGioChuanProvider.GetByNamHocHocKyKhoaDonVi(transactionManager, start, pageLength , namHoc, hocKy, maDonVi);
	        
            	
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



