<%@ Page Language="C#" AutoEventWireup="true" CodeFile="opdracht6.aspx.cs" Inherits="OpdrachtenASP.opdracht6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Vul een getal in: <asp:TextBox ID="getal" runat="server"></asp:TextBox><br />
            <asp:Button ID="toon" runat="server" Text="Toon tafel" OnClick="toon_Click" />
            <asp:Button ID="reset" runat="server" Text="Reset" OnClick="reset_Click" style="height: 26px" /><br />
            <asp:Label ID="Label1" runat="server"></asp:Label>


        </div>
    </form>
</body>
</html>
