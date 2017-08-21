<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MegaChallengeCasino.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="firstImage" runat="server" Height="150px" ImageUrl="~/Cherry.png" Width="150px" />
        &nbsp;
        <asp:Image ID="secondImage" runat="server" Height="150px" ImageUrl="~/Orange.png" style="margin-top: 18px" Width="150px" />
        &nbsp;&nbsp;&nbsp;
        <asp:Image ID="thirdImage" runat="server" Height="150px" ImageUrl="~/Plum.png" Width="150px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
    
    </div>
        <p>
            Your Bet: <asp:TextBox ID="yourBetTextBox" runat="server" AutoPostBack="True" OnTextChanged="yourBetTextBox_TextChanged"></asp:TextBox>
        </p>
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" PostBackUrl="~/Default.aspx" Text="Pull The Lever!" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="moneyLabel" runat="server"></asp:Label>
        <br />
        <br />
        1 Cherry - x2 Your Bet<br />
        2 Cherries - x3 Your Bet<br />
        3 Cherries - x4 Your Bet<br />
        3 7&#39;s - Jackpot - x100 Your Bet<br />
        HOWEVER ... If there&#39;s even one BAR you win nothing.<br />
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
