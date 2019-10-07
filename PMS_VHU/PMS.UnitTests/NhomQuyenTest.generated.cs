﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file NhomQuyenTest.cs instead.
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
    /// Provides tests for the and <see cref="NhomQuyen"/> objects (entity, collection and repository).
    /// </summary>
   public partial class NhomQuyenTest
    {
    	// the NhomQuyen instance used to test the repository.
		protected NhomQuyen mock;
		
		// the TList<NhomQuyen> instance used to test the repository.
		protected TList<NhomQuyen> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the NhomQuyen Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock NhomQuyen entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.NhomQuyenProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.NhomQuyenProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all NhomQuyen objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.NhomQuyenProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.NhomQuyenProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.NhomQuyenProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all NhomQuyen children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.NhomQuyenProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.NhomQuyenProvider.DeepLoading += new EntityProviderBaseCore<NhomQuyen, NhomQuyenKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.NhomQuyenProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("NhomQuyen instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.NhomQuyenProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock NhomQuyen entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				NhomQuyen mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.NhomQuyenProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.NhomQuyenProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.NhomQuyenProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock NhomQuyen entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (NhomQuyen)CreateMockInstance(tm);
				DataRepository.NhomQuyenProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.NhomQuyenProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.NhomQuyenProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock NhomQuyen entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_NhomQuyen.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock NhomQuyen entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_NhomQuyen.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<NhomQuyen>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a NhomQuyen collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_NhomQuyenCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<NhomQuyen> mockCollection = new TList<NhomQuyen>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<NhomQuyen> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a NhomQuyen collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_NhomQuyenCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<NhomQuyen>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<NhomQuyen> mockCollection = (TList<NhomQuyen>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<NhomQuyen> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				NhomQuyen entity = CreateMockInstance(tm);
				bool result = DataRepository.NhomQuyenProvider.Insert(tm, entity);
				
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
				NhomQuyen entity = CreateMockInstance(tm);
				bool result = DataRepository.NhomQuyenProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				NhomQuyen t0 = DataRepository.NhomQuyenProvider.GetByMaNhomQuyen(tm, entity.MaNhomQuyen);
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
				
				NhomQuyen entity = mock.Copy() as NhomQuyen;
				entity = (NhomQuyen)mock.Clone();
				Assert.IsTrue(NhomQuyen.ValueEquals(entity, mock), "Clone is not working");
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
				NhomQuyen mock = CreateMockInstance(tm);
				bool result = DataRepository.NhomQuyenProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				NhomQuyenQuery query = new NhomQuyenQuery();
			
				query.AppendEquals(NhomQuyenColumn.MaNhomQuyen, mock.MaNhomQuyen.ToString());
				if(mock.TenNhomQuyen != null)
					query.AppendEquals(NhomQuyenColumn.TenNhomQuyen, mock.TenNhomQuyen.ToString());
				if(mock.GhiChu != null)
					query.AppendEquals(NhomQuyenColumn.GhiChu, mock.GhiChu.ToString());
				if(mock.QlNhomQuyen != null)
					query.AppendEquals(NhomQuyenColumn.QlNhomQuyen, mock.QlNhomQuyen.ToString());
				if(mock.LoaiLop != null)
					query.AppendEquals(NhomQuyenColumn.LoaiLop, mock.LoaiLop.ToString());
				
				TList<NhomQuyen> results = DataRepository.NhomQuyenProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed NhomQuyen Entity with mock values.
		///</summary>
		static public NhomQuyen CreateMockInstance_Generated(TransactionManager tm)
		{		
			NhomQuyen mock = new NhomQuyen();
						
			mock.TenNhomQuyen = TestUtility.Instance.RandomString(49, false);;
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			mock.QlNhomQuyen = TestUtility.Instance.RandomString(499, false);;
			mock.LoaiLop = TestUtility.Instance.RandomString(99, false);;
			
		
			// create a temporary collection and add the item to it
			TList<NhomQuyen> tempMockCollection = new TList<NhomQuyen>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (NhomQuyen)mock;
		}
		
		
		///<summary>
		///  Update the Typed NhomQuyen Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, NhomQuyen mock)
		{
			mock.TenNhomQuyen = TestUtility.Instance.RandomString(49, false);;
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			mock.QlNhomQuyen = TestUtility.Instance.RandomString(499, false);;
			mock.LoaiLop = TestUtility.Instance.RandomString(99, false);;
			
		}
		#endregion
    }
}
