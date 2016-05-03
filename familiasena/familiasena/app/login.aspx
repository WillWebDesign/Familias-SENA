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
            <img alt="" src="../imagen/logosena.png" style="height: 107px; width: 146px; margin-left:2em; margin-top:4px;" />
        </div>
           
        <div class="familia"><h1 align="center" style="height: 45px; width: 410px; margin-left: auto; margin-right:auto; margin-top:1em;">Familia Sena</h1></div>  


        </div>
       
        
    
    
              
             
    <div id="login">
  <form id = "form1" runat="server">     
        <label> Usuario</label><br />
        <asp:TextBox ID = "txtLogin" Width="156px" runat="server" style="margin-left: 14px"></asp:TextBox><br />

        <label>Contraseña</label><br />
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="157px" style="margin-left: 15px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID = "Button1" runat="server" Text="Iniciar Sesion"  OnClick="enviar_Click" Width="198px" style="margin-left: 10px" /><br /><br />
        <asp:Label ID = "lblError" runat="server" ForeColor="Red" Text=""></asp:Label><br />

       </form>

    </div>
   
    <div id="pie">
     


              <table style="height: 238px; width: 846px; margin-left:auto; margin-right:auto; font-family:Constantia;color:#ffffff; font-size:12px;">
<tr>
  <td class="auto-style2"><strong>Servicio Nacional de Aprendizaje SENA – Dirección General
           Calle 57 No. 8 - 69 Bogotá D.C., Cundinamarca, Colombia
           Atención presencial: lunes a viernes 8:00 a.m. a 5:30 p.m. - Resto del país sedes y horarios<br /><br />
           Atención telefónica: lunes a viernes 7:00 a.m. a 7:00 p.m. - sábados 8:00 a.m. a 1:00 p.m.
           Líneas gratuitas atención al ciudadano: Bogotá (57 1) 5925555 – Resto del país 018000 910270
           Líneas gratuitas atención al empresario: Bogotá (57 1) 4049494 – Resto del país 018000 910682
           Conmutador Nacional (57 1) 5461500 – Extensiones
           Correo notificaciones judiciales: notificacionesjudiciales@sena.edu.co<br /><br />
       Todos los derechos reservados © 2016 SENA – Políticas de privacidad y condiciones de uso</strong></td>
  
     <td ><img alt="" src="../imagen/Certificaciones.png" style="height: 109px; width: 353px; margin-bottom:8em;" /></td>

</tr>

            </table>
        
               
    </div>      
    </div>   

</body>
</html>

