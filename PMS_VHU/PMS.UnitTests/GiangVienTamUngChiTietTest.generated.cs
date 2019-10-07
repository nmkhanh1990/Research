﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file GiangVienTamUngChiTietTest.cs instead.
*/

#region Using directives

using System;
using System.Xml;
using System.Xml.Serialization;
using NUnit.Framework;
using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;

#endregion

namespace PMS.UnitTests
{
    /// <summary>
    /// Provides tests for the and <see cref="GiangVienTamUngChiTiet"/> objects (entity, collection and repository).
    /// </summary>
   public partial class GiangVienTamUngChiTietTest
    {
    	// the GiangVienTamUngChiTiet instance used to test the repository.
		protected GiangVienTamUngChiTiet mock;
		
		// the TList<GiangVienTamUngChiTiet> instance used to test the repository.
		protected TList<GiangVienTamUngChiTiet> mockCollection;
		
		protected static TransactionManager CreateTransaction()
		{
			TransactionManager transactionManager = null;
			if (DataRepository.Provider.IsTransactionSupported)
			{
				transactionManager = DataRepository.Provider.CreateTransaction();
				transactionManager.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
			}			
			return transactionManager;
		}
		       
        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>        
        static public void Init_Generated()
        {		
        	System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the GiangVienTamUngChiTiet Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
			System.Console.WriteLine(new String('-', 75));
        }
    
    	/// <summary>
		/// This method is used to restore the environment after the tests are completed.
		/// </summary>
		static public void CleanUp_Generated()
        {   		
			System.Console.WriteLine("All Tests Completed");
			System.Console.WriteLine();
        }
    
    
		/// <summary>
		/// Inserts a mock GiangVienTamUngChiTiet entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.GiangVienTamUngChiTietProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.GiangVienTamUngChiTietProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all GiangVienTamUngChiTiet objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.GiangVienTamUngChiTietProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.GiangVienTamUngChiTietProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.GiangVienTamUngChiTietProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all GiangVienTamUngChiTiet children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.GiangVienTamUngChiTietProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.GiangVienTamUngChiTietProvider.DeepLoading += new EntityProviderBaseCore<GiangVienTamUngChiTiet, GiangVienTamUngChiTietKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.GiangVienTamUngChiTietProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("GiangVienTamUngChiTiet instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.GiangVienTamUngChiTietProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock GiangVienTamUngChiTiet entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				GiangVienTamUngChiTiet mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.GiangVienTamUngChiTietProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.GiangVienTamUngChiTietProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.GiangVienTamUngChiTietProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock GiangVienTamUngChiTiet entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (GiangVienTamUngChiTiet)CreateMockInstance(tm);
				DataRepository.GiangVienTamUngChiTietProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.GiangVienTamUngChiTietProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.GiangVienTamUngChiTietProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock GiangVienTamUngChiTiet entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_GiangVienTamUngChiTiet.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock GiangVienTamUngChiTiet entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_GiangVienTamUngChiTiet.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<GiangVienTamUngChiTiet>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a GiangVienTamUngChiTiet collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_GiangVienTamUngChiTietCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<GiangVienTamUngChiTiet> mockCollection = new TList<GiangVienTamUngChiTiet>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<GiangVienTamUngChiTiet> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a GiangVienTamUngChiTiet collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_GiangVienTamUngChiTietCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<GiangVienTamUngChiTiet>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<GiangVienTamUngChiTiet> mockCollection = (TList<GiangVienTamUngChiTiet>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<GiangVienTamUngChiTiet> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				GiangVienTamUngChiTiet entity = CreateMockInstance(tm);
				bool result = DataRepository.GiangVienTamUngChiTietProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test FK, Insert Failed");
				
			}
		}
		
		
		/// <summary>
		/// Check the indexes dal methods.
		/// </summary>
		private void Step_11_IX_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				GiangVienTamUngChiTiet entity = CreateMockInstance(tm);
				bool result = DataRepository.GiangVienTamUngChiTietProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				GiangVienTamUngChiTiet t0 = DataRepository.GiangVienTamUngChiTietProvider.GetById(tm, entity.Id);
			}
		}
		
		/// <summary>
		/// Test methods exposed by the EntityHelper class.
		/// </summary>
		private void Step_20_TestEntityHelper_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				
				GiangVienTamUngChiTiet entity = mock.Copy() as GiangVienTamUngChiTiet;
				entity = (GiangVienTamUngChiTiet)mock.Clone();
				Assert.IsTrue(GiangVienTamUngChiTiet.ValueEquals(entity, mock), "Clone is not working");
			}
		}
		
		/// <summary>
		/// Test Find using the Query class
		/// </summary>
		private void Step_30_TestFindByQuery_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Insert Mock Instance
				GiangVienTamUngChiTiet mock = CreateMockInstance(tm);
				bool result = DataRepository.GiangVienTamUngChiTietProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				GiangVienTamUngChiTietQuery query = new GiangVienTamUngChiTietQuery();
			
				query.AppendEquals(GiangVienTamUngChiTietColumn.Id, mock.Id.ToString());
				if(mock.MaGiangVien != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.MaGiangVien, mock.MaGiangVien.ToString());
				if(mock.MaLopHocPhan != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.MaLopHocPhan, mock.MaLopHocPhan.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.HocKy, mock.HocKy.ToString());
				if(mock.MaMonHoc != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.MaMonHoc, mock.MaMonHoc.ToString());
				if(mock.TenMonHoc != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.TenMonHoc, mock.TenMonHoc.ToString());
				if(mock.Nhom != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.Nhom, mock.Nhom.ToString());
				if(mock.SoTinChi != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.SoTinChi, mock.SoTinChi.ToString());
				if(mock.SiSo != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.SiSo, mock.SiSo.ToString());
				if(mock.MaLoaiHocPhan != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.MaLoaiHocPhan, mock.MaLoaiHocPhan.ToString());
				if(mock.LoaiHocPhan != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.LoaiHocPhan, mock.LoaiHocPhan.ToString());
				if(mock.MaLop != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.MaLop, mock.MaLop.ToString());
				if(mock.SoTietThucDay != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.SoTietThucDay, mock.SoTietThucDay.ToString());
				if(mock.MaBacDaoTao != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.MaBacDaoTao, mock.MaBacDaoTao.ToString());
				if(mock.MaKhoa != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.MaKhoa, mock.MaKhoa.ToString());
				if(mock.MaNhomMonHoc != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.MaNhomMonHoc, mock.MaNhomMonHoc.ToString());
				if(mock.MaKhoaHoc != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.MaKhoaHoc, mock.MaKhoaHoc.ToString());
				if(mock.MaHocHam != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.MaHocHam, mock.MaHocHam.ToString());
				if(mock.MaHocVi != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.MaHocVi, mock.MaHocVi.ToString());
				if(mock.MaLoaiGiangVien != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.MaLoaiGiangVien, mock.MaLoaiGiangVien.ToString());
				if(mock.MaChucVu != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.MaChucVu, mock.MaChucVu.ToString());
				if(mock.MaHinhThucDaoTao != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.MaHinhThucDaoTao, mock.MaHinhThucDaoTao.ToString());
				if(mock.LopHocPhanChuyenNganh != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.LopHocPhanChuyenNganh, mock.LopHocPhanChuyenNganh.ToString());
				if(mock.DaoTaoTinChi != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.DaoTaoTinChi, mock.DaoTaoTinChi.ToString());
				if(mock.HeSoCongViec != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.HeSoCongViec, mock.HeSoCongViec.ToString());
				if(mock.HeSoBacDaoTao != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.HeSoBacDaoTao, mock.HeSoBacDaoTao.ToString());
				if(mock.HeSoNgonNgu != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.HeSoNgonNgu, mock.HeSoNgonNgu.ToString());
				if(mock.HeSoChucDanhChuyenMon != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.HeSoChucDanhChuyenMon, mock.HeSoChucDanhChuyenMon.ToString());
				if(mock.HeSoLopDong != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.HeSoLopDong, mock.HeSoLopDong.ToString());
				if(mock.HeSoCoSo != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.HeSoCoSo, mock.HeSoCoSo.ToString());
				if(mock.HeSoNienCheTinChi != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.HeSoNienCheTinChi, mock.HeSoNienCheTinChi.ToString());
				if(mock.SoTietThucTeQuyDoi != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.SoTietThucTeQuyDoi, mock.SoTietThucTeQuyDoi.ToString());
				if(mock.TietQuyDoi != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.TietQuyDoi, mock.TietQuyDoi.ToString());
				if(mock.HeSoQuyDoiThucHanhSangLyThuyet != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.HeSoQuyDoiThucHanhSangLyThuyet, mock.HeSoQuyDoiThucHanhSangLyThuyet.ToString());
				if(mock.HeSoNgoaiGio != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.HeSoNgoaiGio, mock.HeSoNgoaiGio.ToString());
				if(mock.LoaiLop != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.LoaiLop, mock.LoaiLop.ToString());
				if(mock.HeSoClcCntn != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.HeSoClcCntn, mock.HeSoClcCntn.ToString());
				if(mock.HeSoThinhGiangMonChuyenNganh != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.HeSoThinhGiangMonChuyenNganh, mock.HeSoThinhGiangMonChuyenNganh.ToString());
				if(mock.NgonNguGiangDay != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.NgonNguGiangDay, mock.NgonNguGiangDay.ToString());
				if(mock.HeSoTroCap != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.HeSoTroCap, mock.HeSoTroCap.ToString());
				if(mock.HeSoLuong != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.HeSoLuong, mock.HeSoLuong.ToString());
				if(mock.HeSoMonMoi != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.HeSoMonMoi, mock.HeSoMonMoi.ToString());
				if(mock.DonGia != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.DonGia, mock.DonGia.ToString());
				if(mock.ThanhTien != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.ThanhTien, mock.ThanhTien.ToString());
				if(mock.GhiChu != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.GhiChu, mock.GhiChu.ToString());
				if(mock.MucThanhToan != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.MucThanhToan, mock.MucThanhToan.ToString());
				if(mock.NgayTamUng != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.NgayTamUng, mock.NgayTamUng.ToString());
				if(mock.DotTamUng != null)
					query.AppendEquals(GiangVienTamUngChiTietColumn.DotTamUng, mock.DotTamUng.ToString());
				
				TList<GiangVienTamUngChiTiet> results = DataRepository.GiangVienTamUngChiTietProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed GiangVienTamUngChiTiet Entity with mock values.
		///</summary>
		static public GiangVienTamUngChiTiet CreateMockInstance_Generated(TransactionManager tm)
		{		
			GiangVienTamUngChiTiet mock = new GiangVienTamUngChiTiet();
						
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(249, false);;
			mock.Nhom = TestUtility.Instance.RandomString(24, false);;
			mock.SoTinChi = (decimal)TestUtility.Instance.RandomShort();
			mock.SiSo = TestUtility.Instance.RandomNumber();
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomByte();
			mock.LoaiHocPhan = TestUtility.Instance.RandomString(9, false);;
			mock.MaLop = TestUtility.Instance.RandomString(249, false);;
			mock.SoTietThucDay = (decimal)TestUtility.Instance.RandomShort();
			mock.MaBacDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.MaKhoa = TestUtility.Instance.RandomString(99, false);;
			mock.MaNhomMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaKhoaHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaHocHam = TestUtility.Instance.RandomNumber();
			mock.MaHocVi = TestUtility.Instance.RandomNumber();
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaChucVu = TestUtility.Instance.RandomNumber();
			mock.MaHinhThucDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.LopHocPhanChuyenNganh = TestUtility.Instance.RandomBoolean();
			mock.DaoTaoTinChi = TestUtility.Instance.RandomBoolean();
			mock.HeSoCongViec = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoBacDaoTao = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoNgonNgu = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoChucDanhChuyenMon = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoLopDong = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoCoSo = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoNienCheTinChi = (decimal)TestUtility.Instance.RandomShort();
			mock.SoTietThucTeQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.TietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoQuyDoiThucHanhSangLyThuyet = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoNgoaiGio = (decimal)TestUtility.Instance.RandomShort();
			mock.LoaiLop = TestUtility.Instance.RandomString(10, false);;
			mock.HeSoClcCntn = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoThinhGiangMonChuyenNganh = (decimal)TestUtility.Instance.RandomShort();
			mock.NgonNguGiangDay = TestUtility.Instance.RandomString(24, false);;
			mock.HeSoTroCap = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoLuong = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoMonMoi = (decimal)TestUtility.Instance.RandomShort();
			mock.DonGia = (decimal)TestUtility.Instance.RandomShort();
			mock.ThanhTien = (decimal)TestUtility.Instance.RandomShort();
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			mock.MucThanhToan = (decimal)TestUtility.Instance.RandomShort();
			mock.NgayTamUng = TestUtility.Instance.RandomDateTime();
			mock.DotTamUng = TestUtility.Instance.RandomString(249, false);;
			
		
			// create a temporary collection and add the item to it
			TList<GiangVienTamUngChiTiet> tempMockCollection = new TList<GiangVienTamUngChiTiet>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (GiangVienTamUngChiTiet)mock;
		}
		
		
		///<summary>
		///  Update the Typed GiangVienTamUngChiTiet Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, GiangVienTamUngChiTiet mock)
		{
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(249, false);;
			mock.Nhom = TestUtility.Instance.RandomString(24, false);;
			mock.SoTinChi = (decimal)TestUtility.Instance.RandomShort();
			mock.SiSo = TestUtility.Instance.RandomNumber();
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomByte();
			mock.LoaiHocPhan = TestUtility.Instance.RandomString(9, false);;
			mock.MaLop = TestUtility.Instance.RandomString(249, false);;
			mock.SoTietThucDay = (decimal)TestUtility.Instance.RandomShort();
			mock.MaBacDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.MaKhoa = TestUtility.Instance.RandomString(99, false);;
			mock.MaNhomMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaKhoaHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaHocHam = TestUtility.Instance.RandomNumber();
			mock.MaHocVi = TestUtility.Instance.RandomNumber();
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaChucVu = TestUtility.Instance.RandomNumber();
			mock.MaHinhThucDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.LopHocPhanChuyenNganh = TestUtility.Instance.RandomBoolean();
			mock.DaoTaoTinChi = TestUtility.Instance.RandomBoolean();
			mock.HeSoCongViec = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoBacDaoTao = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoNgonNgu = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoChucDanhChuyenMon = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoLopDong = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoCoSo = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoNienCheTinChi = (decimal)TestUtility.Instance.RandomShort();
			mock.SoTietThucTeQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.TietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoQuyDoiThucHanhSangLyThuyet = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoNgoaiGio = (decimal)TestUtility.Instance.RandomShort();
			mock.LoaiLop = TestUtility.Instance.RandomString(10, false);;
			mock.HeSoClcCntn = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoThinhGiangMonChuyenNganh = (decimal)TestUtility.Instance.RandomShort();
			mock.NgonNguGiangDay = TestUtility.Instance.RandomString(24, false);;
			mock.HeSoTroCap = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoLuong = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoMonMoi = (decimal)TestUtility.Instance.RandomShort();
			mock.DonGia = (decimal)TestUtility.Instance.RandomShort();
			mock.ThanhTien = (decimal)TestUtility.Instance.RandomShort();
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			mock.MucThanhToan = (decimal)TestUtility.Instance.RandomShort();
			mock.NgayTamUng = TestUtility.Instance.RandomDateTime();
			mock.DotTamUng = TestUtility.Instance.RandomString(249, false);;
			
		}
		#endregion
    }
}