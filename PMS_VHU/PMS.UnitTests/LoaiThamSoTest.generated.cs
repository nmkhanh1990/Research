﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file LoaiThamSoTest.cs instead.
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
    /// Provides tests for the and <see cref="LoaiThamSo"/> objects (entity, collection and repository).
    /// </summary>
   public partial class LoaiThamSoTest
    {
    	// the LoaiThamSo instance used to test the repository.
		protected LoaiThamSo mock;
		
		// the TList<LoaiThamSo> instance used to test the repository.
		protected TList<LoaiThamSo> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the LoaiThamSo Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock LoaiThamSo entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.LoaiThamSoProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.LoaiThamSoProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all LoaiThamSo objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.LoaiThamSoProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.LoaiThamSoProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.LoaiThamSoProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all LoaiThamSo children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.LoaiThamSoProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.LoaiThamSoProvider.DeepLoading += new EntityProviderBaseCore<LoaiThamSo, LoaiThamSoKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.LoaiThamSoProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("LoaiThamSo instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.LoaiThamSoProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock LoaiThamSo entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				LoaiThamSo mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.LoaiThamSoProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.LoaiThamSoProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.LoaiThamSoProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock LoaiThamSo entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (LoaiThamSo)CreateMockInstance(tm);
				DataRepository.LoaiThamSoProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.LoaiThamSoProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.LoaiThamSoProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock LoaiThamSo entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_LoaiThamSo.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock LoaiThamSo entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_LoaiThamSo.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<LoaiThamSo>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a LoaiThamSo collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_LoaiThamSoCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<LoaiThamSo> mockCollection = new TList<LoaiThamSo>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<LoaiThamSo> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a LoaiThamSo collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_LoaiThamSoCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<LoaiThamSo>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<LoaiThamSo> mockCollection = (TList<LoaiThamSo>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<LoaiThamSo> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				LoaiThamSo entity = CreateMockInstance(tm);
				bool result = DataRepository.LoaiThamSoProvider.Insert(tm, entity);
				
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
				LoaiThamSo entity = CreateMockInstance(tm);
				bool result = DataRepository.LoaiThamSoProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				LoaiThamSo t0 = DataRepository.LoaiThamSoProvider.GetByMaLoaiThamSo(tm, entity.MaLoaiThamSo);
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
				
				LoaiThamSo entity = mock.Copy() as LoaiThamSo;
				entity = (LoaiThamSo)mock.Clone();
				Assert.IsTrue(LoaiThamSo.ValueEquals(entity, mock), "Clone is not working");
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
				LoaiThamSo mock = CreateMockInstance(tm);
				bool result = DataRepository.LoaiThamSoProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				LoaiThamSoQuery query = new LoaiThamSoQuery();
			
				query.AppendEquals(LoaiThamSoColumn.MaLoaiThamSo, mock.MaLoaiThamSo.ToString());
				if(mock.TenLoaiThamSo != null)
					query.AppendEquals(LoaiThamSoColumn.TenLoaiThamSo, mock.TenLoaiThamSo.ToString());
				if(mock.TenBang != null)
					query.AppendEquals(LoaiThamSoColumn.TenBang, mock.TenBang.ToString());
				if(mock.GhiChu != null)
					query.AppendEquals(LoaiThamSoColumn.GhiChu, mock.GhiChu.ToString());
				
				TList<LoaiThamSo> results = DataRepository.LoaiThamSoProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed LoaiThamSo Entity with mock values.
		///</summary>
		static public LoaiThamSo CreateMockInstance_Generated(TransactionManager tm)
		{		
			LoaiThamSo mock = new LoaiThamSo();
						
			mock.MaLoaiThamSo = TestUtility.Instance.RandomString(9, false);;
			mock.TenLoaiThamSo = TestUtility.Instance.RandomString(49, false);;
			mock.TenBang = TestUtility.Instance.RandomString(24, false);;
			mock.GhiChu = TestUtility.Instance.RandomString(2, false);;
			
		
			// create a temporary collection and add the item to it
			TList<LoaiThamSo> tempMockCollection = new TList<LoaiThamSo>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (LoaiThamSo)mock;
		}
		
		
		///<summary>
		///  Update the Typed LoaiThamSo Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, LoaiThamSo mock)
		{
			mock.TenLoaiThamSo = TestUtility.Instance.RandomString(49, false);;
			mock.TenBang = TestUtility.Instance.RandomString(24, false);;
			mock.GhiChu = TestUtility.Instance.RandomString(2, false);;
			
		}
		#endregion
    }
}