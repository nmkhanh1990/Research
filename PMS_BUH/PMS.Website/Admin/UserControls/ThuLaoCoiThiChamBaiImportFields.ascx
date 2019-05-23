<%@ Control Language="C#" ClassName="ThuLaoCoiThiChamBaiImportFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonGiaQuaTrinh" runat="server" Text="Don Gia Qua Trinh:" AssociatedControlID="dataDonGiaQuaTrinh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGiaQuaTrinh" Text='<%# Bind("DonGiaQuaTrinh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDonGiaQuaTrinh" runat="server" Display="Dynamic" ControlToValidate="dataDonGiaQuaTrinh" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonGiaGiuaKy" runat="server" Text="Don Gia Giua Ky:" AssociatedControlID="dataDonGiaGiuaKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGiaGiuaKy" Text='<%# Bind("DonGiaGiuaKy") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDonGiaGiuaKy" runat="server" Display="Dynamic" ControlToValidate="dataDonGiaGiuaKy" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoBaiGiuaKy" runat="server" Text="So Bai Giua Ky:" AssociatedControlID="dataSoBaiGiuaKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoBaiGiuaKy" Text='<%# Bind("SoBaiGiuaKy") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoBaiGiuaKy" runat="server" Display="Dynamic" ControlToValidate="dataSoBaiGiuaKy" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoBaiCuoiKy" runat="server" Text="So Bai Cuoi Ky:" AssociatedControlID="dataSoBaiCuoiKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoBaiCuoiKy" Text='<%# Bind("SoBaiCuoiKy") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoBaiCuoiKy" runat="server" Display="Dynamic" ControlToValidate="dataSoBaiCuoiKy" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonGiaCuoiKy" runat="server" Text="Don Gia Cuoi Ky:" AssociatedControlID="dataDonGiaCuoiKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGiaCuoiKy" Text='<%# Bind("DonGiaCuoiKy") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDonGiaCuoiKy" runat="server" Display="Dynamic" ControlToValidate="dataDonGiaCuoiKy" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCapNhat" runat="server" Text="Ngay Cap Nhat:" AssociatedControlID="dataNgayCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCapNhat" Text='<%# Bind("NgayCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguoiCapNhat" runat="server" Text="Nguoi Cap Nhat:" AssociatedControlID="dataNguoiCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguoiCapNhat" Text='<%# Bind("NguoiCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThanhTien" runat="server" Text="Thanh Tien:" AssociatedControlID="dataThanhTien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThanhTien" Text='<%# Bind("ThanhTien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThanhTien" runat="server" Display="Dynamic" ControlToValidate="dataThanhTien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTienCoiThi" runat="server" Text="So Tien Coi Thi:" AssociatedControlID="dataSoTienCoiThi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTienCoiThi" Text='<%# Bind("SoTienCoiThi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTienCoiThi" runat="server" Display="Dynamic" ControlToValidate="dataSoTienCoiThi" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoBaiQuaTrinh" runat="server" Text="So Bai Qua Trinh:" AssociatedControlID="dataSoBaiQuaTrinh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoBaiQuaTrinh" Text='<%# Bind("SoBaiQuaTrinh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoBaiQuaTrinh" runat="server" Display="Dynamic" ControlToValidate="dataSoBaiQuaTrinh" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDotChiTra" runat="server" Text="Dot Chi Tra:" AssociatedControlID="dataDotChiTra" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDotChiTra" Text='<%# Bind("DotChiTra") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVienQuanLy" runat="server" Text="Ma Giang Vien Quan Ly:" AssociatedControlID="dataMaGiangVienQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVienQuanLy" Text='<%# Bind("MaGiangVienQuanLy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHoTen" runat="server" Text="Ho Ten:" AssociatedControlID="dataHoTen" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHoTen" Text='<%# Bind("HoTen") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenMonHoc" runat="server" Text="Ten Mon Hoc:" AssociatedControlID="dataTenMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenMonHoc" Text='<%# Bind("TenMonHoc") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLop" runat="server" Text="Ma Lop:" AssociatedControlID="dataMaLop" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLop" Text='<%# Bind("MaLop") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNoiDungChi" runat="server" Text="Noi Dung Chi:" AssociatedControlID="dataNoiDungChi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNoiDungChi" Text='<%# Bind("NoiDungChi") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaMonHoc" runat="server" Text="Ma Mon Hoc:" AssociatedControlID="dataMaMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaMonHoc" Text='<%# Bind("MaMonHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


