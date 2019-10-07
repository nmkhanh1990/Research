﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file VLopHocPhanKhongPhanCongTest.cs instead.
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
    /// Provides tests for the and <see cref="VLopHocPhanKhongPhanCong"/> objects (entity, collection and repository).
    /// </summary>
    public partial class VLopHocPhanKhongPhanCongTest
    {
    	// the VLopHocPhanKhongPhanCong instance used to test the repository.
		private VLopHocPhanKhongPhanCong mock;
		
		// the VList<VLopHocPhanKhongPhanCong> instance used to test the repository.
		private VList<VLopHocPhanKhongPhanCong> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the VLopHocPhanKhongPhanCong Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of VLopHocPhanKhongPhanCong objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.VLopHocPhanKhongPhanCongProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.VLopHocPhanKhongPhanCongProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some VLopHocPhanKhongPhanCong objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.VLopHocPhanKhongPhanCongProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.VLopHocPhanKhongPhanCongProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock VLopHocPhanKhongPhanCong entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_VLopHocPhanKhongPhanCong.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VLopHocPhanKhongPhanCong)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock VLopHocPhanKhongPhanCong entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_VLopHocPhanKhongPhanCong.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VLopHocPhanKhongPhanCong)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (VLopHocPhanKhongPhanCong) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a VLopHocPhanKhongPhanCong collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_VLopHocPhanKhongPhanCongCollection.xml";
		
			VList<VLopHocPhanKhongPhanCong> mockCollection = new VList<VLopHocPhanKhongPhanCong>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<VLopHocPhanKhongPhanCong>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<VLopHocPhanKhongPhanCong> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a VLopHocPhanKhongPhanCong collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_VLopHocPhanKhongPhanCongCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<VLopHocPhanKhongPhanCong>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<VLopHocPhanKhongPhanCong> mockCollection = (VList<VLopHocPhanKhongPhanCong>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<VLopHocPhanKhongPhanCong> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed VLopHocPhanKhongPhanCong Entity with mock values.
		///</summary>
		static public VLopHocPhanKhongPhanCong CreateMockInstance()
		{		
			VLopHocPhanKhongPhanCong mock = new VLopHocPhanKhongPhanCong();
						
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.HoTen = TestUtility.Instance.RandomString(49, false);;
			mock.ChucDanh = TestUtility.Instance.RandomString(9, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(126, false);;
			mock.MaNhom = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(14, false);;
			mock.SoTinChi = (decimal)TestUtility.Instance.RandomShort();
			mock.SiSoLop = TestUtility.Instance.RandomNumber();
			mock.TrongGio = TestUtility.Instance.RandomNumber();
			mock.NgoaiGio = TestUtility.Instance.RandomNumber();
			mock.GiangHe = TestUtility.Instance.RandomNumber();
			mock.HeSoCoSo = (decimal)TestUtility.Instance.RandomShort();
			mock.NgayBatDau = TestUtility.Instance.RandomDateTime();
			mock.NgayKetThuc = TestUtility.Instance.RandomDateTime();
			mock.ThoiGianGiang = TestUtility.Instance.RandomString(14, false);;
			mock.MaDiaDiem = TestUtility.Instance.RandomString(9, false);;
			mock.MaBacLoaiHinh = TestUtility.Instance.RandomString(20, false);;
		   return (VLopHocPhanKhongPhanCong)mock;
		}
		

		#endregion
    }
}