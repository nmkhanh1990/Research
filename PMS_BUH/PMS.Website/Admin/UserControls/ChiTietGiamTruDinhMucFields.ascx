<%@ Control Language="C#" ClassName="ChiTietGiamTruDinhMucFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataDinhMucNckh" runat="server" Text="Dinh Muc Nckh:" AssociatedControlID="dataDinhMucNckh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDinhMucNckh" Text='<%# Bind("DinhMucNckh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDinhMucNckh" runat="server" Display="Dynamic" ControlToValidate="dataDinhMucNckh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDinhMucHoatDongKhac" runat="server" Text="Dinh Muc Hoat Dong Khac:" AssociatedControlID="dataDinhMucHoatDongKhac" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDinhMucHoatDongKhac" Text='<%# Bind("DinhMucHoatDongKhac") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDinhMucHoatDongKhac" runat="server" Display="Dynamic" ControlToValidate="dataDinhMucHoatDongKhac" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDinhMucGiangDay" runat="server" Text="Dinh Muc Giang Day:" AssociatedControlID="dataDinhMucGiangDay" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDinhMucGiangDay" Text='<%# Bind("DinhMucGiangDay") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDinhMucGiangDay" runat="server" Display="Dynamic" ControlToValidate="dataDinhMucGiangDay" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiamTruDinhMuc" runat="server" Text="Ma Giam Tru Dinh Muc:" AssociatedControlID="dataMaGiamTruDinhMuc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiamTruDinhMuc" Text='<%# Bind("MaGiamTruDinhMuc") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaGiamTruDinhMuc" runat="server" Display="Dynamic" ControlToValidate="dataMaGiamTruDinhMuc" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaNhomGiangVien" runat="server" Text="Ma Nhom Giang Vien:" AssociatedControlID="dataMaNhomGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaNhomGiangVien" Text='<%# Bind("MaNhomGiangVien") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


