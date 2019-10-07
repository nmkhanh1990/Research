﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file KhoiLuongGiangDayTungTuanTest.cs instead.
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
    /// Provides tests for the and <see cref="KhoiLuongGiangDayTungTuan"/> objects (entity, collection and repository).
    /// </summary>
   public partial class KhoiLuongGiangDayTungTuanTest
    {
    	// the KhoiLuongGiangDayTungTuan instance used to test the repository.
		protected KhoiLuongGiangDayTungTuan mock;
		
		// the TList<KhoiLuongGiangDayTungTuan> instance used to test the repository.
		protected TList<KhoiLuongGiangDayTungTuan> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the KhoiLuongGiangDayTungTuan Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock KhoiLuongGiangDayTungTuan entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KhoiLuongGiangDayTungTuanProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.KhoiLuongGiangDayTungTuanProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all KhoiLuongGiangDayTungTuan objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.KhoiLuongGiangDayTungTuanProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.KhoiLuongGiangDayTungTuanProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.KhoiLuongGiangDayTungTuanProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all KhoiLuongGiangDayTungTuan children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.KhoiLuongGiangDayTungTuanProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.KhoiLuongGiangDayTungTuanProvider.DeepLoading += new EntityProviderBaseCore<KhoiLuongGiangDayTungTuan, KhoiLuongGiangDayTungTuanKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.KhoiLuongGiangDayTungTuanProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("KhoiLuongGiangDayTungTuan instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.KhoiLuongGiangDayTungTuanProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock KhoiLuongGiangDayTungTuan entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KhoiLuongGiangDayTungTuan mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KhoiLuongGiangDayTungTuanProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.KhoiLuongGiangDayTungTuanProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.KhoiLuongGiangDayTungTuanProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock KhoiLuongGiangDayTungTuan entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (KhoiLuongGiangDayTungTuan)CreateMockInstance(tm);
				DataRepository.KhoiLuongGiangDayTungTuanProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.KhoiLuongGiangDayTungTuanProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.KhoiLuongGiangDayTungTuanProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock KhoiLuongGiangDayTungTuan entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoiLuongGiangDayTungTuan.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock KhoiLuongGiangDayTungTuan entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoiLuongGiangDayTungTuan.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<KhoiLuongGiangDayTungTuan>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a KhoiLuongGiangDayTungTuan collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoiLuongGiangDayTungTuanCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<KhoiLuongGiangDayTungTuan> mockCollection = new TList<KhoiLuongGiangDayTungTuan>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<KhoiLuongGiangDayTungTuan> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a KhoiLuongGiangDayTungTuan collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoiLuongGiangDayTungTuanCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<KhoiLuongGiangDayTungTuan>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<KhoiLuongGiangDayTungTuan> mockCollection = (TList<KhoiLuongGiangDayTungTuan>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<KhoiLuongGiangDayTungTuan> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KhoiLuongGiangDayTungTuan entity = CreateMockInstance(tm);
				bool result = DataRepository.KhoiLuongGiangDayTungTuanProvider.Insert(tm, entity);
				
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
				KhoiLuongGiangDayTungTuan entity = CreateMockInstance(tm);
				bool result = DataRepository.KhoiLuongGiangDayTungTuanProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				KhoiLuongGiangDayTungTuan t0 = DataRepository.KhoiLuongGiangDayTungTuanProvider.GetByMaKhoiLuong(tm, entity.MaKhoiLuong);
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
				
				KhoiLuongGiangDayTungTuan entity = mock.Copy() as KhoiLuongGiangDayTungTuan;
				entity = (KhoiLuongGiangDayTungTuan)mock.Clone();
				Assert.IsTrue(KhoiLuongGiangDayTungTuan.ValueEquals(entity, mock), "Clone is not working");
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
				KhoiLuongGiangDayTungTuan mock = CreateMockInstance(tm);
				bool result = DataRepository.KhoiLuongGiangDayTungTuanProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				KhoiLuongGiangDayTungTuanQuery query = new KhoiLuongGiangDayTungTuanQuery();
			
				query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.MaKhoiLuong, mock.MaKhoiLuong.ToString());
				if(mock.MaToaNha != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.MaToaNha, mock.MaToaNha.ToString());
				if(mock.MaLopHocPhan != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.MaLopHocPhan, mock.MaLopHocPhan.ToString());
				if(mock.MaLop != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.MaLop, mock.MaLop.ToString());
				if(mock.MaNhom != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.MaNhom, mock.MaNhom.ToString());
				if(mock.LoaiHocPhan != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.LoaiHocPhan, mock.LoaiHocPhan.ToString());
				if(mock.PhanLoai != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.PhanLoai, mock.PhanLoai.ToString());
				if(mock.MaMonHoc != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.MaMonHoc, mock.MaMonHoc.ToString());
				if(mock.DienGiai != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.DienGiai, mock.DienGiai.ToString());
				if(mock.SoTiet != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.SoTiet, mock.SoTiet.ToString());
				if(mock.SoTinChi != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.SoTinChi, mock.SoTinChi.ToString());
				if(mock.SiSoLop != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.SiSoLop, mock.SiSoLop.ToString());
				if(mock.SoNhom != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.SoNhom, mock.SoNhom.ToString());
				if(mock.MaDiaDiem != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.MaDiaDiem, mock.MaDiaDiem.ToString());
				if(mock.NgayBatDau != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.NgayBatDau, mock.NgayBatDau.ToString());
				if(mock.NgayKetThuc != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.NgayKetThuc, mock.NgayKetThuc.ToString());
				if(mock.ChatLuongCao != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.ChatLuongCao, mock.ChatLuongCao.ToString());
				if(mock.NgoaiGio != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.NgoaiGio, mock.NgoaiGio.ToString());
				if(mock.TrongGio != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.TrongGio, mock.TrongGio.ToString());
				if(mock.HeSoLopDong != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.HeSoLopDong, mock.HeSoLopDong.ToString());
				if(mock.HeSoCoSo != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.HeSoCoSo, mock.HeSoCoSo.ToString());
				if(mock.HeSoHocKy != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.HeSoHocKy, mock.HeSoHocKy.ToString());
				if(mock.HeSoThanhPhan != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.HeSoThanhPhan, mock.HeSoThanhPhan.ToString());
				if(mock.HeSoTrongGio != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.HeSoTrongGio, mock.HeSoTrongGio.ToString());
				if(mock.HeSoNgoaiGio != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.HeSoNgoaiGio, mock.HeSoNgoaiGio.ToString());
				if(mock.TietQuyDoi != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.TietQuyDoi, mock.TietQuyDoi.ToString());
				if(mock.LoaiHocKy != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.LoaiHocKy, mock.LoaiHocKy.ToString());
				if(mock.ThoiKhoaBieu != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.ThoiKhoaBieu, mock.ThoiKhoaBieu.ToString());
				if(mock.NgayTao != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.NgayTao, mock.NgayTao.ToString());
				if(mock.MaQuanLy != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.MaQuanLy, mock.MaQuanLy.ToString());
				if(mock.Tuan != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.Tuan, mock.Tuan.ToString());
				if(mock.Nam != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.Nam, mock.Nam.ToString());
				if(mock.NgayDay != null)
					query.AppendEquals(KhoiLuongGiangDayTungTuanColumn.NgayDay, mock.NgayDay.ToString());
				
				TList<KhoiLuongGiangDayTungTuan> results = DataRepository.KhoiLuongGiangDayTungTuanProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed KhoiLuongGiangDayTungTuan Entity with mock values.
		///</summary>
		static public KhoiLuongGiangDayTungTuan CreateMockInstance_Generated(TransactionManager tm)
		{		
			KhoiLuongGiangDayTungTuan mock = new KhoiLuongGiangDayTungTuan();
						
			mock.MaToaNha = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.MaLop = TestUtility.Instance.RandomString(9, false);;
			mock.MaNhom = TestUtility.Instance.RandomString(9, false);;
			mock.LoaiHocPhan = TestUtility.Instance.RandomString(9, false);;
			mock.PhanLoai = TestUtility.Instance.RandomString(9, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.DienGiai = TestUtility.Instance.RandomString(49, false);;
			mock.SoTiet = (decimal)TestUtility.Instance.RandomShort();
			mock.SoTinChi = (decimal)TestUtility.Instance.RandomShort();
			mock.SiSoLop = TestUtility.Instance.RandomNumber();
			mock.SoNhom = TestUtility.Instance.RandomNumber();
			mock.MaDiaDiem = TestUtility.Instance.RandomString(9, false);;
			mock.NgayBatDau = TestUtility.Instance.RandomDateTime();
			mock.NgayKetThuc = TestUtility.Instance.RandomDateTime();
			mock.ChatLuongCao = (decimal)TestUtility.Instance.RandomShort();
			mock.NgoaiGio = (decimal)TestUtility.Instance.RandomShort();
			mock.TrongGio = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoLopDong = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoCoSo = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoHocKy = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoThanhPhan = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoTrongGio = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoNgoaiGio = (decimal)TestUtility.Instance.RandomShort();
			mock.TietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.LoaiHocKy = TestUtility.Instance.RandomNumber();
			mock.ThoiKhoaBieu = TestUtility.Instance.RandomString(49, false);;
			mock.NgayTao = TestUtility.Instance.RandomDateTime();
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.Tuan = TestUtility.Instance.RandomNumber();
			mock.Nam = TestUtility.Instance.RandomNumber();
			mock.NgayDay = TestUtility.Instance.RandomDateTime();
			
		
			// create a temporary collection and add the item to it
			TList<KhoiLuongGiangDayTungTuan> tempMockCollection = new TList<KhoiLuongGiangDayTungTuan>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (KhoiLuongGiangDayTungTuan)mock;
		}
		
		
		///<summary>
		///  Update the Typed KhoiLuongGiangDayTungTuan Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, KhoiLuongGiangDayTungTuan mock)
		{
			mock.MaToaNha = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.MaLop = TestUtility.Instance.RandomString(9, false);;
			mock.MaNhom = TestUtility.Instance.RandomString(9, false);;
			mock.LoaiHocPhan = TestUtility.Instance.RandomString(9, false);;
			mock.PhanLoai = TestUtility.Instance.RandomString(9, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.DienGiai = TestUtility.Instance.RandomString(49, false);;
			mock.SoTiet = (decimal)TestUtility.Instance.RandomShort();
			mock.SoTinChi = (decimal)TestUtility.Instance.RandomShort();
			mock.SiSoLop = TestUtility.Instance.RandomNumber();
			mock.SoNhom = TestUtility.Instance.RandomNumber();
			mock.MaDiaDiem = TestUtility.Instance.RandomString(9, false);;
			mock.NgayBatDau = TestUtility.Instance.RandomDateTime();
			mock.NgayKetThuc = TestUtility.Instance.RandomDateTime();
			mock.ChatLuongCao = (decimal)TestUtility.Instance.RandomShort();
			mock.NgoaiGio = (decimal)TestUtility.Instance.RandomShort();
			mock.TrongGio = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoLopDong = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoCoSo = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoHocKy = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoThanhPhan = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoTrongGio = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoNgoaiGio = (decimal)TestUtility.Instance.RandomShort();
			mock.TietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.LoaiHocKy = TestUtility.Instance.RandomNumber();
			mock.ThoiKhoaBieu = TestUtility.Instance.RandomString(49, false);;
			mock.NgayTao = TestUtility.Instance.RandomDateTime();
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.Tuan = TestUtility.Instance.RandomNumber();
			mock.Nam = TestUtility.Instance.RandomNumber();
			mock.NgayDay = TestUtility.Instance.RandomDateTime();
			
		}
		#endregion
    }
}
