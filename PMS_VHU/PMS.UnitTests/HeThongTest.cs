﻿

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
    /// Provides tests for the and <see cref="HeThong"/> objects (entity, collection and repository).
    /// </summary>
	/// <remarks>
	/// This file is generated once and will never be overwritten.
	/// </remarks>
    [TestFixture]
    public partial class HeThongTest
    {    	
		/// <summary>
		/// Creates a new <see cref="HeThongTest"/> instance.
		/// </summary>	
		public HeThongTest()
		{				
		}
      
		
		/// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>        
		[TestFixtureSetUp]
		public void Init()
        {
			Init_Generated();
			// Add your initialization here
        }
    
    	/// <summary>
		/// This method is used to restore the environment after the tests are completed.
		/// </summary>
		[TestFixtureTearDown]
        public void Dispose()
        {   
        	CleanUp_Generated();
			// Add you clean up here
        }
    
    
		
		
		/// <summary>
		/// Selects a sample of  HeThong objects of the database.
		/// </summary>
		[NUnit.Framework.Test]
		public void Step_02_SelectAll()
		{
			// Establish additional pre-conditions here
			Step_02_SelectAll_Generated();
			// Add additional verification here
		}
		
		
		
		
		/// <summary>
		/// Deep load all HeThong children.
		/// </summary>
		[NUnit.Framework.Test]
		public void Step_03_DeepLoad()
		{
			// Establish additional pre-conditions here
			Step_03_DeepLoad_Generated();
			// Add additional verification here
		}
		
		
		
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock HeThong entity into a temporary file.
		/// </summary>
		[NUnit.Framework.Test]
		public void Step_06_SerializeEntity()
		{
			// Establish additional pre-conditions here
			Step_06_SerializeEntity_Generated();
			// Add additional verification here
		}
		
		/// <summary>
		/// Deserialize the mock HeThong entity from a temporary file.
		/// </summary>
		[NUnit.Framework.Test]
		public void Step_07_DeserializeEntity()
		{
			// Establish additional pre-conditions here
			Step_07_DeserializeEntity_Generated();
			// Add additional verification here
		}
		
		/// <summary>
		/// Serialize a HeThong collection into a temporary file.
		/// </summary>
		[NUnit.Framework.Test]
		public void Step_08_SerializeCollection()
		{
			// Establish additional pre-conditions here
			Step_08_SerializeCollection_Generated();
			// Add additional verification here
		}
		
		
		/// <summary>
		/// Deserialize a HeThong collection from a temporary file.
		/// </summary>
		[NUnit.Framework.Test]
		public void Step_09_DeserializeCollection()
		{
			// Establish additional pre-conditions here
			Step_09_DeserializeCollection_Generated();
			// Add additional verification here
		}
		#endregion
		
		
		
		
		/// <summary>
		/// Test methods exposed by the EntityHelper class.
		/// </summary>
		[NUnit.Framework.Test]
		public void Step_20_TestEntityHelper()
		{
			Step_20_TestEntityHelper_Generated();
		}

        /// <summary>
        /// Test Find using the Query class
        /// </summary>
        [NUnit.Framework.Test]
        public void Step_30_TestFindByQuery()
        {
            Step_30_TestFindByQuery_Generated();
        }

        ///<summary>
        ///  Returns a Typed HeThong Entity with mock values.
        ///</summary>
        static public HeThong CreateMockInstance(TransactionManager tm)
        {
            // get the default mock instance
            HeThong mock = HeThongTest.CreateMockInstance_Generated(tm);
			
            // make any alterations necessary 
            // (i.e. for DB check constraints, special test cases, etc.)
			SetSpecialTestData(mock);
			
            // return the modified object
            return mock;
        }

        ///<summary>
        ///  Update the Typed HeThong Entity with modified mock values.
        ///</summary>
        static public void UpdateMockInstance(TransactionManager tm, HeThong mock)
        {
            HeThongTest.UpdateMockInstance_Generated(tm, mock);
            
			// make any alterations necessary 
            // (i.e. for DB check constraints, special test cases, etc.)
			SetSpecialTestData(mock);
        }
		
		/// <summary>
        /// Make any alterations necessary (i.e. for DB check constraints, special test cases, etc.)
        /// </summary>
        /// <param name="mock">Object to be modified</param>
        static private void SetSpecialTestData(HeThong mock)
        {
            //Code your changes to the data object here.
        }
    }
}
