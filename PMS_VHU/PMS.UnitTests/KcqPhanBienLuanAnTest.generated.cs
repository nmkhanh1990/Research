﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file KcqPhanBienLuanAnTest.cs instead.
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
    /// Provides tests for the and <see cref="KcqPhanBienLuanAn"/> objects (entity, collection and repository).
    /// </summary>
   public partial class KcqPhanBienLuanAnTest
    {
    	// the KcqPhanBienLuanAn instance used to test the repository.
		protected KcqPhanBienLuanAn mock;
		
		// the TList<KcqPhanBienLuanAn> instance used to test the repository.
		protected TList<KcqPhanBienLuanAn> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the KcqPhanBienLuanAn Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock KcqPhanBienLuanAn entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KcqPhanBienLuanAnProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.KcqPhanBienLuanAnProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all KcqPhanBienLuanAn objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.KcqPhanBienLuanAnProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.KcqPhanBienLuanAnProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.KcqPhanBienLuanAnProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all KcqPhanBienLuanAn children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.KcqPhanBienLuanAnProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.KcqPhanBienLuanAnProvider.DeepLoading += new EntityProviderBaseCore<KcqPhanBienLuanAn, KcqPhanBienLuanAnKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.KcqPhanBienLuanAnProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("KcqPhanBienLuanAn instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.KcqPhanBienLuanAnProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock KcqPhanBienLuanAn entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KcqPhanBienLuanAn mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KcqPhanBienLuanAnProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.KcqPhanBienLuanAnProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.KcqPhanBienLuanAnProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock KcqPhanBienLuanAn entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (KcqPhanBienLuanAn)CreateMockInstance(tm);
				DataRepository.KcqPhanBienLuanAnProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.KcqPhanBienLuanAnProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.KcqPhanBienLuanAnProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock KcqPhanBienLuanAn entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KcqPhanBienLuanAn.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock KcqPhanBienLuanAn entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KcqPhanBienLuanAn.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<KcqPhanBienLuanAn>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a KcqPhanBienLuanAn collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KcqPhanBienLuanAnCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<KcqPhanBienLuanAn> mockCollection = new TList<KcqPhanBienLuanAn>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<KcqPhanBienLuanAn> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a KcqPhanBienLuanAn collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KcqPhanBienLuanAnCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<KcqPhanBienLuanAn>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<KcqPhanBienLuanAn> mockCollection = (TList<KcqPhanBienLuanAn>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<KcqPhanBienLuanAn> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KcqPhanBienLuanAn entity = CreateMockInstance(tm);
				bool result = DataRepository.KcqPhanBienLuanAnProvider.Insert(tm, entity);
				
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
				KcqPhanBienLuanAn entity = CreateMockInstance(tm);
				bool result = DataRepository.KcqPhanBienLuanAnProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				KcqPhanBienLuanAn t0 = DataRepository.KcqPhanBienLuanAnProvider.GetByMaGiangVienNamHocHocKyLoai(tm, entity.MaGiangVien, entity.NamHoc, entity.HocKy, entity.Loai);
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
				
				KcqPhanBienLuanAn entity = mock.Copy() as KcqPhanBienLuanAn;
				entity = (KcqPhanBienLuanAn)mock.Clone();
				Assert.IsTrue(KcqPhanBienLuanAn.ValueEquals(entity, mock), "Clone is not working");
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
				KcqPhanBienLuanAn mock = CreateMockInstance(tm);
				bool result = DataRepository.KcqPhanBienLuanAnProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				KcqPhanBienLuanAnQuery query = new KcqPhanBienLuanAnQuery();
			
				query.AppendEquals(KcqPhanBienLuanAnColumn.MaGiangVien, mock.MaGiangVien.ToString());
				query.AppendEquals(KcqPhanBienLuanAnColumn.NamHoc, mock.NamHoc.ToString());
				query.AppendEquals(KcqPhanBienLuanAnColumn.HocKy, mock.HocKy.ToString());
				if(mock.MaHocHam != null)
					query.AppendEquals(KcqPhanBienLuanAnColumn.MaHocHam, mock.MaHocHam.ToString());
				if(mock.MaHocVi != null)
					query.AppendEquals(KcqPhanBienLuanAnColumn.MaHocVi, mock.MaHocVi.ToString());
				if(mock.MaLoaiGiangVien != null)
					query.AppendEquals(KcqPhanBienLuanAnColumn.MaLoaiGiangVien, mock.MaLoaiGiangVien.ToString());
				if(mock.SoLuong != null)
					query.AppendEquals(KcqPhanBienLuanAnColumn.SoLuong, mock.SoLuong.ToString());
				if(mock.HeSo != null)
					query.AppendEquals(KcqPhanBienLuanAnColumn.HeSo, mock.HeSo.ToString());
				if(mock.TietQuyDoi != null)
					query.AppendEquals(KcqPhanBienLuanAnColumn.TietQuyDoi, mock.TietQuyDoi.ToString());
				if(mock.DonGia != null)
					query.AppendEquals(KcqPhanBienLuanAnColumn.DonGia, mock.DonGia.ToString());
				if(mock.TongThanhTien != null)
					query.AppendEquals(KcqPhanBienLuanAnColumn.TongThanhTien, mock.TongThanhTien.ToString());
				if(mock.NgayCapNhat != null)
					query.AppendEquals(KcqPhanBienLuanAnColumn.NgayCapNhat, mock.NgayCapNhat.ToString());
				if(mock.HeSoHocKy != null)
					query.AppendEquals(KcqPhanBienLuanAnColumn.HeSoHocKy, mock.HeSoHocKy.ToString());
				query.AppendEquals(KcqPhanBienLuanAnColumn.Loai, mock.Loai.ToString());
				if(mock.MaDot != null)
					query.AppendEquals(KcqPhanBienLuanAnColumn.MaDot, mock.MaDot.ToString());
				
				TList<KcqPhanBienLuanAn> results = DataRepository.KcqPhanBienLuanAnProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed KcqPhanBienLuanAn Entity with mock values.
		///</summary>
		static public KcqPhanBienLuanAn CreateMockInstance_Generated(TransactionManager tm)
		{		
			KcqPhanBienLuanAn mock = new KcqPhanBienLuanAn();
						
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaHocHam = TestUtility.Instance.RandomNumber();
			mock.MaHocVi = TestUtility.Instance.RandomNumber();
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.SoLuong = TestUtility.Instance.RandomNumber();
			mock.HeSo = (decimal)TestUtility.Instance.RandomShort();
			mock.TietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.DonGia = (decimal)TestUtility.Instance.RandomShort();
			mock.TongThanhTien = (decimal)TestUtility.Instance.RandomShort();
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
			mock.HeSoHocKy = (decimal)TestUtility.Instance.RandomShort();
			mock.Loai = TestUtility.Instance.RandomString(49, false);;
			mock.MaDot = TestUtility.Instance.RandomString(24, false);;
			
		
			// create a temporary collection and add the item to it
			TList<KcqPhanBienLuanAn> tempMockCollection = new TList<KcqPhanBienLuanAn>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (KcqPhanBienLuanAn)mock;
		}
		
		
		///<summary>
		///  Update the Typed KcqPhanBienLuanAn Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, KcqPhanBienLuanAn mock)
		{
			mock.MaHocHam = TestUtility.Instance.RandomNumber();
			mock.MaHocVi = TestUtility.Instance.RandomNumber();
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.SoLuong = TestUtility.Instance.RandomNumber();
			mock.HeSo = (decimal)TestUtility.Instance.RandomShort();
			mock.TietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.DonGia = (decimal)TestUtility.Instance.RandomShort();
			mock.TongThanhTien = (decimal)TestUtility.Instance.RandomShort();
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
			mock.HeSoHocKy = (decimal)TestUtility.Instance.RandomShort();
			mock.MaDot = TestUtility.Instance.RandomString(24, false);;
			
		}
		#endregion
    }
}
