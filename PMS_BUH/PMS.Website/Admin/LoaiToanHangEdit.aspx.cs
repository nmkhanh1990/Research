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

public partial class LoaiToanHangEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "LoaiToanHangEdit.aspx?{0}", LoaiToanHangDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "LoaiToanHangEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "LoaiToanHang.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaLoaiToanHang");
	}
	protected void GridViewCongThucTinhGiaTriToanHang1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaCongThuc={0}", GridViewCongThucTinhGiaTriToanHang1.SelectedDataKey.Values[0]);
		Response.Redirect("CongThucTinhGiaTriToanHangEdit.aspx?" + urlParams, true);		
	}	
}


