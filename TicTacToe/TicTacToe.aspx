<%@ Page Language="C#" AutoEventWireup="true" EnableViewState="true" CodeBehind="TicTacToe.aspx.cs" Inherits="TicTacToe.TicTacToe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            TicTacToe Game</div>
        <asp:Button ID="Button1" runat="server"  Text="-" OnClick="Button_Click" Width="40px" />
        <asp:Button ID="Button2" runat="server"  Text="-" OnClick="Button_Click" Width="40px" />
        <asp:Button ID="Button3" runat="server"  Text="-" OnClick="Button_Click" Width="40px" />
        <p>
            <asp:Button ID="Button4" runat="server"  Text="-" OnClick="Button_Click" Width="40px" />
            <asp:Button ID="Button5" runat="server" Text="-" OnClick="Button_Click" Width="40px" />
            <asp:Button ID="Button6" runat="server" Text="-" OnClick="Button_Click" Width="40px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="player" runat="server" Text="Player1"></asp:Label>
        </p>
        <asp:Button ID="Button7" runat="server"  Text="-" OnClick="Button_Click" Width="40px" />
        <asp:Button ID="Button8" runat="server"  Text="-" OnClick="Button_Click" Width="40px" />
        <asp:Button ID="Button9" runat="server"  Text="-" OnClick="Button_Click" Width="40px" />
        <p>
            <asp:Label ID="lbl_winning" runat="server" Text="Winning Player:"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btn_reset" runat="server" OnClick="btn_reset_Click" Text="Reset" />
        </p>
    </form>
</body>
</html>
