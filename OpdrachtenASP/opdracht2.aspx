<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="opdracht2.aspx.cs" Inherits="OpdrachtenASP.opdracht2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="nummer1" runat="server"></asp:TextBox>
            <asp:TextBox ID="nummer2" runat="server"></asp:TextBox><br />

            <asp:Button ID="p" runat="server" Text="+" OnClick="plus_Click" style="width: 24px" />
            <asp:Button ID="m" runat="server" Text="-" OnClick="min_Click" />
            <asp:Button ID="k" runat="server" Text="x" OnClick="keer_Click" />
            <asp:Button ID="d" runat="server" Text="/" OnClick="delen_Click" style="width: 25px" /><br />

            <asp:TextBox ID="antwoordVeld" ReadOnly="true" runat="server"></asp:TextBox><br />
        </div>
    </form>
</body>
</html>
