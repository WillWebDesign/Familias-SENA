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
            string CodAc = "5&5t3m4.k4kt0"; 
            // lblError.Text = "bienvenido";
            // Response.Redirect("pagina.aspx");
            ws.Kactus Consulta = new ws.Kactus();

            var resultado = Consulta.Consulta_Familia(Cedula, idfamiliar, Correo, CodAc);
            //Response.Redirect("pagina.aspx");
            foreach (var item in resultado)
            {
                // hacer algo con cada item
                StringBuilder result = new StringBuilder();
                lblError.Text = item.COD_EMPL + "\r";
                lblError.Text += item.COD_FAMI+"\r";
                lblError.Text += item.TIP_RELA + "\r";
                lblError.Text += item.EEE_MAIL + "\r";
                lblError.Text += item.APELLIDOS + "\r";
                lblError.Text += item.NOMBRES + "\r";
                lblError.Text += item.APE_FAMI + "\r";
                lblError.Text += item.NOM_FAMI + "\r";
                lblError.Text += item.RELACION + "\r";
                lblError.Text += item.NACIO + "\r";
                lblError.Text += item.EDAD + "\r";
                lblError.Text += item.DEPENDE + "\r";
                lblError.Text += item.DISCAP + "\r";
                lblError.Text += item.REGIONAL + "\r";
                lblError.Text += item.CENTRO + "\r";
                lblError.Text += item.ACTUALIZO + "\r";
                lblError.Text += item.Nro_Registros;

            }

        }
        else
        {
            lblError.Text = "acceso denegado";
        }

        ws.Kactus consulta = new ws.Kactus();
       
  
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