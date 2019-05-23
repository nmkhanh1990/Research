<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="LoaiHoatDongQuanLyEdit.aspx.cs" Inherits="LoaiHoatDongQuanLyEdit" Title="LoaiHoatDongQuanLy Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Loai Hoat Dong Quan Ly - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="Id" runat="server" DataSourceID="LoaiHoatDongQuanLyDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/LoaiHoatDongQuanLyFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/LoaiHoatDongQuanLyFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>LoaiHoatDongQuanLy not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:LoaiHoatDongQuanLyDataSource ID="LoaiHoatDongQuanLyDataSource" runat="server"
			SelectMethod="GetById"
		>
			<Parameters>
				<asp:QueryStringParameter Name="Id" QueryStringField="Id" Type="String" />

			</Parameters>
		</data:LoaiHoatDongQuanLyDataSource>
		
		<br />

		

</asp:Content>

