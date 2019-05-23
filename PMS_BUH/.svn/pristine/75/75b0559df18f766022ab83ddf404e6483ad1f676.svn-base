<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="TieuDe.aspx.cs" Inherits="TieuDe" Title="TieuDe List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Tieu De List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="TieuDeDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_TieuDe.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="IdFormatField" HeaderText="Id Format Field" SortExpression="[IdFormatField]"  />
				<asp:BoundField DataField="IdAn" HeaderText="Id An" SortExpression="[IdAn]"  />
				<asp:BoundField DataField="IdFrom" HeaderText="Id From" SortExpression="[IDFrom]"  />
				<asp:BoundField DataField="IdReadOnlyField" HeaderText="Id Read Only Field" SortExpression="[IdReadOnlyField]"  />
				<asp:BoundField DataField="IdSummaryField" HeaderText="Id Summary Field" SortExpression="[IdSummaryField]"  />
				<asp:BoundField DataField="IdHideField" HeaderText="Id Hide Field" SortExpression="[IdHideField]"  />
				<data:BoundRadioButtonField DataField="TrangThai" HeaderText="Trang Thai" SortExpression="[TrangThai]"  />
				<asp:BoundField DataField="IdTitleEn" HeaderText="Id Title En" SortExpression="[IdTitleEN]"  />
				<asp:BoundField DataField="IdTitleVn" HeaderText="Id Title Vn" SortExpression="[IdTitleVN]"  />
				<asp:BoundField DataField="IdFileName" HeaderText="Id File Name" SortExpression="[IdFileName]"  />
				<asp:BoundField DataField="MaTruong" HeaderText="Ma Truong" SortExpression="[MaTruong]"  />
				<asp:BoundField DataField="Stt" HeaderText="Stt" SortExpression="[STT]"  />
				<asp:BoundField DataField="IdSize" HeaderText="Id Size" SortExpression="[IdSize]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No TieuDe Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnTieuDe" OnClientClick="javascript:location.href='TieuDeEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:TieuDeDataSource ID="TieuDeDataSource" runat="server"
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
		</data:TieuDeDataSource>
	    		
</asp:Content>



