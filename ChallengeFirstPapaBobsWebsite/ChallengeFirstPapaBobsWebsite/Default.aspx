<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeFirstPapaBobsWebsite.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FF3300;
        }
        .auto-style3 {
            font-size: small;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1 style="font-family: Arial, Helvetica, sans-serif">
            <asp:Image ID="resultImage" runat="server" ImageUrl="~/PapaBob.png" />
            Papa Bob&#39;s Pizza and Software</h1>
    
    </div>
        <p>
            <asp:RadioButton ID="babyBobRadioButton" runat="server" GroupName="sizeGroup" Text="Baby Bob Size (10&quot;) - $10" />
            <br />
            <asp:RadioButton ID="mamaBobRadioButton" runat="server" GroupName="sizeGroup"  Text="Mama Bob Size (13&quot;) - $13" /> <!-- OnCheckedChanged="RadioButton2_CheckedChanged" -->   
            <br />
            <asp:RadioButton ID="papaBobRadioButton" runat="server" GroupName="sizeGroup" Text="Papa Bob Size (16&quot;) - $16" />
        </p>
            <asp:RadioButton ID="thinCrustRadioButton" runat="server" GroupName="crustGroup" Text="Thin Crust" />
            <br />
            <asp:RadioButton ID="deepDishRadioButton" runat="server" GroupName="crustGroup" Text="Deep Dish (+$2)" />
        <p>
            <asp:CheckBox ID="pepperoniCheckBox" runat="server" Text="Pepperoni (+$1.50)" />
            <br />
            <asp:CheckBox ID="onionsCheckBox" runat="server" Text="Onions (+$0.75)" />
            <br />
            <asp:CheckBox ID="greenPeppersCheckBox" runat="server" Text="Green Peppers (+$0.50)" />
            <br />
            <asp:CheckBox ID="redPeppersCheckBox" runat="server" Text="Red Peppers (+$0.75)" />
            <br />
            <asp:CheckBox ID="anchoviesCheckBox" runat="server" Text="Anchovies (+$2)" />
            <br />
        </p>
        <h3 style="font-family: Arial, Helvetica, sans-serif">Papa Bob&#39;s <span class="auto-style1">Special Deal</span></h3>
        <p class="auto-style3">
            Save $2.00 when you add Pepperoni,&nbsp;Green Peppers, and Anchovies OR Pepperoni, Red Peppers, and Onions to your pizza.</p>
        <p>
            <asp:Button ID="purchaseButton" runat="server" OnClick="purchaseButton_Click" Text="Purchase" />
        </p>
        <p>
            Total:&nbsp; <asp:Label ID="resultLabel" runat="server">$0.00</asp:Label>
        </p>
        <p>
            Sorry, at this time you can only order one pizza online, and pick-up only...we need a better website!</p>
    </form>
</body>
</html>
