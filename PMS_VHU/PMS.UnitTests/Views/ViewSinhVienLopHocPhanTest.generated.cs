﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewSinhVienLopHocPhanTest.cs instead.
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
    /// Provides tests for the and <see cref="ViewSinhVienLopHocPhan"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewSinhVienLopHocPhanTest
    {
    	// the ViewSinhVienLopHocPhan instance used to test the repository.
		private ViewSinhVienLopHocPhan mock;
		
		// the VList<ViewSinhVienLopHocPhan> instance used to test the repository.
		private VList<ViewSinhVienLopHocPhan> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewSinhVienLopHocPhan Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of ViewSinhVienLopHocPhan objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewSinhVienLopHocPhanProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewSinhVienLopHocPhanProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewSinhVienLopHocPhan objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewSinhVienLopHocPhanProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewSinhVienLopHocPhanProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewSinhVienLopHocPhan entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewSinhVienLopHocPhan.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewSinhVienLopHocPhan)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewSinhVienLopHocPhan entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewSinhVienLopHocPhan.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewSinhVienLopHocPhan)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewSinhVienLopHocPhan) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewSinhVienLopHocPhan collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewSinhVienLopHocPhanCollection.xml";
		
			VList<ViewSinhVienLopHocPhan> mockCollection = new VList<ViewSinhVienLopHocPhan>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewSinhVienLopHocPhan>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewSinhVienLopHocPhan> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewSinhVienLopHocPhan collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewSinhVienLopHocPhanCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewSinhVienLopHocPhan>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewSinhVienLopHocPhan> mockCollection = (VList<ViewSinhVienLopHocPhan>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewSinhVienLopHocPhan> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewSinhVienLopHocPhan Entity with mock values.
		///</summary>
		static public ViewSinhVienLopHocPhan CreateMockInstance()
		{		
			ViewSinhVienLopHocPhan mock = new ViewSinhVienLopHocPhan();
						
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(14, false);;
			mock.MaSinhVien = TestUtility.Instance.RandomString(9, false);;
			mock.HoTen = TestUtility.Instance.RandomString(150, false);;
			mock.GioiTinh = TestUtility.Instance.RandomString(3, false);;
			mock.NgaySinh = TestUtility.Instance.RandomString(9, false);;
			mock.MaLop = TestUtility.Instance.RandomString(9, false);;
			mock.MaKhoa = TestUtility.Instance.RandomString(9, false);;
		   return (ViewSinhVienLopHocPhan)mock;
		}
		

		#endregion
    }
}
