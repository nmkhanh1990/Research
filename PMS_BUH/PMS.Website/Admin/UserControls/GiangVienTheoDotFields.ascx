<%@ Control Language="C#" ClassName="GiangVienTheoDotFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataDotThanhToan" runat="server" Text="Dot Thanh Toan:" AssociatedControlID="dataDotThanhToan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDotThanhToan" Text='<%# Bind("DotThanhToan") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGiamTruDinhMuc" runat="server" Text="Giam Tru Dinh Muc:" AssociatedControlID="dataGiamTruDinhMuc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGiamTruDinhMuc" Text='<%# Bind("GiamTruDinhMuc") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataGiamTruDinhMuc" runat="server" Display="Dynamic" ControlToValidate="dataGiamTruDinhMuc" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
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
        <td class="literal"><asp:Label ID="lbldataStnckhThucHien" runat="server" Text="Stnckh Thuc Hien:" AssociatedControlID="dataStnckhThucHien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataStnckhThucHien" Text='<%# Bind("StnckhThucHien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataStnckhThucHien" runat="server" Display="Dynamic" ControlToValidate="dataStnckhThucHien" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVien" Text='<%# Bind("MaGiangVien") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDinhMuc" runat="server" Text="Dinh Muc:" AssociatedControlID="dataDinhMuc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDinhMuc" Text='<%# Bind("DinhMuc") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDinhMuc" runat="server" Display="Dynamic" ControlToValidate="dataDinhMuc" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataStnckhDuocTru" runat="server" Text="Stnckh Duoc Tru:" AssociatedControlID="dataStnckhDuocTru" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataStnckhDuocTru" Text='<%# Bind("StnckhDuocTru") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataStnckhDuocTru" runat="server" Display="Dynamic" ControlToValidate="dataStnckhDuocTru" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


