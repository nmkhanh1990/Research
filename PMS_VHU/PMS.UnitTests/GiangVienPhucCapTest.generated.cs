﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file GiangVienPhucCapTest.cs instead.
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
    /// Provides tests for the and <see cref="GiangVienPhucCap"/> objects (entity, collection and repository).
    /// </summary>
   public partial class GiangVienPhucCapTest
    {
    	// the GiangVienPhucCap instance used to test the repository.
		protected GiangVienPhucCap mock;
		
		// the TList<GiangVienPhucCap> instance used to test the repository.
		protected TList<GiangVienPhucCap> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the GiangVienPhucCap Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock GiangVienPhucCap entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.GiangVienPhucCapProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.GiangVienPhucCapProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all GiangVienPhucCap objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.GiangVienPhucCapProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.GiangVienPhucCapProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.GiangVienPhucCapProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all GiangVienPhucCap children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.GiangVienPhucCapProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.GiangVienPhucCapProvider.DeepLoading += new EntityProviderBaseCore<GiangVienPhucCap, GiangVienPhucCapKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.GiangVienPhucCapProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("GiangVienPhucCap instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.GiangVienPhucCapProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock GiangVienPhucCap entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				GiangVienPhucCap mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.GiangVienPhucCapProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.GiangVienPhucCapProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.GiangVienPhucCapProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock GiangVienPhucCap entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (GiangVienPhucCap)CreateMockInstance(tm);
				DataRepository.GiangVienPhucCapProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.GiangVienPhucCapProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.GiangVienPhucCapProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock GiangVienPhucCap entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_GiangVienPhucCap.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock GiangVienPhucCap entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_GiangVienPhucCap.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<GiangVienPhucCap>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a GiangVienPhucCap collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_GiangVienPhucCapCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<GiangVienPhucCap> mockCollection = new TList<GiangVienPhucCap>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<GiangVienPhucCap> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a GiangVienPhucCap collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_GiangVienPhucCapCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<GiangVienPhucCap>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<GiangVienPhucCap> mockCollection = (TList<GiangVienPhucCap>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<GiangVienPhucCap> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				GiangVienPhucCap entity = CreateMockInstance(tm);
				bool result = DataRepository.GiangVienPhucCapProvider.Insert(tm, entity);
				
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
				GiangVienPhucCap entity = CreateMockInstance(tm);
				bool result = DataRepository.GiangVienPhucCapProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				GiangVienPhucCap t0 = DataRepository.GiangVienPhucCapProvider.GetByMaQuanLy(tm, entity.MaQuanLy);
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
				
				GiangVienPhucCap entity = mock.Copy() as GiangVienPhucCap;
				entity = (GiangVienPhucCap)mock.Clone();
				Assert.IsTrue(GiangVienPhucCap.ValueEquals(entity, mock), "Clone is not working");
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
				GiangVienPhucCap mock = CreateMockInstance(tm);
				bool result = DataRepository.GiangVienPhucCapProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				GiangVienPhucCapQuery query = new GiangVienPhucCapQuery();
			
				query.AppendEquals(GiangVienPhucCapColumn.MaQuanLy, mock.MaQuanLy.ToString());
				if(mock.MaGiangVien != null)
					query.AppendEquals(GiangVienPhucCapColumn.MaGiangVien, mock.MaGiangVien.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(GiangVienPhucCapColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(GiangVienPhucCapColumn.HocKy, mock.HocKy.ToString());
				if(mock.SoDot != null)
					query.AppendEquals(GiangVienPhucCapColumn.SoDot, mock.SoDot.ToString());
				if(mock.SoNgay != null)
					query.AppendEquals(GiangVienPhucCapColumn.SoNgay, mock.SoNgay.ToString());
				if(mock.NgayCapNhat != null)
					query.AppendEquals(GiangVienPhucCapColumn.NgayCapNhat, mock.NgayCapNhat.ToString());
				if(mock.NguoiCapNhat != null)
					query.AppendEquals(GiangVienPhucCapColumn.NguoiCapNhat, mock.NguoiCapNhat.ToString());
				if(mock.TinhTrang != null)
					query.AppendEquals(GiangVienPhucCapColumn.TinhTrang, mock.TinhTrang.ToString());
				if(mock.GhiChu != null)
					query.AppendEquals(GiangVienPhucCapColumn.GhiChu, mock.GhiChu.ToString());
				if(mock.MaPhuCap != null)
					query.AppendEquals(GiangVienPhucCapColumn.MaPhuCap, mock.MaPhuCap.ToString());
				if(mock.MaLopHocPhan != null)
					query.AppendEquals(GiangVienPhucCapColumn.MaLopHocPhan, mock.MaLopHocPhan.ToString());
				if(mock.MaMonHoc != null)
					query.AppendEquals(GiangVienPhucCapColumn.MaMonHoc, mock.MaMonHoc.ToString());
				
				TList<GiangVienPhucCap> results = DataRepository.GiangVienPhucCapProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed GiangVienPhucCap Entity with mock values.
		///</summary>
		static public GiangVienPhucCap CreateMockInstance_Generated(TransactionManager tm)
		{		
			GiangVienPhucCap mock = new GiangVienPhucCap();
						
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.SoDot = TestUtility.Instance.RandomNumber();
			mock.SoNgay = TestUtility.Instance.RandomNumber();
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.TinhTrang = TestUtility.Instance.RandomBoolean();
			mock.GhiChu = TestUtility.Instance.RandomString(2, false);;
			mock.MaPhuCap = TestUtility.Instance.RandomString(49, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(24, false);;
			
		
			// create a temporary collection and add the item to it
			TList<GiangVienPhucCap> tempMockCollection = new TList<GiangVienPhucCap>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (GiangVienPhucCap)mock;
		}
		
		
		///<summary>
		///  Update the Typed GiangVienPhucCap Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, GiangVienPhucCap mock)
		{
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.SoDot = TestUtility.Instance.RandomNumber();
			mock.SoNgay = TestUtility.Instance.RandomNumber();
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.TinhTrang = TestUtility.Instance.RandomBoolean();
			mock.GhiChu = TestUtility.Instance.RandomString(2, false);;
			mock.MaPhuCap = TestUtility.Instance.RandomString(49, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(24, false);;
			
		}
		#endregion
    }
}
