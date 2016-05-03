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


        public void Logout() {
                Session.Abandon();
                Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
            }
    //control de cantidad de familiares



    protected void infoFamiliaWS(string e) {

        string Cedula = "";
        string idfamiliar = "";
        string Correo = "jgalindos";
        string CodAc = "5&5t3m4.k4kt0";

        ws.Kactus Consulta = new ws.Kactus();



        ws.ConsFamilia[] resultado = Consulta.Consulta_Familia(Cedula, idfamiliar, Correo, CodAc);

        contenido.InnerHtml = "";
        int i = 0;
        foreach (var item in resultado)
        {
            // llamado de los valores
            i++;
            contenido.InnerHtml += "<h6>" + item.COD_EMPL + "</h6>";
            contenido.InnerHtml += "<h6>" + item.COD_FAMI + "</h6>";
            contenido.InnerHtml += "<h6>" + item.TIP_RELA + "</h6>";
            contenido.InnerHtml += "<h6>" + item.EEE_MAIL + "</h6>";
            contenido.InnerHtml += "<h6>" + item.APELLIDOS + "</h6>";
            contenido.InnerHtml += "<h6>" + item.NOMBRES + "</h6>";
            contenido.InnerHtml += "<h6>" + item.APE_FAMI + "</h6>";
            contenido.InnerHtml += "<h6>" + item.NOM_FAMI + "</h6>";
            contenido.InnerHtml += "<h6>" + item.RELACION + "</h6>";
            contenido.InnerHtml += "<h6>" + item.NACIO + "</h6>";
            contenido.InnerHtml += "<h6>" + item.EDAD + "</h6>";
            contenido.InnerHtml += "<h6>" + item.DEPENDE + "</h6>";
            contenido.InnerHtml += "<h6>" + item.DISCAP + "</h6>";
            contenido.InnerHtml += "<h6>" + item.REGIONAL + "</h6>";
            contenido.InnerHtml += "<h6>" + item.CENTRO + "</h6>";
            contenido.InnerHtml += "<h6>" + item.ACTUALIZO + "</h6>";
            contenido.InnerHtml += "<h6>" + item.Nro_Registros + "</h6>";
            contenido.InnerHtml += "<div class='onoffswitch' OnClick='check_Click' Value='"+item.COD_FAMI+"'><input type = 'checkbox' name = 'onoffswitch' class='onoffswitch-checkbox' id='myonoffswitch" + i+ "'><label class='onoffswitch-label' for='myonoffswitch" + i + "'><span class='onoffswitch-inner'></span><span class='onoffswitch-switch'></span></label></div>";

        }


    }
}
