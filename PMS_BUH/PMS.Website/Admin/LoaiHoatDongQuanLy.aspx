<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="LoaiHoatDongQuanLy.aspx.cs" Inherits="LoaiHoatDongQuanLy" Title="LoaiHoatDongQuanLy List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Loai Hoat Dong Quan Ly List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="LoaiHoatDongQuanLyDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_LoaiHoatDongQuanLy.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="ChuTriDeTaiHuong" HeaderText="Chu Tri De Tai Huong" SortExpression="[ChuTriDeTaiHuong]"  />
				<asp:BoundField DataField="ThanhVienHuong" HeaderText="Thanh Vien Huong" SortExpression="[ThanhVienHuong]"  />
				<asp:BoundField DataField="DonViHdql" HeaderText="Don Vi Hdql" SortExpression="[DonViHDQL]"  />
				<asp:BoundField DataField="MaLoaiHdql" HeaderText="Ma Loai Hdql" SortExpression="[MaLoaiHDQL]"  />
				<asp:BoundField DataField="TenLoaiNhdql" HeaderText="Ten Loai Nhdql" SortExpression="[TenLoaiNHDQL]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No LoaiHoatDongQuanLy Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnLoaiHoatDongQuanLy" OnClientClick="javascript:location.href='LoaiHoatDongQuanLyEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:LoaiHoatDongQuanLyDataSource ID="LoaiHoatDongQuanLyDataSource" runat="server"
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
		</data:LoaiHoatDongQuanLyDataSource>
	    		
</asp:Content>



