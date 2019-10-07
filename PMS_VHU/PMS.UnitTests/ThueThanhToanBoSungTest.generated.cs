﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ThueThanhToanBoSungTest.cs instead.
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
    /// Provides tests for the and <see cref="ThueThanhToanBoSung"/> objects (entity, collection and repository).
    /// </summary>
   public partial class ThueThanhToanBoSungTest
    {
    	// the ThueThanhToanBoSung instance used to test the repository.
		protected ThueThanhToanBoSung mock;
		
		// the TList<ThueThanhToanBoSung> instance used to test the repository.
		protected TList<ThueThanhToanBoSung> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the ThueThanhToanBoSung Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock ThueThanhToanBoSung entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.ThueThanhToanBoSungProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.ThueThanhToanBoSungProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all ThueThanhToanBoSung objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.ThueThanhToanBoSungProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.ThueThanhToanBoSungProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.ThueThanhToanBoSungProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all ThueThanhToanBoSung children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.ThueThanhToanBoSungProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.ThueThanhToanBoSungProvider.DeepLoading += new EntityProviderBaseCore<ThueThanhToanBoSung, ThueThanhToanBoSungKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.ThueThanhToanBoSungProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("ThueThanhToanBoSung instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.ThueThanhToanBoSungProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock ThueThanhToanBoSung entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				ThueThanhToanBoSung mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.ThueThanhToanBoSungProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.ThueThanhToanBoSungProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.ThueThanhToanBoSungProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock ThueThanhToanBoSung entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (ThueThanhToanBoSung)CreateMockInstance(tm);
				DataRepository.ThueThanhToanBoSungProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.ThueThanhToanBoSungProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.ThueThanhToanBoSungProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ThueThanhToanBoSung entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_ThueThanhToanBoSung.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock ThueThanhToanBoSung entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_ThueThanhToanBoSung.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<ThueThanhToanBoSung>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ThueThanhToanBoSung collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_ThueThanhToanBoSungCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<ThueThanhToanBoSung> mockCollection = new TList<ThueThanhToanBoSung>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<ThueThanhToanBoSung> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a ThueThanhToanBoSung collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_ThueThanhToanBoSungCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<ThueThanhToanBoSung>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<ThueThanhToanBoSung> mockCollection = (TList<ThueThanhToanBoSung>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<ThueThanhToanBoSung> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				ThueThanhToanBoSung entity = CreateMockInstance(tm);
				bool result = DataRepository.ThueThanhToanBoSungProvider.Insert(tm, entity);
				
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
				ThueThanhToanBoSung entity = CreateMockInstance(tm);
				bool result = DataRepository.ThueThanhToanBoSungProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				ThueThanhToanBoSung t0 = DataRepository.ThueThanhToanBoSungProvider.GetById(tm, entity.Id);
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
				
				ThueThanhToanBoSung entity = mock.Copy() as ThueThanhToanBoSung;
				entity = (ThueThanhToanBoSung)mock.Clone();
				Assert.IsTrue(ThueThanhToanBoSung.ValueEquals(entity, mock), "Clone is not working");
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
				ThueThanhToanBoSung mock = CreateMockInstance(tm);
				bool result = DataRepository.ThueThanhToanBoSungProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				ThueThanhToanBoSungQuery query = new ThueThanhToanBoSungQuery();
			
				query.AppendEquals(ThueThanhToanBoSungColumn.Id, mock.Id.ToString());
				if(mock.MaGiangVien != null)
					query.AppendEquals(ThueThanhToanBoSungColumn.MaGiangVien, mock.MaGiangVien.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(ThueThanhToanBoSungColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(ThueThanhToanBoSungColumn.HocKy, mock.HocKy.ToString());
				if(mock.Thue != null)
					query.AppendEquals(ThueThanhToanBoSungColumn.Thue, mock.Thue.ToString());
				if(mock.GhiChu != null)
					query.AppendEquals(ThueThanhToanBoSungColumn.GhiChu, mock.GhiChu.ToString());
				if(mock.SoTietNckhDaTru != null)
					query.AppendEquals(ThueThanhToanBoSungColumn.SoTietNckhDaTru, mock.SoTietNckhDaTru.ToString());
				
				TList<ThueThanhToanBoSung> results = DataRepository.ThueThanhToanBoSungProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed ThueThanhToanBoSung Entity with mock values.
		///</summary>
		static public ThueThanhToanBoSung CreateMockInstance_Generated(TransactionManager tm)
		{		
			ThueThanhToanBoSung mock = new ThueThanhToanBoSung();
						
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.Thue = (decimal)TestUtility.Instance.RandomShort();
			mock.GhiChu = TestUtility.Instance.RandomString(499, false);;
			mock.SoTietNckhDaTru = (decimal)TestUtility.Instance.RandomShort();
			
		
			// create a temporary collection and add the item to it
			TList<ThueThanhToanBoSung> tempMockCollection = new TList<ThueThanhToanBoSung>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (ThueThanhToanBoSung)mock;
		}
		
		
		///<summary>
		///  Update the Typed ThueThanhToanBoSung Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, ThueThanhToanBoSung mock)
		{
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.Thue = (decimal)TestUtility.Instance.RandomShort();
			mock.GhiChu = TestUtility.Instance.RandomString(499, false);;
			mock.SoTietNckhDaTru = (decimal)TestUtility.Instance.RandomShort();
			
		}
		#endregion
    }
}