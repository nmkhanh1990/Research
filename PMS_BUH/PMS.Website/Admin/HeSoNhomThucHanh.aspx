﻿<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="HeSoNhomThucHanh.aspx.cs" Inherits="HeSoNhomThucHanh" Title="HeSoNhomThucHanh List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">He So Nhom Thuc Hanh List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="HeSoNhomThucHanhDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_HeSoNhomThucHanh.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="MaBacDaoTao" HeaderText="Ma Bac Dao Tao" SortExpression="[MaBacDaoTao]"  />
				<asp:BoundField DataField="MaNhomMonHoc" HeaderText="Ma Nhom Mon Hoc" SortExpression="[MaNhomMonHoc]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="DenKhoan" HeaderText="Den Khoan" SortExpression="[DenKhoan]"  />
				<asp:BoundField DataField="TuKhoan" HeaderText="Tu Khoan" SortExpression="[TuKhoan]"  />
				<asp:BoundField DataField="HeSo" HeaderText="He So" SortExpression="[HeSo]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No HeSoNhomThucHanh Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnHeSoNhomThucHanh" OnClientClick="javascript:location.href='HeSoNhomThucHanhEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:HeSoNhomThucHanhDataSource ID="HeSoNhomThucHanhDataSource" runat="server"
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
		</data:HeSoNhomThucHanhDataSource>
	    		
</asp:Content>


