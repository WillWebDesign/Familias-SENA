<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns = "http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="estilos.css" rel="stylesheet" type="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    

 
</head>

<body>
<div id="contenedor">


  
    <div id="cabeza">
        <div Id ="sena">
            <img alt="" src="http://contratistas.sena.edu.co/Resources/logo_sena2.png" style="height: 109px; width: 124px" />
        </div>
           
        <div class="familia"><h1 align="center" style="height: 45px; width: 410px; margin-left: auto; margin-right:auto">Familia Sena</h1></div>  


        </div>
       
        
    
    </div>
     <form id = "form1" runat="server">              
             
    <div id="login">
        <label class="nombres">Cedula</label><br />
        <asp:TextBox ID = "txtdocumento" Width="158px" runat="server" style="margin-left: 18px"></asp:TextBox><br />

        <label class="nombres"> Usuario</label><br />
        <asp:TextBox ID = "txtLogin" Width="156px" runat="server" style="margin-left: 14px"></asp:TextBox><br />

        <label class="nombres">Contraseña</label><br />
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="157px" style="margin-left: 15px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID = "Button1" runat="server" Text="Iniciar Sesion"  OnClick="enviar_Click" Width="173px" style="margin-left: 17px" /><br />
        <asp:Label ID = "lblError" runat="server" ForeColor="Red" Text=""></asp:Label><br />

        <br />
        <br />

    </div>
    </form>
    <div id="pie">
        <div id="parrafo">
        <p class="a">Servicio Nacional de Aprendizaje SENA – Dirección General
           Calle 57 No. 8 - 69 Bogotá D.C., Cundinamarca, Colombia
           Atención presencial: lunes a viernes 8:00 a.m. a 5:30 p.m. - Resto del país sedes y horarios</p>
        <p class="a"> Atención telefónica: lunes a viernes 7:00 a.m. a 7:00 p.m. - sábados 8:00 a.m. a 1:00 p.m.
           Líneas gratuitas atención al ciudadano: Bogotá (57 1) 5925555 – Resto del país 018000 910270
           Líneas gratuitas atención al empresario: Bogotá (57 1) 4049494 – Resto del país 018000 910682
           Conmutador Nacional (57 1) 5461500 – Extensiones
           Correo notificaciones judiciales: notificacionesjudiciales@sena.edu.co</p>
        <p class="a">Todos los derechos reservados © 2016 SENA – Políticas de privacidad y condiciones de uso</p>
            
            </div>
        <div style="height: 236px">
            <img alt="" src="http://contratistas.sena.edu.co/Resources/Certificaciones.png" />
        </div>
    </div>
</body>
</html>

