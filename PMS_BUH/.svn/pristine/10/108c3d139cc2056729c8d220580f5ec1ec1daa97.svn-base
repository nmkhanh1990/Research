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
	/// This class is the base class for any <see cref="ChamTayHaiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ChamTayHaiProviderBaseCore : EntityProviderBase<PMS.Entities.ChamTayHai, PMS.Entities.ChamTayHaiKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ChamTayHaiKey key)
		{
			return Delete(transactionManager, key.MaGiangVien, key.MaLopHocPhan);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maGiangVien">. Primary Key.</param>
		/// <param name="_maLopHocPhan">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _maGiangVien, System.String _maLopHocPhan)
		{
			return Delete(null, _maGiangVien, _maLopHocPhan);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien">. Primary Key.</param>
		/// <param name="_maLopHocPhan">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _maGiangVien, System.String _maLopHocPhan);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
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
		public override PMS.Entities.ChamTayHai Get(TransactionManager transactionManager, PMS.Entities.ChamTayHaiKey key, int start, int pageLength)
		{
			return GetByMaGiangVienMaLopHocPhan(transactionManager, key.MaGiangVien, key.MaLopHocPhan, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__ChamTayH__481E6F77A5538D48 index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChamTayHai"/> class.</returns>
		public PMS.Entities.ChamTayHai GetByMaGiangVienMaLopHocPhan(System.String _maGiangVien, System.String _maLopHocPhan)
		{
			int count = -1;
			return GetByMaGiangVienMaLopHocPhan(null,_maGiangVien, _maLopHocPhan, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__ChamTayH__481E6F77A5538D48 index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChamTayHai"/> class.</returns>
		public PMS.Entities.ChamTayHai GetByMaGiangVienMaLopHocPhan(System.String _maGiangVien, System.String _maLopHocPhan, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVienMaLopHocPhan(null, _maGiangVien, _maLopHocPhan, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__ChamTayH__481E6F77A5538D48 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChamTayHai"/> class.</returns>
		public PMS.Entities.ChamTayHai GetByMaGiangVienMaLopHocPhan(TransactionManager transactionManager, System.String _maGiangVien, System.String _maLopHocPhan)
		{
			int count = -1;
			return GetByMaGiangVienMaLopHocPhan(transactionManager, _maGiangVien, _maLopHocPhan, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__ChamTayH__481E6F77A5538D48 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChamTayHai"/> class.</returns>
		public PMS.Entities.ChamTayHai GetByMaGiangVienMaLopHocPhan(TransactionManager transactionManager, System.String _maGiangVien, System.String _maLopHocPhan, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVienMaLopHocPhan(transactionManager, _maGiangVien, _maLopHocPhan, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__ChamTayH__481E6F77A5538D48 index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChamTayHai"/> class.</returns>
		public PMS.Entities.ChamTayHai GetByMaGiangVienMaLopHocPhan(System.String _maGiangVien, System.String _maLopHocPhan, int start, int pageLength, out int count)
		{
			return GetByMaGiangVienMaLopHocPhan(null, _maGiangVien, _maLopHocPhan, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__ChamTayH__481E6F77A5538D48 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChamTayHai"/> class.</returns>
		public abstract PMS.Entities.ChamTayHai GetByMaGiangVienMaLopHocPhan(TransactionManager transactionManager, System.String _maGiangVien, System.String _maLopHocPhan, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_ChamTayHai_LuuXoa 
		
		/// <summary>
		///	This method wrap the 'cust_ChamTayHai_LuuXoa' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuXoa(System.String xmlData, ref System.Int32 reVal)
		{
			 LuuXoa(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChamTayHai_LuuXoa' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuXoa(int start, int pageLength, System.String xmlData, ref System.Int32 reVal)
		{
			 LuuXoa(null, start, pageLength , xmlData, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ChamTayHai_LuuXoa' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuXoa(TransactionManager transactionManager, System.String xmlData, ref System.Int32 reVal)
		{
			 LuuXoa(transactionManager, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChamTayHai_LuuXoa' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuXoa(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_ChamTayHai_LuuImportExcel 
		
		/// <summary>
		///	This method wrap the 'cust_ChamTayHai_LuuImportExcel' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuImportExcel(System.String xmlData, ref System.Int32 reVal)
		{
			 LuuImportExcel(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChamTayHai_LuuImportExcel' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuImportExcel(int start, int pageLength, System.String xmlData, ref System.Int32 reVal)
		{
			 LuuImportExcel(null, start, pageLength , xmlData, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ChamTayHai_LuuImportExcel' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuImportExcel(TransactionManager transactionManager, System.String xmlData, ref System.Int32 reVal)
		{
			 LuuImportExcel(transactionManager, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChamTayHai_LuuImportExcel' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuImportExcel(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_ChamTayHai_GetAllChamTay2 
		
		/// <summary>
		///	This method wrap the 'cust_ChamTayHai_GetAllChamTay2' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHoatDong"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetAllChamTay2(System.String namHoc, System.String hocKy, System.String loaiHoatDong, System.String khoa)
		{
			return GetAllChamTay2(null, 0, int.MaxValue , namHoc, hocKy, loaiHoatDong, khoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChamTayHai_GetAllChamTay2' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHoatDong"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetAllChamTay2(int start, int pageLength, System.String namHoc, System.String hocKy, System.String loaiHoatDong, System.String khoa)
		{
			return GetAllChamTay2(null, start, pageLength , namHoc, hocKy, loaiHoatDong, khoa);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ChamTayHai_GetAllChamTay2' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHoatDong"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetAllChamTay2(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String loaiHoatDong, System.String khoa)
		{
			return GetAllChamTay2(transactionManager, 0, int.MaxValue , namHoc, hocKy, loaiHoatDong, khoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChamTayHai_GetAllChamTay2' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHoatDong"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetAllChamTay2(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String loaiHoatDong, System.String khoa);
		
		#endregion
		
		#region cust_ChamTayHai_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_ChamTayHai_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChamTayHai_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ChamTayHai_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChamTayHai_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_ChamTayHai_GetBangChamTay2ByNamHocHocKyKhoaLoaiHoatDong 
		
		/// <summary>
		///	This method wrap the 'cust_ChamTayHai_GetBangChamTay2ByNamHocHocKyKhoaLoaiHoatDong' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHoatDong"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetBangChamTay2ByNamHocHocKyKhoaLoaiHoatDong(System.String namHoc, System.String hocKy, System.String loaiHoatDong, System.String khoa)
		{
			return GetBangChamTay2ByNamHocHocKyKhoaLoaiHoatDong(null, 0, int.MaxValue , namHoc, hocKy, loaiHoatDong, khoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChamTayHai_GetBangChamTay2ByNamHocHocKyKhoaLoaiHoatDong' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHoatDong"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetBangChamTay2ByNamHocHocKyKhoaLoaiHoatDong(int start, int pageLength, System.String namHoc, System.String hocKy, System.String loaiHoatDong, System.String khoa)
		{
			return GetBangChamTay2ByNamHocHocKyKhoaLoaiHoatDong(null, start, pageLength , namHoc, hocKy, loaiHoatDong, khoa);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ChamTayHai_GetBangChamTay2ByNamHocHocKyKhoaLoaiHoatDong' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHoatDong"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetBangChamTay2ByNamHocHocKyKhoaLoaiHoatDong(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String loaiHoatDong, System.String khoa)
		{
			return GetBangChamTay2ByNamHocHocKyKhoaLoaiHoatDong(transactionManager, 0, int.MaxValue , namHoc, hocKy, loaiHoatDong, khoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChamTayHai_GetBangChamTay2ByNamHocHocKyKhoaLoaiHoatDong' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHoatDong"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetBangChamTay2ByNamHocHocKyKhoaLoaiHoatDong(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String loaiHoatDong, System.String khoa);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ChamTayHai&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ChamTayHai&gt;"/></returns>
		public static TList<ChamTayHai> Fill(IDataReader reader, TList<ChamTayHai> rows, int start, int pageLength)
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
				
				PMS.Entities.ChamTayHai c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ChamTayHai")
					.Append("|").Append((System.String)reader[((int)ChamTayHaiColumn.MaGiangVien - 1)])
					.Append("|").Append((System.String)reader[((int)ChamTayHaiColumn.MaLopHocPhan - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ChamTayHai>(
					key.ToString(), // EntityTrackingKey
					"ChamTayHai",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ChamTayHai();
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
					c.MaGiangVien = (System.String)reader[(ChamTayHaiColumn.MaGiangVien.ToString())];
					c.OriginalMaGiangVien = c.MaGiangVien;
					c.MaLopHocPhan = (System.String)reader[(ChamTayHaiColumn.MaLopHocPhan.ToString())];
					c.OriginalMaLopHocPhan = c.MaLopHocPhan;
					c.SoTiet = (reader[ChamTayHaiColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChamTayHaiColumn.SoTiet.ToString())];
					c.SiSo = (reader[ChamTayHaiColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChamTayHaiColumn.SiSo.ToString())];
					c.NgayCapNhat = (reader[ChamTayHaiColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ChamTayHaiColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[ChamTayHaiColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChamTayHaiColumn.NguoiCapNhat.ToString())];
					c.NamHoc = (reader[ChamTayHaiColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChamTayHaiColumn.NamHoc.ToString())];
					c.HocKy = (reader[ChamTayHaiColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChamTayHaiColumn.HocKy.ToString())];
					c.Khoa = (reader[ChamTayHaiColumn.Khoa.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ChamTayHaiColumn.Khoa.ToString())];
					c.HeSoQuyDoi = (reader[ChamTayHaiColumn.HeSoQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ChamTayHaiColumn.HeSoQuyDoi.ToString())];
					c.GhiChu = (reader[ChamTayHaiColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChamTayHaiColumn.GhiChu.ToString())];
					c.LayDuLieu = (reader[ChamTayHaiColumn.LayDuLieu.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ChamTayHaiColumn.LayDuLieu.ToString())];
					c.MaHoatDong = (reader[ChamTayHaiColumn.MaHoatDong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChamTayHaiColumn.MaHoatDong.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ChamTayHai"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ChamTayHai"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ChamTayHai entity)
		{
			if (!reader.Read()) return;
			
			entity.MaGiangVien = (System.String)reader[(ChamTayHaiColumn.MaGiangVien.ToString())];
			entity.OriginalMaGiangVien = (System.String)reader["MaGiangVien"];
			entity.MaLopHocPhan = (System.String)reader[(ChamTayHaiColumn.MaLopHocPhan.ToString())];
			entity.OriginalMaLopHocPhan = (System.String)reader["MaLopHocPhan"];
			entity.SoTiet = (reader[ChamTayHaiColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChamTayHaiColumn.SoTiet.ToString())];
			entity.SiSo = (reader[ChamTayHaiColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChamTayHaiColumn.SiSo.ToString())];
			entity.NgayCapNhat = (reader[ChamTayHaiColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ChamTayHaiColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[ChamTayHaiColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChamTayHaiColumn.NguoiCapNhat.ToString())];
			entity.NamHoc = (reader[ChamTayHaiColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChamTayHaiColumn.NamHoc.ToString())];
			entity.HocKy = (reader[ChamTayHaiColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChamTayHaiColumn.HocKy.ToString())];
			entity.Khoa = (reader[ChamTayHaiColumn.Khoa.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ChamTayHaiColumn.Khoa.ToString())];
			entity.HeSoQuyDoi = (reader[ChamTayHaiColumn.HeSoQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ChamTayHaiColumn.HeSoQuyDoi.ToString())];
			entity.GhiChu = (reader[ChamTayHaiColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChamTayHaiColumn.GhiChu.ToString())];
			entity.LayDuLieu = (reader[ChamTayHaiColumn.LayDuLieu.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ChamTayHaiColumn.LayDuLieu.ToString())];
			entity.MaHoatDong = (reader[ChamTayHaiColumn.MaHoatDong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChamTayHaiColumn.MaHoatDong.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ChamTayHai"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ChamTayHai"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ChamTayHai entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (System.String)dataRow["MaGiangVien"];
			entity.OriginalMaGiangVien = (System.String)dataRow["MaGiangVien"];
			entity.MaLopHocPhan = (System.String)dataRow["MaLopHocPhan"];
			entity.OriginalMaLopHocPhan = (System.String)dataRow["MaLopHocPhan"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Int32?)dataRow["SoTiet"];
			entity.SiSo = Convert.IsDBNull(dataRow["SiSo"]) ? null : (System.Int32?)dataRow["SiSo"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.Khoa = Convert.IsDBNull(dataRow["Khoa"]) ? null : (System.Boolean?)dataRow["Khoa"];
			entity.HeSoQuyDoi = Convert.IsDBNull(dataRow["HeSoQuyDoi"]) ? null : (System.Decimal?)dataRow["HeSoQuyDoi"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.LayDuLieu = Convert.IsDBNull(dataRow["LayDuLieu"]) ? null : (System.Boolean?)dataRow["LayDuLieu"];
			entity.MaHoatDong = Convert.IsDBNull(dataRow["MaHoatDong"]) ? null : (System.Int32?)dataRow["MaHoatDong"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ChamTayHai"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ChamTayHai Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ChamTayHai entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
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
		/// Deep Save the entire object graph of the PMS.Entities.ChamTayHai object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ChamTayHai instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ChamTayHai Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ChamTayHai entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
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
	
	#region ChamTayHaiChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ChamTayHai</c>
	///</summary>
	public enum ChamTayHaiChildEntityTypes
	{
	}
	
	#endregion ChamTayHaiChildEntityTypes
	
	#region ChamTayHaiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ChamTayHaiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChamTayHai"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChamTayHaiFilterBuilder : SqlFilterBuilder<ChamTayHaiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChamTayHaiFilterBuilder class.
		/// </summary>
		public ChamTayHaiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ChamTayHaiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ChamTayHaiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ChamTayHaiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ChamTayHaiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ChamTayHaiFilterBuilder
	
	#region ChamTayHaiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ChamTayHaiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChamTayHai"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChamTayHaiParameterBuilder : ParameterizedSqlFilterBuilder<ChamTayHaiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChamTayHaiParameterBuilder class.
		/// </summary>
		public ChamTayHaiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ChamTayHaiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ChamTayHaiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ChamTayHaiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ChamTayHaiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ChamTayHaiParameterBuilder
	
	#region ChamTayHaiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ChamTayHaiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChamTayHai"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ChamTayHaiSortBuilder : SqlSortBuilder<ChamTayHaiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChamTayHaiSqlSortBuilder class.
		/// </summary>
		public ChamTayHaiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ChamTayHaiSortBuilder
	
} // end namespace
