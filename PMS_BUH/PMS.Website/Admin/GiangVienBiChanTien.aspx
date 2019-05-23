﻿<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="GiangVienBiChanTien.aspx.cs" Inherits="GiangVienBiChanTien" Title="GiangVienBiChanTien List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Giang Vien Bi Chan Tien List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="GiangVienBiChanTienDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_GiangVienBiChanTien.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="TietCanTren" HeaderText="Tiet Can Tren" SortExpression="[TietCanTren]"  />
				<asp:BoundField DataField="TietXetVuot" HeaderText="Tiet Xet Vuot" SortExpression="[TietXetVuot]"  />
				<asp:BoundField DataField="ThanhTienSauChan" HeaderText="Thanh Tien Sau Chan" SortExpression="[ThanhTienSauChan]"  />
				<asp:BoundField DataField="ThanhTienVuot" HeaderText="Thanh Tien Vuot" SortExpression="[ThanhTienVuot]"  />
				<asp:BoundField DataField="TietThanhToan" HeaderText="Tiet Thanh Toan" SortExpression="[TietThanhToan]"  />
				<asp:BoundField DataField="TietVuotCanTren" HeaderText="Tiet Vuot Can Tren" SortExpression="[TietVuotCanTren]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="MaGiangVien" HeaderText="Ma Giang Vien" SortExpression="[MaGiangVien]"  />
				<asp:BoundField DataField="ThanhTienThanhToan" HeaderText="Thanh Tien Thanh Toan" SortExpression="[ThanhTienThanhToan]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<data:BoundRadioButtonField DataField="BiChan" HeaderText="Bi Chan" SortExpression="[BiChan]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No GiangVienBiChanTien Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnGiangVienBiChanTien" OnClientClick="javascript:location.href='GiangVienBiChanTienEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:GiangVienBiChanTienDataSource ID="GiangVienBiChanTienDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
		>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:GiangVienBiChanTienDataSource>
	    		
</asp:Content>


