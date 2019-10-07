﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file NhomGiangVienTinhDinhMucTest.cs instead.
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
    /// Provides tests for the and <see cref="NhomGiangVienTinhDinhMuc"/> objects (entity, collection and repository).
    /// </summary>
   public partial class NhomGiangVienTinhDinhMucTest
    {
    	// the NhomGiangVienTinhDinhMuc instance used to test the repository.
		protected NhomGiangVienTinhDinhMuc mock;
		
		// the TList<NhomGiangVienTinhDinhMuc> instance used to test the repository.
		protected TList<NhomGiangVienTinhDinhMuc> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the NhomGiangVienTinhDinhMuc Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock NhomGiangVienTinhDinhMuc entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.NhomGiangVienTinhDinhMucProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.NhomGiangVienTinhDinhMucProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all NhomGiangVienTinhDinhMuc objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.NhomGiangVienTinhDinhMucProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.NhomGiangVienTinhDinhMucProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.NhomGiangVienTinhDinhMucProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all NhomGiangVienTinhDinhMuc children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.NhomGiangVienTinhDinhMucProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.NhomGiangVienTinhDinhMucProvider.DeepLoading += new EntityProviderBaseCore<NhomGiangVienTinhDinhMuc, NhomGiangVienTinhDinhMucKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.NhomGiangVienTinhDinhMucProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("NhomGiangVienTinhDinhMuc instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.NhomGiangVienTinhDinhMucProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock NhomGiangVienTinhDinhMuc entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				NhomGiangVienTinhDinhMuc mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.NhomGiangVienTinhDinhMucProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.NhomGiangVienTinhDinhMucProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.NhomGiangVienTinhDinhMucProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock NhomGiangVienTinhDinhMuc entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (NhomGiangVienTinhDinhMuc)CreateMockInstance(tm);
				DataRepository.NhomGiangVienTinhDinhMucProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.NhomGiangVienTinhDinhMucProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.NhomGiangVienTinhDinhMucProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock NhomGiangVienTinhDinhMuc entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_NhomGiangVienTinhDinhMuc.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock NhomGiangVienTinhDinhMuc entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_NhomGiangVienTinhDinhMuc.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<NhomGiangVienTinhDinhMuc>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a NhomGiangVienTinhDinhMuc collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_NhomGiangVienTinhDinhMucCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<NhomGiangVienTinhDinhMuc> mockCollection = new TList<NhomGiangVienTinhDinhMuc>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<NhomGiangVienTinhDinhMuc> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a NhomGiangVienTinhDinhMuc collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_NhomGiangVienTinhDinhMucCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<NhomGiangVienTinhDinhMuc>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<NhomGiangVienTinhDinhMuc> mockCollection = (TList<NhomGiangVienTinhDinhMuc>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<NhomGiangVienTinhDinhMuc> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				NhomGiangVienTinhDinhMuc entity = CreateMockInstance(tm);
				bool result = DataRepository.NhomGiangVienTinhDinhMucProvider.Insert(tm, entity);
				
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
				NhomGiangVienTinhDinhMuc entity = CreateMockInstance(tm);
				bool result = DataRepository.NhomGiangVienTinhDinhMucProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				NhomGiangVienTinhDinhMuc t0 = DataRepository.NhomGiangVienTinhDinhMucProvider.GetByMaNhomGiangVien(tm, entity.MaNhomGiangVien);
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
				
				NhomGiangVienTinhDinhMuc entity = mock.Copy() as NhomGiangVienTinhDinhMuc;
				entity = (NhomGiangVienTinhDinhMuc)mock.Clone();
				Assert.IsTrue(NhomGiangVienTinhDinhMuc.ValueEquals(entity, mock), "Clone is not working");
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
				NhomGiangVienTinhDinhMuc mock = CreateMockInstance(tm);
				bool result = DataRepository.NhomGiangVienTinhDinhMucProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				NhomGiangVienTinhDinhMucQuery query = new NhomGiangVienTinhDinhMucQuery();
			
				query.AppendEquals(NhomGiangVienTinhDinhMucColumn.MaNhomGiangVien, mock.MaNhomGiangVien.ToString());
				if(mock.TenNhomGiangVien != null)
					query.AppendEquals(NhomGiangVienTinhDinhMucColumn.TenNhomGiangVien, mock.TenNhomGiangVien.ToString());
				
				TList<NhomGiangVienTinhDinhMuc> results = DataRepository.NhomGiangVienTinhDinhMucProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed NhomGiangVienTinhDinhMuc Entity with mock values.
		///</summary>
		static public NhomGiangVienTinhDinhMuc CreateMockInstance_Generated(TransactionManager tm)
		{		
			NhomGiangVienTinhDinhMuc mock = new NhomGiangVienTinhDinhMuc();
						
			mock.MaNhomGiangVien = TestUtility.Instance.RandomString(24, false);;
			mock.TenNhomGiangVien = TestUtility.Instance.RandomString(2, false);;
			
		
			// create a temporary collection and add the item to it
			TList<NhomGiangVienTinhDinhMuc> tempMockCollection = new TList<NhomGiangVienTinhDinhMuc>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (NhomGiangVienTinhDinhMuc)mock;
		}
		
		
		///<summary>
		///  Update the Typed NhomGiangVienTinhDinhMuc Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, NhomGiangVienTinhDinhMuc mock)
		{
			mock.TenNhomGiangVien = TestUtility.Instance.RandomString(2, false);;
			
		}
		#endregion
    }
}
