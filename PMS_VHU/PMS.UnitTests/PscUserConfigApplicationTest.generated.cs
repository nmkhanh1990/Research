﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file PscUserConfigApplicationTest.cs instead.
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
    /// Provides tests for the and <see cref="PscUserConfigApplication"/> objects (entity, collection and repository).
    /// </summary>
   public partial class PscUserConfigApplicationTest
    {
    	// the PscUserConfigApplication instance used to test the repository.
		protected PscUserConfigApplication mock;
		
		// the TList<PscUserConfigApplication> instance used to test the repository.
		protected TList<PscUserConfigApplication> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the PscUserConfigApplication Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock PscUserConfigApplication entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.PscUserConfigApplicationProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.PscUserConfigApplicationProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all PscUserConfigApplication objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.PscUserConfigApplicationProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.PscUserConfigApplicationProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.PscUserConfigApplicationProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all PscUserConfigApplication children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.PscUserConfigApplicationProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.PscUserConfigApplicationProvider.DeepLoading += new EntityProviderBaseCore<PscUserConfigApplication, PscUserConfigApplicationKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.PscUserConfigApplicationProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("PscUserConfigApplication instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.PscUserConfigApplicationProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock PscUserConfigApplication entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				PscUserConfigApplication mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.PscUserConfigApplicationProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.PscUserConfigApplicationProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.PscUserConfigApplicationProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock PscUserConfigApplication entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (PscUserConfigApplication)CreateMockInstance(tm);
				DataRepository.PscUserConfigApplicationProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.PscUserConfigApplicationProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.PscUserConfigApplicationProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock PscUserConfigApplication entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PscUserConfigApplication.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock PscUserConfigApplication entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PscUserConfigApplication.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<PscUserConfigApplication>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a PscUserConfigApplication collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PscUserConfigApplicationCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<PscUserConfigApplication> mockCollection = new TList<PscUserConfigApplication>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<PscUserConfigApplication> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a PscUserConfigApplication collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PscUserConfigApplicationCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<PscUserConfigApplication>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<PscUserConfigApplication> mockCollection = (TList<PscUserConfigApplication>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<PscUserConfigApplication> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				PscUserConfigApplication entity = CreateMockInstance(tm);
				bool result = DataRepository.PscUserConfigApplicationProvider.Insert(tm, entity);
				
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
				PscUserConfigApplication entity = CreateMockInstance(tm);
				bool result = DataRepository.PscUserConfigApplicationProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				PscUserConfigApplication t0 = DataRepository.PscUserConfigApplicationProvider.GetByStaffIdConfigName(tm, entity.StaffId, entity.ConfigName);
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
				
				PscUserConfigApplication entity = mock.Copy() as PscUserConfigApplication;
				entity = (PscUserConfigApplication)mock.Clone();
				Assert.IsTrue(PscUserConfigApplication.ValueEquals(entity, mock), "Clone is not working");
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
				PscUserConfigApplication mock = CreateMockInstance(tm);
				bool result = DataRepository.PscUserConfigApplicationProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				PscUserConfigApplicationQuery query = new PscUserConfigApplicationQuery();
			
				query.AppendEquals(PscUserConfigApplicationColumn.StaffId, mock.StaffId.ToString());
				query.AppendEquals(PscUserConfigApplicationColumn.ConfigName, mock.ConfigName.ToString());
				
				TList<PscUserConfigApplication> results = DataRepository.PscUserConfigApplicationProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed PscUserConfigApplication Entity with mock values.
		///</summary>
		static public PscUserConfigApplication CreateMockInstance_Generated(TransactionManager tm)
		{		
			PscUserConfigApplication mock = new PscUserConfigApplication();
						
			mock.StaffId = TestUtility.Instance.RandomString(9, false);;
			mock.ConfigName = TestUtility.Instance.RandomString(126, false);;
			mock.ConfigValue = "<test></test>";
			
		
			// create a temporary collection and add the item to it
			TList<PscUserConfigApplication> tempMockCollection = new TList<PscUserConfigApplication>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (PscUserConfigApplication)mock;
		}
		
		
		///<summary>
		///  Update the Typed PscUserConfigApplication Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, PscUserConfigApplication mock)
		{
			mock.ConfigValue = "<test></test>";
			
		}
		#endregion
    }
}