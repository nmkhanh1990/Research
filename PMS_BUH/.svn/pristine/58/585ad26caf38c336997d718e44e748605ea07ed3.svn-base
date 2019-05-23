<%@ Control Language="C#" ClassName="LoaiLopFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHoatDong" runat="server" Text="Ma Hoat Dong:" AssociatedControlID="dataMaHoatDong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHoatDong" Text='<%# Bind("MaHoatDong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaHoatDong" runat="server" Display="Dynamic" ControlToValidate="dataMaHoatDong" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTinhTrangHoatDong" runat="server" Text="Tinh Trang Hoat Dong:" AssociatedControlID="dataTinhTrangHoatDong" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataTinhTrangHoatDong" SelectedValue='<%# Bind("TinhTrangHoatDong") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaQuanLy" runat="server" Text="Ma Quan Ly:" AssociatedControlID="dataMaQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaQuanLy" Text='<%# Bind("MaQuanLy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenLoaiLop" runat="server" Text="Ten Loai Lop:" AssociatedControlID="dataTenLoaiLop" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenLoaiLop" Text='<%# Bind("TenLoaiLop") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


