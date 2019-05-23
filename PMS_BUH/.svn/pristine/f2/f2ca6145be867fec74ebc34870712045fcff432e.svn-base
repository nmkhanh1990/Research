<%@ Control Language="C#" ClassName="LoaiToanHangFields" %>

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
        <td class="literal"><asp:Label ID="lbldataMaLoaiToanHang" runat="server" Text="Ma Loai Toan Hang:" AssociatedControlID="dataMaLoaiToanHang" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLoaiToanHang" Text='<%# Bind("MaLoaiToanHang") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaLoaiToanHang" runat="server" Display="Dynamic" ControlToValidate="dataMaLoaiToanHang" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenLoaiToanHang" runat="server" Text="Ten Loai Toan Hang:" AssociatedControlID="dataTenLoaiToanHang" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenLoaiToanHang" Text='<%# Bind("TenLoaiToanHang") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


