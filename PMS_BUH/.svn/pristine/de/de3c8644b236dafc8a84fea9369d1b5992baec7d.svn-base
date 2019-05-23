<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="GiangVienTheoDot.aspx.cs" Inherits="GiangVienTheoDot" Title="GiangVienTheoDot List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Giang Vien Theo Dot List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="GiangVienTheoDotDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_GiangVienTheoDot.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="DotThanhToan" HeaderText="Dot Thanh Toan" SortExpression="[DotThanhToan]"  />
				<asp:BoundField DataField="GiamTruDinhMuc" HeaderText="Giam Tru Dinh Muc" SortExpression="[GiamTruDinhMuc]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="StnckhThucHien" HeaderText="Stnckh Thuc Hien" SortExpression="[STNCKHThucHien]"  />
				<asp:BoundField DataField="MaGiangVien" HeaderText="Ma Giang Vien" SortExpression="[MaGiangVien]"  />
				<asp:BoundField DataField="DinhMuc" HeaderText="Dinh Muc" SortExpression="[DinhMuc]"  />
				<asp:BoundField DataField="StnckhDuocTru" HeaderText="Stnckh Duoc Tru" SortExpression="[STNCKHDuocTru]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No GiangVienTheoDot Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnGiangVienTheoDot" OnClientClick="javascript:location.href='GiangVienTheoDotEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:GiangVienTheoDotDataSource ID="GiangVienTheoDotDataSource" runat="server"
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
		</data:GiangVienTheoDotDataSource>
	    		
</asp:Content>



