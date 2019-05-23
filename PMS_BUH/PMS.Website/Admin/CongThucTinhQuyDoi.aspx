<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="CongThucTinhQuyDoi.aspx.cs" Inherits="CongThucTinhQuyDoi" Title="CongThucTinhQuyDoi List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Cong Thuc Tinh Quy Doi List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="CongThucTinhQuyDoiDataSource"
				DataKeyNames="MaCongThuc"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_CongThucTinhQuyDoi.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="DienGiai" HeaderText="Dien Giai" SortExpression="[DienGiai]"  />
				<data:BoundRadioButtonField DataField="ApDung" HeaderText="Ap Dung" SortExpression="[ApDung]"  />
				<data:BoundRadioButtonField DataField="TinhVuotTran" HeaderText="Tinh Vuot Tran" SortExpression="[TinhVuotTran]"  />
				<data:BoundRadioButtonField DataField="TinhVuotDinhMuc" HeaderText="Tinh Vuot Dinh Muc" SortExpression="[TinhVuotDinhMuc]"  />
				<asp:BoundField DataField="ToanHangSuDung" HeaderText="Toan Hang Su Dung" SortExpression="[ToanHangSuDung]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<data:HyperLinkField HeaderText="Ma Loai Cong Thuc" DataNavigateUrlFormatString="LoaiCongThucEdit.aspx?MaLoaiCongThuc={0}" DataNavigateUrlFields="MaLoaiCongThuc" DataContainer="MaLoaiCongThucSource" DataTextField="TenLoaiCongThuc" />
				<asp:BoundField DataField="CongThuc" HeaderText="Cong Thuc" SortExpression="[CongThuc]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No CongThucTinhQuyDoi Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnCongThucTinhQuyDoi" OnClientClick="javascript:location.href='CongThucTinhQuyDoiEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:CongThucTinhQuyDoiDataSource ID="CongThucTinhQuyDoiDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:CongThucTinhQuyDoiProperty Name="LoaiCongThuc"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:CongThucTinhQuyDoiDataSource>
	    		
</asp:Content>



