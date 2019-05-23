﻿<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KcqMonTieuLuan.aspx.cs" Inherits="KcqMonTieuLuan" Title="KcqMonTieuLuan List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Kcq Mon Tieu Luan List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="KcqMonTieuLuanDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_KcqMonTieuLuan.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="NgayCapNhat" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="TenMonHoc" HeaderText="Ten Mon Hoc" SortExpression="[TenMonHoc]"  />
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]"  />
				<asp:BoundField DataField="TenBoMon" HeaderText="Ten Bo Mon" SortExpression="[TenBoMon]"  />
				<asp:BoundField DataField="SoTinChi" HeaderText="So Tin Chi" SortExpression="[SoTinChi]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No KcqMonTieuLuan Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnKcqMonTieuLuan" OnClientClick="javascript:location.href='KcqMonTieuLuanEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:KcqMonTieuLuanDataSource ID="KcqMonTieuLuanDataSource" runat="server"
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
		</data:KcqMonTieuLuanDataSource>
	    		
</asp:Content>



