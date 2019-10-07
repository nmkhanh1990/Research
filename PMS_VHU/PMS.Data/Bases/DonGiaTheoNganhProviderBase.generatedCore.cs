#region Using directives

using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;

using PMS.Entities;
using PMS.Data;

#endregion

namespace PMS.Data.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="DonGiaTheoNganhProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class DonGiaTheoNganhProviderBaseCore : EntityProviderBase<PMS.Entities.DonGiaTheoNganh, PMS.Entities.DonGiaTheoNganhKey>
	{		
		#region Get from Many To Many Relationship Functions
		#endregion	
		
		#region Delete Methods

		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to delete.</param>
		/// <returns>Returns true if operation suceeded.</returns>
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.DonGiaTheoNganhKey key)
		{
			return Delete(transactionManager, key.Id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _id)
		{
			return Delete(null, _id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _id);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_HocHam key.
		///		FK_DonGiaTheoNganh_HocHam Description: 
		/// </summary>
		/// <param name="_maHocHam"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		public TList<DonGiaTheoNganh> GetByMaHocHam(System.Int32? _maHocHam)
		{
			int count = -1;
			return GetByMaHocHam(_maHocHam, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_HocHam key.
		///		FK_DonGiaTheoNganh_HocHam Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocHam"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		/// <remarks></remarks>
		public TList<DonGiaTheoNganh> GetByMaHocHam(TransactionManager transactionManager, System.Int32? _maHocHam)
		{
			int count = -1;
			return GetByMaHocHam(transactionManager, _maHocHam, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_HocHam key.
		///		FK_DonGiaTheoNganh_HocHam Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocHam"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		public TList<DonGiaTheoNganh> GetByMaHocHam(TransactionManager transactionManager, System.Int32? _maHocHam, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHocHam(transactionManager, _maHocHam, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_HocHam key.
		///		fkDonGiaTheoNganhHocHam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHocHam"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		public TList<DonGiaTheoNganh> GetByMaHocHam(System.Int32? _maHocHam, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaHocHam(null, _maHocHam, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_HocHam key.
		///		fkDonGiaTheoNganhHocHam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHocHam"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		public TList<DonGiaTheoNganh> GetByMaHocHam(System.Int32? _maHocHam, int start, int pageLength,out int count)
		{
			return GetByMaHocHam(null, _maHocHam, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_HocHam key.
		///		FK_DonGiaTheoNganh_HocHam Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocHam"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		public abstract TList<DonGiaTheoNganh> GetByMaHocHam(TransactionManager transactionManager, System.Int32? _maHocHam, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_HocVi key.
		///		FK_DonGiaTheoNganh_HocVi Description: 
		/// </summary>
		/// <param name="_maHocVi"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		public TList<DonGiaTheoNganh> GetByMaHocVi(System.Int32? _maHocVi)
		{
			int count = -1;
			return GetByMaHocVi(_maHocVi, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_HocVi key.
		///		FK_DonGiaTheoNganh_HocVi Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocVi"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		/// <remarks></remarks>
		public TList<DonGiaTheoNganh> GetByMaHocVi(TransactionManager transactionManager, System.Int32? _maHocVi)
		{
			int count = -1;
			return GetByMaHocVi(transactionManager, _maHocVi, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_HocVi key.
		///		FK_DonGiaTheoNganh_HocVi Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocVi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		public TList<DonGiaTheoNganh> GetByMaHocVi(TransactionManager transactionManager, System.Int32? _maHocVi, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHocVi(transactionManager, _maHocVi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_HocVi key.
		///		fkDonGiaTheoNganhHocVi Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHocVi"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		public TList<DonGiaTheoNganh> GetByMaHocVi(System.Int32? _maHocVi, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaHocVi(null, _maHocVi, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_HocVi key.
		///		fkDonGiaTheoNganhHocVi Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHocVi"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		public TList<DonGiaTheoNganh> GetByMaHocVi(System.Int32? _maHocVi, int start, int pageLength,out int count)
		{
			return GetByMaHocVi(null, _maHocVi, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_HocVi key.
		///		FK_DonGiaTheoNganh_HocVi Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocVi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		public abstract TList<DonGiaTheoNganh> GetByMaHocVi(TransactionManager transactionManager, System.Int32? _maHocVi, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_LoaiGiangVien key.
		///		FK_DonGiaTheoNganh_LoaiGiangVien Description: 
		/// </summary>
		/// <param name="_maLoaiGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		public TList<DonGiaTheoNganh> GetByMaLoaiGiangVien(System.Int32? _maLoaiGiangVien)
		{
			int count = -1;
			return GetByMaLoaiGiangVien(_maLoaiGiangVien, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_LoaiGiangVien key.
		///		FK_DonGiaTheoNganh_LoaiGiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		/// <remarks></remarks>
		public TList<DonGiaTheoNganh> GetByMaLoaiGiangVien(TransactionManager transactionManager, System.Int32? _maLoaiGiangVien)
		{
			int count = -1;
			return GetByMaLoaiGiangVien(transactionManager, _maLoaiGiangVien, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_LoaiGiangVien key.
		///		FK_DonGiaTheoNganh_LoaiGiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		public TList<DonGiaTheoNganh> GetByMaLoaiGiangVien(TransactionManager transactionManager, System.Int32? _maLoaiGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiGiangVien(transactionManager, _maLoaiGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_LoaiGiangVien key.
		///		fkDonGiaTheoNganhLoaiGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		public TList<DonGiaTheoNganh> GetByMaLoaiGiangVien(System.Int32? _maLoaiGiangVien, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaLoaiGiangVien(null, _maLoaiGiangVien, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_LoaiGiangVien key.
		///		fkDonGiaTheoNganhLoaiGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		public TList<DonGiaTheoNganh> GetByMaLoaiGiangVien(System.Int32? _maLoaiGiangVien, int start, int pageLength,out int count)
		{
			return GetByMaLoaiGiangVien(null, _maLoaiGiangVien, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_LoaiGiangVien key.
		///		FK_DonGiaTheoNganh_LoaiGiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		public abstract TList<DonGiaTheoNganh> GetByMaLoaiGiangVien(TransactionManager transactionManager, System.Int32? _maLoaiGiangVien, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_NgonNguGiangDay key.
		///		FK_DonGiaTheoNganh_NgonNguGiangDay Description: 
		/// </summary>
		/// <param name="_ngonNguGiangDay"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		public TList<DonGiaTheoNganh> GetByNgonNguGiangDay(System.String _ngonNguGiangDay)
		{
			int count = -1;
			return GetByNgonNguGiangDay(_ngonNguGiangDay, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_NgonNguGiangDay key.
		///		FK_DonGiaTheoNganh_NgonNguGiangDay Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ngonNguGiangDay"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		/// <remarks></remarks>
		public TList<DonGiaTheoNganh> GetByNgonNguGiangDay(TransactionManager transactionManager, System.String _ngonNguGiangDay)
		{
			int count = -1;
			return GetByNgonNguGiangDay(transactionManager, _ngonNguGiangDay, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_NgonNguGiangDay key.
		///		FK_DonGiaTheoNganh_NgonNguGiangDay Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ngonNguGiangDay"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		public TList<DonGiaTheoNganh> GetByNgonNguGiangDay(TransactionManager transactionManager, System.String _ngonNguGiangDay, int start, int pageLength)
		{
			int count = -1;
			return GetByNgonNguGiangDay(transactionManager, _ngonNguGiangDay, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_NgonNguGiangDay key.
		///		fkDonGiaTheoNganhNgonNguGiangDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ngonNguGiangDay"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		public TList<DonGiaTheoNganh> GetByNgonNguGiangDay(System.String _ngonNguGiangDay, int start, int pageLength)
		{
			int count =  -1;
			return GetByNgonNguGiangDay(null, _ngonNguGiangDay, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_NgonNguGiangDay key.
		///		fkDonGiaTheoNganhNgonNguGiangDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ngonNguGiangDay"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		public TList<DonGiaTheoNganh> GetByNgonNguGiangDay(System.String _ngonNguGiangDay, int start, int pageLength,out int count)
		{
			return GetByNgonNguGiangDay(null, _ngonNguGiangDay, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_NgonNguGiangDay key.
		///		FK_DonGiaTheoNganh_NgonNguGiangDay Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ngonNguGiangDay"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		public abstract TList<DonGiaTheoNganh> GetByNgonNguGiangDay(TransactionManager transactionManager, System.String _ngonNguGiangDay, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_NMH key.
		///		FK_DonGiaTheoNganh_NMH Description: 
		/// </summary>
		/// <param name="_maNhomMon"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		public TList<DonGiaTheoNganh> GetByMaNhomMon(System.Int32? _maNhomMon)
		{
			int count = -1;
			return GetByMaNhomMon(_maNhomMon, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_NMH key.
		///		FK_DonGiaTheoNganh_NMH Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomMon"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		/// <remarks></remarks>
		public TList<DonGiaTheoNganh> GetByMaNhomMon(TransactionManager transactionManager, System.Int32? _maNhomMon)
		{
			int count = -1;
			return GetByMaNhomMon(transactionManager, _maNhomMon, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_NMH key.
		///		FK_DonGiaTheoNganh_NMH Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomMon"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		public TList<DonGiaTheoNganh> GetByMaNhomMon(TransactionManager transactionManager, System.Int32? _maNhomMon, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNhomMon(transactionManager, _maNhomMon, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_NMH key.
		///		fkDonGiaTheoNganhNmh Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maNhomMon"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		public TList<DonGiaTheoNganh> GetByMaNhomMon(System.Int32? _maNhomMon, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaNhomMon(null, _maNhomMon, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_NMH key.
		///		fkDonGiaTheoNganhNmh Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maNhomMon"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		public TList<DonGiaTheoNganh> GetByMaNhomMon(System.Int32? _maNhomMon, int start, int pageLength,out int count)
		{
			return GetByMaNhomMon(null, _maNhomMon, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaTheoNganh_NMH key.
		///		FK_DonGiaTheoNganh_NMH Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomMon"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaTheoNganh objects.</returns>
		public abstract TList<DonGiaTheoNganh> GetByMaNhomMon(TransactionManager transactionManager, System.Int32? _maNhomMon, int start, int pageLength, out int count);
		
		#endregion

		#region Get By Index Functions
		
		/// <summary>
		/// 	Gets a row from the DataSource based on its primary key.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to retrieve.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <returns>Returns an instance of the Entity class.</returns>
		public override PMS.Entities.DonGiaTheoNganh Get(TransactionManager transactionManager, PMS.Entities.DonGiaTheoNganhKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_DonGiaTheoNganh index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaTheoNganh"/> class.</returns>
		public PMS.Entities.DonGiaTheoNganh GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGiaTheoNganh index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaTheoNganh"/> class.</returns>
		public PMS.Entities.DonGiaTheoNganh GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGiaTheoNganh index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaTheoNganh"/> class.</returns>
		public PMS.Entities.DonGiaTheoNganh GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGiaTheoNganh index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaTheoNganh"/> class.</returns>
		public PMS.Entities.DonGiaTheoNganh GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGiaTheoNganh index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaTheoNganh"/> class.</returns>
		public PMS.Entities.DonGiaTheoNganh GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGiaTheoNganh index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaTheoNganh"/> class.</returns>
		public abstract PMS.Entities.DonGiaTheoNganh GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;DonGiaTheoNganh&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;DonGiaTheoNganh&gt;"/></returns>
		public static TList<DonGiaTheoNganh> Fill(IDataReader reader, TList<DonGiaTheoNganh> rows, int start, int pageLength)
		{
			NetTiersProvider currentProvider = DataRepository.Provider;
            bool useEntityFactory = currentProvider.UseEntityFactory;
            bool enableEntityTracking = currentProvider.EnableEntityTracking;
            LoadPolicy currentLoadPolicy = currentProvider.CurrentLoadPolicy;
			Type entityCreationFactoryType = currentProvider.EntityCreationalFactoryType;
			
			// advance to the starting row
			for (int i = 0; i < start; i++)
			{
				if (!reader.Read())
				return rows; // not enough rows, just return
			}
			for (int i = 0; i < pageLength; i++)
			{
				if (!reader.Read())
					break; // we are done
					
				string key = null;
				
				PMS.Entities.DonGiaTheoNganh c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("DonGiaTheoNganh")
					.Append("|").Append((System.Int32)reader[((int)DonGiaTheoNganhColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<DonGiaTheoNganh>(
					key.ToString(), // EntityTrackingKey
					"DonGiaTheoNganh",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.DonGiaTheoNganh();
				}
				
				if (!enableEntityTracking ||
					c.EntityState == EntityState.Added ||
					(enableEntityTracking &&
					
						(
							(currentLoadPolicy == LoadPolicy.PreserveChanges && c.EntityState == EntityState.Unchanged) ||
							(currentLoadPolicy == LoadPolicy.DiscardChanges && c.EntityState != EntityState.Unchanged)
						)
					))
				{
					c.SuppressEntityEvents = true;
					c.Id = (System.Int32)reader[(DonGiaTheoNganhColumn.Id.ToString())];
					c.MaQuanLy = (reader[DonGiaTheoNganhColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaTheoNganhColumn.MaQuanLy.ToString())];
					c.MaLoaiGiangVien = (reader[DonGiaTheoNganhColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DonGiaTheoNganhColumn.MaLoaiGiangVien.ToString())];
					c.MaHocHam = (reader[DonGiaTheoNganhColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DonGiaTheoNganhColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[DonGiaTheoNganhColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DonGiaTheoNganhColumn.MaHocVi.ToString())];
					c.DonGiaCh = (reader[DonGiaTheoNganhColumn.DonGiaCh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaTheoNganhColumn.DonGiaCh.ToString())];
					c.DonGiaTgkc = (reader[DonGiaTheoNganhColumn.DonGiaTgkc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaTheoNganhColumn.DonGiaTgkc.ToString())];
					c.DonGiaTgc = (reader[DonGiaTheoNganhColumn.DonGiaTgc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaTheoNganhColumn.DonGiaTgc.ToString())];
					c.DonGiaHocPhan = (reader[DonGiaTheoNganhColumn.DonGiaHocPhan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaTheoNganhColumn.DonGiaHocPhan.ToString())];
					c.DonGiaLt = (reader[DonGiaTheoNganhColumn.DonGiaLt.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaTheoNganhColumn.DonGiaLt.ToString())];
					c.DonGiaTh = (reader[DonGiaTheoNganhColumn.DonGiaTh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaTheoNganhColumn.DonGiaTh.ToString())];
					c.MaDonGiaNhomNganh = (reader[DonGiaTheoNganhColumn.MaDonGiaNhomNganh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DonGiaTheoNganhColumn.MaDonGiaNhomNganh.ToString())];
					c.NgayCapNhat = (reader[DonGiaTheoNganhColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(DonGiaTheoNganhColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[DonGiaTheoNganhColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaTheoNganhColumn.NguoiCapNhat.ToString())];
					c.DonGiaClc = (reader[DonGiaTheoNganhColumn.DonGiaClc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaTheoNganhColumn.DonGiaClc.ToString())];
					c.HeSoQuyDoiChatLuong = (reader[DonGiaTheoNganhColumn.HeSoQuyDoiChatLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaTheoNganhColumn.HeSoQuyDoiChatLuong.ToString())];
					c.DonGiaTrongChuan = (reader[DonGiaTheoNganhColumn.DonGiaTrongChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaTheoNganhColumn.DonGiaTrongChuan.ToString())];
					c.DonGiaNgoaiChuan = (reader[DonGiaTheoNganhColumn.DonGiaNgoaiChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaTheoNganhColumn.DonGiaNgoaiChuan.ToString())];
					c.MaHinhThucDaoTao = (reader[DonGiaTheoNganhColumn.MaHinhThucDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaTheoNganhColumn.MaHinhThucDaoTao.ToString())];
					c.BacDaoTao = (reader[DonGiaTheoNganhColumn.BacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaTheoNganhColumn.BacDaoTao.ToString())];
					c.NgonNguGiangDay = (reader[DonGiaTheoNganhColumn.NgonNguGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaTheoNganhColumn.NgonNguGiangDay.ToString())];
					c.NamHoc = (reader[DonGiaTheoNganhColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaTheoNganhColumn.NamHoc.ToString())];
					c.HocKy = (reader[DonGiaTheoNganhColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaTheoNganhColumn.HocKy.ToString())];
					c.MaNhomMon = (reader[DonGiaTheoNganhColumn.MaNhomMon.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DonGiaTheoNganhColumn.MaNhomMon.ToString())];
					c.NhomMonHoc = (reader[DonGiaTheoNganhColumn.NhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaTheoNganhColumn.NhomMonHoc.ToString())];
					c.DonGiaNgoaiNgu = (reader[DonGiaTheoNganhColumn.DonGiaNgoaiNgu.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaTheoNganhColumn.DonGiaNgoaiNgu.ToString())];
					c.DonGiaDoAnClc = (reader[DonGiaTheoNganhColumn.DonGiaDoAnClc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaTheoNganhColumn.DonGiaDoAnClc.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DonGiaTheoNganh"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DonGiaTheoNganh"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.DonGiaTheoNganh entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(DonGiaTheoNganhColumn.Id.ToString())];
			entity.MaQuanLy = (reader[DonGiaTheoNganhColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaTheoNganhColumn.MaQuanLy.ToString())];
			entity.MaLoaiGiangVien = (reader[DonGiaTheoNganhColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DonGiaTheoNganhColumn.MaLoaiGiangVien.ToString())];
			entity.MaHocHam = (reader[DonGiaTheoNganhColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DonGiaTheoNganhColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[DonGiaTheoNganhColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DonGiaTheoNganhColumn.MaHocVi.ToString())];
			entity.DonGiaCh = (reader[DonGiaTheoNganhColumn.DonGiaCh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaTheoNganhColumn.DonGiaCh.ToString())];
			entity.DonGiaTgkc = (reader[DonGiaTheoNganhColumn.DonGiaTgkc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaTheoNganhColumn.DonGiaTgkc.ToString())];
			entity.DonGiaTgc = (reader[DonGiaTheoNganhColumn.DonGiaTgc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaTheoNganhColumn.DonGiaTgc.ToString())];
			entity.DonGiaHocPhan = (reader[DonGiaTheoNganhColumn.DonGiaHocPhan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaTheoNganhColumn.DonGiaHocPhan.ToString())];
			entity.DonGiaLt = (reader[DonGiaTheoNganhColumn.DonGiaLt.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaTheoNganhColumn.DonGiaLt.ToString())];
			entity.DonGiaTh = (reader[DonGiaTheoNganhColumn.DonGiaTh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaTheoNganhColumn.DonGiaTh.ToString())];
			entity.MaDonGiaNhomNganh = (reader[DonGiaTheoNganhColumn.MaDonGiaNhomNganh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DonGiaTheoNganhColumn.MaDonGiaNhomNganh.ToString())];
			entity.NgayCapNhat = (reader[DonGiaTheoNganhColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(DonGiaTheoNganhColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[DonGiaTheoNganhColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaTheoNganhColumn.NguoiCapNhat.ToString())];
			entity.DonGiaClc = (reader[DonGiaTheoNganhColumn.DonGiaClc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaTheoNganhColumn.DonGiaClc.ToString())];
			entity.HeSoQuyDoiChatLuong = (reader[DonGiaTheoNganhColumn.HeSoQuyDoiChatLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaTheoNganhColumn.HeSoQuyDoiChatLuong.ToString())];
			entity.DonGiaTrongChuan = (reader[DonGiaTheoNganhColumn.DonGiaTrongChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaTheoNganhColumn.DonGiaTrongChuan.ToString())];
			entity.DonGiaNgoaiChuan = (reader[DonGiaTheoNganhColumn.DonGiaNgoaiChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaTheoNganhColumn.DonGiaNgoaiChuan.ToString())];
			entity.MaHinhThucDaoTao = (reader[DonGiaTheoNganhColumn.MaHinhThucDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaTheoNganhColumn.MaHinhThucDaoTao.ToString())];
			entity.BacDaoTao = (reader[DonGiaTheoNganhColumn.BacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaTheoNganhColumn.BacDaoTao.ToString())];
			entity.NgonNguGiangDay = (reader[DonGiaTheoNganhColumn.NgonNguGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaTheoNganhColumn.NgonNguGiangDay.ToString())];
			entity.NamHoc = (reader[DonGiaTheoNganhColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaTheoNganhColumn.NamHoc.ToString())];
			entity.HocKy = (reader[DonGiaTheoNganhColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaTheoNganhColumn.HocKy.ToString())];
			entity.MaNhomMon = (reader[DonGiaTheoNganhColumn.MaNhomMon.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DonGiaTheoNganhColumn.MaNhomMon.ToString())];
			entity.NhomMonHoc = (reader[DonGiaTheoNganhColumn.NhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaTheoNganhColumn.NhomMonHoc.ToString())];
			entity.DonGiaNgoaiNgu = (reader[DonGiaTheoNganhColumn.DonGiaNgoaiNgu.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaTheoNganhColumn.DonGiaNgoaiNgu.ToString())];
			entity.DonGiaDoAnClc = (reader[DonGiaTheoNganhColumn.DonGiaDoAnClc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaTheoNganhColumn.DonGiaDoAnClc.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DonGiaTheoNganh"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DonGiaTheoNganh"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.DonGiaTheoNganh entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.DonGiaCh = Convert.IsDBNull(dataRow["DonGiaCH"]) ? null : (System.Decimal?)dataRow["DonGiaCH"];
			entity.DonGiaTgkc = Convert.IsDBNull(dataRow["DonGiaTGKC"]) ? null : (System.Decimal?)dataRow["DonGiaTGKC"];
			entity.DonGiaTgc = Convert.IsDBNull(dataRow["DonGiaTGC"]) ? null : (System.Decimal?)dataRow["DonGiaTGC"];
			entity.DonGiaHocPhan = Convert.IsDBNull(dataRow["DonGiaHocPhan"]) ? null : (System.Decimal?)dataRow["DonGiaHocPhan"];
			entity.DonGiaLt = Convert.IsDBNull(dataRow["DonGiaLT"]) ? null : (System.Decimal?)dataRow["DonGiaLT"];
			entity.DonGiaTh = Convert.IsDBNull(dataRow["DonGiaTH"]) ? null : (System.Decimal?)dataRow["DonGiaTH"];
			entity.MaDonGiaNhomNganh = Convert.IsDBNull(dataRow["MaDonGiaNhomNganh"]) ? null : (System.Int32?)dataRow["MaDonGiaNhomNganh"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.DonGiaClc = Convert.IsDBNull(dataRow["DonGiaClc"]) ? null : (System.Decimal?)dataRow["DonGiaClc"];
			entity.HeSoQuyDoiChatLuong = Convert.IsDBNull(dataRow["HeSoQuyDoiChatLuong"]) ? null : (System.Decimal?)dataRow["HeSoQuyDoiChatLuong"];
			entity.DonGiaTrongChuan = Convert.IsDBNull(dataRow["DonGiaTrongChuan"]) ? null : (System.Decimal?)dataRow["DonGiaTrongChuan"];
			entity.DonGiaNgoaiChuan = Convert.IsDBNull(dataRow["DonGiaNgoaiChuan"]) ? null : (System.Decimal?)dataRow["DonGiaNgoaiChuan"];
			entity.MaHinhThucDaoTao = Convert.IsDBNull(dataRow["MaHinhThucDaoTao"]) ? null : (System.String)dataRow["MaHinhThucDaoTao"];
			entity.BacDaoTao = Convert.IsDBNull(dataRow["BacDaoTao"]) ? null : (System.String)dataRow["BacDaoTao"];
			entity.NgonNguGiangDay = Convert.IsDBNull(dataRow["NgonNguGiangDay"]) ? null : (System.String)dataRow["NgonNguGiangDay"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaNhomMon = Convert.IsDBNull(dataRow["MaNhomMon"]) ? null : (System.Int32?)dataRow["MaNhomMon"];
			entity.NhomMonHoc = Convert.IsDBNull(dataRow["NhomMonHoc"]) ? null : (System.String)dataRow["NhomMonHoc"];
			entity.DonGiaNgoaiNgu = Convert.IsDBNull(dataRow["DonGiaNgoaiNgu"]) ? null : (System.Decimal?)dataRow["DonGiaNgoaiNgu"];
			entity.DonGiaDoAnClc = Convert.IsDBNull(dataRow["DonGiaDoAnClc"]) ? null : (System.Decimal?)dataRow["DonGiaDoAnClc"];
			entity.AcceptChanges();
		}
		#endregion 
		
		#region DeepLoad Methods
		/// <summary>
		/// Deep Loads the <see cref="IEntity"/> object with criteria based of the child 
		/// property collections only N Levels Deep based on the <see cref="DeepLoadType"/>.
		/// </summary>
		/// <remarks>
		/// Use this method with caution as it is possible to DeepLoad with Recursion and traverse an entire object graph.
		/// </remarks>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">The <see cref="PMS.Entities.DonGiaTheoNganh"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.DonGiaTheoNganh Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.DonGiaTheoNganh entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaHocHamSource	
			if (CanDeepLoad(entity, "HocHam|MaHocHamSource", deepLoadType, innerList) 
				&& entity.MaHocHamSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaHocHam ?? (int)0);
				HocHam tmpEntity = EntityManager.LocateEntity<HocHam>(EntityLocator.ConstructKeyFromPkItems(typeof(HocHam), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaHocHamSource = tmpEntity;
				else
					entity.MaHocHamSource = DataRepository.HocHamProvider.GetByMaHocHam(transactionManager, (entity.MaHocHam ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaHocHamSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaHocHamSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.HocHamProvider.DeepLoad(transactionManager, entity.MaHocHamSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaHocHamSource

			#region MaHocViSource	
			if (CanDeepLoad(entity, "HocVi|MaHocViSource", deepLoadType, innerList) 
				&& entity.MaHocViSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaHocVi ?? (int)0);
				HocVi tmpEntity = EntityManager.LocateEntity<HocVi>(EntityLocator.ConstructKeyFromPkItems(typeof(HocVi), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaHocViSource = tmpEntity;
				else
					entity.MaHocViSource = DataRepository.HocViProvider.GetByMaHocVi(transactionManager, (entity.MaHocVi ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaHocViSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaHocViSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.HocViProvider.DeepLoad(transactionManager, entity.MaHocViSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaHocViSource

			#region MaLoaiGiangVienSource	
			if (CanDeepLoad(entity, "LoaiGiangVien|MaLoaiGiangVienSource", deepLoadType, innerList) 
				&& entity.MaLoaiGiangVienSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaLoaiGiangVien ?? (int)0);
				LoaiGiangVien tmpEntity = EntityManager.LocateEntity<LoaiGiangVien>(EntityLocator.ConstructKeyFromPkItems(typeof(LoaiGiangVien), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaLoaiGiangVienSource = tmpEntity;
				else
					entity.MaLoaiGiangVienSource = DataRepository.LoaiGiangVienProvider.GetByMaLoaiGiangVien(transactionManager, (entity.MaLoaiGiangVien ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaLoaiGiangVienSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaLoaiGiangVienSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.LoaiGiangVienProvider.DeepLoad(transactionManager, entity.MaLoaiGiangVienSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaLoaiGiangVienSource

			#region NgonNguGiangDaySource	
			if (CanDeepLoad(entity, "NgonNguGiangDay|NgonNguGiangDaySource", deepLoadType, innerList) 
				&& entity.NgonNguGiangDaySource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.NgonNguGiangDay ?? string.Empty);
				NgonNguGiangDay tmpEntity = EntityManager.LocateEntity<NgonNguGiangDay>(EntityLocator.ConstructKeyFromPkItems(typeof(NgonNguGiangDay), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.NgonNguGiangDaySource = tmpEntity;
				else
					entity.NgonNguGiangDaySource = DataRepository.NgonNguGiangDayProvider.GetByMaNgonNgu(transactionManager, (entity.NgonNguGiangDay ?? string.Empty));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'NgonNguGiangDaySource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.NgonNguGiangDaySource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.NgonNguGiangDayProvider.DeepLoad(transactionManager, entity.NgonNguGiangDaySource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion NgonNguGiangDaySource

			#region MaNhomMonSource	
			if (CanDeepLoad(entity, "NhomMonHoc|MaNhomMonSource", deepLoadType, innerList) 
				&& entity.MaNhomMonSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaNhomMon ?? (int)0);
				NhomMonHoc tmpEntity = EntityManager.LocateEntity<NhomMonHoc>(EntityLocator.ConstructKeyFromPkItems(typeof(NhomMonHoc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaNhomMonSource = tmpEntity;
				else
					entity.MaNhomMonSource = DataRepository.NhomMonHocProvider.GetByMaNhomMon(transactionManager, (entity.MaNhomMon ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaNhomMonSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaNhomMonSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.NhomMonHocProvider.DeepLoad(transactionManager, entity.MaNhomMonSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaNhomMonSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			
			//Fire all DeepLoad Items
			foreach(KeyValuePair<Delegate, object> pair in deepHandles.Values)
		    {
                pair.Key.DynamicInvoke((object[])pair.Value);
		    }
			deepHandles = null;
		}
		
		#endregion 
		
		#region DeepSave Methods

		/// <summary>
		/// Deep Save the entire object graph of the PMS.Entities.DonGiaTheoNganh object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.DonGiaTheoNganh instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.DonGiaTheoNganh Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.DonGiaTheoNganh entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaHocHamSource
			if (CanDeepSave(entity, "HocHam|MaHocHamSource", deepSaveType, innerList) 
				&& entity.MaHocHamSource != null)
			{
				DataRepository.HocHamProvider.Save(transactionManager, entity.MaHocHamSource);
				entity.MaHocHam = entity.MaHocHamSource.MaHocHam;
			}
			#endregion 
			
			#region MaHocViSource
			if (CanDeepSave(entity, "HocVi|MaHocViSource", deepSaveType, innerList) 
				&& entity.MaHocViSource != null)
			{
				DataRepository.HocViProvider.Save(transactionManager, entity.MaHocViSource);
				entity.MaHocVi = entity.MaHocViSource.MaHocVi;
			}
			#endregion 
			
			#region MaLoaiGiangVienSource
			if (CanDeepSave(entity, "LoaiGiangVien|MaLoaiGiangVienSource", deepSaveType, innerList) 
				&& entity.MaLoaiGiangVienSource != null)
			{
				DataRepository.LoaiGiangVienProvider.Save(transactionManager, entity.MaLoaiGiangVienSource);
				entity.MaLoaiGiangVien = entity.MaLoaiGiangVienSource.MaLoaiGiangVien;
			}
			#endregion 
			
			#region NgonNguGiangDaySource
			if (CanDeepSave(entity, "NgonNguGiangDay|NgonNguGiangDaySource", deepSaveType, innerList) 
				&& entity.NgonNguGiangDaySource != null)
			{
				DataRepository.NgonNguGiangDayProvider.Save(transactionManager, entity.NgonNguGiangDaySource);
				entity.NgonNguGiangDay = entity.NgonNguGiangDaySource.MaNgonNgu;
			}
			#endregion 
			
			#region MaNhomMonSource
			if (CanDeepSave(entity, "NhomMonHoc|MaNhomMonSource", deepSaveType, innerList) 
				&& entity.MaNhomMonSource != null)
			{
				DataRepository.NhomMonHocProvider.Save(transactionManager, entity.MaNhomMonSource);
				entity.MaNhomMon = entity.MaNhomMonSource.MaNhomMon;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			//Fire all DeepSave Items
			foreach(KeyValuePair<Delegate, object> pair in deepHandles.Values)
		    {
                pair.Key.DynamicInvoke((object[])pair.Value);
		    }
			
			// Save Root Entity through Provider, if not already saved in delete mode
			if (entity.IsDeleted)
				this.Save(transactionManager, entity);
				

			deepHandles = null;
						
			return true;
		}
		#endregion
	} // end class
	
	#region DonGiaTheoNganhChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.DonGiaTheoNganh</c>
	///</summary>
	public enum DonGiaTheoNganhChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>HocHam</c> at MaHocHamSource
		///</summary>
		[ChildEntityType(typeof(HocHam))]
		HocHam,
		
		///<summary>
		/// Composite Property for <c>HocVi</c> at MaHocViSource
		///</summary>
		[ChildEntityType(typeof(HocVi))]
		HocVi,
		
		///<summary>
		/// Composite Property for <c>LoaiGiangVien</c> at MaLoaiGiangVienSource
		///</summary>
		[ChildEntityType(typeof(LoaiGiangVien))]
		LoaiGiangVien,
		
		///<summary>
		/// Composite Property for <c>NgonNguGiangDay</c> at NgonNguGiangDaySource
		///</summary>
		[ChildEntityType(typeof(NgonNguGiangDay))]
		NgonNguGiangDay,
		
		///<summary>
		/// Composite Property for <c>NhomMonHoc</c> at MaNhomMonSource
		///</summary>
		[ChildEntityType(typeof(NhomMonHoc))]
		NhomMonHoc,
	}
	
	#endregion DonGiaTheoNganhChildEntityTypes
	
	#region DonGiaTheoNganhFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;DonGiaTheoNganhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaTheoNganh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaTheoNganhFilterBuilder : SqlFilterBuilder<DonGiaTheoNganhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaTheoNganhFilterBuilder class.
		/// </summary>
		public DonGiaTheoNganhFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DonGiaTheoNganhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DonGiaTheoNganhFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DonGiaTheoNganhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DonGiaTheoNganhFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DonGiaTheoNganhFilterBuilder
	
	#region DonGiaTheoNganhParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;DonGiaTheoNganhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaTheoNganh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaTheoNganhParameterBuilder : ParameterizedSqlFilterBuilder<DonGiaTheoNganhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaTheoNganhParameterBuilder class.
		/// </summary>
		public DonGiaTheoNganhParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DonGiaTheoNganhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DonGiaTheoNganhParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DonGiaTheoNganhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DonGiaTheoNganhParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DonGiaTheoNganhParameterBuilder
	
	#region DonGiaTheoNganhSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;DonGiaTheoNganhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaTheoNganh"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class DonGiaTheoNganhSortBuilder : SqlSortBuilder<DonGiaTheoNganhColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaTheoNganhSqlSortBuilder class.
		/// </summary>
		public DonGiaTheoNganhSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion DonGiaTheoNganhSortBuilder
	
} // end namespace
