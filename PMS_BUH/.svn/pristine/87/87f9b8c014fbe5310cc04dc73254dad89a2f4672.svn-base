<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="DonGiaPhuCapEdit.aspx.cs" Inherits="DonGiaPhuCapEdit" Title="DonGiaPhuCap Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Don Gia Phu Cap - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="IdPhuCap" runat="server" DataSourceID="DonGiaPhuCapDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/DonGiaPhuCapFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/DonGiaPhuCapFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>DonGiaPhuCap not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:DonGiaPhuCapDataSource ID="DonGiaPhuCapDataSource" runat="server"
			SelectMethod="GetByIdPhuCap"
		>
			<Parameters>
				<asp:QueryStringParameter Name="IdPhuCap" QueryStringField="IdPhuCap" Type="String" />

			</Parameters>
		</data:DonGiaPhuCapDataSource>
		
		<br />

		

</asp:Content>

