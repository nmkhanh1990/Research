﻿
/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewKcqKetQuaThanhToanThuLao.cs instead.
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
	/// An object representation of the 'View_KcqKetQuaThanhToanThuLao' View.
	///</summary>
	/// <remarks>
	/// IMPORTANT!!! You should not modify this partial  class, modify the ViewKcqKetQuaThanhToanThuLao.cs file instead.
	/// All custom implementations should be done in the <see cref="ViewKcqKetQuaThanhToanThuLao"/> class.
	/// </remarks>
	[DataObject]
	public partial class ViewKcqKetQuaThanhToanThuLaoServiceBase : ServiceViewBase<ViewKcqKetQuaThanhToanThuLao>
	{

		#region Constructors
		///<summary>
		/// Creates a new <see cref="ViewKcqKetQuaThanhToanThuLao"/> instance .
		///</summary>
		public ViewKcqKetQuaThanhToanThuLaoServiceBase() : base()
		{
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewKcqKetQuaThanhToanThuLao"/> instance.
		///</summary>
		///<param name="_maGiangVien"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_ho"></param>
		///<param name="_ten"></param>
		///<param name="_hoTen"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_maHocHam"></param>
		///<param name="_tenHocHam"></param>
		///<param name="_maHocVi"></param>
		///<param name="_tenHocVi"></param>
		///<param name="_maLoaiGiangVien"></param>
		///<param name="_tenLoaiGiangVien"></param>
		///<param name="_maDonVi"></param>
		///<param name="_tenDonVi"></param>
		///<param name="_loai"></param>
		///<param name="_phanLoai"></param>
		///<param name="_maMonHoc"></param>
		///<param name="_tenMonHoc"></param>
		///<param name="_loaiHocPhan"></param>
		///<param name="_nhom"></param>
		///<param name="_maLop"></param>
		///<param name="_lopClc"></param>
		///<param name="_siSo"></param>
		///<param name="_tietThucDay"></param>
		///<param name="_tietChuNhat"></param>
		///<param name="_heSoHocKy"></param>
		///<param name="_heSoLopDong"></param>
		///<param name="_tietQuyDoi"></param>
		///<param name="_donGia"></param>
		///<param name="_thanhTien"></param>
		///<param name="_lanChot"></param>
		///<param name="_ngayCapNhat"></param>
		///<param name="_maDiaDiem"></param>
		///<param name="_tenDiaDiem"></param>
		///<param name="_tienXeDiaDiem"></param>
		///<param name="_donGiaDiaDiem"></param>
		///<param name="_heSoDiaDiem"></param>
		///<param name="_soTinChi"></param>
		public static ViewKcqKetQuaThanhToanThuLao CreateViewKcqKetQuaThanhToanThuLao(System.Int32? _maGiangVien, System.String _maQuanLy, System.String _ho, System.String _ten, System.String _hoTen, System.String _namHoc, System.String _hocKy, System.Int32? _maHocHam, System.String _tenHocHam, System.Int32? _maHocVi, System.String _tenHocVi, System.Int32? _maLoaiGiangVien, System.String _tenLoaiGiangVien, System.String _maDonVi, System.String _tenDonVi, System.String _loai, System.String _phanLoai, System.String _maMonHoc, System.String _tenMonHoc, System.String _loaiHocPhan, System.String _nhom, System.String _maLop, System.Boolean? _lopClc, System.Int32? _siSo, System.Decimal? _tietThucDay, System.Decimal? _tietChuNhat, System.Decimal? _heSoHocKy, System.Decimal? _heSoLopDong, System.Decimal? _tietQuyDoi, System.Decimal? _donGia, System.Decimal? _thanhTien, System.Int32? _lanChot, System.DateTime? _ngayCapNhat, System.String _maDiaDiem, System.String _tenDiaDiem, System.Decimal? _tienXeDiaDiem, System.Decimal? _donGiaDiaDiem, System.Decimal? _heSoDiaDiem, System.Int32? _soTinChi)
		{
			ViewKcqKetQuaThanhToanThuLao newEntityViewKcqKetQuaThanhToanThuLao = new ViewKcqKetQuaThanhToanThuLao();
			newEntityViewKcqKetQuaThanhToanThuLao.MaGiangVien  = _maGiangVien;
			newEntityViewKcqKetQuaThanhToanThuLao.MaQuanLy  = _maQuanLy;
			newEntityViewKcqKetQuaThanhToanThuLao.Ho  = _ho;
			newEntityViewKcqKetQuaThanhToanThuLao.Ten  = _ten;
			newEntityViewKcqKetQuaThanhToanThuLao.HoTen  = _hoTen;
			newEntityViewKcqKetQuaThanhToanThuLao.NamHoc  = _namHoc;
			newEntityViewKcqKetQuaThanhToanThuLao.HocKy  = _hocKy;
			newEntityViewKcqKetQuaThanhToanThuLao.MaHocHam  = _maHocHam;
			newEntityViewKcqKetQuaThanhToanThuLao.TenHocHam  = _tenHocHam;
			newEntityViewKcqKetQuaThanhToanThuLao.MaHocVi  = _maHocVi;
			newEntityViewKcqKetQuaThanhToanThuLao.TenHocVi  = _tenHocVi;
			newEntityViewKcqKetQuaThanhToanThuLao.MaLoaiGiangVien  = _maLoaiGiangVien;
			newEntityViewKcqKetQuaThanhToanThuLao.TenLoaiGiangVien  = _tenLoaiGiangVien;
			newEntityViewKcqKetQuaThanhToanThuLao.MaDonVi  = _maDonVi;
			newEntityViewKcqKetQuaThanhToanThuLao.TenDonVi  = _tenDonVi;
			newEntityViewKcqKetQuaThanhToanThuLao.Loai  = _loai;
			newEntityViewKcqKetQuaThanhToanThuLao.PhanLoai  = _phanLoai;
			newEntityViewKcqKetQuaThanhToanThuLao.MaMonHoc  = _maMonHoc;
			newEntityViewKcqKetQuaThanhToanThuLao.TenMonHoc  = _tenMonHoc;
			newEntityViewKcqKetQuaThanhToanThuLao.LoaiHocPhan  = _loaiHocPhan;
			newEntityViewKcqKetQuaThanhToanThuLao.Nhom  = _nhom;
			newEntityViewKcqKetQuaThanhToanThuLao.MaLop  = _maLop;
			newEntityViewKcqKetQuaThanhToanThuLao.LopClc  = _lopClc;
			newEntityViewKcqKetQuaThanhToanThuLao.SiSo  = _siSo;
			newEntityViewKcqKetQuaThanhToanThuLao.TietThucDay  = _tietThucDay;
			newEntityViewKcqKetQuaThanhToanThuLao.TietChuNhat  = _tietChuNhat;
			newEntityViewKcqKetQuaThanhToanThuLao.HeSoHocKy  = _heSoHocKy;
			newEntityViewKcqKetQuaThanhToanThuLao.HeSoLopDong  = _heSoLopDong;
			newEntityViewKcqKetQuaThanhToanThuLao.TietQuyDoi  = _tietQuyDoi;
			newEntityViewKcqKetQuaThanhToanThuLao.DonGia  = _donGia;
			newEntityViewKcqKetQuaThanhToanThuLao.ThanhTien  = _thanhTien;
			newEntityViewKcqKetQuaThanhToanThuLao.LanChot  = _lanChot;
			newEntityViewKcqKetQuaThanhToanThuLao.NgayCapNhat  = _ngayCapNhat;
			newEntityViewKcqKetQuaThanhToanThuLao.MaDiaDiem  = _maDiaDiem;
			newEntityViewKcqKetQuaThanhToanThuLao.TenDiaDiem  = _tenDiaDiem;
			newEntityViewKcqKetQuaThanhToanThuLao.TienXeDiaDiem  = _tienXeDiaDiem;
			newEntityViewKcqKetQuaThanhToanThuLao.DonGiaDiaDiem  = _donGiaDiaDiem;
			newEntityViewKcqKetQuaThanhToanThuLao.HeSoDiaDiem  = _heSoDiaDiem;
			newEntityViewKcqKetQuaThanhToanThuLao.SoTinChi  = _soTinChi;
			return newEntityViewKcqKetQuaThanhToanThuLao;
		}
		#endregion Constructors

		#region Fields
		//private static SecurityContext<ViewKcqKetQuaThanhToanThuLao> securityContext = new SecurityContext<ViewKcqKetQuaThanhToanThuLao>();
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
		public override VList<ViewKcqKetQuaThanhToanThuLao> Get(string whereClause, string orderBy)
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
		/// <returns>Returns a typed collection TList{ViewKcqKetQuaThanhToanThuLao} of <c>ViewKcqKetQuaThanhToanThuLao</c> objects.</returns>
		public override VList<ViewKcqKetQuaThanhToanThuLao> Get(string whereClause, string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Get");
								
			// get this data
			VList<ViewKcqKetQuaThanhToanThuLao> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewKcqKetQuaThanhToanThuLaoProvider.Get(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// Get a complete collection of <see cref="ViewKcqKetQuaThanhToanThuLao" /> entities.
		/// </summary>
		/// <returns></returns>
		public virtual VList<ViewKcqKetQuaThanhToanThuLao> GetAll() 
		{
			int totalCount = -1;
			return GetAll(0, defaultMaxRecords, out totalCount);
		}

       
		/// <summary>
		/// Get a set portion of a complete list of <see cref="ViewKcqKetQuaThanhToanThuLao" /> entities
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">out parameter, number of total rows in given query.</param>
		/// <returns>a <see cref="TList{ViewKcqKetQuaThanhToanThuLao}"/> </returns>
		public override VList<ViewKcqKetQuaThanhToanThuLao> GetAll(int start, int pageLength, out int totalCount) 
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetAll");
			
			// get this data
			VList<ViewKcqKetQuaThanhToanThuLao> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;					

				//Access repository
				list = dataProvider.ViewKcqKetQuaThanhToanThuLaoProvider.GetAll(transactionManager, start, pageLength, out totalCount);	
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
		/// Gets a page of <see cref="TList{ViewKcqKetQuaThanhToanThuLao}" /> rows from the DataSource.
		/// </summary>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewKcqKetQuaThanhToanThuLao</c> objects.</returns>
		public virtual VList<ViewKcqKetQuaThanhToanThuLao> GetPaged(out int totalCount)
		{
			return GetPaged(null, null, 0, defaultMaxRecords, out totalCount);
		}
		
		/// <summary>
		/// Gets a page of <see cref="TList{ViewKcqKetQuaThanhToanThuLao}" /> rows from the DataSource.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewKcqKetQuaThanhToanThuLao</c> objects.</returns>
		public virtual VList<ViewKcqKetQuaThanhToanThuLao> GetPaged(int start, int pageLength, out int totalCount)
		{
			return GetPaged(null, null, start, pageLength, out totalCount);
		}

		/// <summary>
		/// Gets a page of entity rows with a <see cref="TList{ViewKcqKetQuaThanhToanThuLao}" /> from the DataSource with a where clause and order by clause.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC).</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewKcqKetQuaThanhToanThuLao</c> objects.</returns>
		public override VList<ViewKcqKetQuaThanhToanThuLao> GetPaged(string whereClause,string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetPaged");
			
			// get this data
			VList<ViewKcqKetQuaThanhToanThuLao> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewKcqKetQuaThanhToanThuLaoProvider.GetPaged(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// <returns>Returns a typed collection of <c>ViewKcqKetQuaThanhToanThuLao</c> objects.</returns>
		public virtual VList<ViewKcqKetQuaThanhToanThuLao> Find(IFilterParameterCollection parameters)
		{
			return Find(parameters, null);
		}
		
		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <returns>Returns a typed collection of <c>ViewKcqKetQuaThanhToanThuLao</c> objects.</returns>
		public virtual VList<ViewKcqKetQuaThanhToanThuLao> Find(IFilterParameterCollection parameters, string orderBy)
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
		/// <returns>Returns a typed collection of <c>ViewKcqKetQuaThanhToanThuLao</c> objects.</returns>
		public override VList<ViewKcqKetQuaThanhToanThuLao> Find(IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Find");
								
			// get this data
			TransactionManager transactionManager = null; 
			VList<ViewKcqKetQuaThanhToanThuLao> list = null;
			count = -1;
			
			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewKcqKetQuaThanhToanThuLaoProvider.Find(transactionManager, parameters, orderBy, start, pageLength, out count);
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
		
		#region cust_View_KcqKetQuaThanhToanThuLao_GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot2
		/// <summary>
		///	This method wrap the 'cust_View_KcqKetQuaThanhToanThuLao_GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot2' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public virtual IDataReader GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot2(System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.String lanChot)
		{
			return GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot2( namHoc, hocKy, donVi, loaiGiangVien, lanChot, 0, defaultMaxRecords );
		}
	
		/// <summary>
		///	This method wrap the 'cust_View_KcqKetQuaThanhToanThuLao_GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot2' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public virtual IDataReader GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot2(System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.String lanChot, int start, int pageLength)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot2");
			
		
			IDataReader result = null; 
			TransactionManager transactionManager = null; 
			
			try
            {
				bool isBorrowedTransaction = ConnectionScope.Current.HasTransaction;				
				
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
                
				//Call Custom Procedure from Repository
				result = dataProvider.ViewKcqKetQuaThanhToanThuLaoProvider.GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot2(transactionManager, start, pageLength , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
	        
            	
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
		
		#region cust_View_KcqKetQuaThanhToanThuLao_ThongKeSiSoSinhVien
		/// <summary>
		///	This method wrap the 'cust_View_KcqKetQuaThanhToanThuLao_ThongKeSiSoSinhVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public virtual IDataReader ThongKeSiSoSinhVien(System.String namHoc, System.String hocKy)
		{
			return ThongKeSiSoSinhVien( namHoc, hocKy, 0, defaultMaxRecords );
		}
	
		/// <summary>
		///	This method wrap the 'cust_View_KcqKetQuaThanhToanThuLao_ThongKeSiSoSinhVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public virtual IDataReader ThongKeSiSoSinhVien(System.String namHoc, System.String hocKy, int start, int pageLength)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("ThongKeSiSoSinhVien");
			
		
			IDataReader result = null; 
			TransactionManager transactionManager = null; 
			
			try
            {
				bool isBorrowedTransaction = ConnectionScope.Current.HasTransaction;				
				
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
                
				//Call Custom Procedure from Repository
				result = dataProvider.ViewKcqKetQuaThanhToanThuLaoProvider.ThongKeSiSoSinhVien(transactionManager, start, pageLength , namHoc, hocKy);
	        
            	
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
		
		#region cust_View_KcqKetQuaThanhToanThuLao_GetByMaGiangVienNamHocHocKyReader
		/// <summary>
		///	This method wrap the 'cust_View_KcqKetQuaThanhToanThuLao_GetByMaGiangVienNamHocHocKyReader' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="listMaGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public virtual IDataReader GetByMaGiangVienNamHocHocKyReader(System.String namHoc, System.String hocKy, System.String listMaGiangVien)
		{
			return GetByMaGiangVienNamHocHocKyReader( namHoc, hocKy, listMaGiangVien, 0, defaultMaxRecords );
		}
	
		/// <summary>
		///	This method wrap the 'cust_View_KcqKetQuaThanhToanThuLao_GetByMaGiangVienNamHocHocKyReader' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="listMaGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public virtual IDataReader GetByMaGiangVienNamHocHocKyReader(System.String namHoc, System.String hocKy, System.String listMaGiangVien, int start, int pageLength)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetByMaGiangVienNamHocHocKyReader");
			
		
			IDataReader result = null; 
			TransactionManager transactionManager = null; 
			
			try
            {
				bool isBorrowedTransaction = ConnectionScope.Current.HasTransaction;				
				
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
                
				//Call Custom Procedure from Repository
				result = dataProvider.ViewKcqKetQuaThanhToanThuLaoProvider.GetByMaGiangVienNamHocHocKyReader(transactionManager, start, pageLength , namHoc, hocKy, listMaGiangVien);
	        
            	
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



