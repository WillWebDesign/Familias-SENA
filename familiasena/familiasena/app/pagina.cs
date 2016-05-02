using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ws = familiasena.co.edu.sena.busdatos;


public partial class paginas : System.Web.UI.Page
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
    public void Logout()
    {
        Session.Abandon();
        Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
    }
    protected void infoFamiliaWS(string e) {

        string Cedula = "";
        string idfamiliar = "";
        string Correo = e;
        string CodAc = "5&5t3m4.k4kt0";

        ws.Kactus Consulta = new ws.Kactus();



        ws.ConsFamilia[] resultado = Consulta.Consulta_Familia(Cedula, idfamiliar, Correo, CodAc);

        //lblError.Text = "";

        foreach (var item in resultado)
        {
            // llamado de los valores

            //lblError.Text += item.COD_EMPL + "\n";
            //lblError.Text += item.COD_FAMI + "\r";
            //lblError.Text += item.TIP_RELA + "\r";
            //lblError.Text += item.EEE_MAIL + "\r";
            //lblError.Text += item.APELLIDOS + "\r";
            //lblError.Text += item.NOMBRES + "\r";
            //lblError.Text += item.APE_FAMI + "\r";
            //lblError.Text += item.NOM_FAMI + "\r";
            //lblError.Text += item.RELACION + "\r";
            //lblError.Text += item.NACIO + "\r";
            //lblError.Text += item.EDAD + "\r";
            //lblError.Text += item.DEPENDE + "\r";
            //lblError.Text += item.DISCAP + "\r";
            //lblError.Text += item.REGIONAL + "\r";
            //lblError.Text += item.CENTRO + "\r";
            //lblError.Text += item.ACTUALIZO + "\r";
            //lblError.Text += item.Nro_Registros;

        }


    }
}
