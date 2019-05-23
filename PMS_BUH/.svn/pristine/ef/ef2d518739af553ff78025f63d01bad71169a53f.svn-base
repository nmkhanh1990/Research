<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="LoaiThucHien.aspx.cs" Inherits="LoaiThucHien" Title="LoaiThucHien List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Loai Thuc Hien List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="LoaiThucHienDataSource"
				DataKeyNames="MaLoaiThucHien"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_LoaiThucHien.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<data:BoundRadioButtonField DataField="TrangThaiDung" HeaderText="Trang Thai Dung" SortExpression="[TrangThaiDung]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="NguoiThucHien" HeaderText="Nguoi Thuc Hien" SortExpression="[NguoiThucHien]"  />
				<asp:BoundField DataField="TenLoaiThucHien" HeaderText="Ten Loai Thuc Hien" SortExpression="[TenLoaiThucHien]"  />
				<asp:BoundField DataField="NgayThucHien" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Thuc Hien" SortExpression="[NgayThucHien]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No LoaiThucHien Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnLoaiThucHien" OnClientClick="javascript:location.href='LoaiThucHienEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:LoaiThucHienDataSource ID="LoaiThucHienDataSource" runat="server"
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
		</data:LoaiThucHienDataSource>
	    		
</asp:Content>



