<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="HeSoQuyDoiThucHanhSangLyThuyetEdit.aspx.cs" Inherits="HeSoQuyDoiThucHanhSangLyThuyetEdit" Title="HeSoQuyDoiThucHanhSangLyThuyet Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">He So Quy Doi Thuc Hanh Sang Ly Thuyet - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="NamHoc, HocKy" runat="server" DataSourceID="HeSoQuyDoiThucHanhSangLyThuyetDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/HeSoQuyDoiThucHanhSangLyThuyetFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/HeSoQuyDoiThucHanhSangLyThuyetFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>HeSoQuyDoiThucHanhSangLyThuyet not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:HeSoQuyDoiThucHanhSangLyThuyetDataSource ID="HeSoQuyDoiThucHanhSangLyThuyetDataSource" runat="server"
			SelectMethod="GetByNamHocHocKy"
		>
			<Parameters>
				<asp:QueryStringParameter Name="NamHoc" QueryStringField="NamHoc" Type="String" />
<asp:QueryStringParameter Name="HocKy" QueryStringField="HocKy" Type="String" />

			</Parameters>
		</data:HeSoQuyDoiThucHanhSangLyThuyetDataSource>
		
		<br />


</asp:Content>

