﻿#region Imports...
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using PMS.Web.UI;
#endregion

public partial class LoaiNghienCuuKhoaHocEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "LoaiNghienCuuKhoaHocEdit.aspx?{0}", LoaiNghienCuuKhoaHocDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "LoaiNghienCuuKhoaHocEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "LoaiNghienCuuKhoaHoc.aspx");
		FormUtil.SetDefaultMode(FormView1, "Id");
	}
	protected void GridViewDanhMucNghienCuuKhoaHoc1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewDanhMucNghienCuuKhoaHoc1.SelectedDataKey.Values[0]);
		Response.Redirect("DanhMucNghienCuuKhoaHocEdit.aspx?" + urlParams, true);		
	}	
}

