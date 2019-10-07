﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file KcqDonGiaTest.cs instead.
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
    /// Provides tests for the and <see cref="KcqDonGia"/> objects (entity, collection and repository).
    /// </summary>
   public partial class KcqDonGiaTest
    {
    	// the KcqDonGia instance used to test the repository.
		protected KcqDonGia mock;
		
		// the TList<KcqDonGia> instance used to test the repository.
		protected TList<KcqDonGia> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the KcqDonGia Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock KcqDonGia entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KcqDonGiaProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.KcqDonGiaProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all KcqDonGia objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.KcqDonGiaProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.KcqDonGiaProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.KcqDonGiaProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all KcqDonGia children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.KcqDonGiaProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.KcqDonGiaProvider.DeepLoading += new EntityProviderBaseCore<KcqDonGia, KcqDonGiaKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.KcqDonGiaProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("KcqDonGia instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.KcqDonGiaProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock KcqDonGia entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KcqDonGia mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KcqDonGiaProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.KcqDonGiaProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.KcqDonGiaProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock KcqDonGia entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (KcqDonGia)CreateMockInstance(tm);
				DataRepository.KcqDonGiaProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.KcqDonGiaProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.KcqDonGiaProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock KcqDonGia entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KcqDonGia.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock KcqDonGia entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KcqDonGia.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<KcqDonGia>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a KcqDonGia collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KcqDonGiaCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<KcqDonGia> mockCollection = new TList<KcqDonGia>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<KcqDonGia> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a KcqDonGia collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KcqDonGiaCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<KcqDonGia>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<KcqDonGia> mockCollection = (TList<KcqDonGia>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<KcqDonGia> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KcqDonGia entity = CreateMockInstance(tm);
				bool result = DataRepository.KcqDonGiaProvider.Insert(tm, entity);
				
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
				KcqDonGia entity = CreateMockInstance(tm);
				bool result = DataRepository.KcqDonGiaProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				KcqDonGia t0 = DataRepository.KcqDonGiaProvider.GetById(tm, entity.Id);
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
				
				KcqDonGia entity = mock.Copy() as KcqDonGia;
				entity = (KcqDonGia)mock.Clone();
				Assert.IsTrue(KcqDonGia.ValueEquals(entity, mock), "Clone is not working");
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
				KcqDonGia mock = CreateMockInstance(tm);
				bool result = DataRepository.KcqDonGiaProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				KcqDonGiaQuery query = new KcqDonGiaQuery();
			
				query.AppendEquals(KcqDonGiaColumn.Id, mock.Id.ToString());
				if(mock.MaQuanLy != null)
					query.AppendEquals(KcqDonGiaColumn.MaQuanLy, mock.MaQuanLy.ToString());
				if(mock.MaLoaiGiangVien != null)
					query.AppendEquals(KcqDonGiaColumn.MaLoaiGiangVien, mock.MaLoaiGiangVien.ToString());
				if(mock.MaHocHam != null)
					query.AppendEquals(KcqDonGiaColumn.MaHocHam, mock.MaHocHam.ToString());
				if(mock.MaHocVi != null)
					query.AppendEquals(KcqDonGiaColumn.MaHocVi, mock.MaHocVi.ToString());
				if(mock.DonGia != null)
					query.AppendEquals(KcqDonGiaColumn.DonGia, mock.DonGia.ToString());
				if(mock.NgayCapNhat != null)
					query.AppendEquals(KcqDonGiaColumn.NgayCapNhat, mock.NgayCapNhat.ToString());
				if(mock.NguoiCapNhat != null)
					query.AppendEquals(KcqDonGiaColumn.NguoiCapNhat, mock.NguoiCapNhat.ToString());
				if(mock.DonGiaClc != null)
					query.AppendEquals(KcqDonGiaColumn.DonGiaClc, mock.DonGiaClc.ToString());
				if(mock.HeSoQuyDoiChatLuong != null)
					query.AppendEquals(KcqDonGiaColumn.HeSoQuyDoiChatLuong, mock.HeSoQuyDoiChatLuong.ToString());
				if(mock.DonGiaTrongChuan != null)
					query.AppendEquals(KcqDonGiaColumn.DonGiaTrongChuan, mock.DonGiaTrongChuan.ToString());
				if(mock.DonGiaNgoaiChuan != null)
					query.AppendEquals(KcqDonGiaColumn.DonGiaNgoaiChuan, mock.DonGiaNgoaiChuan.ToString());
				if(mock.MaHinhThucDaoTao != null)
					query.AppendEquals(KcqDonGiaColumn.MaHinhThucDaoTao, mock.MaHinhThucDaoTao.ToString());
				if(mock.BacDaoTao != null)
					query.AppendEquals(KcqDonGiaColumn.BacDaoTao, mock.BacDaoTao.ToString());
				if(mock.NgonNguGiangDay != null)
					query.AppendEquals(KcqDonGiaColumn.NgonNguGiangDay, mock.NgonNguGiangDay.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(KcqDonGiaColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(KcqDonGiaColumn.HocKy, mock.HocKy.ToString());
				
				TList<KcqDonGia> results = DataRepository.KcqDonGiaProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed KcqDonGia Entity with mock values.
		///</summary>
		static public KcqDonGia CreateMockInstance_Generated(TransactionManager tm)
		{		
			KcqDonGia mock = new KcqDonGia();
						
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaHocHam = TestUtility.Instance.RandomNumber();
			mock.MaHocVi = TestUtility.Instance.RandomNumber();
			mock.DonGia = (decimal)TestUtility.Instance.RandomShort();
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.DonGiaClc = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoQuyDoiChatLuong = (decimal)TestUtility.Instance.RandomShort();
			mock.DonGiaTrongChuan = (decimal)TestUtility.Instance.RandomShort();
			mock.DonGiaNgoaiChuan = (decimal)TestUtility.Instance.RandomShort();
			mock.MaHinhThucDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.BacDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.NgonNguGiangDay = TestUtility.Instance.RandomString(9, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			
		
			// create a temporary collection and add the item to it
			TList<KcqDonGia> tempMockCollection = new TList<KcqDonGia>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (KcqDonGia)mock;
		}
		
		
		///<summary>
		///  Update the Typed KcqDonGia Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, KcqDonGia mock)
		{
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaHocHam = TestUtility.Instance.RandomNumber();
			mock.MaHocVi = TestUtility.Instance.RandomNumber();
			mock.DonGia = (decimal)TestUtility.Instance.RandomShort();
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.DonGiaClc = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoQuyDoiChatLuong = (decimal)TestUtility.Instance.RandomShort();
			mock.DonGiaTrongChuan = (decimal)TestUtility.Instance.RandomShort();
			mock.DonGiaNgoaiChuan = (decimal)TestUtility.Instance.RandomShort();
			mock.MaHinhThucDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.BacDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.NgonNguGiangDay = TestUtility.Instance.RandomString(9, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			
		}
		#endregion
    }
}