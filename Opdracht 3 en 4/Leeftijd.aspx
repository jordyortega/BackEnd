<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Leeftijd.aspx.cs" Inherits="Opdracht_3_en_4.Leeftijd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="style.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="kalender">
    <fieldset>
    <asp:Calendar ID="kalVerjaardag" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" VisibleDate="1995-01-01"></asp:Calendar>
        <br />
        U heeft de onderstaande datum geselecteerd:<br />
        <br />
        <asp:Label style="color:blue;" ID="Label1" runat="server">Selecteer een datum</asp:Label>
        <br />
        <br />
        U bent nu:<br />
        <br />
        <asp:Label style="color:blue;" ID="Label2" runat="server">Druk op &quot;Laat zien&quot;</asp:Label>
        <br />
        <br />
        <asp:Button ID="btnLeeftijd" runat="server" OnClick="btnLeeftijd_Click" Text="Laat zien" />
    </fieldset>
    </div>

    <br />

    <div id="countdown">
    <fieldset>
        <h1>Het aftellen is begonnen</h1>
        Het is vandaag:
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;
        <asp:Literal ID="litVandaag" runat="server"></asp:Literal>
        <br />
        <br />
        Het is nu:<br />
        <br />
        &nbsp;&nbsp;&nbsp;
        <asp:Literal ID="litTijd" runat="server"></asp:Literal>
        <br />
        <h3>Wanneer is het Pasen?</h3>
        <br />
        Het duurt nog:<br />
        <br />
        <asp:Label ID="lblUren" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblMin" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblSec" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnVervers" runat="server" Text="Verversen" />
        <br />

    </fieldset>
    </div>

    </form>
</body>
</html>
