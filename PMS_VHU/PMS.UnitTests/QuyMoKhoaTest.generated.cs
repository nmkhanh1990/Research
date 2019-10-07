﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file QuyMoKhoaTest.cs instead.
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
    /// Provides tests for the and <see cref="QuyMoKhoa"/> objects (entity, collection and repository).
    /// </summary>
   public partial class QuyMoKhoaTest
    {
    	// the QuyMoKhoa instance used to test the repository.
		protected QuyMoKhoa mock;
		
		// the TList<QuyMoKhoa> instance used to test the repository.
		protected TList<QuyMoKhoa> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the QuyMoKhoa Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock QuyMoKhoa entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.QuyMoKhoaProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.QuyMoKhoaProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all QuyMoKhoa objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.QuyMoKhoaProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.QuyMoKhoaProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.QuyMoKhoaProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all QuyMoKhoa children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.QuyMoKhoaProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.QuyMoKhoaProvider.DeepLoading += new EntityProviderBaseCore<QuyMoKhoa, QuyMoKhoaKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.QuyMoKhoaProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("QuyMoKhoa instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.QuyMoKhoaProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock QuyMoKhoa entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				QuyMoKhoa mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.QuyMoKhoaProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.QuyMoKhoaProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.QuyMoKhoaProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock QuyMoKhoa entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (QuyMoKhoa)CreateMockInstance(tm);
				DataRepository.QuyMoKhoaProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.QuyMoKhoaProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.QuyMoKhoaProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock QuyMoKhoa entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_QuyMoKhoa.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock QuyMoKhoa entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_QuyMoKhoa.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<QuyMoKhoa>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a QuyMoKhoa collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_QuyMoKhoaCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<QuyMoKhoa> mockCollection = new TList<QuyMoKhoa>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<QuyMoKhoa> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a QuyMoKhoa collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_QuyMoKhoaCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<QuyMoKhoa>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<QuyMoKhoa> mockCollection = (TList<QuyMoKhoa>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<QuyMoKhoa> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				QuyMoKhoa entity = CreateMockInstance(tm);
				bool result = DataRepository.QuyMoKhoaProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test FK, Insert Failed");
				
				TList<QuyMoKhoa> t0 = DataRepository.QuyMoKhoaProvider.GetByIdQuyMo(tm, entity.IdQuyMo, 0, 10);
			}
		}
		
		
		/// <summary>
		/// Check the indexes dal methods.
		/// </summary>
		private void Step_11_IX_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				QuyMoKhoa entity = CreateMockInstance(tm);
				bool result = DataRepository.QuyMoKhoaProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				QuyMoKhoa t0 = DataRepository.QuyMoKhoaProvider.GetByMaKhoa(tm, entity.MaKhoa);
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
				
				QuyMoKhoa entity = mock.Copy() as QuyMoKhoa;
				entity = (QuyMoKhoa)mock.Clone();
				Assert.IsTrue(QuyMoKhoa.ValueEquals(entity, mock), "Clone is not working");
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
				QuyMoKhoa mock = CreateMockInstance(tm);
				bool result = DataRepository.QuyMoKhoaProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				QuyMoKhoaQuery query = new QuyMoKhoaQuery();
			
				query.AppendEquals(QuyMoKhoaColumn.MaKhoa, mock.MaKhoa.ToString());
				if(mock.IdQuyMo != null)
					query.AppendEquals(QuyMoKhoaColumn.IdQuyMo, mock.IdQuyMo.ToString());
				if(mock.GhiChu != null)
					query.AppendEquals(QuyMoKhoaColumn.GhiChu, mock.GhiChu.ToString());
				
				TList<QuyMoKhoa> results = DataRepository.QuyMoKhoaProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed QuyMoKhoa Entity with mock values.
		///</summary>
		static public QuyMoKhoa CreateMockInstance_Generated(TransactionManager tm)
		{		
			QuyMoKhoa mock = new QuyMoKhoa();
						
			mock.MaKhoa = TestUtility.Instance.RandomString(9, false);;
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			
			//OneToOneRelationship
			DanhMucQuyMo mockDanhMucQuyMoByIdQuyMo = DanhMucQuyMoTest.CreateMockInstance(tm);
			DataRepository.DanhMucQuyMoProvider.Insert(tm, mockDanhMucQuyMoByIdQuyMo);
			mock.IdQuyMo = mockDanhMucQuyMoByIdQuyMo.Id;
		
			// create a temporary collection and add the item to it
			TList<QuyMoKhoa> tempMockCollection = new TList<QuyMoKhoa>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (QuyMoKhoa)mock;
		}
		
		
		///<summary>
		///  Update the Typed QuyMoKhoa Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, QuyMoKhoa mock)
		{
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			
			//OneToOneRelationship
			DanhMucQuyMo mockDanhMucQuyMoByIdQuyMo = DanhMucQuyMoTest.CreateMockInstance(tm);
			DataRepository.DanhMucQuyMoProvider.Insert(tm, mockDanhMucQuyMoByIdQuyMo);
			mock.IdQuyMo = mockDanhMucQuyMoByIdQuyMo.Id;
					
		}
		#endregion
    }
}