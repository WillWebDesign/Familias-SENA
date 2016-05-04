using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ws = familiasena.co.edu.sena.busdatos;


public partial class pagina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["key"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else {
                string Correo = (string)(Session["key"]);
                infoFamiliaWS(Correo);
            }
        }


        public void Logout(object sender, EventArgs e) {
                Session.Abandon();
                Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
                Response.Redirect("login.aspx");
            }
    //control de cantidad de familiares



    protected void infoFamiliaWS(string e) {

        string Cedula = "";
        string idfamiliar = "";
        string Correo = "jgalindos";
        string CodAc = "5&5t3m4.k4kt0";

        ws.Kactus Consulta = new ws.Kactus();



        ws.ConsFamilia[] resultado = Consulta.Consulta_Familia(Cedula, idfamiliar, Correo, CodAc);

        familiares.InnerHtml = "";
        int i = 0;
        foreach (var item in resultado)
        {
            // llamado de los valores
            i++;
            nombre.InnerText = "Nombres:" + item.NOMBRES +" "+item.APELLIDOS;
            cedula.InnerText = "Cedula:" + item.COD_EMPL;
            familiares.InnerHtml += "<div id='familiar' > ";
            familiares.InnerHtml += "<div style='width: 444px; margin-left: auto; margin-right:auto; padding-top:8px; text-align:center; font-size:2em;'>Familiar</div>";
            //familiares.InnerHtml += "<div  style='float:right; width: 268px; height: 179px; margin-top: 23px;'><img alt=' src='../imagen/usuario.png' style='height: 173px; width: 204px; margin-right:2em;' /></div>";
            familiares.InnerHtml += "<div  style='margin-left:4em; width: 370px; padding-top:2em;'>Cedula:" + item.COD_FAMI + "</div>";
            familiares.InnerHtml += "<div  style='margin-left:4em; width: 370px;'>Apellidos:" + item.APE_FAMI + "</div>";
            familiares.InnerHtml += "<div  style='margin-left:4em; width: 370px;'>Nombres:" + item.NOM_FAMI + "</div>";
            familiares.InnerHtml += "<div  style='margin-left:4em; width: 370px;'>Relacion:" + item.TIP_RELA + "</div>";
            familiares.InnerHtml += "<div  style='margin-left:4em; width: 370px;'>Edad:" + item.EDAD + "</div>";
            familiares.InnerHtml += "<div  style='margin-left:4em; width: 370px;'>Fecha De Nacimiento:" + item.NACIO + "</div>";
            familiares.InnerHtml += "<div  style='margin-left:4em; width: 370px;'>Reginal:" + item.REGIONAL + "</div>";
            familiares.InnerHtml += "<div  style='margin-left:4em; width: 370px;'>Centro:" + item.CENTRO + "</div><br /><br />";          
            familiares.InnerHtml += "<div  style='margin:0 auto;' class='onoffswitch' value='"+i+ "'><input type='hidden' id='rela"+ i +"' value='" + item.TIP_RELA + "'><input type = 'checkbox' value='" + i + "' name = 'onoffswitch' class='onoffswitch-checkbox' id='myonoffswitch" + i+ "'><label class='onoffswitch-label' value='" + i + "' for='myonoffswitch" + i + "'><span class='onoffswitch-inner'></span><span class='onoffswitch-switch'></span></label></div>";
            familiares.InnerHtml += "</div> ";
        }


    }
}
