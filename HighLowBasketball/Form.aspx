<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="HighLowBasketball.Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Euroleague HighLow</title>
    <link rel="stylesheet" href="~/Code/stylesheet.css" type="text/css"/>
    <link rel="shortcut icon" href="~/Code/favicon.ico" type="image/x-icon">  
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Selected="True">Height</asp:ListItem>
                <asp:ListItem>Age</asp:ListItem>
                <asp:ListItem>Games played</asp:ListItem>
                <asp:ListItem>Win percentage</asp:ListItem>
                <asp:ListItem>Minutes per game</asp:ListItem>
                <asp:ListItem>Points per game</asp:ListItem>
                <asp:ListItem>2&#39;s made per game</asp:ListItem>
                <asp:ListItem>2&#39;s attempted per game</asp:ListItem>
                <asp:ListItem>2&#39;s shooting percentage</asp:ListItem>
                <asp:ListItem>3&#39;s made per game</asp:ListItem>
                <asp:ListItem>3&#39;s attempted per game</asp:ListItem>
                <asp:ListItem>3&#39;s shooting percentage</asp:ListItem>
                <asp:ListItem>Shots made per game</asp:ListItem>
                <asp:ListItem>Shots attempted per game</asp:ListItem>
                <asp:ListItem>Shooting percentage</asp:ListItem>
                <asp:ListItem>Free throws made per game</asp:ListItem>
                <asp:ListItem>Free throws attempted per game</asp:ListItem>
                <asp:ListItem>Free throws percentage</asp:ListItem>
                <asp:ListItem>Offensive rebounds per game</asp:ListItem>
                <asp:ListItem>Defensive rebounds per game</asp:ListItem>
                <asp:ListItem>Rebounds per game</asp:ListItem>
                <asp:ListItem>Assists per game</asp:ListItem>
                <asp:ListItem>Fouls made per game</asp:ListItem>
                <asp:ListItem>Fouls drawn per game</asp:ListItem>
                <asp:ListItem>Steals per game</asp:ListItem>
                <asp:ListItem>Turnovers per game</asp:ListItem>
                <asp:ListItem>Blocks per game</asp:ListItem>
                <asp:ListItem>Average performence index</asp:ListItem>
            </asp:DropDownList>
&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Start a game!" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Bold="True" style="margin-left: 200px"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" style="margin-left: 200px"></asp:Label>
            <br />
            <br />
            <div style="width: 506px; height: 200px; overflow: hidden" class="container">
                <div style="float: left; width: 200px; height: 200px">

            <asp:Table ID="Table1" runat="server" Height="200px" Width="200px" GridLines="Horizontal" HorizontalAlign="Center">
            </asp:Table>

                </div>
                <div style="float: left; width: 100px; height: 200px; margin-left: 3px; margin-right: 3px">

                    <br />
                    <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Higher" style="margin-left: auto; margin-right:auto" Width="100px"/>
                    <br />
                    <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Equal" Width="100px" />
                    <br />
                    <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Lower" Width="100px" />
                    <br />
                    <br />
                    <br />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Next" Width="100px" />

                </div>
                <div style="float: left; width: 200px; height: 200px;">

            <asp:Table ID="Table2" runat="server" Height="200px" Width="200px" HorizontalAlign="Center" GridLines="Horizontal">
            </asp:Table>

                </div>
            </div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>
