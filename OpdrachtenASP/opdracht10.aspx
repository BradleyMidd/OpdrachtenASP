<%@ Page Language="C#" AutoEventWireup="true" CodeFile="opdracht10.aspx.cs" Inherits="OpdrachtenASP.opdracht10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Cijfer: <asp:TextBox ID="cijfer" runat="server"></asp:TextBox><br />
            <asp:Button ID="voeg" runat="server" Text="Voeg Toe" OnClick="voeg_Click" /><br />
            <asp:Label ID="aant" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="gem" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="hoog" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="laag" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>
