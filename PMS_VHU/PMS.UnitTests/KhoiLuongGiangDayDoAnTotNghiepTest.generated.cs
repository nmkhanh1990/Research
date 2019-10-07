﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file KhoiLuongGiangDayDoAnTotNghiepTest.cs instead.
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
    /// Provides tests for the and <see cref="KhoiLuongGiangDayDoAnTotNghiep"/> objects (entity, collection and repository).
    /// </summary>
   public partial class KhoiLuongGiangDayDoAnTotNghiepTest
    {
    	// the KhoiLuongGiangDayDoAnTotNghiep instance used to test the repository.
		protected KhoiLuongGiangDayDoAnTotNghiep mock;
		
		// the TList<KhoiLuongGiangDayDoAnTotNghiep> instance used to test the repository.
		protected TList<KhoiLuongGiangDayDoAnTotNghiep> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the KhoiLuongGiangDayDoAnTotNghiep Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock KhoiLuongGiangDayDoAnTotNghiep entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KhoiLuongGiangDayDoAnTotNghiepProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.KhoiLuongGiangDayDoAnTotNghiepProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all KhoiLuongGiangDayDoAnTotNghiep objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.KhoiLuongGiangDayDoAnTotNghiepProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.KhoiLuongGiangDayDoAnTotNghiepProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.KhoiLuongGiangDayDoAnTotNghiepProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all KhoiLuongGiangDayDoAnTotNghiep children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.KhoiLuongGiangDayDoAnTotNghiepProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.KhoiLuongGiangDayDoAnTotNghiepProvider.DeepLoading += new EntityProviderBaseCore<KhoiLuongGiangDayDoAnTotNghiep, KhoiLuongGiangDayDoAnTotNghiepKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.KhoiLuongGiangDayDoAnTotNghiepProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("KhoiLuongGiangDayDoAnTotNghiep instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.KhoiLuongGiangDayDoAnTotNghiepProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock KhoiLuongGiangDayDoAnTotNghiep entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KhoiLuongGiangDayDoAnTotNghiep mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KhoiLuongGiangDayDoAnTotNghiepProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.KhoiLuongGiangDayDoAnTotNghiepProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.KhoiLuongGiangDayDoAnTotNghiepProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock KhoiLuongGiangDayDoAnTotNghiep entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (KhoiLuongGiangDayDoAnTotNghiep)CreateMockInstance(tm);
				DataRepository.KhoiLuongGiangDayDoAnTotNghiepProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.KhoiLuongGiangDayDoAnTotNghiepProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.KhoiLuongGiangDayDoAnTotNghiepProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock KhoiLuongGiangDayDoAnTotNghiep entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoiLuongGiangDayDoAnTotNghiep.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock KhoiLuongGiangDayDoAnTotNghiep entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoiLuongGiangDayDoAnTotNghiep.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<KhoiLuongGiangDayDoAnTotNghiep>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a KhoiLuongGiangDayDoAnTotNghiep collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoiLuongGiangDayDoAnTotNghiepCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<KhoiLuongGiangDayDoAnTotNghiep> mockCollection = new TList<KhoiLuongGiangDayDoAnTotNghiep>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<KhoiLuongGiangDayDoAnTotNghiep> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a KhoiLuongGiangDayDoAnTotNghiep collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoiLuongGiangDayDoAnTotNghiepCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<KhoiLuongGiangDayDoAnTotNghiep>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<KhoiLuongGiangDayDoAnTotNghiep> mockCollection = (TList<KhoiLuongGiangDayDoAnTotNghiep>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<KhoiLuongGiangDayDoAnTotNghiep> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KhoiLuongGiangDayDoAnTotNghiep entity = CreateMockInstance(tm);
				bool result = DataRepository.KhoiLuongGiangDayDoAnTotNghiepProvider.Insert(tm, entity);
				
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
				KhoiLuongGiangDayDoAnTotNghiep entity = CreateMockInstance(tm);
				bool result = DataRepository.KhoiLuongGiangDayDoAnTotNghiepProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				KhoiLuongGiangDayDoAnTotNghiep t0 = DataRepository.KhoiLuongGiangDayDoAnTotNghiepProvider.GetById(tm, entity.Id);
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
				
				KhoiLuongGiangDayDoAnTotNghiep entity = mock.Copy() as KhoiLuongGiangDayDoAnTotNghiep;
				entity = (KhoiLuongGiangDayDoAnTotNghiep)mock.Clone();
				Assert.IsTrue(KhoiLuongGiangDayDoAnTotNghiep.ValueEquals(entity, mock), "Clone is not working");
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
				KhoiLuongGiangDayDoAnTotNghiep mock = CreateMockInstance(tm);
				bool result = DataRepository.KhoiLuongGiangDayDoAnTotNghiepProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				KhoiLuongGiangDayDoAnTotNghiepQuery query = new KhoiLuongGiangDayDoAnTotNghiepQuery();
			
				query.AppendEquals(KhoiLuongGiangDayDoAnTotNghiepColumn.Id, mock.Id.ToString());
				if(mock.MaMonHoc != null)
					query.AppendEquals(KhoiLuongGiangDayDoAnTotNghiepColumn.MaMonHoc, mock.MaMonHoc.ToString());
				if(mock.TenMonHoc != null)
					query.AppendEquals(KhoiLuongGiangDayDoAnTotNghiepColumn.TenMonHoc, mock.TenMonHoc.ToString());
				if(mock.MaHocPhan != null)
					query.AppendEquals(KhoiLuongGiangDayDoAnTotNghiepColumn.MaHocPhan, mock.MaHocPhan.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(KhoiLuongGiangDayDoAnTotNghiepColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(KhoiLuongGiangDayDoAnTotNghiepColumn.HocKy, mock.HocKy.ToString());
				if(mock.MaLopHocPhan != null)
					query.AppendEquals(KhoiLuongGiangDayDoAnTotNghiepColumn.MaLopHocPhan, mock.MaLopHocPhan.ToString());
				if(mock.Nhom != null)
					query.AppendEquals(KhoiLuongGiangDayDoAnTotNghiepColumn.Nhom, mock.Nhom.ToString());
				if(mock.MaLop != null)
					query.AppendEquals(KhoiLuongGiangDayDoAnTotNghiepColumn.MaLop, mock.MaLop.ToString());
				if(mock.SoTinChi != null)
					query.AppendEquals(KhoiLuongGiangDayDoAnTotNghiepColumn.SoTinChi, mock.SoTinChi.ToString());
				if(mock.LopClc != null)
					query.AppendEquals(KhoiLuongGiangDayDoAnTotNghiepColumn.LopClc, mock.LopClc.ToString());
				if(mock.SiSo != null)
					query.AppendEquals(KhoiLuongGiangDayDoAnTotNghiepColumn.SiSo, mock.SiSo.ToString());
				if(mock.NgayCapNhat != null)
					query.AppendEquals(KhoiLuongGiangDayDoAnTotNghiepColumn.NgayCapNhat, mock.NgayCapNhat.ToString());
				
				TList<KhoiLuongGiangDayDoAnTotNghiep> results = DataRepository.KhoiLuongGiangDayDoAnTotNghiepProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed KhoiLuongGiangDayDoAnTotNghiep Entity with mock values.
		///</summary>
		static public KhoiLuongGiangDayDoAnTotNghiep CreateMockInstance_Generated(TransactionManager tm)
		{		
			KhoiLuongGiangDayDoAnTotNghiep mock = new KhoiLuongGiangDayDoAnTotNghiep();
						
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(126, false);;
			mock.MaHocPhan = TestUtility.Instance.RandomString(9, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.Nhom = TestUtility.Instance.RandomString(24, false);;
			mock.MaLop = TestUtility.Instance.RandomString(99, false);;
			mock.SoTinChi = TestUtility.Instance.RandomNumber();
			mock.LopClc = TestUtility.Instance.RandomBoolean();
			mock.SiSo = TestUtility.Instance.RandomNumber();
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
			
		
			// create a temporary collection and add the item to it
			TList<KhoiLuongGiangDayDoAnTotNghiep> tempMockCollection = new TList<KhoiLuongGiangDayDoAnTotNghiep>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (KhoiLuongGiangDayDoAnTotNghiep)mock;
		}
		
		
		///<summary>
		///  Update the Typed KhoiLuongGiangDayDoAnTotNghiep Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, KhoiLuongGiangDayDoAnTotNghiep mock)
		{
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(126, false);;
			mock.MaHocPhan = TestUtility.Instance.RandomString(9, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.Nhom = TestUtility.Instance.RandomString(24, false);;
			mock.MaLop = TestUtility.Instance.RandomString(99, false);;
			mock.SoTinChi = TestUtility.Instance.RandomNumber();
			mock.LopClc = TestUtility.Instance.RandomBoolean();
			mock.SiSo = TestUtility.Instance.RandomNumber();
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
			
		}
		#endregion
    }
}