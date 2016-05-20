<%@ Page Title="Iniciar sesión" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="familiasena.Account.Login" Async="true" %>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">


    <div class="row">
   
        <label> Usuario</label><br />
        <img alt="" src="../imagen/usuario.png" style="margin-right: 0px; margin-left: 0px; width: 17px; height: 19px; margin-top: 2px;" /><asp:TextBox ID = "txtLogin" Width="157px" runat="server" style="margin-left: 2px" Height="25px"></asp:TextBox><br />
        <label>Contraseña</label><br />
           <img alt="" src="../imagen/contrasena.png" style="margin-right: 0px;  width: 17px; height: 17px;" /><asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="157px" style="margin-left: 2px" Height="25px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID = "Button1" runat="server" Text="Iniciar Sesion"  OnClick="enviar_Click" Width="198px" style="margin-left: 10px" /><br /><br />
        <asp:Label ID = "lblError" runat="server" ForeColor="Red" Text=""></asp:Label><br />

    </div>
</asp:Content>
