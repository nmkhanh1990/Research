﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file SdhUteThanhToanThuLaoTest.cs instead.
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
    /// Provides tests for the and <see cref="SdhUteThanhToanThuLao"/> objects (entity, collection and repository).
    /// </summary>
   public partial class SdhUteThanhToanThuLaoTest
    {
    	// the SdhUteThanhToanThuLao instance used to test the repository.
		protected SdhUteThanhToanThuLao mock;
		
		// the TList<SdhUteThanhToanThuLao> instance used to test the repository.
		protected TList<SdhUteThanhToanThuLao> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the SdhUteThanhToanThuLao Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock SdhUteThanhToanThuLao entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.SdhUteThanhToanThuLaoProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.SdhUteThanhToanThuLaoProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all SdhUteThanhToanThuLao objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.SdhUteThanhToanThuLaoProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.SdhUteThanhToanThuLaoProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.SdhUteThanhToanThuLaoProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all SdhUteThanhToanThuLao children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.SdhUteThanhToanThuLaoProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.SdhUteThanhToanThuLaoProvider.DeepLoading += new EntityProviderBaseCore<SdhUteThanhToanThuLao, SdhUteThanhToanThuLaoKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.SdhUteThanhToanThuLaoProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("SdhUteThanhToanThuLao instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.SdhUteThanhToanThuLaoProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock SdhUteThanhToanThuLao entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				SdhUteThanhToanThuLao mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.SdhUteThanhToanThuLaoProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.SdhUteThanhToanThuLaoProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.SdhUteThanhToanThuLaoProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock SdhUteThanhToanThuLao entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (SdhUteThanhToanThuLao)CreateMockInstance(tm);
				DataRepository.SdhUteThanhToanThuLaoProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.SdhUteThanhToanThuLaoProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.SdhUteThanhToanThuLaoProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock SdhUteThanhToanThuLao entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhUteThanhToanThuLao.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock SdhUteThanhToanThuLao entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhUteThanhToanThuLao.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<SdhUteThanhToanThuLao>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a SdhUteThanhToanThuLao collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhUteThanhToanThuLaoCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<SdhUteThanhToanThuLao> mockCollection = new TList<SdhUteThanhToanThuLao>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<SdhUteThanhToanThuLao> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a SdhUteThanhToanThuLao collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhUteThanhToanThuLaoCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<SdhUteThanhToanThuLao>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<SdhUteThanhToanThuLao> mockCollection = (TList<SdhUteThanhToanThuLao>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<SdhUteThanhToanThuLao> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				SdhUteThanhToanThuLao entity = CreateMockInstance(tm);
				bool result = DataRepository.SdhUteThanhToanThuLaoProvider.Insert(tm, entity);
				
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
				SdhUteThanhToanThuLao entity = CreateMockInstance(tm);
				bool result = DataRepository.SdhUteThanhToanThuLaoProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				SdhUteThanhToanThuLao t0 = DataRepository.SdhUteThanhToanThuLaoProvider.GetByIdKhoiLuongQuyDoi(tm, entity.IdKhoiLuongQuyDoi);
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
				
				SdhUteThanhToanThuLao entity = mock.Copy() as SdhUteThanhToanThuLao;
				entity = (SdhUteThanhToanThuLao)mock.Clone();
				Assert.IsTrue(SdhUteThanhToanThuLao.ValueEquals(entity, mock), "Clone is not working");
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
				SdhUteThanhToanThuLao mock = CreateMockInstance(tm);
				bool result = DataRepository.SdhUteThanhToanThuLaoProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				SdhUteThanhToanThuLaoQuery query = new SdhUteThanhToanThuLaoQuery();
			
				query.AppendEquals(SdhUteThanhToanThuLaoColumn.IdKhoiLuongQuyDoi, mock.IdKhoiLuongQuyDoi.ToString());
				if(mock.MaMonHoc != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.MaMonHoc, mock.MaMonHoc.ToString());
				if(mock.TenMonHoc != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.TenMonHoc, mock.TenMonHoc.ToString());
				if(mock.NhomMonHoc != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.NhomMonHoc, mock.NhomMonHoc.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.HocKy, mock.HocKy.ToString());
				if(mock.MaLopHocPhan != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.MaLopHocPhan, mock.MaLopHocPhan.ToString());
				if(mock.Nhom != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.Nhom, mock.Nhom.ToString());
				if(mock.MaLop != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.MaLop, mock.MaLop.ToString());
				if(mock.SoTinChi != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.SoTinChi, mock.SoTinChi.ToString());
				if(mock.SoTiet != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.SoTiet, mock.SoTiet.ToString());
				if(mock.SiSo != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.SiSo, mock.SiSo.ToString());
				if(mock.LopClc != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.LopClc, mock.LopClc.ToString());
				if(mock.SoTietDayChuNhat != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.SoTietDayChuNhat, mock.SoTietDayChuNhat.ToString());
				if(mock.MaLoaiHocPhan != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.MaLoaiHocPhan, mock.MaLoaiHocPhan.ToString());
				if(mock.HeSoLopDongLyThuyet != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.HeSoLopDongLyThuyet, mock.HeSoLopDongLyThuyet.ToString());
				if(mock.HeSoLopDongThTnTt != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.HeSoLopDongThTnTt, mock.HeSoLopDongThTnTt.ToString());
				if(mock.MaQuanLy != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.MaQuanLy, mock.MaQuanLy.ToString());
				if(mock.Ho != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.Ho, mock.Ho.ToString());
				if(mock.Ten != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.Ten, mock.Ten.ToString());
				if(mock.HoTen != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.HoTen, mock.HoTen.ToString());
				if(mock.MaHocHam != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.MaHocHam, mock.MaHocHam.ToString());
				if(mock.MaHocVi != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.MaHocVi, mock.MaHocVi.ToString());
				if(mock.MaLoaiGiangVien != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.MaLoaiGiangVien, mock.MaLoaiGiangVien.ToString());
				if(mock.MaDonVi != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.MaDonVi, mock.MaDonVi.ToString());
				if(mock.DonGia != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.DonGia, mock.DonGia.ToString());
				if(mock.TietQuyDoi != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.TietQuyDoi, mock.TietQuyDoi.ToString());
				if(mock.ThanhTienDayChuNhat != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.ThanhTienDayChuNhat, mock.ThanhTienDayChuNhat.ToString());
				if(mock.ThanhTien != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.ThanhTien, mock.ThanhTien.ToString());
				if(mock.TongThanhTien != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.TongThanhTien, mock.TongThanhTien.ToString());
				if(mock.NgayCapNhat != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.NgayCapNhat, mock.NgayCapNhat.ToString());
				if(mock.DaChot != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.DaChot, mock.DaChot.ToString());
				if(mock.HeSoHocKy != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.HeSoHocKy, mock.HeSoHocKy.ToString());
				if(mock.SoGioThucGiangTrenLop != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.SoGioThucGiangTrenLop, mock.SoGioThucGiangTrenLop.ToString());
				if(mock.SoGioChuanTinhThem != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.SoGioChuanTinhThem, mock.SoGioChuanTinhThem.ToString());
				if(mock.MaDiaDiem != null)
					query.AppendEquals(SdhUteThanhToanThuLaoColumn.MaDiaDiem, mock.MaDiaDiem.ToString());
				
				TList<SdhUteThanhToanThuLao> results = DataRepository.SdhUteThanhToanThuLaoProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed SdhUteThanhToanThuLao Entity with mock values.
		///</summary>
		static public SdhUteThanhToanThuLao CreateMockInstance_Generated(TransactionManager tm)
		{		
			SdhUteThanhToanThuLao mock = new SdhUteThanhToanThuLao();
						
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(249, false);;
			mock.NhomMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.Nhom = TestUtility.Instance.RandomString(24, false);;
			mock.MaLop = TestUtility.Instance.RandomString(99, false);;
			mock.SoTinChi = TestUtility.Instance.RandomNumber();
			mock.SoTiet = TestUtility.Instance.RandomNumber();
			mock.SiSo = TestUtility.Instance.RandomNumber();
			mock.LopClc = TestUtility.Instance.RandomBoolean();
			mock.SoTietDayChuNhat = TestUtility.Instance.RandomNumber();
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomNumber();
			mock.HeSoLopDongLyThuyet = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoLopDongThTnTt = (decimal)TestUtility.Instance.RandomShort();
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.Ho = TestUtility.Instance.RandomString(24, false);;
			mock.Ten = TestUtility.Instance.RandomString(24, false);;
			mock.HoTen = TestUtility.Instance.RandomString(49, false);;
			mock.MaHocHam = TestUtility.Instance.RandomNumber();
			mock.MaHocVi = TestUtility.Instance.RandomNumber();
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaDonVi = TestUtility.Instance.RandomString(9, false);;
			mock.DonGia = (decimal)TestUtility.Instance.RandomShort();
			mock.TietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.ThanhTienDayChuNhat = (decimal)TestUtility.Instance.RandomShort();
			mock.ThanhTien = (decimal)TestUtility.Instance.RandomShort();
			mock.TongThanhTien = (decimal)TestUtility.Instance.RandomShort();
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
			mock.DaChot = TestUtility.Instance.RandomBoolean();
			mock.HeSoHocKy = (decimal)TestUtility.Instance.RandomShort();
			mock.SoGioThucGiangTrenLop = (decimal)TestUtility.Instance.RandomShort();
			mock.SoGioChuanTinhThem = (decimal)TestUtility.Instance.RandomShort();
			mock.MaDiaDiem = TestUtility.Instance.RandomString(9, false);;
			
			//OneToOneRelationship
			SdhUteKhoiLuongQuyDoi mockSdhUteKhoiLuongQuyDoiByIdKhoiLuongQuyDoi = SdhUteKhoiLuongQuyDoiTest.CreateMockInstance(tm);
			DataRepository.SdhUteKhoiLuongQuyDoiProvider.Insert(tm, mockSdhUteKhoiLuongQuyDoiByIdKhoiLuongQuyDoi);
			mock.IdKhoiLuongQuyDoi = mockSdhUteKhoiLuongQuyDoiByIdKhoiLuongQuyDoi.Id;
		
			// create a temporary collection and add the item to it
			TList<SdhUteThanhToanThuLao> tempMockCollection = new TList<SdhUteThanhToanThuLao>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (SdhUteThanhToanThuLao)mock;
		}
		
		
		///<summary>
		///  Update the Typed SdhUteThanhToanThuLao Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, SdhUteThanhToanThuLao mock)
		{
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(249, false);;
			mock.NhomMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.Nhom = TestUtility.Instance.RandomString(24, false);;
			mock.MaLop = TestUtility.Instance.RandomString(99, false);;
			mock.SoTinChi = TestUtility.Instance.RandomNumber();
			mock.SoTiet = TestUtility.Instance.RandomNumber();
			mock.SiSo = TestUtility.Instance.RandomNumber();
			mock.LopClc = TestUtility.Instance.RandomBoolean();
			mock.SoTietDayChuNhat = TestUtility.Instance.RandomNumber();
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomNumber();
			mock.HeSoLopDongLyThuyet = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoLopDongThTnTt = (decimal)TestUtility.Instance.RandomShort();
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.Ho = TestUtility.Instance.RandomString(24, false);;
			mock.Ten = TestUtility.Instance.RandomString(24, false);;
			mock.HoTen = TestUtility.Instance.RandomString(49, false);;
			mock.MaHocHam = TestUtility.Instance.RandomNumber();
			mock.MaHocVi = TestUtility.Instance.RandomNumber();
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaDonVi = TestUtility.Instance.RandomString(9, false);;
			mock.DonGia = (decimal)TestUtility.Instance.RandomShort();
			mock.TietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.ThanhTienDayChuNhat = (decimal)TestUtility.Instance.RandomShort();
			mock.ThanhTien = (decimal)TestUtility.Instance.RandomShort();
			mock.TongThanhTien = (decimal)TestUtility.Instance.RandomShort();
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
			mock.DaChot = TestUtility.Instance.RandomBoolean();
			mock.HeSoHocKy = (decimal)TestUtility.Instance.RandomShort();
			mock.SoGioThucGiangTrenLop = (decimal)TestUtility.Instance.RandomShort();
			mock.SoGioChuanTinhThem = (decimal)TestUtility.Instance.RandomShort();
			mock.MaDiaDiem = TestUtility.Instance.RandomString(9, false);;
			
			//OneToOneRelationship
			SdhUteKhoiLuongQuyDoi mockSdhUteKhoiLuongQuyDoiByIdKhoiLuongQuyDoi = SdhUteKhoiLuongQuyDoiTest.CreateMockInstance(tm);
			DataRepository.SdhUteKhoiLuongQuyDoiProvider.Insert(tm, mockSdhUteKhoiLuongQuyDoiByIdKhoiLuongQuyDoi);
			mock.IdKhoiLuongQuyDoi = mockSdhUteKhoiLuongQuyDoiByIdKhoiLuongQuyDoi.Id;
					
		}
		#endregion
    }
}