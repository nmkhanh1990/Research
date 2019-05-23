<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="HeSoQuyDoiThucHanhSangLyThuyet.aspx.cs" Inherits="HeSoQuyDoiThucHanhSangLyThuyet" Title="HeSoQuyDoiThucHanhSangLyThuyet List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">He So Quy Doi Thuc Hanh Sang Ly Thuyet List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="HeSoQuyDoiThucHanhSangLyThuyetDataSource"
				DataKeyNames="NamHoc, HocKy"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_HeSoQuyDoiThucHanhSangLyThuyet.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" ReadOnly="True" />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="HeSo" HeaderText="He So" SortExpression="[HeSo]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" ReadOnly="True" />
			</Columns>
			<EmptyDataTemplate>
				<b>No HeSoQuyDoiThucHanhSangLyThuyet Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnHeSoQuyDoiThucHanhSangLyThuyet" OnClientClick="javascript:location.href='HeSoQuyDoiThucHanhSangLyThuyetEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:HeSoQuyDoiThucHanhSangLyThuyetDataSource ID="HeSoQuyDoiThucHanhSangLyThuyetDataSource" runat="server"
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
		</data:HeSoQuyDoiThucHanhSangLyThuyetDataSource>
	    		
</asp:Content>



