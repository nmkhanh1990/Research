﻿#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using PMS.Entities;
using PMS.Data;

#endregion

namespace PMS.Data.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="ViewKetQuaThanhToanThuLaoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewKetQuaThanhToanThuLaoProviderBaseCore : EntityViewProviderBase<ViewKetQuaThanhToanThuLao>
	{
		#region Custom Methods
		
		
		#region cust_View_KetQuaThanhToanThuLao_GetByMaGiangVienNamHocHocKyLocDieuKien
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_GetByMaGiangVienNamHocHocKyLocDieuKien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="listMaGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="dieuKienLoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVienNamHocHocKyLocDieuKien(System.String namHoc, System.String hocKy, System.String listMaGiangVien, System.String dieuKienLoc)
		{
			return GetByMaGiangVienNamHocHocKyLocDieuKien(null, 0, int.MaxValue , namHoc, hocKy, listMaGiangVien, dieuKienLoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_GetByMaGiangVienNamHocHocKyLocDieuKien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="listMaGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="dieuKienLoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVienNamHocHocKyLocDieuKien(int start, int pageLength, System.String namHoc, System.String hocKy, System.String listMaGiangVien, System.String dieuKienLoc)
		{
			return GetByMaGiangVienNamHocHocKyLocDieuKien(null, start, pageLength , namHoc, hocKy, listMaGiangVien, dieuKienLoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_GetByMaGiangVienNamHocHocKyLocDieuKien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="listMaGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="dieuKienLoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVienNamHocHocKyLocDieuKien(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String listMaGiangVien, System.String dieuKienLoc)
		{
			return GetByMaGiangVienNamHocHocKyLocDieuKien(transactionManager, 0, int.MaxValue , namHoc, hocKy, listMaGiangVien, dieuKienLoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_GetByMaGiangVienNamHocHocKyLocDieuKien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="listMaGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="dieuKienLoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByMaGiangVienNamHocHocKyLocDieuKien(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.String listMaGiangVien, System.String dieuKienLoc);
		
		#endregion

		
		#region cust_View_KetQuaThanhToanThuLao_GetByMaGiangVienNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_GetByMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="listMaGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKetQuaThanhToanThuLao&gt;"/> instance.</returns>
		public VList<ViewKetQuaThanhToanThuLao> GetByMaGiangVienNamHocHocKy(System.String namHoc, System.String hocKy, System.String listMaGiangVien)
		{
			return GetByMaGiangVienNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy, listMaGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_GetByMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="listMaGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKetQuaThanhToanThuLao&gt;"/> instance.</returns>
		public VList<ViewKetQuaThanhToanThuLao> GetByMaGiangVienNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy, System.String listMaGiangVien)
		{
			return GetByMaGiangVienNamHocHocKy(null, start, pageLength , namHoc, hocKy, listMaGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_GetByMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="listMaGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewKetQuaThanhToanThuLao&gt;"/> instance.</returns>
		public VList<ViewKetQuaThanhToanThuLao> GetByMaGiangVienNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String listMaGiangVien)
		{
			return GetByMaGiangVienNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy, listMaGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_GetByMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="listMaGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKetQuaThanhToanThuLao&gt;"/> instance.</returns>
		public abstract VList<ViewKetQuaThanhToanThuLao> GetByMaGiangVienNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.String listMaGiangVien);
		
		#endregion

		
		#region cust_View_KetQuaThanhToanThuLao_GetByMaGiangVienNamHocHocKyReader
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_GetByMaGiangVienNamHocHocKyReader' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="listMaGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVienNamHocHocKyReader(System.String namHoc, System.String hocKy, System.String listMaGiangVien)
		{
			return GetByMaGiangVienNamHocHocKyReader(null, 0, int.MaxValue , namHoc, hocKy, listMaGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_GetByMaGiangVienNamHocHocKyReader' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="listMaGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVienNamHocHocKyReader(int start, int pageLength, System.String namHoc, System.String hocKy, System.String listMaGiangVien)
		{
			return GetByMaGiangVienNamHocHocKyReader(null, start, pageLength , namHoc, hocKy, listMaGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_GetByMaGiangVienNamHocHocKyReader' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="listMaGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVienNamHocHocKyReader(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String listMaGiangVien)
		{
			return GetByMaGiangVienNamHocHocKyReader(transactionManager, 0, int.MaxValue , namHoc, hocKy, listMaGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_GetByMaGiangVienNamHocHocKyReader' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="listMaGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByMaGiangVienNamHocHocKyReader(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.String listMaGiangVien);
		
		#endregion

		
		#region cust_View_KetQuaThanhToanThuLao_GetByMaGiangVien
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVien(System.String maQuanLy)
		{
			return GetByMaGiangVien(null, 0, int.MaxValue , maQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVien(int start, int pageLength, System.String maQuanLy)
		{
			return GetByMaGiangVien(null, start, pageLength , maQuanLy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVien(TransactionManager transactionManager, System.String maQuanLy)
		{
			return GetByMaGiangVien(transactionManager, 0, int.MaxValue , maQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByMaGiangVien(TransactionManager transactionManager, int start, int pageLength, System.String maQuanLy);
		
		#endregion

		
		#region cust_View_KetQuaThanhToanThuLao_ThongKeSiSoSinhVien
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_ThongKeSiSoSinhVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeSiSoSinhVien(System.String namHoc, System.String hocKy)
		{
			return ThongKeSiSoSinhVien(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_ThongKeSiSoSinhVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeSiSoSinhVien(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return ThongKeSiSoSinhVien(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_ThongKeSiSoSinhVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeSiSoSinhVien(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return ThongKeSiSoSinhVien(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_ThongKeSiSoSinhVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeSiSoSinhVien(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#region cust_View_KetQuaThanhToanThuLao_GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKetQuaThanhToanThuLao&gt;"/> instance.</returns>
		public VList<ViewKetQuaThanhToanThuLao> GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot(System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.String lanChot)
		{
			return GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot(null, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKetQuaThanhToanThuLao&gt;"/> instance.</returns>
		public VList<ViewKetQuaThanhToanThuLao> GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.String lanChot)
		{
			return GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot(null, start, pageLength , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewKetQuaThanhToanThuLao&gt;"/> instance.</returns>
		public VList<ViewKetQuaThanhToanThuLao> GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.String lanChot)
		{
			return GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKetQuaThanhToanThuLao&gt;"/> instance.</returns>
		public abstract VList<ViewKetQuaThanhToanThuLao> GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.String lanChot);
		
		#endregion

		
		#region cust_View_KetQuaThanhToanThuLao_GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot2
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot2' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot2(System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.String lanChot)
		{
			return GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot2(null, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot2' stored procedure. 
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
		public IDataReader GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot2(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.String lanChot)
		{
			return GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot2(null, start, pageLength , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot2' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot2(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.String lanChot)
		{
			return GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot2(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaThanhToanThuLao_GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot2' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot2(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.String lanChot);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewKetQuaThanhToanThuLao&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewKetQuaThanhToanThuLao&gt;"/></returns>
		protected static VList&lt;ViewKetQuaThanhToanThuLao&gt; Fill(DataSet dataSet, VList<ViewKetQuaThanhToanThuLao> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewKetQuaThanhToanThuLao>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewKetQuaThanhToanThuLao&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewKetQuaThanhToanThuLao>"/></returns>
		protected static VList&lt;ViewKetQuaThanhToanThuLao&gt; Fill(DataTable dataTable, VList<ViewKetQuaThanhToanThuLao> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewKetQuaThanhToanThuLao c = new ViewKetQuaThanhToanThuLao();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32?)row["MaGiangVien"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.MaHocHam = (Convert.IsDBNull(row["MaHocHam"]))?(int)0:(System.Int32?)row["MaHocHam"];
					c.TenHocHam = (Convert.IsDBNull(row["TenHocHam"]))?string.Empty:(System.String)row["TenHocHam"];
					c.MaHocVi = (Convert.IsDBNull(row["MaHocVi"]))?(int)0:(System.Int32?)row["MaHocVi"];
					c.TenHocVi = (Convert.IsDBNull(row["TenHocVi"]))?string.Empty:(System.String)row["TenHocVi"];
					c.MaLoaiGiangVien = (Convert.IsDBNull(row["MaLoaiGiangVien"]))?(int)0:(System.Int32?)row["MaLoaiGiangVien"];
					c.TenLoaiGiangVien = (Convert.IsDBNull(row["TenLoaiGiangVien"]))?string.Empty:(System.String)row["TenLoaiGiangVien"];
					c.MaDonVi = (Convert.IsDBNull(row["MaDonVi"]))?string.Empty:(System.String)row["MaDonVi"];
					c.TenDonVi = (Convert.IsDBNull(row["TenDonVi"]))?string.Empty:(System.String)row["TenDonVi"];
					c.Loai = (Convert.IsDBNull(row["Loai"]))?string.Empty:(System.String)row["Loai"];
					c.PhanLoai = (Convert.IsDBNull(row["PhanLoai"]))?string.Empty:(System.String)row["PhanLoai"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.LoaiHocPhan = (Convert.IsDBNull(row["LoaiHocPhan"]))?string.Empty:(System.String)row["LoaiHocPhan"];
					c.Nhom = (Convert.IsDBNull(row["Nhom"]))?string.Empty:(System.String)row["Nhom"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.LopClc = (Convert.IsDBNull(row["LopClc"]))?false:(System.Boolean?)row["LopClc"];
					c.SiSo = (Convert.IsDBNull(row["SiSo"]))?(int)0:(System.Int32?)row["SiSo"];
					c.TietThucDay = (Convert.IsDBNull(row["TietThucDay"]))?0.0m:(System.Decimal?)row["TietThucDay"];
					c.TietChuNhat = (Convert.IsDBNull(row["TietChuNhat"]))?0.0m:(System.Decimal?)row["TietChuNhat"];
					c.HeSoHocKy = (Convert.IsDBNull(row["HeSoHocKy"]))?0.0m:(System.Decimal?)row["HeSoHocKy"];
					c.HeSoLopDong = (Convert.IsDBNull(row["HeSoLopDong"]))?0.0m:(System.Decimal?)row["HeSoLopDong"];
					c.TietQuyDoi = (Convert.IsDBNull(row["TietQuyDoi"]))?0.0m:(System.Decimal?)row["TietQuyDoi"];
					c.DonGia = (Convert.IsDBNull(row["DonGia"]))?0.0m:(System.Decimal?)row["DonGia"];
					c.ThanhTien = (Convert.IsDBNull(row["ThanhTien"]))?0.0m:(System.Decimal?)row["ThanhTien"];
					c.LanChot = (Convert.IsDBNull(row["LanChot"]))?(int)0:(System.Int32?)row["LanChot"];
					c.NgayCapNhat = (Convert.IsDBNull(row["NgayCapNhat"]))?DateTime.MinValue:(System.DateTime?)row["NgayCapNhat"];
					c.AcceptChanges();
					rows.Add(c);
					pagelen -= 1;
				}
				recordnum += 1;
			}
			return rows;
		}
		*/	
						
		///<summary>
		/// Fill an <see cref="VList&lt;ViewKetQuaThanhToanThuLao&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewKetQuaThanhToanThuLao&gt;"/></returns>
		protected VList<ViewKetQuaThanhToanThuLao> Fill(IDataReader reader, VList<ViewKetQuaThanhToanThuLao> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewKetQuaThanhToanThuLao entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewKetQuaThanhToanThuLao>("ViewKetQuaThanhToanThuLao",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewKetQuaThanhToanThuLao();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.Int32?)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
					entity.MaQuanLy = (System.String)reader["MaQuanLy"];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.MaHocHam = reader.IsDBNull(reader.GetOrdinal("MaHocHam")) ? null : (System.Int32?)reader["MaHocHam"];
					//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?(int)0:(System.Int32?)reader["MaHocHam"];
					entity.TenHocHam = reader.IsDBNull(reader.GetOrdinal("TenHocHam")) ? null : (System.String)reader["TenHocHam"];
					//entity.TenHocHam = (Convert.IsDBNull(reader["TenHocHam"]))?string.Empty:(System.String)reader["TenHocHam"];
					entity.MaHocVi = reader.IsDBNull(reader.GetOrdinal("MaHocVi")) ? null : (System.Int32?)reader["MaHocVi"];
					//entity.MaHocVi = (Convert.IsDBNull(reader["MaHocVi"]))?(int)0:(System.Int32?)reader["MaHocVi"];
					entity.TenHocVi = reader.IsDBNull(reader.GetOrdinal("TenHocVi")) ? null : (System.String)reader["TenHocVi"];
					//entity.TenHocVi = (Convert.IsDBNull(reader["TenHocVi"]))?string.Empty:(System.String)reader["TenHocVi"];
					entity.MaLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("MaLoaiGiangVien")) ? null : (System.Int32?)reader["MaLoaiGiangVien"];
					//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
					entity.TenLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("TenLoaiGiangVien")) ? null : (System.String)reader["TenLoaiGiangVien"];
					//entity.TenLoaiGiangVien = (Convert.IsDBNull(reader["TenLoaiGiangVien"]))?string.Empty:(System.String)reader["TenLoaiGiangVien"];
					entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
					//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
					entity.TenDonVi = reader.IsDBNull(reader.GetOrdinal("TenDonVi")) ? null : (System.String)reader["TenDonVi"];
					//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
					entity.Loai = reader.IsDBNull(reader.GetOrdinal("Loai")) ? null : (System.String)reader["Loai"];
					//entity.Loai = (Convert.IsDBNull(reader["Loai"]))?string.Empty:(System.String)reader["Loai"];
					entity.PhanLoai = reader.IsDBNull(reader.GetOrdinal("PhanLoai")) ? null : (System.String)reader["PhanLoai"];
					//entity.PhanLoai = (Convert.IsDBNull(reader["PhanLoai"]))?string.Empty:(System.String)reader["PhanLoai"];
					entity.MaMonHoc = reader.IsDBNull(reader.GetOrdinal("MaMonHoc")) ? null : (System.String)reader["MaMonHoc"];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = reader.IsDBNull(reader.GetOrdinal("TenMonHoc")) ? null : (System.String)reader["TenMonHoc"];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.LoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("LoaiHocPhan")) ? null : (System.String)reader["LoaiHocPhan"];
					//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
					entity.Nhom = reader.IsDBNull(reader.GetOrdinal("Nhom")) ? null : (System.String)reader["Nhom"];
					//entity.Nhom = (Convert.IsDBNull(reader["Nhom"]))?string.Empty:(System.String)reader["Nhom"];
					entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.LopClc = reader.IsDBNull(reader.GetOrdinal("LopClc")) ? null : (System.Boolean?)reader["LopClc"];
					//entity.LopClc = (Convert.IsDBNull(reader["LopClc"]))?false:(System.Boolean?)reader["LopClc"];
					entity.SiSo = reader.IsDBNull(reader.GetOrdinal("SiSo")) ? null : (System.Int32?)reader["SiSo"];
					//entity.SiSo = (Convert.IsDBNull(reader["SiSo"]))?(int)0:(System.Int32?)reader["SiSo"];
					entity.TietThucDay = reader.IsDBNull(reader.GetOrdinal("TietThucDay")) ? null : (System.Decimal?)reader["TietThucDay"];
					//entity.TietThucDay = (Convert.IsDBNull(reader["TietThucDay"]))?0.0m:(System.Decimal?)reader["TietThucDay"];
					entity.TietChuNhat = reader.IsDBNull(reader.GetOrdinal("TietChuNhat")) ? null : (System.Decimal?)reader["TietChuNhat"];
					//entity.TietChuNhat = (Convert.IsDBNull(reader["TietChuNhat"]))?0.0m:(System.Decimal?)reader["TietChuNhat"];
					entity.HeSoHocKy = reader.IsDBNull(reader.GetOrdinal("HeSoHocKy")) ? null : (System.Decimal?)reader["HeSoHocKy"];
					//entity.HeSoHocKy = (Convert.IsDBNull(reader["HeSoHocKy"]))?0.0m:(System.Decimal?)reader["HeSoHocKy"];
					entity.HeSoLopDong = reader.IsDBNull(reader.GetOrdinal("HeSoLopDong")) ? null : (System.Decimal?)reader["HeSoLopDong"];
					//entity.HeSoLopDong = (Convert.IsDBNull(reader["HeSoLopDong"]))?0.0m:(System.Decimal?)reader["HeSoLopDong"];
					entity.TietQuyDoi = reader.IsDBNull(reader.GetOrdinal("TietQuyDoi")) ? null : (System.Decimal?)reader["TietQuyDoi"];
					//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
					entity.DonGia = reader.IsDBNull(reader.GetOrdinal("DonGia")) ? null : (System.Decimal?)reader["DonGia"];
					//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal?)reader["DonGia"];
					entity.ThanhTien = reader.IsDBNull(reader.GetOrdinal("ThanhTien")) ? null : (System.Decimal?)reader["ThanhTien"];
					//entity.ThanhTien = (Convert.IsDBNull(reader["ThanhTien"]))?0.0m:(System.Decimal?)reader["ThanhTien"];
					entity.LanChot = reader.IsDBNull(reader.GetOrdinal("LanChot")) ? null : (System.Int32?)reader["LanChot"];
					//entity.LanChot = (Convert.IsDBNull(reader["LanChot"]))?(int)0:(System.Int32?)reader["LanChot"];
					entity.NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (System.DateTime?)reader["NgayCapNhat"];
					//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?DateTime.MinValue:(System.DateTime?)reader["NgayCapNhat"];
					entity.AcceptChanges();
					entity.SuppressEntityEvents = false;
					
					rows.Add(entity);
					pageLength -= 1;
				}
				recordnum += 1;
			}
			return rows;
		}
		
		
		/// <summary>
		/// Refreshes the <see cref="ViewKetQuaThanhToanThuLao"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKetQuaThanhToanThuLao"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewKetQuaThanhToanThuLao entity)
		{
			reader.Read();
			entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.Int32?)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
			entity.MaQuanLy = (System.String)reader["MaQuanLy"];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.MaHocHam = reader.IsDBNull(reader.GetOrdinal("MaHocHam")) ? null : (System.Int32?)reader["MaHocHam"];
			//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?(int)0:(System.Int32?)reader["MaHocHam"];
			entity.TenHocHam = reader.IsDBNull(reader.GetOrdinal("TenHocHam")) ? null : (System.String)reader["TenHocHam"];
			//entity.TenHocHam = (Convert.IsDBNull(reader["TenHocHam"]))?string.Empty:(System.String)reader["TenHocHam"];
			entity.MaHocVi = reader.IsDBNull(reader.GetOrdinal("MaHocVi")) ? null : (System.Int32?)reader["MaHocVi"];
			//entity.MaHocVi = (Convert.IsDBNull(reader["MaHocVi"]))?(int)0:(System.Int32?)reader["MaHocVi"];
			entity.TenHocVi = reader.IsDBNull(reader.GetOrdinal("TenHocVi")) ? null : (System.String)reader["TenHocVi"];
			//entity.TenHocVi = (Convert.IsDBNull(reader["TenHocVi"]))?string.Empty:(System.String)reader["TenHocVi"];
			entity.MaLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("MaLoaiGiangVien")) ? null : (System.Int32?)reader["MaLoaiGiangVien"];
			//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
			entity.TenLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("TenLoaiGiangVien")) ? null : (System.String)reader["TenLoaiGiangVien"];
			//entity.TenLoaiGiangVien = (Convert.IsDBNull(reader["TenLoaiGiangVien"]))?string.Empty:(System.String)reader["TenLoaiGiangVien"];
			entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
			//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
			entity.TenDonVi = reader.IsDBNull(reader.GetOrdinal("TenDonVi")) ? null : (System.String)reader["TenDonVi"];
			//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
			entity.Loai = reader.IsDBNull(reader.GetOrdinal("Loai")) ? null : (System.String)reader["Loai"];
			//entity.Loai = (Convert.IsDBNull(reader["Loai"]))?string.Empty:(System.String)reader["Loai"];
			entity.PhanLoai = reader.IsDBNull(reader.GetOrdinal("PhanLoai")) ? null : (System.String)reader["PhanLoai"];
			//entity.PhanLoai = (Convert.IsDBNull(reader["PhanLoai"]))?string.Empty:(System.String)reader["PhanLoai"];
			entity.MaMonHoc = reader.IsDBNull(reader.GetOrdinal("MaMonHoc")) ? null : (System.String)reader["MaMonHoc"];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = reader.IsDBNull(reader.GetOrdinal("TenMonHoc")) ? null : (System.String)reader["TenMonHoc"];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.LoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("LoaiHocPhan")) ? null : (System.String)reader["LoaiHocPhan"];
			//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
			entity.Nhom = reader.IsDBNull(reader.GetOrdinal("Nhom")) ? null : (System.String)reader["Nhom"];
			//entity.Nhom = (Convert.IsDBNull(reader["Nhom"]))?string.Empty:(System.String)reader["Nhom"];
			entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.LopClc = reader.IsDBNull(reader.GetOrdinal("LopClc")) ? null : (System.Boolean?)reader["LopClc"];
			//entity.LopClc = (Convert.IsDBNull(reader["LopClc"]))?false:(System.Boolean?)reader["LopClc"];
			entity.SiSo = reader.IsDBNull(reader.GetOrdinal("SiSo")) ? null : (System.Int32?)reader["SiSo"];
			//entity.SiSo = (Convert.IsDBNull(reader["SiSo"]))?(int)0:(System.Int32?)reader["SiSo"];
			entity.TietThucDay = reader.IsDBNull(reader.GetOrdinal("TietThucDay")) ? null : (System.Decimal?)reader["TietThucDay"];
			//entity.TietThucDay = (Convert.IsDBNull(reader["TietThucDay"]))?0.0m:(System.Decimal?)reader["TietThucDay"];
			entity.TietChuNhat = reader.IsDBNull(reader.GetOrdinal("TietChuNhat")) ? null : (System.Decimal?)reader["TietChuNhat"];
			//entity.TietChuNhat = (Convert.IsDBNull(reader["TietChuNhat"]))?0.0m:(System.Decimal?)reader["TietChuNhat"];
			entity.HeSoHocKy = reader.IsDBNull(reader.GetOrdinal("HeSoHocKy")) ? null : (System.Decimal?)reader["HeSoHocKy"];
			//entity.HeSoHocKy = (Convert.IsDBNull(reader["HeSoHocKy"]))?0.0m:(System.Decimal?)reader["HeSoHocKy"];
			entity.HeSoLopDong = reader.IsDBNull(reader.GetOrdinal("HeSoLopDong")) ? null : (System.Decimal?)reader["HeSoLopDong"];
			//entity.HeSoLopDong = (Convert.IsDBNull(reader["HeSoLopDong"]))?0.0m:(System.Decimal?)reader["HeSoLopDong"];
			entity.TietQuyDoi = reader.IsDBNull(reader.GetOrdinal("TietQuyDoi")) ? null : (System.Decimal?)reader["TietQuyDoi"];
			//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
			entity.DonGia = reader.IsDBNull(reader.GetOrdinal("DonGia")) ? null : (System.Decimal?)reader["DonGia"];
			//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal?)reader["DonGia"];
			entity.ThanhTien = reader.IsDBNull(reader.GetOrdinal("ThanhTien")) ? null : (System.Decimal?)reader["ThanhTien"];
			//entity.ThanhTien = (Convert.IsDBNull(reader["ThanhTien"]))?0.0m:(System.Decimal?)reader["ThanhTien"];
			entity.LanChot = reader.IsDBNull(reader.GetOrdinal("LanChot")) ? null : (System.Int32?)reader["LanChot"];
			//entity.LanChot = (Convert.IsDBNull(reader["LanChot"]))?(int)0:(System.Int32?)reader["LanChot"];
			entity.NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (System.DateTime?)reader["NgayCapNhat"];
			//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?DateTime.MinValue:(System.DateTime?)reader["NgayCapNhat"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewKetQuaThanhToanThuLao"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKetQuaThanhToanThuLao"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewKetQuaThanhToanThuLao entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32?)dataRow["MaGiangVien"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.MaHocHam = (Convert.IsDBNull(dataRow["MaHocHam"]))?(int)0:(System.Int32?)dataRow["MaHocHam"];
			entity.TenHocHam = (Convert.IsDBNull(dataRow["TenHocHam"]))?string.Empty:(System.String)dataRow["TenHocHam"];
			entity.MaHocVi = (Convert.IsDBNull(dataRow["MaHocVi"]))?(int)0:(System.Int32?)dataRow["MaHocVi"];
			entity.TenHocVi = (Convert.IsDBNull(dataRow["TenHocVi"]))?string.Empty:(System.String)dataRow["TenHocVi"];
			entity.MaLoaiGiangVien = (Convert.IsDBNull(dataRow["MaLoaiGiangVien"]))?(int)0:(System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.TenLoaiGiangVien = (Convert.IsDBNull(dataRow["TenLoaiGiangVien"]))?string.Empty:(System.String)dataRow["TenLoaiGiangVien"];
			entity.MaDonVi = (Convert.IsDBNull(dataRow["MaDonVi"]))?string.Empty:(System.String)dataRow["MaDonVi"];
			entity.TenDonVi = (Convert.IsDBNull(dataRow["TenDonVi"]))?string.Empty:(System.String)dataRow["TenDonVi"];
			entity.Loai = (Convert.IsDBNull(dataRow["Loai"]))?string.Empty:(System.String)dataRow["Loai"];
			entity.PhanLoai = (Convert.IsDBNull(dataRow["PhanLoai"]))?string.Empty:(System.String)dataRow["PhanLoai"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.LoaiHocPhan = (Convert.IsDBNull(dataRow["LoaiHocPhan"]))?string.Empty:(System.String)dataRow["LoaiHocPhan"];
			entity.Nhom = (Convert.IsDBNull(dataRow["Nhom"]))?string.Empty:(System.String)dataRow["Nhom"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.LopClc = (Convert.IsDBNull(dataRow["LopClc"]))?false:(System.Boolean?)dataRow["LopClc"];
			entity.SiSo = (Convert.IsDBNull(dataRow["SiSo"]))?(int)0:(System.Int32?)dataRow["SiSo"];
			entity.TietThucDay = (Convert.IsDBNull(dataRow["TietThucDay"]))?0.0m:(System.Decimal?)dataRow["TietThucDay"];
			entity.TietChuNhat = (Convert.IsDBNull(dataRow["TietChuNhat"]))?0.0m:(System.Decimal?)dataRow["TietChuNhat"];
			entity.HeSoHocKy = (Convert.IsDBNull(dataRow["HeSoHocKy"]))?0.0m:(System.Decimal?)dataRow["HeSoHocKy"];
			entity.HeSoLopDong = (Convert.IsDBNull(dataRow["HeSoLopDong"]))?0.0m:(System.Decimal?)dataRow["HeSoLopDong"];
			entity.TietQuyDoi = (Convert.IsDBNull(dataRow["TietQuyDoi"]))?0.0m:(System.Decimal?)dataRow["TietQuyDoi"];
			entity.DonGia = (Convert.IsDBNull(dataRow["DonGia"]))?0.0m:(System.Decimal?)dataRow["DonGia"];
			entity.ThanhTien = (Convert.IsDBNull(dataRow["ThanhTien"]))?0.0m:(System.Decimal?)dataRow["ThanhTien"];
			entity.LanChot = (Convert.IsDBNull(dataRow["LanChot"]))?(int)0:(System.Int32?)dataRow["LanChot"];
			entity.NgayCapNhat = (Convert.IsDBNull(dataRow["NgayCapNhat"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayCapNhat"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewKetQuaThanhToanThuLaoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKetQuaThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKetQuaThanhToanThuLaoFilterBuilder : SqlFilterBuilder<ViewKetQuaThanhToanThuLaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaThanhToanThuLaoFilterBuilder class.
		/// </summary>
		public ViewKetQuaThanhToanThuLaoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaThanhToanThuLaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKetQuaThanhToanThuLaoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaThanhToanThuLaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKetQuaThanhToanThuLaoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKetQuaThanhToanThuLaoFilterBuilder

	#region ViewKetQuaThanhToanThuLaoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKetQuaThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKetQuaThanhToanThuLaoParameterBuilder : ParameterizedSqlFilterBuilder<ViewKetQuaThanhToanThuLaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaThanhToanThuLaoParameterBuilder class.
		/// </summary>
		public ViewKetQuaThanhToanThuLaoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaThanhToanThuLaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKetQuaThanhToanThuLaoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaThanhToanThuLaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKetQuaThanhToanThuLaoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKetQuaThanhToanThuLaoParameterBuilder
	
	#region ViewKetQuaThanhToanThuLaoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKetQuaThanhToanThuLao"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewKetQuaThanhToanThuLaoSortBuilder : SqlSortBuilder<ViewKetQuaThanhToanThuLaoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaThanhToanThuLaoSqlSortBuilder class.
		/// </summary>
		public ViewKetQuaThanhToanThuLaoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewKetQuaThanhToanThuLaoSortBuilder

} // end namespace