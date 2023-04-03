<%@ Page Language="C#" AutoEventWireup="true" CodeFile="opdracht5.aspx.cs" Inherits="OpdrachtenASP.opdracht5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

             <h2>Stel je eigen pizza samen:</h2>

            <table style="width: 100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td>BODEM</td>
                    <td>3 euro</td>
                </tr>
                <tr>
                    <td><input id="tom" type="checkbox" runat="server" /></td>
                    <td>Tomatensaus</td>
                    <td>1 euro</td>
                </tr>
                <tr>
                    <td><input id="sal" type="checkbox" runat="server" /></td>
                    <td>Salami</td>
                    <td>2 euro</td>
                </tr>                
                
                <tr>
                    <td><input id="pep" type="checkbox" runat="server" /></td>
                    <td>Pepperoni</td>
                    <td>2 euro</td>
                </tr>
                <tr>
                    <td><input id="ham" type="checkbox" runat="server" /></td>
                    <td>Ham</td>
                    <td>2 euro</td>
                </tr>               
                <tr>
                    <td><input id="carp" type="checkbox" runat="server" /></td>
                    <td>Carpaccio</td>
                    <td>2,50 euro</td>
                </tr>
                <tr>
                    <td><input id="pap" type="checkbox" runat="server" /></td>
                    <td>Paprika</td>
                    <td>2 euro</td>
                </tr>               
                <tr>
                    <td><input id="knof" type="checkbox" runat="server" /></td>
                    <td>Knoflook</td>
                    <td>1 euro</td>
                </tr>
                <tr>
                    <td><input id="cham" type="checkbox" runat="server" /></td>
                    <td>Champignons</td>
                    <td>2 euro</td>
                </tr>               
                <tr>
                    <td><input id="gor" type="checkbox" runat="server" /></td>
                    <td>Gorgonzola</td>
                    <td>2,50 euro</td>
                </tr>
                <tr>
                    <td><input id="moz" type="checkbox" runat="server" /></td>
                    <td>Mozzarella</td>
                    <td>1,50 euro</td>
                </tr>
            </table><br />

            <asp:Button ID="reken" runat="server" Text="REKEN AF" OnClick="reken_Click" /><br />
            Totale prijs: <asp:TextBox ID="totaal" runat="server" ReadOnly="true"></asp:TextBox>

        </div>
    </form>
</body>
</html>
