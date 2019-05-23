﻿<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="TinhTrang.aspx.cs" Inherits="TinhTrang" Title="TinhTrang List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Tinh Trang List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="TinhTrangDataSource"
				DataKeyNames="MaTinhTrang"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_TinhTrang.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<data:BoundRadioButtonField DataField="TinhTrang" HeaderText="Tinh Trang" SortExpression="[TinhTrang]"  />
				<data:BoundRadioButtonField DataField="TrangThai" HeaderText="Trang Thai" SortExpression="[TrangThai]"  />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]"  />
				<asp:BoundField DataField="TenTinhTrang" HeaderText="Ten Tinh Trang" SortExpression="[TenTinhTrang]"  />
				<asp:BoundField DataField="ThuTu" HeaderText="Thu Tu" SortExpression="[ThuTu]"  />
				<asp:BoundField DataField="Hrmid" HeaderText="Hrmid" SortExpression="[HRMID]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No TinhTrang Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnTinhTrang" OnClientClick="javascript:location.href='TinhTrangEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:TinhTrangDataSource ID="TinhTrangDataSource" runat="server"
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
		</data:TinhTrangDataSource>
	    		
</asp:Content>



