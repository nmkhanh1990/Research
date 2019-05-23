<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="CongThucTinhQuyDoiEdit.aspx.cs" Inherits="CongThucTinhQuyDoiEdit" Title="CongThucTinhQuyDoi Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Cong Thuc Tinh Quy Doi - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaCongThuc" runat="server" DataSourceID="CongThucTinhQuyDoiDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/CongThucTinhQuyDoiFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/CongThucTinhQuyDoiFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>CongThucTinhQuyDoi not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:CongThucTinhQuyDoiDataSource ID="CongThucTinhQuyDoiDataSource" runat="server"
			SelectMethod="GetByMaCongThuc"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaCongThuc" QueryStringField="MaCongThuc" Type="String" />

			</Parameters>
		</data:CongThucTinhQuyDoiDataSource>
		
		<br />

		

</asp:Content>

