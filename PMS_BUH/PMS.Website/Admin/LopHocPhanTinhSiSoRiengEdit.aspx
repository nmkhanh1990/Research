﻿<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="LopHocPhanTinhSiSoRiengEdit.aspx.cs" Inherits="LopHocPhanTinhSiSoRiengEdit" Title="LopHocPhanTinhSiSoRieng Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Lop Hoc Phan Tinh Si So Rieng - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaLopHocPhan" runat="server" DataSourceID="LopHocPhanTinhSiSoRiengDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/LopHocPhanTinhSiSoRiengFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/LopHocPhanTinhSiSoRiengFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>LopHocPhanTinhSiSoRieng not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:LopHocPhanTinhSiSoRiengDataSource ID="LopHocPhanTinhSiSoRiengDataSource" runat="server"
			SelectMethod="GetByMaLopHocPhan"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaLopHocPhan" QueryStringField="MaLopHocPhan" Type="String" />

			</Parameters>
		</data:LopHocPhanTinhSiSoRiengDataSource>
		
		<br />

		

</asp:Content>

