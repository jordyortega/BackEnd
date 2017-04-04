<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Opdracht_6._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <link rel="stylesheet" href="Content/bootstrap.min.css">
    <script src="Scripts/bootstrap.min.js"></script> 
    <link href="https://fonts.googleapis.com/css?family=Orbitron" rel="stylesheet">
    <style type="text/css">
        * {
        }

        body {
            margin-bottom: 50px;
            background: url("Content/pattern.png");
            background-repeat: repeat;
        }
        .col:not(:last-of-type) {
        margin: 8px;
        }

        .rekenmachine { 
        border: 1px solid #D6D6D6;
        padding: 10px;
        width: 266px;
        display: inline-block;
        background-color: #F5F5F5;
        height:346px;
        border-radius: 5px;
        }

         .history { 
        border: 1px solid #D6D6D6;
        width: 266px;
        display: inline-block;
        background-color: #F5F5F5;
        height:38px;
        border-radius: 5px;
        }

        .memory {
            padding: 40px;
        }
        label.lblScherm{
        color: #333;
        font-family: 'Orbitron', sans-serif;
        }

        .well {
        margin-top:0px !important;
        height:60px !important;
        text-align: right;
        }

        .container {
        text-align: center;
        margin-top: 120px;
        }
        .logo>h3 {
        margin-top:-4px;
        }

        .btn-info {
        color: #fff;
        background-color: #333 !important;
        border-color: #2a2a2a !important;
        width:54px !important;
        font-family: 'Orbitron', sans-serif;
        }

        .btn-warning {
        width:54px !important;
        font-family: 'Orbitron', sans-serif;
        }

        .btn-danger {
        width:54px !important;
        font-family: 'Orbitron', sans-serif;
        }

        .btn-success {
        width:54px !important;
        font-family: 'Orbitron', sans-serif;
        }

        .btn-info:focus,
        .btn-info.focus {
        color: #fff;
        background-color: none !important;
        border-color: #000 !important;
        }
        .btn-info:hover {
        color: #fff;
        background-color: #242424 !important;
        border-color: #333;
        }

        .btn-info:active,
        .btn-info.active,
        .open > .dropdown-toggle.btn-info {
        color: #fff;
        background-color: #333 !important;
        border-color: #000 !important;
        }

        .btn:focus {
         outline: none !important;
         }
         .footer {
        position: fixed;
        bottom: 0;
        width: 100%;
        height: 60px;
        background-color: #333;
        border-top:5px solid #464545;
        }
        p.text {
            margin-top:-103px;
            color:white;
        }

        .col2 {
            margin: 20px 0 0 -10px !important;  

        }

        Label {
            font-family: 'Orbitron', sans-serif;
        }

        .jumbotron {
            background-color: #333 !!important;
            border-bottom:5px solid #464545;
            color:white !important;
        }
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <div class="jumbotron" style="background:#333 !important;">
    <center><h1><b>Maico & Jordy</b></h1></center>
    <center><h2 style="margin-top: -10px;">Bootstrap C# Rekenmachine</h2></center>
  </div>
    <div class="container">
<div class="rekenmachine">
    <div class="well"><asp:Label ID="lblScherm" style="font-family: 'Orbitron', sans-serif;" runat="server" Text="0"></asp:Label></div>
    <div class="toetsencontainer">
        <div class="col">
            <asp:Button runat="server" Text="7"  CssClass="btn btn-info btn-md" ID="knop7" OnClick="button7_Click"/>
            <asp:Button runat="server" Text="8"  CssClass="btn btn-info btn-md" ID="knop8" OnClick="button8_Click"/>
            <asp:Button runat="server" Text="9"  CssClass="btn btn-info btn-md" ID="knop9" OnClick="button9_Click"/>
            <asp:Button runat="server" Text="÷"  CssClass="btn btn-info btn-md" ID="knopDelen" OnClick="buttonDelen_Click"/>
        </div>
        <div class="col">
            <asp:Button runat="server" Text="4"  CssClass="btn btn-info btn-md" ID="knop4" OnClick="button4_Click"/>
            <asp:Button runat="server" Text="5"  CssClass="btn btn-info btn-md" ID="knop5" OnClick="button5_Click"/>
            <asp:Button runat="server" Text="6"  CssClass="btn btn-info btn-md" ID="knop6" OnClick="button6_Click"/>
            <asp:Button runat="server" Text="×"  CssClass="btn btn-info btn-md" ID="knopMaal" OnClick="buttonMaal_Click"/>
        </div>
        <div class="col">
            <asp:Button runat="server" Text="1"  CssClass="btn btn-info btn-md" ID="knop1" OnClick="button1_Click"/>
            <asp:Button runat="server" Text="2"  CssClass="btn btn-info btn-md" ID="knop2" OnClick="button2_Click"/>
            <asp:Button runat="server" Text="3"  CssClass="btn btn-info btn-md" ID="knop3" OnClick="button3_Click"/>
            <asp:Button runat="server" Text="-"  CssClass="btn btn-info btn-md" ID="knopMin" OnClick="buttonMin_Click"/>
        </div>
        <div class="col">
            <asp:Button runat="server" Text="."  CssClass="btn btn-info btn-md" ID="knopPunt" OnClick="buttonPunt_Click"/>
            <asp:Button runat="server" Text="0"  CssClass="btn btn-info btn-md" ID="knop0" OnClick="button0_Click"/>
            <asp:Button runat="server" Text="%"  CssClass="btn btn-info btn-md" ID="knopProcent" OnClick="buttonProcent_Click"/>
            <asp:Button runat="server" Text="+"  CssClass="btn btn-info btn-md" ID="knopPlus" OnClick="buttonPlus_Click"/>
        </div>
        <div class="col">
            <asp:Button runat="server" Text="Cos"  CssClass="btn btn-info btn-md" ID="knopCos" OnClick="buttonCos_Click"/>
            <asp:Button runat="server" Text="Tan"  CssClass="btn btn-info btn-md" ID="knopTan" OnClick="buttonTan_Click"/>
            <asp:Button runat="server" Text="O1"  CssClass="btn btn-info btn-md" ID="knopO1" OnClick="buttonO1_Click"/>
            <asp:Button runat="server" Text="O2"  CssClass="btn btn-info btn-md" ID="knopO2" OnClick="buttonO2_Click"/>
            
        </div>
        <div class="col">
            <asp:Button runat="server" Text="M2"  CssClass="btn btn-info btn-md" ID="knopM2" OnClick="buttonM2_Click"/>
            <asp:Button runat="server" Text="Del"  CssClass="btn btn-warning btn-md" ID="knopBack" OnClick="buttonBack_Click"/>
            <asp:Button runat="server" Text="C"  CssClass="btn btn-danger btn-md" ID="knopClear" OnClick="buttonClear_Click"/>
            <asp:Button runat="server" Text="="  CssClass="btn btn-success btn-md" ID="knopIs" OnClick="buttonIs_Click"/>
        </div>
        <div class="col2">
             <div class="history">
            <span class="label label-primary" style="display:block;">Geschiedenis</span>
            <asp:Label ID="lGetal1" style="font-family: 'Orbitron', sans-serif;" runat="server" Text=""></asp:Label>
            <asp:Label ID="lBereken" style="font-family: 'Orbitron', sans-serif;" runat="server" Text=""></asp:Label>
            <asp:Label ID="lGetal2" style="font-family: 'Orbitron', sans-serif;" runat="server" Text=""></asp:Label>
            <asp:Label ID="lUitkomst" style="font-family: 'Orbitron', sans-serif;" runat="server" Text=""></asp:Label>
        </div>
        </div>
    </div>
</div>
</div>
    </div>   
    </form>
    <footer class="footer">
      <div class="container">
        <p class="text">&copy; 2017 Maico &amp; Jordy - Alle rechten voorbehouden.</p>
      </div>
    </footer>
</body>
</html>
