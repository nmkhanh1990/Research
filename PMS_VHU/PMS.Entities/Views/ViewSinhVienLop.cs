﻿#region Using directives

using System;

#endregion

namespace PMS.Entities
{	
	///<summary>
	/// An object representation of the 'View_SinhVien_Lop' view. [No description found in the database]	
	///</summary>
	/// <remarks>
	/// This file is generated once and will never be overwritten.
	/// </remarks>	
	[Serializable]
	[CLSCompliant(true)]
	public partial class ViewSinhVienLop : ViewSinhVienLopBase
	{
		#region Constructors

		///<summary>
		/// Creates a new <see cref="ViewSinhVienLop"/> instance.
		///</summary>
		public ViewSinhVienLop():base(){}

        #endregion
                
        public bool Chon { get; set; }
    }
}
