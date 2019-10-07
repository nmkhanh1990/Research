﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file DonGiaNhomNganhTest.cs instead.
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
    /// Provides tests for the and <see cref="DonGiaNhomNganh"/> objects (entity, collection and repository).
    /// </summary>
   public partial class DonGiaNhomNganhTest
    {
    	// the DonGiaNhomNganh instance used to test the repository.
		protected DonGiaNhomNganh mock;
		
		// the TList<DonGiaNhomNganh> instance used to test the repository.
		protected TList<DonGiaNhomNganh> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the DonGiaNhomNganh Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock DonGiaNhomNganh entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.DonGiaNhomNganhProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.DonGiaNhomNganhProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all DonGiaNhomNganh objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.DonGiaNhomNganhProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.DonGiaNhomNganhProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.DonGiaNhomNganhProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all DonGiaNhomNganh children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.DonGiaNhomNganhProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.DonGiaNhomNganhProvider.DeepLoading += new EntityProviderBaseCore<DonGiaNhomNganh, DonGiaNhomNganhKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.DonGiaNhomNganhProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("DonGiaNhomNganh instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.DonGiaNhomNganhProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock DonGiaNhomNganh entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				DonGiaNhomNganh mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.DonGiaNhomNganhProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.DonGiaNhomNganhProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.DonGiaNhomNganhProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock DonGiaNhomNganh entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (DonGiaNhomNganh)CreateMockInstance(tm);
				DataRepository.DonGiaNhomNganhProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.DonGiaNhomNganhProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.DonGiaNhomNganhProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock DonGiaNhomNganh entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_DonGiaNhomNganh.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock DonGiaNhomNganh entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_DonGiaNhomNganh.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<DonGiaNhomNganh>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a DonGiaNhomNganh collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_DonGiaNhomNganhCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<DonGiaNhomNganh> mockCollection = new TList<DonGiaNhomNganh>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<DonGiaNhomNganh> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a DonGiaNhomNganh collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_DonGiaNhomNganhCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<DonGiaNhomNganh>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<DonGiaNhomNganh> mockCollection = (TList<DonGiaNhomNganh>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<DonGiaNhomNganh> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				DonGiaNhomNganh entity = CreateMockInstance(tm);
				bool result = DataRepository.DonGiaNhomNganhProvider.Insert(tm, entity);
				
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
				DonGiaNhomNganh entity = CreateMockInstance(tm);
				bool result = DataRepository.DonGiaNhomNganhProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				DonGiaNhomNganh t0 = DataRepository.DonGiaNhomNganhProvider.GetByMaDonGiaNhomNganh(tm, entity.MaDonGiaNhomNganh);
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
				
				DonGiaNhomNganh entity = mock.Copy() as DonGiaNhomNganh;
				entity = (DonGiaNhomNganh)mock.Clone();
				Assert.IsTrue(DonGiaNhomNganh.ValueEquals(entity, mock), "Clone is not working");
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
				DonGiaNhomNganh mock = CreateMockInstance(tm);
				bool result = DataRepository.DonGiaNhomNganhProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				DonGiaNhomNganhQuery query = new DonGiaNhomNganhQuery();
			
				query.AppendEquals(DonGiaNhomNganhColumn.MaDonGiaNhomNganh, mock.MaDonGiaNhomNganh.ToString());
				if(mock.MaQuanLy != null)
					query.AppendEquals(DonGiaNhomNganhColumn.MaQuanLy, mock.MaQuanLy.ToString());
				if(mock.MaTenNhomNganh != null)
					query.AppendEquals(DonGiaNhomNganhColumn.MaTenNhomNganh, mock.MaTenNhomNganh.ToString());
				if(mock.GiaTri != null)
					query.AppendEquals(DonGiaNhomNganhColumn.GiaTri, mock.GiaTri.ToString());
				if(mock.GhiChu != null)
					query.AppendEquals(DonGiaNhomNganhColumn.GhiChu, mock.GhiChu.ToString());
				if(mock.TinhTrang != null)
					query.AppendEquals(DonGiaNhomNganhColumn.TinhTrang, mock.TinhTrang.ToString());
				
				TList<DonGiaNhomNganh> results = DataRepository.DonGiaNhomNganhProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed DonGiaNhomNganh Entity with mock values.
		///</summary>
		static public DonGiaNhomNganh CreateMockInstance_Generated(TransactionManager tm)
		{		
			DonGiaNhomNganh mock = new DonGiaNhomNganh();
						
			mock.MaQuanLy = TestUtility.Instance.RandomString(24, false);;
			mock.MaTenNhomNganh = TestUtility.Instance.RandomString(249, false);;
			mock.GiaTri = TestUtility.Instance.RandomNumber();
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			mock.TinhTrang = TestUtility.Instance.RandomBoolean();
			
		
			// create a temporary collection and add the item to it
			TList<DonGiaNhomNganh> tempMockCollection = new TList<DonGiaNhomNganh>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (DonGiaNhomNganh)mock;
		}
		
		
		///<summary>
		///  Update the Typed DonGiaNhomNganh Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, DonGiaNhomNganh mock)
		{
			mock.MaQuanLy = TestUtility.Instance.RandomString(24, false);;
			mock.MaTenNhomNganh = TestUtility.Instance.RandomString(249, false);;
			mock.GiaTri = TestUtility.Instance.RandomNumber();
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			mock.TinhTrang = TestUtility.Instance.RandomBoolean();
			
		}
		#endregion
    }
}