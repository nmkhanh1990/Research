<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="NhomGiangVienTinhDinhMucEdit.aspx.cs" Inherits="NhomGiangVienTinhDinhMucEdit" Title="NhomGiangVienTinhDinhMuc Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Nhom Giang Vien Tinh Dinh Muc - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaNhomGiangVien" runat="server" DataSourceID="NhomGiangVienTinhDinhMucDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/NhomGiangVienTinhDinhMucFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/NhomGiangVienTinhDinhMucFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>NhomGiangVienTinhDinhMuc not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:NhomGiangVienTinhDinhMucDataSource ID="NhomGiangVienTinhDinhMucDataSource" runat="server"
			SelectMethod="GetByMaNhomGiangVien"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaNhomGiangVien" QueryStringField="MaNhomGiangVien" Type="String" />

			</Parameters>
		</data:NhomGiangVienTinhDinhMucDataSource>
		
		<br />

		

</asp:Content>

