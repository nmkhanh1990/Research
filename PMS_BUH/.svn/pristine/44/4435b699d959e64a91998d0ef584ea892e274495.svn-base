<%@ Control Language="C#" ClassName="LoaiHoatDongQuanLyFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataChuTriDeTaiHuong" runat="server" Text="Chu Tri De Tai Huong:" AssociatedControlID="dataChuTriDeTaiHuong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataChuTriDeTaiHuong" Text='<%# Bind("ChuTriDeTaiHuong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataChuTriDeTaiHuong" runat="server" Display="Dynamic" ControlToValidate="dataChuTriDeTaiHuong" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThanhVienHuong" runat="server" Text="Thanh Vien Huong:" AssociatedControlID="dataThanhVienHuong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThanhVienHuong" Text='<%# Bind("ThanhVienHuong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThanhVienHuong" runat="server" Display="Dynamic" ControlToValidate="dataThanhVienHuong" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonViHdql" runat="server" Text="Don Vi Hdql:" AssociatedControlID="dataDonViHdql" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonViHdql" Text='<%# Bind("DonViHdql") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLoaiHdql" runat="server" Text="Ma Loai Hdql:" AssociatedControlID="dataMaLoaiHdql" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLoaiHdql" Text='<%# Bind("MaLoaiHdql") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenLoaiNhdql" runat="server" Text="Ten Loai Nhdql:" AssociatedControlID="dataTenLoaiNhdql" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenLoaiNhdql" Text='<%# Bind("TenLoaiNhdql") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
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


