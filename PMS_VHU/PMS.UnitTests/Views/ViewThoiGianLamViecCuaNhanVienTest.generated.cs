﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewThoiGianLamViecCuaNhanVienTest.cs instead.
*/
#region Using directives

using System;
using System.Xml;
using System.Xml.Serialization;
using NUnit.Framework;
using PMS.Entities;
using PMS.Data;

#endregion

namespace PMS.UnitTests
{
    /// <summary>
    /// Provides tests for the and <see cref="ViewThoiGianLamViecCuaNhanVien"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewThoiGianLamViecCuaNhanVienTest
    {
    	// the ViewThoiGianLamViecCuaNhanVien instance used to test the repository.
		private ViewThoiGianLamViecCuaNhanVien mock;
		
		// the VList<ViewThoiGianLamViecCuaNhanVien> instance used to test the repository.
		private VList<ViewThoiGianLamViecCuaNhanVien> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewThoiGianLamViecCuaNhanVien Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
			System.Console.WriteLine(new String('-', 75));
        }
    
    	/// <summary>
		/// This method is used to restore the environment after the tests are completed.
		/// </summary>
        static private void CleanUp_Generated()
        {       	
			System.Console.WriteLine();
			System.Console.WriteLine();
        }
		
		/// <summary>
		/// Selects a page of ViewThoiGianLamViecCuaNhanVien objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewThoiGianLamViecCuaNhanVienProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewThoiGianLamViecCuaNhanVienProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewThoiGianLamViecCuaNhanVien objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewThoiGianLamViecCuaNhanVienProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewThoiGianLamViecCuaNhanVienProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewThoiGianLamViecCuaNhanVien entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewThoiGianLamViecCuaNhanVien.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewThoiGianLamViecCuaNhanVien)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewThoiGianLamViecCuaNhanVien entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewThoiGianLamViecCuaNhanVien.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewThoiGianLamViecCuaNhanVien)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewThoiGianLamViecCuaNhanVien) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewThoiGianLamViecCuaNhanVien collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewThoiGianLamViecCuaNhanVienCollection.xml";
		
			VList<ViewThoiGianLamViecCuaNhanVien> mockCollection = new VList<ViewThoiGianLamViecCuaNhanVien>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewThoiGianLamViecCuaNhanVien>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewThoiGianLamViecCuaNhanVien> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewThoiGianLamViecCuaNhanVien collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewThoiGianLamViecCuaNhanVienCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewThoiGianLamViecCuaNhanVien>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewThoiGianLamViecCuaNhanVien> mockCollection = (VList<ViewThoiGianLamViecCuaNhanVien>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewThoiGianLamViecCuaNhanVien> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewThoiGianLamViecCuaNhanVien Entity with mock values.
		///</summary>
		static public ViewThoiGianLamViecCuaNhanVien CreateMockInstance()
		{		
			ViewThoiGianLamViecCuaNhanVien mock = new ViewThoiGianLamViecCuaNhanVien();
						
			mock.Id = TestUtility.Instance.RandomNumber();
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.Ho = TestUtility.Instance.RandomString(49, false);;
			mock.Ten = TestUtility.Instance.RandomString(24, false);;
			mock.HoTen = TestUtility.Instance.RandomString(75, false);;
			mock.NoiDung = TestUtility.Instance.RandomString(499, false);;
			mock.TuNgay = TestUtility.Instance.RandomDateTime();
			mock.DenNgay = TestUtility.Instance.RandomDateTime();
			mock.NgayCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.MaDonVi = TestUtility.Instance.RandomString(9, false);;
			mock.TenDonVi = TestUtility.Instance.RandomString(126, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaGiamTruDinhMuc = TestUtility.Instance.RandomNumber();
		   return (ViewThoiGianLamViecCuaNhanVien)mock;
		}
		

		#endregion
    }
}