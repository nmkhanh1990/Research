<%@ Control Language="C#" ClassName="LoaiCongThucFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenLoaiCongThuc" runat="server" Text="Ten Loai Cong Thuc:" AssociatedControlID="dataTenLoaiCongThuc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenLoaiCongThuc" Text='<%# Bind("TenLoaiCongThuc") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLoaiCongThuc" runat="server" Text="Ma Loai Cong Thuc:" AssociatedControlID="dataMaLoaiCongThuc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLoaiCongThuc" Text='<%# Bind("MaLoaiCongThuc") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaLoaiCongThuc" runat="server" Display="Dynamic" ControlToValidate="dataMaLoaiCongThuc" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


