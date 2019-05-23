<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="LopHocPhanTinhSiSoRieng.aspx.cs" Inherits="LopHocPhanTinhSiSoRieng" Title="LopHocPhanTinhSiSoRieng List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Lop Hoc Phan Tinh Si So Rieng List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="LopHocPhanTinhSiSoRiengDataSource"
				DataKeyNames="MaLopHocPhan"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_LopHocPhanTinhSiSoRieng.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="SiSo" HeaderText="Si So" SortExpression="[SiSo]"  />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]" ReadOnly="True" />
			</Columns>
			<EmptyDataTemplate>
				<b>No LopHocPhanTinhSiSoRieng Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnLopHocPhanTinhSiSoRieng" OnClientClick="javascript:location.href='LopHocPhanTinhSiSoRiengEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:LopHocPhanTinhSiSoRiengDataSource ID="LopHocPhanTinhSiSoRiengDataSource" runat="server"
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
		</data:LopHocPhanTinhSiSoRiengDataSource>
	    		
</asp:Content>



