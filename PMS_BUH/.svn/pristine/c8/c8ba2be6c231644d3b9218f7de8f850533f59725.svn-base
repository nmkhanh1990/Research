<%@ Control Language="C#" ClassName="LoaiThamSoFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenBang" runat="server" Text="Ten Bang:" AssociatedControlID="dataTenBang" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenBang" Text='<%# Bind("TenBang") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLoaiThamSo" runat="server" Text="Ma Loai Tham So:" AssociatedControlID="dataMaLoaiThamSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLoaiThamSo" Text='<%# Bind("MaLoaiThamSo") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaLoaiThamSo" runat="server" Display="Dynamic" ControlToValidate="dataMaLoaiThamSo" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenLoaiThamSo" runat="server" Text="Ten Loai Tham So:" AssociatedControlID="dataTenLoaiThamSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenLoaiThamSo" Text='<%# Bind("TenLoaiThamSo") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


