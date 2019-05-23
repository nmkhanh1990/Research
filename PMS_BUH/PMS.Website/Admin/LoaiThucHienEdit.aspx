<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="LoaiThucHienEdit.aspx.cs" Inherits="LoaiThucHienEdit" Title="LoaiThucHien Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Loai Thuc Hien - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaLoaiThucHien" runat="server" DataSourceID="LoaiThucHienDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/LoaiThucHienFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/LoaiThucHienFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>LoaiThucHien not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:LoaiThucHienDataSource ID="LoaiThucHienDataSource" runat="server"
			SelectMethod="GetByMaLoaiThucHien"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaLoaiThucHien" QueryStringField="MaLoaiThucHien" Type="String" />

			</Parameters>
		</data:LoaiThucHienDataSource>
		
		<br />

		

</asp:Content>

