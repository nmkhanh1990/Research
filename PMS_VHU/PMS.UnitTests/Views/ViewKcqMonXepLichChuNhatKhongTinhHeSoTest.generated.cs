﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewKcqMonXepLichChuNhatKhongTinhHeSoTest.cs instead.
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
    /// Provides tests for the and <see cref="ViewKcqMonXepLichChuNhatKhongTinhHeSo"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewKcqMonXepLichChuNhatKhongTinhHeSoTest
    {
    	// the ViewKcqMonXepLichChuNhatKhongTinhHeSo instance used to test the repository.
		private ViewKcqMonXepLichChuNhatKhongTinhHeSo mock;
		
		// the VList<ViewKcqMonXepLichChuNhatKhongTinhHeSo> instance used to test the repository.
		private VList<ViewKcqMonXepLichChuNhatKhongTinhHeSo> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewKcqMonXepLichChuNhatKhongTinhHeSo Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of ViewKcqMonXepLichChuNhatKhongTinhHeSo objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewKcqMonXepLichChuNhatKhongTinhHeSoProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewKcqMonXepLichChuNhatKhongTinhHeSoProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewKcqMonXepLichChuNhatKhongTinhHeSo objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewKcqMonXepLichChuNhatKhongTinhHeSoProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewKcqMonXepLichChuNhatKhongTinhHeSoProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewKcqMonXepLichChuNhatKhongTinhHeSo entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewKcqMonXepLichChuNhatKhongTinhHeSo.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewKcqMonXepLichChuNhatKhongTinhHeSo)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewKcqMonXepLichChuNhatKhongTinhHeSo entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewKcqMonXepLichChuNhatKhongTinhHeSo.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewKcqMonXepLichChuNhatKhongTinhHeSo)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewKcqMonXepLichChuNhatKhongTinhHeSo) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewKcqMonXepLichChuNhatKhongTinhHeSo collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewKcqMonXepLichChuNhatKhongTinhHeSoCollection.xml";
		
			VList<ViewKcqMonXepLichChuNhatKhongTinhHeSo> mockCollection = new VList<ViewKcqMonXepLichChuNhatKhongTinhHeSo>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewKcqMonXepLichChuNhatKhongTinhHeSo>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewKcqMonXepLichChuNhatKhongTinhHeSo> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewKcqMonXepLichChuNhatKhongTinhHeSo collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewKcqMonXepLichChuNhatKhongTinhHeSoCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewKcqMonXepLichChuNhatKhongTinhHeSo>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewKcqMonXepLichChuNhatKhongTinhHeSo> mockCollection = (VList<ViewKcqMonXepLichChuNhatKhongTinhHeSo>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewKcqMonXepLichChuNhatKhongTinhHeSo> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewKcqMonXepLichChuNhatKhongTinhHeSo Entity with mock values.
		///</summary>
		static public ViewKcqMonXepLichChuNhatKhongTinhHeSo CreateMockInstance()
		{		
			ViewKcqMonXepLichChuNhatKhongTinhHeSo mock = new ViewKcqMonXepLichChuNhatKhongTinhHeSo();
						
			mock.Id = TestUtility.Instance.RandomNumber();
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.Ho = TestUtility.Instance.RandomString(49, false);;
			mock.Ten = TestUtility.Instance.RandomString(24, false);;
			mock.HoTen = TestUtility.Instance.RandomString(75, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(24, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(126, false);;
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomNumber();
			mock.TenLoaiHocPhan = TestUtility.Instance.RandomString(49, false);;
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
		   return (ViewKcqMonXepLichChuNhatKhongTinhHeSo)mock;
		}
		

		#endregion
    }
}
