using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormeApp
{
    public partial class TriangoloIsoscele : Triangolo, Forma
    {
        protected new void Page_Load(object sender, EventArgs e)
        {

        }
        public double lato;
        public double lato2;
        public double altezza;

        public double Area(double lato, double altezza)
        {
            double area = (lato * altezza) / 2;
            return area;
        }

        public double Perimetro(double lato, double lato2)
        {
            double perimetro = (lato2*2)+lato;
            return perimetro;
        }

        protected new void btnIndietro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Triangolo.aspx");
        }

        protected void btnCalcola_Click(object sender, EventArgs e)
        {
            TriangoloIsoscele ti = new TriangoloIsoscele();
            lato = Convert.ToDouble(txtLatoTriangolo.Text);
            lato2 = Convert.ToDouble(txtLato2Triangolo.Text);
            altezza = Convert.ToDouble(txtAltezzaTriangolo.Text);
            double calcolo_altezza = Math.Sqrt(Math.Pow(Convert.ToDouble(txtLato2Triangolo.Text), 2) - Math.Pow((Convert.ToDouble(txtLatoTriangolo.Text)) / 2, 2));
            if (lato < 0 || altezza < 0 || lato2 <0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "err", "alert('I valori non possono essere negativi o sono mancanti')", true);
            }

            else if (altezza != calcolo_altezza)
            {
                txtAltezzaTriangolo.Text = calcolo_altezza.ToString();
                lblAltezza.Text = "L'altezza è stata ricalcolata in base al valore del lato";
                double area = ti.Area(lato, calcolo_altezza);
                double perimetro = ti.Perimetro(lato, lato2);

                lblCalcolo.Text = "L'area e il perimetro del triangolo sono: " + area + " e " + perimetro;
                lblDimensioni.Text = "Il primo lato, il secondo lato e l'altezza del triangolo sono: " + txtLatoTriangolo.Text + " , " + txtLato2Triangolo.Text+" e "+ txtAltezzaTriangolo.Text;

            }
        }
    }
}