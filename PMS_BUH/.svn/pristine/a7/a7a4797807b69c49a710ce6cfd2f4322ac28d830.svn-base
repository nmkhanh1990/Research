<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="DonGiaPhuCap.aspx.cs" Inherits="DonGiaPhuCap" Title="DonGiaPhuCap List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Don Gia Phu Cap List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="DonGiaPhuCapDataSource"
				DataKeyNames="IdPhuCap"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_DonGiaPhuCap.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="NgayCapNhat" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<data:BoundRadioButtonField DataField="TinhTrang" HeaderText="Tinh Trang" SortExpression="[TinhTrang]"  />
				<asp:BoundField DataField="TenPhuCap" HeaderText="Ten Phu Cap" SortExpression="[TenPhuCap]"  />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]"  />
				<asp:BoundField DataField="DonVi" HeaderText="Don Vi" SortExpression="[DonVi]"  />
				<asp:BoundField DataField="DonGia" HeaderText="Don Gia" SortExpression="[DonGia]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No DonGiaPhuCap Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnDonGiaPhuCap" OnClientClick="javascript:location.href='DonGiaPhuCapEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:DonGiaPhuCapDataSource ID="DonGiaPhuCapDataSource" runat="server"
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
		</data:DonGiaPhuCapDataSource>
	    		
</asp:Content>



