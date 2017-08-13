<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Default" MaintainScrollPositionOnPostback="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 153px;
            height: 190px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <img class="auto-style1" src="epic-spies-logo.jpg" /><br />
        <h2 style="font-family: Arial, Helvetica, sans-serif">Spy New Assignment Form</h2>
    <div>
    
        Spy Code Name:
        <asp:TextBox ID="codeNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        New Assignment Name:
        <asp:TextBox ID="assignmentNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        End Date of Previous Assignment:<br />
        <asp:Calendar ID="previousEndDateCalendar" runat="server"></asp:Calendar>
        <br />
        <br />
        Start Date of New Assignment:<br />
        <asp:Calendar ID="newStartDateCalendar" runat="server"></asp:Calendar>
        <br />
        <br />
        Projected End Date of New Assignment:<br />
        <asp:Calendar ID="projectedEndDateCalendar" runat="server"></asp:Calendar>
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" Text="Assign Spy" OnClick="okButton_Click" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
