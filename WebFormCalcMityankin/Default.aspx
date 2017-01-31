<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormCalcMityankin.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    </head>

<body style="height: 410px">
    <form id="form1" runat="server">
            
        <asp:Label ID="CalcHistory" runat="server"  Width="280pt"></asp:Label>
        <asp:Label ID="Label1" runat="server" Text="=" Width="20pt"></asp:Label>
        <asp:Label ID="Result" runat="server" Width="100pt"></asp:Label>
        <br/>
        <asp:Button ID="Clear" runat="server"  Width="306pt" Text="C" OnClick="Clear_Click" />
        <asp:Button ID="Multiply" runat="server" Width="100pt" Text="*" OnClick="Multiply_Click" />
        <br/>
        <asp:Button ID="Num7" runat="server" Width="100pt" Text="7" CommandArgument="7" OnClick="Num_Clic" />
        <asp:Button ID="Num8" runat="server" Width="100pt" Text="8" CommandArgument="8" OnClick="Num_Clic" />
        <asp:Button ID="Num9" runat="server" Width="100pt" Text="9" CommandArgument="9" OnClick="Num_Clic" />
        <asp:Button ID="Divided" runat="server" Width="100pt" Text="/" OnClick="Divided_Click" />
        <br/>
        <asp:Button ID="Num4" runat="server" Width="100pt" Text="4" CommandArgument="4" OnClick="Num_Clic" />
        <asp:Button ID="Num5" runat="server" Width="100pt" Text="5" CommandArgument="5" OnClick="Num_Clic" />
        <asp:Button ID="Num6" runat="server" Width="100pt" Text="6" CommandArgument="6" OnClick="Num_Clic" />
        <asp:Button ID="Minus" runat="server" Width="100pt" Text="-" OnClick="Minus_Click" />
        <br/>
        <asp:Button ID="Num1" runat="server" Width="100pt" Text="1" CommandArgument="1" OnClick="Num_Clic" />
        <asp:Button ID="Num2" runat="server" Width="100pt" Text="2" CommandArgument="2" OnClick="Num_Clic" />
        <asp:Button ID="Num3" runat="server" Width="100pt" Text="3" CommandArgument="3" OnClick="Num_Clic" />
        <asp:Button ID="Add" runat="server" Width="100pt" Text="+" OnClick="Add_Click" />
        <br/>
        <asp:Button ID="Nm0" runat="server" Width="100pt" Text="0" CommandArgument="0" OnClick="Num_Clic" />
        <asp:Button ID="Done" runat="server" Width="306pt" Text="=" OnClick="Done_Click" />
        <br/>              
    </form>
    </body>
</html>
