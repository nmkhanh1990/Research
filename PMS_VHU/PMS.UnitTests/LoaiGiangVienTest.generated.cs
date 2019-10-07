﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file LoaiGiangVienTest.cs instead.
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
    /// Provides tests for the and <see cref="LoaiGiangVien"/> objects (entity, collection and repository).
    /// </summary>
   public partial class LoaiGiangVienTest
    {
    	// the LoaiGiangVien instance used to test the repository.
		protected LoaiGiangVien mock;
		
		// the TList<LoaiGiangVien> instance used to test the repository.
		protected TList<LoaiGiangVien> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the LoaiGiangVien Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock LoaiGiangVien entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.LoaiGiangVienProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.LoaiGiangVienProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all LoaiGiangVien objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.LoaiGiangVienProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.LoaiGiangVienProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.LoaiGiangVienProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all LoaiGiangVien children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.LoaiGiangVienProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.LoaiGiangVienProvider.DeepLoading += new EntityProviderBaseCore<LoaiGiangVien, LoaiGiangVienKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.LoaiGiangVienProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("LoaiGiangVien instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.LoaiGiangVienProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock LoaiGiangVien entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				LoaiGiangVien mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.LoaiGiangVienProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.LoaiGiangVienProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.LoaiGiangVienProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock LoaiGiangVien entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (LoaiGiangVien)CreateMockInstance(tm);
				DataRepository.LoaiGiangVienProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.LoaiGiangVienProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.LoaiGiangVienProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock LoaiGiangVien entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_LoaiGiangVien.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock LoaiGiangVien entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_LoaiGiangVien.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<LoaiGiangVien>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a LoaiGiangVien collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_LoaiGiangVienCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<LoaiGiangVien> mockCollection = new TList<LoaiGiangVien>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<LoaiGiangVien> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a LoaiGiangVien collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_LoaiGiangVienCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<LoaiGiangVien>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<LoaiGiangVien> mockCollection = (TList<LoaiGiangVien>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<LoaiGiangVien> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				LoaiGiangVien entity = CreateMockInstance(tm);
				bool result = DataRepository.LoaiGiangVienProvider.Insert(tm, entity);
				
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
				LoaiGiangVien entity = CreateMockInstance(tm);
				bool result = DataRepository.LoaiGiangVienProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				LoaiGiangVien t0 = DataRepository.LoaiGiangVienProvider.GetByMaQuanLy(tm, entity.MaQuanLy);
				LoaiGiangVien t1 = DataRepository.LoaiGiangVienProvider.GetByMaLoaiGiangVien(tm, entity.MaLoaiGiangVien);
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
				
				LoaiGiangVien entity = mock.Copy() as LoaiGiangVien;
				entity = (LoaiGiangVien)mock.Clone();
				Assert.IsTrue(LoaiGiangVien.ValueEquals(entity, mock), "Clone is not working");
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
				LoaiGiangVien mock = CreateMockInstance(tm);
				bool result = DataRepository.LoaiGiangVienProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				LoaiGiangVienQuery query = new LoaiGiangVienQuery();
			
				query.AppendEquals(LoaiGiangVienColumn.MaLoaiGiangVien, mock.MaLoaiGiangVien.ToString());
				query.AppendEquals(LoaiGiangVienColumn.MaQuanLy, mock.MaQuanLy.ToString());
				if(mock.TenLoaiGiangVien != null)
					query.AppendEquals(LoaiGiangVienColumn.TenLoaiGiangVien, mock.TenLoaiGiangVien.ToString());
				if(mock.TienThem != null)
					query.AppendEquals(LoaiGiangVienColumn.TienThem, mock.TienThem.ToString());
				if(mock.ThuTu != null)
					query.AppendEquals(LoaiGiangVienColumn.ThuTu, mock.ThuTu.ToString());
				if(mock.Hrmid != null)
					query.AppendEquals(LoaiGiangVienColumn.Hrmid, mock.Hrmid.ToString());
				if(mock.TinhTrang != null)
					query.AppendEquals(LoaiGiangVienColumn.TinhTrang, mock.TinhTrang.ToString());
				if(mock.TrangThai != null)
					query.AppendEquals(LoaiGiangVienColumn.TrangThai, mock.TrangThai.ToString());
				
				TList<LoaiGiangVien> results = DataRepository.LoaiGiangVienProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed LoaiGiangVien Entity with mock values.
		///</summary>
		static public LoaiGiangVien CreateMockInstance_Generated(TransactionManager tm)
		{		
			LoaiGiangVien mock = new LoaiGiangVien();
						
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.TenLoaiGiangVien = TestUtility.Instance.RandomString(49, false);;
			mock.TienThem = (decimal)TestUtility.Instance.RandomShort();
			mock.ThuTu = TestUtility.Instance.RandomNumber();
			mock.Hrmid = Guid.NewGuid();
			mock.TinhTrang = TestUtility.Instance.RandomBoolean();
			mock.TrangThai = TestUtility.Instance.RandomBoolean();
			
		
			// create a temporary collection and add the item to it
			TList<LoaiGiangVien> tempMockCollection = new TList<LoaiGiangVien>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (LoaiGiangVien)mock;
		}
		
		
		///<summary>
		///  Update the Typed LoaiGiangVien Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, LoaiGiangVien mock)
		{
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.TenLoaiGiangVien = TestUtility.Instance.RandomString(49, false);;
			mock.TienThem = (decimal)TestUtility.Instance.RandomShort();
			mock.ThuTu = TestUtility.Instance.RandomNumber();
			mock.Hrmid = Guid.NewGuid();
			mock.TinhTrang = TestUtility.Instance.RandomBoolean();
			mock.TrangThai = TestUtility.Instance.RandomBoolean();
			
		}
		#endregion
    }
}
