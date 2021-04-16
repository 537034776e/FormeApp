using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormeApp
{
    public partial class TriangoloScaleno : Triangolo, Forma
    {
        protected new void Page_Load(object sender, EventArgs e)
        {

        }
        public double lato;
        public double lato2;
        public double lato3;
        
        public double Area(double lato, double lato2, double lato3)
        {
            double area = Math.Sqrt((lato + lato2 + lato3) * (lato2 + lato3) * (lato + lato3) * (lato + lato2));
            return area;
        }

        public double Perimetro(double lato, double lato2,double lato3)
        {
            double perimetro = lato+lato2+lato3;
            return perimetro;
        }

        protected new void btnIndietro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Triangolo.aspx");
        }

        protected void btnCalcola_Click(object sender, EventArgs e)
        {
            TriangoloScaleno ts = new TriangoloScaleno();
            lato = Convert.ToDouble(txtLatoTriangolo.Text);
            lato2 = Convert.ToDouble(txtLato2Triangolo.Text);
            lato3 = Convert.ToDouble(txtLato3Triangolo.Text);
            if (lato < 0 || lato3 < 0 || lato2 < 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "err", "alert('I valori non possono essere negativi o sono mancanti')", true);
            }

            else
            {
                double area = ts.Area(lato, lato2,lato3);
                double perimetro = ts.Perimetro(lato, lato2,lato3);

                lblCalcolo.Text = "L'area e il perimetro del triangolo sono: " + area + " e " + perimetro;
                lblDimensioni.Text = "Il primo lato, il secondo lato e l'altezza del triangolo sono: " + txtLatoTriangolo.Text + " , " + txtLato2Triangolo.Text + " e " + txtLato3Triangolo.Text;

            }
        }
    }
}