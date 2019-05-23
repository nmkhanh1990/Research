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

public partial class GiangVienEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "GiangVienEdit.aspx?{0}", GiangVienDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "GiangVienEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "GiangVien.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaGiangVien");
	}
	protected void GridViewTietNoKyTruoc1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewTietNoKyTruoc1.SelectedDataKey.Values[0]);
		Response.Redirect("TietNoKyTruocEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewKcqKhoiLuongKhac2_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaKhoiLuong={0}", GridViewKcqKhoiLuongKhac2.SelectedDataKey.Values[0]);
		Response.Redirect("KcqKhoiLuongKhacEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewThuLaoThoaThuan3_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaThuLao={0}", GridViewThuLaoThoaThuan3.SelectedDataKey.Values[0]);
		Response.Redirect("ThuLaoThoaThuanEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewGiangVienCamKetKhongTruThue4_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaGiangVien={0}&NamHoc={1}&HocKy={2}", GridViewGiangVienCamKetKhongTruThue4.SelectedDataKey.Values[0], GridViewGiangVienCamKetKhongTruThue4.SelectedDataKey.Values[1], GridViewGiangVienCamKetKhongTruThue4.SelectedDataKey.Values[2]);
		Response.Redirect("GiangVienCamKetKhongTruThueEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewThamDinhLuanVanThacSy5_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewThamDinhLuanVanThacSy5.SelectedDataKey.Values[0]);
		Response.Redirect("ThamDinhLuanVanThacSyEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewThoiGianLamViecCuaNhanVien6_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewThoiGianLamViecCuaNhanVien6.SelectedDataKey.Values[0]);
		Response.Redirect("ThoiGianLamViecCuaNhanVienEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewGiangVienHoatDongQuanLy7_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewGiangVienHoatDongQuanLy7.SelectedDataKey.Values[0]);
		Response.Redirect("GiangVienHoatDongQuanLyEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewKhoiLuongKhac8_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaKhoiLuong={0}", GridViewKhoiLuongKhac8.SelectedDataKey.Values[0]);
		Response.Redirect("KhoiLuongKhacEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewCoVanHocTap9_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaCoVan={0}", GridViewCoVanHocTap9.SelectedDataKey.Values[0]);
		Response.Redirect("CoVanHocTapEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewGiangVienNghienCuuKh10_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewGiangVienNghienCuuKh10.SelectedDataKey.Values[0]);
		Response.Redirect("GiangVienNghienCuuKhEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewGiangVienChucVu11_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaQuanLy={0}&MaGiangVien={1}&MaChucVu={2}", GridViewGiangVienChucVu11.SelectedDataKey.Values[0], GridViewGiangVienChucVu11.SelectedDataKey.Values[1], GridViewGiangVienChucVu11.SelectedDataKey.Values[2]);
		Response.Redirect("GiangVienChucVuEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewXetDuyetDeCuongLuanVanCaoHoc12_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewXetDuyetDeCuongLuanVanCaoHoc12.SelectedDataKey.Values[0]);
		Response.Redirect("XetDuyetDeCuongLuanVanCaoHocEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewKetQuaTinh13_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaKetQua={0}", GridViewKetQuaTinh13.SelectedDataKey.Values[0]);
		Response.Redirect("KetQuaTinhEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewThoiGianNghiTamThoiCuaGiangVien14_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewThoiGianNghiTamThoiCuaGiangVien14.SelectedDataKey.Values[0]);
		Response.Redirect("ThoiGianNghiTamThoiCuaGiangVienEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewGiangVienChuyenMon15_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaPhanCong={0}", GridViewGiangVienChuyenMon15.SelectedDataKey.Values[0]);
		Response.Redirect("GiangVienChuyenMonEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewTietNghiaVu16_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewTietNghiaVu16.SelectedDataKey.Values[0]);
		Response.Redirect("TietNghiaVuEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewGiangVienMocTangLuong17_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewGiangVienMocTangLuong17.SelectedDataKey.Values[0]);
		Response.Redirect("GiangVienMocTangLuongEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewGiangVienGiamTruDinhMuc18_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaQuanLy={0}", GridViewGiangVienGiamTruDinhMuc18.SelectedDataKey.Values[0]);
		Response.Redirect("GiangVienGiamTruDinhMucEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewGiangVienHoatDongNgoaiGiangDay19_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaQuanLy={0}", GridViewGiangVienHoatDongNgoaiGiangDay19.SelectedDataKey.Values[0]);
		Response.Redirect("GiangVienHoatDongNgoaiGiangDayEdit.aspx?" + urlParams, true);		
	}	
}


