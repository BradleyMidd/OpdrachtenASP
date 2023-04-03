<%@ Page Language="C#" AutoEventWireup="true" CodeFile="opdracht4.aspx.cs" Inherits="OpdrachtenASP.opdracht4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Hoeveel:<asp:TextBox ID="cijferVeld" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Kopen" OnClick="Button1_Click" /><br />
            Totaal: <asp:TextBox ID="totaalVeld" runat="server" ReadOnly="true"></asp:TextBox>
            

        </div>
    </form>
</body>
</html>
