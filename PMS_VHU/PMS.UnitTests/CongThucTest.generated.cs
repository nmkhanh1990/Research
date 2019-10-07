﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file CongThucTest.cs instead.
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
    /// Provides tests for the and <see cref="CongThuc"/> objects (entity, collection and repository).
    /// </summary>
   public partial class CongThucTest
    {
    	// the CongThuc instance used to test the repository.
		protected CongThuc mock;
		
		// the TList<CongThuc> instance used to test the repository.
		protected TList<CongThuc> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the CongThuc Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock CongThuc entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.CongThucProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.CongThucProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all CongThuc objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.CongThucProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.CongThucProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.CongThucProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all CongThuc children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.CongThucProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.CongThucProvider.DeepLoading += new EntityProviderBaseCore<CongThuc, CongThucKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.CongThucProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("CongThuc instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.CongThucProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock CongThuc entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				CongThuc mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.CongThucProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.CongThucProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.CongThucProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock CongThuc entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (CongThuc)CreateMockInstance(tm);
				DataRepository.CongThucProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.CongThucProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.CongThucProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock CongThuc entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_CongThuc.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock CongThuc entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_CongThuc.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<CongThuc>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a CongThuc collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_CongThucCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<CongThuc> mockCollection = new TList<CongThuc>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<CongThuc> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a CongThuc collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_CongThucCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<CongThuc>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<CongThuc> mockCollection = (TList<CongThuc>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<CongThuc> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				CongThuc entity = CreateMockInstance(tm);
				bool result = DataRepository.CongThucProvider.Insert(tm, entity);
				
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
				CongThuc entity = CreateMockInstance(tm);
				bool result = DataRepository.CongThucProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				CongThuc t0 = DataRepository.CongThucProvider.GetById(tm, entity.Id);
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
				
				CongThuc entity = mock.Copy() as CongThuc;
				entity = (CongThuc)mock.Clone();
				Assert.IsTrue(CongThuc.ValueEquals(entity, mock), "Clone is not working");
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
				CongThuc mock = CreateMockInstance(tm);
				bool result = DataRepository.CongThucProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				CongThucQuery query = new CongThucQuery();
			
				query.AppendEquals(CongThucColumn.Id, mock.Id.ToString());
				if(mock.YearStudy != null)
					query.AppendEquals(CongThucColumn.YearStudy, mock.YearStudy.ToString());
				if(mock.Name != null)
					query.AppendEquals(CongThucColumn.Name, mock.Name.ToString());
				if(mock.Col01 != null)
					query.AppendEquals(CongThucColumn.Col01, mock.Col01.ToString());
				if(mock.Col02 != null)
					query.AppendEquals(CongThucColumn.Col02, mock.Col02.ToString());
				if(mock.Col03 != null)
					query.AppendEquals(CongThucColumn.Col03, mock.Col03.ToString());
				if(mock.Col04 != null)
					query.AppendEquals(CongThucColumn.Col04, mock.Col04.ToString());
				if(mock.Col05 != null)
					query.AppendEquals(CongThucColumn.Col05, mock.Col05.ToString());
				if(mock.Col06 != null)
					query.AppendEquals(CongThucColumn.Col06, mock.Col06.ToString());
				if(mock.Col07 != null)
					query.AppendEquals(CongThucColumn.Col07, mock.Col07.ToString());
				if(mock.Col08 != null)
					query.AppendEquals(CongThucColumn.Col08, mock.Col08.ToString());
				if(mock.UpdateDate != null)
					query.AppendEquals(CongThucColumn.UpdateDate, mock.UpdateDate.ToString());
				if(mock.UpdateStaff != null)
					query.AppendEquals(CongThucColumn.UpdateStaff, mock.UpdateStaff.ToString());
				
				TList<CongThuc> results = DataRepository.CongThucProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed CongThuc Entity with mock values.
		///</summary>
		static public CongThuc CreateMockInstance_Generated(TransactionManager tm)
		{		
			CongThuc mock = new CongThuc();
						
			mock.YearStudy = TestUtility.Instance.RandomString(9, false);;
			mock.Name = TestUtility.Instance.RandomString(249, false);;
			mock.Col01 = (decimal)TestUtility.Instance.RandomShort();
			mock.Col02 = (decimal)TestUtility.Instance.RandomShort();
			mock.Col03 = (decimal)TestUtility.Instance.RandomShort();
			mock.Col04 = (decimal)TestUtility.Instance.RandomShort();
			mock.Col05 = (decimal)TestUtility.Instance.RandomShort();
			mock.Col06 = (decimal)TestUtility.Instance.RandomShort();
			mock.Col07 = (decimal)TestUtility.Instance.RandomShort();
			mock.Col08 = (decimal)TestUtility.Instance.RandomShort();
			mock.UpdateDate = TestUtility.Instance.RandomString(24, false);;
			mock.UpdateStaff = TestUtility.Instance.RandomString(24, false);;
			
		
			// create a temporary collection and add the item to it
			TList<CongThuc> tempMockCollection = new TList<CongThuc>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (CongThuc)mock;
		}
		
		
		///<summary>
		///  Update the Typed CongThuc Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, CongThuc mock)
		{
			mock.YearStudy = TestUtility.Instance.RandomString(9, false);;
			mock.Name = TestUtility.Instance.RandomString(249, false);;
			mock.Col01 = (decimal)TestUtility.Instance.RandomShort();
			mock.Col02 = (decimal)TestUtility.Instance.RandomShort();
			mock.Col03 = (decimal)TestUtility.Instance.RandomShort();
			mock.Col04 = (decimal)TestUtility.Instance.RandomShort();
			mock.Col05 = (decimal)TestUtility.Instance.RandomShort();
			mock.Col06 = (decimal)TestUtility.Instance.RandomShort();
			mock.Col07 = (decimal)TestUtility.Instance.RandomShort();
			mock.Col08 = (decimal)TestUtility.Instance.RandomShort();
			mock.UpdateDate = TestUtility.Instance.RandomString(24, false);;
			mock.UpdateStaff = TestUtility.Instance.RandomString(24, false);;
			
		}
		#endregion
    }
}