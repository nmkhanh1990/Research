<%@ Control Language="C#" ClassName="PhanNhomMonHocTinhDinhMucFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaMonHoc" runat="server" Text="Ma Mon Hoc:" AssociatedControlID="dataMaMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaMonHoc" Text='<%# Bind("MaMonHoc") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaNhomMon" runat="server" Text="Ma Nhom Mon:" AssociatedControlID="dataMaNhomMon" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaNhomMon" Text='<%# Bind("MaNhomMon") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


