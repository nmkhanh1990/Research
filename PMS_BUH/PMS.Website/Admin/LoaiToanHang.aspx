<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="LoaiToanHang.aspx.cs" Inherits="LoaiToanHang" Title="LoaiToanHang List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Loai Toan Hang List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="LoaiToanHangDataSource"
				DataKeyNames="MaLoaiToanHang"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_LoaiToanHang.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="TenBang" HeaderText="Ten Bang" SortExpression="[TenBang]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="MaLoaiToanHang" HeaderText="Ma Loai Toan Hang" SortExpression="[MaLoaiToanHang]" ReadOnly="True" />
				<asp:BoundField DataField="TenLoaiToanHang" HeaderText="Ten Loai Toan Hang" SortExpression="[TenLoaiToanHang]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No LoaiToanHang Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnLoaiToanHang" OnClientClick="javascript:location.href='LoaiToanHangEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:LoaiToanHangDataSource ID="LoaiToanHangDataSource" runat="server"
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
		</data:LoaiToanHangDataSource>
	    		
</asp:Content>



