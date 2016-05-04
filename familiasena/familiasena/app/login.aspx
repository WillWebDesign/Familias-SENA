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
           
    <div class="familia" style="float:left; width: 875px; height: 88px;" ><h1 align="center" style="height: 41px; width: 496px; margin-left: auto; margin-right:auto; margin-top:1em;">Familia Sena</h1></div>  

    <div id="enlaces" style="float:right;  height: 101px; width: 201px; margin-right:5px; margin-left: 0px;">
             
   <table style="height: 40px; float:right; width: 140px;">
        <tr>
            <td> <img alt="" src="../imagen/logo.png" style="height: 63px; width: 175px; float:; margin-top: 0px;" /></td>
        </tr>  
  </table>

  <table style="height: 7px; float:right; width: 140px;  margin-bottom:3em;">
             
       <tr>
         <td> <a href="https://www.facebook.com/senageneral/"><img  alt="" src="../imagen/facebook.png" style="height: 26px; width: 26px" /></a></td>
         <td><a href="https://www.youtube.com/user/SENATV"><img alt="" src="../imagen/youtube.png" style="height: 26px; width: 26px" /></a></td>
         <td><a href="https://www.instagram.com/senacomunica/"><img alt="" src="../imagen/instagran.png" style="height: 26px; width: 26px" /></a></td>
         <td><a href="https://plus.google.com/+senacolombia/posts"><img alt="" src="../imagen/google.png" style="height: 26px; width: 26px" /></a></td>
         <td><a href="https://twitter.com/SENAComunica"><img alt="" src="../imagen/twitter.png" style="height: 26px; width: 26px" /></a></td>
       </tr>
   </table>
    </div>
   </div>      
           
<div id="login">
      <form id = "form1" runat="server">     
        <label> Usuario</label><br />
        <img alt="" src="../imagen/usuario.png" style="margin-right: 0px; margin-left: 0px; width: 17px; height: 19px; margin-top: 2px;" /><asp:TextBox ID = "txtLogin" Width="157px" runat="server" style="margin-left: 2px" Height="25px"></asp:TextBox><br />
        <label>Contraseña</label><br />
           <img alt="" src="../imagen/contrasena.png" style="margin-right: 0px;  width: 17px; height: 17px;" /><asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="157px" style="margin-left: 2px" Height="25px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID = "Button1" runat="server" Text="Iniciar Sesion"  OnClick="enviar_Click" Width="198px" style="margin-left: 10px" /><br /><br />
        <asp:Label ID = "lblError" runat="server" ForeColor="Red" Text=""></asp:Label><br />
     </form>
</div>
   
<div id="pie">
    <table style="height: 238px; width: 846px; margin-left:auto; margin-right:auto; font-family:Constantia;color:#ffffff; font-size:12px;">
        <tr>
           <td >Servicio Nacional de Aprendizaje SENA – Dirección General
           Calle 57 No. 8 - 69 Bogotá D.C., Cundinamarca, Colombia
           Atención presencial: lunes a viernes 8:00 a.m. a 5:30 p.m. - Resto del país sedes y horarios<br /><br />
           Atención telefónica: lunes a viernes 7:00 a.m. a 7:00 p.m. - sábados 8:00 a.m. a 1:00 p.m.
           Líneas gratuitas atención al ciudadano: Bogotá (57 1) 5925555 – Resto del país 018000 910270
           Líneas gratuitas atención al empresario: Bogotá (57 1) 4049494 – Resto del país 018000 910682
           Conmutador Nacional (57 1) 5461500 – Extensiones
           Correo notificaciones judiciales: notificacionesjudiciales@sena.edu.co<br /><br />
           Todos los derechos reservados © 2016 SENA – Políticas de privacidad y condiciones de uso</td>
           
            <td ><img alt="" src="../imagen/Certificaciones.png" style="height: 109px; width: 353px; margin-bottom:8em;" /></td>
        </tr>

    </table>
        
               
    
</div>      
</div>   

</body>
</html>

