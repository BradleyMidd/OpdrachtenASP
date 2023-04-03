<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="opdracht1.aspx.cs" Inherits="OpdrachtenASP.opdracht1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Table ID="Table1" runat="server">
                 <asp:TableRow runat="server">
            	
            <asp:TableCell runat="server">Voornaam</asp:TableCell>
            <asp:TableCell runat="server"><asp:TextBox ID="voornaamVeld" runat="server"></asp:TextBox><br /></asp:TableCell>
                     </asp:TableRow>

                 <asp:TableRow runat="server">
            <asp:TableCell runat="server"> Achternaam</asp:TableCell>
                 <asp:TableCell runat="server"><asp:TextBox ID="achternaamVeld" runat="server"></asp:TextBox><br /></asp:TableCell>
                     </asp:TableRow>

                     <asp:TableRow runat="server">
            <asp:TableCell runat="server">Woonplaats</asp:TableCell>
                 <asp:TableCell runat="server"><asp:TextBox ID="woonplaatsVeld" runat="server"></asp:TextBox><br /></asp:TableCell>
                         </asp:TableRow>

                         <asp:TableRow runat="server">
            <asp:TableCell runat="server">Klas</asp:TableCell>
                 <asp:TableCell runat="server"><asp:TextBox ID="klasVeld" runat="server"></asp:TextBox><br /></asp:TableCell>
                     </asp:TableRow>

                        </asp:Table>
             <asp:Button ID="verstuurKnop" runat="server" Text="Button" OnClick="verstuurKnop_Click" />
            

        </div>

        <asp:Label ID="mijnBegroeting" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
