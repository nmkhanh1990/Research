﻿
/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewLopHocPhan.cs instead.
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
	/// An object representation of the 'View_LopHocPhan' View.
	///</summary>
	/// <remarks>
	/// IMPORTANT!!! You should not modify this partial  class, modify the ViewLopHocPhan.cs file instead.
	/// All custom implementations should be done in the <see cref="ViewLopHocPhan"/> class.
	/// </remarks>
	[DataObject]
	public partial class ViewLopHocPhanServiceBase : ServiceViewBase<ViewLopHocPhan>
	{

		#region Constructors
		///<summary>
		/// Creates a new <see cref="ViewLopHocPhan"/> instance .
		///</summary>
		public ViewLopHocPhanServiceBase() : base()
		{
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewLopHocPhan"/> instance.
		///</summary>
		///<param name="_maLopHocPhan"></param>
		///<param name="_tenLopHocPhan"></param>
		///<param name="_maMonHoc"></param>
		///<param name="_tenMonHoc"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_maLop"></param>
		///<param name="_siSo"></param>
		///<param name="_maLoaiHocPhan"></param>
		///<param name="_nhom"></param>
		///<param name="_soTinChi"></param>
		///<param name="_tenLop"></param>
		///<param name="_tenLoaiHocPhan"></param>
		///<param name="_maKhoa"></param>
		///<param name="_tenKhoa"></param>
		public static ViewLopHocPhan CreateViewLopHocPhan(System.String _maLopHocPhan, System.String _tenLopHocPhan, System.String _maMonHoc, System.String _tenMonHoc, System.String _namHoc, System.String _hocKy, System.String _maLop, System.Int32? _siSo, System.Byte _maLoaiHocPhan, System.String _nhom, System.Decimal _soTinChi, System.String _tenLop, System.String _tenLoaiHocPhan, System.String _maKhoa, System.String _tenKhoa)
		{
			ViewLopHocPhan newEntityViewLopHocPhan = new ViewLopHocPhan();
			newEntityViewLopHocPhan.MaLopHocPhan  = _maLopHocPhan;
			newEntityViewLopHocPhan.TenLopHocPhan  = _tenLopHocPhan;
			newEntityViewLopHocPhan.MaMonHoc  = _maMonHoc;
			newEntityViewLopHocPhan.TenMonHoc  = _tenMonHoc;
			newEntityViewLopHocPhan.NamHoc  = _namHoc;
			newEntityViewLopHocPhan.HocKy  = _hocKy;
			newEntityViewLopHocPhan.MaLop  = _maLop;
			newEntityViewLopHocPhan.SiSo  = _siSo;
			newEntityViewLopHocPhan.MaLoaiHocPhan  = _maLoaiHocPhan;
			newEntityViewLopHocPhan.Nhom  = _nhom;
			newEntityViewLopHocPhan.SoTinChi  = _soTinChi;
			newEntityViewLopHocPhan.TenLop  = _tenLop;
			newEntityViewLopHocPhan.TenLoaiHocPhan  = _tenLoaiHocPhan;
			newEntityViewLopHocPhan.MaKhoa  = _maKhoa;
			newEntityViewLopHocPhan.TenKhoa  = _tenKhoa;
			return newEntityViewLopHocPhan;
		}
		#endregion Constructors

		#region Fields
		//private static SecurityContext<ViewLopHocPhan> securityContext = new SecurityContext<ViewLopHocPhan>();
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
		public override VList<ViewLopHocPhan> Get(string whereClause, string orderBy)
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
		/// <returns>Returns a typed collection TList{ViewLopHocPhan} of <c>ViewLopHocPhan</c> objects.</returns>
		public override VList<ViewLopHocPhan> Get(string whereClause, string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Get");
								
			// get this data
			VList<ViewLopHocPhan> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewLopHocPhanProvider.Get(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// Get a complete collection of <see cref="ViewLopHocPhan" /> entities.
		/// </summary>
		/// <returns></returns>
		public virtual VList<ViewLopHocPhan> GetAll() 
		{
			int totalCount = -1;
			return GetAll(0, defaultMaxRecords, out totalCount);
		}

       
		/// <summary>
		/// Get a set portion of a complete list of <see cref="ViewLopHocPhan" /> entities
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">out parameter, number of total rows in given query.</param>
		/// <returns>a <see cref="TList{ViewLopHocPhan}"/> </returns>
		public override VList<ViewLopHocPhan> GetAll(int start, int pageLength, out int totalCount) 
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetAll");
			
			// get this data
			VList<ViewLopHocPhan> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;					

				//Access repository
				list = dataProvider.ViewLopHocPhanProvider.GetAll(transactionManager, start, pageLength, out totalCount);	
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
		/// Gets a page of <see cref="TList{ViewLopHocPhan}" /> rows from the DataSource.
		/// </summary>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewLopHocPhan</c> objects.</returns>
		public virtual VList<ViewLopHocPhan> GetPaged(out int totalCount)
		{
			return GetPaged(null, null, 0, defaultMaxRecords, out totalCount);
		}
		
		/// <summary>
		/// Gets a page of <see cref="TList{ViewLopHocPhan}" /> rows from the DataSource.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewLopHocPhan</c> objects.</returns>
		public virtual VList<ViewLopHocPhan> GetPaged(int start, int pageLength, out int totalCount)
		{
			return GetPaged(null, null, start, pageLength, out totalCount);
		}

		/// <summary>
		/// Gets a page of entity rows with a <see cref="TList{ViewLopHocPhan}" /> from the DataSource with a where clause and order by clause.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC).</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewLopHocPhan</c> objects.</returns>
		public override VList<ViewLopHocPhan> GetPaged(string whereClause,string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetPaged");
			
			// get this data
			VList<ViewLopHocPhan> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewLopHocPhanProvider.GetPaged(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// <returns>Returns a typed collection of <c>ViewLopHocPhan</c> objects.</returns>
		public virtual VList<ViewLopHocPhan> Find(IFilterParameterCollection parameters)
		{
			return Find(parameters, null);
		}
		
		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <returns>Returns a typed collection of <c>ViewLopHocPhan</c> objects.</returns>
		public virtual VList<ViewLopHocPhan> Find(IFilterParameterCollection parameters, string orderBy)
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
		/// <returns>Returns a typed collection of <c>ViewLopHocPhan</c> objects.</returns>
		public override VList<ViewLopHocPhan> Find(IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Find");
								
			// get this data
			TransactionManager transactionManager = null; 
			VList<ViewLopHocPhan> list = null;
			count = -1;
			
			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewLopHocPhanProvider.Find(transactionManager, parameters, orderBy, start, pageLength, out count);
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
		
		#region cust_View_LopHocPhan_Clc_Auf_Cjl_GetByNamHocHocKy
		/// <summary>
		///	This method wrap the 'cust_View_LopHocPhan_Clc_Auf_Cjl_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public virtual IDataReader Clc_Auf_Cjl_GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return Clc_Auf_Cjl_GetByNamHocHocKy( namHoc, hocKy, 0, defaultMaxRecords );
		}
	
		/// <summary>
		///	This method wrap the 'cust_View_LopHocPhan_Clc_Auf_Cjl_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public virtual IDataReader Clc_Auf_Cjl_GetByNamHocHocKy(System.String namHoc, System.String hocKy, int start, int pageLength)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Clc_Auf_Cjl_GetByNamHocHocKy");
			
		
			IDataReader result = null; 
			TransactionManager transactionManager = null; 
			
			try
            {
				bool isBorrowedTransaction = ConnectionScope.Current.HasTransaction;				
				
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
                
				//Call Custom Procedure from Repository
				result = dataProvider.ViewLopHocPhanProvider.Clc_Auf_Cjl_GetByNamHocHocKy(transactionManager, start, pageLength , namHoc, hocKy);
	        
            	
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
		
		#region cust_View_LopHocPhan_GetByNamHocHocKy
		/// <summary>
		///	This method wrap the 'cust_View_LopHocPhan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewLopHocPhan}"/> instance.</returns>
		public virtual VList<ViewLopHocPhan> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy( namHoc, hocKy, 0, defaultMaxRecords );
		}
	
		/// <summary>
		///	This method wrap the 'cust_View_LopHocPhan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewLopHocPhan}"/> instance.</returns>
		public virtual VList<ViewLopHocPhan> GetByNamHocHocKy(System.String namHoc, System.String hocKy, int start, int pageLength)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetByNamHocHocKy");
			
		
			VList<ViewLopHocPhan> result = null; 
			TransactionManager transactionManager = null; 
			
			try
            {
				bool isBorrowedTransaction = ConnectionScope.Current.HasTransaction;				
				
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
                
				//Call Custom Procedure from Repository
				result = dataProvider.ViewLopHocPhanProvider.GetByNamHocHocKy(transactionManager, start, pageLength , namHoc, hocKy);
	        
            	
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
		
		#region cust_View_LopHocPhan_GetThongTinLopHocPhan
		/// <summary>
		///	This method wrap the 'cust_View_LopHocPhan_GetThongTinLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public virtual IDataReader GetThongTinLopHocPhan(System.String namHoc, System.String hocKy)
		{
			return GetThongTinLopHocPhan( namHoc, hocKy, 0, defaultMaxRecords );
		}
	
		/// <summary>
		///	This method wrap the 'cust_View_LopHocPhan_GetThongTinLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public virtual IDataReader GetThongTinLopHocPhan(System.String namHoc, System.String hocKy, int start, int pageLength)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetThongTinLopHocPhan");
			
		
			IDataReader result = null; 
			TransactionManager transactionManager = null; 
			
			try
            {
				bool isBorrowedTransaction = ConnectionScope.Current.HasTransaction;				
				
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
                
				//Call Custom Procedure from Repository
				result = dataProvider.ViewLopHocPhanProvider.GetThongTinLopHocPhan(transactionManager, start, pageLength , namHoc, hocKy);
	        
            	
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
		
		#region cust_View_LopHocPhan_GetByNamHocHocKyKhoaDonViBuh
		/// <summary>
		///	This method wrap the 'cust_View_LopHocPhan_GetByNamHocHocKyKhoaDonViBuh' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public virtual IDataReader GetByNamHocHocKyKhoaDonViBuh(System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetByNamHocHocKyKhoaDonViBuh( namHoc, hocKy, maDonVi, 0, defaultMaxRecords );
		}
	
		/// <summary>
		///	This method wrap the 'cust_View_LopHocPhan_GetByNamHocHocKyKhoaDonViBuh' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public virtual IDataReader GetByNamHocHocKyKhoaDonViBuh(System.String namHoc, System.String hocKy, System.String maDonVi, int start, int pageLength)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetByNamHocHocKyKhoaDonViBuh");
			
		
			IDataReader result = null; 
			TransactionManager transactionManager = null; 
			
			try
            {
				bool isBorrowedTransaction = ConnectionScope.Current.HasTransaction;				
				
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
                
				//Call Custom Procedure from Repository
				result = dataProvider.ViewLopHocPhanProvider.GetByNamHocHocKyKhoaDonViBuh(transactionManager, start, pageLength , namHoc, hocKy, maDonVi);
	        
            	
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
		
		#region cust_View_LopHocPhan_GetByNamHocHocKyKhoaDonVi
		/// <summary>
		///	This method wrap the 'cust_View_LopHocPhan_GetByNamHocHocKyKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewLopHocPhan}"/> instance.</returns>
		public virtual VList<ViewLopHocPhan> GetByNamHocHocKyKhoaDonVi(System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetByNamHocHocKyKhoaDonVi( namHoc, hocKy, maDonVi, 0, defaultMaxRecords );
		}
	
		/// <summary>
		///	This method wrap the 'cust_View_LopHocPhan_GetByNamHocHocKyKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewLopHocPhan}"/> instance.</returns>
		public virtual VList<ViewLopHocPhan> GetByNamHocHocKyKhoaDonVi(System.String namHoc, System.String hocKy, System.String maDonVi, int start, int pageLength)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetByNamHocHocKyKhoaDonVi");
			
		
			VList<ViewLopHocPhan> result = null; 
			TransactionManager transactionManager = null; 
			
			try
            {
				bool isBorrowedTransaction = ConnectionScope.Current.HasTransaction;				
				
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
                
				//Call Custom Procedure from Repository
				result = dataProvider.ViewLopHocPhanProvider.GetByNamHocHocKyKhoaDonVi(transactionManager, start, pageLength , namHoc, hocKy, maDonVi);
	        
            	
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



