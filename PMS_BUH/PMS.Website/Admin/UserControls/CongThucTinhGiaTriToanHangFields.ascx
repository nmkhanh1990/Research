<%@ Control Language="C#" ClassName="CongThucTinhGiaTriToanHangFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataThamSoDauVao" runat="server" Text="Tham So Dau Vao:" AssociatedControlID="dataThamSoDauVao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThamSoDauVao" Text='<%# Bind("ThamSoDauVao") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenHamThucHien" runat="server" Text="Ten Ham Thuc Hien:" AssociatedControlID="dataTenHamThucHien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenHamThucHien" Text='<%# Bind("TenHamThucHien") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGiaTriMacDinh" runat="server" Text="Gia Tri Mac Dinh:" AssociatedControlID="dataGiaTriMacDinh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGiaTriMacDinh" Text='<%# Bind("GiaTriMacDinh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataGiaTriMacDinh" runat="server" Display="Dynamic" ControlToValidate="dataGiaTriMacDinh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataCotLayGiaTri" runat="server" Text="Cot Lay Gia Tri:" AssociatedControlID="dataCotLayGiaTri" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataCotLayGiaTri" Text='<%# Bind("CotLayGiaTri") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDienGiai" runat="server" Text="Dien Giai:" AssociatedControlID="dataDienGiai" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDienGiai" Text='<%# Bind("DienGiai") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLoaiToanHang" runat="server" Text="Ma Loai Toan Hang:" AssociatedControlID="dataMaLoaiToanHang" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaLoaiToanHang" DataSourceID="MaLoaiToanHangLoaiToanHangDataSource" DataTextField="TenLoaiToanHang" DataValueField="MaLoaiToanHang" SelectedValue='<%# Bind("MaLoaiToanHang") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:LoaiToanHangDataSource ID="MaLoaiToanHangLoaiToanHangDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataApDung" runat="server" Text="Ap Dung:" AssociatedControlID="dataApDung" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataApDung" SelectedValue='<%# Bind("ApDung") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


