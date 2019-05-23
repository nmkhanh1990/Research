<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="GiangVienThayDoiBacLuong.aspx.cs" Inherits="GiangVienThayDoiBacLuong" Title="GiangVienThayDoiBacLuong List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Giang Vien Thay Doi Bac Luong List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="GiangVienThayDoiBacLuongDataSource"
				DataKeyNames="MaQuanLy"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_GiangVienThayDoiBacLuong.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="NgayHieuLuc" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Hieu Luc" SortExpression="[NgayHieuLuc]"  />
				<asp:BoundField DataField="NgayCapNhat" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="UserId" HeaderText="User Id" SortExpression="[UserID]"  />
				<asp:BoundField DataField="MaBacLuong" HeaderText="Ma Bac Luong" SortExpression="[MaBacLuong]"  />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]" ReadOnly="True" />
				<asp:BoundField DataField="MaGiangVien" HeaderText="Ma Giang Vien" SortExpression="[MaGiangVien]"  />
				<asp:BoundField DataField="MaBacLuongCu" HeaderText="Ma Bac Luong Cu" SortExpression="[MaBacLuongCu]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No GiangVienThayDoiBacLuong Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnGiangVienThayDoiBacLuong" OnClientClick="javascript:location.href='GiangVienThayDoiBacLuongEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:GiangVienThayDoiBacLuongDataSource ID="GiangVienThayDoiBacLuongDataSource" runat="server"
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
		</data:GiangVienThayDoiBacLuongDataSource>
	    		
</asp:Content>



