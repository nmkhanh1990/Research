<%@ Control Language="C#" ClassName="NhomGiangVienTinhDinhMucFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenNhomGiangVien" runat="server" Text="Ten Nhom Giang Vien:" AssociatedControlID="dataTenNhomGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenNhomGiangVien" Text='<%# Bind("TenNhomGiangVien") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaNhomGiangVien" runat="server" Text="Ma Nhom Giang Vien:" AssociatedControlID="dataMaNhomGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaNhomGiangVien" Text='<%# Bind("MaNhomGiangVien") %>' MaxLength="50"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaNhomGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaNhomGiangVien" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


