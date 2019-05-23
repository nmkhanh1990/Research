<%@ Control Language="C#" ClassName="DanhMucHoatDongQuanLyFields" %>

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
        <td class="literal"><asp:Label ID="lbldataTenHoatDong" runat="server" Text="Ten Hoat Dong:" AssociatedControlID="dataTenHoatDong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenHoatDong" Text='<%# Bind("TenHoatDong") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHoatDong" runat="server" Text="Ma Hoat Dong:" AssociatedControlID="dataMaHoatDong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHoatDong" Text='<%# Bind("MaHoatDong") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


