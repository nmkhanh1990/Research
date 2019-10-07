﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewThanhToanThuLaoTest.cs instead.
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
    /// Provides tests for the and <see cref="ViewThanhToanThuLao"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewThanhToanThuLaoTest
    {
    	// the ViewThanhToanThuLao instance used to test the repository.
		private ViewThanhToanThuLao mock;
		
		// the VList<ViewThanhToanThuLao> instance used to test the repository.
		private VList<ViewThanhToanThuLao> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewThanhToanThuLao Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of ViewThanhToanThuLao objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewThanhToanThuLaoProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewThanhToanThuLaoProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewThanhToanThuLao objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewThanhToanThuLaoProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewThanhToanThuLaoProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewThanhToanThuLao entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewThanhToanThuLao.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewThanhToanThuLao)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewThanhToanThuLao entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewThanhToanThuLao.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewThanhToanThuLao)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewThanhToanThuLao) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewThanhToanThuLao collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewThanhToanThuLaoCollection.xml";
		
			VList<ViewThanhToanThuLao> mockCollection = new VList<ViewThanhToanThuLao>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewThanhToanThuLao>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewThanhToanThuLao> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewThanhToanThuLao collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewThanhToanThuLaoCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewThanhToanThuLao>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewThanhToanThuLao> mockCollection = (VList<ViewThanhToanThuLao>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewThanhToanThuLao> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewThanhToanThuLao Entity with mock values.
		///</summary>
		static public ViewThanhToanThuLao CreateMockInstance()
		{		
			ViewThanhToanThuLao mock = new ViewThanhToanThuLao();
						
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.HoTen = TestUtility.Instance.RandomString(75, false);;
			mock.HoDem = TestUtility.Instance.RandomString(49, false);;
			mock.Ten = TestUtility.Instance.RandomString(24, false);;
			mock.ChucDanh = TestUtility.Instance.RandomString(9, false);;
			mock.MaDonVi = TestUtility.Instance.RandomString(9, false);;
			mock.TietNghiaVu = TestUtility.Instance.RandomNumber();
			mock.TietGioiHan = (decimal)TestUtility.Instance.RandomShort();
			mock.TietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.TietDoAn = (decimal)TestUtility.Instance.RandomShort();
			mock.NgoaiGio = (decimal)TestUtility.Instance.RandomShort();
			mock.DonGia = (decimal)TestUtility.Instance.RandomShort();
			mock.TienDay = (decimal)TestUtility.Instance.RandomShort();
			mock.TienDoAn = (decimal)TestUtility.Instance.RandomShort();
			mock.TietThieu = (decimal)TestUtility.Instance.RandomShort();
			mock.TietVuot = (decimal)TestUtility.Instance.RandomShort();
			mock.TienVuot = (decimal)TestUtility.Instance.RandomShort();
		   return (ViewThanhToanThuLao)mock;
		}
		

		#endregion
    }
}