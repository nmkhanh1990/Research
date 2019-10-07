﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file NgonNguGiangDayTest.cs instead.
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
    /// Provides tests for the and <see cref="NgonNguGiangDay"/> objects (entity, collection and repository).
    /// </summary>
   public partial class NgonNguGiangDayTest
    {
    	// the NgonNguGiangDay instance used to test the repository.
		protected NgonNguGiangDay mock;
		
		// the TList<NgonNguGiangDay> instance used to test the repository.
		protected TList<NgonNguGiangDay> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the NgonNguGiangDay Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock NgonNguGiangDay entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.NgonNguGiangDayProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.NgonNguGiangDayProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all NgonNguGiangDay objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.NgonNguGiangDayProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.NgonNguGiangDayProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.NgonNguGiangDayProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all NgonNguGiangDay children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.NgonNguGiangDayProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.NgonNguGiangDayProvider.DeepLoading += new EntityProviderBaseCore<NgonNguGiangDay, NgonNguGiangDayKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.NgonNguGiangDayProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("NgonNguGiangDay instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.NgonNguGiangDayProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock NgonNguGiangDay entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				NgonNguGiangDay mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.NgonNguGiangDayProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.NgonNguGiangDayProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.NgonNguGiangDayProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock NgonNguGiangDay entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (NgonNguGiangDay)CreateMockInstance(tm);
				DataRepository.NgonNguGiangDayProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.NgonNguGiangDayProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.NgonNguGiangDayProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock NgonNguGiangDay entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_NgonNguGiangDay.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock NgonNguGiangDay entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_NgonNguGiangDay.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<NgonNguGiangDay>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a NgonNguGiangDay collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_NgonNguGiangDayCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<NgonNguGiangDay> mockCollection = new TList<NgonNguGiangDay>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<NgonNguGiangDay> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a NgonNguGiangDay collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_NgonNguGiangDayCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<NgonNguGiangDay>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<NgonNguGiangDay> mockCollection = (TList<NgonNguGiangDay>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<NgonNguGiangDay> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				NgonNguGiangDay entity = CreateMockInstance(tm);
				bool result = DataRepository.NgonNguGiangDayProvider.Insert(tm, entity);
				
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
				NgonNguGiangDay entity = CreateMockInstance(tm);
				bool result = DataRepository.NgonNguGiangDayProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				NgonNguGiangDay t0 = DataRepository.NgonNguGiangDayProvider.GetByMaNgonNgu(tm, entity.MaNgonNgu);
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
				
				NgonNguGiangDay entity = mock.Copy() as NgonNguGiangDay;
				entity = (NgonNguGiangDay)mock.Clone();
				Assert.IsTrue(NgonNguGiangDay.ValueEquals(entity, mock), "Clone is not working");
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
				NgonNguGiangDay mock = CreateMockInstance(tm);
				bool result = DataRepository.NgonNguGiangDayProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				NgonNguGiangDayQuery query = new NgonNguGiangDayQuery();
			
				query.AppendEquals(NgonNguGiangDayColumn.MaNgonNgu, mock.MaNgonNgu.ToString());
				if(mock.TenNgonNgu != null)
					query.AppendEquals(NgonNguGiangDayColumn.TenNgonNgu, mock.TenNgonNgu.ToString());
				if(mock.TinhTrang != null)
					query.AppendEquals(NgonNguGiangDayColumn.TinhTrang, mock.TinhTrang.ToString());
				
				TList<NgonNguGiangDay> results = DataRepository.NgonNguGiangDayProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed NgonNguGiangDay Entity with mock values.
		///</summary>
		static public NgonNguGiangDay CreateMockInstance_Generated(TransactionManager tm)
		{		
			NgonNguGiangDay mock = new NgonNguGiangDay();
						
			mock.MaNgonNgu = TestUtility.Instance.RandomString(9, false);;
			mock.TenNgonNgu = TestUtility.Instance.RandomString(99, false);;
			mock.TinhTrang = TestUtility.Instance.RandomBoolean();
			
		
			// create a temporary collection and add the item to it
			TList<NgonNguGiangDay> tempMockCollection = new TList<NgonNguGiangDay>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (NgonNguGiangDay)mock;
		}
		
		
		///<summary>
		///  Update the Typed NgonNguGiangDay Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, NgonNguGiangDay mock)
		{
			mock.TenNgonNgu = TestUtility.Instance.RandomString(99, false);;
			mock.TinhTrang = TestUtility.Instance.RandomBoolean();
			
		}
		#endregion
    }
}
