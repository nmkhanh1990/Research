<%@ Control Language="C#" ClassName="PhanNhomGiangVienTinhDinhMucFields" %>

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
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVien" Text='<%# Bind("MaGiangVien") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaNhomGiangVien" runat="server" Text="Ma Nhom Giang Vien:" AssociatedControlID="dataMaNhomGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaNhomGiangVien" Text='<%# Bind("MaNhomGiangVien") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


