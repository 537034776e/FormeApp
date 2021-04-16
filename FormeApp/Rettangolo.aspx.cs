using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormeApp
{
    public partial class Rettangolo : System.Web.UI.Page, Forma
    {
        public double lato;
        public double altezza;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public double Area()
        {
            throw new NotImplementedException();
        }

        public double Perimetro()
        {
            throw new NotImplementedException();
        }

       

        public double Area(double lato, double altezza)
        {
            double area = lato * altezza;
            return area;
        }

        public double Perimetro(double lato, double altezza)
        {
            double perimetro = (lato+altezza) * 2;
            return perimetro;
        }

        protected void btnCalcola_Click(object sender, EventArgs e)
        {
            Rettangolo r = new Rettangolo();
            lato = Convert.ToDouble(txtLatoRettangolo.Text);
            altezza = Convert.ToDouble(txtAltezzaRettangolo.Text);
            if (lato < 0 || altezza < 0)
            {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "err", "alert('I valori non possono essere negativi o sono mancanti')", true);
            }
            else
            {
                double area = r.Area(lato, altezza);
                double perimetro = r.Perimetro(lato, altezza);

                lblCalcolo.Text = "L'area e il perimetro del rettangolo sono: " + area + " e " + perimetro;
                lblDimensioni.Text = "Il lato e l'altezza del rettangolo sono: " + txtLatoRettangolo.Text + " e " + txtAltezzaRettangolo.Text;
            }

        }

        protected void btnIndietro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}