<%@ Page Language="C#" AutoEventWireup="true" CodeFile="opdracht9.aspx.cs" Inherits="OpdrachtenASP.opdracht9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Huidige Saldo: <asp:Label ID="saldo" runat="server" Text=""></asp:Label><br />
            Voer uw pincode in: <asp:TextBox ID="pin" runat="server" MaxLength="4" TextMode="Password"></asp:TextBox><br />
            Bedrag: <asp:TextBox ID="bedrag" runat="server"></asp:TextBox><br />
            <asp:Button ID="klik" runat="server" Text="Overmaken" OnClick="klik_Click" />

        </div>
    </form>
</body>
</html>
