<%@ Page Language="C#" AutoEventWireup="true" CodeFile="lowsaldo.aspx.cs" Inherits="OpdrachtenASP.lowsaldo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

             Er is niet genoeg saldo op u rekening om over te maken<br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/opdracht9.aspx">Terug</asp:HyperLink>

        </div>
    </form>
</body>
</html>
