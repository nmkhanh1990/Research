﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewKcqPhuCapHanhChinhTest.cs instead.
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
    /// Provides tests for the and <see cref="ViewKcqPhuCapHanhChinh"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewKcqPhuCapHanhChinhTest
    {
    	// the ViewKcqPhuCapHanhChinh instance used to test the repository.
		private ViewKcqPhuCapHanhChinh mock;
		
		// the VList<ViewKcqPhuCapHanhChinh> instance used to test the repository.
		private VList<ViewKcqPhuCapHanhChinh> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewKcqPhuCapHanhChinh Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of ViewKcqPhuCapHanhChinh objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewKcqPhuCapHanhChinhProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewKcqPhuCapHanhChinhProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewKcqPhuCapHanhChinh objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewKcqPhuCapHanhChinhProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewKcqPhuCapHanhChinhProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewKcqPhuCapHanhChinh entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewKcqPhuCapHanhChinh.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewKcqPhuCapHanhChinh)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewKcqPhuCapHanhChinh entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewKcqPhuCapHanhChinh.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewKcqPhuCapHanhChinh)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewKcqPhuCapHanhChinh) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewKcqPhuCapHanhChinh collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewKcqPhuCapHanhChinhCollection.xml";
		
			VList<ViewKcqPhuCapHanhChinh> mockCollection = new VList<ViewKcqPhuCapHanhChinh>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewKcqPhuCapHanhChinh>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewKcqPhuCapHanhChinh> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewKcqPhuCapHanhChinh collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewKcqPhuCapHanhChinhCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewKcqPhuCapHanhChinh>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewKcqPhuCapHanhChinh> mockCollection = (VList<ViewKcqPhuCapHanhChinh>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewKcqPhuCapHanhChinh> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewKcqPhuCapHanhChinh Entity with mock values.
		///</summary>
		static public ViewKcqPhuCapHanhChinh CreateMockInstance()
		{		
			ViewKcqPhuCapHanhChinh mock = new ViewKcqPhuCapHanhChinh();
						
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.Ho = TestUtility.Instance.RandomString(49, false);;
			mock.Ten = TestUtility.Instance.RandomString(24, false);;
			mock.HoTen = TestUtility.Instance.RandomString(75, false);;
			mock.SoThangTruPhuCapHanhChinh = (decimal)TestUtility.Instance.RandomShort();
			mock.DonGiaPhuCapHanhChinh = (decimal)TestUtility.Instance.RandomShort();
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
		   return (ViewKcqPhuCapHanhChinh)mock;
		}
		

		#endregion
    }
}