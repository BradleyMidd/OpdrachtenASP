<%@ Page Language="C#" AutoEventWireup="true" CodeFile="totaalsaldo.aspx.cs" Inherits="OpdrachtenASP.totaalsaldo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            U heeft successvol uw geld overgemaakt!<br />
            Uw huidige saldo: <asp:Label ID="saldo" runat="server" Text=""></asp:Label><br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/opdracht9.aspx">Terug</asp:HyperLink>

        </div>
    </form>
</body>
</html>
