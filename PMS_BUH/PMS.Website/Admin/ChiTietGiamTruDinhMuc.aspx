<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ChiTietGiamTruDinhMuc.aspx.cs" Inherits="ChiTietGiamTruDinhMuc" Title="ChiTietGiamTruDinhMuc List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Chi Tiet Giam Tru Dinh Muc List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ChiTietGiamTruDinhMucDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ChiTietGiamTruDinhMuc.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="DinhMucNckh" HeaderText="Dinh Muc Nckh" SortExpression="[DinhMucNckh]"  />
				<asp:BoundField DataField="DinhMucHoatDongKhac" HeaderText="Dinh Muc Hoat Dong Khac" SortExpression="[DinhMucHoatDongKhac]"  />
				<asp:BoundField DataField="DinhMucGiangDay" HeaderText="Dinh Muc Giang Day" SortExpression="[DinhMucGiangDay]"  />
				<asp:BoundField DataField="MaGiamTruDinhMuc" HeaderText="Ma Giam Tru Dinh Muc" SortExpression="[MaGiamTruDinhMuc]"  />
				<asp:BoundField DataField="MaNhomGiangVien" HeaderText="Ma Nhom Giang Vien" SortExpression="[MaNhomGiangVien]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No ChiTietGiamTruDinhMuc Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnChiTietGiamTruDinhMuc" OnClientClick="javascript:location.href='ChiTietGiamTruDinhMucEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ChiTietGiamTruDinhMucDataSource ID="ChiTietGiamTruDinhMucDataSource" runat="server"
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
		</data:ChiTietGiamTruDinhMucDataSource>
	    		
</asp:Content>



