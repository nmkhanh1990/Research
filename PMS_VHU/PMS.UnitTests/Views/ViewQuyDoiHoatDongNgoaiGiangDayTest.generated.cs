﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewQuyDoiHoatDongNgoaiGiangDayTest.cs instead.
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
    /// Provides tests for the and <see cref="ViewQuyDoiHoatDongNgoaiGiangDay"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewQuyDoiHoatDongNgoaiGiangDayTest
    {
    	// the ViewQuyDoiHoatDongNgoaiGiangDay instance used to test the repository.
		private ViewQuyDoiHoatDongNgoaiGiangDay mock;
		
		// the VList<ViewQuyDoiHoatDongNgoaiGiangDay> instance used to test the repository.
		private VList<ViewQuyDoiHoatDongNgoaiGiangDay> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewQuyDoiHoatDongNgoaiGiangDay Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of ViewQuyDoiHoatDongNgoaiGiangDay objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewQuyDoiHoatDongNgoaiGiangDayProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewQuyDoiHoatDongNgoaiGiangDayProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewQuyDoiHoatDongNgoaiGiangDay objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewQuyDoiHoatDongNgoaiGiangDayProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewQuyDoiHoatDongNgoaiGiangDayProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewQuyDoiHoatDongNgoaiGiangDay entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewQuyDoiHoatDongNgoaiGiangDay.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewQuyDoiHoatDongNgoaiGiangDay)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewQuyDoiHoatDongNgoaiGiangDay entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewQuyDoiHoatDongNgoaiGiangDay.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewQuyDoiHoatDongNgoaiGiangDay)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewQuyDoiHoatDongNgoaiGiangDay) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewQuyDoiHoatDongNgoaiGiangDay collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewQuyDoiHoatDongNgoaiGiangDayCollection.xml";
		
			VList<ViewQuyDoiHoatDongNgoaiGiangDay> mockCollection = new VList<ViewQuyDoiHoatDongNgoaiGiangDay>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewQuyDoiHoatDongNgoaiGiangDay>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewQuyDoiHoatDongNgoaiGiangDay> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewQuyDoiHoatDongNgoaiGiangDay collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewQuyDoiHoatDongNgoaiGiangDayCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewQuyDoiHoatDongNgoaiGiangDay>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewQuyDoiHoatDongNgoaiGiangDay> mockCollection = (VList<ViewQuyDoiHoatDongNgoaiGiangDay>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewQuyDoiHoatDongNgoaiGiangDay> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewQuyDoiHoatDongNgoaiGiangDay Entity with mock values.
		///</summary>
		static public ViewQuyDoiHoatDongNgoaiGiangDay CreateMockInstance()
		{		
			ViewQuyDoiHoatDongNgoaiGiangDay mock = new ViewQuyDoiHoatDongNgoaiGiangDay();
						
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.Ho = TestUtility.Instance.RandomString(49, false);;
			mock.Ten = TestUtility.Instance.RandomString(24, false);;
			mock.TenHoatDong = TestUtility.Instance.RandomString(126, false);;
			mock.SoLuong = (decimal)TestUtility.Instance.RandomShort();
			mock.MucQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.DonGia = (decimal)TestUtility.Instance.RandomShort();
			mock.SoTietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.SoTien = (decimal)TestUtility.Instance.RandomShort();
			mock.MaLop = TestUtility.Instance.RandomString(249, false);;
		   return (ViewQuyDoiHoatDongNgoaiGiangDay)mock;
		}
		

		#endregion
    }
}