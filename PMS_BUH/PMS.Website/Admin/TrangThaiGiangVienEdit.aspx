<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="TrangThaiGiangVienEdit.aspx.cs" Inherits="TrangThaiGiangVienEdit" Title="TrangThaiGiangVien Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Trang Thai Giang Vien - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaKhoa" runat="server" DataSourceID="TrangThaiGiangVienDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/TrangThaiGiangVienFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/TrangThaiGiangVienFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>TrangThaiGiangVien not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:TrangThaiGiangVienDataSource ID="TrangThaiGiangVienDataSource" runat="server"
			SelectMethod="GetByMaKhoa"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaKhoa" QueryStringField="MaKhoa" Type="String" />

			</Parameters>
		</data:TrangThaiGiangVienDataSource>
		
		<br />

		

</asp:Content>

