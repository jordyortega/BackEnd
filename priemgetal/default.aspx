<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="priemgetal._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <b>Exercise 1</b><br />
    
        Number:
        <asp:TextBox ID="numberBox" runat="server"></asp:TextBox>
        <asp:Button ID="btnCheck" runat="server" OnClick="btnCheck_Click" Text="Check" />
        <asp:RangeValidator ID="RangeValidatorPrimeNumber" runat="server" ControlToValidate="numberBox" Display="Dynamic" ErrorMessage="The number should have a minimum value of 2" MaximumValue="2147483647" MinimumValue="2" Type="Integer"></asp:RangeValidator>
    
    </div>
        <br />
        <asp:Label ID="lblPriem" runat="server"></asp:Label>
        <br />
        <br />
        <b>Exercise 2</b><br />
        Maximum number: <asp:TextBox ID="maxNumberBox" runat="server"></asp:TextBox>
        <asp:Button ID="BtnCheckMax" runat="server" OnClick="BtnCheckMax_Click" Text="Check all" />
        <asp:RangeValidator ID="RangeValidatorPrimeMaxNumber" runat="server" ControlToValidate="maxNumberBox" Display="Dynamic" ErrorMessage="The number should have a minimum value of 2" MaximumValue="2147483647" MinimumValue="2" Type="Integer"></asp:RangeValidator>
        <br />
        <br />
        <div style="width:200px;"><asp:Label ID="lblPrimeNumbers" runat="server"></asp:Label>
            <br />
            <br />
        </div>
        Total time:
            <asp:Label ID="lblTotaal" runat="server"></asp:Label>
            &nbsp;ms<br />
            Time per iteration:
            <asp:Label ID="lblEach" runat="server"></asp:Label>
    &nbsp;ms<br />
        <br />
        <b>Exercise 3</b><br />
        Eerste getal
        <asp:TextBox ID="txtGetal1" runat="server"></asp:TextBox>
        <br />
        Tweede getal
        <asp:TextBox ID="txtGetal2" runat="server"></asp:TextBox>
        <asp:Button ID="ggdButton" runat="server" OnClick="ggdButton_Click" Text="Show greatest common divisor " />
        <br />
        <br />
        <asp:Label ID="lblGgd" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <b>Exercise 4</b>
        <br />
        Word&nbsp;
        <asp:TextBox ID="txtPalin" runat="server"></asp:TextBox>
        <asp:Button ID="btnPalin" runat="server" OnClick="btnPalin_Click" Text="Yes or no" />
        <br />
        <br />
        <asp:Label ID="lblPalin" runat="server"></asp:Label>
    </form>
</body>
</html>
