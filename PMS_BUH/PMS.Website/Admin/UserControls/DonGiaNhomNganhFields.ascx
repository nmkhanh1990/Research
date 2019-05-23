<%@ Control Language="C#" ClassName="DonGiaNhomNganhFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTinhTrang" runat="server" Text="Tinh Trang:" AssociatedControlID="dataTinhTrang" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataTinhTrang" SelectedValue='<%# Bind("TinhTrang") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGiaTri" runat="server" Text="Gia Tri:" AssociatedControlID="dataGiaTri" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGiaTri" Text='<%# Bind("GiaTri") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataGiaTri" runat="server" Display="Dynamic" ControlToValidate="dataGiaTri" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaQuanLy" runat="server" Text="Ma Quan Ly:" AssociatedControlID="dataMaQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaQuanLy" Text='<%# Bind("MaQuanLy") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaTenNhomNganh" runat="server" Text="Ma Ten Nhom Nganh:" AssociatedControlID="dataMaTenNhomNganh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaTenNhomNganh" Text='<%# Bind("MaTenNhomNganh") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


