<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reken.aspx.cs" Inherits="Rekenmachine_Hoofdstuk5.Reken" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:Label ID="lblGetal1" runat="server" Text="Getal 1"></asp:Label>
        <asp:TextBox ID="txtGetal1" runat="server" OnTextChanged="txtGetal1_TextChanged" style="margin-left: 63px;"></asp:TextBox>*
        <asp:RequiredFieldValidator ID="rfvGetal1" runat="server" ControlToValidate="txtGetal1" ErrorMessage="Vul getal 1 in!" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="rvGetal1" runat="server" ControlToValidate="txtGetal1" ErrorMessage="Tussen de 1 en 100" MaximumValue="100" MinimumValue="1" Display="Dynamic" Type="Double"></asp:RangeValidator>
        <asp:Button ID="btnOptel" runat="server" Text="Optellen" OnClick="btnOptel_Click" />
        <br />
        <br />
        <asp:Label ID="lblGetal2" runat="server" Text="Getal 2"></asp:Label>
        <asp:TextBox ID="txtGetal2" runat="server" style="margin-left: 63px;"></asp:TextBox>*
        <asp:RequiredFieldValidator ID="rfvGetal2" runat="server" ControlToValidate="txtGetal2" ErrorMessage="Vul getal 2 in!" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtGetal2" ErrorMessage="Tussen de 1 en 100" MaximumValue="100" MinimumValue="1" Display="Dynamic" Type="Double"></asp:RangeValidator>
        <asp:Button ID="btnAftrek" runat="server" Text="Aftrekken" OnClick="btnAftrek_Click" />
        <br />
        <br />
        <asp:Label ID="lblUitkomst" runat="server" Text="Uitkomst"></asp:Label>
        <asp:TextBox ID="txtUitkomst" runat="server" ReadOnly="True" style="margin-left: 50px;"></asp:TextBox>
        <br />
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtGetal1" ControlToValidate="txtGetal2" Display="Dynamic" ErrorMessage="Vul dezelfde getallen in!" ForeColor="Red"></asp:CompareValidator>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Telefoonnummer"></asp:Label>
        <asp:TextBox ID="txtTelefoon" runat="server"></asp:TextBox>
        <br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtTelefoon" Display="Dynamic" ErrorMessage="Vul een geldig nummer in! Zoals: 074 2780013 of 0742780013" ValidationExpression="(((\d{3}) (\d{7}))|(\d{10}))" ForeColor="Red"></asp:RegularExpressionValidator>

    </form>
</body>
</html>
