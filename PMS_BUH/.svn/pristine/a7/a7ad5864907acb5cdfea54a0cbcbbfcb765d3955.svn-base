<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="DonGiaNhomNganhEdit.aspx.cs" Inherits="DonGiaNhomNganhEdit" Title="DonGiaNhomNganh Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Don Gia Nhom Nganh - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaDonGiaNhomNganh" runat="server" DataSourceID="DonGiaNhomNganhDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/DonGiaNhomNganhFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/DonGiaNhomNganhFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>DonGiaNhomNganh not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:DonGiaNhomNganhDataSource ID="DonGiaNhomNganhDataSource" runat="server"
			SelectMethod="GetByMaDonGiaNhomNganh"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaDonGiaNhomNganh" QueryStringField="MaDonGiaNhomNganh" Type="String" />

			</Parameters>
		</data:DonGiaNhomNganhDataSource>
		
		<br />

		

</asp:Content>

