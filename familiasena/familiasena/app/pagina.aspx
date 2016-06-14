
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pagina.aspx.cs" Inherits="pagina" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="estilos.css" rel="stylesheet" type="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<script src="jquery.min.js"></script>
<script src="main.js"></script>

    <title></title>
    
  
    
</head>
<body>
    
    <form id="form1" runat="server">
    <asp:Button ID="cerrar" runat="server" OnClick="Logout"  Text="Cerrar  Sesion"/>
<div id="contenedor">
    
   <<div id="cabeza"">


        <div Id ="sena">
            <img alt="" src="../imagen/logosena.png" style="height: 103px; width: 127px; margin-left:1em; margin-top:10px;" />
        </div>
           
    <div class="familia" style="float:left; width: 884px; height: 88px;" ><h1 align="center" style="height: 41px; width: 496px; margin-left: auto; margin-right:auto; margin-top:1em;">Familia Sena</h1></div>  

    <div id="enlaces" style="float:right;  height: 121px; width: 201px; margin-right:5px; margin-left: 0px;">
             
   <table style="height: 40px; float:right; width: 190px;">
        <tr>
            <td> <a href="http://es.presidencia.gov.co/"><img alt="" src="../imagen/logo.png" style="height: 63px; width: 175px; float:; margin-top: 0px;" /></a></td>
        </tr>  
  </table>

  <table style="height: 43px; float:right; width: 139px;  margin-bottom:3em;">
             
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
 
 <div id="contenidos"> 
         
  <div id="funcionario">
      
        <div style="float:right; margin-bottom:2px; margin-top:2px; height: 120px; width: 258px;"><img alt="" src="../imagen/familia.png" style="height: 124px; width: 228px; margin-right:2em; " /></div>
        
       <div id="nombre" runat="server" style="margin-left:4em; width: 370px; margin-top: 30px;">Nombres:</div>
       <div id ="cedula" runat="server" style="margin-left:4em; width: 370px;">Cedula:</div>
       <div id ="convocatoria" runat="server" style="margin-left:4em; width: 370px;"></div>
  </div>
     <div id="familiares" runat="server">
         
     </div> <br/>
    <center>
   <input type="button" id="enviarInfo"    value="Confirmar"/>
    </center>
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
    </form>
    </body>
</html>
