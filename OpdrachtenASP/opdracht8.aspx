<%@ Page Language="C#" AutoEventWireup="true" CodeFile="opdracht8.aspx.cs" Inherits="OpdrachtenASP.opdracht8aspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Button ID="add" runat="server" Text="Add" OnClick="add_Click" />
            <asp:Button ID="reset" runat="server" Text="Reset" OnClick="reset_Click" /><br />
            <asp:Label ID="number" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>
