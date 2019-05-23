<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="GiangVienDangKyHinhThucGiangDay.aspx.cs" Inherits="GiangVienDangKyHinhThucGiangDay" Title="GiangVienDangKyHinhThucGiangDay List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Giang Vien Dang Ky Hinh Thuc Giang Day List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="GiangVienDangKyHinhThucGiangDayDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_GiangVienDangKyHinhThucGiangDay.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="MaGiangVien" HeaderText="Ma Giang Vien" SortExpression="[MaGiangVien]"  />
				<asp:BoundField DataField="MaHinhThucDaoTao" HeaderText="Ma Hinh Thuc Dao Tao" SortExpression="[MaHinhThucDaoTao]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No GiangVienDangKyHinhThucGiangDay Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnGiangVienDangKyHinhThucGiangDay" OnClientClick="javascript:location.href='GiangVienDangKyHinhThucGiangDayEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:GiangVienDangKyHinhThucGiangDayDataSource ID="GiangVienDangKyHinhThucGiangDayDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
		>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:GiangVienDangKyHinhThucGiangDayDataSource>
	    		
</asp:Content>



