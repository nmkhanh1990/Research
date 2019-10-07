﻿#region Using directives

using System;

#endregion

namespace PMS.Entities
{	
	///<summary>
	/// An object representation of the 'View_ThanhTraTheoThoiKhoaBieu' view. [No description found in the database]	
	///</summary>
	/// <remarks>
	/// This file is generated once and will never be overwritten.
	/// </remarks>	
	[Serializable]
	[CLSCompliant(true)]
	public partial class ViewThanhTraTheoThoiKhoaBieu : ViewThanhTraTheoThoiKhoaBieuBase
	{
		#region Constructors

		///<summary>
		/// Creates a new <see cref="ViewThanhTraTheoThoiKhoaBieu"/> instance.
		///</summary>
		public ViewThanhTraTheoThoiKhoaBieu():base(){}	
		
		#endregion

        public string GioVao { get; set; }
        public string GioRa { get; set; }
	}
}