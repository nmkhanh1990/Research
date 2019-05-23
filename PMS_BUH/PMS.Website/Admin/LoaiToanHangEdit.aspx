<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="LoaiToanHangEdit.aspx.cs" Inherits="LoaiToanHangEdit" Title="LoaiToanHang Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Loai Toan Hang - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaLoaiToanHang" runat="server" DataSourceID="LoaiToanHangDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/LoaiToanHangFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/LoaiToanHangFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>LoaiToanHang not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:LoaiToanHangDataSource ID="LoaiToanHangDataSource" runat="server"
			SelectMethod="GetByMaLoaiToanHang"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaLoaiToanHang" QueryStringField="MaLoaiToanHang" Type="String" />

			</Parameters>
		</data:LoaiToanHangDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewCongThucTinhGiaTriToanHang1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewCongThucTinhGiaTriToanHang1_SelectedIndexChanged"			 			 
			DataSourceID="CongThucTinhGiaTriToanHangDataSource1"
			DataKeyNames="MaCongThuc"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_CongThucTinhGiaTriToanHang.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Loai Toan Hang" DataNavigateUrlFormatString="LoaiToanHangEdit.aspx?MaLoaiToanHang={0}" DataNavigateUrlFields="MaLoaiToanHang" DataContainer="MaLoaiToanHangSource" DataTextField="TenLoaiToanHang" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<asp:BoundField DataField="ApDung" HeaderText="Ap Dung" SortExpression="[ApDung]" />				
				<asp:BoundField DataField="DienGiai" HeaderText="Dien Giai" SortExpression="[DienGiai]" />				
				<asp:BoundField DataField="TenHamThucHien" HeaderText="Ten Ham Thuc Hien" SortExpression="[TenHamThucHien]" />				
				<asp:BoundField DataField="ThamSoDauVao" HeaderText="Tham So Dau Vao" SortExpression="[ThamSoDauVao]" />				
				<asp:BoundField DataField="CotLayGiaTri" HeaderText="Cot Lay Gia Tri" SortExpression="[CotLayGiaTri]" />				
				<asp:BoundField DataField="GiaTriMacDinh" HeaderText="Gia Tri Mac Dinh" SortExpression="[GiaTriMacDinh]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Cong Thuc Tinh Gia Tri Toan Hang Found! </b>
				<asp:HyperLink runat="server" ID="hypCongThucTinhGiaTriToanHang" NavigateUrl="~/admin/CongThucTinhGiaTriToanHangEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:CongThucTinhGiaTriToanHangDataSource ID="CongThucTinhGiaTriToanHangDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:CongThucTinhGiaTriToanHangProperty Name="LoaiToanHang"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:CongThucTinhGiaTriToanHangFilter  Column="MaLoaiToanHang" QueryStringField="MaLoaiToanHang" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:CongThucTinhGiaTriToanHangDataSource>		
		
		<br />
		

</asp:Content>

