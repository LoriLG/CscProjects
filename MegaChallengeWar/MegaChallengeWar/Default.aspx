<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MegaChallengeWar.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    Play War !<form id="form1" runat="server">
        <p>
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Play" />
        </p>
        <p>
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    <div>
    
    </div>
    </form>
</body>
</html>
