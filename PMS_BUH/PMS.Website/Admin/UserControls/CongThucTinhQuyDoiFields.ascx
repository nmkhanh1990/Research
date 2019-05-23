<%@ Control Language="C#" ClassName="CongThucTinhQuyDoiFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataDienGiai" runat="server" Text="Dien Giai:" AssociatedControlID="dataDienGiai" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDienGiai" Text='<%# Bind("DienGiai") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataApDung" runat="server" Text="Ap Dung:" AssociatedControlID="dataApDung" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataApDung" SelectedValue='<%# Bind("ApDung") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTinhVuotTran" runat="server" Text="Tinh Vuot Tran:" AssociatedControlID="dataTinhVuotTran" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataTinhVuotTran" SelectedValue='<%# Bind("TinhVuotTran") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTinhVuotDinhMuc" runat="server" Text="Tinh Vuot Dinh Muc:" AssociatedControlID="dataTinhVuotDinhMuc" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataTinhVuotDinhMuc" SelectedValue='<%# Bind("TinhVuotDinhMuc") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataToanHangSuDung" runat="server" Text="Toan Hang Su Dung:" AssociatedControlID="dataToanHangSuDung" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataToanHangSuDung" Text='<%# Bind("ToanHangSuDung") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataToanHangSuDung" runat="server" Display="Dynamic" ControlToValidate="dataToanHangSuDung" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLoaiCongThuc" runat="server" Text="Ma Loai Cong Thuc:" AssociatedControlID="dataMaLoaiCongThuc" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaLoaiCongThuc" DataSourceID="MaLoaiCongThucLoaiCongThucDataSource" DataTextField="TenLoaiCongThuc" DataValueField="MaLoaiCongThuc" SelectedValue='<%# Bind("MaLoaiCongThuc") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:LoaiCongThucDataSource ID="MaLoaiCongThucLoaiCongThucDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataCongThuc" runat="server" Text="Cong Thuc:" AssociatedControlID="dataCongThuc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataCongThuc" Text='<%# Bind("CongThuc") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataCongThuc" runat="server" Display="Dynamic" ControlToValidate="dataCongThuc" ErrorMessage="Required"></asp:RequiredFieldValidator>
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


