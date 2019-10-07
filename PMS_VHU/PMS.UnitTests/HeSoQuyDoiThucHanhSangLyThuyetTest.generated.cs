﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file HeSoQuyDoiThucHanhSangLyThuyetTest.cs instead.
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
    /// Provides tests for the and <see cref="HeSoQuyDoiThucHanhSangLyThuyet"/> objects (entity, collection and repository).
    /// </summary>
   public partial class HeSoQuyDoiThucHanhSangLyThuyetTest
    {
    	// the HeSoQuyDoiThucHanhSangLyThuyet instance used to test the repository.
		protected HeSoQuyDoiThucHanhSangLyThuyet mock;
		
		// the TList<HeSoQuyDoiThucHanhSangLyThuyet> instance used to test the repository.
		protected TList<HeSoQuyDoiThucHanhSangLyThuyet> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the HeSoQuyDoiThucHanhSangLyThuyet Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock HeSoQuyDoiThucHanhSangLyThuyet entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.HeSoQuyDoiThucHanhSangLyThuyetProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.HeSoQuyDoiThucHanhSangLyThuyetProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all HeSoQuyDoiThucHanhSangLyThuyet objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.HeSoQuyDoiThucHanhSangLyThuyetProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.HeSoQuyDoiThucHanhSangLyThuyetProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.HeSoQuyDoiThucHanhSangLyThuyetProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all HeSoQuyDoiThucHanhSangLyThuyet children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.HeSoQuyDoiThucHanhSangLyThuyetProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.HeSoQuyDoiThucHanhSangLyThuyetProvider.DeepLoading += new EntityProviderBaseCore<HeSoQuyDoiThucHanhSangLyThuyet, HeSoQuyDoiThucHanhSangLyThuyetKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.HeSoQuyDoiThucHanhSangLyThuyetProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("HeSoQuyDoiThucHanhSangLyThuyet instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.HeSoQuyDoiThucHanhSangLyThuyetProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock HeSoQuyDoiThucHanhSangLyThuyet entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				HeSoQuyDoiThucHanhSangLyThuyet mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.HeSoQuyDoiThucHanhSangLyThuyetProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.HeSoQuyDoiThucHanhSangLyThuyetProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.HeSoQuyDoiThucHanhSangLyThuyetProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock HeSoQuyDoiThucHanhSangLyThuyet entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (HeSoQuyDoiThucHanhSangLyThuyet)CreateMockInstance(tm);
				DataRepository.HeSoQuyDoiThucHanhSangLyThuyetProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.HeSoQuyDoiThucHanhSangLyThuyetProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.HeSoQuyDoiThucHanhSangLyThuyetProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock HeSoQuyDoiThucHanhSangLyThuyet entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_HeSoQuyDoiThucHanhSangLyThuyet.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock HeSoQuyDoiThucHanhSangLyThuyet entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_HeSoQuyDoiThucHanhSangLyThuyet.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<HeSoQuyDoiThucHanhSangLyThuyet>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a HeSoQuyDoiThucHanhSangLyThuyet collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_HeSoQuyDoiThucHanhSangLyThuyetCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<HeSoQuyDoiThucHanhSangLyThuyet> mockCollection = new TList<HeSoQuyDoiThucHanhSangLyThuyet>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<HeSoQuyDoiThucHanhSangLyThuyet> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a HeSoQuyDoiThucHanhSangLyThuyet collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_HeSoQuyDoiThucHanhSangLyThuyetCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<HeSoQuyDoiThucHanhSangLyThuyet>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<HeSoQuyDoiThucHanhSangLyThuyet> mockCollection = (TList<HeSoQuyDoiThucHanhSangLyThuyet>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<HeSoQuyDoiThucHanhSangLyThuyet> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				HeSoQuyDoiThucHanhSangLyThuyet entity = CreateMockInstance(tm);
				bool result = DataRepository.HeSoQuyDoiThucHanhSangLyThuyetProvider.Insert(tm, entity);
				
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
				HeSoQuyDoiThucHanhSangLyThuyet entity = CreateMockInstance(tm);
				bool result = DataRepository.HeSoQuyDoiThucHanhSangLyThuyetProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				HeSoQuyDoiThucHanhSangLyThuyet t0 = DataRepository.HeSoQuyDoiThucHanhSangLyThuyetProvider.GetByNamHocHocKy(tm, entity.NamHoc, entity.HocKy);
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
				
				HeSoQuyDoiThucHanhSangLyThuyet entity = mock.Copy() as HeSoQuyDoiThucHanhSangLyThuyet;
				entity = (HeSoQuyDoiThucHanhSangLyThuyet)mock.Clone();
				Assert.IsTrue(HeSoQuyDoiThucHanhSangLyThuyet.ValueEquals(entity, mock), "Clone is not working");
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
				HeSoQuyDoiThucHanhSangLyThuyet mock = CreateMockInstance(tm);
				bool result = DataRepository.HeSoQuyDoiThucHanhSangLyThuyetProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				HeSoQuyDoiThucHanhSangLyThuyetQuery query = new HeSoQuyDoiThucHanhSangLyThuyetQuery();
			
				query.AppendEquals(HeSoQuyDoiThucHanhSangLyThuyetColumn.HeSo, mock.HeSo.ToString());
				query.AppendEquals(HeSoQuyDoiThucHanhSangLyThuyetColumn.NamHoc, mock.NamHoc.ToString());
				query.AppendEquals(HeSoQuyDoiThucHanhSangLyThuyetColumn.HocKy, mock.HocKy.ToString());
				if(mock.GhiChu != null)
					query.AppendEquals(HeSoQuyDoiThucHanhSangLyThuyetColumn.GhiChu, mock.GhiChu.ToString());
				
				TList<HeSoQuyDoiThucHanhSangLyThuyet> results = DataRepository.HeSoQuyDoiThucHanhSangLyThuyetProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed HeSoQuyDoiThucHanhSangLyThuyet Entity with mock values.
		///</summary>
		static public HeSoQuyDoiThucHanhSangLyThuyet CreateMockInstance_Generated(TransactionManager tm)
		{		
			HeSoQuyDoiThucHanhSangLyThuyet mock = new HeSoQuyDoiThucHanhSangLyThuyet();
						
			mock.HeSo = (decimal)TestUtility.Instance.RandomShort();
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.GhiChu = TestUtility.Instance.RandomString(2, false);;
			
		
			// create a temporary collection and add the item to it
			TList<HeSoQuyDoiThucHanhSangLyThuyet> tempMockCollection = new TList<HeSoQuyDoiThucHanhSangLyThuyet>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (HeSoQuyDoiThucHanhSangLyThuyet)mock;
		}
		
		
		///<summary>
		///  Update the Typed HeSoQuyDoiThucHanhSangLyThuyet Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, HeSoQuyDoiThucHanhSangLyThuyet mock)
		{
			mock.HeSo = (decimal)TestUtility.Instance.RandomShort();
			mock.GhiChu = TestUtility.Instance.RandomString(2, false);;
			
		}
		#endregion
    }
}
