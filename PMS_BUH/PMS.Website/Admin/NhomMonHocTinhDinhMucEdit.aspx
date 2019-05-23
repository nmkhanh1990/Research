<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="NhomMonHocTinhDinhMucEdit.aspx.cs" Inherits="NhomMonHocTinhDinhMucEdit" Title="NhomMonHocTinhDinhMuc Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Nhom Mon Hoc Tinh Dinh Muc - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaNhomMon" runat="server" DataSourceID="NhomMonHocTinhDinhMucDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/NhomMonHocTinhDinhMucFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/NhomMonHocTinhDinhMucFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>NhomMonHocTinhDinhMuc not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:NhomMonHocTinhDinhMucDataSource ID="NhomMonHocTinhDinhMucDataSource" runat="server"
			SelectMethod="GetByMaNhomMon"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaNhomMon" QueryStringField="MaNhomMon" Type="String" />

			</Parameters>
		</data:NhomMonHocTinhDinhMucDataSource>
		
		<br />

		

</asp:Content>

