using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormeApp
{
    public partial class TriangoloEquilatero : Triangolo, Forma
    {
        protected new void Page_Load(object sender, EventArgs e)
        {

        }
        public double lato;
        public double altezza;

        public double Area(double lato, double altezza)
        {
            double area = (lato * altezza) / 2;
            return area;
        }

        public double Perimetro(double lato)
        {
            double perimetro = lato * 3;
            return perimetro;
        }

        protected void btnCalcola_Click(object sender, EventArgs e)
        {
            TriangoloEquilatero t = new TriangoloEquilatero();
            lato = Convert.ToDouble(txtLatoTriangolo.Text);
            altezza = Convert.ToDouble(txtAltezzaTriangolo.Text);
            double calcolo_altezza = Math.Sqrt(Math.Pow(Convert.ToDouble(txtLatoTriangolo.Text), 2) - Math.Pow((Convert.ToDouble(txtLatoTriangolo.Text)) / 2, 2));
            if (lato < 0 || altezza < 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "err", "alert('I valori non possono essere negativi o sono mancanti')", true);
            }

            else if (altezza != calcolo_altezza)
            {
                txtAltezzaTriangolo.Text = calcolo_altezza.ToString();
                lblAltezza.Text = "L'altezza è stata ricalcolata in base al valore del lato";
                double area = t.Area(lato, calcolo_altezza);
                double perimetro = t.Perimetro(lato);

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

        protected new void btnIndietro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Triangolo.aspx");
        }

    }
}