using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormeApp
{
    public partial class Quadrato : Rettangolo, Forma
    {
        public new double lato;

        public double Area(double lato)
        {
            double area = lato * lato;
            return area;
        }

        public double Perimetro(double lato)
        {
            double perimetro = lato * 4;
            return perimetro;
        }

        protected new void btnCalcola_Click(object sender, EventArgs e)
        {
            Quadrato q = new Quadrato();
            lato = Convert.ToDouble(txtLatoQuadrato.Text);
            if (lato < 0)
            {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "err", "alert('I valori non possono essere negativi o sono mancanti')", true);
            }
            else
            {
                double area = q.Area(lato);
                double perimetro = q.Perimetro(lato);


                lblCalcolo.Text = "L'area e il perimetro del quadrato sono: " + area + " e " + perimetro;
                lblDimensioni.Text = "Il lato del quadrato è: " + txtLatoQuadrato.Text;
            }

        }

        protected new void btnIndietro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");

        }
    }
}