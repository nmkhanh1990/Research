﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file MonHocTinhHeSoKhoiNganhTest.cs instead.
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
    /// Provides tests for the and <see cref="MonHocTinhHeSoKhoiNganh"/> objects (entity, collection and repository).
    /// </summary>
   public partial class MonHocTinhHeSoKhoiNganhTest
    {
    	// the MonHocTinhHeSoKhoiNganh instance used to test the repository.
		protected MonHocTinhHeSoKhoiNganh mock;
		
		// the TList<MonHocTinhHeSoKhoiNganh> instance used to test the repository.
		protected TList<MonHocTinhHeSoKhoiNganh> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the MonHocTinhHeSoKhoiNganh Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock MonHocTinhHeSoKhoiNganh entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.MonHocTinhHeSoKhoiNganhProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.MonHocTinhHeSoKhoiNganhProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all MonHocTinhHeSoKhoiNganh objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.MonHocTinhHeSoKhoiNganhProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.MonHocTinhHeSoKhoiNganhProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.MonHocTinhHeSoKhoiNganhProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all MonHocTinhHeSoKhoiNganh children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.MonHocTinhHeSoKhoiNganhProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.MonHocTinhHeSoKhoiNganhProvider.DeepLoading += new EntityProviderBaseCore<MonHocTinhHeSoKhoiNganh, MonHocTinhHeSoKhoiNganhKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.MonHocTinhHeSoKhoiNganhProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("MonHocTinhHeSoKhoiNganh instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.MonHocTinhHeSoKhoiNganhProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock MonHocTinhHeSoKhoiNganh entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				MonHocTinhHeSoKhoiNganh mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.MonHocTinhHeSoKhoiNganhProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.MonHocTinhHeSoKhoiNganhProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.MonHocTinhHeSoKhoiNganhProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock MonHocTinhHeSoKhoiNganh entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (MonHocTinhHeSoKhoiNganh)CreateMockInstance(tm);
				DataRepository.MonHocTinhHeSoKhoiNganhProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.MonHocTinhHeSoKhoiNganhProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.MonHocTinhHeSoKhoiNganhProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock MonHocTinhHeSoKhoiNganh entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_MonHocTinhHeSoKhoiNganh.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock MonHocTinhHeSoKhoiNganh entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_MonHocTinhHeSoKhoiNganh.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<MonHocTinhHeSoKhoiNganh>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a MonHocTinhHeSoKhoiNganh collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_MonHocTinhHeSoKhoiNganhCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<MonHocTinhHeSoKhoiNganh> mockCollection = new TList<MonHocTinhHeSoKhoiNganh>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<MonHocTinhHeSoKhoiNganh> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a MonHocTinhHeSoKhoiNganh collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_MonHocTinhHeSoKhoiNganhCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<MonHocTinhHeSoKhoiNganh>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<MonHocTinhHeSoKhoiNganh> mockCollection = (TList<MonHocTinhHeSoKhoiNganh>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<MonHocTinhHeSoKhoiNganh> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				MonHocTinhHeSoKhoiNganh entity = CreateMockInstance(tm);
				bool result = DataRepository.MonHocTinhHeSoKhoiNganhProvider.Insert(tm, entity);
				
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
				MonHocTinhHeSoKhoiNganh entity = CreateMockInstance(tm);
				bool result = DataRepository.MonHocTinhHeSoKhoiNganhProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				MonHocTinhHeSoKhoiNganh t0 = DataRepository.MonHocTinhHeSoKhoiNganhProvider.GetById(tm, entity.Id);
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
				
				MonHocTinhHeSoKhoiNganh entity = mock.Copy() as MonHocTinhHeSoKhoiNganh;
				entity = (MonHocTinhHeSoKhoiNganh)mock.Clone();
				Assert.IsTrue(MonHocTinhHeSoKhoiNganh.ValueEquals(entity, mock), "Clone is not working");
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
				MonHocTinhHeSoKhoiNganh mock = CreateMockInstance(tm);
				bool result = DataRepository.MonHocTinhHeSoKhoiNganhProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				MonHocTinhHeSoKhoiNganhQuery query = new MonHocTinhHeSoKhoiNganhQuery();
			
				query.AppendEquals(MonHocTinhHeSoKhoiNganhColumn.Id, mock.Id.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(MonHocTinhHeSoKhoiNganhColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(MonHocTinhHeSoKhoiNganhColumn.HocKy, mock.HocKy.ToString());
				if(mock.MaMonHoc != null)
					query.AppendEquals(MonHocTinhHeSoKhoiNganhColumn.MaMonHoc, mock.MaMonHoc.ToString());
				if(mock.CoTinhHeSoKhoiNganh != null)
					query.AppendEquals(MonHocTinhHeSoKhoiNganhColumn.CoTinhHeSoKhoiNganh, mock.CoTinhHeSoKhoiNganh.ToString());
				if(mock.MaLoaiHocPhan != null)
					query.AppendEquals(MonHocTinhHeSoKhoiNganhColumn.MaLoaiHocPhan, mock.MaLoaiHocPhan.ToString());
				
				TList<MonHocTinhHeSoKhoiNganh> results = DataRepository.MonHocTinhHeSoKhoiNganhProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed MonHocTinhHeSoKhoiNganh Entity with mock values.
		///</summary>
		static public MonHocTinhHeSoKhoiNganh CreateMockInstance_Generated(TransactionManager tm)
		{		
			MonHocTinhHeSoKhoiNganh mock = new MonHocTinhHeSoKhoiNganh();
						
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.CoTinhHeSoKhoiNganh = TestUtility.Instance.RandomBoolean();
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomString(9, false);;
			
		
			// create a temporary collection and add the item to it
			TList<MonHocTinhHeSoKhoiNganh> tempMockCollection = new TList<MonHocTinhHeSoKhoiNganh>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (MonHocTinhHeSoKhoiNganh)mock;
		}
		
		
		///<summary>
		///  Update the Typed MonHocTinhHeSoKhoiNganh Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, MonHocTinhHeSoKhoiNganh mock)
		{
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.CoTinhHeSoKhoiNganh = TestUtility.Instance.RandomBoolean();
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomString(9, false);;
			
		}
		#endregion
    }
}
