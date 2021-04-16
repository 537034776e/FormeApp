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
        public double lato;
        public double altezza;

        public double Area(double lato,double altezza)
        {
            double area = lato * altezza;
            return area;
        }

        public double Perimetro(double lato, double altezza)
        {
            double perimetro = lato * 3;
            return perimetro;
        }

        protected void btnCalcola_Click(object sender, EventArgs e)
        {
            Triangolo t = new Triangolo();
            lato = Convert.ToDouble(txtLatoTriangolo.Text);
            altezza = Convert.ToDouble(txtAltezzaTriangolo.Text);
            if(lato<0 || altezza < 0)
            {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "err", "alert('I valori non possono essere negativi o sono mancanti')", true);
            }
            else { 
            double area = t.Area(lato,altezza);
            double perimetro = t.Perimetro(lato, altezza);

            lblCalcolo.Text = "L'area e il perimetro del triangolo sono: " + area + " e " + perimetro;
            lblDimensioni.Text = "Il lato e l'altezza del triangolo sono: " + txtLatoTriangolo.Text + " e " + txtAltezzaTriangolo.Text;
            }
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
            Response.Redirect("PaginaIniziale.aspx");
        }
    }
}