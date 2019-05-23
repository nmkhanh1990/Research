#region Imports...
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

public partial class LoaiCongThucEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "LoaiCongThucEdit.aspx?{0}", LoaiCongThucDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "LoaiCongThucEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "LoaiCongThuc.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaLoaiCongThuc");
	}
	protected void GridViewCongThucTinhQuyDoi1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaCongThuc={0}", GridViewCongThucTinhQuyDoi1.SelectedDataKey.Values[0]);
		Response.Redirect("CongThucTinhQuyDoiEdit.aspx?" + urlParams, true);		
	}	
}


