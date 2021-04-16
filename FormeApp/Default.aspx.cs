using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormeApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTriangolo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Triangolo.aspx");
        }

        protected void btnRettangolo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Rettangolo.aspx");

        }

        protected void btnCerchio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cerchio.aspx");

        }

        protected void btnQuadrato_Click(object sender, EventArgs e)
        {
            Response.Redirect("Quadrato.aspx");

        }
    }
}