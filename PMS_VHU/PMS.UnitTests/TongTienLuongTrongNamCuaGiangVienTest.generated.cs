﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file TongTienLuongTrongNamCuaGiangVienTest.cs instead.
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
    /// Provides tests for the and <see cref="TongTienLuongTrongNamCuaGiangVien"/> objects (entity, collection and repository).
    /// </summary>
   public partial class TongTienLuongTrongNamCuaGiangVienTest
    {
    	// the TongTienLuongTrongNamCuaGiangVien instance used to test the repository.
		protected TongTienLuongTrongNamCuaGiangVien mock;
		
		// the TList<TongTienLuongTrongNamCuaGiangVien> instance used to test the repository.
		protected TList<TongTienLuongTrongNamCuaGiangVien> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the TongTienLuongTrongNamCuaGiangVien Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock TongTienLuongTrongNamCuaGiangVien entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.TongTienLuongTrongNamCuaGiangVienProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.TongTienLuongTrongNamCuaGiangVienProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all TongTienLuongTrongNamCuaGiangVien objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.TongTienLuongTrongNamCuaGiangVienProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.TongTienLuongTrongNamCuaGiangVienProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.TongTienLuongTrongNamCuaGiangVienProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all TongTienLuongTrongNamCuaGiangVien children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.TongTienLuongTrongNamCuaGiangVienProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.TongTienLuongTrongNamCuaGiangVienProvider.DeepLoading += new EntityProviderBaseCore<TongTienLuongTrongNamCuaGiangVien, TongTienLuongTrongNamCuaGiangVienKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.TongTienLuongTrongNamCuaGiangVienProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("TongTienLuongTrongNamCuaGiangVien instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.TongTienLuongTrongNamCuaGiangVienProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock TongTienLuongTrongNamCuaGiangVien entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				TongTienLuongTrongNamCuaGiangVien mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.TongTienLuongTrongNamCuaGiangVienProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.TongTienLuongTrongNamCuaGiangVienProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.TongTienLuongTrongNamCuaGiangVienProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock TongTienLuongTrongNamCuaGiangVien entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (TongTienLuongTrongNamCuaGiangVien)CreateMockInstance(tm);
				DataRepository.TongTienLuongTrongNamCuaGiangVienProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.TongTienLuongTrongNamCuaGiangVienProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.TongTienLuongTrongNamCuaGiangVienProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock TongTienLuongTrongNamCuaGiangVien entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_TongTienLuongTrongNamCuaGiangVien.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock TongTienLuongTrongNamCuaGiangVien entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_TongTienLuongTrongNamCuaGiangVien.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<TongTienLuongTrongNamCuaGiangVien>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a TongTienLuongTrongNamCuaGiangVien collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_TongTienLuongTrongNamCuaGiangVienCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<TongTienLuongTrongNamCuaGiangVien> mockCollection = new TList<TongTienLuongTrongNamCuaGiangVien>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<TongTienLuongTrongNamCuaGiangVien> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a TongTienLuongTrongNamCuaGiangVien collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_TongTienLuongTrongNamCuaGiangVienCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<TongTienLuongTrongNamCuaGiangVien>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<TongTienLuongTrongNamCuaGiangVien> mockCollection = (TList<TongTienLuongTrongNamCuaGiangVien>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<TongTienLuongTrongNamCuaGiangVien> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				TongTienLuongTrongNamCuaGiangVien entity = CreateMockInstance(tm);
				bool result = DataRepository.TongTienLuongTrongNamCuaGiangVienProvider.Insert(tm, entity);
				
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
				TongTienLuongTrongNamCuaGiangVien entity = CreateMockInstance(tm);
				bool result = DataRepository.TongTienLuongTrongNamCuaGiangVienProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				TongTienLuongTrongNamCuaGiangVien t0 = DataRepository.TongTienLuongTrongNamCuaGiangVienProvider.GetById(tm, entity.Id);
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
				
				TongTienLuongTrongNamCuaGiangVien entity = mock.Copy() as TongTienLuongTrongNamCuaGiangVien;
				entity = (TongTienLuongTrongNamCuaGiangVien)mock.Clone();
				Assert.IsTrue(TongTienLuongTrongNamCuaGiangVien.ValueEquals(entity, mock), "Clone is not working");
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
				TongTienLuongTrongNamCuaGiangVien mock = CreateMockInstance(tm);
				bool result = DataRepository.TongTienLuongTrongNamCuaGiangVienProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				TongTienLuongTrongNamCuaGiangVienQuery query = new TongTienLuongTrongNamCuaGiangVienQuery();
			
				query.AppendEquals(TongTienLuongTrongNamCuaGiangVienColumn.Id, mock.Id.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(TongTienLuongTrongNamCuaGiangVienColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.MaGiangVien != null)
					query.AppendEquals(TongTienLuongTrongNamCuaGiangVienColumn.MaGiangVien, mock.MaGiangVien.ToString());
				if(mock.TongTienLuong != null)
					query.AppendEquals(TongTienLuongTrongNamCuaGiangVienColumn.TongTienLuong, mock.TongTienLuong.ToString());
				if(mock.NgayCapNhat != null)
					query.AppendEquals(TongTienLuongTrongNamCuaGiangVienColumn.NgayCapNhat, mock.NgayCapNhat.ToString());
				if(mock.NguoiCapNhat != null)
					query.AppendEquals(TongTienLuongTrongNamCuaGiangVienColumn.NguoiCapNhat, mock.NguoiCapNhat.ToString());
				
				TList<TongTienLuongTrongNamCuaGiangVien> results = DataRepository.TongTienLuongTrongNamCuaGiangVienProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed TongTienLuongTrongNamCuaGiangVien Entity with mock values.
		///</summary>
		static public TongTienLuongTrongNamCuaGiangVien CreateMockInstance_Generated(TransactionManager tm)
		{		
			TongTienLuongTrongNamCuaGiangVien mock = new TongTienLuongTrongNamCuaGiangVien();
						
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.TongTienLuong = (decimal)TestUtility.Instance.RandomShort();
			mock.NgayCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			
		
			// create a temporary collection and add the item to it
			TList<TongTienLuongTrongNamCuaGiangVien> tempMockCollection = new TList<TongTienLuongTrongNamCuaGiangVien>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (TongTienLuongTrongNamCuaGiangVien)mock;
		}
		
		
		///<summary>
		///  Update the Typed TongTienLuongTrongNamCuaGiangVien Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, TongTienLuongTrongNamCuaGiangVien mock)
		{
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.TongTienLuong = (decimal)TestUtility.Instance.RandomShort();
			mock.NgayCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			
		}
		#endregion
    }
}
