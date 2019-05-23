<%@ Control Language="C#" ClassName="GiangVienCamKetKhongTruThueFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataThueTncn" runat="server" Text="Thue Tncn:" AssociatedControlID="dataThueTncn" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThueTncn" Text='<%# Bind("ThueTncn") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThueTncn" runat="server" Display="Dynamic" ControlToValidate="dataThueTncn" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguoiCapNhat" runat="server" Text="Nguoi Cap Nhat:" AssociatedControlID="dataNguoiCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguoiCapNhat" Text='<%# Bind("NguoiCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataXacNhanThue" runat="server" Text="Xac Nhan Thue:" AssociatedControlID="dataXacNhanThue" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataXacNhanThue" SelectedValue='<%# Bind("XacNhanThue") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHoatDong" runat="server" Text="Ma Hoat Dong:" AssociatedControlID="dataMaHoatDong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHoatDong" Text='<%# Bind("MaHoatDong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaHoatDong" runat="server" Display="Dynamic" ControlToValidate="dataMaHoatDong" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataXacNhanKhongThue" runat="server" Text="Xac Nhan Khong Thue:" AssociatedControlID="dataXacNhanKhongThue" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataXacNhanKhongThue" SelectedValue='<%# Bind("XacNhanKhongThue") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataNamHoc" runat="server" Display="Dynamic" ControlToValidate="dataNamHoc" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaGiangVien" DataSourceID="MaGiangVienGiangVienDataSource" DataTextField="MaDanToc" DataValueField="MaGiangVien" SelectedValue='<%# Bind("MaGiangVien") %>' AppendNullItem="true" Required="true" NullItemText="< Please Choose ...>" ErrorText="Required" />
					<data:GiangVienDataSource ID="MaGiangVienGiangVienDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataHocKy" runat="server" Display="Dynamic" ControlToValidate="dataHocKy" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCapNhat" runat="server" Text="Ngay Cap Nhat:" AssociatedControlID="dataNgayCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCapNhat" Text='<%# Bind("NgayCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


