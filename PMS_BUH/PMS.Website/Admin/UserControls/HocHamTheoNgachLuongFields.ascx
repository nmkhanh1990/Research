<%@ Control Language="C#" ClassName="HocHamTheoNgachLuongFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayHieuLuc" runat="server" Text="Ngay Hieu Luc:" AssociatedControlID="dataNgayHieuLuc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayHieuLuc" Text='<%# Bind("NgayHieuLuc", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayHieuLuc" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocHam" runat="server" Text="Ma Hoc Ham:" AssociatedControlID="dataMaHocHam" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHocHam" Text='<%# Bind("MaHocHam") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaHocHam" runat="server" Display="Dynamic" ControlToValidate="dataMaHocHam" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaNgachLuong" runat="server" Text="Ma Ngach Luong:" AssociatedControlID="dataMaNgachLuong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaNgachLuong" Text='<%# Bind("MaNgachLuong") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


