<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="CongThucTinhGiaTriToanHang.aspx.cs" Inherits="CongThucTinhGiaTriToanHang" Title="CongThucTinhGiaTriToanHang List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Cong Thuc Tinh Gia Tri Toan Hang List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="CongThucTinhGiaTriToanHangDataSource"
				DataKeyNames="MaCongThuc"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_CongThucTinhGiaTriToanHang.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="ThamSoDauVao" HeaderText="Tham So Dau Vao" SortExpression="[ThamSoDauVao]"  />
				<asp:BoundField DataField="TenHamThucHien" HeaderText="Ten Ham Thuc Hien" SortExpression="[TenHamThucHien]"  />
				<asp:BoundField DataField="GiaTriMacDinh" HeaderText="Gia Tri Mac Dinh" SortExpression="[GiaTriMacDinh]"  />
				<asp:BoundField DataField="CotLayGiaTri" HeaderText="Cot Lay Gia Tri" SortExpression="[CotLayGiaTri]"  />
				<asp:BoundField DataField="DienGiai" HeaderText="Dien Giai" SortExpression="[DienGiai]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<data:HyperLinkField HeaderText="Ma Loai Toan Hang" DataNavigateUrlFormatString="LoaiToanHangEdit.aspx?MaLoaiToanHang={0}" DataNavigateUrlFields="MaLoaiToanHang" DataContainer="MaLoaiToanHangSource" DataTextField="TenLoaiToanHang" />
				<data:BoundRadioButtonField DataField="ApDung" HeaderText="Ap Dung" SortExpression="[ApDung]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No CongThucTinhGiaTriToanHang Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnCongThucTinhGiaTriToanHang" OnClientClick="javascript:location.href='CongThucTinhGiaTriToanHangEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:CongThucTinhGiaTriToanHangDataSource ID="CongThucTinhGiaTriToanHangDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:CongThucTinhGiaTriToanHangProperty Name="LoaiToanHang"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:CongThucTinhGiaTriToanHangDataSource>
	    		
</asp:Content>



