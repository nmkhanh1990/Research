<%@ Control Language="C#" ClassName="GiangVienBiChanTienFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietCanTren" runat="server" Text="Tiet Can Tren:" AssociatedControlID="dataTietCanTren" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietCanTren" Text='<%# Bind("TietCanTren") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietCanTren" runat="server" Display="Dynamic" ControlToValidate="dataTietCanTren" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietXetVuot" runat="server" Text="Tiet Xet Vuot:" AssociatedControlID="dataTietXetVuot" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietXetVuot" Text='<%# Bind("TietXetVuot") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietXetVuot" runat="server" Display="Dynamic" ControlToValidate="dataTietXetVuot" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThanhTienSauChan" runat="server" Text="Thanh Tien Sau Chan:" AssociatedControlID="dataThanhTienSauChan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThanhTienSauChan" Text='<%# Bind("ThanhTienSauChan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThanhTienSauChan" runat="server" Display="Dynamic" ControlToValidate="dataThanhTienSauChan" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThanhTienVuot" runat="server" Text="Thanh Tien Vuot:" AssociatedControlID="dataThanhTienVuot" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThanhTienVuot" Text='<%# Bind("ThanhTienVuot") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThanhTienVuot" runat="server" Display="Dynamic" ControlToValidate="dataThanhTienVuot" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietThanhToan" runat="server" Text="Tiet Thanh Toan:" AssociatedControlID="dataTietThanhToan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietThanhToan" Text='<%# Bind("TietThanhToan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietThanhToan" runat="server" Display="Dynamic" ControlToValidate="dataTietThanhToan" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietVuotCanTren" runat="server" Text="Tiet Vuot Can Tren:" AssociatedControlID="dataTietVuotCanTren" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietVuotCanTren" Text='<%# Bind("TietVuotCanTren") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietVuotCanTren" runat="server" Display="Dynamic" ControlToValidate="dataTietVuotCanTren" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="10"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVien" Text='<%# Bind("MaGiangVien") %>'></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaGiangVien" ErrorMessage="Required"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeVal_dataMaGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaGiangVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThanhTienThanhToan" runat="server" Text="Thanh Tien Thanh Toan:" AssociatedControlID="dataThanhTienThanhToan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThanhTienThanhToan" Text='<%# Bind("ThanhTienThanhToan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThanhTienThanhToan" runat="server" Display="Dynamic" ControlToValidate="dataThanhTienThanhToan" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataBiChan" runat="server" Text="Bi Chan:" AssociatedControlID="dataBiChan" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataBiChan" SelectedValue='<%# Bind("BiChan") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


