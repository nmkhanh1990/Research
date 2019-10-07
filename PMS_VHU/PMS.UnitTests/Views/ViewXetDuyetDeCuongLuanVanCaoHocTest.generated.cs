﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewXetDuyetDeCuongLuanVanCaoHocTest.cs instead.
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
    /// Provides tests for the and <see cref="ViewXetDuyetDeCuongLuanVanCaoHoc"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewXetDuyetDeCuongLuanVanCaoHocTest
    {
    	// the ViewXetDuyetDeCuongLuanVanCaoHoc instance used to test the repository.
		private ViewXetDuyetDeCuongLuanVanCaoHoc mock;
		
		// the VList<ViewXetDuyetDeCuongLuanVanCaoHoc> instance used to test the repository.
		private VList<ViewXetDuyetDeCuongLuanVanCaoHoc> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewXetDuyetDeCuongLuanVanCaoHoc Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of ViewXetDuyetDeCuongLuanVanCaoHoc objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewXetDuyetDeCuongLuanVanCaoHocProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewXetDuyetDeCuongLuanVanCaoHocProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewXetDuyetDeCuongLuanVanCaoHoc objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewXetDuyetDeCuongLuanVanCaoHocProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewXetDuyetDeCuongLuanVanCaoHocProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewXetDuyetDeCuongLuanVanCaoHoc entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewXetDuyetDeCuongLuanVanCaoHoc.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewXetDuyetDeCuongLuanVanCaoHoc)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewXetDuyetDeCuongLuanVanCaoHoc entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewXetDuyetDeCuongLuanVanCaoHoc.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewXetDuyetDeCuongLuanVanCaoHoc)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewXetDuyetDeCuongLuanVanCaoHoc) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewXetDuyetDeCuongLuanVanCaoHoc collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewXetDuyetDeCuongLuanVanCaoHocCollection.xml";
		
			VList<ViewXetDuyetDeCuongLuanVanCaoHoc> mockCollection = new VList<ViewXetDuyetDeCuongLuanVanCaoHoc>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewXetDuyetDeCuongLuanVanCaoHoc>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewXetDuyetDeCuongLuanVanCaoHoc> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewXetDuyetDeCuongLuanVanCaoHoc collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewXetDuyetDeCuongLuanVanCaoHocCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewXetDuyetDeCuongLuanVanCaoHoc>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewXetDuyetDeCuongLuanVanCaoHoc> mockCollection = (VList<ViewXetDuyetDeCuongLuanVanCaoHoc>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewXetDuyetDeCuongLuanVanCaoHoc> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewXetDuyetDeCuongLuanVanCaoHoc Entity with mock values.
		///</summary>
		static public ViewXetDuyetDeCuongLuanVanCaoHoc CreateMockInstance()
		{		
			ViewXetDuyetDeCuongLuanVanCaoHoc mock = new ViewXetDuyetDeCuongLuanVanCaoHoc();
						
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.Ho = TestUtility.Instance.RandomString(49, false);;
			mock.Ten = TestUtility.Instance.RandomString(24, false);;
			mock.HoTen = TestUtility.Instance.RandomString(75, false);;
			mock.TenDonVi = TestUtility.Instance.RandomString(126, false);;
			mock.MaKhoaHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenKhoaHoc = TestUtility.Instance.RandomString(49, false);;
			mock.SoLuong = TestUtility.Instance.RandomNumber();
			mock.DonGia = (decimal)TestUtility.Instance.RandomShort();
			mock.ThanhTien = (decimal)TestUtility.Instance.RandomShort();
			mock.Thue = (decimal)TestUtility.Instance.RandomShort();
			mock.ThucLinh = (decimal)TestUtility.Instance.RandomShort();
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			mock.NgayCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
		   return (ViewXetDuyetDeCuongLuanVanCaoHoc)mock;
		}
		

		#endregion
    }
}
