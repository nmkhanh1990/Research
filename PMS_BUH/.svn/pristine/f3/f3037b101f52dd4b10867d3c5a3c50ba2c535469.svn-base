<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="LoaiThamSoEdit.aspx.cs" Inherits="LoaiThamSoEdit" Title="LoaiThamSo Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Loai Tham So - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaLoaiThamSo" runat="server" DataSourceID="LoaiThamSoDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/LoaiThamSoFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/LoaiThamSoFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>LoaiThamSo not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:LoaiThamSoDataSource ID="LoaiThamSoDataSource" runat="server"
			SelectMethod="GetByMaLoaiThamSo"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaLoaiThamSo" QueryStringField="MaLoaiThamSo" Type="String" />

			</Parameters>
		</data:LoaiThamSoDataSource>
		
		<br />

		

</asp:Content>

