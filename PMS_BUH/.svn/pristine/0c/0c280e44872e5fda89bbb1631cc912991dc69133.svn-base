<%@ Control Language="C#" ClassName="KhoaBoMonFields" %>

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
        <td class="literal"><asp:Label ID="lbldataMaBoMon" runat="server" Text="Ma Bo Mon:" AssociatedControlID="dataMaBoMon" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaBoMon" Text='<%# Bind("MaBoMon") %>'></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaBoMon" runat="server" Display="Dynamic" ControlToValidate="dataMaBoMon" ErrorMessage="Required"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeVal_dataMaBoMon" runat="server" Display="Dynamic" ControlToValidate="dataMaBoMon" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


