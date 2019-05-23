<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="GiangVienThayDoiBacLuongEdit.aspx.cs" Inherits="GiangVienThayDoiBacLuongEdit" Title="GiangVienThayDoiBacLuong Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Giang Vien Thay Doi Bac Luong - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaQuanLy" runat="server" DataSourceID="GiangVienThayDoiBacLuongDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/GiangVienThayDoiBacLuongFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/GiangVienThayDoiBacLuongFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>GiangVienThayDoiBacLuong not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:GiangVienThayDoiBacLuongDataSource ID="GiangVienThayDoiBacLuongDataSource" runat="server"
			SelectMethod="GetByMaQuanLy"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaQuanLy" QueryStringField="MaQuanLy" Type="String" />

			</Parameters>
		</data:GiangVienThayDoiBacLuongDataSource>
		
		<br />

		

</asp:Content>

