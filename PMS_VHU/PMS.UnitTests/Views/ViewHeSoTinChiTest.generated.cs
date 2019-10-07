﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewHeSoTinChiTest.cs instead.
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
    /// Provides tests for the and <see cref="ViewHeSoTinChi"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewHeSoTinChiTest
    {
    	// the ViewHeSoTinChi instance used to test the repository.
		private ViewHeSoTinChi mock;
		
		// the VList<ViewHeSoTinChi> instance used to test the repository.
		private VList<ViewHeSoTinChi> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewHeSoTinChi Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of ViewHeSoTinChi objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewHeSoTinChiProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewHeSoTinChiProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewHeSoTinChi objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewHeSoTinChiProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewHeSoTinChiProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewHeSoTinChi entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewHeSoTinChi.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewHeSoTinChi)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewHeSoTinChi entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewHeSoTinChi.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewHeSoTinChi)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewHeSoTinChi) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewHeSoTinChi collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewHeSoTinChiCollection.xml";
		
			VList<ViewHeSoTinChi> mockCollection = new VList<ViewHeSoTinChi>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewHeSoTinChi>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewHeSoTinChi> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewHeSoTinChi collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewHeSoTinChiCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewHeSoTinChi>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewHeSoTinChi> mockCollection = (VList<ViewHeSoTinChi>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewHeSoTinChi> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewHeSoTinChi Entity with mock values.
		///</summary>
		static public ViewHeSoTinChi CreateMockInstance()
		{		
			ViewHeSoTinChi mock = new ViewHeSoTinChi();
						
			mock.MaHeDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.TenHeDaoTao = TestUtility.Instance.RandomString(49, false);;
			mock.MaBacDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.TenBacDaoTao = TestUtility.Instance.RandomString(49, false);;
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.TenLoaiGiangVien = TestUtility.Instance.RandomString(49, false);;
			mock.HeSoTinChi = (decimal)TestUtility.Instance.RandomShort();
		   return (ViewHeSoTinChi)mock;
		}
		

		#endregion
    }
}