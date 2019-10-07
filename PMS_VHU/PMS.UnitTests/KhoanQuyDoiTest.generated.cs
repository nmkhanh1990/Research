﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file KhoanQuyDoiTest.cs instead.
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
    /// Provides tests for the and <see cref="KhoanQuyDoi"/> objects (entity, collection and repository).
    /// </summary>
   public partial class KhoanQuyDoiTest
    {
    	// the KhoanQuyDoi instance used to test the repository.
		protected KhoanQuyDoi mock;
		
		// the TList<KhoanQuyDoi> instance used to test the repository.
		protected TList<KhoanQuyDoi> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the KhoanQuyDoi Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock KhoanQuyDoi entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KhoanQuyDoiProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.KhoanQuyDoiProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all KhoanQuyDoi objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.KhoanQuyDoiProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.KhoanQuyDoiProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.KhoanQuyDoiProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all KhoanQuyDoi children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.KhoanQuyDoiProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.KhoanQuyDoiProvider.DeepLoading += new EntityProviderBaseCore<KhoanQuyDoi, KhoanQuyDoiKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.KhoanQuyDoiProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("KhoanQuyDoi instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.KhoanQuyDoiProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock KhoanQuyDoi entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KhoanQuyDoi mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KhoanQuyDoiProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.KhoanQuyDoiProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.KhoanQuyDoiProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock KhoanQuyDoi entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (KhoanQuyDoi)CreateMockInstance(tm);
				DataRepository.KhoanQuyDoiProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.KhoanQuyDoiProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.KhoanQuyDoiProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock KhoanQuyDoi entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoanQuyDoi.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock KhoanQuyDoi entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoanQuyDoi.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<KhoanQuyDoi>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a KhoanQuyDoi collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoanQuyDoiCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<KhoanQuyDoi> mockCollection = new TList<KhoanQuyDoi>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<KhoanQuyDoi> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a KhoanQuyDoi collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoanQuyDoiCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<KhoanQuyDoi>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<KhoanQuyDoi> mockCollection = (TList<KhoanQuyDoi>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<KhoanQuyDoi> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KhoanQuyDoi entity = CreateMockInstance(tm);
				bool result = DataRepository.KhoanQuyDoiProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test FK, Insert Failed");
				
				TList<KhoanQuyDoi> t0 = DataRepository.KhoanQuyDoiProvider.GetByMaQuyDoi(tm, entity.MaQuyDoi, 0, 10);
			}
		}
		
		
		/// <summary>
		/// Check the indexes dal methods.
		/// </summary>
		private void Step_11_IX_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KhoanQuyDoi entity = CreateMockInstance(tm);
				bool result = DataRepository.KhoanQuyDoiProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				KhoanQuyDoi t0 = DataRepository.KhoanQuyDoiProvider.GetByMaKhoan(tm, entity.MaKhoan);
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
				
				KhoanQuyDoi entity = mock.Copy() as KhoanQuyDoi;
				entity = (KhoanQuyDoi)mock.Clone();
				Assert.IsTrue(KhoanQuyDoi.ValueEquals(entity, mock), "Clone is not working");
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
				KhoanQuyDoi mock = CreateMockInstance(tm);
				bool result = DataRepository.KhoanQuyDoiProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				KhoanQuyDoiQuery query = new KhoanQuyDoiQuery();
			
				query.AppendEquals(KhoanQuyDoiColumn.MaKhoan, mock.MaKhoan.ToString());
				if(mock.MaQuyDoi != null)
					query.AppendEquals(KhoanQuyDoiColumn.MaQuyDoi, mock.MaQuyDoi.ToString());
				if(mock.TuKhoan != null)
					query.AppendEquals(KhoanQuyDoiColumn.TuKhoan, mock.TuKhoan.ToString());
				if(mock.DenKhoan != null)
					query.AppendEquals(KhoanQuyDoiColumn.DenKhoan, mock.DenKhoan.ToString());
				if(mock.HeSo != null)
					query.AppendEquals(KhoanQuyDoiColumn.HeSo, mock.HeSo.ToString());
				if(mock.ThuTu != null)
					query.AppendEquals(KhoanQuyDoiColumn.ThuTu, mock.ThuTu.ToString());
				
				TList<KhoanQuyDoi> results = DataRepository.KhoanQuyDoiProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed KhoanQuyDoi Entity with mock values.
		///</summary>
		static public KhoanQuyDoi CreateMockInstance_Generated(TransactionManager tm)
		{		
			KhoanQuyDoi mock = new KhoanQuyDoi();
						
			mock.TuKhoan = TestUtility.Instance.RandomNumber();
			mock.DenKhoan = TestUtility.Instance.RandomNumber();
			mock.HeSo = (decimal)TestUtility.Instance.RandomShort();
			mock.ThuTu = TestUtility.Instance.RandomNumber();
			
			//OneToOneRelationship
			QuyDoiGioChuan mockQuyDoiGioChuanByMaQuyDoi = QuyDoiGioChuanTest.CreateMockInstance(tm);
			DataRepository.QuyDoiGioChuanProvider.Insert(tm, mockQuyDoiGioChuanByMaQuyDoi);
			mock.MaQuyDoi = mockQuyDoiGioChuanByMaQuyDoi.MaQuyDoi;
		
			// create a temporary collection and add the item to it
			TList<KhoanQuyDoi> tempMockCollection = new TList<KhoanQuyDoi>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (KhoanQuyDoi)mock;
		}
		
		
		///<summary>
		///  Update the Typed KhoanQuyDoi Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, KhoanQuyDoi mock)
		{
			mock.TuKhoan = TestUtility.Instance.RandomNumber();
			mock.DenKhoan = TestUtility.Instance.RandomNumber();
			mock.HeSo = (decimal)TestUtility.Instance.RandomShort();
			mock.ThuTu = TestUtility.Instance.RandomNumber();
			
			//OneToOneRelationship
			QuyDoiGioChuan mockQuyDoiGioChuanByMaQuyDoi = QuyDoiGioChuanTest.CreateMockInstance(tm);
			DataRepository.QuyDoiGioChuanProvider.Insert(tm, mockQuyDoiGioChuanByMaQuyDoi);
			mock.MaQuyDoi = mockQuyDoiGioChuanByMaQuyDoi.MaQuyDoi;
					
		}
		#endregion
    }
}