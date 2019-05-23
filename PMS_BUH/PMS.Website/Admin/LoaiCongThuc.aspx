<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="LoaiCongThuc.aspx.cs" Inherits="LoaiCongThuc" Title="LoaiCongThuc List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Loai Cong Thuc List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="LoaiCongThucDataSource"
				DataKeyNames="MaLoaiCongThuc"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_LoaiCongThuc.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="TenLoaiCongThuc" HeaderText="Ten Loai Cong Thuc" SortExpression="[TenLoaiCongThuc]"  />
				<asp:BoundField DataField="MaLoaiCongThuc" HeaderText="Ma Loai Cong Thuc" SortExpression="[MaLoaiCongThuc]" ReadOnly="True" />
			</Columns>
			<EmptyDataTemplate>
				<b>No LoaiCongThuc Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnLoaiCongThuc" OnClientClick="javascript:location.href='LoaiCongThucEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:LoaiCongThucDataSource ID="LoaiCongThucDataSource" runat="server"
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
		</data:LoaiCongThucDataSource>
	    		
</asp:Content>



