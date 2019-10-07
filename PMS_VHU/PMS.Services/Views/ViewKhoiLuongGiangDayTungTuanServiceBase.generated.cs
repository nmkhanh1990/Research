﻿
/*
	File generated by NetTiers templates [www.NetTiers.com]
	Important: Do not modify this file. Edit the file ViewKhoiLuongGiangDayTungTuan.cs instead.
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
	/// An object representation of the 'View_KhoiLuongGiangDay_TungTuan' View.
	///</summary>
	/// <remarks>
	/// IMPORTANT!!! You should not modify this partial  class, modify the ViewKhoiLuongGiangDayTungTuan.cs file instead.
	/// All custom implementations should be done in the <see cref="ViewKhoiLuongGiangDayTungTuan"/> class.
	/// </remarks>
	[DataObject]
	public partial class ViewKhoiLuongGiangDayTungTuanServiceBase : ServiceViewBase<ViewKhoiLuongGiangDayTungTuan>
	{

		#region Constructors
		///<summary>
		/// Creates a new <see cref="ViewKhoiLuongGiangDayTungTuan"/> instance .
		///</summary>
		public ViewKhoiLuongGiangDayTungTuanServiceBase() : base()
		{
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewKhoiLuongGiangDayTungTuan"/> instance.
		///</summary>
		///<param name="_stt"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_maQuanLy1"></param>
		///<param name="_ho"></param>
		///<param name="_ho1"></param>
		///<param name="_ten"></param>
		///<param name="_ten1"></param>
		///<param name="_maLopHocPhan"></param>
		///<param name="_maLop"></param>
		///<param name="_maHeDaoTao"></param>
		///<param name="_tenHeDaoTao"></param>
		///<param name="_maBacDaoTao"></param>
		///<param name="_tenBacDaoTao"></param>
		///<param name="_maDonVi"></param>
		///<param name="_tenDonVi"></param>
		///<param name="_maLoaiGiangVien"></param>
		///<param name="_maKhoaHoc"></param>
		///<param name="_tenKhoaHoc"></param>
		///<param name="_maMonHoc"></param>
		///<param name="_tenMonHoc"></param>
		///<param name="_loaiHocPhan"></param>
		///<param name="_heSoLopDong"></param>
		///<param name="_siSoLop"></param>
		///<param name="_lyThuyet"></param>
		///<param name="_thucHanh"></param>
		///<param name="_lyThuyetCoHeSo"></param>
		///<param name="_thucHanhCoHeSo"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_tongLyThuyetThucHanh"></param>
		///<param name="_tongLyThuyetThucHanhCoHeSo"></param>
		///<param name="_tongLyThuyetThucHanhTg"></param>
		public static ViewKhoiLuongGiangDayTungTuan CreateViewKhoiLuongGiangDayTungTuan(System.Int32? _stt, System.String _maQuanLy, System.String _maQuanLy1, System.String _ho, System.String _ho1, System.String _ten, System.String _ten1, System.String _maLopHocPhan, System.String _maLop, System.String _maHeDaoTao, System.String _tenHeDaoTao, System.String _maBacDaoTao, System.String _tenBacDaoTao, System.String _maDonVi, System.String _tenDonVi, System.Int32? _maLoaiGiangVien, System.String _maKhoaHoc, System.String _tenKhoaHoc, System.String _maMonHoc, System.String _tenMonHoc, System.String _loaiHocPhan, System.Decimal? _heSoLopDong, System.Int32? _siSoLop, System.Decimal? _lyThuyet, System.Decimal? _thucHanh, System.Decimal? _lyThuyetCoHeSo, System.Decimal? _thucHanhCoHeSo, System.String _namHoc, System.String _hocKy, System.Decimal? _tongLyThuyetThucHanh, System.Decimal? _tongLyThuyetThucHanhCoHeSo, System.Decimal? _tongLyThuyetThucHanhTg)
		{
			ViewKhoiLuongGiangDayTungTuan newEntityViewKhoiLuongGiangDayTungTuan = new ViewKhoiLuongGiangDayTungTuan();
			newEntityViewKhoiLuongGiangDayTungTuan.Stt  = _stt;
			newEntityViewKhoiLuongGiangDayTungTuan.MaQuanLy  = _maQuanLy;
			newEntityViewKhoiLuongGiangDayTungTuan.MaQuanLy1  = _maQuanLy1;
			newEntityViewKhoiLuongGiangDayTungTuan.Ho  = _ho;
			newEntityViewKhoiLuongGiangDayTungTuan.Ho1  = _ho1;
			newEntityViewKhoiLuongGiangDayTungTuan.Ten  = _ten;
			newEntityViewKhoiLuongGiangDayTungTuan.Ten1  = _ten1;
			newEntityViewKhoiLuongGiangDayTungTuan.MaLopHocPhan  = _maLopHocPhan;
			newEntityViewKhoiLuongGiangDayTungTuan.MaLop  = _maLop;
			newEntityViewKhoiLuongGiangDayTungTuan.MaHeDaoTao  = _maHeDaoTao;
			newEntityViewKhoiLuongGiangDayTungTuan.TenHeDaoTao  = _tenHeDaoTao;
			newEntityViewKhoiLuongGiangDayTungTuan.MaBacDaoTao  = _maBacDaoTao;
			newEntityViewKhoiLuongGiangDayTungTuan.TenBacDaoTao  = _tenBacDaoTao;
			newEntityViewKhoiLuongGiangDayTungTuan.MaDonVi  = _maDonVi;
			newEntityViewKhoiLuongGiangDayTungTuan.TenDonVi  = _tenDonVi;
			newEntityViewKhoiLuongGiangDayTungTuan.MaLoaiGiangVien  = _maLoaiGiangVien;
			newEntityViewKhoiLuongGiangDayTungTuan.MaKhoaHoc  = _maKhoaHoc;
			newEntityViewKhoiLuongGiangDayTungTuan.TenKhoaHoc  = _tenKhoaHoc;
			newEntityViewKhoiLuongGiangDayTungTuan.MaMonHoc  = _maMonHoc;
			newEntityViewKhoiLuongGiangDayTungTuan.TenMonHoc  = _tenMonHoc;
			newEntityViewKhoiLuongGiangDayTungTuan.LoaiHocPhan  = _loaiHocPhan;
			newEntityViewKhoiLuongGiangDayTungTuan.HeSoLopDong  = _heSoLopDong;
			newEntityViewKhoiLuongGiangDayTungTuan.SiSoLop  = _siSoLop;
			newEntityViewKhoiLuongGiangDayTungTuan.LyThuyet  = _lyThuyet;
			newEntityViewKhoiLuongGiangDayTungTuan.ThucHanh  = _thucHanh;
			newEntityViewKhoiLuongGiangDayTungTuan.LyThuyetCoHeSo  = _lyThuyetCoHeSo;
			newEntityViewKhoiLuongGiangDayTungTuan.ThucHanhCoHeSo  = _thucHanhCoHeSo;
			newEntityViewKhoiLuongGiangDayTungTuan.NamHoc  = _namHoc;
			newEntityViewKhoiLuongGiangDayTungTuan.HocKy  = _hocKy;
			newEntityViewKhoiLuongGiangDayTungTuan.TongLyThuyetThucHanh  = _tongLyThuyetThucHanh;
			newEntityViewKhoiLuongGiangDayTungTuan.TongLyThuyetThucHanhCoHeSo  = _tongLyThuyetThucHanhCoHeSo;
			newEntityViewKhoiLuongGiangDayTungTuan.TongLyThuyetThucHanhTg  = _tongLyThuyetThucHanhTg;
			return newEntityViewKhoiLuongGiangDayTungTuan;
		}
		#endregion Constructors

		#region Fields
		//private static SecurityContext<ViewKhoiLuongGiangDayTungTuan> securityContext = new SecurityContext<ViewKhoiLuongGiangDayTungTuan>();
		private static readonly string layerExceptionPolicy = "NoneExceptionPolicy";
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
		public override VList<ViewKhoiLuongGiangDayTungTuan> Get(string whereClause, string orderBy)
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
		/// <returns>Returns a typed collection TList{ViewKhoiLuongGiangDayTungTuan} of <c>ViewKhoiLuongGiangDayTungTuan</c> objects.</returns>
		public override VList<ViewKhoiLuongGiangDayTungTuan> Get(string whereClause, string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Get");
								
			// get this data
			VList<ViewKhoiLuongGiangDayTungTuan> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewKhoiLuongGiangDayTungTuanProvider.Get(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// Get a complete collection of <see cref="ViewKhoiLuongGiangDayTungTuan" /> entities.
		/// </summary>
		/// <returns></returns>
		public virtual VList<ViewKhoiLuongGiangDayTungTuan> GetAll() 
		{
			int totalCount = -1;
			return GetAll(0, defaultMaxRecords, out totalCount);
		}

       
		/// <summary>
		/// Get a set portion of a complete list of <see cref="ViewKhoiLuongGiangDayTungTuan" /> entities
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">out parameter, number of total rows in given query.</param>
		/// <returns>a <see cref="TList{ViewKhoiLuongGiangDayTungTuan}"/> </returns>
		public override VList<ViewKhoiLuongGiangDayTungTuan> GetAll(int start, int pageLength, out int totalCount) 
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetAll");
			
			// get this data
			VList<ViewKhoiLuongGiangDayTungTuan> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;					

				//Access repository
				list = dataProvider.ViewKhoiLuongGiangDayTungTuanProvider.GetAll(transactionManager, start, pageLength, out totalCount);	
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
		/// Gets a page of <see cref="TList{ViewKhoiLuongGiangDayTungTuan}" /> rows from the DataSource.
		/// </summary>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewKhoiLuongGiangDayTungTuan</c> objects.</returns>
		public virtual VList<ViewKhoiLuongGiangDayTungTuan> GetPaged(out int totalCount)
		{
			return GetPaged(null, null, 0, defaultMaxRecords, out totalCount);
		}
		
		/// <summary>
		/// Gets a page of <see cref="TList{ViewKhoiLuongGiangDayTungTuan}" /> rows from the DataSource.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewKhoiLuongGiangDayTungTuan</c> objects.</returns>
		public virtual VList<ViewKhoiLuongGiangDayTungTuan> GetPaged(int start, int pageLength, out int totalCount)
		{
			return GetPaged(null, null, start, pageLength, out totalCount);
		}

		/// <summary>
		/// Gets a page of entity rows with a <see cref="TList{ViewKhoiLuongGiangDayTungTuan}" /> from the DataSource with a where clause and order by clause.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC).</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewKhoiLuongGiangDayTungTuan</c> objects.</returns>
		public override VList<ViewKhoiLuongGiangDayTungTuan> GetPaged(string whereClause,string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetPaged");
			
			// get this data
			VList<ViewKhoiLuongGiangDayTungTuan> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewKhoiLuongGiangDayTungTuanProvider.GetPaged(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// <returns>Returns a typed collection of <c>ViewKhoiLuongGiangDayTungTuan</c> objects.</returns>
		public virtual VList<ViewKhoiLuongGiangDayTungTuan> Find(IFilterParameterCollection parameters)
		{
			return Find(parameters, null);
		}
		
		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <returns>Returns a typed collection of <c>ViewKhoiLuongGiangDayTungTuan</c> objects.</returns>
		public virtual VList<ViewKhoiLuongGiangDayTungTuan> Find(IFilterParameterCollection parameters, string orderBy)
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
		/// <returns>Returns a typed collection of <c>ViewKhoiLuongGiangDayTungTuan</c> objects.</returns>
		public override VList<ViewKhoiLuongGiangDayTungTuan> Find(IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Find");
								
			// get this data
			TransactionManager transactionManager = null; 
			VList<ViewKhoiLuongGiangDayTungTuan> list = null;
			count = -1;
			
			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewKhoiLuongGiangDayTungTuanProvider.Find(transactionManager, parameters, orderBy, start, pageLength, out count);
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
		#endregion
		
		#endregion Data Access Methods
		
	
	}//End Class
} // end namespace


