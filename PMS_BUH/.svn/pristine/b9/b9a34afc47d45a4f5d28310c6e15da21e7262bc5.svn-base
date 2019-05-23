<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="DotChiTraEdit.aspx.cs" Inherits="DotChiTraEdit" Title="DotChiTra Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Dot Chi Tra - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="Id" runat="server" DataSourceID="DotChiTraDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/DotChiTraFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/DotChiTraFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>DotChiTra not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:DotChiTraDataSource ID="DotChiTraDataSource" runat="server"
			SelectMethod="GetById"
		>
			<Parameters>
				<asp:QueryStringParameter Name="Id" QueryStringField="Id" Type="String" />

			</Parameters>
		</data:DotChiTraDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewTietNoKyTruoc1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewTietNoKyTruoc1_SelectedIndexChanged"			 			 
			DataSourceID="TietNoKyTruocDataSource1"
			DataKeyNames="Id"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_TietNoKyTruoc.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<asp:BoundField DataField="SoTietNoKyTruoc" HeaderText="So Tiet No Ky Truoc" SortExpression="[SoTietNoKyTruoc]" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]" />				
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]" />				
				<asp:BoundField DataField="TietNoKhac" HeaderText="Tiet No Khac" SortExpression="[TietNoKhac]" />				
				<asp:BoundField DataField="NamHocGoc" HeaderText="Nam Hoc Goc" SortExpression="[NamHocGoc]" />				
				<asp:BoundField DataField="TietNoNcKh" HeaderText="Tiet No Nc Kh" SortExpression="[TietNoNcKh]" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]" />				
				<asp:BoundField DataField="LayTuDong" HeaderText="Lay Tu Dong" SortExpression="[LayTuDong]" />				
				<data:HyperLinkField HeaderText="Dot Chi Tra" DataNavigateUrlFormatString="DotChiTraEdit.aspx?Id={0}" DataNavigateUrlFields="Id" DataContainer="DotChiTraSource" DataTextField="MaDotChiTra" />
			</Columns>
			<EmptyDataTemplate>
				<b>No Tiet No Ky Truoc Found! </b>
				<asp:HyperLink runat="server" ID="hypTietNoKyTruoc" NavigateUrl="~/admin/TietNoKyTruocEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:TietNoKyTruocDataSource ID="TietNoKyTruocDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:TietNoKyTruocProperty Name="GiangVien"/> 
					<data:TietNoKyTruocProperty Name="DotChiTra"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:TietNoKyTruocFilter  Column="DotChiTra" QueryStringField="Id" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:TietNoKyTruocDataSource>		
		
		<br />
		

</asp:Content>

