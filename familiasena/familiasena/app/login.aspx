<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns = "http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id = "form1" runat="server">
    <div>

        <div>
            <table>
                <tr>

                    <td>
                        <asp:Label ID = "cedula" runat="server" Text="Cedula:"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID = "txtdocumento" Width="150" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>

                    <td>
                        <asp:Label ID = "lblName" runat="server" Text="Usuario:"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID = "txtLogin" Width="150" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID = "lblpwd" runat="server" Text="Contraseña:"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID = "txtPassword" Width="150" TextMode="Password" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan = "2" >
                       <asp:Button ID = "btnLogin" runat="server" Text="Iniciar Sesion"  OnClick="enviar_Click" Width="240px" />
                       </td>
                </tr>
                <tr>
                    <td colspan = "2" >
                        <asp:Label ID = "lblError" runat="server" ForeColor="Red" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </div>
    </form>
</body>
</html>

