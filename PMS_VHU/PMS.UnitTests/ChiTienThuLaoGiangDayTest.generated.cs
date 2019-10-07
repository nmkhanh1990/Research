﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ChiTienThuLaoGiangDayTest.cs instead.
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
    /// Provides tests for the and <see cref="ChiTienThuLaoGiangDay"/> objects (entity, collection and repository).
    /// </summary>
   public partial class ChiTienThuLaoGiangDayTest
    {
    	// the ChiTienThuLaoGiangDay instance used to test the repository.
		protected ChiTienThuLaoGiangDay mock;
		
		// the TList<ChiTienThuLaoGiangDay> instance used to test the repository.
		protected TList<ChiTienThuLaoGiangDay> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the ChiTienThuLaoGiangDay Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock ChiTienThuLaoGiangDay entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.ChiTienThuLaoGiangDayProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.ChiTienThuLaoGiangDayProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all ChiTienThuLaoGiangDay objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.ChiTienThuLaoGiangDayProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.ChiTienThuLaoGiangDayProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.ChiTienThuLaoGiangDayProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all ChiTienThuLaoGiangDay children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.ChiTienThuLaoGiangDayProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.ChiTienThuLaoGiangDayProvider.DeepLoading += new EntityProviderBaseCore<ChiTienThuLaoGiangDay, ChiTienThuLaoGiangDayKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.ChiTienThuLaoGiangDayProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("ChiTienThuLaoGiangDay instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.ChiTienThuLaoGiangDayProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock ChiTienThuLaoGiangDay entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				ChiTienThuLaoGiangDay mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.ChiTienThuLaoGiangDayProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.ChiTienThuLaoGiangDayProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.ChiTienThuLaoGiangDayProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock ChiTienThuLaoGiangDay entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (ChiTienThuLaoGiangDay)CreateMockInstance(tm);
				DataRepository.ChiTienThuLaoGiangDayProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.ChiTienThuLaoGiangDayProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.ChiTienThuLaoGiangDayProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ChiTienThuLaoGiangDay entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_ChiTienThuLaoGiangDay.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock ChiTienThuLaoGiangDay entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_ChiTienThuLaoGiangDay.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<ChiTienThuLaoGiangDay>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ChiTienThuLaoGiangDay collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_ChiTienThuLaoGiangDayCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<ChiTienThuLaoGiangDay> mockCollection = new TList<ChiTienThuLaoGiangDay>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<ChiTienThuLaoGiangDay> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a ChiTienThuLaoGiangDay collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_ChiTienThuLaoGiangDayCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<ChiTienThuLaoGiangDay>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<ChiTienThuLaoGiangDay> mockCollection = (TList<ChiTienThuLaoGiangDay>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<ChiTienThuLaoGiangDay> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				ChiTienThuLaoGiangDay entity = CreateMockInstance(tm);
				bool result = DataRepository.ChiTienThuLaoGiangDayProvider.Insert(tm, entity);
				
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
				ChiTienThuLaoGiangDay entity = CreateMockInstance(tm);
				bool result = DataRepository.ChiTienThuLaoGiangDayProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				TList<ChiTienThuLaoGiangDay> t0 = DataRepository.ChiTienThuLaoGiangDayProvider.GetByOid(tm, entity.Oid);
				ChiTienThuLaoGiangDay t1 = DataRepository.ChiTienThuLaoGiangDayProvider.GetById(tm, entity.Id);
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
				
				ChiTienThuLaoGiangDay entity = mock.Copy() as ChiTienThuLaoGiangDay;
				entity = (ChiTienThuLaoGiangDay)mock.Clone();
				Assert.IsTrue(ChiTienThuLaoGiangDay.ValueEquals(entity, mock), "Clone is not working");
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
				ChiTienThuLaoGiangDay mock = CreateMockInstance(tm);
				bool result = DataRepository.ChiTienThuLaoGiangDayProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				ChiTienThuLaoGiangDayQuery query = new ChiTienThuLaoGiangDayQuery();
			
				query.AppendEquals(ChiTienThuLaoGiangDayColumn.Id, mock.Id.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(ChiTienThuLaoGiangDayColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(ChiTienThuLaoGiangDayColumn.HocKy, mock.HocKy.ToString());
				if(mock.MaCanBoGiangDay != null)
					query.AppendEquals(ChiTienThuLaoGiangDayColumn.MaCanBoGiangDay, mock.MaCanBoGiangDay.ToString());
				if(mock.Oid != null)
					query.AppendEquals(ChiTienThuLaoGiangDayColumn.Oid, mock.Oid.ToString());
				if(mock.LaGiangVienThinhGiang != null)
					query.AppendEquals(ChiTienThuLaoGiangDayColumn.LaGiangVienThinhGiang, mock.LaGiangVienThinhGiang.ToString());
				if(mock.TongTien != null)
					query.AppendEquals(ChiTienThuLaoGiangDayColumn.TongTien, mock.TongTien.ToString());
				if(mock.SoChungTuHrm != null)
					query.AppendEquals(ChiTienThuLaoGiangDayColumn.SoChungTuHrm, mock.SoChungTuHrm.ToString());
				if(mock.NgayCapNhat != null)
					query.AppendEquals(ChiTienThuLaoGiangDayColumn.NgayCapNhat, mock.NgayCapNhat.ToString());
				if(mock.NguoiCapNhat != null)
					query.AppendEquals(ChiTienThuLaoGiangDayColumn.NguoiCapNhat, mock.NguoiCapNhat.ToString());
				if(mock.NgayLayDuLieu != null)
					query.AppendEquals(ChiTienThuLaoGiangDayColumn.NgayLayDuLieu, mock.NgayLayDuLieu.ToString());
				if(mock.MaMonHoc != null)
					query.AppendEquals(ChiTienThuLaoGiangDayColumn.MaMonHoc, mock.MaMonHoc.ToString());
				if(mock.TongSoTietQuyDoi != null)
					query.AppendEquals(ChiTienThuLaoGiangDayColumn.TongSoTietQuyDoi, mock.TongSoTietQuyDoi.ToString());
				if(mock.MaLopHocPhan != null)
					query.AppendEquals(ChiTienThuLaoGiangDayColumn.MaLopHocPhan, mock.MaLopHocPhan.ToString());
				if(mock.MaLopSinhVien != null)
					query.AppendEquals(ChiTienThuLaoGiangDayColumn.MaLopSinhVien, mock.MaLopSinhVien.ToString());
				if(mock.LopClc != null)
					query.AppendEquals(ChiTienThuLaoGiangDayColumn.LopClc, mock.LopClc.ToString());
				
				TList<ChiTienThuLaoGiangDay> results = DataRepository.ChiTienThuLaoGiangDayProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed ChiTienThuLaoGiangDay Entity with mock values.
		///</summary>
		static public ChiTienThuLaoGiangDay CreateMockInstance_Generated(TransactionManager tm)
		{		
			ChiTienThuLaoGiangDay mock = new ChiTienThuLaoGiangDay();
						
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaCanBoGiangDay = TestUtility.Instance.RandomString(9, false);;
			mock.Oid = Guid.NewGuid();
			mock.LaGiangVienThinhGiang = TestUtility.Instance.RandomBoolean();
			mock.TongTien = (decimal)TestUtility.Instance.RandomShort();
			mock.SoChungTuHrm = TestUtility.Instance.RandomString(49, false);;
			mock.NgayCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.NgayLayDuLieu = TestUtility.Instance.RandomString(24, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TongSoTietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.MaLopSinhVien = TestUtility.Instance.RandomString(249, false);;
			mock.LopClc = TestUtility.Instance.RandomBoolean();
			
		
			// create a temporary collection and add the item to it
			TList<ChiTienThuLaoGiangDay> tempMockCollection = new TList<ChiTienThuLaoGiangDay>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (ChiTienThuLaoGiangDay)mock;
		}
		
		
		///<summary>
		///  Update the Typed ChiTienThuLaoGiangDay Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, ChiTienThuLaoGiangDay mock)
		{
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaCanBoGiangDay = TestUtility.Instance.RandomString(9, false);;
			mock.Oid = Guid.NewGuid();
			mock.LaGiangVienThinhGiang = TestUtility.Instance.RandomBoolean();
			mock.TongTien = (decimal)TestUtility.Instance.RandomShort();
			mock.SoChungTuHrm = TestUtility.Instance.RandomString(49, false);;
			mock.NgayCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.NgayLayDuLieu = TestUtility.Instance.RandomString(24, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TongSoTietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.MaLopSinhVien = TestUtility.Instance.RandomString(249, false);;
			mock.LopClc = TestUtility.Instance.RandomBoolean();
			
		}
		#endregion
    }
}