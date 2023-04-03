<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="OpdrachtenASP.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>Voornaam<br />
            <asp:TextBox ID="voornaamVeld" runat="server"></asp:TextBox><br />
            Achternaam<br />
            <asp:TextBox ID="achternaamVeld" runat="server"></asp:TextBox><br /><br />
            Ja, doe het, druk op de knop<br />
            <asp:Button ID="verstuurKnop" runat="server" Text="Button" OnClick="verstuurKnop_Click" />
            
        </div>
        <p>
            
            <asp:Label ID="mijnBegroeting" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
