<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="MonHocDayTiengNuocNgoai.aspx.cs" Inherits="MonHocDayTiengNuocNgoai" Title="MonHocDayTiengNuocNgoai List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Mon Hoc Day Tieng Nuoc Ngoai List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="MonHocDayTiengNuocNgoaiDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_MonHocDayTiengNuocNgoai.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="NguoiCapNhat" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="NgayCapNhat" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="MaNgonNgu" HeaderText="Ma Ngon Ngu" SortExpression="[MaNgonNgu]"  />
				<asp:BoundField DataField="TenMonHoc" HeaderText="Ten Mon Hoc" SortExpression="[TenMonHoc]"  />
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]"  />
				<asp:BoundField DataField="HeSoMonHoc" HeaderText="He So Mon Hoc" SortExpression="[HeSoMonHoc]"  />
				<data:BoundRadioButtonField DataField="TrangThai" HeaderText="Trang Thai" SortExpression="[TrangThai]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No MonHocDayTiengNuocNgoai Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnMonHocDayTiengNuocNgoai" OnClientClick="javascript:location.href='MonHocDayTiengNuocNgoaiEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:MonHocDayTiengNuocNgoaiDataSource ID="MonHocDayTiengNuocNgoaiDataSource" runat="server"
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
		</data:MonHocDayTiengNuocNgoaiDataSource>
	    		
</asp:Content>



