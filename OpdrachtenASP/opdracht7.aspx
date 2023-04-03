<%@ Page Language="C#" AutoEventWireup="true" CodeFile="opdracht7.aspx.cs" Inherits="OpdrachtenASP.opdracht7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            
           Vandaag is het: <asp:TextBox ID="vandaag" runat="server" ReadOnly="true"></asp:TextBox><br />
            Over <asp:TextBox ID="over" runat="server"></asp:TextBox> Dagen<br />
            <asp:Button ID="is" runat="server" Text="Is het" OnClick="is_Click" /><br />
            <asp:TextBox ID="dan" runat="server" ReadOnly="true"></asp:TextBox>

        </div>
    </form>
</body>
</html>
