using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormeApp
{
    public partial class Cerchio : System.Web.UI.Page, Forma
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public double raggio;
        double Forma.Area()
        {
            throw new NotImplementedException();
        }

        double Forma.Perimetro()
        {
            throw new NotImplementedException();
        }


        public double Area(double raggio)
        {
            double area = 3.14*raggio*raggio;
            return area;
        }

        public double Perimetro(double raggio)
        {
            double perimetro = 2*3.14*raggio;
            return perimetro;
        }

        protected void btnCalcola_Click(object sender, EventArgs e)
        {
            Cerchio c = new Cerchio();
            raggio = Convert.ToDouble(txtRaggioCerchio.Text);
            if (raggio < 0)
            {
              
                ScriptManager.RegisterStartupScript(this, this.GetType(), "err", "alert('I valori non possono essere negativi o sono mancanti')", true);
           
            }
            else
            {
                double area = c.Area(raggio);
                double perimetro = c.Perimetro(raggio);

                lblCalcolo.Text = "L'area e la circonferenza del cerchio sono: " + area + " e " + perimetro;
                lblDimensioni.Text = "Il raggio del cerchio è : " + txtRaggioCerchio.Text;
            }

        }

        protected void btnIndietro_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaIniziale.aspx");

        }
    }
}