<%@ Control Language="C#" ClassName="QuyCheFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNoiDung" runat="server" Text="Noi Dung:" AssociatedControlID="dataNoiDung" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNoiDung" Text='<%# Bind("NoiDung") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaQuyChe" runat="server" Text="Ma Quy Che:" AssociatedControlID="dataMaQuyChe" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaQuyChe" Text='<%# Bind("MaQuyChe") %>' MaxLength="50"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaQuyChe" runat="server" Display="Dynamic" ControlToValidate="dataMaQuyChe" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenQuyChe" runat="server" Text="Ten Quy Che:" AssociatedControlID="dataTenQuyChe" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenQuyChe" Text='<%# Bind("TenQuyChe") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


