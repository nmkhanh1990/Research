﻿
/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewThanhTraCoiThi.cs instead.
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
	/// An object representation of the 'View_ThanhTraCoiThi' View.
	///</summary>
	/// <remarks>
	/// IMPORTANT!!! You should not modify this partial  class, modify the ViewThanhTraCoiThi.cs file instead.
	/// All custom implementations should be done in the <see cref="ViewThanhTraCoiThi"/> class.
	/// </remarks>
	[DataObject]
	public partial class ViewThanhTraCoiThiServiceBase : ServiceViewBase<ViewThanhTraCoiThi>
	{

		#region Constructors
		///<summary>
		/// Creates a new <see cref="ViewThanhTraCoiThi"/> instance .
		///</summary>
		public ViewThanhTraCoiThiServiceBase() : base()
		{
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewThanhTraCoiThi"/> instance.
		///</summary>
		///<param name="_examination"></param>
		///<param name="_maCanBoCoiThi"></param>
		///<param name="_ho"></param>
		///<param name="_ten"></param>
		///<param name="_hoTen"></param>
		///<param name="_ngayThi"></param>
		///<param name="_thoiGianBatDau"></param>
		///<param name="_maPhong"></param>
		///<param name="_maLopHocPhan"></param>
		///<param name="_maMonHoc"></param>
		///<param name="_tenMonHoc"></param>
		///<param name="_thoiGianLamBai"></param>
		///<param name="_tietBatDau"></param>
		///<param name="_maLopSinhVien"></param>
		///<param name="_soLuongSinhVien"></param>
		///<param name="_tenKhoaChuQuan"></param>
		///<param name="_maViPham"></param>
		///<param name="_maHinhThucViPhamHrm"></param>
		///<param name="_siSoThanhTra"></param>
		///<param name="_thoiDiemGhiNhan"></param>
		///<param name="_lyDo"></param>
		///<param name="_ghiChu"></param>
		///<param name="_ngayCapNhat"></param>
		///<param name="_nguoiCapNhat"></param>
		///<param name="_maLoaiHocPhan"></param>
		///<param name="_tuTietDenTiet"></param>
		///<param name="_trangThai"></param>
		///<param name="_xacNhan"></param>
		///<param name="_soTiet"></param>
		///<param name="_lt"></param>
		///<param name="_th"></param>
		public static ViewThanhTraCoiThi CreateViewThanhTraCoiThi(System.Int32 _examination, System.String _maCanBoCoiThi, System.String _ho, System.String _ten, System.String _hoTen, System.String _ngayThi, System.String _thoiGianBatDau, System.String _maPhong, System.String _maLopHocPhan, System.String _maMonHoc, System.String _tenMonHoc, System.String _thoiGianLamBai, System.Int32? _tietBatDau, System.String _maLopSinhVien, System.Int32? _soLuongSinhVien, System.String _tenKhoaChuQuan, System.String _maViPham, System.Guid? _maHinhThucViPhamHrm, System.Int32? _siSoThanhTra, System.String _thoiDiemGhiNhan, System.String _lyDo, System.String _ghiChu, System.String _ngayCapNhat, System.String _nguoiCapNhat, System.Int32? _maLoaiHocPhan, System.String _tuTietDenTiet, System.Boolean? _trangThai, System.Boolean? _xacNhan, System.Int32 _soTiet, System.Int32? _lt, System.Int32? _th)
		{
			ViewThanhTraCoiThi newEntityViewThanhTraCoiThi = new ViewThanhTraCoiThi();
			newEntityViewThanhTraCoiThi.Examination  = _examination;
			newEntityViewThanhTraCoiThi.MaCanBoCoiThi  = _maCanBoCoiThi;
			newEntityViewThanhTraCoiThi.Ho  = _ho;
			newEntityViewThanhTraCoiThi.Ten  = _ten;
			newEntityViewThanhTraCoiThi.HoTen  = _hoTen;
			newEntityViewThanhTraCoiThi.NgayThi  = _ngayThi;
			newEntityViewThanhTraCoiThi.ThoiGianBatDau  = _thoiGianBatDau;
			newEntityViewThanhTraCoiThi.MaPhong  = _maPhong;
			newEntityViewThanhTraCoiThi.MaLopHocPhan  = _maLopHocPhan;
			newEntityViewThanhTraCoiThi.MaMonHoc  = _maMonHoc;
			newEntityViewThanhTraCoiThi.TenMonHoc  = _tenMonHoc;
			newEntityViewThanhTraCoiThi.ThoiGianLamBai  = _thoiGianLamBai;
			newEntityViewThanhTraCoiThi.TietBatDau  = _tietBatDau;
			newEntityViewThanhTraCoiThi.MaLopSinhVien  = _maLopSinhVien;
			newEntityViewThanhTraCoiThi.SoLuongSinhVien  = _soLuongSinhVien;
			newEntityViewThanhTraCoiThi.TenKhoaChuQuan  = _tenKhoaChuQuan;
			newEntityViewThanhTraCoiThi.MaViPham  = _maViPham;
			newEntityViewThanhTraCoiThi.MaHinhThucViPhamHrm  = _maHinhThucViPhamHrm;
			newEntityViewThanhTraCoiThi.SiSoThanhTra  = _siSoThanhTra;
			newEntityViewThanhTraCoiThi.ThoiDiemGhiNhan  = _thoiDiemGhiNhan;
			newEntityViewThanhTraCoiThi.LyDo  = _lyDo;
			newEntityViewThanhTraCoiThi.GhiChu  = _ghiChu;
			newEntityViewThanhTraCoiThi.NgayCapNhat  = _ngayCapNhat;
			newEntityViewThanhTraCoiThi.NguoiCapNhat  = _nguoiCapNhat;
			newEntityViewThanhTraCoiThi.MaLoaiHocPhan  = _maLoaiHocPhan;
			newEntityViewThanhTraCoiThi.TuTietDenTiet  = _tuTietDenTiet;
			newEntityViewThanhTraCoiThi.TrangThai  = _trangThai;
			newEntityViewThanhTraCoiThi.XacNhan  = _xacNhan;
			newEntityViewThanhTraCoiThi.SoTiet  = _soTiet;
			newEntityViewThanhTraCoiThi.Lt  = _lt;
			newEntityViewThanhTraCoiThi.Th  = _th;
			return newEntityViewThanhTraCoiThi;
		}
		#endregion Constructors

		#region Fields
		//private static SecurityContext<ViewThanhTraCoiThi> securityContext = new SecurityContext<ViewThanhTraCoiThi>();
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
		public override VList<ViewThanhTraCoiThi> Get(string whereClause, string orderBy)
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
		/// <returns>Returns a typed collection TList{ViewThanhTraCoiThi} of <c>ViewThanhTraCoiThi</c> objects.</returns>
		public override VList<ViewThanhTraCoiThi> Get(string whereClause, string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Get");
								
			// get this data
			VList<ViewThanhTraCoiThi> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewThanhTraCoiThiProvider.Get(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// Get a complete collection of <see cref="ViewThanhTraCoiThi" /> entities.
		/// </summary>
		/// <returns></returns>
		public virtual VList<ViewThanhTraCoiThi> GetAll() 
		{
			int totalCount = -1;
			return GetAll(0, defaultMaxRecords, out totalCount);
		}

       
		/// <summary>
		/// Get a set portion of a complete list of <see cref="ViewThanhTraCoiThi" /> entities
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">out parameter, number of total rows in given query.</param>
		/// <returns>a <see cref="TList{ViewThanhTraCoiThi}"/> </returns>
		public override VList<ViewThanhTraCoiThi> GetAll(int start, int pageLength, out int totalCount) 
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetAll");
			
			// get this data
			VList<ViewThanhTraCoiThi> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;					

				//Access repository
				list = dataProvider.ViewThanhTraCoiThiProvider.GetAll(transactionManager, start, pageLength, out totalCount);	
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
		/// Gets a page of <see cref="TList{ViewThanhTraCoiThi}" /> rows from the DataSource.
		/// </summary>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewThanhTraCoiThi</c> objects.</returns>
		public virtual VList<ViewThanhTraCoiThi> GetPaged(out int totalCount)
		{
			return GetPaged(null, null, 0, defaultMaxRecords, out totalCount);
		}
		
		/// <summary>
		/// Gets a page of <see cref="TList{ViewThanhTraCoiThi}" /> rows from the DataSource.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewThanhTraCoiThi</c> objects.</returns>
		public virtual VList<ViewThanhTraCoiThi> GetPaged(int start, int pageLength, out int totalCount)
		{
			return GetPaged(null, null, start, pageLength, out totalCount);
		}

		/// <summary>
		/// Gets a page of entity rows with a <see cref="TList{ViewThanhTraCoiThi}" /> from the DataSource with a where clause and order by clause.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC).</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewThanhTraCoiThi</c> objects.</returns>
		public override VList<ViewThanhTraCoiThi> GetPaged(string whereClause,string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetPaged");
			
			// get this data
			VList<ViewThanhTraCoiThi> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewThanhTraCoiThiProvider.GetPaged(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// <returns>Returns a typed collection of <c>ViewThanhTraCoiThi</c> objects.</returns>
		public virtual VList<ViewThanhTraCoiThi> Find(IFilterParameterCollection parameters)
		{
			return Find(parameters, null);
		}
		
		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <returns>Returns a typed collection of <c>ViewThanhTraCoiThi</c> objects.</returns>
		public virtual VList<ViewThanhTraCoiThi> Find(IFilterParameterCollection parameters, string orderBy)
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
		/// <returns>Returns a typed collection of <c>ViewThanhTraCoiThi</c> objects.</returns>
		public override VList<ViewThanhTraCoiThi> Find(IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Find");
								
			// get this data
			TransactionManager transactionManager = null; 
			VList<ViewThanhTraCoiThi> list = null;
			count = -1;
			
			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewThanhTraCoiThiProvider.Find(transactionManager, parameters, orderBy, start, pageLength, out count);
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
		
		#region cust_View_ThanhTraCoiThi_GetByNgayCoSoToaNha
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraCoiThi_GetByNgayCoSoToaNha' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="toaNha"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewThanhTraCoiThi}"/> instance.</returns>
		public virtual VList<ViewThanhTraCoiThi> GetByNgayCoSoToaNha(System.String tuNgay, System.String denNgay, System.String toaNha)
		{
			return GetByNgayCoSoToaNha( tuNgay, denNgay, toaNha, 0, defaultMaxRecords );
		}
	
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraCoiThi_GetByNgayCoSoToaNha' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="toaNha"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewThanhTraCoiThi}"/> instance.</returns>
		public virtual VList<ViewThanhTraCoiThi> GetByNgayCoSoToaNha(System.String tuNgay, System.String denNgay, System.String toaNha, int start, int pageLength)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetByNgayCoSoToaNha");
			
		
			VList<ViewThanhTraCoiThi> result = null; 
			TransactionManager transactionManager = null; 
			
			try
            {
				bool isBorrowedTransaction = ConnectionScope.Current.HasTransaction;				
				
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
                
				//Call Custom Procedure from Repository
				result = dataProvider.ViewThanhTraCoiThiProvider.GetByNgayCoSoToaNha(transactionManager, start, pageLength , tuNgay, denNgay, toaNha);
	        
            	
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



