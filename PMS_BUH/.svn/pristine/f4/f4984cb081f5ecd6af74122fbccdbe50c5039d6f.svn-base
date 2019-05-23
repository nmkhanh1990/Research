<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="LoaiCongThucEdit.aspx.cs" Inherits="LoaiCongThucEdit" Title="LoaiCongThuc Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Loai Cong Thuc - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaLoaiCongThuc" runat="server" DataSourceID="LoaiCongThucDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/LoaiCongThucFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/LoaiCongThucFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>LoaiCongThuc not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:LoaiCongThucDataSource ID="LoaiCongThucDataSource" runat="server"
			SelectMethod="GetByMaLoaiCongThuc"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaLoaiCongThuc" QueryStringField="MaLoaiCongThuc" Type="String" />

			</Parameters>
		</data:LoaiCongThucDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewCongThucTinhQuyDoi1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewCongThucTinhQuyDoi1_SelectedIndexChanged"			 			 
			DataSourceID="CongThucTinhQuyDoiDataSource1"
			DataKeyNames="MaCongThuc"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_CongThucTinhQuyDoi.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Loai Cong Thuc" DataNavigateUrlFormatString="LoaiCongThucEdit.aspx?MaLoaiCongThuc={0}" DataNavigateUrlFields="MaLoaiCongThuc" DataContainer="MaLoaiCongThucSource" DataTextField="TenLoaiCongThuc" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<asp:BoundField DataField="CongThuc" HeaderText="Cong Thuc" SortExpression="[CongThuc]" />				
				<asp:BoundField DataField="ToanHangSuDung" HeaderText="Toan Hang Su Dung" SortExpression="[ToanHangSuDung]" />				
				<asp:BoundField DataField="ApDung" HeaderText="Ap Dung" SortExpression="[ApDung]" />				
				<asp:BoundField DataField="DienGiai" HeaderText="Dien Giai" SortExpression="[DienGiai]" />				
				<asp:BoundField DataField="TinhVuotDinhMuc" HeaderText="Tinh Vuot Dinh Muc" SortExpression="[TinhVuotDinhMuc]" />				
				<asp:BoundField DataField="TinhVuotTran" HeaderText="Tinh Vuot Tran" SortExpression="[TinhVuotTran]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Cong Thuc Tinh Quy Doi Found! </b>
				<asp:HyperLink runat="server" ID="hypCongThucTinhQuyDoi" NavigateUrl="~/admin/CongThucTinhQuyDoiEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:CongThucTinhQuyDoiDataSource ID="CongThucTinhQuyDoiDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:CongThucTinhQuyDoiProperty Name="LoaiCongThuc"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:CongThucTinhQuyDoiFilter  Column="MaLoaiCongThuc" QueryStringField="MaLoaiCongThuc" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:CongThucTinhQuyDoiDataSource>		
		
		<br />
		

</asp:Content>

