<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="DonGiaTheoNganh.aspx.cs" Inherits="DonGiaTheoNganh" Title="DonGiaTheoNganh List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Don Gia Theo Nganh List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="DonGiaTheoNganhDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_DonGiaTheoNganh.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="DonGiaNgoaiChuan" HeaderText="Don Gia Ngoai Chuan" SortExpression="[DonGiaNgoaiChuan]"  />
				<asp:BoundField DataField="MaHinhThucDaoTao" HeaderText="Ma Hinh Thuc Dao Tao" SortExpression="[MaHinhThucDaoTao]"  />
				<asp:BoundField DataField="BacDaoTao" HeaderText="Bac Dao Tao" SortExpression="[BacDaoTao]"  />
				<asp:BoundField DataField="DonGiaClc" HeaderText="Don Gia Clc" SortExpression="[DonGiaClc]"  />
				<asp:BoundField DataField="HeSoQuyDoiChatLuong" HeaderText="He So Quy Doi Chat Luong" SortExpression="[HeSoQuyDoiChatLuong]"  />
				<asp:BoundField DataField="DonGiaTrongChuan" HeaderText="Don Gia Trong Chuan" SortExpression="[DonGiaTrongChuan]"  />
				<data:HyperLinkField HeaderText="Ngon Ngu Giang Day" DataNavigateUrlFormatString="NgonNguGiangDayEdit.aspx?MaNgonNgu={0}" DataNavigateUrlFields="MaNgonNgu" DataContainer="NgonNguGiangDaySource" DataTextField="TenNgonNgu" />
				<asp:BoundField DataField="NhomMonHoc" HeaderText="Nhom Mon Hoc" SortExpression="[NhomMonHoc]"  />
				<asp:BoundField DataField="DonGiaNgoaiNgu" HeaderText="Don Gia Ngoai Ngu" SortExpression="[DonGiaNgoaiNgu]"  />
				<asp:BoundField DataField="DonGiaDoAnClc" HeaderText="Don Gia Do An Clc" SortExpression="[DonGiaDoAnClc]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<data:HyperLinkField HeaderText="Ma Nhom Mon" DataNavigateUrlFormatString="NhomMonHocEdit.aspx?MaNhomMon={0}" DataNavigateUrlFields="MaNhomMon" DataContainer="MaNhomMonSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Hoc Vi" DataNavigateUrlFormatString="HocViEdit.aspx?MaHocVi={0}" DataNavigateUrlFields="MaHocVi" DataContainer="MaHocViSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="DonGiaCh" HeaderText="Don Gia Ch" SortExpression="[DonGiaCH]"  />
				<asp:BoundField DataField="DonGiaTgkc" HeaderText="Don Gia Tgkc" SortExpression="[DonGiaTGKC]"  />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]"  />
				<data:HyperLinkField HeaderText="Ma Loai Giang Vien" DataNavigateUrlFormatString="LoaiGiangVienEdit.aspx?MaLoaiGiangVien={0}" DataNavigateUrlFields="MaLoaiGiangVien" DataContainer="MaLoaiGiangVienSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Hoc Ham" DataNavigateUrlFormatString="HocHamEdit.aspx?MaHocHam={0}" DataNavigateUrlFields="MaHocHam" DataContainer="MaHocHamSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="DonGiaTgc" HeaderText="Don Gia Tgc" SortExpression="[DonGiaTGC]"  />
				<asp:BoundField DataField="MaDonGiaNhomNganh" HeaderText="Ma Don Gia Nhom Nganh" SortExpression="[MaDonGiaNhomNganh]"  />
				<asp:BoundField DataField="NgayCapNhat" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="DonGiaHocPhan" HeaderText="Don Gia Hoc Phan" SortExpression="[DonGiaHocPhan]"  />
				<asp:BoundField DataField="DonGiaLt" HeaderText="Don Gia Lt" SortExpression="[DonGiaLT]"  />
				<asp:BoundField DataField="DonGiaTh" HeaderText="Don Gia Th" SortExpression="[DonGiaTH]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No DonGiaTheoNganh Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnDonGiaTheoNganh" OnClientClick="javascript:location.href='DonGiaTheoNganhEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:DonGiaTheoNganhDataSource ID="DonGiaTheoNganhDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:DonGiaTheoNganhProperty Name="HocHam"/> 
					<data:DonGiaTheoNganhProperty Name="HocVi"/> 
					<data:DonGiaTheoNganhProperty Name="LoaiGiangVien"/> 
					<data:DonGiaTheoNganhProperty Name="NgonNguGiangDay"/> 
					<data:DonGiaTheoNganhProperty Name="NhomMonHoc"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:DonGiaTheoNganhDataSource>
	    		
</asp:Content>



