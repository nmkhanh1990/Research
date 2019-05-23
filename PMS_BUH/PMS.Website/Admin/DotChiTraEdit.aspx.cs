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

public partial class DotChiTraEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "DotChiTraEdit.aspx?{0}", DotChiTraDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "DotChiTraEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "DotChiTra.aspx");
		FormUtil.SetDefaultMode(FormView1, "Id");
	}
	protected void GridViewTietNoKyTruoc1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewTietNoKyTruoc1.SelectedDataKey.Values[0]);
		Response.Redirect("TietNoKyTruocEdit.aspx?" + urlParams, true);		
	}	
}

