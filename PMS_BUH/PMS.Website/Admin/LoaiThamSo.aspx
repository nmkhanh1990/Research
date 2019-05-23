<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="LoaiThamSo.aspx.cs" Inherits="LoaiThamSo" Title="LoaiThamSo List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Loai Tham So List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="LoaiThamSoDataSource"
				DataKeyNames="MaLoaiThamSo"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_LoaiThamSo.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="TenBang" HeaderText="Ten Bang" SortExpression="[TenBang]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="MaLoaiThamSo" HeaderText="Ma Loai Tham So" SortExpression="[MaLoaiThamSo]" ReadOnly="True" />
				<asp:BoundField DataField="TenLoaiThamSo" HeaderText="Ten Loai Tham So" SortExpression="[TenLoaiThamSo]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No LoaiThamSo Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnLoaiThamSo" OnClientClick="javascript:location.href='LoaiThamSoEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:LoaiThamSoDataSource ID="LoaiThamSoDataSource" runat="server"
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
		</data:LoaiThamSoDataSource>
	    		
</asp:Content>



