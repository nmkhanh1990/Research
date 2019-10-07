﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file PhanNhomMonHocTinhDinhMucTest.cs instead.
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
    /// Provides tests for the and <see cref="PhanNhomMonHocTinhDinhMuc"/> objects (entity, collection and repository).
    /// </summary>
   public partial class PhanNhomMonHocTinhDinhMucTest
    {
    	// the PhanNhomMonHocTinhDinhMuc instance used to test the repository.
		protected PhanNhomMonHocTinhDinhMuc mock;
		
		// the TList<PhanNhomMonHocTinhDinhMuc> instance used to test the repository.
		protected TList<PhanNhomMonHocTinhDinhMuc> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the PhanNhomMonHocTinhDinhMuc Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock PhanNhomMonHocTinhDinhMuc entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.PhanNhomMonHocTinhDinhMucProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.PhanNhomMonHocTinhDinhMucProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all PhanNhomMonHocTinhDinhMuc objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.PhanNhomMonHocTinhDinhMucProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.PhanNhomMonHocTinhDinhMucProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.PhanNhomMonHocTinhDinhMucProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all PhanNhomMonHocTinhDinhMuc children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.PhanNhomMonHocTinhDinhMucProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.PhanNhomMonHocTinhDinhMucProvider.DeepLoading += new EntityProviderBaseCore<PhanNhomMonHocTinhDinhMuc, PhanNhomMonHocTinhDinhMucKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.PhanNhomMonHocTinhDinhMucProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("PhanNhomMonHocTinhDinhMuc instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.PhanNhomMonHocTinhDinhMucProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock PhanNhomMonHocTinhDinhMuc entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				PhanNhomMonHocTinhDinhMuc mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.PhanNhomMonHocTinhDinhMucProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.PhanNhomMonHocTinhDinhMucProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.PhanNhomMonHocTinhDinhMucProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock PhanNhomMonHocTinhDinhMuc entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (PhanNhomMonHocTinhDinhMuc)CreateMockInstance(tm);
				DataRepository.PhanNhomMonHocTinhDinhMucProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.PhanNhomMonHocTinhDinhMucProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.PhanNhomMonHocTinhDinhMucProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock PhanNhomMonHocTinhDinhMuc entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PhanNhomMonHocTinhDinhMuc.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock PhanNhomMonHocTinhDinhMuc entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PhanNhomMonHocTinhDinhMuc.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<PhanNhomMonHocTinhDinhMuc>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a PhanNhomMonHocTinhDinhMuc collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PhanNhomMonHocTinhDinhMucCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<PhanNhomMonHocTinhDinhMuc> mockCollection = new TList<PhanNhomMonHocTinhDinhMuc>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<PhanNhomMonHocTinhDinhMuc> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a PhanNhomMonHocTinhDinhMuc collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PhanNhomMonHocTinhDinhMucCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<PhanNhomMonHocTinhDinhMuc>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<PhanNhomMonHocTinhDinhMuc> mockCollection = (TList<PhanNhomMonHocTinhDinhMuc>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<PhanNhomMonHocTinhDinhMuc> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				PhanNhomMonHocTinhDinhMuc entity = CreateMockInstance(tm);
				bool result = DataRepository.PhanNhomMonHocTinhDinhMucProvider.Insert(tm, entity);
				
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
				PhanNhomMonHocTinhDinhMuc entity = CreateMockInstance(tm);
				bool result = DataRepository.PhanNhomMonHocTinhDinhMucProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				PhanNhomMonHocTinhDinhMuc t0 = DataRepository.PhanNhomMonHocTinhDinhMucProvider.GetById(tm, entity.Id);
				PhanNhomMonHocTinhDinhMuc t1 = DataRepository.PhanNhomMonHocTinhDinhMucProvider.GetByMaMonHocMaNhomMonNamHocHocKy(tm, entity.MaMonHoc, entity.MaNhomMon, entity.NamHoc, entity.HocKy);
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
				
				PhanNhomMonHocTinhDinhMuc entity = mock.Copy() as PhanNhomMonHocTinhDinhMuc;
				entity = (PhanNhomMonHocTinhDinhMuc)mock.Clone();
				Assert.IsTrue(PhanNhomMonHocTinhDinhMuc.ValueEquals(entity, mock), "Clone is not working");
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
				PhanNhomMonHocTinhDinhMuc mock = CreateMockInstance(tm);
				bool result = DataRepository.PhanNhomMonHocTinhDinhMucProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				PhanNhomMonHocTinhDinhMucQuery query = new PhanNhomMonHocTinhDinhMucQuery();
			
				query.AppendEquals(PhanNhomMonHocTinhDinhMucColumn.Id, mock.Id.ToString());
				if(mock.MaMonHoc != null)
					query.AppendEquals(PhanNhomMonHocTinhDinhMucColumn.MaMonHoc, mock.MaMonHoc.ToString());
				if(mock.MaNhomMon != null)
					query.AppendEquals(PhanNhomMonHocTinhDinhMucColumn.MaNhomMon, mock.MaNhomMon.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(PhanNhomMonHocTinhDinhMucColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(PhanNhomMonHocTinhDinhMucColumn.HocKy, mock.HocKy.ToString());
				
				TList<PhanNhomMonHocTinhDinhMuc> results = DataRepository.PhanNhomMonHocTinhDinhMucProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed PhanNhomMonHocTinhDinhMuc Entity with mock values.
		///</summary>
		static public PhanNhomMonHocTinhDinhMuc CreateMockInstance_Generated(TransactionManager tm)
		{		
			PhanNhomMonHocTinhDinhMuc mock = new PhanNhomMonHocTinhDinhMuc();
						
			mock.MaMonHoc = TestUtility.Instance.RandomString(24, false);;
			mock.MaNhomMon = TestUtility.Instance.RandomString(24, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			
		
			// create a temporary collection and add the item to it
			TList<PhanNhomMonHocTinhDinhMuc> tempMockCollection = new TList<PhanNhomMonHocTinhDinhMuc>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (PhanNhomMonHocTinhDinhMuc)mock;
		}
		
		
		///<summary>
		///  Update the Typed PhanNhomMonHocTinhDinhMuc Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, PhanNhomMonHocTinhDinhMuc mock)
		{
			mock.MaMonHoc = TestUtility.Instance.RandomString(24, false);;
			mock.MaNhomMon = TestUtility.Instance.RandomString(24, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			
		}
		#endregion
    }
}
