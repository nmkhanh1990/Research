<%@ Control Language="C#" ClassName="NhomMonHocTinhDinhMucFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenNhomMon" runat="server" Text="Ten Nhom Mon:" AssociatedControlID="dataTenNhomMon" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenNhomMon" Text='<%# Bind("TenNhomMon") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaNhomMon" runat="server" Text="Ma Nhom Mon:" AssociatedControlID="dataMaNhomMon" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaNhomMon" Text='<%# Bind("MaNhomMon") %>' MaxLength="50"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaNhomMon" runat="server" Display="Dynamic" ControlToValidate="dataMaNhomMon" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


