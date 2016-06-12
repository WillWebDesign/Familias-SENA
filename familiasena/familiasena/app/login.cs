using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.DirectoryServices;
using System.Web.Services;
using ws = familiasena.co.edu.sena.busdatos;
using System.Text;

public partial class login : System.Web.UI.Page
{  
     protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["key"] != null) {
            Response.Redirect("pagina.aspx");
        }
    }

    public void Logout()
    {
        Session.Abandon();
        Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
        Response.Redirect("login.aspx");
    }

    protected void enviar_Click(object sender, EventArgs e)
    {
        
        string path = @"LDAP://172.29.13.153:389";
        string dominio = @"sena.edu.co";
        string usuario = txtLogin.Text;
        string contrasena = txtPassword.Text;
        string domUsu = dominio + @"\" + usuario;

        bool permiso = autenticacion(path, domUsu, contrasena);
        if (permiso)
        {
            string Cedula = "";
            string idfamiliar = "";
            string Correo = "jgalindos";
            //string Correo = usuario;
            string CodAc = "5&5t3m4.k4kt0";

            ws.Kactus Consulta = new ws.Kactus();

            ws.ConsFamilia[] resultado = Consulta.Consulta_Familia(Cedula, idfamiliar, Correo, CodAc);

            lblError.Text = "";

            foreach (var item in resultado)
            {
                // llamado de los valores
                if (item.Nro_Registros != "0") {
                    Session["key"] = txtLogin.Text;
                    Response.Redirect("pagina.aspx");
                }
                else
                {
                    lblError.Text = "No Tiene Familiares Inscritos";
                }
            }
            
        }
        else
        {
            lblError.Text = "acceso denegado";
        }
    }

    private bool autenticacion(String path, String user, String pass)
    {

        DirectoryEntry de = new DirectoryEntry(path, user, pass);
        try
        {

            DirectorySearcher ds = new DirectorySearcher(de);
            ds.FindOne();
            return true;
        }
        catch
        {

            return false;
        }
    }
    
}