using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JGualpaS2D
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Operacion : ContentPage
    {
        public Operacion()
        {
            InitializeComponent();
        }

        private void btnCarcularUno_Clicked(object sender, EventArgs e)
        {
            double SegUno = Convert.ToDouble(txtSegUno.Text) * 0.3;
            double ExamUno = Convert.ToDouble(txtExamUno.Text) * 0.2;
            double NotaParcialUno = Convert.ToDouble(txtNotaParcialUno.Text);



            double suma = SegUno + ExamUno;
            txtNotaParcialUno.Text = suma.ToString();
            //lblNotaParcialUno.Text = SegUno.ToString();
        }

        private void btnCarcularDos_Clicked(object sender, EventArgs e)
        {
            double SegDos = Convert.ToDouble(txtSegDos.Text) * 0.3;
            double ExamDos = Convert.ToDouble(txtExamDos.Text) * 0.2;
            double NotaParcialDos = Convert.ToDouble(txtNotaParcialDos.Text);



            double suma = SegDos + ExamDos;
            txtNotaParcialDos.Text = suma.ToString();
            //lblNotaParcialDos.Text = SegDos.ToString();
        }

        private void btnEstado_Clicked(object sender, EventArgs e)
        {
            double NotaParcialUno = Convert.ToDouble(txtNotaParcialUno.Text);
            double NotaParcialDos = Convert.ToDouble(txtNotaParcialDos.Text);

            double NotaFinal = NotaParcialUno + NotaParcialDos;
            txtEstado.Text = NotaFinal.ToString();

            if (NotaFinal < 5.0)
            {
                DisplayAlert("ESTADO DEL NIVEL", "REPROBADO", "Cerrar");
            }
            else
            {
                if (NotaFinal < 7)
                {
                    DisplayAlert("ESTADO DEL NIVEL", "COMPLEMENTARIO", "Cerrar");
                }
                else
                {
                    DisplayAlert("ESTADO DEL NIVEL", "APROBADO", "Cerrar");
                }
            }                

            

        }
        private void btnlimpiar_Clicked(object sender, EventArgs e)
        {

            txtSegUno.Text = "";
            txtExamUno.Text = "";
            txtNotaParcialUno.Text = "";
            txtSegDos.Text = "";
            txtExamDos.Text = "";
            txtNotaParcialDos.Text = "";
            txtEstado.Text = "";
        }
    }
}