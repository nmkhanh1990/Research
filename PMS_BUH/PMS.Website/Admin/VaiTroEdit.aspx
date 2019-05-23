﻿<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="VaiTroEdit.aspx.cs" Inherits="VaiTroEdit" Title="VaiTro Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Vai Tro - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="Id" runat="server" DataSourceID="VaiTroDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/VaiTroFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/VaiTroFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>VaiTro not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:VaiTroDataSource ID="VaiTroDataSource" runat="server"
			SelectMethod="GetById"
		>
			<Parameters>
				<asp:QueryStringParameter Name="Id" QueryStringField="Id" Type="String" />

			</Parameters>
		</data:VaiTroDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewGiangVienNghienCuuKh1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewGiangVienNghienCuuKh1_SelectedIndexChanged"			 			 
			DataSourceID="GiangVienNghienCuuKhDataSource1"
			DataKeyNames="Id"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_GiangVienNghienCuuKh.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<data:HyperLinkField HeaderText="Ma Nckh" DataNavigateUrlFormatString="DanhMucNghienCuuKhoaHocEdit.aspx?Id={0}" DataNavigateUrlFields="Id" DataContainer="MaNckhSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="NgayHieuLuc" HeaderText="Ngay Hieu Luc" SortExpression="[NgayHieuLuc]" />				
				<asp:BoundField DataField="TrangThai" HeaderText="Trang Thai" SortExpression="[TrangThai]" />				
				<asp:BoundField DataField="NgayHetHieuLuc" HeaderText="Ngay Het Hieu Luc" SortExpression="[NgayHetHieuLuc]" />				
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]" />				
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]" />				
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]" />				
				<asp:BoundField DataField="TenNckh" HeaderText="Ten Nckh" SortExpression="[TenNckh]" />				
				<asp:BoundField DataField="GioGiangChuyenSangNckh" HeaderText="Gio Giang Chuyen Sang Nckh" SortExpression="[GioGiangChuyenSangNckh]" />				
				<asp:BoundField DataField="NgayNhap" HeaderText="Ngay Nhap" SortExpression="[NgayNhap]" />				
				<asp:BoundField DataField="SoLuongThanhVien" HeaderText="So Luong Thanh Vien" SortExpression="[SoLuongThanhVien]" />				
				<data:HyperLinkField HeaderText="Ma Vai Tro" DataNavigateUrlFormatString="VaiTroEdit.aspx?Id={0}" DataNavigateUrlFields="Id" DataContainer="MaVaiTroSource" DataTextField="MaVaiTro" />
				<asp:BoundField DataField="DuKien" HeaderText="Du Kien" SortExpression="[DuKien]" />				
				<asp:BoundField DataField="XacNhan" HeaderText="Xac Nhan" SortExpression="[XacNhan]" />				
				<asp:BoundField DataField="NgayXacNhan" HeaderText="Ngay Xac Nhan" SortExpression="[NgayXacNhan]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Giang Vien Nghien Cuu Kh Found! </b>
				<asp:HyperLink runat="server" ID="hypGiangVienNghienCuuKh" NavigateUrl="~/admin/GiangVienNghienCuuKhEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:GiangVienNghienCuuKhDataSource ID="GiangVienNghienCuuKhDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:GiangVienNghienCuuKhProperty Name="DanhMucNghienCuuKhoaHoc"/> 
					<data:GiangVienNghienCuuKhProperty Name="GiangVien"/> 
					<data:GiangVienNghienCuuKhProperty Name="VaiTro"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:GiangVienNghienCuuKhFilter  Column="MaVaiTro" QueryStringField="Id" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:GiangVienNghienCuuKhDataSource>		
		
		<br />
		

</asp:Content>

