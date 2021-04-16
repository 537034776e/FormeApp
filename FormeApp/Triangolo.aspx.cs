using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormeApp
{
    public partial class Triangolo : System.Web.UI.Page, Forma
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
 
        double Forma.Perimetro()
        {
            throw new NotImplementedException();
        }

        double Forma.Area()
        {
            throw new NotImplementedException();
        }

        protected void btnIndietro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnEquilatero_Click(object sender, EventArgs e)
        {
            Response.Redirect("TriangoloEquilatero.aspx");
        }

        protected void btnIsoscele_Click(object sender, EventArgs e)
        {
            Response.Redirect("TriangoloIsoscele.aspx");

        }

        protected void btnScaleno_Click(object sender, EventArgs e)
        {
            Response.Redirect("TriangoloScaleno.aspx");

        }

    }
}