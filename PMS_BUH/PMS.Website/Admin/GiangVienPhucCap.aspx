<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="GiangVienPhucCap.aspx.cs" Inherits="GiangVienPhucCap" Title="GiangVienPhucCap List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Giang Vien Phuc Cap List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="GiangVienPhucCapDataSource"
				DataKeyNames="MaQuanLy"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_GiangVienPhucCap.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<data:BoundRadioButtonField DataField="TinhTrang" HeaderText="Tinh Trang" SortExpression="[TinhTrang]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]"  />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]"  />
				<asp:BoundField DataField="MaPhuCap" HeaderText="Ma Phu Cap" SortExpression="[MaPhuCap]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="MaGiangVien" HeaderText="Ma Giang Vien" SortExpression="[MaGiangVien]"  />
				<asp:BoundField DataField="NgayCapNhat" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="SoNgay" HeaderText="So Ngay" SortExpression="[SoNgay]"  />
				<asp:BoundField DataField="SoDot" HeaderText="So Dot" SortExpression="[SoDot]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No GiangVienPhucCap Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnGiangVienPhucCap" OnClientClick="javascript:location.href='GiangVienPhucCapEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:GiangVienPhucCapDataSource ID="GiangVienPhucCapDataSource" runat="server"
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
		</data:GiangVienPhucCapDataSource>
	    		
</asp:Content>



