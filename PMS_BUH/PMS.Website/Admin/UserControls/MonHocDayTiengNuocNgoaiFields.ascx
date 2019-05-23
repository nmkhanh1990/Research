<%@ Control Language="C#" ClassName="MonHocDayTiengNuocNgoaiFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguoiCapNhat" runat="server" Text="Nguoi Cap Nhat:" AssociatedControlID="dataNguoiCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguoiCapNhat" Text='<%# Bind("NguoiCapNhat", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNguoiCapNhat" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCapNhat" runat="server" Text="Ngay Cap Nhat:" AssociatedControlID="dataNgayCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCapNhat" Text='<%# Bind("NgayCapNhat", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayCapNhat" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaNgonNgu" runat="server" Text="Ma Ngon Ngu:" AssociatedControlID="dataMaNgonNgu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaNgonNgu" Text='<%# Bind("MaNgonNgu") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenMonHoc" runat="server" Text="Ten Mon Hoc:" AssociatedControlID="dataTenMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenMonHoc" Text='<%# Bind("TenMonHoc") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaMonHoc" runat="server" Text="Ma Mon Hoc:" AssociatedControlID="dataMaMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaMonHoc" Text='<%# Bind("MaMonHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoMonHoc" runat="server" Text="He So Mon Hoc:" AssociatedControlID="dataHeSoMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoMonHoc" Text='<%# Bind("HeSoMonHoc") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoMonHoc" runat="server" Display="Dynamic" ControlToValidate="dataHeSoMonHoc" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTrangThai" runat="server" Text="Trang Thai:" AssociatedControlID="dataTrangThai" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataTrangThai" SelectedValue='<%# Bind("TrangThai") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


