﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file GiamTruDinhMucTest.cs instead.
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
    /// Provides tests for the and <see cref="GiamTruDinhMuc"/> objects (entity, collection and repository).
    /// </summary>
   public partial class GiamTruDinhMucTest
    {
    	// the GiamTruDinhMuc instance used to test the repository.
		protected GiamTruDinhMuc mock;
		
		// the TList<GiamTruDinhMuc> instance used to test the repository.
		protected TList<GiamTruDinhMuc> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the GiamTruDinhMuc Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock GiamTruDinhMuc entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.GiamTruDinhMucProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.GiamTruDinhMucProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all GiamTruDinhMuc objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.GiamTruDinhMucProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.GiamTruDinhMucProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.GiamTruDinhMucProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all GiamTruDinhMuc children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.GiamTruDinhMucProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.GiamTruDinhMucProvider.DeepLoading += new EntityProviderBaseCore<GiamTruDinhMuc, GiamTruDinhMucKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.GiamTruDinhMucProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("GiamTruDinhMuc instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.GiamTruDinhMucProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock GiamTruDinhMuc entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				GiamTruDinhMuc mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.GiamTruDinhMucProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.GiamTruDinhMucProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.GiamTruDinhMucProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock GiamTruDinhMuc entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (GiamTruDinhMuc)CreateMockInstance(tm);
				DataRepository.GiamTruDinhMucProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.GiamTruDinhMucProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.GiamTruDinhMucProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock GiamTruDinhMuc entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_GiamTruDinhMuc.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock GiamTruDinhMuc entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_GiamTruDinhMuc.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<GiamTruDinhMuc>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a GiamTruDinhMuc collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_GiamTruDinhMucCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<GiamTruDinhMuc> mockCollection = new TList<GiamTruDinhMuc>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<GiamTruDinhMuc> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a GiamTruDinhMuc collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_GiamTruDinhMucCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<GiamTruDinhMuc>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<GiamTruDinhMuc> mockCollection = (TList<GiamTruDinhMuc>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<GiamTruDinhMuc> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				GiamTruDinhMuc entity = CreateMockInstance(tm);
				bool result = DataRepository.GiamTruDinhMucProvider.Insert(tm, entity);
				
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
				GiamTruDinhMuc entity = CreateMockInstance(tm);
				bool result = DataRepository.GiamTruDinhMucProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				GiamTruDinhMuc t0 = DataRepository.GiamTruDinhMucProvider.GetByMaQuanLy(tm, entity.MaQuanLy);
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
				
				GiamTruDinhMuc entity = mock.Copy() as GiamTruDinhMuc;
				entity = (GiamTruDinhMuc)mock.Clone();
				Assert.IsTrue(GiamTruDinhMuc.ValueEquals(entity, mock), "Clone is not working");
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
				GiamTruDinhMuc mock = CreateMockInstance(tm);
				bool result = DataRepository.GiamTruDinhMucProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				GiamTruDinhMucQuery query = new GiamTruDinhMucQuery();
			
				query.AppendEquals(GiamTruDinhMucColumn.MaQuanLy, mock.MaQuanLy.ToString());
				if(mock.NoiDungGiamTru != null)
					query.AppendEquals(GiamTruDinhMucColumn.NoiDungGiamTru, mock.NoiDungGiamTru.ToString());
				if(mock.PhanTramGiamTru != null)
					query.AppendEquals(GiamTruDinhMucColumn.PhanTramGiamTru, mock.PhanTramGiamTru.ToString());
				if(mock.GhiChu != null)
					query.AppendEquals(GiamTruDinhMucColumn.GhiChu, mock.GhiChu.ToString());
				if(mock.MucGiam != null)
					query.AppendEquals(GiamTruDinhMucColumn.MucGiam, mock.MucGiam.ToString());
				if(mock.DonVi != null)
					query.AppendEquals(GiamTruDinhMucColumn.DonVi, mock.DonVi.ToString());
				if(mock.NgayCapNhat != null)
					query.AppendEquals(GiamTruDinhMucColumn.NgayCapNhat, mock.NgayCapNhat.ToString());
				if(mock.NguoiCapNhat != null)
					query.AppendEquals(GiamTruDinhMucColumn.NguoiCapNhat, mock.NguoiCapNhat.ToString());
				if(mock.MucGiamNckh != null)
					query.AppendEquals(GiamTruDinhMucColumn.MucGiamNckh, mock.MucGiamNckh.ToString());
				if(mock.PhanTramGiamTruNckh != null)
					query.AppendEquals(GiamTruDinhMucColumn.PhanTramGiamTruNckh, mock.PhanTramGiamTruNckh.ToString());
				
				TList<GiamTruDinhMuc> results = DataRepository.GiamTruDinhMucProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed GiamTruDinhMuc Entity with mock values.
		///</summary>
		static public GiamTruDinhMuc CreateMockInstance_Generated(TransactionManager tm)
		{		
			GiamTruDinhMuc mock = new GiamTruDinhMuc();
						
			mock.NoiDungGiamTru = TestUtility.Instance.RandomString(126, false);;
			mock.PhanTramGiamTru = (decimal)TestUtility.Instance.RandomShort();
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			mock.MucGiam = (decimal)TestUtility.Instance.RandomShort();
			mock.DonVi = TestUtility.Instance.RandomString(9, false);;
			mock.NgayCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.MucGiamNckh = (decimal)TestUtility.Instance.RandomShort();
			mock.PhanTramGiamTruNckh = (decimal)TestUtility.Instance.RandomShort();
			
		
			// create a temporary collection and add the item to it
			TList<GiamTruDinhMuc> tempMockCollection = new TList<GiamTruDinhMuc>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (GiamTruDinhMuc)mock;
		}
		
		
		///<summary>
		///  Update the Typed GiamTruDinhMuc Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, GiamTruDinhMuc mock)
		{
			mock.NoiDungGiamTru = TestUtility.Instance.RandomString(126, false);;
			mock.PhanTramGiamTru = (decimal)TestUtility.Instance.RandomShort();
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			mock.MucGiam = (decimal)TestUtility.Instance.RandomShort();
			mock.DonVi = TestUtility.Instance.RandomString(9, false);;
			mock.NgayCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.MucGiamNckh = (decimal)TestUtility.Instance.RandomShort();
			mock.PhanTramGiamTruNckh = (decimal)TestUtility.Instance.RandomShort();
			
		}
		#endregion
    }
}
