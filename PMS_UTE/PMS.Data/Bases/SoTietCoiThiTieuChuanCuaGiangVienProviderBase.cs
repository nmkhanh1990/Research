﻿#region Using directives

using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;

using System.Diagnostics;
using PMS.Entities;
using PMS.Data;

#endregion

namespace PMS.Data.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="SoTietCoiThiTieuChuanCuaGiangVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SoTietCoiThiTieuChuanCuaGiangVienProviderBase : SoTietCoiThiTieuChuanCuaGiangVienProviderBaseCore
	{
	} // end class
} // end namespace
