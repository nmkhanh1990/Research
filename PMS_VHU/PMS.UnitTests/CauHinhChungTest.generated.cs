﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file CauHinhChungTest.cs instead.
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
    /// Provides tests for the and <see cref="CauHinhChung"/> objects (entity, collection and repository).
    /// </summary>
   public partial class CauHinhChungTest
    {
    	// the CauHinhChung instance used to test the repository.
		protected CauHinhChung mock;
		
		// the TList<CauHinhChung> instance used to test the repository.
		protected TList<CauHinhChung> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the CauHinhChung Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock CauHinhChung entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.CauHinhChungProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.CauHinhChungProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all CauHinhChung objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.CauHinhChungProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.CauHinhChungProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.CauHinhChungProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all CauHinhChung children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.CauHinhChungProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.CauHinhChungProvider.DeepLoading += new EntityProviderBaseCore<CauHinhChung, CauHinhChungKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.CauHinhChungProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("CauHinhChung instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.CauHinhChungProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock CauHinhChung entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				CauHinhChung mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.CauHinhChungProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.CauHinhChungProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.CauHinhChungProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock CauHinhChung entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (CauHinhChung)CreateMockInstance(tm);
				DataRepository.CauHinhChungProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.CauHinhChungProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.CauHinhChungProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock CauHinhChung entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_CauHinhChung.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock CauHinhChung entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_CauHinhChung.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<CauHinhChung>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a CauHinhChung collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_CauHinhChungCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<CauHinhChung> mockCollection = new TList<CauHinhChung>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<CauHinhChung> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a CauHinhChung collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_CauHinhChungCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<CauHinhChung>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<CauHinhChung> mockCollection = (TList<CauHinhChung>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<CauHinhChung> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				CauHinhChung entity = CreateMockInstance(tm);
				bool result = DataRepository.CauHinhChungProvider.Insert(tm, entity);
				
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
				CauHinhChung entity = CreateMockInstance(tm);
				bool result = DataRepository.CauHinhChungProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				CauHinhChung t0 = DataRepository.CauHinhChungProvider.GetByMaCauHinh(tm, entity.MaCauHinh);
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
				
				CauHinhChung entity = mock.Copy() as CauHinhChung;
				entity = (CauHinhChung)mock.Clone();
				Assert.IsTrue(CauHinhChung.ValueEquals(entity, mock), "Clone is not working");
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
				CauHinhChung mock = CreateMockInstance(tm);
				bool result = DataRepository.CauHinhChungProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				CauHinhChungQuery query = new CauHinhChungQuery();
			
				query.AppendEquals(CauHinhChungColumn.MaCauHinh, mock.MaCauHinh.ToString());
				if(mock.TenCauHinh != null)
					query.AppendEquals(CauHinhChungColumn.TenCauHinh, mock.TenCauHinh.ToString());
				if(mock.GiaTri != null)
					query.AppendEquals(CauHinhChungColumn.GiaTri, mock.GiaTri.ToString());
				if(mock.NgayCapNhat != null)
					query.AppendEquals(CauHinhChungColumn.NgayCapNhat, mock.NgayCapNhat.ToString());
				if(mock.GhiChu != null)
					query.AppendEquals(CauHinhChungColumn.GhiChu, mock.GhiChu.ToString());
				
				TList<CauHinhChung> results = DataRepository.CauHinhChungProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed CauHinhChung Entity with mock values.
		///</summary>
		static public CauHinhChung CreateMockInstance_Generated(TransactionManager tm)
		{		
			CauHinhChung mock = new CauHinhChung();
						
			mock.TenCauHinh = TestUtility.Instance.RandomString(49, false);;
			mock.GiaTri = TestUtility.Instance.RandomString(249, false);;
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			
		
			// create a temporary collection and add the item to it
			TList<CauHinhChung> tempMockCollection = new TList<CauHinhChung>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (CauHinhChung)mock;
		}
		
		
		///<summary>
		///  Update the Typed CauHinhChung Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, CauHinhChung mock)
		{
			mock.TenCauHinh = TestUtility.Instance.RandomString(49, false);;
			mock.GiaTri = TestUtility.Instance.RandomString(249, false);;
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			
		}
		#endregion
    }
}