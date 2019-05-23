<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ThanhToanThinhGiang.aspx.cs" Inherits="ThanhToanThinhGiang" Title="ThanhToanThinhGiang List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Thanh Toan Thinh Giang List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ThanhToanThinhGiangDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ThanhToanThinhGiang.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="CongHeSo" HeaderText="Cong He So" SortExpression="[CongHeSo]"  />
				<asp:BoundField DataField="DonGia" HeaderText="Don Gia" SortExpression="[DonGia]"  />
				<asp:BoundField DataField="HeSo" HeaderText="He So" SortExpression="[HeSo]"  />
				<asp:BoundField DataField="HeSoChucDanh" HeaderText="He So Chuc Danh" SortExpression="[HeSoChucDanh]"  />
				<asp:BoundField DataField="ThanhTien" HeaderText="Thanh Tien" SortExpression="[ThanhTien]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="NgayXacNhan" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Xac Nhan" SortExpression="[NgayXacNhan]"  />
				<asp:BoundField DataField="Thue" HeaderText="Thue" SortExpression="[Thue]"  />
				<asp:BoundField DataField="ConNhan" HeaderText="Con Nhan" SortExpression="[ConNhan]"  />
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]"  />
				<asp:BoundField DataField="MaGiangVien" HeaderText="Ma Giang Vien" SortExpression="[MaGiangVien]"  />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="ChucDanh" HeaderText="Chuc Danh" SortExpression="[ChucDanh]"  />
				<asp:BoundField DataField="Stt" HeaderText="Stt" SortExpression="[Stt]"  />
				<asp:BoundField DataField="NoiDung" HeaderText="Noi Dung" SortExpression="[NoiDung]"  />
				<asp:BoundField DataField="MaLop" HeaderText="Ma Lop" SortExpression="[MaLop]"  />
				<asp:BoundField DataField="SiSo" HeaderText="Si So" SortExpression="[SiSo]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No ThanhToanThinhGiang Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnThanhToanThinhGiang" OnClientClick="javascript:location.href='ThanhToanThinhGiangEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ThanhToanThinhGiangDataSource ID="ThanhToanThinhGiangDataSource" runat="server"
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
		</data:ThanhToanThinhGiangDataSource>
	    		
</asp:Content>



