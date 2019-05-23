<%@ Control Language="C#" ClassName="LoaiThucHienFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataTrangThaiDung" runat="server" Text="Trang Thai Dung:" AssociatedControlID="dataTrangThaiDung" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataTrangThaiDung" SelectedValue='<%# Bind("TrangThaiDung") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguoiThucHien" runat="server" Text="Nguoi Thuc Hien:" AssociatedControlID="dataNguoiThucHien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguoiThucHien" Text='<%# Bind("NguoiThucHien") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenLoaiThucHien" runat="server" Text="Ten Loai Thuc Hien:" AssociatedControlID="dataTenLoaiThucHien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenLoaiThucHien" Text='<%# Bind("TenLoaiThucHien") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayThucHien" runat="server" Text="Ngay Thuc Hien:" AssociatedControlID="dataNgayThucHien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayThucHien" Text='<%# Bind("NgayThucHien", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayThucHien" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


